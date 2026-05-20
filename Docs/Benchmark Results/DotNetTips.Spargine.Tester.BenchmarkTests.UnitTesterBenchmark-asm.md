## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.MeasureActionPrintFalse()
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbx,[rcx+148]
       mov       rcx,15CAA400198
       mov       rsi,[rcx]
       test      rsi,rsi
       mov       [rsp+20],rsi
       je        near ptr M00_L04
M00_L00:
       cmp       [rbx],bl
       lea       rcx,[rsp+30]
       mov       rax,7FFD07305F50
       call      rax
       mov       rbx,[rsp+30]
       cmp       dword ptr [7FFCAF0039A0],0
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintFalse>b__5_0()
       mov       rsi,[rsp+20]
       cmp       [rsi+18],rcx
       jne       near ptr M00_L06
M00_L02:
       lea       rcx,[rsp+28]
       mov       rax,7FFD07305F50
       call      rax
       mov       rax,[rsp+28]
       sub       rax,rbx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rax,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FFC4F187690]
       cmovb     rax,rcx
       mov       rbx,rax
       cmp       dword ptr [7FFCAF0039A0],0
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
       mov       rdx,15CAA400190
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintFalse>b__5_0()
       call      qword ptr [7FFC4F0D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15CAA400198
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
       call      qword ptr [7FFC4F784CF0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark.MeasureActionPrintTrue()
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbx,[rcx+148]
       mov       rcx,21293C001A0
       mov       rsi,[rcx]
       test      rsi,rsi
       mov       [rsp+20],rsi
       je        near ptr M00_L04
M00_L00:
       cmp       [rbx],bl
       lea       rcx,[rsp+30]
       mov       rax,7FFD07305F50
       call      rax
       mov       rbx,[rsp+30]
       cmp       dword ptr [7FFCAF0039A0],0
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintTrue>b__6_0()
       mov       rsi,[rsp+20]
       cmp       [rsi+18],rcx
       jne       near ptr M00_L06
M00_L02:
       lea       rcx,[rsp+28]
       mov       rax,7FFD07305F50
       call      rax
       mov       rax,[rsp+28]
       sub       rax,rbx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rax,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FFC4F14ADA0]
       cmovb     rax,rcx
       mov       rbx,rax
       cmp       dword ptr [7FFCAF0039A0],0
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
       mov       rdx,21293C00190
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.UnitTesterBenchmark+<>c.<MeasureActionPrintTrue>b__6_0()
       call      qword ptr [7FFC4F096BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21293C001A0
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
       call      qword ptr [7FFC4F744DE0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,22F21801E98
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L36
M00_L01:
       mov       r15,[r14+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,[r15+0C0]
       mov       rax,26FB688B5F0
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
       mov       rdx,26FB688B5F0
       call      qword ptr [7FFC4F4BD7E8]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       call      qword ptr [7FFC4F7945B8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,26FB6886D78
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
       mov       rcx,22F21801E50
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFC4F6D2F70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r15,26FB6881718
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
       mov       rsi,26FB6881718
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r15d
       call      qword ptr [7FFC4F794648]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFC4F7946F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L23:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F795140]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFC4F626478]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-1D8],rax
       jmp       near ptr M00_L31
M00_L27:
       call      qword ptr [7FFC4F27F228]
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
       call      qword ptr [7FFC4F8D52C0]
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
       mov       rax,7FFC4F6D6008
       mov       [rbp-188],rax
       lea       rax,[M00_L32]
       mov       [rbp-178],rax
       mov       rax,[rbp-160]
       lea       rdx,[rbp-198]
       mov       [rax+8],rdx
       mov       rax,[rbp-160]
       mov       byte ptr [rax+4],0
       mov       rax,7FFD06C60930
       call      rax
M00_L32:
       mov       rcx,[rbp-160]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCAF0039A0],0
       je        short M00_L33
       call      qword ptr [7FFCAEFF1648]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-190]
       mov       [rcx+8],rdx
       test      eax,eax
       jne       near ptr M00_L45
       vmovups   xmm0,[rbp-130]
       vmovups   [rbp-120],xmm0
       mov       rcx,26FB688B220
       call      qword ptr [7FFC4F33E430]; System.String.IsNullOrEmpty(System.String)
       mov       ecx,20
       mov       edx,24
       test      eax,eax
       cmovne    ecx,edx
       call      qword ptr [7FFC4F0A6670]; System.String.FastAllocateString(IntPtr)
       mov       rbx,rax
       cmp       [rbx],bl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-140],xmm0
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       rcx,[rbp-140]
       call      qword ptr [7FFC4F8D6340]; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       rsi,[rbp-140]
       mov       edi,[rbp-138]
       lea       rcx,[rbp-158]
       mov       rdx,26FB688B220
       call      qword ptr [7FFC4F4B7B28]; System.MemoryExtensions.AsSpan(System.String)
       mov       [rbp-1B8],rsi
       mov       [rbp-1B0],edi
       lea       rdx,[rbp-1B8]
       lea       rcx,[rbp-120]
       lea       r8,[rbp-148]
       lea       r9,[rbp-158]
       call      qword ptr [7FFC4F2750B0]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       rcx,rbx
       mov       rdx,26FB6890810
       call      qword ptr [7FFC4F0AD9C8]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rbx,[rbp-1C0]
       mov       rcx,[rbx+8]
       call      qword ptr [7FFC4F42E520]; System.IO.Path.Combine(System.String, System.String)
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFC4F6CDB60]; System.IO.File.WriteAllText(System.String, System.String)
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
       mov       rcx,26FB688B5F0
       call      qword ptr [7FFC4F8D47B0]
       int       3
M00_L35:
       call      qword ptr [7FFC4F62ECB8]
       mov       ecx,58B
       mov       rdx,7FFC4F374FF0
       call      qword ptr [7FFC4F0AF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC4F375AC0
       call      qword ptr [7FFC4F0AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F0AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FFC4F374FF0
       call      qword ptr [7FFC4F0AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F0AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC4F8D6328]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC4F79CFF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FFC4F4B7A98]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FFC4F4BD2C0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L38:
       call      qword ptr [7FFC4F8D4798]
       int       3
M00_L39:
       mov       rcx,r15
       call      qword ptr [7FFC4F5B6F58]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L40:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L41:
       mov       ecx,9
       call      qword ptr [7FFC4F79C2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L42:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22F378003E8
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L43:
       mov       rax,26FB6886D78
       jmp       near ptr M00_L09
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22F378003E8
       mov       r15,[rcx]
       jmp       near ptr M00_L11
M00_L45:
       mov       ecx,eax
       call      qword ptr [7FFC4F8D5D58]
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
       call      qword ptr [7FFC4F79C2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       mov       r8,26FB6886D78
       mov       [rcx],r8
       cmp       byte ptr [rcx+10],0
       je        short M00_L50
       cmp       dword ptr [rdx+8],0
       je        short M00_L50
       mov       rcx,22F21801E50
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC4F6D2F78]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFCACDA8540]
       mov       rbp,[rax]
       test      rbp,rbp
       je        short M01_L01
M01_L00:
       mov       rcx,rdi
       call      qword ptr [7FFCACDA84C0]
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
       call      qword ptr [7FFCACDAA0D0]
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCACDAACF8]
       call      qword ptr [7FFCACDA8540]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,26FB6891650
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],1
       jne       short M02_L03
       cmp       word ptr [r8+0C],0A
       je        short M02_L04
