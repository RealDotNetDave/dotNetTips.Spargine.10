## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.MeasureActionPrintFalse()
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbx,[rcx+148]
       mov       rcx,181FBC021A8
       mov       rsi,[rcx]
       test      rsi,rsi
       mov       [rsp+20],rsi
       je        near ptr M00_L04
M00_L00:
       cmp       [rbx],bl
       lea       rcx,[rsp+30]
       mov       rax,7FF9B1FD5F50
       call      rax
       mov       rbx,[rsp+30]
       cmp       dword ptr [7FF9799839A0],0
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintFalse>b__5_0()
       mov       rsi,[rsp+20]
       cmp       [rsi+18],rcx
       jne       near ptr M00_L06
M00_L02:
       lea       rcx,[rsp+28]
       mov       rax,7FF9B1FD5F50
       call      rax
       mov       rax,[rsp+28]
       sub       rax,rbx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rax,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FF91A136C30]
       cmovb     rax,rcx
       mov       rbx,rax
       cmp       dword ptr [7FF9799839A0],0
       jne       short M00_L07
M00_L03:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L04:
       mov       rcx,offset MT_System.Action
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,181FBC021A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintFalse>b__5_0()
       call      qword ptr [7FF919A46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,181FBC021A8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       jmp       near ptr M00_L00
M00_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L06:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M00_L02
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L03
; Total bytes of code 304
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintFalse>b__5_0()
       ret
; Total bytes of code 1
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF91A06F5B8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.MeasureActionPrintTrue()
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbx,[rcx+148]
       mov       rcx,20187800178
       mov       rsi,[rcx]
       test      rsi,rsi
       mov       [rsp+20],rsi
       je        near ptr M00_L04
M00_L00:
       cmp       [rbx],bl
       lea       rcx,[rsp+30]
       mov       rax,7FF9B1FD5F50
       call      rax
       mov       rbx,[rsp+30]
       cmp       dword ptr [7FF9799839A0],0
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintTrue>b__6_0()
       mov       rsi,[rsp+20]
       cmp       [rsi+18],rcx
       jne       near ptr M00_L06
M00_L02:
       lea       rcx,[rsp+28]
       mov       rax,7FF9B1FD5F50
       call      rax
       mov       rax,[rsp+28]
       sub       rax,rbx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rax,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FF919AE35E0]
       cmovb     rax,rcx
       mov       rbx,rax
       cmp       dword ptr [7FF9799839A0],0
       jne       short M00_L07
M00_L03:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L04:
       mov       rcx,offset MT_System.Action
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20187800168
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintTrue>b__6_0()
       call      qword ptr [7FF919A36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20187800178
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       jmp       near ptr M00_L00
M00_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L06:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M00_L02
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L03
; Total bytes of code 304
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintTrue>b__6_0()
       ret
; Total bytes of code 1
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF91A0E48B8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.SaveAsJsonToFileNoMethod()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1C8
       vzeroupper
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rsi,rcx
       lea       rcx,[rbp-198]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-160],rax
       mov       rcx,rsp
       mov       [rbp-180],rcx
       mov       rcx,rbp
       mov       [rbp-170],rcx
       mov       rbx,[rsi+148]
       mov       [rbp-1C0],rbx
       mov       rcx,[rsi+140]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L46
       mov       rcx,[rcx+10]
       cmp       [rbx],bl
       test      rcx,rcx
       je        near ptr M00_L35
       mov       [rbp-40],rcx
       mov       rcx,2A71C001E98
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L36
M00_L01:
       mov       r15,[r14+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,[r15+0C0]
       mov       rax,2E7B0EBB5F0
       cmp       rcx,rax
       je        short M00_L05
M00_L02:
       xor       r15d,r15d
       cmp       byte ptr [r14+9E],0
       je        short M00_L04
       mov       rcx,[r14+8]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L03:
       cmp       [rcx],cl
       mov       rdx,2E7B0EBB5F0
       call      qword ptr [7FF919E3D788]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L38
       mov       r15,[rax+8]
       test      r15,r15
       je        short M00_L04
       cmp       byte ptr [r15+119],2
       jne       near ptr M00_L39
M00_L04:
       test      r15,r15
       je        near ptr M00_L34
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r14,r15
       test      r14,r14
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L40
M00_L06:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-50]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF91A114510]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L41
       mov       rcx,[rcx+240]
       mov       r13,[rcx+48]
       test      r13,r13
       je        near ptr M00_L41
M00_L07:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M00_L08
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2E7B0EB62A0
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
M00_L08:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L43
       mov       rcx,2A71C001E50
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF91A052F70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L09:
       mov       [rbp-68],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-1C8],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-44]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L13
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L10:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L44
       mov       r15,2E7B0EB1518
M00_L11:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L12
       mov       dword ptr [r13+78],3E8
M00_L12:
       mov       [rbp-1D0],r13
       jmp       near ptr M00_L20
M00_L13:
       mov       eax,2
       jmp       short M00_L10
M00_L14:
       mov       rcx,[rax+8]
       mov       [rbp-1C8],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L18
M00_L15:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-1C8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-44]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L19
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L16:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L42
       mov       rsi,2E7B0EB1518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r15d
       call      qword ptr [7FF91A1145A0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L15
M00_L19:
       mov       eax,2
       jmp       short M00_L16
M00_L20:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L28
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       jne       near ptr M00_L29
M00_L21:
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
       mov       rcx,[r14+0B8]
       cmp       dword ptr [rcx+8C],0
       jne       near ptr M00_L30
M00_L22:
       lea       rcx,[rbp-108]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91A114648]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L23:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91A1150C8]; System.Text.Json.Utf8JsonWriter.Flush()
M00_L24:
       xor       ecx,ecx
       mov       [rbp-110],rcx
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       mov       rax,[rcx]
       mov       edx,[rcx+8]
       mov       r8d,edx
       mov       ecx,[rcx+0C]
       sub       ecx,edx
       test      rax,rax
       je        short M00_L25
       mov       edx,r8d
       mov       r10d,ecx
       add       rdx,r10
       mov       r10d,[rax+8]
       cmp       rdx,r10
       ja        short M00_L27
       mov       r8d,r8d
       lea       rax,[rax+r8+10]
       jmp       short M00_L26
M00_L25:
       or        r8d,ecx
       jne       short M00_L27
       xor       eax,eax
       xor       ecx,ecx
M00_L26:
       mov       [rbp-1A8],rax
       mov       [rbp-1A0],ecx
       lea       rcx,[rbp-1A8]
       call      qword ptr [7FF919FA6478]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-1D8],rax
       jmp       near ptr M00_L31
M00_L27:
       call      qword ptr [7FF919B97198]
       int       3
M00_L28:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L23
M00_L29:
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L21
       mov       rcx,[r14+0B8]
       lea       r8,[rbp-110]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A254E58]
       test      eax,eax
       je        near ptr M00_L21
       mov       rcx,[rbp-110]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[rbp-110]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L24
M00_L30:
       mov       rcx,[rcx+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-0E8],rax
       jmp       near ptr M00_L22
M00_L31:
       call      M00_L47
       nop
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-120],xmm0
       lea       rcx,[rbp-130]
       mov       rax,7FF91A0559A8
       mov       [rbp-188],rax
       lea       rax,[M00_L32]
       mov       [rbp-178],rax
       mov       rax,[rbp-160]
       lea       rdx,[rbp-198]
       mov       [rax+8],rdx
       mov       rax,[rbp-160]
       mov       byte ptr [rax+4],0
       mov       rax,7FF9B1700930
       call      rax
M00_L32:
       mov       rcx,[rbp-160]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M00_L33
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-190]
       mov       [rcx+8],rdx
       test      eax,eax
       jne       near ptr M00_L45
       vmovups   xmm0,[rbp-130]
       vmovups   [rbp-120],xmm0
       mov       rcx,2E7B0EBB220
       call      qword ptr [7FF919C4E3D0]; System.String.IsNullOrEmpty(System.String)
       mov       ecx,20
       mov       edx,24
       test      eax,eax
       cmovne    ecx,edx
       call      qword ptr [7FF919A26670]; System.String.FastAllocateString(IntPtr)
       mov       rbx,rax
       cmp       [rbx],bl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-140],xmm0
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       rcx,[rbp-140]
       call      qword ptr [7FF91A256BE0]; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       rsi,[rbp-140]
       mov       edi,[rbp-138]
       lea       rcx,[rbp-158]
       mov       rdx,2E7B0EBB220
       call      qword ptr [7FF919E37AC8]; System.MemoryExtensions.AsSpan(System.String)
       mov       [rbp-1B8],rsi
       mov       [rbp-1B0],edi
       lea       rdx,[rbp-1B8]
       lea       rcx,[rbp-120]
       lea       r8,[rbp-148]
       lea       r9,[rbp-158]
       call      qword ptr [7FF919A271C8]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       rcx,rbx
       mov       rdx,2E7B0EC0810
       call      qword ptr [7FF919A27840]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rbx,[rbp-1C0]
       mov       rcx,[rbx+8]
       call      qword ptr [7FF919DAE4C0]; System.IO.Path.Combine(System.String, System.String)
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FF91A04DAB8]; System.IO.File.WriteAllText(System.String, System.String)
       mov       rax,rbx
       add       rsp,1C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rdx,[r14+20]
       mov       rcx,2E7B0EBB5F0
       call      qword ptr [7FF91A2548B8]
       int       3
M00_L35:
       call      qword ptr [7FF919FAEC88]
       mov       ecx,58B
       mov       rdx,7FF919CF4A80
       call      qword ptr [7FF919C477B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF919CF5550
       call      qword ptr [7FF919C477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FF919CF4A80
       call      qword ptr [7FF919C477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A256BC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A11CB28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FF919E37A38]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FF919E3D260]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L38:
       call      qword ptr [7FF91A2548A0]
       int       3
M00_L39:
       mov       rcx,r15
       call      qword ptr [7FF919F36EF8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L40:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L41:
       mov       ecx,9
       call      qword ptr [7FF91A117DC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L42:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A71C0023E0
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L43:
       mov       rax,2E7B0EB62A0
       jmp       near ptr M00_L09
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A71C0023E0
       mov       r15,[rcx]
       jmp       near ptr M00_L11
M00_L45:
       mov       ecx,eax
       call      qword ptr [7FF91A255428]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       sub       rsp,28
       vzeroupper
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M00_L48
       mov       rcx,[rcx+240]
       mov       r13,[rcx+48]
       test      r13,r13
       jne       short M00_L49
M00_L48:
       mov       ecx,9
       call      qword ptr [7FF91A117DC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M00_L49:
       mov       rbx,[r13+10]
       xor       ecx,ecx
       mov       rdx,[rbp-1D0]
       mov       [rdx+34],ecx
       mov       [rdx+20],rcx
       mov       [rdx+40],rcx
       mov       [rdx+48],rcx
       mov       byte ptr [rdx+38],0
       mov       word ptr [rdx+39],0
       mov       [rdx+28],ecx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+60],rcx
       mov       [rdx+68],cx
       mov       [rdx+6A],cl
       mov       byte ptr [rdx+3B],0
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       xor       edx,edx
       mov       [rcx+8],edx
       mov       [rcx+0C],edx
       mov       rdx,[rcx]
       mov       r8,2E7B0EB62A0
       mov       [rcx],r8
       cmp       byte ptr [rcx+10],0
       je        short M00_L50
       cmp       dword ptr [rdx+8],0
       je        short M00_L50
       mov       rcx,2A71C001E50
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF91A052F78]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M00_L50:
       dec       dword ptr [rbx+18]
       add       rsp,28
       ret
; Total bytes of code 2460
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       call      qword ptr [7FF97D738540]
       mov       rbp,[rax]
       test      rbp,rbp
       je        short M01_L01
M01_L00:
       mov       rcx,rdi
       call      qword ptr [7FF97D7384C0]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9,rbx
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       call      qword ptr [7FF97D73A0D0]
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF97D73ACF8]
       call      qword ptr [7FF97D738540]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 106
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
       jne       near ptr M02_L10
       and       esi,0FFFFFFF7
M02_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M02_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M02_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M02_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M02_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M02_L14
M02_L02:
       mov       rcx,2E7B0EC1650
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],1
       jne       short M02_L03
       cmp       word ptr [r8+0C],0A
       je        short M02_L04
M02_L03:
       mov       rcx,2E7B0EB1518
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],2
       jne       short M02_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L08
M02_L04:
       mov       rcx,2E7B0EB1518
       cmp       r8,rcx
       je        short M02_L05
       cmp       dword ptr [r8+8],2
       jne       short M02_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L09
M02_L05:
       and       esi,0FFFFFFFB
M02_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       r8d,2
       jmp       near ptr M02_L01
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF919E59F30
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A254C90]
       int       3
M02_L09:
       or        esi,4
       jmp       short M02_L06
M02_L10:
       cmp       edx,9
       je        short M02_L11
       mov       ecx,38A0
       mov       rdx,7FF919E59F30
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A254C48]
       int       3
M02_L11:
       or        esi,8
       jmp       near ptr M02_L00
M02_L12:
       mov       ecx,38A0
       mov       rdx,7FF919E59F30
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF91A254C60]
       int       3
M02_L13:
       mov       ecx,38A0
       mov       rdx,7FF919E59F30
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A254C78]
       int       3
M02_L14:
       mov       r8,2E7B0EB1518
       mov       [rcx+50],r8
       jmp       near ptr M02_L02
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
       mov       rcx,2A71C000C90
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
       jle       short M03_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M03_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M03_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M03_L03
M03_L01:
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
M03_L02:
       mov       ecx,0A
       call      qword ptr [7FF91A117DC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       mov       rcx,r14
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A11C408]
       jmp       short M03_L01
M03_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M03_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M03_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91996B184],0
       je        short M03_L05
       call      qword ptr [7FF91A11C420]
       mov       ebx,eax
       jmp       short M03_L07
M03_L05:
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M03_L06
       call      qword ptr [7FF91A11C450]
       mov       ebx,eax
       jmp       short M03_L07
M03_L06:
       sar       ebx,10
M03_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF91996B178]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M03_L11
M03_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M03_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF919F3DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M03_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M03_L09:
       mov       rcx,r13
       call      qword ptr [7FF919A26820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M03_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M03_L10
       xor       ebx,ebx
M03_L10:
       inc       r15d
M03_L11:
       cmp       [r14+8],r15d
       jg        short M03_L08
       jmp       short M03_L13
M03_L12:
       mov       r14,r12
       jmp       short M03_L14
M03_L13:
       xor       r14d,r14d
M03_L14:
       test      r14,r14
       je        short M03_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       mov       rcx,r14
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A11C408]
       jmp       near ptr M03_L01
M03_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M03_L18
M03_L16:
       test      ebx,ebx
       jne       short M03_L17
       mov       rax,2E7B0EB62A0
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
M03_L17:
       mov       ecx,ebx
       mov       rdx,2E7B0EB6F28
       call      qword ptr [7FF919C4D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M03_L18:
       cmp       ebx,800
       jge       short M03_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M03_L20
M03_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF91A1145E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A11C408]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF91A11C480]
       jmp       near ptr M03_L01
M03_L21:
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
       jne       near ptr M04_L23
       mov       rcx,2A71C001E50
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,2A71C000C90
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
       jle       short M04_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M04_L04
M04_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M04_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M04_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M04_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M04_L05
M04_L01:
       mov       rdx,r13
M04_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L03:
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
M04_L04:
       mov       ecx,0A
       call      qword ptr [7FF91A117DC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L05:
       mov       rcx,r13
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A11C408]
       jmp       short M04_L01
M04_L06:
       mov       rcx,[rdi+10]
       cmp       [rcx+8],r15d
       jbe       near ptr M04_L18
       mov       eax,r15d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M04_L17
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91996B184],0
       je        short M04_L07
       call      qword ptr [7FF91A11C420]
       mov       ebp,eax
       jmp       short M04_L09
M04_L07:
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M04_L08
       call      qword ptr [7FF91A11C450]
       mov       ebp,eax
       jmp       short M04_L09
M04_L08:
       sar       ebp,10
M04_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FF91996B178]
       mov       esi,edx
       xor       ebp,ebp
       jmp       short M04_L13
M04_L10:
       cmp       esi,[r13+8]
       jae       near ptr M04_L29
       mov       ecx,esi
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF919F3DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M04_L11
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M04_L11:
       mov       rcx,r12
       call      qword ptr [7FF919A26820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M04_L14
       inc       esi
       cmp       [r13+8],esi
       jne       short M04_L12
       xor       esi,esi
M04_L12:
       inc       ebp
M04_L13:
       cmp       [r13+8],ebp
       jg        short M04_L10
       jmp       short M04_L15
M04_L14:
       mov       r13,r12
       jmp       short M04_L16
M04_L15:
       xor       r13d,r13d
M04_L16:
       test      r13,r13
       je        short M04_L17
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       mov       rcx,r13
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A11C408]
       jmp       near ptr M04_L01
M04_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M04_L20
M04_L18:
       test      ebp,ebp
       jne       short M04_L19
       mov       rdx,2E7B0EB62A0
       jmp       near ptr M04_L02
M04_L19:
       mov       ecx,ebp
       mov       rdx,2E7B0EB6F28
       call      qword ptr [7FF919C4D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M04_L20:
       cmp       ebp,800
       jge       short M04_L21
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M04_L22
M04_L21:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF91A1145E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M04_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A11C408]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF91A11C480]
       jmp       near ptr M04_L01
M04_L23:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M04_L24
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF919B9DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M04_L03
M04_L24:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M04_L25
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A11FD68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L25:
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
       jne       short M04_L26
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M04_L27
M04_L26:
       mov       rcx,2A71C001E50
       mov       rcx,[rcx]
       call      qword ptr [7FF91A052F70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M04_L27:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M04_L28
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF919B9DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M04_L28:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M04_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M04_L03
       mov       rcx,2A71C001E50
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
       jmp       qword ptr [7FF91A052F78]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M04_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       jge       near ptr M05_L20
       cmp       byte ptr [rsi+17],0
       jne       short M05_L00
       cmp       qword ptr [rdi],0
       je        near ptr M05_L21
M05_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M05_L10
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M05_L22
M05_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M05_L26
       test      r8,r8
       je        near ptr M05_L07
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M05_L23
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M05_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,2A71C001458
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
       jmp       short M05_L03
M05_L02:
       mov       eax,0FFFFFFFF
M05_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M05_L05
       test      byte ptr [rbx+7C],2
       je        near ptr M05_L24
M05_L04:
       mov       rcx,[rbp+30]
       test      byte ptr [rbx+7C],1
       je        near ptr M05_L25
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF91A114A80]; System.Text.Json.Utf8JsonWriter.WriteStringIndented(System.ReadOnlySpan`1<Char>)
       jmp       short M05_L06
M05_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF91A114AB0]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M05_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       call      qword ptr [7FF91A114DB0]
M05_L08:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M05_L27
M05_L09:
       mov       eax,1
       jmp       near ptr M05_L34
M05_L10:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M05_L16
       cmp       byte ptr [rcx+8E],1
       je        short M05_L16
       cmp       dword ptr [rcx+40],0
       jne       short M05_L11
       mov       r8,[rcx+68]
       jmp       short M05_L13
M05_L11:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M05_L28
M05_L12:
       mov       r8,r13
       mov       rcx,[rbp+30]
M05_L13:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M05_L29
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M05_L29
       xor       r13d,r13d
M05_L14:
       test      r15d,r15d
       jne       short M05_L15
       cmp       dword ptr [r14+8C],0
       jne       near ptr M05_L30
M05_L15:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M05_L31
M05_L16:
       call      qword ptr [7FF91A114678]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M05_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF919F681B8]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M05_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF91A114C00]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M05_L18
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M05_L32
M05_L18:
       mov       rcx,[rbp+30]
       mov       eax,r15d
       jmp       near ptr M05_L34
M05_L19:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M05_L17
M05_L20:
       mov       ecx,[r14+88]
       call      qword ptr [7FF91A114D80]
       int       3
M05_L21:
       mov       rcx,rbx
       call      qword ptr [7FF91A114DB0]
       jmp       near ptr M05_L09
M05_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M05_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF919FA6370]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M05_L08
M05_L23:
       mov       ecx,edi
       call      qword ptr [7FF91A254288]
       int       3
M05_L24:
       mov       rcx,rbx
       call      qword ptr [7FF91A2542A0]
       test      eax,eax
       jne       near ptr M05_L04
       mov       rcx,rbx
       call      qword ptr [7FF91A2542B8]
       jmp       near ptr M05_L04
M05_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF91A2542D0]
       jmp       near ptr M05_L06
M05_L26:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M05_L08
M05_L27:
       mov       rcx,rsi
       call      qword ptr [7FF91A114D20]
       int       3
M05_L28:
       mov       rcx,r13
       call      qword ptr [7FF919F36EF8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M05_L12
M05_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF91A2541B0]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M05_L14
M05_L30:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF91A2541C8]
       test      eax,eax
       je        near ptr M05_L15
       jmp       near ptr M05_L09
M05_L31:
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
       je        near ptr M05_L18
       cmp       byte ptr [rcx+8F],0
       je        near ptr M05_L18
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M05_L33
M05_L32:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L33:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M05_L18
M05_L34:
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
       jne       short M05_L35
       call      qword ptr [7FF91A254EB8]
M05_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M05_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M05_L36
       mov       rcx,rsi
       call      qword ptr [7FF91A254ED0]
       test      rax,rax
       jne       near ptr M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF91A254EE8]
       jmp       near ptr M05_L39
M05_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2E7B0EBF0E0
       cmp       [rcx],ecx
       call      qword ptr [7FF91A254F18]
       test      eax,eax
       jne       short M05_L39
       jmp       short M05_L38
M05_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2E7B0EBF090
       call      qword ptr [7FF919C44F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF91A254F00]
       jmp       short M05_L39
M05_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF91A254F30]
M05_L39:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1293
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
       call      qword ptr [7FF91A2553C8]
       int       3
M06_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A27D2A8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A2553F8]
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
       call      qword ptr [7FF91A255410]
M06_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M06_L02
M06_L06:
       mov       r11,7FF919970CB0
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
       mov       r8,2A71C001430
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
       call      qword ptr [7FF919B94C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FF9796CA1D0
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
       call      qword ptr [7FF919B94C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,2E7B0EB0008
M07_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF919FAE430]
       int       3
M07_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF919FAE400]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF919FAE448]
       int       3
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF919FAE430]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF919FA6298]
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
       call      qword ptr [7FF919FAE688]
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
       call      qword ptr [7FF91A1169D0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M08_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M08_L00:
       mov       eax,1
       ret
; Total bytes of code 22
```
```assembly
; System.String.FastAllocateString(IntPtr)
       mov       rdx,rcx
       mov       rcx,offset MT_System.String
       jmp       near ptr 00007FF9796CA1D0
; Total bytes of code 18
```
```assembly
; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
```
```assembly
; System.MemoryExtensions.AsSpan(System.String)
       test      rdx,rdx
       jne       short M11_L01
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rcx+8],rdx
M11_L00:
       mov       rax,rcx
       ret
M11_L01:
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       jmp       short M11_L00
; Total bytes of code 33
```
```assembly
; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r9]
       mov       r10d,[r9+8]
       test      r10d,r10d
       je        near ptr M12_L12
       cmp       r10d,1
       jne       near ptr M12_L08
       movzx     eax,word ptr [rax]
       or        eax,20
       cmp       eax,64
       jle       near ptr M12_L09
       cmp       eax,6E
       jne       near ptr M12_L11
       mov       ebx,20
M12_L00:
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       movzx     r10d,bl
       cmp       r10d,edx
       jg        near ptr M12_L15
       mov       [r8],r10d
       sar       ebx,8
       mov       [rsp+28],rax
       mov       r8,rax
       test      bl,bl
       jne       near ptr M12_L16
M12_L01:
       sar       ebx,8
       vmovups   xmm0,[rcx]
       vmovups   xmm1,[7FF91A1B71C0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FF91A1B71D0]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FF91A1B71E0]
       test      ebx,ebx
       jl        short M12_L02
       vxorps    xmm2,xmm2,xmm2
       vmovaps   xmm3,xmm0
       vmovaps   xmm0,xmm2
       vmovaps   xmm2,xmm3
       jmp       short M12_L03
M12_L02:
       vpshufb   xmm2,xmm0,[7FF91A1B71F0]
       vpshufb   xmm3,xmm1,[7FF91A1B7200]
       vpshufb   xmm1,xmm1,[7FF91A1B7210]
       vpshufb   xmm0,xmm0,[7FF91A1B7220]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FF91A1B7230]
       vmovaps   xmm1,xmm3
M12_L03:
       vpmovzxbw xmm3,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm4,xmm2
       vpsrldq   xmm2,xmm2,8
       vpmovzxbw xmm2,xmm2
       test      ebx,ebx
       jge       short M12_L07
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r8],xmm3
       vmovups   [r8+28],xmm4
       vmovups   [r8+38],xmm2
       vmovups   [r8+10],xmm1
       vmovups   [r8+20],xmm0
       add       r8,48
M12_L04:
       test      bl,bl
       jne       near ptr M12_L17
M12_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
M12_L06:
       add       rsp,30
       pop       rbx
       ret
M12_L07:
       vmovups   [r8],xmm3
       vmovups   [r8+10],xmm1
       vmovups   [r8+20],xmm4
       vmovups   [r8+30],xmm2
       add       r8,40
       jmp       short M12_L04
M12_L08:
       call      qword ptr [7FF91A117F90]
       int       3
M12_L09:
       cmp       eax,62
       je        short M12_L14
       cmp       eax,64
       je        short M12_L12
M12_L10:
       call      qword ptr [7FF91A117F90]
       int       3
M12_L11:
       cmp       eax,70
       je        short M12_L13
       cmp       eax,78
       jne       short M12_L10
       call      qword ptr [7FF91A117FD8]
       nop
       add       rsp,30
       pop       rbx
       ret
M12_L12:
       mov       ebx,80000024
       jmp       near ptr M12_L00
M12_L13:
       mov       ebx,80292826
       jmp       near ptr M12_L00
M12_L14:
       mov       ebx,807D7B26
       jmp       near ptr M12_L00
M12_L15:
       xor       eax,eax
       mov       [r8],eax
       jmp       short M12_L06
M12_L16:
       lea       r8,[rax+2]
       movzx     edx,bl
       mov       [rax],dx
       jmp       near ptr M12_L01
M12_L17:
       movzx     eax,bl
       mov       [r8],ax
       jmp       near ptr M12_L05
; Total bytes of code 494
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
       je        near ptr M13_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M13_L01
       test      rsi,rsi
       je        short M13_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M13_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M13_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF919A25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF919A25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M13_L00:
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
M13_L01:
       test      rsi,rsi
       je        short M13_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M13_L03
M13_L02:
       mov       rax,2E7B0EB0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L03:
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
M13_L04:
       call      qword ptr [7FF91A117F60]
       int       3
; Total bytes of code 244
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M14_L06
       test      rbx,rbx
       je        near ptr M14_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M14_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M14_L03
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FF91A045E18]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M14_L04
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       lea       rbp,[rbx+0C]
       mov       ebx,[rbx+8]
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M14_L01
       cmp       ecx,2F
       je        short M14_L01
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M14_L08
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M14_L00:
       test      ecx,ecx
       jne       short M14_L01
       mov       rcx,2E7B0EB81EC
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       [rsp+30],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FF91A115170]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M14_L02
M14_L01:
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FF919DAD920]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
M14_L02:
       jmp       short M14_L05
M14_L03:
       mov       rax,rsi
       jmp       short M14_L05
M14_L04:
       mov       rax,rbx
M14_L05:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M14_L06:
       mov       ecx,1C47C
       mov       rdx,7FF919964000
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A117B10]
       int       3
M14_L07:
       mov       ecx,1C488
       mov       rdx,7FF919964000
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A117B10]
       int       3
M14_L08:
       mov       ecx,1
       jmp       near ptr M14_L00
; Total bytes of code 355
```
```assembly
; System.IO.File.WriteAllText(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       call      qword ptr [7FF91A115188]; System.IO.File.get_UTF8NoBOM()
       test      rbx,rbx
       je        short M15_L02
       cmp       dword ptr [rbx+8],0
       je        short M15_L02
       test      rax,rax
       je        short M15_L03
       test      rsi,rsi
       jne       short M15_L01
       xor       r8d,r8d
       xor       r9d,r9d
M15_L00:
       mov       [rsp+28],r8
       mov       [rsp+30],r9d
       lea       r8,[rsp+28]
       mov       r9,rax
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FF91A1151D0]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M15_L01:
       lea       r8,[rsi+0C]
       mov       r9d,[rsi+8]
       jmp       short M15_L00
M15_L02:
       mov       ecx,1AC3C
       mov       rdx,7FF919964000
       call      qword ptr [7FF919C477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A11F048]
       int       3
M15_L03:
       mov       ecx,1C2AE
       mov       rdx,7FF919964000
       call      qword ptr [7FF919C477B0]
       mov       rcx,rax
       call      qword ptr [7FF91A117B10]
       int       3
; Total bytes of code 167
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
       call      qword ptr [7FF97D7384E0]
       cmp       byte ptr [rax],0
       je        near ptr M16_L03
       call      qword ptr [7FF97D73EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M16_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
M16_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L01:
       call      qword ptr [7FF97D73A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M16_L00
       call      qword ptr [7FF97D7384D8]
       cmp       byte ptr [rax],0
       je        short M16_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF97D7402E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF97D73EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M16_L00
       cmp       [rsi+10],rbx
       je        short M16_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M16_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF97D73E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M16_L00
M16_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M16_L00
M16_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M16_L04
       call      qword ptr [7FF97D73A6A0]
       test      rax,rax
       je        near ptr M16_L00
M16_L04:
       call      qword ptr [7FF97D73CE58]
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
       call      qword ptr [7FF97D73E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF97D73C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M18_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M18_L07
M18_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M18_L08
M18_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF97D73B180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M18_L03
M18_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF97D73EEF8]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L03:
       mov       rcx,rax
       call      qword ptr [7FF97D73B218]
       jmp       short M18_L02
M18_L04:
       cmp       byte ptr [rbp-10],0
       je        short M18_L05
       mov       rcx,rbx
       call      qword ptr [7FF97D73B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M18_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FF97D73CE50]
       int       3
M18_L07:
       mov       rcx,rax
       call      qword ptr [7FF97D73B218]
       jmp       near ptr M18_L00
M18_L08:
       mov       rcx,rax
       call      qword ptr [7FF97D73E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M18_L01
       sub       rsp,28
       call      qword ptr [7FF97D73B210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF97D738258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M18_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF97D73B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M18_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M19_L00
       cmp       [rdx],rcx
       jne       short M19_L01
M19_L00:
       mov       rax,rdx
       ret
M19_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M19_L00
M19_L02:
       test      rax,rax
       je        short M19_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M19_L00
       test      rax,rax
       je        short M19_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M19_L00
       test      rax,rax
       je        short M19_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M19_L00
       test      rax,rax
       je        short M19_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M19_L00
       jmp       short M19_L02
M19_L03:
       jmp       qword ptr [7FF91A11C780]
; Total bytes of code 90
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF96D8BDCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M20_L01
       cmp       [rax],ecx
       jle       short M20_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M20_L03
M20_L00:
       add       rsp,20
       pop       rbx
       ret
M20_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M20_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M20_L00
M20_L02:
       cmp       [rax+4],edx
       jle       short M20_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M20_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M20_L03
       jmp       short M20_L00
M20_L03:
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
       jne       short M21_L00
       ret
M21_L00:
       jmp       qword ptr [7FF919A25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M22_L05
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M22_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M22_L06
M22_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M22_L07
M22_L01:
       xor       r13d,r13d
       mov       r12d,1
       mov       ecx,[r15+8]
       cmp       ecx,r14d
       jbe       short M22_L03
       mov       r13d,1
       test      sil,sil
       jne       near ptr M22_L08
M22_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M22_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M22_L10
M22_L03:
       mov       rcx,2A71C000C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M22_L25
M22_L04:
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
M22_L05:
       mov       ecx,2
       call      qword ptr [7FF919C4C240]
       int       3
M22_L06:
       mov       ecx,0A
       call      qword ptr [7FF91A117DC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M22_L00
M22_L07:
       mov       rcx,rdi
       call      qword ptr [7FF91A115128]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M22_L01
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91A11C510]
       jmp       near ptr M22_L02
M22_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF91A11C528]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF919964000
       call      qword ptr [7FF919C477B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF919DA6190]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M22_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M22_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M22_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF91A254A68]
M22_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91996B184],0
       je        short M22_L12
       call      qword ptr [7FF91A11C420]
       mov       esi,eax
       jmp       short M22_L14
M22_L12:
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       mov       esi,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A11C438]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M22_L13
       call      qword ptr [7FF91A11C450]
       mov       esi,eax
       jmp       short M22_L14
M22_L13:
       sar       esi,10
M22_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF91996B178]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M22_L21
M22_L15:
       cmp       esi,[r12+8]
       jae       near ptr M22_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF919F3DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M22_L17
       test      r8d,r8d
       jne       short M22_L18
       xor       edx,edx
       mov       [rax+14],edx
M22_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M22_L17:
       mov       rcx,rax
       call      qword ptr [7FF919A26820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M22_L19
       jmp       short M22_L22
M22_L18:
       jmp       short M22_L16
M22_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M22_L20
       xor       esi,esi
M22_L20:
       mov       eax,[rsp+40]
       inc       eax
M22_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M22_L15
       jmp       short M22_L23
M22_L22:
       mov       r12d,1
       jmp       short M22_L24
M22_L23:
       xor       r12d,r12d
M22_L24:
       jmp       near ptr M22_L03
M22_L25:
       test      ebp,ebp
       je        near ptr M22_L04
       mov       rcx,rbx
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF91A11C558]
       test      r12d,r13d
       jne       near ptr M22_L04
       mov       rcx,rbx
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF919E3D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M22_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M22_L27
M22_L26:
       mov       ecx,r14d
       xor       edx,edx
M22_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FF91A11C570]
       jmp       near ptr M22_L04
M22_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.SaveAsJsonToFile()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,148
       lea       rbp,[rsp+170]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       vmovdqa   xmmword ptr [rbp-130],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-30],rax
       mov       rdx,[rcx+148]
       mov       [rbp-128],rdx
       mov       rcx,[rcx+140]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L46
       mov       rcx,[rcx+10]
       cmp       [rdx],dl
       test      rcx,rcx
       je        near ptr M00_L33
       mov       [rbp-30],rcx
       mov       rcx,27F31401E98
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+9F],0
       je        near ptr M00_L34
M00_L01:
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[r14+0C0]
       mov       rax,2BFC641B5F0
       cmp       rcx,rax
       je        short M00_L05
M00_L02:
       xor       r14d,r14d
       cmp       byte ptr [rbx+9E],0
       je        short M00_L04
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M00_L35
M00_L03:
       cmp       [rcx],cl
       mov       rdx,2BFC641B5F0
       call      qword ptr [7FF919E4D788]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L36
       mov       r14,[rax+8]
       test      r14,r14
       je        short M00_L04
       cmp       byte ptr [r14+119],2
       jne       near ptr M00_L37
M00_L04:
       test      r14,r14
       je        near ptr M00_L32
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       rbx,r14
       test      rbx,rbx
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L38
M00_L06:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF91A1245B8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r14d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L39
       mov       rcx,[rcx+240]
       mov       r15,[rcx+48]
       test      r15,r15
       je        near ptr M00_L39
M00_L07:
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L08
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2BFC64162A0
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
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L08:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r14d,r14d
       je        near ptr M00_L41
       mov       rcx,27F31401E50
       mov       rcx,[rcx]
       mov       edx,r14d
       call      qword ptr [7FF91A062CE8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L09:
       mov       [rbp-58],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-130],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-34]
       lea       rdi,[r15+70]
       lea       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r15+7C],8
       cmove     ecx,eax
       mov       [r15+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L13
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L10:
       mov       [r15+2C],eax
       test      dl,4
       jne       near ptr M00_L42
       mov       r14,2BFC6411518
M00_L11:
       mov       ecx,[r14+8]
       mov       [r15+30],ecx
       cmp       dword ptr [r15+78],0
       jne       short M00_L12
       mov       dword ptr [r15+78],3E8
M00_L12:
       mov       [rbp-138],r15
       jmp       near ptr M00_L20
M00_L13:
       mov       eax,2
       jmp       short M00_L10
M00_L14:
       mov       rcx,[rax+8]
       mov       [rbp-130],rcx
       mov       r15,[rax+10]
       mov       rcx,[rbp-130]
       cmp       [rcx],cl
       mov       rcx,[rbp-130]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r14d
       jl        near ptr M00_L18
M00_L15:
       lea       rcx,[r15+8]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-34]
       lea       rdi,[r15+70]
       lea       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r15+7C],8
       cmove     ecx,eax
       mov       [r15+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L19
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L16:
       mov       [r15+2C],eax
       test      dl,4
       jne       near ptr M00_L40
       mov       rsi,2BFC6411518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r15+30],ecx
       cmp       dword ptr [r15+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r15+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r14d
       call      qword ptr [7FF91A124648]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L15
M00_L19:
       mov       eax,2
       jmp       short M00_L16
M00_L20:
       cmp       byte ptr [rbx+116],0
       jne       near ptr M00_L28
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       jne       near ptr M00_L29
M00_L21:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0F8],ymm0
       vmovdqu   ymmword ptr [rbp-0D8],ymm0
       vmovdqu   ymmword ptr [rbp-0B8],ymm0
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       mov       [rbp-90],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+0C8]
       mov       [rbp-68],rcx
       mov       byte ptr [rbp-0AA],0
       mov       byte ptr [rbp-0A9],0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],0
       jne       near ptr M00_L30
M00_L22:
       lea       rcx,[rbp-0F8]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp-30]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF91A1246F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L23:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF91A125068]; System.Text.Json.Utf8JsonWriter.Flush()
M00_L24:
       xor       ecx,ecx
       mov       [rbp-100],rcx
       mov       rcx,[rbp-130]
       cmp       [rcx],cl
       mov       rcx,[rbp-130]
       add       rcx,18
       mov       rax,[rcx]
       mov       edx,[rcx+8]
       mov       r8d,edx
       mov       ecx,[rcx+0C]
       sub       ecx,edx
       test      rax,rax
       je        short M00_L25
       mov       edx,r8d
       mov       r10d,ecx
       add       rdx,r10
       mov       r10d,[rax+8]
       cmp       rdx,r10
       ja        short M00_L27
       mov       r8d,r8d
       lea       rax,[rax+r8+10]
       jmp       short M00_L26
M00_L25:
       or        r8d,ecx
       jne       short M00_L27
       xor       eax,eax
       xor       ecx,ecx
M00_L26:
       mov       [rbp-120],rax
       mov       [rbp-118],ecx
       lea       rcx,[rbp-120]
       call      qword ptr [7FF919FB6478]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-140],rax
       jmp       near ptr M00_L31
M00_L27:
       call      qword ptr [7FF919BA7198]
       int       3
M00_L28:
       mov       rax,[rbx+148]
       mov       rdx,r15
       mov       r8,[rbp-30]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L23
M00_L29:
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L21
       mov       rcx,[rbx+0B8]
       lea       r8,[rbp-100]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A266028]
       test      eax,eax
       je        near ptr M00_L21
       mov       rcx,[rbp-100]
       mov       rdx,r15
       mov       r8,[rbp-30]
       mov       rax,[rbp-100]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L24
M00_L30:
       mov       rcx,[rcx+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-0D8],rax
       jmp       near ptr M00_L22
M00_L31:
       call      M00_L47
       nop
       call      qword ptr [7FF919DB4300]; System.DateTime.get_Now()
       mov       rcx,rax
       mov       r8,27F31400100
       mov       r8,[r8]
       mov       rdx,2BFC6420808
       mov       r9,8000000000000000
       call      qword ptr [7FF91A1251A0]; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       mov       r8,rax
       mov       rcx,2BFC64207D0
       mov       rdx,2BFC64125A8
       mov       r9,2BFC6420848
       call      qword ptr [7FF919C5FE88]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,[rbp-128]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L43
       test      rax,rax
       je        near ptr M00_L44
       mov       rdx,rax
       call      qword ptr [7FF91A055DB8]; System.IO.Path.CombineInternal(System.String, System.String)
       mov       rbx,rax
       call      qword ptr [7FF91A125CC8]; System.IO.File.get_UTF8NoBOM()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,2BFC6417DF8
       call      qword ptr [7FF91A267828]; System.ArgumentException.ThrowIfNullOrEmpty(System.String, System.String)
       test      rsi,rsi
       je        near ptr M00_L45
       lea       rcx,[rbp-110]
       mov       rdx,[rbp-140]
       call      qword ptr [7FF919E47AC8]; System.MemoryExtensions.AsSpan(System.String)
       lea       r8,[rbp-110]
       mov       rcx,rbx
       mov       r9,rsi
       mov       edx,2
       call      qword ptr [7FF91A125D10]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       mov       rax,rbx
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L32:
       mov       rdx,[rbx+20]
       mov       rcx,2BFC641B5F0
       call      qword ptr [7FF91A264E70]
       int       3
M00_L33:
       call      qword ptr [7FF919FBEC58]
       mov       ecx,58B
       mov       rdx,7FF919D04A80
       call      qword ptr [7FF919C577B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF919D05550
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FF919D04A80
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A267810]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A12D6B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rbx
       call      qword ptr [7FF919E47A38]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,rbx
       call      qword ptr [7FF919E4D260]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L36:
       call      qword ptr [7FF91A264E58]
       int       3
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FF919F46EF8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L38:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L39:
       mov       ecx,9
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L40:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27F47400410
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L41:
       mov       rax,2BFC64162A0
       jmp       near ptr M00_L09
M00_L42:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27F47400410
       mov       r14,[rcx]
       jmp       near ptr M00_L11
M00_L43:
       mov       ecx,1C47C
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A12C6D8]
       int       3
M00_L44:
       mov       ecx,1C488
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A12C6D8]
       int       3
M00_L45:
       mov       ecx,1C2AE
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A12C6D8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       short M00_L48
       mov       rcx,[rcx+240]
       mov       r15,[rcx+48]
       test      r15,r15
       jne       short M00_L49
M00_L48:
       mov       ecx,9
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
M00_L49:
       mov       rbx,[r15+10]
       xor       ecx,ecx
       mov       rdx,[rbp-138]
       mov       [rdx+34],ecx
       mov       [rdx+20],rcx
       mov       [rdx+40],rcx
       mov       [rdx+48],rcx
       mov       byte ptr [rdx+38],0
       mov       word ptr [rdx+39],0
       mov       [rdx+28],ecx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+60],rcx
       mov       [rdx+68],cx
       mov       [rdx+6A],cl
       mov       byte ptr [rdx+3B],0
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbp-130]
       cmp       [rcx],cl
       mov       rcx,[rbp-130]
       add       rcx,18
       xor       edx,edx
       mov       [rcx+8],edx
       mov       [rcx+0C],edx
       mov       rdx,[rcx]
       mov       r8,2BFC64162A0
       mov       [rcx],r8
       cmp       byte ptr [rcx+10],0
       je        short M00_L50
       cmp       dword ptr [rdx+8],0
       je        short M00_L50
       mov       rcx,27F31401E50
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF91A062CF0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M00_L50:
       dec       dword ptr [rbx+18]
       add       rsp,28
       ret
; Total bytes of code 2315
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       call      qword ptr [7FF97D738540]
       mov       rbp,[rax]
       test      rbp,rbp
       je        short M01_L01
M01_L00:
       mov       rcx,rdi
       call      qword ptr [7FF97D7384C0]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9,rbx
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       call      qword ptr [7FF97D73A0D0]
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF97D73ACF8]
       call      qword ptr [7FF97D738540]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 106
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
       jne       near ptr M02_L10
       and       esi,0FFFFFFF7
M02_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M02_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M02_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M02_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M02_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M02_L14
M02_L02:
       mov       rcx,2BFC6421688
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],1
       jne       short M02_L03
       cmp       word ptr [r8+0C],0A
       je        short M02_L04
M02_L03:
       mov       rcx,2BFC6411518
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],2
       jne       short M02_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L08
M02_L04:
       mov       rcx,2BFC6411518
       cmp       r8,rcx
       je        short M02_L05
       cmp       dword ptr [r8+8],2
       jne       short M02_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L09
M02_L05:
       and       esi,0FFFFFFFB
M02_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       r8d,2
       jmp       near ptr M02_L01
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF919E69F30
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A265E60]
       int       3
M02_L09:
       or        esi,4
       jmp       short M02_L06
M02_L10:
       cmp       edx,9
       je        short M02_L11
       mov       ecx,38A0
       mov       rdx,7FF919E69F30
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A265E18]
       int       3
M02_L11:
       or        esi,8
       jmp       near ptr M02_L00
M02_L12:
       mov       ecx,38A0
       mov       rdx,7FF919E69F30
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF91A265E30]
       int       3
M02_L13:
       mov       ecx,38A0
       mov       rdx,7FF919E69F30
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A265E48]
       int       3
M02_L14:
       mov       r8,2BFC6411518
       mov       [rcx+50],r8
       jmp       near ptr M02_L02
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
       mov       rcx,27F31400C90
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
       jle       short M03_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M03_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M03_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M03_L03
M03_L01:
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
M03_L02:
       mov       ecx,0A
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       mov       rcx,r14
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A12CFA8]
       jmp       short M03_L01
M03_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M03_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M03_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91997B184],0
       je        short M03_L05
       call      qword ptr [7FF91A12CFC0]
       mov       ebx,eax
       jmp       short M03_L07
M03_L05:
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M03_L06
       call      qword ptr [7FF91A12CFF0]
       mov       ebx,eax
       jmp       short M03_L07
M03_L06:
       sar       ebx,10
M03_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF91997B178]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M03_L11
M03_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M03_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF919F4DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M03_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M03_L09:
       mov       rcx,r13
       call      qword ptr [7FF919A36820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M03_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M03_L10
       xor       ebx,ebx
M03_L10:
       inc       r15d
M03_L11:
       cmp       [r14+8],r15d
       jg        short M03_L08
       jmp       short M03_L13
M03_L12:
       mov       r14,r12
       jmp       short M03_L14
M03_L13:
       xor       r14d,r14d
M03_L14:
       test      r14,r14
       je        short M03_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       mov       rcx,r14
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A12CFA8]
       jmp       near ptr M03_L01
M03_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M03_L18
M03_L16:
       test      ebx,ebx
       jne       short M03_L17
       mov       rax,2BFC64162A0
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
M03_L17:
       mov       ecx,ebx
       mov       rdx,2BFC6416F28
       call      qword ptr [7FF919C5D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M03_L18:
       cmp       ebx,800
       jge       short M03_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M03_L20
M03_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF91A124690]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF91A12CFA8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF91A12D020]
       jmp       near ptr M03_L01
M03_L21:
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
       jne       near ptr M04_L23
       mov       rcx,27F31401E50
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,27F31400C90
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
       jle       short M04_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M04_L04
M04_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M04_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M04_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M04_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M04_L05
M04_L01:
       mov       rdx,r13
M04_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L03:
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
M04_L04:
       mov       ecx,0A
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L05:
       mov       rcx,r13
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A12CFA8]
       jmp       short M04_L01
M04_L06:
       mov       rcx,[rdi+10]
       cmp       [rcx+8],r15d
       jbe       near ptr M04_L18
       mov       eax,r15d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M04_L17
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91997B184],0
       je        short M04_L07
       call      qword ptr [7FF91A12CFC0]
       mov       ebp,eax
       jmp       short M04_L09
M04_L07:
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M04_L08
       call      qword ptr [7FF91A12CFF0]
       mov       ebp,eax
       jmp       short M04_L09
M04_L08:
       sar       ebp,10
M04_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FF91997B178]
       mov       esi,edx
       xor       ebp,ebp
       jmp       short M04_L13
M04_L10:
       cmp       esi,[r13+8]
       jae       near ptr M04_L29
       mov       ecx,esi
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF919F4DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M04_L11
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M04_L11:
       mov       rcx,r12
       call      qword ptr [7FF919A36820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M04_L14
       inc       esi
       cmp       [r13+8],esi
       jne       short M04_L12
       xor       esi,esi
M04_L12:
       inc       ebp
M04_L13:
       cmp       [r13+8],ebp
       jg        short M04_L10
       jmp       short M04_L15
M04_L14:
       mov       r13,r12
       jmp       short M04_L16
M04_L15:
       xor       r13d,r13d
M04_L16:
       test      r13,r13
       je        short M04_L17
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       mov       rcx,r13
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A12CFA8]
       jmp       near ptr M04_L01
M04_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M04_L20
M04_L18:
       test      ebp,ebp
       jne       short M04_L19
       mov       rdx,2BFC64162A0
       jmp       near ptr M04_L02
M04_L19:
       mov       ecx,ebp
       mov       rdx,2BFC6416F28
       call      qword ptr [7FF919C5D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M04_L20:
       cmp       ebp,800
       jge       short M04_L21
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M04_L22
M04_L21:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF91A124690]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M04_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF91A12CFA8]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF91A12D020]
       jmp       near ptr M04_L01
M04_L23:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M04_L24
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF919BADF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M04_L03
M04_L24:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M04_L25
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A265008]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L25:
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
       jne       short M04_L26
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M04_L27
M04_L26:
       mov       rcx,27F31401E50
       mov       rcx,[rcx]
       call      qword ptr [7FF91A062CE8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M04_L27:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M04_L28
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF919BADF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M04_L28:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M04_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M04_L03
       mov       rcx,27F31401E50
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
       jmp       qword ptr [7FF91A062CF0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M04_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       jge       near ptr M05_L21
       cmp       byte ptr [rsi+17],0
       jne       short M05_L00
       cmp       qword ptr [rdi],0
       je        near ptr M05_L22
M05_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M05_L11
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M05_L23
M05_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M05_L25
       test      r8,r8
       je        near ptr M05_L08
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M05_L24
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M05_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,27F31401458
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
       jmp       short M05_L03
M05_L02:
       mov       eax,0FFFFFFFF
M05_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M05_L06
       test      byte ptr [rbx+7C],2
       jne       short M05_L04
       movzx     eax,byte ptr [rbx+38]
       cmp       eax,10
       sete      dl
       movzx     edx,dl
       movzx     r8d,byte ptr [rbx+3A]
       cmp       eax,r8d
       sete      al
       movzx     eax,al
       or        eax,edx
       jne       short M05_L04
       mov       rcx,rbx
       call      qword ptr [7FF91A265440]
       mov       rcx,[rbp+30]
M05_L04:
       test      byte ptr [rbx+7C],1
       jne       short M05_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF91A265458]
       jmp       short M05_L07
M05_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF91A124B28]; System.Text.Json.Utf8JsonWriter.WriteStringIndented(System.ReadOnlySpan`1<Char>)
       jmp       short M05_L07