M02_L03:
       mov       rcx,26FB6881718
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],2
       jne       short M02_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L08
M02_L04:
       mov       rcx,26FB6881718
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
       mov       rdx,7FFC4F4D9D68
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8D50F8]
       int       3
M02_L09:
       or        esi,4
       jmp       short M02_L06
M02_L10:
       cmp       edx,9
       je        short M02_L11
       mov       ecx,38A0
       mov       rdx,7FFC4F4D9D68
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8D50B0]
       int       3
M02_L11:
       or        esi,8
       jmp       near ptr M02_L00
M02_L12:
       mov       ecx,38A0
       mov       rdx,7FFC4F4D9D68
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFC4F8D50C8]
       int       3
M02_L13:
       mov       ecx,38A0
       mov       rdx,7FFC4F4D9D68
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8D50E0]
       int       3
M02_L14:
       mov       r8,26FB6881718
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
       mov       rcx,22F21800C90
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
       call      qword ptr [7FFC4F79C2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       mov       rcx,r14
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F79C8E8]
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
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFEB184],0
       je        short M03_L05
       call      qword ptr [7FFC4F79C900]
       mov       ebx,eax
       jmp       short M03_L07
M03_L05:
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M03_L06
       call      qword ptr [7FFC4F79C930]
       mov       ebx,eax
       jmp       short M03_L07
M03_L06:
       sar       ebx,10
M03_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFC4EFEB178]
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
       call      qword ptr [7FFC4F5BDFF8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F79C8E8]
       jmp       near ptr M03_L01
M03_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M03_L18
M03_L16:
       test      ebx,ebx
       jne       short M03_L17
       mov       rax,26FB6886D78
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
       mov       rdx,26FB6886F28
       call      qword ptr [7FFC4F33D980]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC4F794690]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F79C8E8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F79C960]
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
       mov       rcx,22F21801E50
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,22F21800C90
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
       call      qword ptr [7FFC4F79C2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L05:
       mov       rcx,r13
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F79C8E8]
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
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFEB184],0
       je        short M04_L07
       call      qword ptr [7FFC4F79C900]
       mov       ebp,eax
       jmp       short M04_L09
M04_L07:
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M04_L08
       call      qword ptr [7FFC4F79C930]
       mov       ebp,eax
       jmp       short M04_L09
M04_L08:
       sar       ebp,10
M04_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFC4EFEB178]
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
       call      qword ptr [7FFC4F5BDFF8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F79C8E8]
       jmp       near ptr M04_L01
M04_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M04_L20
M04_L18:
       test      ebp,ebp
       jne       short M04_L19
       mov       rdx,26FB6886D78
       jmp       near ptr M04_L02