M05_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF91A265410]
M05_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91A124D50]
M05_L09:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M05_L26
M05_L10:
       mov       eax,1
       jmp       near ptr M05_L33
M05_L11:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M05_L17
       cmp       byte ptr [rcx+8E],1
       je        short M05_L17
       cmp       dword ptr [rcx+40],0
       jne       short M05_L12
       mov       r8,[rcx+68]
       jmp       short M05_L14
M05_L12:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M05_L27
M05_L13:
       mov       r8,r13
       mov       rcx,[rbp+30]
M05_L14:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M05_L28
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M05_L28
       xor       r13d,r13d
M05_L15:
       test      r15d,r15d
       jne       short M05_L16
       cmp       dword ptr [r14+8C],0
       jne       near ptr M05_L29
M05_L16:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M05_L30
M05_L17:
       call      qword ptr [7FF91A124720]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M05_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF919F781B8]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M05_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF91A124BA0]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M05_L19
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M05_L31
M05_L19:
       mov       rcx,[rbp+30]
       mov       eax,r15d
       jmp       near ptr M05_L33
M05_L20:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M05_L18
M05_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FF91A124D20]
       int       3
M05_L22:
       mov       rcx,rbx
       call      qword ptr [7FF91A124D50]
       jmp       near ptr M05_L10
M05_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M05_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF919FB6370]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M05_L09
M05_L24:
       mov       ecx,edi
       call      qword ptr [7FF91A2653F8]
       int       3
M05_L25:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M05_L09
M05_L26:
       mov       rcx,rsi
       call      qword ptr [7FF91A124CC0]
       int       3
M05_L27:
       mov       rcx,r13
       call      qword ptr [7FF919F46EF8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M05_L13
M05_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF91A265320]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M05_L15
M05_L29:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF91A265338]
       test      eax,eax
       je        near ptr M05_L16
       jmp       near ptr M05_L10
M05_L30:
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
       je        near ptr M05_L19
       cmp       byte ptr [rcx+8F],0
       je        near ptr M05_L19
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M05_L32
M05_L31:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L32:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M05_L19
M05_L33:
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
       jne       short M05_L34
       call      qword ptr [7FF91A266088]
M05_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M05_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M05_L35
       mov       rcx,rsi
       call      qword ptr [7FF91A2660A0]
       test      rax,rax
       jne       near ptr M05_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF91A2660B8]
       jmp       near ptr M05_L38
M05_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2BFC641F0E0
       cmp       [rcx],ecx
       call      qword ptr [7FF91A2660E8]
       test      eax,eax
       jne       short M05_L38
       jmp       short M05_L37
M05_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2BFC641F090
       call      qword ptr [7FF919C54F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M05_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF91A2660D0]
       jmp       short M05_L38
M05_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF91A266100]
M05_L38:
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
       call      qword ptr [7FF91A266520]
       int       3
M06_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A290BC8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A266550]
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
       call      qword ptr [7FF91A266568]
M06_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M06_L02
M06_L06:
       mov       r11,7FF919980BF0
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
       mov       r8,27F31401430
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
       call      qword ptr [7FF919BA4C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FF9796CA1D0
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
       call      qword ptr [7FF919BA4C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,2BFC6410008
M07_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF919FBE430]
       int       3
M07_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF919FBE400]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF919FBE448]
       int       3
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF919FBE430]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF919FB6298]
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
       call      qword ptr [7FF919FBE6A0]
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
       call      qword ptr [7FF91A1274B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.DateTime.get_Now()
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rcx,[rsp+28]
       mov       rax,7FF9B1FE5380
       call      rax
       mov       rbx,[rsp+28]
       mov       rax,27F31401B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FF9799839A0],0
       jne       short M08_L02
M08_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M08_L03
       add       rbx,[rsi+10]
M08_L01:
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       call      qword ptr [7FF91A125110]; System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(System.DateTime, Boolean ByRef)
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rbx
       add       rax,rcx
       mov       rcx,2BCA2875F4373FFF
       cmp       rax,rcx
       ja        short M08_L05
       cmp       byte ptr [rsp+30],0
       jne       short M08_L04
       mov       rcx,8000000000000000
       or        rax,rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M08_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L00
M08_L03:
       call      qword ptr [7FF919F46AF0]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       short M08_L01
M08_L04:
       mov       rcx,0C000000000000000
       or        rax,rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M08_L05:
       mov       rcx,8000000000000000
       mov       rdx,0ABCA2875F4373FFF
       test      rax,rax
       mov       rax,rdx
       cmovl     rax,rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 215
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqa   xmmword ptr [rbp+70],xmm4
       xor       eax,eax
       mov       [rbp+80],rax
       mov       rax,8EAE3BAD19
       mov       [rbp+8],rax
       mov       [rbp+0B0],rcx
       mov       rbx,rdx
       mov       rcx,r8
       mov       rsi,r9
M09_L00:
       test      rbx,rbx
       je        near ptr M09_L08
       cmp       dword ptr [rbx+8],0
       je        near ptr M09_L08
       cmp       dword ptr [rbx+8],1
       je        near ptr M09_L17
       test      rcx,rcx
       jne       near ptr M09_L29
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M09_L30
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M09_L30
M09_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M09_L02
       mov       rcx,27F31400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M09_L02
       mov       rcx,27F314000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M09_L02
       call      qword ptr [7FF919C55E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
M09_L02:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M09_L31
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M09_L31
M09_L03:
       mov       [rbp+80],rax
M09_L04:
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+30]
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],100
       mov       rdx,[rbp+30]
       mov       ecx,[rbp+38]
       xor       r8d,r8d
       mov       [rbp+60],r8
       mov       [rbp+68],r8d
       mov       [rbp+70],rdx
       mov       [rbp+78],ecx
       mov       rcx,[rbp+0B0]
       test      rbx,rbx
       jne       near ptr M09_L14
       xor       edx,edx
       xor       r8d,r8d