M04_L19:
       mov       ecx,ebp
       mov       rdx,26FB6886F28
       call      qword ptr [7FFC4F33D980]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC4F794690]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M04_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F79C8E8]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F79C960]
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
       call      qword ptr [7FFC4F335FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFC4F8D4948]
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
       mov       rcx,22F21801E50
       mov       rcx,[rcx]
       call      qword ptr [7FFC4F6D2F70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFC4F335FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,22F21801E50
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
       jmp       qword ptr [7FFC4F6D2F78]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,22F21801458
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
       call      qword ptr [7FFC4F794B28]; System.Text.Json.Utf8JsonWriter.WriteStringIndented(System.ReadOnlySpan`1<Char>)
       jmp       short M05_L06
M05_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFC4F794BD0]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M05_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       call      qword ptr [7FFC4F794E28]
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
       call      qword ptr [7FFC4F794720]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M05_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFC4F5E81B8]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M05_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFC4F794BA0]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFC4F794DF8]
       int       3
M05_L21:
       mov       rcx,rbx
       call      qword ptr [7FFC4F794E28]
       jmp       near ptr M05_L09
M05_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M05_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFC4F626370]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFC4F8D4CD8]
       int       3
M05_L24:
       mov       rcx,rbx
       call      qword ptr [7FFC4F8D4CF0]
       test      eax,eax
       jne       near ptr M05_L04
       mov       rcx,rbx
       call      qword ptr [7FFC4F8D4D08]
       jmp       near ptr M05_L04
M05_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFC4F8D4D20]
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
       call      qword ptr [7FFC4F794D98]
       int       3
M05_L28:
       mov       rcx,r13
       call      qword ptr [7FFC4F5B6F58]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M05_L12
M05_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFC4F8D4C30]
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
       call      qword ptr [7FFC4F8D4C48]
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
       call      qword ptr [7FFC4F8D5320]
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
       call      qword ptr [7FFC4F8D5338]
       test      rax,rax
       jne       near ptr M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFC4F8D5350]
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
       mov       rdx,26FB688F0E0
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8D5380]
       test      eax,eax
       jne       short M05_L39
       jmp       short M05_L38
M05_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,26FB688F090
       call      qword ptr [7FFC4F0AC318]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFC4F8D5368]
       jmp       short M05_L39
M05_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFC4F8D5398]
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
       call      qword ptr [7FFC4F8D5CF8]
       int       3
M06_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F906330]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8D5D28]
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
       call      qword ptr [7FFC4F8D5D40]
M06_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M06_L02
M06_L06:
       mov       r11,7FFC4EFF0BF0
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
       mov       r8,22F21801430
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
       call      qword ptr [7FFC4F27CD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFCAED49D30
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
       call      qword ptr [7FFC4F27CDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,26FB6880008
M07_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFC4F62E460]
       int       3
M07_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFC4F62E430]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FFC4F62E478]
       int       3
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFC4F62E460]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFC4F626298]
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
       call      qword ptr [7FFC4F62E6B8]
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
       call      qword ptr [7FFC4F796940]
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
       jmp       near ptr 00007FFCAED49D30
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
       vmovups   xmm1,[7FFC4F8375F0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFC4F837600]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFC4F837610]
       test      ebx,ebx
       jl        short M12_L02
       vxorps    xmm2,xmm2,xmm2
       vmovaps   xmm3,xmm0
       vmovaps   xmm0,xmm2
       vmovaps   xmm2,xmm3
       jmp       short M12_L03
M12_L02:
       vpshufb   xmm2,xmm0,[7FFC4F837620]
       vpshufb   xmm3,xmm1,[7FFC4F837630]
       vpshufb   xmm1,xmm1,[7FFC4F837640]
       vpshufb   xmm0,xmm0,[7FFC4F837650]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFC4F837660]
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
       call      qword ptr [7FFC4F79C480]
       int       3
M12_L09:
       cmp       eax,62
       je        short M12_L14
       cmp       eax,64
       je        short M12_L12
M12_L10:
       call      qword ptr [7FFC4F79C480]
       int       3
M12_L11:
       cmp       eax,70
       je        short M12_L13
       cmp       eax,78
       jne       short M12_L10
       call      qword ptr [7FFC4F79C4C8]
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
       call      00007FFCAED49D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC4F0A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC4F0A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26FB6880008
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
       call      qword ptr [7FFC4F79C450]
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
       call      qword ptr [7FFC4F6C5D70]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,26FB68881EC
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       [rsp+30],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FFC4F7951E8]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M14_L02
M14_L01:
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFC4F42D980]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       mov       rdx,7FFC4EFE4000
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F79C000]
       int       3
M14_L07:
       mov       ecx,1C488
       mov       rdx,7FFC4EFE4000
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F79C000]
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
       call      qword ptr [7FFC4F795200]; System.IO.File.get_UTF8NoBOM()
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
       call      qword ptr [7FFC4F795248]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
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
       mov       rdx,7FFC4EFE4000
       call      qword ptr [7FFC4F0AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F79F510]
       int       3
M15_L03:
       mov       ecx,1C2AE
       mov       rdx,7FFC4EFE4000
       call      qword ptr [7FFC4F0AF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F79C000]
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
       call      qword ptr [7FFCACDA84E0]
       cmp       byte ptr [rax],0
       je        near ptr M16_L03
       call      qword ptr [7FFCACDAEBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M16_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
M16_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L01:
       call      qword ptr [7FFCACDAA688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M16_L00
       call      qword ptr [7FFCACDA84D8]
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
       call      qword ptr [7FFCACDB02E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFCACDAEC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCACDAE4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFCACDAA6A0]
       test      rax,rax
       je        near ptr M16_L00
M16_L04:
       call      qword ptr [7FFCACDACE58]
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
       call      qword ptr [7FFCACDAE588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFCACDAC548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FFCACDAB180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M18_L03
M18_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFCACDAEEF8]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L03:
       mov       rcx,rax
       call      qword ptr [7FFCACDAB218]
       jmp       short M18_L02
M18_L04:
       cmp       byte ptr [rbp-10],0
       je        short M18_L05
       mov       rcx,rbx
       call      qword ptr [7FFCACDAB188]; Precode of System.Threading.Monitor.Exit(System.Object)
M18_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FFCACDACE50]
       int       3
M18_L07:
       mov       rcx,rax
       call      qword ptr [7FFCACDAB218]
       jmp       near ptr M18_L00
M18_L08:
       mov       rcx,rax
       call      qword ptr [7FFCACDAE530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M18_L01
       sub       rsp,28
       call      qword ptr [7FFCACDAB210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FFCACDA8258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M18_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FFCACDAB188]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       jmp       qword ptr [7FFC4F79CC48]
; Total bytes of code 90
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCAEB2CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFC4F0A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,22F21800C90
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
       call      qword ptr [7FFC4F0AFD50]
       int       3
M22_L06:
       mov       ecx,0A
       call      qword ptr [7FFC4F79C2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M22_L00
M22_L07:
       mov       rcx,rdi
       call      qword ptr [7FFC4F7951A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M22_L01
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FFC4F79C9D8]
       jmp       near ptr M22_L02
M22_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFC4F79C9F0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFC4EFE4000
       call      qword ptr [7FFC4F0AF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFC4F4261F0]
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
       call      qword ptr [7FFC4F8D4ED0]
M22_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFEB184],0
       je        short M22_L12
       call      qword ptr [7FFC4F79C900]
       mov       esi,eax
       jmp       short M22_L14
M22_L12:
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       mov       esi,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F79C918]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M22_L13
       call      qword ptr [7FFC4F79C930]
       mov       esi,eax
       jmp       short M22_L14
M22_L13:
       sar       esi,10
M22_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFC4EFEB178]
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
       call      qword ptr [7FFC4F5BDFF8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFC4F79CA20]
       test      r12d,r13d
       jne       near ptr M22_L04
       mov       rcx,rbx
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFC4F4BD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F79CA38]
       jmp       near ptr M22_L04
M22_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,20C57001E98
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+9F],0
       je        near ptr M00_L34
M00_L01:
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[r14+0C0]
       mov       rax,24CEBF9B5F0
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
       mov       rdx,24CEBF9B5F0
       call      qword ptr [7FFC4F4CD7E8]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       call      qword ptr [7FFC4F7A4528]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r14d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       mov       rcx,24CEBF96D78
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
       mov       rcx,20C57001E50
       mov       rcx,[rcx]
       mov       edx,r14d
       call      qword ptr [7FFC4F6E21A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r14,24CEBF91718
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
       mov       rsi,24CEBF91718
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r15+30],ecx
       cmp       dword ptr [r15+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r15+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r14d
       call      qword ptr [7FFC4F7A45B8]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFC4F7A4660]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L23:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F7A50E0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFC4F636478]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-140],rax
       jmp       near ptr M00_L31
M00_L27:
       call      qword ptr [7FFC4F28F228]
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
       call      qword ptr [7FFC4F8E6040]
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
       call      qword ptr [7FFC4F434360]; System.DateTime.get_Now()
       mov       rcx,rax
       mov       r8,20C57000180
       mov       r8,[r8]
       mov       rdx,24CEBFA0808
       mov       r9,8000000000000000
       call      qword ptr [7FFC4F7A5218]; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       mov       r8,rax
       mov       rcx,24CEBFA07D0
       mov       rdx,24CEBF932E0
       mov       r9,24CEBFA0848
       call      qword ptr [7FFC4F34FEE8]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rdx,[rbp-128]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L43
       test      rax,rax
       je        near ptr M00_L44
       mov       rdx,rax
       call      qword ptr [7FFC4F6D5CF8]; System.IO.Path.CombineInternal(System.String, System.String)
       mov       rbx,rax
       call      qword ptr [7FFC4F7A5D40]; System.IO.File.get_UTF8NoBOM()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,24CEBF97DF8
       call      qword ptr [7FFC4F8E7918]; System.ArgumentException.ThrowIfNullOrEmpty(System.String, System.String)
       test      rsi,rsi
       je        near ptr M00_L45
       lea       rcx,[rbp-110]
       mov       rdx,[rbp-140]
       call      qword ptr [7FFC4F4C7B28]; System.MemoryExtensions.AsSpan(System.String)
       lea       r8,[rbp-110]
       mov       rcx,rbx
       mov       r9,rsi
       mov       edx,2
       call      qword ptr [7FFC4F7A5D88]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
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
       mov       rcx,24CEBF9B5F0
       call      qword ptr [7FFC4F8E4EA0]
       int       3
M00_L33:
       call      qword ptr [7FFC4F63EA30]
       mov       ecx,58B
       mov       rdx,7FFC4F384FF0
       call      qword ptr [7FFC4F0BF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC4F385AC0
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F0BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FFC4F384FF0
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F0BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC4F8E7888]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC4F7AD6F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rbx
       call      qword ptr [7FFC4F4C7A98]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,rbx
       call      qword ptr [7FFC4F4CD2C0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L36:
       call      qword ptr [7FFC4F8E4E88]
       int       3
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FFC4F5C6F58]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L38:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L39:
       mov       ecx,9
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L40:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20C6D000410
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L41:
       mov       rax,24CEBF96D78
       jmp       near ptr M00_L09
M00_L42:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20C6D000410
       mov       r14,[rcx]
       jmp       near ptr M00_L11
M00_L43:
       mov       ecx,1C47C
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F7AC6F0]
       int       3
M00_L44:
       mov       ecx,1C488
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F7AC6F0]
       int       3
M00_L45:
       mov       ecx,1C2AE
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F7AC6F0]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M00_L48
       mov       rcx,[rcx+240]
       mov       r15,[rcx+48]
       test      r15,r15
       jne       short M00_L49
M00_L48:
       mov       ecx,9
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       mov       r8,24CEBF96D78
       mov       [rcx],r8
       cmp       byte ptr [rcx+10],0
       je        short M00_L50
       cmp       dword ptr [rdx+8],0
       je        short M00_L50
       mov       rcx,20C57001E50
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC4F6E21B0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFCACDA8540]
       mov       rbp,[rax]
       test      rbp,rbp
       je        short M01_L01
M01_L00:
       mov       rcx,rdi
       call      qword ptr [7FFCACDA84C0]
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
       call      qword ptr [7FFCACDAA0D0]
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCACDAACF8]
       call      qword ptr [7FFCACDA8540]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,24CEBFA1688
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],1
       jne       short M02_L03
       cmp       word ptr [r8+0C],0A
       je        short M02_L04
M02_L03:
       mov       rcx,24CEBF91718
       cmp       r8,rcx
       je        short M02_L04
       cmp       dword ptr [r8+8],2
       jne       short M02_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M02_L08
M02_L04:
       mov       rcx,24CEBF91718
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
       mov       rdx,7FFC4F4E9D68
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8E5E78]
       int       3
M02_L09:
       or        esi,4
       jmp       short M02_L06
M02_L10:
       cmp       edx,9
       je        short M02_L11
       mov       ecx,38A0
       mov       rdx,7FFC4F4E9D68
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8E5E30]
       int       3
M02_L11:
       or        esi,8
       jmp       near ptr M02_L00
M02_L12:
       mov       ecx,38A0
       mov       rdx,7FFC4F4E9D68
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFC4F8E5E48]
       int       3
M02_L13:
       mov       ecx,38A0
       mov       rdx,7FFC4F4E9D68
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F8E5E60]
       int       3
M02_L14:
       mov       r8,24CEBF91718
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
       mov       rcx,20C57000C90
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
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       mov       rcx,r14
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F7ACFC0]
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
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFFB184],0
       je        short M03_L05
       call      qword ptr [7FFC4F7ACFD8]
       mov       ebx,eax
       jmp       short M03_L07
M03_L05:
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M03_L06
       call      qword ptr [7FFC4F7AD008]
       mov       ebx,eax
       jmp       short M03_L07
M03_L06:
       sar       ebx,10
M03_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFC4EFFB178]
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
       call      qword ptr [7FFC4F5CDFE0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F7ACFC0]
       jmp       near ptr M03_L01
M03_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M03_L18
M03_L16:
       test      ebx,ebx
       jne       short M03_L17
       mov       rax,24CEBF96D78
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
       mov       rdx,24CEBF96F28
       call      qword ptr [7FFC4F34D980]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC4F7A4600]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFC4F7ACFC0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F7AD038]
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
       mov       rcx,20C57001E50
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,20C57000C90
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
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L05:
       mov       rcx,r13
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F7ACFC0]
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
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFFB184],0
       je        short M04_L07
       call      qword ptr [7FFC4F7ACFD8]
       mov       ebp,eax
       jmp       short M04_L09
M04_L07:
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M04_L08
       call      qword ptr [7FFC4F7AD008]
       mov       ebp,eax
       jmp       short M04_L09
M04_L08:
       sar       ebp,10
M04_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFC4EFFB178]
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
       call      qword ptr [7FFC4F5CDFE0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F7ACFC0]
       jmp       near ptr M04_L01
M04_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M04_L20
M04_L18:
       test      ebp,ebp
       jne       short M04_L19
       mov       rdx,24CEBF96D78
       jmp       near ptr M04_L02
M04_L19:
       mov       ecx,ebp
       mov       rdx,24CEBF96F28
       call      qword ptr [7FFC4F34D980]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFC4F7A4600]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M04_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFC4F7ACFC0]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F7AD038]
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
       call      qword ptr [7FFC4F345FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFC4F8E5038]
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
       mov       rcx,20C57001E50
       mov       rcx,[rcx]
       call      qword ptr [7FFC4F6E21A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFC4F345FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,20C57001E50
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
       jmp       qword ptr [7FFC4F6E21B0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,20C57001458
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
       call      qword ptr [7FFC4F7A4A98]; System.Text.Json.Utf8JsonWriter.WriteStringIndented(System.ReadOnlySpan`1<Char>)
       jmp       short M05_L06
M05_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFC4F7A4AC8]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M05_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M05_L08
M05_L07:
       mov       rcx,rbx
       call      qword ptr [7FFC4F7A4DC8]
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
       call      qword ptr [7FFC4F7A4690]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M05_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFC4F5F81B8]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M05_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFC4F7A4C18]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFC4F7A4D98]
       int       3