M09_L05:
       mov       [rbp+10],rdx
       mov       [rbp+18],r8d
       lea       rdx,[rbp+60]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+10]
       mov       r8,[rbp+80]
       mov       r9,rsi
       call      qword ptr [7FF91A125908]; System.DateTimeFormat.FormatCustomized[[System.Char, System.Private.CoreLib]](System.DateTime, System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.TimeSpan, System.Collections.Generic.ValueListBuilder`1<Char> ByRef)
       mov       ecx,[rbp+68]
       cmp       ecx,[rbp+78]
       ja        near ptr M09_L33
       mov       rax,[rbp+70]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbp+60]
       test      rdx,rdx
       jne       near ptr M09_L34
M09_L06:
       mov       rax,rdi
       mov       r8,8EAE3BAD19
       cmp       [rbp+8],r8
       je        short M09_L07
       call      CORINFO_HELP_FAIL_FAST
M09_L07:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M09_L08:
       test      rcx,rcx
       jne       near ptr M09_L16
       call      qword ptr [7FF91A2665F8]
M09_L09:
       mov       [rbp+80],rax
       mov       rcx,8000000000000000
       cmp       rsi,rcx
       jne       near ptr M09_L12
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF91A266610]
       test      eax,eax
       jne       short M09_L11
       mov       rcx,[rbp+80]
       mov       rax,27F474002D8
       cmp       rcx,[rax]
       je        short M09_L10
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A266628]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L10:
       mov       ecx,13
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+50]
       mov       rdx,8000000000000000
       call      qword ptr [7FF91A266598]
       jmp       near ptr M09_L06
M09_L11:
       mov       ecx,13
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+58]
       call      qword ptr [7FF91A266580]
       jmp       near ptr M09_L06
M09_L12:
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF91A266610]
       test      eax,eax
       je        short M09_L13
       mov       rbx,2BFC64216D0
       mov       rcx,27F474002D8
       mov       rcx,[rcx]
       mov       [rbp+80],rcx
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,[rbp+80]
       mov       rax,27F474002D8
       cmp       rcx,[rax]
       je        short M09_L15
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A266640]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L14:
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       jmp       near ptr M09_L05
M09_L15:
       mov       ecx,1A
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+48]
       mov       rdx,rsi
       call      qword ptr [7FF91A266598]
       jmp       near ptr M09_L06
M09_L16:
       call      qword ptr [7FF91A1251B8]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       near ptr M09_L09
M09_L17:
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,52
       jg        short M09_L18
       cmp       eax,4F
       je        short M09_L20
       cmp       eax,52
       je        near ptr M09_L21
       jmp       short M09_L19
M09_L18:
       cmp       eax,55
       je        near ptr M09_L23
       add       eax,0FFFFFF91
       cmp       eax,6
       ja        short M09_L19
       lea       rdx,[7FF91A1F0040]
       mov       edx,[rdx+rax*4]
       lea       r8,[M09_L00]
       add       rdx,r8
       jmp       rdx
M09_L19:
       test      rcx,rcx
       je        near ptr M09_L27
       jmp       near ptr M09_L26
M09_L20:
       test      [rsp],esp
       sub       rsp,50
       lea       rdi,[rsp+30]
       mov       rcx,[rbp+0B0]
       mov       [rbp+20],rdi
       mov       dword ptr [rbp+28],21
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF91A2665B0]
       mov       ecx,[rbp+40]
       cmp       ecx,21
       ja        near ptr M09_L33
       mov       [rbp+30],rdi
       mov       [rbp+38],ecx
       lea       rcx,[rbp+30]
       call      qword ptr [7FF919C54180]; System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdi,rax
       jmp       near ptr M09_L06
M09_L21:
       mov       ecx,1D
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF91A2665C8]
M09_L22:
       jmp       near ptr M09_L06
       mov       ecx,13
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+40]
       call      qword ptr [7FF91A266580]
       jmp       short M09_L22
       mov       ecx,14
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FF91A2665E0]
       jmp       short M09_L22
M09_L23:
       test      rcx,rcx
       je        short M09_L24
       call      qword ptr [7FF91A1251B8]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M09_L25
M09_L24:
       call      qword ptr [7FF91A2665F8]
M09_L25:
       mov       [rbp+80],rax
       lea       rcx,[rbp+0B0]
       lea       rdx,[rbp+80]
       mov       r8,rsi
       call      qword ptr [7FF91A266658]
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A266670]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L26:
       call      qword ptr [7FF91A1251B8]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M09_L28
M09_L27:
       call      qword ptr [7FF91A2665F8]
M09_L28:
       mov       [rbp+80],rax
       movzx     ecx,word ptr [rbx+0C]
       mov       rdx,[rbp+80]
       call      qword ptr [7FF91A266688]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L29:
       call      qword ptr [7FF91A1251B8]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       near ptr M09_L03
M09_L30:
       mov       ecx,2
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L01
M09_L31:
       mov       rdx,2BFC6421728
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       rdx,rax
       test      rdx,rdx
       je        short M09_L32
       mov       rcx,offset MT_System.Globalization.DateTimeFormatInfo
       cmp       [rdx],rcx
       je        short M09_L32
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M09_L32:
       mov       rax,rdx
       jmp       near ptr M09_L03
M09_L33:
       call      qword ptr [7FF919BA7198]
       int       3
M09_L34:
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,27F31400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF919D007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M09_L06
; Total bytes of code 1434
```
```assembly
; System.String.Concat(System.String, System.String, System.String, System.String)
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
       mov       rsi,rdx
       mov       rbp,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M10_L03
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M10_L03
       test      rsi,rsi
       je        near ptr M10_L02
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M10_L02
       test      rbp,rbp
       je        near ptr M10_L01
       mov       r13d,[rbp+8]
       test      r13d,r13d
       je        near ptr M10_L01
       test      rdi,rdi
       je        near ptr M10_L00
       cmp       dword ptr [rdi+8],0
       je        near ptr M10_L00
       mov       r12d,r14d
       mov       edx,r15d
       add       rdx,r12
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rdi+8]
       add       rdx,rcx
       cmp       rdx,7FFFFFFF
       jg        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+28]
       lea       rcx,[rbx+r12*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rcx,r14d
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    rcx,r14d
       lea       rcx,[rbx+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,[rsp+30]
       mov       rax,rsi
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
M10_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
M10_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
M10_L02:
       mov       rcx,rbx
       mov       rdx,rbp
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
M10_L03:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
M10_L04:
       call      qword ptr [7FF91A12CB28]
       int       3
; Total bytes of code 434
```
```assembly
; System.IO.Path.CombineInternal(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M11_L09
       cmp       dword ptr [rcx+8],0
       je        near ptr M11_L09
       test      rdx,rdx
       je        near ptr M11_L08
       mov       ebx,[rdx+8]
       test      ebx,ebx
       je        near ptr M11_L08
       lea       rsi,[rdx+0C]
       mov       rax,rsi
       mov       r8d,ebx
       test      r8d,r8d
       jle       short M11_L00
       movzx     r10d,word ptr [rax]
       cmp       r10d,5C
       je        near ptr M11_L09
       cmp       r10d,2F
       je        near ptr M11_L09
M11_L00:
       cmp       r8d,2
       jl        short M11_L01
       movzx     r8d,word ptr [rax]
       or        r8d,20
       add       r8d,0FFFFFF9F
       cmp       r8d,19
       ja        short M11_L01
       cmp       word ptr [rax+2],3A
       je        near ptr M11_L09
M11_L01:
       lea       rdi,[rcx+0C]
       mov       ebp,[rcx+8]
       lea       edx,[rbp-1]
       cmp       edx,ebp
       jae       near ptr M11_L13
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,5C
       je        near ptr M11_L05
       cmp       edx,2F
       je        near ptr M11_L05
       test      ebx,ebx
       je        near ptr M11_L13
       movzx     edx,word ptr [rsi]
       cmp       edx,5C
       je        near ptr M11_L10
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M11_L02:
       test      edx,edx
       jne       near ptr M11_L05
       mov       edx,ebp
       add       edx,1
       jo        near ptr M11_L14
       add       edx,ebx
       jo        near ptr M11_L14
       test      edx,edx
       je        short M11_L03
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        near ptr M11_L12
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,r15
       sub       r13d,ebp
       je        near ptr M11_L12
       mov       word ptr [r12],5C
       lea       rcx,[r12+2]
       dec       r13d
       cmp       ebx,r13d
       ja        near ptr M11_L12
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       jmp       short M11_L04
M11_L03:
       mov       rax,2BFC6410008
M11_L04:
       jmp       short M11_L07
M11_L05:
       mov       edx,ebp
       add       edx,ebx
       jo        near ptr M11_L14
       test      edx,edx
       je        near ptr M11_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        near ptr M11_L12
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       ebx,r13d
       ja        short M11_L12
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M11_L06:
       mov       rax,r14
M11_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L08:
       mov       rax,rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L09:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L10:
       mov       edx,1
       jmp       near ptr M11_L02
M11_L11:
       mov       r14,2BFC6410008
       jmp       short M11_L06
M11_L12:
       call      qword ptr [7FF919E4CD38]
       int       3
M11_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 561
```
```assembly
; System.IO.File.get_UTF8NoBOM()
       push      rbx
       sub       rsp,20
       mov       rcx,27F474002F8
       mov       rax,[rcx]
       test      rax,rax
       je        short M12_L01
M12_L00:
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       mov       rcx,offset MT_System.Text.UTF8Encoding
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FF919C56B38]; System.Text.UTF8Encoding..ctor(Boolean, Boolean)
       mov       rcx,27F474002F8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       short M12_L00
; Total bytes of code 87
```
```assembly
; System.ArgumentException.ThrowIfNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M13_L00
       cmp       dword ptr [rcx+8],0
       je        short M13_L00
       add       rsp,28
       ret
M13_L00:
       call      qword ptr [7FF91A12FBD0]
       int       3
; Total bytes of code 27
```
```assembly
; System.MemoryExtensions.AsSpan(System.String)
       test      rdx,rdx
       jne       short M14_L01
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rcx+8],rdx
M14_L00:
       mov       rax,rcx
       ret
M14_L01:
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       jmp       short M14_L00
; Total bytes of code 33
```
```assembly
; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M15_L00:
       vmovdqa   xmmword ptr [rbp+rax+1D0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+1F0],xmm4
       add       rax,30
       jne       short M15_L00
       mov       [rbp+1D0],rax
       mov       rax,8EAE3BAD19
       mov       [rbp+8],rax
       mov       [rbp+248],edx
       mov       [rbp+258],r9
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       lea       rcx,[rbp+0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp+108],rax
       mov       rcx,rsp
       mov       [rbp+0E8],rcx
       mov       rcx,rbp
       mov       [rbp+0F8],rcx
       mov       rcx,[rbx]
       mov       [rbp+38],rcx
       mov       ecx,[rbx+8]
       mov       [rbp+0CC],ecx
       mov       rcx,offset MT_System.Text.UTF8Encoding
       cmp       [rsi],rcx
       jne       near ptr M15_L102
       cmp       byte ptr [rsi+25],0
       jne       near ptr M15_L101
       mov       rbx,2BFC64162A0
M15_L01:
       test      rbx,rbx
       je        near ptr M15_L103
       lea       rax,[rbx+10]
       mov       ebx,[rbx+8]
M15_L02:
       mov       [rbp+30],rax
       mov       [rbp+0C8],ebx
       mov       [rbp+1F4],ebx
       cmp       dword ptr [rbp+0CC],2000
       jl        short M15_L03
       cmp       dword ptr [rbp+248],6
       je        short M15_L03
       mov       rdx,[rbp+38]
       mov       [rbp+98],rdx
       mov       edx,[rbp+0CC]
       mov       [rbp+0A0],edx
       lea       rdx,[rbp+98]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       add       eax,ebx
       movsxd    rcx,eax
       mov       [rbp+1E0],rcx
       mov       rsi,[rbp+258]
       jmp       short M15_L04
M15_L03:
       xor       ecx,ecx
       mov       [rbp+1E0],rcx
M15_L04:
       test      rdi,rdi
       je        near ptr M15_L100
       cmp       dword ptr [rdi+8],0
       je        near ptr M15_L100
       xor       ebx,ebx
       mov       eax,[rbp+248]
       mov       ecx,eax
       sub       ecx,1
       mov       rdx,2BFC64186D0
       cmp       ecx,5
       cmova     rbx,rdx
       test      rbx,rbx
       jne       near ptr M15_L104
       cmp       qword ptr [rbp+1E0],0
       jl        near ptr M15_L105
       cmp       qword ptr [rbp+1E0],0
       jg        near ptr M15_L106
M15_L05:
       cmp       dword ptr [7FF91997B168],0
       je        near ptr M15_L107
M15_L06:
       mov       ecx,[7FF91997B168]
       cmp       ecx,1
       je        near ptr M15_L13
       cmp       ecx,0FFFFFFFF
       jne       near ptr M15_L110
       mov       rcx,27F47400300
       mov       rbx,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M15_L109
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+20]
       test      rdx,rdx
       je        near ptr M15_L109
M15_L07:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M15_L08
       call      qword ptr [7FF919C5FC00]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
       mov       eax,[rbp+248]
M15_L08:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M15_L09
       mov       rcx,[rcx+8]
       lea       r8,[rbp+1D0]
       mov       rdx,rbx
       mov       r11,7FF919980C08
       call      qword ptr [r11]
       mov       rbx,[rbp+1D0]
       mov       eax,[rbp+248]
       jmp       short M15_L10
M15_L09:
       xor       ebx,ebx
M15_L10:
       xor       edx,edx
       mov       [rbp+1D0],rdx
       test      rbx,rbx
       je        short M15_L12
       mov       rdx,offset MT_System.Boolean
       cmp       [rbx],rdx
       je        short M15_L11
       mov       rdx,rbx
       mov       rcx,offset MT_System.Boolean
       call      qword ptr [7FF919A35890]; System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       eax,[rbp+248]
M15_L11:
       movzx     ecx,byte ptr [rbx+8]
       test      ecx,ecx
       jne       near ptr M15_L14
M15_L12:
       call      qword ptr [7FF91A125E48]; System.Runtime.Serialization.SerializationInfo.GetThreadDeserializationTracker()
       movzx     eax,byte ptr [rax+8]
       test      eax,eax
       jne       near ptr M15_L14
M15_L13:
       mov       rcx,rdi
       call      qword ptr [7FF919C5EFA0]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp+58],rax
       xor       ecx,ecx
       mov       [rbp+1C8],rcx
       mov       [rbp+1CC],ecx
       mov       rax,7FF9B1FD5FF0
       call      rax
       lea       rdx,[rbp+1CC]
       mov       ecx,1
       mov       rax,7FF9B1FDBE20
       call      rax
       mov       edi,eax
       mov       rax,7FF9B1FD5F30
       call      rax
       mov       ecx,eax
       call      00007FF9796C6FE0
       test      edi,edi
       setne     al
       movzx     eax,al
       mov       [rbp+1C8],al
       movzx     eax,byte ptr [rbp+1C8]
       mov       [rbp+0BC],al
       mov       eax,[rbp+1CC]
       mov       [rbp+0B8],eax
       cmp       dword ptr [7FF9799839A0],0
       je        short M15_L15
       jmp       near ptr M15_L111
M15_L14:
       call      qword ptr [7FF91A2672A0]
       mov       rdi,rax
       mov       rcx,offset MT_System.Runtime.Serialization.SerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1A1A1
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rbx,rax
       mov       ecx,1C65C
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91A12D5C0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A2672B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L15:
       mov       eax,[rbp+248]
       mov       ebx,eax
       vxorps    xmm1,xmm1,xmm1
       vmovdqu   xmmword ptr [rbp+1B0],xmm1
       vmovdqu   xmmword ptr [rbp+1B8],xmm1
       mov       ecx,4
       cmp       ebx,6
       cmove     ebx,ecx
       cmp       qword ptr [rbp+58],0
       je        short M15_L16
       mov       rdx,[rbp+58]
       mov       esi,[rdx+8]
       cmp       esi,104
       jge       near ptr M15_L42
       test      esi,esi
       je        short M15_L16
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rdx+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M15_L42
       cmp       ecx,2E
       je        near ptr M15_L42
M15_L16:
       mov       rdx,[rbp+58]
       mov       rsi,rdx
M15_L17:
       xor       ecx,ecx
       mov       [rbp+1AC],ecx
       mov       byte ptr [rbp+0B4],0
       mov       rcx,2BFC6422278
       mov       r8,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       mov       r8d,[r8]
       and       r8d,0C0000
       cmp       r8d,40000
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       jne       near ptr M15_L43
       call      qword ptr [7FF919A37BD0]; System.RuntimeType.CreateInstanceOfT()
       mov       rdi,rax
M15_L18:
       xor       ecx,ecx
       mov       [rbp+198],rcx
       mov       [rbp+48],rdi
       mov       [rbp+20],rdi
       test      rsi,rsi
       je        near ptr M15_L22
       add       rsi,0C
M15_L19:
       mov       [rbp+1A0],rsi
       xor       ecx,ecx
       mov       rax,7FF9B1FD5FF0
       call      rax
       mov       [rsp+20],ebx
       mov       dword ptr [rsp+28],100000
       xor       r9d,r9d
       mov       [rsp+30],r9
       lea       r9,[rbp+1B0]
       mov       rcx,rsi
       mov       edx,40000000
       mov       r8d,1
       mov       rax,7FF919B2ADF0
       mov       [rbp+0E0],rax
       lea       rax,[M15_L20]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       mov       rax,7FF9B1FE4EA0
       call      rax
M15_L20:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M15_L21
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
M15_L21:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       rbx,rax
       mov       rax,7FF9B1FD5F30
       call      rax
       jmp       short M15_L23
M15_L22:
       xor       esi,esi
       jmp       near ptr M15_L19
M15_L23:
       xor       ecx,ecx
       mov       [rbp+1A0],rcx
       mov       dword ptr [rbp+1AC],1
       mov       byte ptr [rbp+0B4],1
       mov       rdi,[rbp+48]
       mov       [rdi+8],rbx
       mov       ecx,eax
       call      00007FF9796C6FE0
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M15_L44
       cmp       rcx,0FFFFFFFFFFFFFFFF
       je        near ptr M15_L44
       lea       rcx,[rdi+18]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+38],eax
       mov       byte ptr [rdi+16],0
       mov       [rbp+50],rdi
       cmp       qword ptr [rbp+1E0],0
       jle       near ptr M15_L50
       mov       rax,[rbp+1E0]
       mov       [rbp+190],rax
       xor       eax,eax
       mov       [rbp+18C],eax
       mov       [rbp+18],rax
       mov       byte ptr [rbp+0B0],0
       mov       [rbp+18],rdi
       mov       rdi,[rbp+50]
       mov       eax,[rdi+10]
       test      al,1
       jne       near ptr M15_L28
M15_L24:
       lea       rcx,[rdi+10]
       lea       edx,[rax+4]
       mov       [rbp+184],eax
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp+184]
       jne       near ptr M15_L27
       mov       byte ptr [rbp+0B0],1
       mov       rcx,[rbp+18]
       mov       rbx,[rcx+8]
       xor       ecx,ecx
       mov       rax,7FF9B1FD5FF0
       call      rax
       lea       r8,[rbp+190]
       mov       rcx,rbx
       mov       edx,5
       mov       r9d,8
       mov       rax,7FF919B2BA08
       mov       [rbp+0E0],rax
       lea       rax,[M15_L25]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FF919B2BA28]
M15_L25:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M15_L26
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
M15_L26:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       ebx,eax
       mov       rax,7FF9B1FD5F30
       call      rax
       mov       [rbp+188],eax
       test      ebx,ebx
       setne     cl
       movzx     ecx,cl
       mov       [rbp+18C],ecx
       jmp       short M15_L29
M15_L27:
       mov       eax,[rdi+10]
       test      al,1
       mov       rdi,[rbp+50]
       je        near ptr M15_L24
M15_L28:
       mov       rcx,rdi
       call      qword ptr [7FF91A264858]
       int       3
M15_L29:
       call      M15_L167
       nop
       mov       ecx,[rbp+188]
       call      00007FF9796C6FE0
       cmp       dword ptr [rbp+18C],0
       jne       near ptr M15_L50
       call      00007FF9796C6FC0
       mov       ebx,eax
       cmp       ebx,57
       je        short M15_L30
       cmp       ebx,70
       je        short M15_L30
       cmp       ebx,0DF
       jne       near ptr M15_L50
M15_L30:
       mov       rdi,[rbp+50]
       mov       esi,[rdi+10]
       test      sil,2
       jne       near ptr M15_L35
M15_L31:
       mov       r14d,esi
       and       r14d,0FFFFFFFC
       je        near ptr M15_L47
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       near ptr M15_L40
       cmp       byte ptr [rdi+14],0
       je        near ptr M15_L40
       mov       rcx,rdi
       call      qword ptr [7FF919B303A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       sete      cl
       movzx     ecx,cl
M15_L32:
       lea       eax,[rsi-4]
       cmp       r14d,4
       jne       short M15_L33
       or        eax,1
M15_L33:
       lea       rdx,[rdi+10]
       mov       r8d,eax
       or        r8d,2
       mov       eax,esi
       lock cmpxchg [rdx],r8d
       cmp       eax,esi
       jne       near ptr M15_L46
       test      ecx,ecx
       je        short M15_L35
       call      00007FF9796C6FC0
       mov       esi,eax
       mov       rcx,[rdi+8]
       call      qword ptr [7FF91A125F08]; Interop+Kernel32.CloseHandle(IntPtr)
       lea       rcx,[rdi+28]
       xor       eax,eax
       xchg      rax,[rcx]
       test      rax,rax
       jne       near ptr M15_L48
M15_L34:
       mov       ecx,esi
       call      00007FF9796C6FE0
M15_L35:
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M15_L36
       mov       rcx,rdi
       call      00007FF9796817C0
M15_L36:
       cmp       qword ptr [rbp+58],0
       je        short M15_L37
       mov       rdx,[rbp+58]
       mov       esi,[rdx+8]
       cmp       esi,104
       jge       near ptr M15_L49
       mov       rcx,rdx
       call      qword ptr [7FF919C5F108]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
       test      eax,eax
       jne       near ptr M15_L49
M15_L37:
       mov       rcx,[rbp+58]
       mov       rax,rcx
M15_L38:
       mov       rcx,rax
       call      qword ptr [7FF91A267AB0]; Interop+Kernel32.DeleteFilePrivate(System.String)
       cmp       ebx,70
       je        short M15_L41
       mov       rcx,2BFC64223D8
       call      qword ptr [7FF91A12F8B8]
       mov       rdi,rax
M15_L39:
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp+1E0]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,[rbp+58]
       call      qword ptr [7FF91A12D4D0]
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,ebx
       call      qword ptr [7FF91A267AC8]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF91A267AE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M15_L40:
       xor       ecx,ecx
       jmp       near ptr M15_L32
M15_L41:
       mov       rcx,2BFC6422380
       call      qword ptr [7FF91A12F8B8]
       mov       rdi,rax
       jmp       short M15_L39
M15_L42:
       mov       rcx,rdx
       call      qword ptr [7FF91A055E90]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       near ptr M15_L17
M15_L43:
       xor       r8d,r8d
       mov       [rbp+198],r8
       lea       rdx,[rbp+198]
       call      qword ptr [7FF91A264CA8]
       mov       rdi,[rbp+198]
       jmp       near ptr M15_L18
M15_L44:
       call      00007FF9796C6FC0
       mov       ebx,eax
       cmp       ebx,3
       jne       short M15_L45
       mov       rdx,[rbp+58]
       mov       esi,[rdx+8]
       lea       rcx,[rdx+0C]
       mov       [rbp+98],rcx
       mov       [rbp+0A0],esi
       lea       rcx,[rbp+98]
       call      qword ptr [7FF91A055E48]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       ecx,5
       cmp       eax,esi
       cmove     ebx,ecx
M15_L45:
       mov       rcx,rdi
       call      qword ptr [7FF919B30298]; Precode of System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,ebx
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       call      qword ptr [7FF91A2648A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L46:
       mov       esi,[rdi+10]
       test      sil,2
       jne       near ptr M15_L35
       jmp       near ptr M15_L31
M15_L47:
       mov       rcx,rdi
       call      qword ptr [7FF91A264858]
       int       3
M15_L48:
       mov       rcx,rax
       call      qword ptr [7FF91A2649A8]
       jmp       near ptr M15_L34
M15_L49:
       mov       rdx,[rbp+58]
       mov       rcx,rdx
       call      qword ptr [7FF91A055E90]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M15_L38
M15_L50:
       cmp       byte ptr [rbp+0BC],0
       je        short M15_L51
       xor       ecx,ecx
       mov       [rbp+178],ecx
       call      00007FF919A28CF0
       lea       rdx,[rbp+178]
       mov       ecx,[rbp+0B8]
       call      00007FF919A28D08
       call      00007FF919A28D20
       mov       ecx,eax
       call      00007FF9796C6FE0
M15_L51:
       mov       rcx,[rbp+50]
       mov       [rbp+70],rcx
       cmp       dword ptr [rbp+248],6
       je        near ptr M15_L93
M15_L52:
       xor       ebx,ebx
M15_L53:
       mov       [rbp+1E8],rbx
       cmp       dword ptr [rbp+0CC],0
       je        near ptr M15_L94
       mov       edx,2000
       cmp       dword ptr [rbp+0CC],2000
       cmovle    edx,[rbp+0CC]
       mov       rcx,offset MT_System.Text.UTF8Encoding
       mov       rax,[rbp+258]
       cmp       [rax],rcx
       jne       near ptr M15_L95
       mov       rcx,rax
       call      qword ptr [7FF919B8F278]; System.Text.UTF8Encoding.GetMaxByteCount(Int32)
M15_L54:
       mov       edx,eax
       add       edx,[rbp+0C8]
       jo        near ptr M15_L98
       xor       ecx,ecx
       mov       [rbp+68],rcx
       cmp       edx,400
       jbe       near ptr M15_L96
       mov       rcx,27F31401E50
       mov       rcx,[rcx]
       call      qword ptr [7FF91A062CE8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+68],rax
       test      rax,rax
       je        near ptr M15_L97
       lea       rsi,[rax+10]
       mov       r8d,[rax+8]
M15_L55:
       mov       [rbp+28],rsi
       mov       [rbp+0C4],r8d
       test      rbx,rbx
       jne       near ptr M15_L77
       cmp       [rbp+1F4],r8d
       jg        near ptr M15_L76
       mov       r8d,[rbp+1F4]
       mov       rcx,[rbp+28]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L56:
       mov       rcx,offset MT_System.Text.UTF8Encoding
       mov       rax,[rbp+258]
       cmp       [rax],rcx
       jne       near ptr M15_L79
       mov       rcx,offset MT_System.Text.EncoderNLS
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+18]
       mov       rdx,[rbp+258]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [rbx+24],0
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       near ptr M15_L78
M15_L57:
       mov       [rbp+60],rbx
       cmp       dword ptr [rbp+0CC],0
       je        near ptr M15_L92
M15_L58:
       cmp       dword ptr [rbp+0CC],2000
       jg        near ptr M15_L63
       mov       ebx,[rbp+0CC]
M15_L59:
       cmp       ebx,[rbp+0CC]
       ja        near ptr M15_L90
       mov       rsi,[rbp+38]
       mov       rcx,[rbp+38]
       mov       eax,ebx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp+0CC]
       sub       eax,ebx
       mov       [rbp+38],rcx
       mov       [rbp+0CC],eax
       mov       ecx,[rbp+1F4]
       cmp       ecx,[rbp+0C4]
       ja        near ptr M15_L90
       mov       edi,[rbp+1F4]
       add       rdi,[rbp+28]
       mov       r14d,[rbp+0C4]
       sub       r14d,[rbp+1F4]
       test      eax,eax
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,offset MT_System.Text.EncoderNLS
       mov       rax,[rbp+60]
       cmp       [rax],rcx
       jne       near ptr M15_L83
       test      ebx,ebx
       je        near ptr M15_L80
M15_L60:
       mov       [rbp+170],rsi
       test      r14d,r14d
       je        near ptr M15_L81
M15_L61:
       mov       [rbp+168],rdi
       test      rsi,rsi
       je        near ptr M15_L86
       test      rdi,rdi
       je        near ptr M15_L87
       test      r14d,r14d
       jl        near ptr M15_L88
       test      ebx,ebx
       jl        near ptr M15_L89
       mov       [rax+26],r9b
       mov       byte ptr [rax+27],1
       mov       r15,[rax+18]
       mov       rcx,offset MT_System.Text.UTF8Encoding
       cmp       [r15],rcx
       jne       near ptr M15_L82
       xor       r13d,r13d
       xor       r12d,r12d
       cmp       word ptr [rax+24],0
       jne       short M15_L64
       cmp       qword ptr [rax+10],0
       je        short M15_L62
       mov       rcx,[rax+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx]
       test      eax,eax
       jg        short M15_L64
M15_L62:
       lea       rcx,[rbp+160]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+158]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8,rdi
       mov       r9d,r14d
       call      qword ptr [7FF919A3FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       r12,[rbp+160]
       sub       r12,rsi
       mov       rcx,r12
       shr       rcx,3F
       add       r12,rcx
       sar       r12,1
       mov       r13d,[rbp+158]
       sub       r13d,edi
       cmp       r12d,ebx
       jne       short M15_L64
       mov       rax,[rbp+60]
       mov       [rax+20],ebx
       jmp       short M15_L65
M15_L63:
       mov       ebx,2000
       jmp       near ptr M15_L59
M15_L64:
       mov       rax,[rbp+60]
       mov       [rsp+20],r14d
       mov       [rsp+28],r12d
       mov       [rsp+30],r13d
       mov       [rsp+38],rax
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9,rdi
       call      qword ptr [7FF91A2648E8]
       mov       r13d,eax
       mov       rax,[rbp+60]
M15_L65:
       xor       edx,edx
       mov       [rbp+170],rdx
       mov       [rbp+168],rdx
M15_L66:
       add       r13d,[rbp+1F4]
       cmp       r13d,[rbp+0C4]
       ja        near ptr M15_L90
       mov       [rbp+0C0],r13d
       test      r13d,r13d
       je        near ptr M15_L75
       mov       rcx,[rbp+70]
       call      qword ptr [7FF919C563E8]; Microsoft.Win32.SafeHandles.SafeFileHandle.GetFileOptions()
       test      eax,40000000
       jne       near ptr M15_L84
       xor       ebx,ebx
       xor       r14d,r14d
       mov       rsi,[rbp+70]
       test      byte ptr [rsi+10],1
       jne       short M15_L68
       mov       edi,[rsi+3C]
       cmp       edi,0FFFFFFFF
       je        near ptr M15_L85
M15_L67:
       cmp       edi,1
       jne       short M15_L68
       mov       ebx,[rbp+1E8]
       mov       r14,[rbp+1E8]
       sar       r14,20
M15_L68:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rbp+138],ymm0
       mov       [rbp+148],ebx
       mov       [rbp+14C],r14d
       mov       rcx,[rbp+28]
       mov       [rbp+130],rcx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbp+128],eax
       mov       [rbp+124],eax
       mov       [rbp+10],rax
       mov       byte ptr [rbp+0AC],0
       mov       [rbp+10],rsi
       mov       eax,[rsi+10]
       test      al,1
       jne       near ptr M15_L73
M15_L69:
       lea       rdx,[rsi+10]
       lea       r8d,[rax+4]
       mov       [rbp+11C],eax
       lock cmpxchg [rdx],r8d
       cmp       eax,[rbp+11C]
       jne       near ptr M15_L72
       mov       byte ptr [rbp+0AC],1
       mov       rax,[rbp+10]
       mov       rdi,[rax+8]
       xor       ecx,ecx
       mov       rax,7FF9B1FD5FF0
       call      rax
       lea       r9,[rbp+138]
       mov       [rsp+20],r9
       lea       r9,[rbp+128]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r13d
       mov       rax,7FF919B2BC88
       mov       [rbp+0E0],rax
       lea       rax,[M15_L70]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       mov       rax,7FF9B1FE5310
       call      rax
M15_L70:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M15_L71
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
M15_L71:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       [rbp+124],eax
       mov       rax,7FF9B1FD5F30
       call      rax
       mov       [rbp+120],eax
       jmp       short M15_L74
M15_L72:
       mov       eax,[rsi+10]
       test      al,1
       mov       rsi,[rbp+70]
       je        near ptr M15_L69
M15_L73:
       mov       rcx,rsi
       call      qword ptr [7FF91A264858]
       int       3
M15_L74:
       call      M15_L114
       nop
       mov       ecx,[rbp+120]
       call      00007FF9796C6FE0
       cmp       dword ptr [rbp+124],0
       je        near ptr M15_L91
M15_L75:
       xor       ecx,ecx
       mov       [rbp+130],rcx
       mov       ecx,[rbp+0C0]
       add       rcx,[rbp+1E8]
       mov       [rbp+1E8],rcx
       xor       ecx,ecx
       mov       [rbp+1F4],ecx
       cmp       dword ptr [rbp+0CC],0
       jne       near ptr M15_L58
       jmp       near ptr M15_L92
M15_L76:
       call      qword ptr [7FF919E4CD38]
       int       3
M15_L77:
       xor       ecx,ecx
       mov       [rbp+1F4],ecx
       jmp       near ptr M15_L56
M15_L78:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M15_L57
M15_L79:
       mov       rax,[rbp+258]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M15_L57
M15_L80:
       mov       esi,1
       jmp       near ptr M15_L60
M15_L81:
       mov       edi,1
       jmp       near ptr M15_L61
M15_L82:
       mov       [rsp+20],r14d
       mov       [rsp+28],rax
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9,rdi
       mov       r10,[r15]
       mov       r10,[r10+70]
       call      qword ptr [r10+38]
       mov       r13d,eax
       mov       rax,[rbp+60]
       jmp       near ptr M15_L65
M15_L83:
       mov       [rbp+98],rsi
       mov       [rbp+0A0],ebx
       mov       [rbp+88],rdi
       mov       [rbp+90],r14d
       lea       rdx,[rbp+98]
       lea       r8,[rbp+88]
       mov       rcx,rax
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+10]
       mov       r13d,eax
       mov       rax,[rbp+60]
       jmp       near ptr M15_L66
M15_L84:
       mov       rcx,[rbp+28]
       mov       [rbp+78],rcx
       mov       [rbp+80],r13d
       lea       rdx,[rbp+78]
       mov       rcx,[rbp+70]
       mov       r8,[rbp+1E8]
       call      qword ptr [7FF91A264978]
       jmp       near ptr M15_L75
M15_L85:
       mov       rcx,rsi
       call      qword ptr [7FF919C567C0]; Interop+Kernel32.GetFileType(System.Runtime.InteropServices.SafeHandle)
       mov       edi,eax
       mov       [rsi+3C],edi
       jmp       near ptr M15_L67
M15_L86:
       mov       ecx,13C60
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A12C6D8]
       int       3
M15_L87:
       mov       ecx,11AD
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A12C6D8]
       int       3
M15_L88:
       mov       ecx,13C46
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF91A12C6A8]
       int       3
M15_L89:
       mov       ecx,13C80
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF91A12C6A8]
       int       3
M15_L90:
       call      qword ptr [7FF919BA7198]
       int       3
M15_L91:
       mov       rcx,[rbp+70]
       call      qword ptr [7FF91A264990]
       mov       ecx,eax
       mov       rax,[rbp+70]
       mov       rdx,[rax+18]
       xor       r8d,r8d
       call      qword ptr [7FF91A2648A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L92:
       call      M15_L129
       jmp       near ptr M15_L99
M15_L93:
       mov       rcx,[rbp+70]
       call      qword ptr [7FF919C567A8]; Microsoft.Win32.SafeHandles.SafeFileHandle.get_CanSeek()
       test      eax,eax
       je        near ptr M15_L52
       mov       rcx,[rbp+70]
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF91A267198]
       mov       rcx,[rbp+70]
       call      qword ptr [7FF91A2671B0]
       mov       rbx,rax
       jmp       near ptr M15_L53
M15_L94:
       cmp       dword ptr [rbp+0C8],0
       jle       short M15_L99
       test      rbx,rbx
       jne       short M15_L99
       mov       rdx,[rbp+30]
       mov       [rbp+78],rdx
       mov       edx,[rbp+0C8]
       mov       [rbp+80],edx
       lea       rdx,[rbp+78]
       mov       rcx,[rbp+70]
       xor       r8d,r8d
       call      qword ptr [7FF919C5C588]; System.IO.RandomAccess.WriteAtOffset(Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlySpan`1<Byte>, Int64)
       jmp       short M15_L99