M05_L21:
       mov       rcx,rbx
       call      qword ptr [7FFC4F7A4DC8]
       jmp       near ptr M05_L09
M05_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M05_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFC4F636370]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFC4F8E5428]
       int       3
M05_L24:
       mov       rcx,rbx
       call      qword ptr [7FFC4F8E5440]
       test      eax,eax
       jne       near ptr M05_L04
       mov       rcx,rbx
       call      qword ptr [7FFC4F8E5458]
       jmp       near ptr M05_L04
M05_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFC4F8E5470]
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
       call      qword ptr [7FFC4F7A4D38]
       int       3
M05_L28:
       mov       rcx,r13
       call      qword ptr [7FFC4F5C6F58]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M05_L12
M05_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFC4F8E5368]
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
       call      qword ptr [7FFC4F8E5380]
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
       call      qword ptr [7FFC4F8E60A0]
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
       call      qword ptr [7FFC4F8E60B8]
       test      rax,rax
       jne       near ptr M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFC4F8E60D0]
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
       mov       rdx,24CEBF9F0E0
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8E6100]
       test      eax,eax
       jne       short M05_L39
       jmp       short M05_L38
M05_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,24CEBF9F090
       call      qword ptr [7FFC4F0BC318]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M05_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFC4F8E60E8]
       jmp       short M05_L39
M05_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFC4F8E6118]
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
       call      qword ptr [7FFC4F8E6598]
       int       3
M06_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F9129F0]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8E65C8]
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
       call      qword ptr [7FFC4F8E65E0]
M06_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M06_L02
M06_L06:
       mov       r11,7FFC4F000C38
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
       mov       r8,20C57001430
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
       call      qword ptr [7FFC4F28CD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFCAED49D30
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
       call      qword ptr [7FFC4F28CDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,24CEBF90008
M07_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFC4F63E460]
       int       3
M07_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFC4F63E430]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FFC4F63E478]
       int       3
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFC4F63E460]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFC4F636298]
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
       call      qword ptr [7FFC4F63E6D0]
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
       call      qword ptr [7FFC4F7A75A0]
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
       mov       rax,7FFD07315380
       call      rax
       mov       rbx,[rsp+28]
       mov       rax,20C57001B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFCAF0039A0],0
       jne       short M08_L02
M08_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M08_L03
       add       rbx,[rsi+10]
M08_L01:
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       call      qword ptr [7FFC4F7A5188]; System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(System.DateTime, Boolean ByRef)
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
       call      qword ptr [7FFC4F5C6B50]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
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
       mov       rax,0CDD4EE7A2C85
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
       mov       rcx,[rcx+30]
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
       mov       rcx,20C57000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M09_L02
       mov       rcx,20C57000170
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M09_L02
       call      qword ptr [7FFC4F0BD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFC4F7A5980]; System.DateTimeFormat.FormatCustomized[[System.Char, System.Private.CoreLib]](System.DateTime, System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.TimeSpan, System.Collections.Generic.ValueListBuilder`1<Char> ByRef)
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
       mov       r8,0CDD4EE7A2C85
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
       call      qword ptr [7FFC4F8E6670]
M09_L09:
       mov       [rbp+80],rax
       mov       rcx,8000000000000000
       cmp       rsi,rcx
       jne       near ptr M09_L12
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FFC4F8E6688]
       test      eax,eax
       jne       short M09_L11
       mov       rcx,[rbp+80]
       mov       rax,20C6D0002D8
       cmp       rcx,[rax]
       je        short M09_L10
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8E66A0]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L10:
       mov       ecx,13
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+50]
       mov       rdx,8000000000000000
       call      qword ptr [7FFC4F8E6610]
       jmp       near ptr M09_L06
M09_L11:
       mov       ecx,13
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+58]
       call      qword ptr [7FFC4F8E65F8]
       jmp       near ptr M09_L06
M09_L12:
       mov       rcx,[rbp+0B0]
       mov       rdx,[rbp+80]
       call      qword ptr [7FFC4F8E6688]
       test      eax,eax
       je        short M09_L13
       mov       rbx,24CEBFA16D0
       mov       rcx,20C6D0002D8
       mov       rcx,[rcx]
       mov       [rbp+80],rcx
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,[rbp+80]
       mov       rax,20C6D0002D8
       cmp       rcx,[rax]
       je        short M09_L15
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8E66B8]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L14:
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       jmp       near ptr M09_L05
M09_L15:
       mov       ecx,1A
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+48]
       mov       rdx,rsi
       call      qword ptr [7FFC4F8E6610]
       jmp       near ptr M09_L06
M09_L16:
       call      qword ptr [7FFC4F7A5230]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
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
       lea       rdx,[7FFC4F877E70]
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
       call      qword ptr [7FFC4F8E6628]
       mov       ecx,[rbp+40]
       cmp       ecx,21
       ja        near ptr M09_L33
       mov       [rbp+30],rdi
       mov       [rbp+38],ecx
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC4F34C108]; System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdi,rax
       jmp       near ptr M09_L06
M09_L21:
       mov       ecx,1D
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FFC4F8E6640]
M09_L22:
       jmp       near ptr M09_L06
       mov       ecx,13
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       mov       [rbp+20],rdx
       mov       [rbp+28],r8d
       lea       rdx,[rbp+20]
       lea       r8,[rbp+40]
       call      qword ptr [7FFC4F8E65F8]
       jmp       short M09_L22
       mov       ecx,14
       call      qword ptr [7FFC4F0B6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+0B0]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       lea       r8,[rbp+20]
       lea       r9,[rbp+40]
       mov       rdx,rsi
       call      qword ptr [7FFC4F8E6658]
       jmp       short M09_L22
M09_L23:
       test      rcx,rcx
       je        short M09_L24
       call      qword ptr [7FFC4F7A5230]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M09_L25
M09_L24:
       call      qword ptr [7FFC4F8E6670]
M09_L25:
       mov       [rbp+80],rax
       lea       rcx,[rbp+0B0]
       lea       rdx,[rbp+80]
       mov       r8,rsi
       call      qword ptr [7FFC4F8E66D0]
       mov       rcx,[rbp+80]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4F8E66E8]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L26:
       call      qword ptr [7FFC4F7A5230]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       short M09_L28
M09_L27:
       call      qword ptr [7FFC4F8E6670]
M09_L28:
       mov       [rbp+80],rax
       movzx     ecx,word ptr [rbx+0C]
       mov       rdx,[rbp+80]
       call      qword ptr [7FFC4F8E6700]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L29:
       call      qword ptr [7FFC4F7A5230]; System.Globalization.DateTimeFormatInfo.<GetInstance>g__GetProviderNonNull|71_0(System.IFormatProvider)
       jmp       near ptr M09_L03
M09_L30:
       mov       ecx,2
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L01
M09_L31:
       mov       rdx,24CEBFA1728
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
       call      qword ptr [7FFC4F28F228]
       int       3
M09_L34:
       xor       ecx,ecx
       mov       [rbp+60],rcx
       mov       rcx,20C57000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC4F380D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       call      00007FFCAED49D30
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+28]
       lea       rcx,[rbx+r12*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rcx,r14d
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r13d
       movsxd    rcx,r14d
       lea       rcx,[rbx+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFC4F285488]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC4F285488]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC4F285488]; System.String.Concat(System.String, System.String, System.String)
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
       jmp       qword ptr [7FFC4F285488]; System.String.Concat(System.String, System.String, System.String)
M10_L04:
       call      qword ptr [7FFC4F7ACB28]
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
       call      00007FFCAED49D30
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
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       jmp       short M11_L04
M11_L03:
       mov       rax,24CEBF90008
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
       call      00007FFCAED49D30
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
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       ebx,r13d
       ja        short M11_L12
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r14,24CEBF90008
       jmp       short M11_L06
M11_L12:
       call      qword ptr [7FFC4F4CCD98]
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
       mov       rcx,20C6D0002F8
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
       call      qword ptr [7FFC4F0BE538]; System.Text.UTF8Encoding..ctor(Boolean, Boolean)
       mov       rcx,20C6D0002F8
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
       call      qword ptr [7FFC4F7AFC00]
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
       mov       rax,0CDD4EE7A2C85
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
       mov       rbx,24CEBF96D78
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
       mov       rdx,24CEBF986D0
       cmp       ecx,5
       cmova     rbx,rdx
       test      rbx,rbx
       jne       near ptr M15_L104
       cmp       qword ptr [rbp+1E0],0
       jl        near ptr M15_L105
       cmp       qword ptr [rbp+1E0],0
       jg        near ptr M15_L106
M15_L05:
       cmp       dword ptr [7FFC4EFFB168],0
       je        near ptr M15_L107
M15_L06:
       mov       ecx,[7FFC4EFFB168]
       cmp       ecx,1
       je        near ptr M15_L13
       cmp       ecx,0FFFFFFFF
       jne       near ptr M15_L110
       mov       rcx,20C6D000300
       mov       rbx,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       call      qword ptr [7FFC4F34FC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
       mov       eax,[rbp+248]
M15_L08:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M15_L09
       mov       rcx,[rcx+8]
       lea       r8,[rbp+1D0]
       mov       rdx,rbx
       mov       r11,7FFC4F000C68
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
       call      qword ptr [7FFC4F0B5890]; System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       eax,[rbp+248]
M15_L11:
       movzx     ecx,byte ptr [rbx+8]
       test      ecx,ecx
       jne       near ptr M15_L14
M15_L12:
       call      qword ptr [7FFC4F7A5EC0]; System.Runtime.Serialization.SerializationInfo.GetThreadDeserializationTracker()
       movzx     eax,byte ptr [rax+8]
       test      eax,eax
       jne       near ptr M15_L14
M15_L13:
       mov       rcx,rdi
       call      qword ptr [7FFC4F34F000]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp+58],rax
       xor       ecx,ecx
       mov       [rbp+1C8],rcx
       mov       [rbp+1CC],ecx
       mov       rax,7FFD07305FF0
       call      rax
       lea       rdx,[rbp+1CC]
       mov       ecx,1
       mov       rax,7FFD0730BE20
       call      rax
       mov       edi,eax
       mov       rax,7FFD07305F30
       call      rax
       mov       ecx,eax
       call      00007FFCAED46B40
       test      edi,edi
       setne     al
       movzx     eax,al
       mov       [rbp+1C8],al
       movzx     eax,byte ptr [rbp+1C8]
       mov       [rbp+0BC],al
       mov       eax,[rbp+1CC]
       mov       [rbp+0B8],eax
       cmp       dword ptr [7FFCAF0039A0],0
       je        short M15_L15
       jmp       near ptr M15_L111
M15_L14:
       call      qword ptr [7FFC4F8E7318]
       mov       rdi,rax
       mov       rcx,offset MT_System.Runtime.Serialization.SerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1A1A1
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rbx,rax
       mov       ecx,1C65C
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F0BD9C8]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC4F7AD608]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC4F8E7330]
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
       mov       rcx,24CEBFA2278
       mov       r8,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       mov       r8d,[r8]
       and       r8d,0C0000
       cmp       r8d,40000
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       jne       near ptr M15_L43
       call      qword ptr [7FFC4F285680]; System.RuntimeType.CreateInstanceOfT()
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
       mov       rax,7FFD07305FF0
       call      rax
       mov       [rsp+20],ebx
       mov       dword ptr [rsp+28],100000
       xor       r9d,r9d
       mov       [rsp+30],r9
       lea       r9,[rbp+1B0]
       mov       rcx,rsi
       mov       edx,40000000
       mov       r8d,1
       mov       rax,7FFC4F22E9A8
       mov       [rbp+0E0],rax
       lea       rax,[M15_L20]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       mov       rax,7FFD07314EA0
       call      rax
M15_L20:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCAF0039A0],0
       je        short M15_L21
       call      qword ptr [7FFCAEFF1648]; CORINFO_HELP_STOP_FOR_GC
M15_L21:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       rbx,rax
       mov       rax,7FFD07305F30
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
       call      00007FFCAED46B40
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
       mov       rax,7FFD07305FF0
       call      rax
       lea       r8,[rbp+190]
       mov       rcx,rbx
       mov       edx,5
       mov       r9d,8
       mov       rax,7FFC4F22F5C0
       mov       [rbp+0E0],rax
       lea       rax,[M15_L25]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFC4F22F5E0]
M15_L25:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCAF0039A0],0
       je        short M15_L26
       call      qword ptr [7FFCAEFF1648]; CORINFO_HELP_STOP_FOR_GC
M15_L26:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       ebx,eax
       mov       rax,7FFD07305F30
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
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L29:
       call      M15_L167
       nop
       mov       ecx,[rbp+188]
       call      00007FFCAED46B40
       cmp       dword ptr [rbp+18C],0
       jne       near ptr M15_L50
       call      00007FFCAED46B20
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
       call      qword ptr [7FFC4F227810]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
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
       call      00007FFCAED46B20
       mov       esi,eax
       mov       rcx,[rdi+8]
       call      qword ptr [7FFC4F7A5F80]; Interop+Kernel32.CloseHandle(IntPtr)
       lea       rcx,[rdi+28]
       xor       eax,eax
       xchg      rax,[rcx]
       test      rax,rax
       jne       near ptr M15_L48
M15_L34:
       mov       ecx,esi
       call      00007FFCAED46B40
M15_L35:
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M15_L36
       mov       rcx,rdi
       call      00007FFCAED00DD0
M15_L36:
       cmp       qword ptr [rbp+58],0
       je        short M15_L37
       mov       rdx,[rbp+58]
       mov       esi,[rdx+8]
       cmp       esi,104
       jge       near ptr M15_L49
       mov       rcx,rdx
       call      qword ptr [7FFC4F34F168]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
       test      eax,eax
       jne       near ptr M15_L49
M15_L37:
       mov       rcx,[rbp+58]
       mov       rax,rcx
M15_L38:
       mov       rcx,rax
       call      qword ptr [7FFC4F8EC840]; Interop+Kernel32.DeleteFilePrivate(System.String)
       cmp       ebx,70
       je        short M15_L41
       mov       rcx,24CEBFA25E0
       call      qword ptr [7FFC4F7AF8E8]
       mov       rdi,rax
M15_L39:
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp+1E0]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,[rbp+58]
       call      qword ptr [7FFC4F7AD500]
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,ebx
       call      qword ptr [7FFC4F8EC858]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC4F8EC870]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M15_L40:
       xor       ecx,ecx
       jmp       near ptr M15_L32
M15_L41:
       mov       rcx,24CEBFA2588
       call      qword ptr [7FFC4F7AF8E8]
       mov       rdi,rax
       jmp       short M15_L39
M15_L42:
       mov       rcx,rdx
       call      qword ptr [7FFC4F6D5DD0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       near ptr M15_L17
M15_L43:
       xor       r8d,r8d
       mov       [rbp+198],r8
       lea       rdx,[rbp+198]
       call      qword ptr [7FFC4F8E4CD8]
       mov       rdi,[rbp+198]
       jmp       near ptr M15_L18
M15_L44:
       call      00007FFCAED46B20
       mov       ebx,eax
       cmp       ebx,3
       jne       short M15_L45
       mov       rdx,[rbp+58]
       mov       esi,[rdx+8]
       lea       rcx,[rdx+0C]
       mov       [rbp+98],rcx
       mov       [rbp+0A0],esi
       lea       rcx,[rbp+98]
       call      qword ptr [7FFC4F6D5D88]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       ecx,5
       cmp       eax,esi
       cmove     ebx,ecx
M15_L45:
       mov       rcx,rdi
       call      qword ptr [7FFC4F227700]; Precode of System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,ebx
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       call      qword ptr [7FFC4F8E48D0]
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
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L48:
       mov       rcx,rax
       call      qword ptr [7FFC4F8E49C0]
       jmp       near ptr M15_L34
M15_L49:
       mov       rdx,[rbp+58]
       mov       rcx,rdx
       call      qword ptr [7FFC4F6D5DD0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M15_L38
M15_L50:
       cmp       byte ptr [rbp+0BC],0
       je        short M15_L51
       xor       ecx,ecx
       mov       [rbp+178],ecx
       call      00007FFC4F0A8CF0
       lea       rdx,[rbp+178]
       mov       ecx,[rbp+0B8]
       call      00007FFC4F0A8D38
       call      00007FFC4F0A8D20
       mov       ecx,eax
       call      00007FFCAED46B40
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
       call      qword ptr [7FFC4F1BCD30]; System.Text.UTF8Encoding.GetMaxByteCount(Int32)
M15_L54:
       mov       edx,eax
       add       edx,[rbp+0C8]
       jo        near ptr M15_L98
       xor       ecx,ecx
       mov       [rbp+68],rcx
       cmp       edx,400
       jbe       near ptr M15_L96
       mov       rcx,20C57001E50
       mov       rcx,[rcx]
       call      qword ptr [7FFC4F6E21A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC4F0B7C00]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFC4F8E4918]
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
       call      qword ptr [7FFC4F0BDDB8]; Microsoft.Win32.SafeHandles.SafeFileHandle.GetFileOptions()
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
       mov       rax,7FFD07305FF0
       call      rax
       lea       r9,[rbp+138]
       mov       [rsp+20],r9
       lea       r9,[rbp+128]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r13d
       mov       rax,7FFC4F22F840
       mov       [rbp+0E0],rax
       lea       rax,[M15_L70]
       mov       [rbp+0F0],rax
       mov       rax,[rbp+108]
       lea       r10,[rbp+0D0]
       mov       [rax+8],r10
       mov       rax,[rbp+108]
       mov       byte ptr [rax+4],0
       mov       rax,7FFD07315310
       call      rax
M15_L70:
       mov       rcx,[rbp+108]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCAF0039A0],0
       je        short M15_L71
       call      qword ptr [7FFCAEFF1648]; CORINFO_HELP_STOP_FOR_GC
M15_L71:
       mov       rcx,[rbp+108]
       mov       rdx,[rbp+0D8]
       mov       [rcx+8],rdx
       mov       [rbp+124],eax
       mov       rax,7FFD07305F30
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
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L74:
       call      M15_L114
       nop
       mov       ecx,[rbp+120]
       call      00007FFCAED46B40
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
       call      qword ptr [7FFC4F4CCD98]
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
       call      qword ptr [7FFC4F8E4990]
       jmp       near ptr M15_L75
M15_L85:
       mov       rcx,rsi
       call      qword ptr [7FFC4F0BE1C0]; Interop+Kernel32.GetFileType(System.Runtime.InteropServices.SafeHandle)
       mov       edi,eax
       mov       [rsi+3C],edi
       jmp       near ptr M15_L67
M15_L86:
       mov       ecx,13C60
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F7AC6F0]
       int       3
M15_L87:
       mov       ecx,11AD
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F7AC6F0]
       int       3
M15_L88:
       mov       ecx,13C46
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC4F7AC6C0]
       int       3
M15_L89:
       mov       ecx,13C80
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFC4F7AC6C0]
       int       3
M15_L90:
       call      qword ptr [7FFC4F28F228]
       int       3
M15_L91:
       mov       rcx,[rbp+70]
       call      qword ptr [7FFC4F8E49A8]
       mov       ecx,eax
       mov       rax,[rbp+70]
       mov       rdx,[rax+18]
       xor       r8d,r8d
       call      qword ptr [7FFC4F8E48D0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L92:
       call      M15_L129
       jmp       near ptr M15_L99
M15_L93:
       mov       rcx,[rbp+70]
       call      qword ptr [7FFC4F0BE1A8]; Microsoft.Win32.SafeHandles.SafeFileHandle.get_CanSeek()
       test      eax,eax
       je        near ptr M15_L52
       mov       rcx,[rbp+70]
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFC4F8E7210]
       mov       rcx,[rbp+70]
       call      qword ptr [7FFC4F8E7228]
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
       call      qword ptr [7FFC4F284DC8]; System.IO.RandomAccess.WriteAtOffset(Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlySpan`1<Byte>, Int64)
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
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC4F7AFC00]
       int       3