M15_L95:
       mov       rcx,rax
       mov       r8,[rax]
       mov       r8,[r8+68]
       call      qword ptr [r8+28]
       jmp       near ptr M15_L54
M15_L96:
       test      [rsp],esp
       sub       rsp,400
       lea       rsi,[rsp+40]
       mov       r8d,400
       jmp       near ptr M15_L55
M15_L97:
       xor       esi,esi
       xor       r8d,r8d
       jmp       near ptr M15_L55
M15_L98:
       call      CORINFO_HELP_OVERFLOW
       int       3
M15_L99:
       call      M15_L152
       jmp       near ptr M15_L112
M15_L100:
       mov       ecx,1AC3C
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91A12FBD0]
       int       3
M15_L101:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,7FF96CC49278
       mov       ax,[rcx]
       mov       [rbx+10],ax
       mov       al,[rcx+2]
       mov       [rbx+12],al
       jmp       near ptr M15_L01
M15_L102:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M15_L01
M15_L103:
       xor       eax,eax
       xor       ebx,ebx
       jmp       near ptr M15_L02
M15_L104:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A2671E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF919C5D950]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L105:
       mov       ecx,1C638
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A05D3C8]
       int       3
M15_L106:
       mov       ecx,eax
       mov       edx,2
       call      qword ptr [7FF91A267228]
       mov       eax,[rbp+248]
       jmp       near ptr M15_L05
M15_L107:
       mov       rcx,2BFC64221C0
       mov       rdx,2BFC6422188
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       lea       rdx,[rbp+1D8]
       call      qword ptr [7FF919A367A8]; System.AppContext.TryGetSwitch(System.String, Boolean ByRef)
       movzx     ecx,byte ptr [rbp+1D8]
       test      ecx,eax
       je        short M15_L108
       mov       dword ptr [7FF91997B168],1
       mov       eax,[rbp+248]
       jmp       near ptr M15_L06
M15_L108:
       mov       dword ptr [7FF91997B168],0FFFFFFFF
       mov       eax,[rbp+248]
       jmp       near ptr M15_L06
M15_L109:
       mov       ecx,4
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       mov       eax,[rbp+248]
       jmp       near ptr M15_L07
M15_L110:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1A211
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A2672D0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L15
M15_L112:
       mov       r8,8EAE3BAD19
       cmp       [rbp+8],r8
       je        short M15_L113
       call      CORINFO_HELP_FAIL_FAST
M15_L113:
       nop
       lea       rsp,[rbp+1F8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M15_L114:
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+0AC],0
       je        near ptr M15_L128
       mov       rbx,[rbp+10]
       mov       rcx,[rbp+10]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        near ptr M15_L124
M15_L115:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M15_L121
       jmp       short M15_L117
M15_L116:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M15_L115
       jmp       short M15_L124
M15_L117:
       cmp       byte ptr [rbx+14],0
       je        short M15_L121
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L119
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M15_L118
       cmp       rcx,0FFFFFFFFFFFFFFFF
       sete      dil
       movzx     edi,dil
       jmp       short M15_L120
M15_L118:
       mov       edi,1
       jmp       short M15_L120
M15_L119:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M15_L120:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M15_L122
M15_L121:
       xor       ecx,ecx
M15_L122:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M15_L123
       or        edx,1
M15_L123:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M15_L116
       jmp       short M15_L125
M15_L124:
       mov       rcx,rbx
       call      qword ptr [7FF91A264858]
       int       3
M15_L125:
       test      ecx,ecx
       je        short M15_L128
       call      00007FF9796C6FC0
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L126
       mov       rdi,[rbx+8]
       xor       ecx,ecx
       call      00007FF919A28CF0
       mov       rcx,rdi
       call      00007FF919A28D98
       call      00007FF919A28D20
       mov       ecx,eax
       call      00007FF9796C6FE0
       add       rbx,28
       xor       ecx,ecx
       xchg      rcx,[rbx]
       test      rcx,rcx
       je        short M15_L127
       call      qword ptr [7FF91A2649A8]
       jmp       short M15_L127
M15_L126:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M15_L127:
       mov       ecx,esi
       call      00007FF9796C6FE0
M15_L128:
       nop
       add       rsp,48
       ret
M15_L129:
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp+68],0
       je        near ptr M15_L151
       mov       rcx,27F31401E50
       mov       rbx,[rcx]
       mov       rcx,[rbp+68]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M15_L130
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M15_L131
M15_L130:
       mov       ecx,0A
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M15_L131:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M15_L132
       mov       rcx,rbx
       call      qword ptr [7FF91A1250C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M15_L132:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M15_L147
       mov       edi,1
       mov       rdx,[rbp+68]
       mov       r8d,10
       shlx      r8d,r8d,esi
       cmp       [rdx+8],r8d
       je        short M15_L133
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A12D0B0]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF919DB6190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L133:
       cmp       esi,ecx
       jae       near ptr M15_L148
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+68]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M15_L147
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M15_L148
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M15_L134
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF91A265788]
M15_L134:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91997B184],0
       je        short M15_L135
       call      qword ptr [7FF91A12CFC0]
       mov       r15d,eax
       jmp       short M15_L137
M15_L135:
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       mov       r15d,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M15_L136
       call      qword ptr [7FF91A12CFF0]
       mov       r15d,eax
       jmp       short M15_L137
M15_L136:
       sar       r15d,10
M15_L137:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF91997B178]
       mov       r15d,edx
       xor       r12d,r12d
       jmp       near ptr M15_L144
M15_L138:
       cmp       r15d,[r14+8]
       jae       near ptr M15_L148
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+40],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+118],edx
       mov       rcx,rax
       call      qword ptr [7FF919F4DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+40]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M15_L140
       test      r8d,r8d
       jne       short M15_L141
       xor       edx,edx
       mov       [rax+14],edx
M15_L139:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+114]
       inc       ecx
       mov       rax,[rbp+40]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+118],1
M15_L140:
       mov       rcx,rax
       call      qword ptr [7FF919A36820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+118],0
       je        short M15_L142
       jmp       short M15_L145
M15_L141:
       jmp       short M15_L139
M15_L142:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M15_L143
       xor       r15d,r15d
M15_L143:
       inc       r12d
M15_L144:
       cmp       [r14+8],r12d
       jg        near ptr M15_L138
       jmp       short M15_L146
M15_L145:
       mov       r14d,1
       jmp       short M15_L147
M15_L146:
       xor       r14d,r14d
M15_L147:
       mov       rcx,27F31400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M15_L151
       mov       rcx,[rbp+68]
       cmp       dword ptr [rcx+8],0
       je        near ptr M15_L151
       mov       rcx,[rbp+68]
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+68]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF91A12D0E0]
       test      r14d,edi
       jne       short M15_L151
       mov       rcx,[rbp+68]
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+68]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M15_L149
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M15_L150
M15_L148:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L149:
       mov       ecx,esi
       xor       edx,edx
M15_L150:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF91A12D0F8]
M15_L151:
       nop
       add       rsp,48
       ret
M15_L152:
       sub       rsp,48
       vzeroupper
       mov       rcx,[rbp+70]
       mov       eax,[rcx+10]
       test      al,2
       jne       near ptr M15_L164
M15_L153:
       test      eax,0FFFFFFFC
       jne       short M15_L155
       jmp       short M15_L161
M15_L154:
       mov       eax,[rcx+10]
       test      al,2
       mov       rcx,[rbp+70]
       jne       near ptr M15_L164
       jmp       short M15_L153
M15_L155:
       mov       edx,eax
       and       edx,0FFFFFFFD
       cmp       edx,4
       jne       short M15_L158
       cmp       byte ptr [rcx+14],0
       je        short M15_L158
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        short M15_L156
       cmp       rdx,0FFFFFFFFFFFFFFFF
       sete      dl
       movzx     edx,dl
       jmp       short M15_L157
M15_L156:
       mov       edx,1
M15_L157:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       jmp       short M15_L159
M15_L158:
       xor       edx,edx
M15_L159:
       lea       r8d,[rax-4]
       mov       r10d,eax
       and       r10d,0FFFFFFFC
       cmp       r10d,4
       jne       short M15_L160
       or        r8d,1
M15_L160:
       lea       r10,[rcx+10]
       or        r8d,2
       mov       [rbp+110],eax
       lock cmpxchg [r10],r8d
       cmp       eax,[rbp+110]
       jne       short M15_L154
       jmp       short M15_L162
M15_L161:
       call      qword ptr [7FF91A264858]
       int       3
M15_L162:
       test      edx,edx
       je        short M15_L164
       call      00007FF9796C6FC0
       mov       ebx,eax
       mov       rcx,[rbp+70]
       mov       rsi,[rcx+8]
       xor       ecx,ecx
       call      00007FF919A28CF0
       mov       rcx,rsi
       call      00007FF919A28D98
       call      00007FF919A28D20
       mov       ecx,eax
       call      00007FF9796C6FE0
       mov       rcx,[rbp+70]
       lea       rax,[rcx+28]
       xor       edx,edx
       xchg      rdx,[rax]
       test      rdx,rdx
       je        short M15_L163
       mov       rcx,rdx
       call      qword ptr [7FF91A2649A8]
M15_L163:
       mov       ecx,ebx
       call      00007FF9796C6FE0
       mov       rcx,[rbp+70]
M15_L164:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M15_L165
       call      00007FF9796817C0
M15_L165:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       xor       ecx,ecx
       mov       [rbp+1A0],rcx
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       dword ptr [rbp+1AC],0
       je        short M15_L166
       cmp       byte ptr [rbp+0B4],0
       jne       short M15_L166
       mov       rcx,[rbp+20]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+20]
       call      qword ptr [7FF919A37AE0]; System.GC.SuppressFinalize(System.Object)
M15_L166:
       nop
       add       rsp,48
       ret
M15_L167:
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+0B0],0
       je        near ptr M15_L180
       mov       rbx,[rbp+18]
       mov       rcx,[rbp+18]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        short M15_L176
M15_L168:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M15_L173
       jmp       short M15_L170
M15_L169:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M15_L168
       jmp       short M15_L176
M15_L170:
       cmp       byte ptr [rbx+14],0
       je        short M15_L173
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L171
       mov       rcx,rbx
       call      qword ptr [7FF919B303A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       jmp       short M15_L172
M15_L171:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M15_L172:
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       jmp       short M15_L174
M15_L173:
       xor       ecx,ecx
M15_L174:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M15_L175
       or        edx,1
M15_L175:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M15_L169
       jmp       short M15_L177
M15_L176:
       mov       rcx,rbx
       call      qword ptr [7FF91A264858]
       int       3
M15_L177:
       test      ecx,ecx
       je        short M15_L180
       call      00007FF9796C6FC0
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L178
       mov       rcx,[rbx+8]
       call      qword ptr [7FF91A125F08]; Interop+Kernel32.CloseHandle(IntPtr)
       add       rbx,28
       xor       ecx,ecx
       xchg      rcx,[rbx]
       test      rcx,rcx
       je        short M15_L179
       call      qword ptr [7FF91A2649A8]
       jmp       short M15_L179
M15_L178:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M15_L179:
       mov       ecx,esi
       call      00007FF9796C6FE0
M15_L180:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+0BC],0
       je        short M15_L181
       xor       ecx,ecx
       mov       [rbp+178],ecx
       call      00007FF919A28CF0
       lea       rdx,[rbp+178]
       mov       ecx,[rbp+0B8]
       call      00007FF919A28D08
       call      00007FF919A28D20
       mov       ecx,eax
       call      00007FF9796C6FE0
M15_L181:
       nop
       add       rsp,48
       ret
; Total bytes of code 6611
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
       je        near ptr M16_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M16_L01
       test      rsi,rsi
       je        short M16_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M16_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M16_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M16_L00:
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
M16_L01:
       test      rsi,rsi
       je        short M16_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M16_L03
M16_L02:
       mov       rax,2BFC6410008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M16_L03:
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
M16_L04:
       call      qword ptr [7FF91A12CB28]
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
       call      qword ptr [7FF97D7384E0]
       cmp       byte ptr [rax],0
       je        near ptr M17_L03
       call      qword ptr [7FF97D73EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M17_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
M17_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M17_L01:
       call      qword ptr [7FF97D73A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M17_L00
       call      qword ptr [7FF97D7384D8]
       cmp       byte ptr [rax],0
       je        short M17_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF97D7402E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF97D73EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M17_L00
       cmp       [rsi+10],rbx
       je        short M17_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M17_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF97D73E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M17_L00
M17_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M17_L00
M17_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M17_L04
       call      qword ptr [7FF97D73A6A0]
       test      rax,rax
       je        near ptr M17_L00
M17_L04:
       call      qword ptr [7FF97D73CE58]
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
       call      qword ptr [7FF97D73E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF97D73C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M19_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M19_L07
M19_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M19_L08
M19_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF97D73B180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M19_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M19_L03
M19_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF97D73EEF8]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M19_L04
M19_L03:
       mov       rcx,rax
       call      qword ptr [7FF97D73B218]
       jmp       short M19_L02
M19_L04:
       cmp       byte ptr [rbp-10],0
       je        short M19_L05
       mov       rcx,rbx
       call      qword ptr [7FF97D73B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M19_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M19_L06:
       call      qword ptr [7FF97D73CE50]
       int       3
M19_L07:
       mov       rcx,rax
       call      qword ptr [7FF97D73B218]
       jmp       near ptr M19_L00
M19_L08:
       mov       rcx,rax
       call      qword ptr [7FF97D73E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M19_L01
       sub       rsp,28
       call      qword ptr [7FF97D73B210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF97D738278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF97D738258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M19_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF97D73B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M19_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M20_L00
       cmp       [rdx],rcx
       jne       short M20_L01
M20_L00:
       mov       rax,rdx
       ret
M20_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
M20_L02:
       test      rax,rax
       je        short M20_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       test      rax,rax
       je        short M20_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       test      rax,rax
       je        short M20_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       test      rax,rax
       je        short M20_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       jmp       short M20_L02
M20_L03:
       jmp       qword ptr [7FF91A12D308]
; Total bytes of code 90
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF96D8BDCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M21_L01
       cmp       [rax],ecx
       jle       short M21_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M21_L03
M21_L00:
       add       rsp,20
       pop       rbx
       ret
M21_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M21_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M21_L00
M21_L02:
       cmp       [rax+4],edx
       jle       short M21_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M21_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M21_L03
       jmp       short M21_L00
M21_L03:
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
       jne       short M22_L00
       ret
M22_L00:
       jmp       qword ptr [7FF919A35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M23_L05
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M23_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M23_L06
M23_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M23_L07
M23_L01:
       xor       r13d,r13d
       mov       r12d,1
       mov       ecx,[r15+8]
       cmp       ecx,r14d
       jbe       short M23_L03
       mov       r13d,1
       test      sil,sil
       jne       near ptr M23_L08
M23_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M23_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M23_L10
M23_L03:
       mov       rcx,27F31400C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M23_L25
M23_L04:
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
M23_L05:
       mov       ecx,2
       call      qword ptr [7FF919C5C240]
       int       3
M23_L06:
       mov       ecx,0A
       call      qword ptr [7FF91A12C990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M23_L00
M23_L07:
       mov       rcx,rdi
       call      qword ptr [7FF91A1250C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M23_L01
M23_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91A12D098]
       jmp       near ptr M23_L02
M23_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF91A12D0B0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF919DB6190]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M23_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M23_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M23_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF91A265788]
M23_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF91997B184],0
       je        short M23_L12
       call      qword ptr [7FF91A12CFC0]
       mov       esi,eax
       jmp       short M23_L14
M23_L12:
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       mov       esi,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FF91A12CFD8]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M23_L13
       call      qword ptr [7FF91A12CFF0]
       mov       esi,eax
       jmp       short M23_L14
M23_L13:
       sar       esi,10
M23_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF919A35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF91997B178]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M23_L21
M23_L15:
       cmp       esi,[r12+8]
       jae       near ptr M23_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF919F4DC98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M23_L17
       test      r8d,r8d
       jne       short M23_L18
       xor       edx,edx
       mov       [rax+14],edx
M23_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M23_L17:
       mov       rcx,rax
       call      qword ptr [7FF919A36820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M23_L19
       jmp       short M23_L22
M23_L18:
       jmp       short M23_L16
M23_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M23_L20
       xor       esi,esi
M23_L20:
       mov       eax,[rsp+40]
       inc       eax
M23_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M23_L15
       jmp       short M23_L23
M23_L22:
       mov       r12d,1
       jmp       short M23_L24
M23_L23:
       xor       r12d,r12d
M23_L24:
       jmp       near ptr M23_L03
M23_L25:
       test      ebp,ebp
       je        near ptr M23_L04
       mov       rcx,rbx
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF91A12D0E0]
       test      r12d,r13d
       jne       near ptr M23_L04
       mov       rcx,rbx
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF919E4D3E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M23_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M23_L27
M23_L26:
       mov       ecx,r14d
       xor       edx,edx
M23_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FF91A12D0F8]
       jmp       near ptr M23_L04
M23_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.SaveToFileCollection()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,[rcx+148]
       mov       rcx,[rcx+140]
       mov       rax,18479C00D50
       mov       rax,[rax]
       cmp       [rbx],bl
       test      rcx,rcx
       je        near ptr M00_L32
       mov       rsi,rcx
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF919A3C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L03
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FF919A37C30]; System.RuntimeType.InitializeCache()
M00_L01:
       mov       r14,[rax+18]
       test      r14,r14
       je        short M00_L04
M00_L02:
       mov       rcx,18477F11158
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L05
       mov       rax,rcx
       jmp       short M00_L06
M00_L03:
       mov       rax,rcx
       jmp       short M00_L01
M00_L04:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FF919BA4AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r14,rax
       jmp       short M00_L02
M00_L05:
       mov       rcx,1C50EBFE4F0
       call      qword ptr [7FF919A37C30]; System.RuntimeType.InitializeCache()
M00_L06:
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L25
M00_L07:
       cmp       r14,rdx
       je        near ptr M00_L36
       test      r14,r14
       je        short M00_L08
       test      rdx,rdx
       je        short M00_L08
       mov       ecx,[r14+8]
       cmp       ecx,[rdx+8]
       je        near ptr M00_L33
M00_L08:
       mov       r14,1C50EBF0008
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FF919A3C9A8]; System.Object.GetType()
       mov       r15,rax
       mov       rcx,1848FC001C8
       mov       r13,[rcx]
       mov       rcx,18479C01D80
       mov       r12,[rcx]
       test      r13,r13
       je        near ptr M00_L37
M00_L10:
       mov       rax,[r12+8]
       mov       [rbp-68],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r12+19],0
       jne       near ptr M00_L26
       mov       rdx,r15
       mov       r11,7FF919980A70
       call      qword ptr [r11]
M00_L11:
       mov       [rbp-3C],eax
       mov       r8,[rbp-68]
       mov       r10,[r8+8]
       mov       [rbp-70],r10
       mov       rcx,[r8+10]
       mov       edx,eax
       imul      rdx,[r8+28]
       shr       rdx,20
       inc       rdx
       mov       r9d,[rcx+8]
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,edx
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       je        near ptr M00_L39
       test      r10,r10
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r10],rcx
       jne       near ptr M00_L27
M00_L12:
       cmp       eax,[r9+20]
       jne       near ptr M00_L38
       mov       [rbp-78],r9
       mov       r11,[r9+8]
       test      r11,r11
       je        near ptr M00_L41
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r11],rcx
       jne       near ptr M00_L40
       cmp       r15,r11
       sete      dl
       movzx     edx,dl
M00_L13:
       test      edx,edx
       je        near ptr M00_L41
M00_L14:
       mov       r9,[rbp-78]
       mov       rdx,[r9+10]
       mov       [rbp-48],rdx
M00_L15:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r15+8]
       mov       ecx,r12d
       test      ecx,ecx
       jle       short M00_L16
       call      qword ptr [7FF919A35A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-80],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-88],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rcx,18479C00048
       mov       rax,[rcx]
       mov       [rbp-98],rax
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18479C00050
       mov       rax,[rcx]
       mov       rdx,rax
       mov       [rbp-0A0],rdx
       mov       rax,rdx
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r12d,r12d
       jle       short M00_L18
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<.cctor>b__12_0(System.Reflection.PropertyInfo)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L48
       add       r15,10
M00_L17:
       mov       rdi,[r15]
       mov       dword ptr [rsp+20],1
       mov       rcx,r13
       mov       rdx,rdi
       mov       r8,rsi
       mov       r9,r14
       call      qword ptr [7FF91A05F8E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryAddSelectedPropertyValue(System.Collections.Generic.Dictionary`2<System.String,System.String>, System.Reflection.PropertyInfo, System.Object, System.String, Boolean)
       add       r15,8
       dec       r12d
       jne       short M00_L17
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,[r13+38]
       sub       ecx,[r13+40]
       js        near ptr M00_L50
       test      ecx,ecx
       jle       short M00_L19
       call      qword ptr [7FF919A35A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       dword ptr [rsi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+30],rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L19:
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-0A0]
       mov       rdx,rdi
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[r13+44]
       xor       r14d,r14d
M00_L20:
       cmp       r14d,[r13+38]
       jae       near ptr M00_L23
M00_L21:
       mov       r9,[r13+10]
       lea       r8d,[r14+1]
       mov       r15d,r8d
       cmp       r14d,[r9+8]
       jae       near ptr M00_L54
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       r8,[r9+r8*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        near ptr M00_L51
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       r9,[r8+8]
       mov       r8,[r8]
       lea       rcx,[rbp-60]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair<System.String, System.String>
       call      qword ptr [7FF91A13E688]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       rdx,[rbp-60]
       mov       r8,[rbp-58]
       test      r8,r8
       je        short M00_L22
       cmp       dword ptr [r8+8],0
       je        short M00_L22
       mov       rcx,rsi
       mov       r9d,1
       call      qword ptr [7FF919A366A0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L22:
       cmp       edi,[r13+44]
       mov       r14d,r15d
       je        near ptr M00_L20
       jmp       near ptr M00_L52
M00_L23:
       mov       rcx,rsi
       mov       r8,1C50EBF7DA8
       mov       rdx,1C50EBF0008
       mov       r9d,3A
       call      qword ptr [7FF91A05DC80]; DotNetTips.Spargine.Extensions.ObjectExtensions.BuildKeyValueString(System.Collections.Generic.IReadOnlyDictionary`2<System.String,System.String>, System.String, System.String, Char)
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF919C5E3D0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L53
       mov       rbx,[rbx+8]
       mov       rcx,1C50EC007D0
       call      qword ptr [7FF91A05DBD8]; DotNetTips.Spargine.Tester.UnitTester.GenerateFileName(System.String)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919DBE4C0]; System.IO.Path.Combine(System.String, System.String)
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF91A05DBF0]; System.IO.File.WriteAllText(System.String, System.String)
       mov       rax,rbx
M00_L24:
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
M00_L25:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FF919BA4AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,r15
       mov       rdx,[7FF91997A1C0]
       call      qword ptr [rdx+18]
       jmp       near ptr M00_L11
M00_L27:
       cmp       eax,[r9+20]
       jne       near ptr M00_L44
       mov       [rbp-78],r9
       mov       r11,[r9+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r10],rcx
       jne       near ptr M00_L42
       mov       r10,[rbp-70]
       test      r11,r11
       je        near ptr M00_L43
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r11],rcx
       jne       near ptr M00_L45
       cmp       r15,r11
       sete      dl
       movzx     edx,dl
M00_L28:
       test      edx,edx
       je        near ptr M00_L46
       jmp       near ptr M00_L14