M15_L101:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,7FFCADEB91C0
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
       call      qword ptr [7FFC4F8E7258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC4F34D9B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L105:
       mov       ecx,1C638
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rcx,rax
       call      qword ptr [7FFC4F6DD338]
       int       3
M15_L106:
       mov       ecx,eax
       mov       edx,2
       call      qword ptr [7FFC4F8E72A0]
       mov       eax,[rbp+248]
       jmp       near ptr M15_L05
M15_L107:
       mov       rcx,24CEBFA21C0
       mov       rdx,24CEBFA2188
       call      qword ptr [7FFC4F0BD9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       lea       rdx,[rbp+1D8]
       call      qword ptr [7FFC4F0B67A8]; System.AppContext.TryGetSwitch(System.String, Boolean ByRef)
       movzx     ecx,byte ptr [rbp+1D8]
       test      ecx,eax
       je        short M15_L108
       mov       dword ptr [7FFC4EFFB168],1
       mov       eax,[rbp+248]
       jmp       near ptr M15_L06
M15_L108:
       mov       dword ptr [7FFC4EFFB168],0FFFFFFFF
       mov       eax,[rbp+248]
       jmp       near ptr M15_L06
M15_L109:
       mov       ecx,4
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       mov       eax,[rbp+248]
       jmp       near ptr M15_L07
M15_L110:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1A211
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4F8E7348]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L15
M15_L112:
       mov       r8,0CDD4EE7A2C85
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
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L125:
       test      ecx,ecx
       je        short M15_L128
       call      00007FFCAED46B20
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L126
       mov       rdi,[rbx+8]
       xor       ecx,ecx
       call      00007FFC4F0A8CF0
       mov       rcx,rdi
       call      00007FFC4F0A8D08
       call      00007FFC4F0A8D20
       mov       ecx,eax
       call      00007FFCAED46B40
       add       rbx,28
       xor       ecx,ecx
       xchg      rcx,[rbx]
       test      rcx,rcx
       je        short M15_L127
       call      qword ptr [7FFC4F8E49C0]
       jmp       short M15_L127
M15_L126:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M15_L127:
       mov       ecx,esi
       call      00007FFCAED46B40
M15_L128:
       nop
       add       rsp,48
       ret
M15_L129:
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp+68],0
       je        near ptr M15_L151
       mov       rcx,20C57001E50
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M15_L130
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M15_L131
M15_L130:
       mov       ecx,0A
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M15_L131:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M15_L132
       mov       rcx,rbx
       call      qword ptr [7FFC4F7A5140]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFC4F7AD0E0]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFC4F4361F0]
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
       call      qword ptr [7FFC4F8E57A0]