M00_L29:
       mov       rdx,[r15]
       mov       rax,rdx
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<.cctor>b__12_0(System.Reflection.PropertyInfo)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L49
M00_L30:
       mov       dword ptr [rsp+20],1
       mov       rcx,r13
       mov       rdx,rax
       mov       r8,rsi
       mov       r9,r14
       call      qword ptr [7FF91A05F8E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryAddSelectedPropertyValue(System.Collections.Generic.Dictionary`2<System.String,System.String>, System.Reflection.PropertyInfo, System.Object, System.String, Boolean)
M00_L31:
       add       r15,8
       dec       r12d
       jne       short M00_L29
       jmp       near ptr M00_L18
M00_L32:
       call      qword ptr [7FF919FBEC88]
       mov       ecx,58B
       mov       rdx,7FF919D04A80
       call      qword ptr [7FF919C577B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF919D05550
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FF919D04A80
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919A37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A13E580]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A1379D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       lea       rcx,[r14+0C]
       add       rdx,0C
       mov       r8d,[r14+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L34
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      al
       movzx     eax,al
       jmp       short M00_L35
M00_L34:
       call      qword ptr [7FF919A3FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L35:
       test      eax,eax
       je        near ptr M00_L08
M00_L36:
       mov       r14,1C50EBF4B70
       jmp       near ptr M00_L09
M00_L37:
       mov       rcx,offset MT_System.Func<System.Type, System.Reflection.PropertyInfo[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1848FC001A8
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<BuildSelectedPropertiesDictionary>b__25_0(System.Type)
       call      qword ptr [7FF919A36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1848FC001C8
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
M00_L38:
       mov       [rbp-78],r9
       jmp       short M00_L41
M00_L39:
       jmp       near ptr M00_L47
M00_L40:
       mov       rcx,r11
       mov       rdx,r15
       mov       r10,[r11]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       edx,eax
       jmp       near ptr M00_L13
M00_L41:
       mov       r9,[rbp-78]
       mov       r9,[r9+18]
       test      r9,r9
       je        short M00_L47
       mov       eax,[rbp-3C]
       jmp       near ptr M00_L12
M00_L42:
       mov       r10,[rbp-70]
       mov       rcx,r10
       mov       r8,r15
       mov       rdx,r11
       mov       r11,7FF919980A78
       call      qword ptr [r11]
       mov       edx,eax
       mov       r10,[rbp-70]
       jmp       near ptr M00_L28
M00_L43:
       mov       r9,[rbp-78]
M00_L44:
       mov       r9,[r9+18]
       test      r9,r9
       je        short M00_L47
       mov       eax,[rbp-3C]
       jmp       near ptr M00_L27
M00_L45:
       mov       rcx,r11
       mov       rdx,r15
       mov       r11,[r11]
       mov       r11,[r11+40]
       call      qword ptr [r11+10]
       mov       edx,eax
       mov       r10,[rbp-70]
       jmp       near ptr M00_L28
M00_L46:
       mov       r9,[rbp-78]
       jmp       short M00_L44
M00_L47:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rdx,r15
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-3C]
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-68]
       mov       r8,r15
       mov       rcx,r12
       call      qword ptr [7FF919DBC660]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L15
M00_L48:
       add       r15,10
       jmp       near ptr M00_L29
M00_L49:
       mov       [rbp-90],rax
       mov       rdx,rax
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       rax,[rbp-90]
       je        near ptr M00_L31
       jmp       near ptr M00_L30
M00_L50:
       mov       ecx,16
       call      qword ptr [7FF919C578E8]
       int       3
M00_L51:
       cmp       r15d,[r13+38]
       mov       r14d,r15d
       jb        near ptr M00_L21
       jmp       near ptr M00_L23
M00_L52:
       call      qword ptr [7FF919C5C150]
       int       3
M00_L53:
       mov       rax,1C50EBF0008
       jmp       near ptr M00_L24
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2085
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
       call      qword ptr [7FF919A35C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FF979557BF0
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
       mov       rax,7FF919B71B50
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF9795A7290
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M02_L04
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF97968F260
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
       call      qword ptr [7FF91A274360]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF91A137A50]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF919A37C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       rbx,rcx
       mov       edi,r8d
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M03_L03
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M03_L04
       mov       rcx,[rcx+18]
M03_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FF919A762A8
       mov       [rbp-70],rax
       lea       rax,[M03_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FF9795F5B90
       call      rax
M03_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FF9799839A0],0
       je        short M03_L02
       call      qword ptr [7FF979971648]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-78]
       mov       [r14+8],rcx
       mov       rbx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
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
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A1379C0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF91A1379D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L04:
       xor       ecx,ecx
       jmp       near ptr M03_L00
; Total bytes of code 312
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M04_L02
       mov       rcx,7FF96CC40BB8
       xor       eax,eax
       mov       edx,48
M04_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M04_L01
       add       rax,4
       dec       edx
       jne       short M04_L00
       jmp       short M04_L03
M04_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A137990]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919DB42A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M04_L06
M04_L04:
       mov       ecx,esi
       call      qword ptr [7FF91A1379A8]
       test      eax,eax
       je        short M04_L05
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
       jne       short M04_L07
M04_L05:
       add       esi,2
M04_L06:
       cmp       esi,7FFFFFFF
       jl        short M04_L04
       jmp       short M04_L08
M04_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 182
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<.cctor>b__12_0(System.Reflection.PropertyInfo)
       mov       eax,1
       ret
; Total bytes of code 6
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryAddSelectedPropertyValue(System.Collections.Generic.Dictionary`2<System.String,System.String>, System.Reflection.PropertyInfo, System.Object, System.String, Boolean)
; 			AddSelectedPropertyValueCore(properties, property, obj, typeName, ignoreNulls);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		catch (Exception ex)
; 		^^^^^^^^^^^^^^^^^^^^
; 			AddPropertyError(properties, property, typeName, ignoreNulls, ex.GetType().Name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rcx,rdx
       mov       rbx,r8
       mov       rsi,[rcx]
       mov       rdi,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       rsi,rdi
       jne       near ptr M06_L18
       cmp       qword ptr [rcx+18],0
       je        near ptr M06_L36
       lea       rdx,[rbp-48]
       call      qword ptr [7FF919A3FE28]; System.Reflection.RuntimePropertyInfo.GetIndexParametersSpan()
       mov       r14d,[rbp-40]
       test      r14d,r14d
       jne       near ptr M06_L15
       mov       rdx,18479C00228
       mov       r15,[rdx]
M06_L00:
       cmp       dword ptr [r15+8],0
       jne       near ptr M06_L36
       cmp       rsi,rdi
       jne       near ptr M06_L23
       mov       rcx,[rbp+18]
       mov       rdx,[rcx+18]
       xor       r8d,r8d
       test      rdx,rdx
       cmove     rdx,r8
       test      rdx,rdx
       je        near ptr M06_L22
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       [rsp+28],r8
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF919B79D98]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdi,rax
       mov       rcx,[rbp+18]
       mov       r14,[rcx+8]
       test      r14,r14
       je        near ptr M06_L24
M06_L01:
       cmp       qword ptr [rbp+28],0
       je        short M06_L02
       mov       rax,[rbp+28]
       cmp       dword ptr [rax+8],0
       jne       near ptr M06_L25
M06_L02:
       mov       rsi,r14
M06_L03:
       test      rdi,rdi
       je        near ptr M06_L26
       mov       rax,offset MT_System.Boolean
       cmp       [rdi],rax
       je        near ptr M06_L17
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rbx,rax
M06_L04:
       mov       rdi,[rbp+10]
       cmp       [rdi],dil
       test      rsi,rsi
       je        near ptr M06_L27
       cmp       qword ptr [rdi+8],0
       je        near ptr M06_L28
M06_L05:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rdx
       jne       near ptr M06_L29
       lea       rdx,[rsi+0C]
       mov       [rbp-70],rdx
       mov       edx,15051505
       mov       r11d,15051505
       mov       rax,[rbp-70]
       mov       r8d,[rsi+8]
       cmp       r8d,2
       jle       short M06_L07
M06_L06:
       add       r8d,0FFFFFFFC
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[rax]
       mov       r10d,r11d
       rol       r10d,5
       add       r11d,r10d
       xor       r11d,[rax+4]
       add       rax,8
       cmp       r8d,2
       jg        short M06_L06
M06_L07:
       test      r8d,r8d
       jle       short M06_L08
       mov       r8d,r11d
       rol       r8d,5
       add       r8d,r11d
       mov       r11d,r8d
       xor       r11d,[rax]
M06_L08:
       imul      r13d,r11d,5D588B65
       add       r13d,edx
       xor       edx,edx
       mov       [rbp-70],rdx
M06_L09:
       xor       r12d,r12d
       mov       rdx,[rdi+8]
       mov       r8d,r13d
       imul      r8,[rdi+30]
       shr       r8,20
       inc       r8
       mov       r11d,[rdx+8]
       imul      r8,r11
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M06_L33
       mov       r8d,r8d
       lea       rax,[rdx+r8*4+10]
       mov       [rbp-88],rax
       mov       r10d,[rax]
       dec       r10d
       mov       r9d,[r14+8]
       mov       [rbp-74],r9d
       cmp       r9d,r10d
       ja        short M06_L10
       mov       r9d,[rbp-74]
       jmp       short M06_L12
M06_L10:
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rbp-98],r11
       cmp       [r11+10],r13d
       je        near ptr M06_L30
M06_L11:
       mov       r11,[rbp-98]
       mov       r10d,[r11+14]
       inc       r12d
       mov       r9d,[rbp-74]
       cmp       r9d,r12d
       jb        near ptr M06_L31
       cmp       r9d,r10d
       ja        short M06_L10
M06_L12:
       cmp       dword ptr [rdi+40],0
       jg        near ptr M06_L32
       mov       r14d,[rdi+38]
       cmp       r9d,r14d
       je        near ptr M06_L34
M06_L13:
       lea       edx,[r14+1]
       mov       [rdi+38],edx
       mov       rdx,[rdi+10]
       mov       r8,rdx
M06_L14:
       cmp       r14d,[r8+8]
       jae       near ptr M06_L33
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       mov       [rbp-80],r8
       lea       r10,[r8+rdx*8+10]
       mov       [rbp-90],r10
       mov       [r10+10],r13d
       mov       rax,[rbp-88]
       mov       edx,[rax]
       dec       edx
       mov       [r10+14],edx
       mov       rcx,r10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-90]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rbx,[rbp-88]
       mov       [rbx],r14d
       inc       dword ptr [rdi+44]
       cmp       r12d,64
       jbe       near ptr M06_L36
       jmp       near ptr M06_L35
M06_L15:
       mov       edx,r14d
       mov       rcx,offset MT_System.Reflection.ParameterInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,[rbp-48]
       mov       r8d,r14d
       shl       r8,3
       cmp       r8,4000
       ja        short M06_L20
       call      00007FF97965FAA0
       cmp       dword ptr [7FF9799839A0],0
       jne       short M06_L19
M06_L16:
       jmp       near ptr M06_L00
M06_L17:
       add       rdi,8
       mov       rbx,1C50EBF01E0
       mov       rdx,1C50EBF01C0
       cmp       byte ptr [rdi],0
       cmove     rbx,rdx
       jmp       near ptr M06_L04
M06_L18:
       mov       rax,[rsi+50]
       call      qword ptr [rax+28]
       test      eax,eax
       je        near ptr M06_L36
       jmp       short M06_L21
M06_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       short M06_L16
M06_L20:
       call      qword ptr [7FF919FBE688]
       jmp       short M06_L16
M06_L21:
       mov       rcx,[rbp+18]
       mov       rax,[rsi+50]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M06_L00
M06_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A13C000]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF919DB42A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rsi+58]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+18]
       mov       rax,[rsi+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       mov       rcx,[rbp+18]
       jmp       near ptr M06_L01
M06_L24:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-58],xmm0
       mov       rdx,[rcx+48]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF91A13E460]
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-68],xmm0
       lea       rcx,[rbp-68]
       call      qword ptr [7FF919F4DB90]; System.MdUtf8String.ToString()
       mov       r14,rax
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       jmp       near ptr M06_L01
M06_L25:
       mov       ecx,1
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       word ptr [rax+0C],2E
       mov       rcx,[rbp+28]
       mov       rdx,rax
       mov       r8,r14
       call      qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,[rbp+18]
       jmp       near ptr M06_L03
M06_L26:
       cmp       byte ptr [rbp+30],0
       jne       near ptr M06_L36
       mov       rdi,[rbp+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,1C50EBF0008
       mov       r9d,1
       call      qword ptr [7FF919A366A0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M06_L36
M06_L27:
       mov       ecx,4
       call      qword ptr [7FF919C5C240]
       int       3
M06_L28:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF919A35A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M06_L05
M06_L29:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r11,7FF919980A40
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M06_L09
M06_L30:
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,r15
       mov       r8,rsi
       mov       r11,7FF919980A48
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L11
       mov       r11,[rbp-98]
       lea       rcx,[r11+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L36
M06_L31:
       call      qword ptr [7FF919C57A20]
       int       3
M06_L32:
       mov       edx,[rdi+3C]
       mov       r8d,edx
       mov       edx,[rdi+3C]
       cmp       edx,r9d
       jae       short M06_L33
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rdi+3C],edx
       dec       dword ptr [rdi+40]
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M06_L14
M06_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L34:
       mov       rcx,rdi
       call      qword ptr [7FF91A1378B8]
       mov       rcx,[rdi+8]
       mov       edx,r13d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M06_L33
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-88],rax
       jmp       near ptr M06_L13
M06_L35:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L36
       mov       r14,[rbp-80]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF919BAF3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       nop
M06_L36:
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
       sub       rsp,38
       cmp       [rcx],ecx
       call      qword ptr [7FF91A05F918]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rbx,rax
       cmp       byte ptr [rbp+30],0
       jne       near ptr M06_L40
       cmp       qword ptr [rbp+28],0
       je        short M06_L37
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       jne       short M06_L38
M06_L37:
       mov       rcx,[rbp+18]
       mov       rdi,[rcx]
       mov       rax,[rdi+40]
       call      qword ptr [rax+30]
       mov       rsi,rax
       jmp       short M06_L39
M06_L38:
       mov       ecx,1
       call      qword ptr [7FF919A36670]; System.String.FastAllocateString(IntPtr)
       mov       rsi,rax
       mov       word ptr [rsi+0C],2E
       mov       rcx,[rbp+18]
       mov       rax,[rcx]
       mov       rdi,rax
       mov       rax,[rdi+40]
       call      qword ptr [rax+30]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,[rbp+28]
       call      qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
       mov       rsi,rax
M06_L39:
       mov       rdx,rbx
       mov       rcx,1C50EC02470
       mov       r8,1C50EC02498
       call      qword ptr [7FF919A37828]; System.String.Concat(System.String, System.String, System.String)
       mov       r8,rax
       mov       rdi,[rbp+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FF919A366A0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M06_L40:
       lea       rax,[M06_L36]
       add       rsp,38
       ret
; Total bytes of code 1675
```
```assembly
; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r9
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+50],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M08_L13
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L14
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M08_L12
M08_L01:
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M08_L15
       lea       rcx,[rsi+0C]
       mov       [rsp+40],rcx
       mov       ecx,15051505
       mov       r11d,15051505
       mov       rdx,[rsp+40]
       mov       eax,[rsi+8]
       cmp       eax,2
       jle       short M08_L03
M08_L02:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[rdx]
       mov       r8d,r11d
       rol       r8d,5
       add       r11d,r8d
       xor       r11d,[rdx+4]
       add       rdx,8
       cmp       eax,2
       jg        short M08_L02
M08_L03:
       test      eax,eax
       jle       short M08_L04
       mov       eax,r11d
       rol       eax,5
       add       eax,r11d
       mov       r11d,eax
       xor       r11d,[rdx]
M08_L04:
       imul      r13d,r11d,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
M08_L05:
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
       jae       near ptr M08_L27
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+30],rax
       mov       r8d,[rax]
       dec       r8d
       mov       r10d,[r14+8]
       mov       [rsp+3C],r10d
       cmp       r10d,r8d
       ja        near ptr M08_L10
       mov       r10d,[rsp+3C]
M08_L06:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L24
       mov       ebp,[rbx+38]
       cmp       r10d,ebp
       je        near ptr M08_L25
M08_L07:
       lea       ecx,[rbp+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L08:
       cmp       ebp,[r14+8]
       jae       near ptr M08_L27
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r14+rcx*8+10]
       mov       [rsp+28],r8
       mov       [r8+10],r13d
       mov       rax,[rsp+30]
       mov       ecx,[rax]
       dec       ecx
       mov       [r8+14],ecx
       mov       rcx,r8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+28]
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       rdi,[rsp+30]
       mov       [rdi],ebp
       inc       dword ptr [rbx+44]
       cmp       r12d,64
       ja        near ptr M08_L26
M08_L09:
       mov       eax,1
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L10:
       mov       [rsp+4C],r8d
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r9,[r14+rcx*8+10]
       mov       [rsp+20],r9
       cmp       [r9+10],r13d
       je        short M08_L16
M08_L11:
       mov       r9,[rsp+20]
       mov       r8d,[r9+14]
       mov       ecx,r8d
       inc       r12d
       mov       r10d,[rsp+3C]
       cmp       r10d,r12d
       jb        near ptr M08_L23
       cmp       r10d,ecx
       mov       r8d,ecx
       ja        short M08_L10
       jmp       near ptr M08_L06
M08_L12:
       mov       rdx,7FF91A11FF58
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L01
M08_L13:
       mov       ecx,4
       call      qword ptr [7FF919C5C240]
       int       3
M08_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF919A35A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L15:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L05
M08_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M08_L17
       jmp       short M08_L18
M08_L17:
       mov       rdx,7FF91A11FF70
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L18:
       mov       edx,[rsp+4C]
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M08_L11
       cmp       bpl,1
       jne       short M08_L19
       mov       r9,[rsp+20]
       lea       rcx,[r9+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L09
M08_L19:
       cmp       bpl,2
       jne       short M08_L22
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M08_L20
       mov       rcx,rax
       jmp       short M08_L21
M08_L20:
       mov       rdx,7FF91A161D58
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M08_L21:
       mov       rdx,rsi
       call      qword ptr [7FF919C5C210]
       int       3
M08_L22:
       xor       eax,eax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L23:
       call      qword ptr [7FF919C57A20]
       int       3
M08_L24:
       mov       ebp,[rbx+3C]
       mov       ecx,[rbx+3C]
       cmp       ecx,r10d
       jae       near ptr M08_L27
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L08
M08_L25:
       mov       rcx,rbx
       call      qword ptr [7FF91A1378B8]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M08_L27
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       r14,rax
       mov       [rsp+30],r14
       jmp       near ptr M08_L07
M08_L26:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M08_L09
       mov       edx,[r14+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF919BAF3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M08_L09
M08_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 938
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.BuildKeyValueString(System.Collections.Generic.IReadOnlyDictionary`2<System.String,System.String>, System.String, System.String, Char)
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (header is { Length: > 0 })
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(header);
; 				^^^^^^^^^^^^^^^^^^^^^^
; 			AppendPropertiesPairs(sb, properties, sequenceSeparator, keyValueSeparator);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       r15,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r14d,r9d
       mov       rcx,18479C01D88
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M09_L36
       mov       rdi,[rcx+18]
M09_L00:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M09_L40
       mov       rcx,[rdi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M09_L38
       lea       rcx,[rdi+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M09_L37
       xor       edx,edx
       call      00007FF979669BA0
       cmp       rax,[rbp-38]
       jne       near ptr M09_L38
M09_L01:
       mov       rcx,[rbp-38]
M09_L02:
       xor       eax,eax
       mov       [rbp-38],rax
M09_L03:
       mov       [rbp-78],rcx
       test      rsi,rsi
       je        short M09_L04
       cmp       dword ptr [rsi+8],0
       jg        near ptr M09_L31
M09_L04:
       mov       r13d,1
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       cmp       [r15],rcx
       jne       near ptr M09_L33
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        near ptr M09_L32
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       [rbp-70],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-70]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M09_L05:
       mov       rcx,rdx
M09_L06:
       mov       [rbp-88],rcx
M09_L07:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Enumerator
       mov       rax,[rbp-88]
       cmp       [rax],rcx
       jne       near ptr M09_L26
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M09_L27
       mov       ecx,[rsi+0C]
       cmp       ecx,[rdx+38]
       jae       near ptr M09_L19
M09_L08:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M09_L28
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M09_L25
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       vmovdqu   xmm0,xmmword ptr [rax+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M09_L09:
       test      r13d,r13d
       jne       short M09_L11
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       test      rbx,rbx
       je        short M09_L11
       lea       rdx,[rbx+0C]
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        short M09_L11
       mov       r8,[rdi+8]
       mov       esi,[rdi+18]
       lea       ecx,[rsi+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M09_L21
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       near ptr M09_L16
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L10:
       add       r13d,esi
       mov       [rdi+18],r13d
       mov       rax,[rbp-88]
M09_L11:
       xor       r13d,r13d
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       cmp       qword ptr [rbp-48],0
       je        short M09_L13
       mov       rdx,[rbp-48]
       add       rdx,0C
       mov       r8,[rbp-48]
       mov       esi,[r8+8]
       test      esi,esi
       je        short M09_L13
       mov       r8,[rdi+8]
       mov       r15d,[rdi+18]
       lea       ecx,[r15+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M09_L22
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       near ptr M09_L17
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L12:
       add       esi,r15d
       mov       [rdi+18],esi
       mov       rax,[rbp-88]
M09_L13:
       mov       edx,[rdi+18]
       mov       ecx,edx
       mov       r8,[rdi+8]
       mov       r10d,[r8+8]
       cmp       r10d,ecx
       jbe       near ptr M09_L23
       mov       [r8+rcx*2+10],r14w
       inc       edx
       mov       [rdi+18],edx
M09_L14:
       cmp       qword ptr [rbp-40],0
       je        near ptr M09_L07
       mov       rdx,[rbp-40]
       add       rdx,0C
       mov       r8,[rbp-40]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M09_L07
       mov       rdi,[rbp-78]
       mov       r8,[rdi+8]
       mov       r15d,[rdi+18]
       lea       ecx,[r15+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M09_L24
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M09_L18
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L15:
       add       esi,r15d
       mov       [rdi+18],esi
       jmp       near ptr M09_L07
M09_L16:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M09_L10
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M09_L10
M09_L17:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       near ptr M09_L12
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M09_L12
M09_L18:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M09_L15
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M09_L15
M09_L19:
       mov       rdi,[rbp-78]
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       near ptr M09_L29
M09_L20:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-88]
       mov       r11,7FF919980B80
       call      qword ptr [r11]
       mov       rax,[rbp-88]
       jmp       near ptr M09_L09
M09_L21:
       mov       rcx,rdi
       mov       r8d,r13d
       call      qword ptr [7FF919BAF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rax,[rbp-88]
       jmp       near ptr M09_L11
M09_L22:
       mov       rcx,rdi
       mov       r8d,esi
       call      qword ptr [7FF919BAF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rax,[rbp-88]
       jmp       near ptr M09_L13
M09_L23:
       movzx     edx,r14w
       mov       rcx,rdi
       call      qword ptr [7FF919BAF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-88]
       jmp       near ptr M09_L14
M09_L24:
       mov       rcx,rdi
       mov       r8d,esi
       call      qword ptr [7FF919BAF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M09_L07
M09_L25:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M09_L08
       jmp       near ptr M09_L19
M09_L26:
       mov       rcx,rax
       mov       r11,7FF919980B78
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M09_L20
       jmp       short M09_L29
M09_L27:
       mov       rdi,[rbp-78]
       call      qword ptr [7FF919C5C150]
       int       3
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L29:
       mov       rdi,[rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Enumerator
       mov       rax,[rbp-88]
       cmp       [rax],rcx
       jne       short M09_L34
M09_L30:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF919C22100]; System.Text.StringBuilder.ToString()
       mov       [rbp-80],rax
       jmp       short M09_L35
M09_L31:
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF919BAF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M09_L04
M09_L32:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1848FC003C0
       mov       rdx,[rcx]
       jmp       near ptr M09_L05
M09_L33:
       mov       rcx,r15
       mov       r11,7FF919980B70
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M09_L06
M09_L34:
       mov       rcx,rax
       mov       r11,7FF919980B88
       call      qword ptr [r11]
       jmp       short M09_L30
M09_L35:
       call      M09_L42
       nop
       mov       rax,[rbp-80]
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L36:
       call      qword ptr [7FF919C5FFA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M09_L00
M09_L37:
       call      qword ptr [7FF91A137138]
       int       3
M09_L38:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF91A0551D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M09_L39
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M09_L01
M09_L39:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M09_L02
M09_L40:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M09_L03
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M09_L41
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Enumerator
       mov       rax,[rbp-88]
       cmp       [rax],rcx
       je        short M09_L41
       mov       rcx,rax
       mov       r11,7FF919980B88
       call      qword ptr [r11]
M09_L41:
       nop
       add       rsp,28
       ret
M09_L42:
       sub       rsp,28
       mov       rcx,18479C01D88
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M09_L43
       call      qword ptr [7FF919C5FFA8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M09_L44
M09_L43:
       mov       rbx,[rcx+18]
M09_L44:
       mov       rdi,[rbp-78]
       cmp       dword ptr [rdi+20],0
       jge       short M09_L45
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rbx,rax
       call      qword ptr [7FF91A13CCF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF919C5D950]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L45:
       cmp       qword ptr [rdi+10],0
       jne       short M09_L46
       xor       ecx,ecx
       mov       [rdi+18],rcx
       jmp       near ptr M09_L53
M09_L46:
       mov       ecx,[rdi+1C]
       add       ecx,[rdi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M09_L47
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF91A13CDE0]
       jmp       near ptr M09_L53
M09_L47:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF91A13CDF8]
       mov       rsi,rax
       cmp       rsi,rdi
       je        near ptr M09_L52
       mov       rax,[rdi+8]
       mov       ecx,[rax+8]
       add       ecx,[rdi+1C]
       mov       eax,[rdi+1C]
       add       eax,[rdi+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rdi+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M09_L50
       cmp       ecx,400
       jge       short M09_L48
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M09_L49
M09_L48:
       xor       edx,edx
       call      qword ptr [7FF919FBEDA8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M09_L49:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,r14
       call      qword ptr [7FF919BA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L51
M09_L50:
       mov       rdx,[rsi+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
M09_L51:
       mov       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+1C]
       mov       [rdi+1C],ecx
M09_L52:
       mov       ecx,[rsi+1C]
       neg       ecx
       mov       [rdi+18],ecx
M09_L53:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M09_L57
       mov       rax,[rbx+10]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M09_L58
       cmp       qword ptr [rbx+20],0
       jne       short M09_L55
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M09_L54
       call      qword ptr [7FF91A137138]
       int       3
M09_L54:
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF979669BA0
       test      rax,rax
       je        short M09_L58
M09_L55:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M09_L56
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF91A13D488]
       test      eax,eax
       jne       short M09_L58
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF91A13D4A0]
       jmp       short M09_L58
M09_L56:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M09_L58
M09_L57:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M09_L58:
       nop
       add       rsp,28
       ret
; Total bytes of code 1940
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M10_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M10_L00:
       mov       eax,1
       ret
; Total bytes of code 22
```
```assembly
; DotNetTips.Spargine.Tester.UnitTester.GenerateFileName(System.String)
; 		var now = DateTime.Now;
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 		var baseName = methodName.FastIsNullOrEmpty() ? RandomData.GenerateKey() : methodName;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return string.Create(
; 		^^^^^^^^^^^^^^^^^^^^^
; 			baseName.Length + 1 + timestampLength + extensionLength,
; 			                                                        
; 			(baseName, now),
; 			                
; 			static (span, state) =>
; 			                       
; 			{
; 			 
; 				var (name, dt) = state;
; 				                       
; 				var pos = 0;
; 				            
; 
; 
; 				name.AsSpan().CopyTo(span);
; 				                           
; 				pos += name.Length;
; 				                   
; 
; 
; 				span[pos++] = '_';
; 				                  
; 
; 
; 				_ = dt.TryFormat(span[pos..], out _, "yyyyMMdd_HHmmssfff", CultureInfo.InvariantCulture);
; 				                                                                                         
; 				pos += 18;
; 				          
; 
; 
; 				".txt".AsSpan().CopyTo(span[pos..]);
; 				                                    
; 			});
; 			   
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       rbx,rcx
       call      qword ptr [7FF919DB4300]; System.DateTime.get_Now()
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M11_L03
       cmp       dword ptr [rbx+8],0
       je        near ptr M11_L03
M11_L00:
       mov       edi,[rbx+8]
       mov       ebp,edi
       add       ebp,1
       jo        near ptr M11_L11
       mov       r14d,ebp
       add       r14d,12
       jo        near ptr M11_L11
       mov       r15d,r14d
       add       r15d,4
       jo        near ptr M11_L11
       mov       rcx,1848FC002C0
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M11_L04
M11_L01:
       test      r15d,r15d
       jle       near ptr M11_L05
       mov       edx,r15d
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       r8,offset DotNetTips.Spargine.Tester.UnitTester+<>c.<GenerateFileName>b__22_0(System.Span`1<Char>, System.ValueTuple`2<System.String,System.DateTime>)
       cmp       [r13+18],r8
       jne       near ptr M11_L09
       mov       [rsp+68],rax
       mov       [rsp+70],r15d
       lea       rdx,[rbx+0C]
       mov       r8d,edi
       mov       rcx,[rsp+68]
       mov       eax,[rsp+70]
       cmp       r8d,eax
       ja        near ptr M11_L08
       add       r8,r8
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       edi,[rsp+70]
       jae       near ptr M11_L10
       mov       rdx,[rsp+68]
       mov       r9d,edi
       mov       word ptr [rdx+r9*2],5F
       mov       edx,[rsp+70]
       mov       r9d,edx
       sub       r9d,ebp
       mov       r8d,ebp
       mov       ecx,r9d
       add       r8,rcx
       cmp       r8,rdx
       ja        near ptr M11_L07
       mov       rdx,[rsp+68]
       mov       r8d,ebp
       lea       rdx,[rdx+r8*2]
       mov       r8,1C50EC017F4
       mov       [rsp+50],rdx
       mov       [rsp+58],r9d
       mov       [rsp+30],r8
       mov       dword ptr [rsp+38],12
       mov       rdx,18479C00100
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,8000000000000000
       mov       [rsp+28],rdx
       lea       rdx,[rsp+50]
       lea       r9,[rsp+30]
       lea       r8,[rsp+60]
       mov       rcx,rsi
       call      qword ptr [7FF91A05FCA8]; System.DateTimeFormat.TryFormat[[System.Char, System.Private.CoreLib]](System.DateTime, System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.TimeSpan)
       mov       ebp,r14d
       mov       [rsp+60],ebp
       mov       eax,[rsp+60]
       mov       ecx,[rsp+70]
       mov       edx,ecx
       sub       edx,[rsp+60]
       mov       r8d,eax
       mov       r10d,edx
       add       r8,r10
       cmp       r8,rcx
       ja        near ptr M11_L07
       mov       rcx,[rsp+68]
       lea       rax,[rcx+rax*2]
       cmp       edx,4
       jb        near ptr M11_L08
       mov       rcx,7400780074002E
       mov       [rax],rcx
M11_L02:
       mov       rax,r12
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L03:
       call      qword ptr [7FF91A054E88]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rbx,rax
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.String, System.DateTime>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,1848FC002B8
       mov       rdx,[rdx]
       mov       rcx,r13
       mov       r8,offset DotNetTips.Spargine.Tester.UnitTester+<>c.<GenerateFileName>b__22_0(System.Span`1<Char>, System.ValueTuple`2<System.String,System.DateTime>)
       call      qword ptr [7FF919A36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1848FC002C0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L01
M11_L05:
       test      r15d,r15d
       jne       short M11_L06
       mov       r12,1C50EBF0008
       jmp       short M11_L02
M11_L06:
       mov       ecx,28
       call      qword ptr [7FF919C578E8]
       int       3
M11_L07:
       call      qword ptr [7FF919BA7198]
       int       3
M11_L08:
       call      qword ptr [7FF919E4CD38]
       int       3
M11_L09:
       mov       [rsp+50],rax
       mov       [rsp+58],r15d
       mov       [rsp+40],rbx
       mov       [rsp+48],rsi
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       jmp       near ptr M11_L02
M11_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 665
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M12_L06
       test      rbx,rbx
       je        near ptr M12_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M12_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M12_L03
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FF91A055E48]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M12_L04
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       lea       rbp,[rbx+0C]
       mov       ebx,[rbx+8]
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M12_L01
       cmp       ecx,2F
       je        short M12_L01
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M12_L08
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M12_L00:
       test      ecx,ecx
       jne       short M12_L01
       mov       rcx,1C50EBF81EC
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       [rsp+30],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FF91A1347E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M12_L02
M12_L01:
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FF919DBD920]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
M12_L02:
       jmp       short M12_L05
M12_L03:
       mov       rax,rsi
       jmp       short M12_L05
M12_L04:
       mov       rax,rbx
M12_L05:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L06:
       mov       ecx,1C47C
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A136C70]
       int       3
M12_L07:
       mov       ecx,1C488
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A136C70]
       int       3
M12_L08:
       mov       ecx,1
       jmp       near ptr M12_L00
; Total bytes of code 355
```
```assembly
; System.IO.File.WriteAllText(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       call      qword ptr [7FF91A1347F8]; System.IO.File.get_UTF8NoBOM()
       test      rbx,rbx
       je        short M13_L02
       cmp       dword ptr [rbx+8],0
       je        short M13_L02
       test      rax,rax
       je        short M13_L03
       test      rsi,rsi
       jne       short M13_L01
       xor       r8d,r8d
       xor       r9d,r9d
M13_L00:
       mov       [rsp+28],r8
       mov       [rsp+30],r9d
       lea       r8,[rsp+28]
       mov       r9,rax
       mov       rcx,rbx
       mov       edx,2
       call      qword ptr [7FF91A134840]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M13_L01:
       lea       r8,[rsi+0C]
       mov       r9d,[rsi+8]
       jmp       short M13_L00
M13_L02:
       mov       ecx,1AC3C
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A13E268]
       int       3
M13_L03:
       mov       ecx,1C2AE
       mov       rdx,7FF919974000
       call      qword ptr [7FF919C577B0]
       mov       rcx,rax
       call      qword ptr [7FF91A136C70]
       int       3
; Total bytes of code 167
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
       je        near ptr M14_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M14_L00
       test      rbx,rbx
       je        near ptr M14_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M14_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9796CA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF919A35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L00:
       test      rbx,rbx
       je        short M14_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L02
M14_L01:
       mov       rax,1C50EBF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L04:
       call      qword ptr [7FF91A1370D8]
       int       3
; Total bytes of code 235
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M15_L03
       cmp       rcx,rdx
       je        short M15_L02
       cmp       r8,20
       jb        near ptr M15_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M15_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M15_L12
M15_L00:
       add       rax,20
       cmp       r8,rax
       jbe       short M15_L01
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M15_L12
       jmp       short M15_L00
M15_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M15_L12
M15_L02:
       mov       eax,1
       vzeroupper
       ret
M15_L03:
       cmp       r8,4
       jae       short M15_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M15_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M15_L04:
       test      r8b,1
       je        short M15_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M15_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M15_L07
M15_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M15_L07:
       vzeroupper
       ret
M15_L08:
       cmp       r8,10
       jb        short M15_L11
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M15_L10
M15_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M15_L12
       add       rax,10
       cmp       r8,rax
       ja        short M15_L09
M15_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M15_L12
       jmp       near ptr M15_L02
M15_L11:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M15_L07
M15_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 317
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<BuildSelectedPropertiesDictionary>b__25_0(System.Type)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		var allProperties = _publicInstancePropertiesCache.GetOrAdd(objectType, static t => t.GetProperties(BindingFlags.Public | BindingFlags.Instance));
; 		                                                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       edx,14
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 51
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M17_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FF91A1378A0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,r8
       mov       esi,[rbp+40]
       movzx     r9d,r9b
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+8]
       mov       r14d,[rbp+2C]
       test      r9d,r9d
       jne       short M18_L04
       cmp       byte ptr [rcx+19],0
       jne       short M18_L03
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+80]
       test      r11,r11
       je        near ptr M18_L34
M18_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
M18_L01:
       mov       r15d,eax
M18_L02:
       jmp       near ptr M18_L33
M18_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M18_L01
M18_L04:
       mov       rcx,7FF91A170F18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,r14d
       jmp       short M18_L02
M18_L05:
       test      sil,sil
       je        short M18_L07
       mov       rcx,7FF91A170F1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M18_L29
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M18_L28
       mov       rcx,r12
       call      00007FF9796D2FF0
       test      eax,eax
       jne       short M18_L06
       mov       rcx,r12
       call      qword ptr [7FF91A1375D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M18_L06:
       mov       dword ptr [rbp-50],1
M18_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[r14+8]
       je        short M18_L10
       mov       rcx,[r14+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       cmp       rdi,[rcx+8]
       je        short M18_L09
       mov       rcx,7FF91A170F20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdi,[rcx+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M18_L27
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M18_L26
M18_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r15d,eax
M18_L09:
       mov       rcx,7FF91A170F24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M18_L31
M18_L10:
       xor       esi,esi
       mov       r12,[r13]
       test      r12,r12
       jne       near ptr M18_L19
M18_L11:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M18_L23
M18_L12:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[r13]
       mov       [rbp-68],rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+20],r15d
       mov       rcx,r13
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-44],eax
       jae       near ptr M18_L29
       mov       eax,[rbp-44]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M18_L30
       mov       [rcx],eax
       cmp       eax,[r14+10]
       jle       short M18_L13
       mov       rcx,7FF91A170F40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-48],1
M18_L13:
       cmp       esi,64
       jbe       near ptr M18_L25
       mov       rcx,rdi
       mov       rdx,7FF91A170F48
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF919A36850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M18_L24
       mov       rcx,7FF91A171050
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M18_L36
M18_L14:
       mov       rcx,7FF91A170F2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r12+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M18_L22
M18_L15:
       mov       rcx,rax
M18_L16:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        near ptr M18_L20
M18_L17:
       mov       rdx,[r12+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M18_L21
       mov       rcx,7FF91A170F28
       call      CORINFO_HELP_COUNTPROFILE32
M18_L18:
       mov       rcx,7FF91A170F38
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       mov       rcx,7FF91A170F3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r12,[r12+18]
       test      r12,r12
       je        near ptr M18_L11
M18_L19:
       cmp       r15d,[r12+20]
       jne       short M18_L18
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       jne       near ptr M18_L15
       mov       rdx,7FF91A160390
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L16
M18_L20:
       mov       rdx,7FF91A1605B0
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M18_L17
M18_L21:
       cmp       byte ptr [rbp+38],0
       je        near ptr M18_L14
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M18_L22:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M18_L35
M18_L23:
       mov       rdx,7FF91A1617E8
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M18_L12
M18_L24:
       mov       rcx,7FF91A170F34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M18_L36
M18_L25:
       mov       rcx,7FF91A170F30
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M18_L36
M18_L26:
       mov       rdx,7FF91A160488
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M18_L08
M18_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M18_L09
M18_L28:
       xor       ecx,ecx
       call      qword ptr [7FF91A136C70]
       int       3
M18_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L30:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L31:
       cmp       dword ptr [rbp-50],0
       je        short M18_L32
       mov       rcx,7FF91A171054
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M18_L39
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M18_L38
       mov       rcx,r12
       call      00007FF9796D2F10
       test      eax,eax
       je        short M18_L32
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF91A136E08]
M18_L32:
       mov       rcx,7FF91A171058
       call      CORINFO_HELP_COUNTPROFILE32
       nop
M18_L33:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r14,[rbp+10]
       cmp       [r14],r14d
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,r15d
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-44],edx
       cmp       r10d,r9d
       jae       near ptr M18_L39
       mov       ecx,r10d
       lea       r13,[r8+rcx*8+10]
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       [rbp-4C],ecx
       mov       [rbp-50],ecx
       jmp       near ptr M18_L05
M18_L34:
       mov       rcx,rdx
       mov       rdx,7FF91A160488
       call      qword ptr [7FF919A3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M18_L00
M18_L35:
       call      M18_L40
       nop
       mov       rcx,7FF91A171064
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
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
M18_L36:
       call      M18_L40
       nop
       mov       ecx,[rbp-48]
       or        ecx,[rbp-4C]
       je        short M18_L37
       mov       rcx,7FF91A17105C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-48]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FF919FB4EE8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M18_L37:
       mov       rcx,7FF91A171060
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M18_L38:
       xor       ecx,ecx
       call      qword ptr [7FF91A136C70]
       int       3
M18_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L40:
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M18_L43
       mov       rcx,7FF91A171054
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       short M18_L41
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       jne       short M18_L42
       xor       ecx,ecx
       call      qword ptr [7FF91A136C70]
       int       3
M18_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L42:
       mov       rcx,r12
       call      00007FF9796D2F10
       test      eax,eax
       je        short M18_L43
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF91A136E08]
M18_L43:
       mov       rcx,7FF91A171058
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 1521
```