M15_L134:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFFB184],0
       je        short M15_L135
       call      qword ptr [7FFC4F7ACFD8]
       mov       r15d,eax
       jmp       short M15_L137
M15_L135:
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       mov       r15d,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M15_L136
       call      qword ptr [7FFC4F7AD008]
       mov       r15d,eax
       jmp       short M15_L137
M15_L136:
       sar       r15d,10
M15_L137:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFC4EFFB178]
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
       call      qword ptr [7FFC4F5CDFE0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0B6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,20C57000C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M15_L151
       mov       rcx,[rbp+68]
       cmp       dword ptr [rcx+8],0
       je        near ptr M15_L151
       mov       rcx,[rbp+68]
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+68]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFC4F7AD110]
       test      r14d,edi
       jne       short M15_L151
       mov       rcx,[rbp+68]
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+68]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F7AD128]
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
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L162:
       test      edx,edx
       je        short M15_L164
       call      00007FFCAED46B20
       mov       ebx,eax
       mov       rcx,[rbp+70]
       mov       rsi,[rcx+8]
       xor       ecx,ecx
       call      00007FFC4F0A8CF0
       mov       rcx,rsi
       call      00007FFC4F0A8D08
       call      00007FFC4F0A8D20
       mov       ecx,eax
       call      00007FFCAED46B40
       mov       rcx,[rbp+70]
       lea       rax,[rcx+28]
       xor       edx,edx
       xchg      rdx,[rax]
       test      rdx,rdx
       je        short M15_L163
       mov       rcx,rdx
       call      qword ptr [7FFC4F8E49C0]
M15_L163:
       mov       ecx,ebx
       call      00007FFCAED46B40
       mov       rcx,[rbp+70]
M15_L164:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M15_L165
       call      00007FFCAED00DD0
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
       call      qword ptr [7FFC4F285590]; System.GC.SuppressFinalize(System.Object)
M15_L166:
       nop
       add       rsp,48
       ret
M15_L167:
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+0B0],0
       je        near ptr M15_L181
       mov       rbx,[rbp+18]
       mov       rcx,[rbp+18]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        near ptr M15_L177
M15_L168:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M15_L174
       jmp       short M15_L170
M15_L169:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M15_L168
       jmp       short M15_L177
M15_L170:
       cmp       byte ptr [rbx+14],0
       je        short M15_L174
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L172
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M15_L171
       cmp       rcx,0FFFFFFFFFFFFFFFF
       sete      dil
       movzx     edi,dil
       jmp       short M15_L173
M15_L171:
       mov       edi,1
       jmp       short M15_L173
M15_L172:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M15_L173:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M15_L175
M15_L174:
       xor       ecx,ecx
M15_L175:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M15_L176
       or        edx,1
M15_L176:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M15_L169
       jmp       short M15_L178
M15_L177:
       mov       rcx,rbx
       call      qword ptr [7FFC4F8E4888]
       int       3
M15_L178:
       test      ecx,ecx
       je        short M15_L181
       call      00007FFCAED46B20
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       cmp       [rbx],rcx
       jne       short M15_L179
       mov       rcx,[rbx+8]
       call      qword ptr [7FFC4F7A5F80]; Interop+Kernel32.CloseHandle(IntPtr)
       add       rbx,28
       xor       ecx,ecx
       xchg      rcx,[rbx]
       test      rcx,rcx
       je        short M15_L180
       call      qword ptr [7FFC4F8E49C0]
       jmp       short M15_L180
M15_L179:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M15_L180:
       mov       ecx,esi
       call      00007FFCAED46B40
M15_L181:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+0BC],0
       je        short M15_L182
       xor       ecx,ecx
       mov       [rbp+178],ecx
       call      00007FFC4F0A8CF0
       lea       rdx,[rbp+178]
       mov       ecx,[rbp+0B8]
       call      00007FFC4F0A8D38
       call      00007FFC4F0A8D20
       mov       ecx,eax
       call      00007FFCAED46B40
M15_L182:
       nop
       add       rsp,48
       ret
; Total bytes of code 6636
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
       call      00007FFCAED49D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC4F0B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24CEBF90008
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
       call      qword ptr [7FFC4F7ACB28]
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
       call      qword ptr [7FFCACDA84E0]
       cmp       byte ptr [rax],0
       je        near ptr M17_L03
       call      qword ptr [7FFCACDAEBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M17_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
M17_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M17_L01:
       call      qword ptr [7FFCACDAA688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M17_L00
       call      qword ptr [7FFCACDA84D8]
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
       call      qword ptr [7FFCACDB02E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFCACDAEC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCACDAE4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFCACDAA6A0]
       test      rax,rax
       je        near ptr M17_L00
M17_L04:
       call      qword ptr [7FFCACDACE58]
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
       call      qword ptr [7FFCACDAE588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFCACDAC548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FFCACDAB180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M19_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M19_L03
M19_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFCACDAEEF8]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M19_L04
M19_L03:
       mov       rcx,rax
       call      qword ptr [7FFCACDAB218]
       jmp       short M19_L02
M19_L04:
       cmp       byte ptr [rbp-10],0
       je        short M19_L05
       mov       rcx,rbx
       call      qword ptr [7FFCACDAB188]; Precode of System.Threading.Monitor.Exit(System.Object)
M19_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M19_L06:
       call      qword ptr [7FFCACDACE50]
       int       3
M19_L07:
       mov       rcx,rax
       call      qword ptr [7FFCACDAB218]
       jmp       near ptr M19_L00
M19_L08:
       mov       rcx,rax
       call      qword ptr [7FFCACDAE530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M19_L01
       sub       rsp,28
       call      qword ptr [7FFCACDAB210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FFCACDA8278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FFCACDA8258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M19_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FFCACDAB188]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       jmp       qword ptr [7FFC4F7AD338]
; Total bytes of code 90
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCAEB2CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFC4F0B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,[rcx+30]
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
       mov       rcx,20C57000C90
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
       call      qword ptr [7FFC4F0BFD50]
       int       3
M23_L06:
       mov       ecx,0A
       call      qword ptr [7FFC4F7AC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M23_L00
M23_L07:
       mov       rcx,rdi
       call      qword ptr [7FFC4F7A5140]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M23_L01
M23_L08:
       mov       rcx,rbx
       call      qword ptr [7FFC4F7AD0C8]
       jmp       near ptr M23_L02
M23_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFC4F7AD0E0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFC4EFF4000
       call      qword ptr [7FFC4F0BF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFC4F4361F0]
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
       call      qword ptr [7FFC4F8E57A0]
M23_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC4EFFB184],0
       je        short M23_L12
       call      qword ptr [7FFC4F7ACFD8]
       mov       esi,eax
       jmp       short M23_L14
M23_L12:
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       mov       esi,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFC4F7ACFF0]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M23_L13
       call      qword ptr [7FFC4F7AD008]
       mov       esi,eax
       jmp       short M23_L14
M23_L13:
       sar       esi,10
M23_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC4F0B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFC4EFFB178]
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
       call      qword ptr [7FFC4F5CDFE0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC4F0B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFC4F7AD110]
       test      r12d,r13d
       jne       near ptr M23_L04
       mov       rcx,rbx
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFC4F4CD440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC4F7AD128]
       jmp       near ptr M23_L04
M23_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```

