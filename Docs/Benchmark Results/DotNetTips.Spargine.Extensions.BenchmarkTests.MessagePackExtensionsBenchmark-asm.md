## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MessagePackExtensionsBenchmark.FromMessagePack()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1C8
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1D0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+1C0],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       eax,[rsi+8]
       test      eax,eax
       je        near ptr M00_L03
       mov       edi,eax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+138],ymm0
       vmovdqu   ymmword ptr [rsp+158],ymm0
       vmovdqu   ymmword ptr [rsp+178],ymm0
       vmovdqu   ymmword ptr [rsp+198],ymm0
       vmovdqu   xmmword ptr [rsp+1B8],xmm0
       mov       rdx,[rsi]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L04
       lea       rbp,[rsi+10]
M00_L01:
       cmp       edi,eax
       ja        near ptr M00_L05
       mov       r14d,edi
       mov       r15d,1
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+38]
       vmovdqu   ymmword ptr [rsp+150],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+58]
       vmovdqu   ymmword ptr [rsp+170],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+190],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+1B0],xmm0
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+138]
       mov       r8d,90
       vzeroupper
       call      qword ptr [7FF7DEE157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       xor       edx,edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],r14
       mov       [rsp+0C8],rdx
       mov       [rsp+0D0],edx
       mov       byte ptr [rsp+0D4],0
       mov       [rsp+0D5],r15b
       mov       [rsp+110],rsi
       mov       [rsp+118],edx
       mov       [rsp+11C],edi
       mov       [rsp+120],rbp
       mov       [rsp+128],edi
       mov       [rsp+130],rdx
       lea       rdx,[rsp+0A8]
       mov       rcx,7FF7DF591A28
       xor       r8d,r8d
       call      qword ptr [7FF7DF566FB8]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       mov       [rsp+20],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       vzeroupper
       add       rsp,1C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       call      qword ptr [7FF7DF3CFA68]
       mov       ecx,867
       mov       rdx,7FF7DF21D530
       call      qword ptr [7FF7DF037798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7DF111A60
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DEE17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DF21D530
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DEE17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DF676460]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DF3CF2A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,867
       mov       rdx,7FF7DF21D530
       call      qword ptr [7FF7DF037798]
       mov       rsi,rax
       call      qword ptr [7FF7DF676460]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DF3CF2A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L04:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbp,[rsp+28]
       mov       eax,[rsp+30]
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FF7DEF87198]
       int       3
; Total bytes of code 761
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M01_L02
       call      00007FF83EA237A0
       cmp       dword ptr [7FF83ED63A90],0
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L00
M01_L02:
       add       rsp,28
       jmp       qword ptr [7FF7DF3CF540]
; Total bytes of code 49
```
```assembly
; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,228
       lea       rbp,[rsp+260]
       xor       eax,eax
       mov       [rbp-1E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1E0],xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rsi,rsi
       jne       short M02_L01
       mov       rcx,1FF56001EC8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L93
M02_L01:
       mov       rdi,rsi
       cmp       dword ptr [rdi+20],0
       jne       near ptr M02_L32
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+10]
       test      r14,r14
       je        near ptr M02_L15
M02_L02:
       mov       rdx,[rcx+18]
       mov       r15,[rdx+18]
       test      r15,r15
       je        near ptr M02_L16
M02_L03:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FF7DF45CA80]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.GeneratedMessagePackResolver+DotNetTips+Spargine+Extensions+BenchmarkTests+TestMessagePackModelFormatter
       cmp       [rax],rcx
       jne       near ptr M02_L91
       lea       r15,[rbx+18]
       mov       rcx,r15
       cmp       byte ptr [rcx+15],0
       je        near ptr M02_L31
       mov       rdx,[rcx+60]
       mov       eax,[rcx+68]
       mov       ecx,[rcx+10]
       cmp       ecx,eax
       jae       near ptr M02_L90
       movzx     ecx,byte ptr [rdx+rcx]
       cmp       ecx,0C0
       je        near ptr M02_L43
       mov       rcx,[rdi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DF567198]; MessagePack.MessagePackSecurity.DepthStep(MessagePack.MessagePackReader ByRef)
       mov       rsi,[rdi+8]
       mov       rcx,r15
       mov       rdx,[rcx+60]
       mov       eax,[rcx+68]
       mov       ecx,[rcx+10]
       cmp       ecx,eax
       ja        near ptr M02_L84
       mov       r8d,ecx
       add       rdx,r8
       sub       eax,ecx
       mov       dword ptr [rbp-110],1
       test      eax,eax
       je        near ptr M02_L48
       movzx     ecx,byte ptr [rdx]
       mov       r8d,ecx
       cmp       r8d,90
       jl        near ptr M02_L53
       cmp       r8d,9F
       jg        near ptr M02_L49
       and       ecx,0F
       cmp       ecx,0FF
       ja        near ptr M02_L89
       mov       r14d,ecx
M02_L04:
       xor       edx,edx
M02_L05:
       test      r14d,r14d
       jl        near ptr M02_L89
       mov       ecx,r14d
       mov       [rbp-108],ecx
       test      edx,edx
       jne       near ptr M02_L56
       mov       rcx,r15
       movsxd    rdx,dword ptr [rbp-110]
       test      rdx,0FFFFFFFF80000000
       jne       near ptr M02_L17
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,edx
       jle       near ptr M02_L17
       mov       eax,edx
       add       eax,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
M02_L06:
       movsxd    r14,dword ptr [rbp-108]
       mov       rdx,[rbx+20]
       mov       rcx,rdx
       sub       rcx,[rbx+8]
       jo        near ptr M02_L89
       mov       rax,[rbx]
       sub       rax,rcx
       jo        near ptr M02_L89
       xor       ecx,ecx
       test      rax,rax
       cmovg     rcx,rax
       mov       [rbx],rcx
       mov       [rbx+8],rdx
       test      r14,r14
       jl        near ptr M02_L31
       mov       r13,[rbx]
       mov       r12,r15
       cmp       qword ptr [r12],0
       jl        near ptr M02_L57
M02_L07:
       mov       rdx,[r12]
       sub       rdx,[r12+8]
       jo        near ptr M02_L89
       cmp       rdx,r13
       jl        near ptr M02_L31
       mov       r13,r15
       cmp       qword ptr [r13],0
       jl        near ptr M02_L60
M02_L08:
       mov       rdx,[r13]
       sub       rdx,[r13+8]
       jo        near ptr M02_L89
       sub       rdx,[rbx]
       jo        near ptr M02_L89
       cmp       rdx,r14
       jl        near ptr M02_L31
       add       r14,[rbx]
       jo        near ptr M02_L89
       mov       [rbx],r14
       mov       r14d,[rbp-108]
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
       cmp       eax,r14d
       jge       near ptr M02_L13
M02_L09:
       mov       [rbp-0FC],eax
       test      eax,eax
       jne       near ptr M02_L19
       xor       edx,edx
       mov       [rbp-168],edx
       mov       rdx,r15
       mov       r9,[rdx+60]
       mov       r8d,[rdx+68]
       mov       edx,[rdx+10]
       cmp       edx,r8d
       ja        near ptr M02_L84
       mov       ecx,edx
       add       r9,rcx
       sub       r8d,edx
       xor       edx,edx
       mov       [rbp-170],rdx
       test      r8d,r8d
       jle       near ptr M02_L65
       movzx     edx,byte ptr [r9]
       mov       rcx,1FF6C000780
       mov       rcx,[rcx]
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,offset MT_MessagePack.MessagePackPrimitives+Decoders+ReadInt64FixInt
       cmp       [rcx],rdx
       jne       near ptr M02_L64
       mov       dword ptr [rbp-168],1
       movzx     r9d,byte ptr [r9]
       mov       [rbp-170],r9
       xor       edx,edx
M02_L10:
       mov       r13,[rbp-170]
       movsxd    rcx,r13d
       cmp       r13,rcx
       jne       near ptr M02_L89
M02_L11:
       test      edx,edx
       jne       near ptr M02_L67
       mov       rcx,r15
       movsxd    rdx,dword ptr [rbp-168]
       test      rdx,0FFFFFFFF80000000
       jne       near ptr M02_L18
       mov       r8d,[rcx+68]
       sub       r8d,[rcx+10]
       jo        near ptr M02_L89
       cmp       r8d,edx
       jle       near ptr M02_L18
       mov       r8d,edx
       add       r8d,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],r8d
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
M02_L12:
       mov       eax,[rbp-0FC]
       inc       eax
       cmp       eax,r14d
       jl        near ptr M02_L09
M02_L13:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.TestMessagePackModel
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+10],r13d
       lea       rcx,[rsi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       dec       dword ptr [rbx+10]
M02_L14:
       mov       [rbp-1E8],rsi
       jmp       near ptr M02_L92
M02_L15:
       mov       rdx,7FF7DF577BA8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L02
M02_L16:
       mov       rdx,7FF7DF577BC8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M02_L03
M02_L17:
       cmp       byte ptr [rcx+14],0
       jne       near ptr M02_L54
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,edx
       jne       near ptr M02_L55
       mov       eax,edx
       add       eax,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       mov       rax,rdx
       add       rax,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       near ptr M02_L06
M02_L18:
       cmp       byte ptr [rcx+14],0
       jne       near ptr M02_L66
       mov       r8d,[rcx+68]
       sub       r8d,[rcx+10]
       jo        near ptr M02_L89
       cmp       r8d,edx
       jne       near ptr M02_L81
       mov       r8d,edx
       add       r8d,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],r8d
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
       mov       byte ptr [rcx+15],0
       jmp       near ptr M02_L12
M02_L19:
       cmp       dword ptr [rbp-0FC],1
       jne       near ptr M02_L63
       mov       rdx,rsi
       mov       rcx,7FF7DF53A510
       call      qword ptr [7FF7DF45CA80]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.NullableStringFormatter
       cmp       [rax],rcx
       jne       near ptr M02_L80
       mov       rcx,r15
       cmp       byte ptr [rcx+15],0
       je        near ptr M02_L31
       mov       rdx,[rcx+60]
       mov       r8d,[rcx+68]
       mov       ecx,[rcx+10]
       cmp       ecx,r8d
       jae       near ptr M02_L90
       movzx     ecx,byte ptr [rdx+rcx]
       cmp       ecx,0C0
       je        near ptr M02_L68
       xor       ecx,ecx
       mov       [rbp-178],ecx
       mov       [rbp-180],ecx
       mov       rcx,r15
       mov       rdx,[rcx+60]
       mov       r8d,[rcx+68]
       mov       ecx,[rcx+10]
       cmp       ecx,r8d
       ja        near ptr M02_L84
       mov       eax,ecx
       add       rdx,rax
       sub       r8d,ecx
       mov       [rbp-1D0],rdx
       mov       [rbp-1C8],r8d
       lea       rcx,[rbp-1D0]
       lea       rdx,[rbp-178]
       lea       r8,[rbp-180]
       call      qword ptr [7FF7DF5679F0]; MessagePack.MessagePackPrimitives.TryReadStringHeader(System.ReadOnlySpan`1<Byte>, UInt32 ByRef, Int32 ByRef)
       test      eax,eax
       jne       near ptr M02_L73
       mov       rcx,r15
       movsxd    rdx,dword ptr [rbp-180]
       test      rdx,0FFFFFFFF80000000
       jne       near ptr M02_L22
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,edx
       jle       near ptr M02_L22
       mov       eax,edx
       add       eax,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
M02_L20:
       mov       r12d,[rbp-178]
       mov       r8,r15
       mov       rax,[r8+60]
       mov       r9d,[r8+68]
       mov       r8d,[r8+10]
       cmp       r8d,r9d
       ja        near ptr M02_L84
       mov       r10d,r8d
       add       rax,r10
       sub       r9d,r8d
       movsxd    r8,r9d
       mov       ecx,r12d
       cmp       r8,rcx
       jl        near ptr M02_L79
       test      r12d,r12d
       jl        near ptr M02_L89
       mov       r10d,r12d
       mov       [rbp-184],r10d
       cmp       r10d,r9d
       ja        near ptr M02_L84
       mov       r8,1FF6C0004A8
       mov       r11,[r8]
       mov       [rbp-208],r11
       test      r10d,r10d
       je        near ptr M02_L74
M02_L21:
       mov       [rbp-190],rax
       mov       [rbp-1D8],rax
       test      rax,rax
       jne       short M02_L23
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7DF56CD20]
       int       3
M02_L22:
       cmp       byte ptr [rcx+14],0
       jne       near ptr M02_L72
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,edx
       jne       near ptr M02_L83
       mov       eax,edx
       add       eax,[rcx+10]
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
       mov       byte ptr [rcx+15],0
       jmp       near ptr M02_L20
M02_L23:
       test      r10d,r10d
       jl        near ptr M02_L30
       lea       r8,[rbp-1A8]
       lea       r9,[rbp-1B0]
       mov       rcx,rax
       mov       edx,r10d
       call      qword ptr [7FF7DEF84C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r10,[rbp-1D8]
       mov       r9d,eax
       sub       r9d,r10d
       mov       eax,r9d
       add       eax,[rbp-1A8]
       mov       [rbp-19C],eax
       mov       r11d,[rbp-184]
       cmp       r9d,r11d
       jne       near ptr M02_L75
M02_L24:
       mov       eax,[rbp-19C]
       test      eax,eax
       je        near ptr M02_L76
       mov       [rbp-19C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FF83EAA52E0
       mov       [rbp-218],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       [rbp-198],rcx
       mov       r10,[rbp-198]
       mov       [rbp-1E0],r10
       test      r10,r10
       je        near ptr M02_L86
       mov       r11d,[rbp-184]
       mov       r9d,[rbp-19C]
       mov       ecx,r11d
       or        ecx,r9d
       jl        near ptr M02_L87
       lea       rcx,[rbp-1B8]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-1C0]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-1D8]
       mov       edx,r11d
       mov       r8,r10
       mov       [rbp-19C],r9d
       call      qword ptr [7FF7DEF84C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-1B8]
       mov       rdx,[rbp-1D8]
       sub       ecx,edx
       mov       r8,[rbp-1C0]
       mov       r9,[rbp-1E0]
       sub       r8,r9
       mov       rax,r8
       shr       rax,3F
       add       r8,rax
       sar       r8,1
       mov       r11d,[rbp-184]
       cmp       ecx,r11d
       jne       near ptr M02_L77
M02_L25:
       xor       ecx,ecx
       mov       [rbp-198],rcx
       mov       rax,[rbp-218]
M02_L26:
       xor       ecx,ecx
       mov       [rbp-198],rcx
       mov       [rbp-190],rcx
       mov       rcx,r15
       mov       edx,r12d
       test      rdx,0FFFFFFFF80000000
       jne       short M02_L29
       mov       r8d,[rcx+68]
       mov       r10d,[rcx+10]
       sub       r8d,r10d
       jo        near ptr M02_L89
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L89
       mov       r9d,edx
       cmp       r8d,r9d
       jle       short M02_L29
       add       r10d,r9d
       jo        near ptr M02_L89
       mov       [rcx+10],r10d
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
M02_L27:
       mov       r12,rax
M02_L28:
       jmp       near ptr M02_L12
M02_L29:
       cmp       byte ptr [rcx+14],0
       jne       near ptr M02_L78
       mov       r8d,[rcx+68]
       mov       r10d,[rcx+10]
       sub       r8d,r10d
       jo        near ptr M02_L89
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L89
       mov       r9d,edx
       cmp       r8d,r9d
       jne       near ptr M02_L88
       mov       r8d,r10d
       add       r8d,r9d
       jo        near ptr M02_L89
       mov       [rcx+10],r8d
       add       rdx,[rcx+8]
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
       mov       byte ptr [rcx+15],0
       jmp       short M02_L27
M02_L30:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FF7DF3C73D8]
       int       3
M02_L31:
       call      qword ptr [7FF7DF5672A0]
       int       3
M02_L32:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DF45CB40]
       mov       rdx,[rbp-48]
       mov       [rbp-220],rdx
       mov       rcx,rbx
       mov       rdx,[rbp-220]
       mov       r8,rsi
       call      qword ptr [7FF7DF567108]
       test      eax,eax
       je        near ptr M02_L37
       mov       rdx,[rbp-220]
       cmp       [rdx],dl
       lea       rcx,[rbp-0F8]
       call      qword ptr [7FF7DF45CBB8]
       lea       r8,[rbp-0F8]
       lea       rdx,[rbp-0E0]
       mov       rcx,rbx
       call      qword ptr [7FF7DF567120]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        short M02_L33
       jmp       short M02_L34
M02_L33:
       mov       rdx,7FF7DF577BA8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       mov       rcx,[rbp+10]
M02_L34:
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M02_L35
       jmp       short M02_L36
M02_L35:
       mov       rdx,7FF7DF577BC8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L36:
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF7DF45CA80]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0E0]
       mov       r11,rdi
       mov       r8,rsi
       call      qword ptr [rdi]
       mov       [rbp-1E8],rax
       jmp       short M02_L42
M02_L37:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rdx,7FF7DF577BA8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L39:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M02_L40
       jmp       short M02_L41
M02_L40:
       mov       rdx,7FF7DF577BC8
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M02_L41:
       mov       rdx,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF7DF45CA80]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       mov       r11,r14
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [r14]
       mov       [rbp-1E8],rax
       call      M02_L94
       jmp       near ptr M02_L92
M02_L42:
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M02_L92
       mov       rdx,[rbp-220]
       call      qword ptr [7FF7DF6764D8]
       jmp       near ptr M02_L92
M02_L43:
       mov       rcx,r15
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,1
       jle       short M02_L44
       mov       eax,[rcx+10]
       add       eax,1
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M02_L89
       mov       [rcx+8],rax
       jmp       near ptr M02_L47
M02_L44:
       cmp       byte ptr [rcx+14],0
       je        short M02_L45
       mov       edx,1
       call      qword ptr [7FF7DF5673A8]
       jmp       short M02_L47
M02_L45:
       mov       eax,[rcx+68]
       sub       eax,[rcx+10]
       jo        near ptr M02_L89
       cmp       eax,1
       jne       short M02_L46
       mov       eax,[rcx+10]
       add       eax,1
       jo        near ptr M02_L89
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M02_L89
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       short M02_L47
M02_L46:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L47:
       xor       esi,esi
       jmp       near ptr M02_L14
M02_L48:
       xor       r14d,r14d
       mov       edx,2
       jmp       near ptr M02_L05
M02_L49:
       cmp       r8d,0DC
       je        short M02_L50
       cmp       r8d,0DD
       jne       near ptr M02_L53
       mov       dword ptr [rbp-110],5
       inc       rdx
       dec       eax
       mov       [rbp-1D0],rdx
       mov       [rbp-1C8],eax
       lea       rcx,[rbp-1D0]
       lea       rdx,[rbp-120]
       call      qword ptr [7FF7DF567378]
       test      eax,eax
       je        short M02_L52
       jmp       short M02_L51
M02_L50:
       mov       dword ptr [rbp-110],3
       lea       rcx,[rdx+1]
       lea       edx,[rax-1]
       mov       [rbp-1D0],rcx
       mov       [rbp-1C8],edx
       lea       rcx,[rbp-1D0]
       lea       rdx,[rbp-118]
       call      qword ptr [7FF7DF567360]
       test      eax,eax
       je        short M02_L52
       movzx     r14d,word ptr [rbp-118]
       jmp       near ptr M02_L04
M02_L51:
       mov       r14d,[rbp-120]
       jmp       near ptr M02_L04
M02_L52:
       xor       r14d,r14d
       mov       edx,3
       jmp       near ptr M02_L05
M02_L53:
       xor       r14d,r14d
       mov       edx,1
       jmp       near ptr M02_L05
M02_L54:
       call      qword ptr [7FF7DF5673A8]
       jmp       near ptr M02_L06
M02_L55:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L56:
       lea       r8,[rbp-108]
       lea       r9,[rbp-110]
       mov       rcx,rbx
       call      qword ptr [7FF7DF567348]
       test      eax,eax
       jne       near ptr M02_L06
       jmp       near ptr M02_L31
M02_L57:
       lea       rdx,[rbp-138]
       mov       rcx,r12
       call      qword ptr [7FF7DF567408]
       mov       rdx,[rbp-138]
       mov       rax,[rbp-130]
       mov       [rbp-1F0],rax
       mov       r8d,[rbp-128]
       and       r8d,7FFFFFFF
       mov       [rbp-13C],r8d
       mov       ecx,[rbp-124]
       and       ecx,7FFFFFFF
       mov       [rbp-140],ecx
       cmp       rdx,rax
       je        short M02_L58
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rbp-1F8],rax
       mov       rdx,[rbp-1F0]
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r10,dword ptr [rbp-140]
       add       r10,[rax+10]
       movsxd    rdx,dword ptr [rbp-13C]
       mov       rcx,[rbp-1F8]
       add       rdx,[rcx+10]
       sub       r10,rdx
       jmp       short M02_L59
M02_L58:
       sub       ecx,r8d
       movsxd    r10,ecx
M02_L59:
       mov       [r12],r10
       jmp       near ptr M02_L07
M02_L60:
       lea       rdx,[rbp-158]
       mov       rcx,r13
       call      qword ptr [7FF7DF567408]
       mov       rdx,[rbp-158]
       mov       r12,[rbp-150]
       mov       eax,[rbp-148]
       and       eax,7FFFFFFF
       mov       [rbp-15C],eax
       mov       ecx,[rbp-144]
       and       ecx,7FFFFFFF
       mov       [rbp-160],ecx
       cmp       rdx,r12
       je        short M02_L61
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rbp-200],rax
       mov       rdx,r12
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r8,dword ptr [rbp-160]
       add       r8,[rax+10]
       movsxd    rdx,dword ptr [rbp-15C]
       mov       r12,[rbp-200]
       add       rdx,[r12+10]
       sub       r8,rdx
       jmp       short M02_L62
M02_L61:
       sub       ecx,eax
       movsxd    r8,ecx
M02_L62:
       mov       [r13],r8
       jmp       near ptr M02_L08
M02_L63:
       mov       rcx,rbx
       call      qword ptr [7FF7DF6764F0]
       test      eax,eax
       jne       near ptr M02_L12
       jmp       near ptr M02_L31
M02_L64:
       mov       [rbp-1D0],r9
       mov       [rbp-1C8],r8d
       lea       rdx,[rbp-1D0]
       lea       r9,[rbp-168]
       lea       r8,[rbp-170]
       mov       r11,7FF7DED60B70
       call      qword ptr [r11]
       mov       edx,eax
       jmp       near ptr M02_L10
M02_L65:
       mov       dword ptr [rbp-168],1
       xor       r13d,r13d
       mov       edx,2
       jmp       near ptr M02_L11
M02_L66:
       call      qword ptr [7FF7DF5673A8]
       jmp       near ptr M02_L12
M02_L67:
       lea       r9,[rbp-168]
       mov       rcx,rbx
       mov       r8d,r13d
       call      qword ptr [7FF7DF567450]
       mov       r13d,eax
       jmp       near ptr M02_L12
M02_L68:
       mov       rcx,r15
       mov       edx,[rcx+68]
       sub       edx,[rcx+10]
       jo        near ptr M02_L89
       cmp       edx,1
       jle       short M02_L69
       mov       edx,[rcx+10]
       add       edx,1
       jo        near ptr M02_L89
       mov       [rcx+10],edx
       mov       rdx,[rcx+8]
       add       rdx,1
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
       jmp       short M02_L71
M02_L69:
       cmp       byte ptr [rcx+14],0
       je        short M02_L70
       mov       edx,1
       call      qword ptr [7FF7DF5673A8]
       jmp       short M02_L71
M02_L70:
       mov       edx,[rcx+68]
       sub       edx,[rcx+10]
       jo        near ptr M02_L89
       cmp       edx,1
       jne       near ptr M02_L82
       mov       edx,[rcx+10]
       add       edx,1
       jo        near ptr M02_L89
       mov       [rcx+10],edx
       mov       rdx,[rcx+8]
       add       rdx,1
       jo        near ptr M02_L89
       mov       [rcx+8],rdx
       mov       byte ptr [rcx+15],0
M02_L71:
       xor       eax,eax
       jmp       near ptr M02_L27
M02_L72:
       call      qword ptr [7FF7DF5673A8]
       jmp       near ptr M02_L20
M02_L73:
       lea       r8,[rbp-178]
       lea       r9,[rbp-180]
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FF7DF567A08]
       test      eax,eax
       jne       near ptr M02_L20
       jmp       near ptr M02_L31
M02_L74:
       mov       eax,1
       jmp       near ptr M02_L21
M02_L75:
       mov       rcx,[rbp-208]
       mov       rdx,r10
       mov       r8d,r11d
       call      qword ptr [7FF7DF56F9D8]
       add       eax,[rbp-19C]
       mov       [rbp-19C],eax
       mov       r10,[rbp-1D8]
       mov       r11d,[rbp-184]
       jns       near ptr M02_L24
       jmp       near ptr M02_L85
M02_L76:
       mov       rax,23FEADE0008
       mov       [rbp-210],rax
       mov       rax,[rbp-210]
       jmp       near ptr M02_L26
M02_L77:
       mov       eax,[rbp-19C]
       mov       [rsp+20],eax
       mov       [rsp+28],ecx
       mov       [rsp+30],r8d
       mov       dword ptr [rsp+38],1
       mov       rcx,[rbp-208]
       mov       r8d,r11d
       call      qword ptr [7FF7DF56CD38]
       jmp       near ptr M02_L25
M02_L78:
       mov       [rbp-210],rax
       call      qword ptr [7FF7DF5673A8]
       mov       rax,[rbp-210]
       jmp       near ptr M02_L27
M02_L79:
       mov       rcx,rbx
       mov       edx,r12d
       call      qword ptr [7FF7DF5679C0]
       jmp       near ptr M02_L27
M02_L80:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,rbx
       mov       r11,7FF7DED60B68
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M02_L28
M02_L81:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L82:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M02_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M02_L84:
       call      qword ptr [7FF7DEF87198]
       int       3
M02_L85:
       call      qword ptr [7FF7DF56F9F0]
       int       3
M02_L86:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7DF56CD20]
       int       3
M02_L87:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7DF3C73D8]
       int       3
M02_L88:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1750
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DF5673C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L90:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L91:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [r15]
       mov       rsi,rax
       jmp       near ptr M02_L14
M02_L92:
       mov       rax,[rbp-1E8]
       add       rsp,228
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L93:
       mov       rcx,1FF56001EF8
       mov       rsi,[rcx]
       mov       rcx,1FF56001EC8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L94:
       sub       rsp,48
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        short M02_L95
       mov       rdx,[rbp-220]
       call      qword ptr [7FF7DF6764D8]
M02_L95:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8FC
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FF7DED5A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,86C
       mov       rdx,7FF7DF46D900
       call      qword ptr [7FF7DF037798]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF7DEE17828]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7DF45CC18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 4468
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
       call      00007FF83EAA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23FEADE0008
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
       call      qword ptr [7FF7DF56DA40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MessagePackExtensionsBenchmark.ToMessagePackBytes()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,168
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+160],xmm4
       vmovdqa   xmmword ptr [rsp+rax+170],xmm4
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+160],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L08
M00_L02:
       mov       rcx,17F06801EB0
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L09
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L10
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+98],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+58]
       vmovdqu   ymmword ptr [rsp+110],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+130],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+150],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+108]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+128]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+148]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       mov       byte ptr [rsp+0A8],0
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rdx
       mov       [rsp+0C0],rax
       mov       [rsp+0C8],eax
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r8d
       mov       [rsp+0E0],rdi
       mov       [rsp+0E8],eax
       mov       [rsp+0EC],r8d
       mov       [rsp+100],rax
       lea       rdx,[rsp+0A8]
       mov       r8,rsi
       mov       rcx,7FF7DF4DD6D8
       call      qword ptr [7FF7DF456C10]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+0B8],0
       je        near ptr M00_L14
       mov       rdx,[rsp+0E0]
       mov       ecx,[rsp+0E8]
       mov       eax,[rsp+0EC]
       mov       esi,[rsp+0C8]
       cmp       esi,eax
       ja        near ptr M00_L11
       test      rdx,rdx
       je        near ptr M00_L12
       mov       eax,ecx
       mov       r8d,esi
       add       rax,r8
       mov       r8d,[rdx+8]
       cmp       rax,r8
       ja        near ptr M00_L13
       lea       rdi,[rdx+rcx+10]
M00_L04:
       test      esi,esi
       je        near ptr M00_L15
       mov       edx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r8d,esi
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,168
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      qword ptr [7FF7DF3BF120]
       mov       ecx,1A5
       mov       rdx,7FF7DF201BB0
       call      qword ptr [7FF7DF037798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7DF0E4F28
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DEE17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DF201BB0
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DEE17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DF56EA60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DF56D230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       ecx,9
       call      qword ptr [7FF7DF456C58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,9
       call      qword ptr [7FF7DF456C58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,17F06801EE0
       mov       rbp,[rcx]
       mov       rcx,17F06801EB0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DF195B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       ecx,28
       call      qword ptr [7FF7DF0378D0]
       int       3
M00_L12:
       or        ecx,esi
       jne       short M00_L13
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L13:
       call      qword ptr [7FF7DEF87198]
       int       3
M00_L14:
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       cmp       qword ptr [rsp+50],0
       jne       short M00_L17
       jmp       short M00_L16
M00_L15:
       mov       rbp,1BF9B5F62A0
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,15F4
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DF0377B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       mov       ebp,[rsp+0C8]
       test      ebp,ebp
       jle       short M00_L18
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF7DF56EA78]
       mov       ecx,ebp
       add       rcx,[rsp+0C0]
       jo        near ptr M00_L19
       mov       [rsp+0C0],rcx
       xor       ecx,ecx
       mov       [rsp+0C8],ecx
       mov       rcx,[rsp+0B0]
       mov       edx,ebp
       mov       r11,7FF7DED60A68
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
M00_L18:
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rdx,[rsp+50]
       cmp       [rdx],dl
       lea       rcx,[rsp+30]
       call      qword ptr [7FF7DF45C270]
       lea       rcx,[rsp+30]
       call      qword ptr [7FF7DF3BF030]
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      qword ptr [7FF7DF45C2B8]
       jmp       near ptr M00_L05
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1234
```
```assembly
; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,138
       lea       rbp,[rsp+170]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,r8
       mov       rsi,r9
       test      rsi,rsi
       je        near ptr M01_L64
M01_L01:
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rsi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L65
M01_L02:
       cmp       dword ptr [rsi+20],0
       jne       near ptr M01_L19
M01_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M01_L17
M01_L04:
       mov       rax,[rcx+18]
       mov       r14,[rax+18]
       test      r14,r14
       je        near ptr M01_L18
M01_L05:
       mov       rdx,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF7DF45C138]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.GeneratedMessagePackResolver+DotNetTips+Spargine+Extensions+BenchmarkTests+TestMessagePackModelFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L62
       test      rbx,rbx
       je        near ptr M01_L28
       mov       r14,[rsi+8]
       mov       rdx,[rbp+18]
       lea       rdi,[rdx+8]
       mov       r15,rdi
       cmp       dword ptr [r15+28],5
       jl        near ptr M01_L29
M01_L06:
       mov       rcx,[r15+20]
       mov       eax,[r15+28]
       test      eax,eax
       jle       near ptr M01_L30
       mov       byte ptr [rcx],92
       mov       rcx,rdi
       mov       eax,[rcx+18]
       add       eax,1
       jo        near ptr M01_L60
       mov       [rcx+18],eax
       lea       rax,[rcx+20]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L57
       mov       rax,[rax]
       inc       rax
       dec       r8d
       mov       [rcx+20],rax
       mov       [rcx+28],r8d
       mov       r15d,[rbx+10]
       mov       r13,rdi
       cmp       dword ptr [r13+28],5
       jl        near ptr M01_L31
M01_L07:
       mov       r12,[r13+20]
       mov       r13d,[r13+28]
       test      r15d,r15d
       jl        near ptr M01_L36
       cmp       r15d,0FF
       ja        near ptr M01_L33
       cmp       r15d,7F
       ja        near ptr M01_L32
       mov       dword ptr [rbp-0E0],1
       cmp       r13d,[rbp-0E0]
       jl        near ptr M01_L34
       test      r13d,r13d
       je        near ptr M01_L61
       mov       [r12],r15b
       mov       eax,1
M01_L08:
       test      eax,eax
       je        near ptr M01_L40
       mov       rcx,rdi
       mov       eax,[rbp-0E0]
       mov       r8d,eax
       add       r8d,[rcx+18]
       jo        near ptr M01_L60
       mov       [rcx+18],r8d
       lea       r8,[rcx+20]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       ja        near ptr M01_L57
       mov       r9d,eax
       add       r9,[r8]
       sub       r10d,eax
       mov       [rcx+20],r9
       mov       [rcx+28],r10d
       mov       rdx,r14
       mov       rcx,7FF7DF533BD0
       call      qword ptr [7FF7DF45C138]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rbx,[rbx+8]
       mov       rcx,offset MT_MessagePack.Formatters.NullableStringFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L59
       test      rbx,rbx
       je        near ptr M01_L41
       mov       esi,[rbx+8]
       mov       rcx,17F1C800490
       mov       r14,[rcx]
       mov       r15,r14
       mov       r13d,esi
       inc       r13
       mov       rcx,[r15+10]
       mov       rax,offset MT_System.Text.EncoderReplacementFallback
       cmp       [rcx],rax
       jne       near ptr M01_L42
       mov       rcx,[rcx+8]
       mov       r12d,[rcx+8]
       cmp       r12d,1
       jg        near ptr M01_L43
M01_L09:
       lea       r13,[r13+r13*2]
       cmp       r13,7FFFFFFF
       jg        near ptr M01_L44
       mov       r15d,r13d
       add       r15d,5
       jo        near ptr M01_L60
       mov       r13,rdi
       cmp       [r13+28],r15d
       jl        near ptr M01_L45
M01_L10:
       mov       rcx,[r13+30]
       test      rcx,rcx
       je        near ptr M01_L46
       mov       eax,[r13+38]
       add       eax,[r13+18]
       jo        near ptr M01_L60
       cmp       eax,[rcx+8]
       jae       near ptr M01_L61
       lea       r12,[rcx+rax+10]
M01_L11:
       cmp       esi,1F
       jg        near ptr M01_L47
       mov       r13d,1
M01_L12:
       mov       [rbp-0E8],r12
       lea       rsi,[rbx+0C]
       mov       ebx,[rbx+8]
       mov       eax,r13d
       add       rax,r12
       jb        near ptr M01_L60
       sub       r15d,r13d
       jo        near ptr M01_L60
       test      r15d,r15d
       jl        near ptr M01_L57
       mov       [rbp-0F0],rsi
       mov       [rbp-0F8],rax
       mov       [rbp-120],rax
       lea       rcx,[rbp-100]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-108]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8,rax
       mov       r9d,r15d
       call      qword ptr [7FF7DEE1FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-100]
       sub       rcx,rsi
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       eax,[rbp-108]
       mov       r9,[rbp-120]
       sub       eax,r9d
       cmp       ecx,ebx
       jne       near ptr M01_L49
       mov       ebx,eax
M01_L13:
       xor       r8d,r8d
       mov       [rbp-0F0],r8
       mov       [rbp-0F8],r8
       cmp       ebx,1F
       jg        near ptr M01_L51
       cmp       r13d,1
       jne       near ptr M01_L50
M01_L14:
       mov       r8d,ebx
       or        r8d,0A0
       cmp       r8d,0FF
       ja        near ptr M01_L60
       mov       [r12],r8b
       add       ebx,1
       jo        near ptr M01_L60
       mov       r8d,ebx
       add       r8d,[rdi+18]
       jo        near ptr M01_L60
       mov       [rdi+18],r8d
       lea       r8,[rdi+20]
       mov       ecx,[r8+8]
       cmp       ebx,ecx
       ja        near ptr M01_L57
       mov       edx,ebx
       add       rdx,[r8]
       sub       ecx,ebx
       mov       [rdi+20],rdx
       mov       [rdi+28],ecx
M01_L15:
       xor       ecx,ecx
       mov       [rbp-0E8],rcx
M01_L16:
       xor       ecx,ecx
       mov       [rbp-0E8],rcx
       jmp       near ptr M01_L63
M01_L17:
       mov       rdx,7FF7DF4E0A20
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L04
M01_L18:
       mov       rdx,7FF7DF4E0A40
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FF7DF4E0C88
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L21:
       mov       rcx,rax
       call      qword ptr [7FF7DEE15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L03
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DF45C1F8]
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FF7DF45C228]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FF7DF4E0A20
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L23:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L25
       jmp       short M01_L26
M01_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L25:
       mov       rdx,7FF7DF4E0A40
       call      qword ptr [7FF7DF037B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L26:
       mov       rdx,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF7DF45C138]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rbx
       mov       r9,rsi
       call      qword ptr [r14]
       mov       ebx,[rbp-0A0]
       test      ebx,ebx
       jle       short M01_L27
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FF7DF56EA78]
       mov       ecx,ebx
       add       rcx,[rbp-0A8]
       jo        short M01_L24
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,ebx
       mov       r11,7FF7DED60A80
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L27:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FF7DF45C270]
       mov       r9d,[rsi+24]
       mov       r8d,[rsi+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF7DF45C2A0]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L63
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FF7DF56EAF0]
       jmp       near ptr M01_L63
M01_L28:
       mov       rcx,[rbp+18]
       call      qword ptr [7FF7DF45E808]
       jmp       near ptr M01_L63
M01_L29:
       mov       rcx,r15
       mov       edx,5
       call      qword ptr [7FF7DF45E9A0]
       jmp       near ptr M01_L06
M01_L30:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,5A9
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DF45E9E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L31:
       mov       rcx,r13
       mov       edx,5
       call      qword ptr [7FF7DF45E9A0]
       jmp       near ptr M01_L07
M01_L32:
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       movzx     edx,r15b
       lea       r8,[rbp-0E0]
       call      qword ptr [7FF7DF45EAA8]
       jmp       near ptr M01_L08
M01_L33:
       cmp       r15d,0FFFF
       jbe       short M01_L35
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       lea       r8,[rbp-0E0]
       mov       edx,r15d
       call      qword ptr [7FF7DF45EAD8]
       jmp       near ptr M01_L08
M01_L34:
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L35:
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       movzx     edx,r15w
       lea       r8,[rbp-0E0]
       call      qword ptr [7FF7DF45EAC0]
       jmp       near ptr M01_L08
M01_L36:
       cmp       r15d,0FFFFFF80
       jl        short M01_L37
       cmp       r15d,0FFFFFFE0
       jge       short M01_L38
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       movsx     rdx,r15b
       lea       r8,[rbp-0E0]
       call      qword ptr [7FF7DF45EA48]
       jmp       near ptr M01_L08
M01_L37:
       cmp       r15d,0FFFF8000
       jge       short M01_L39
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       lea       r8,[rbp-0E0]
       mov       edx,r15d
       call      qword ptr [7FF7DF45EA78]
       jmp       near ptr M01_L08
M01_L38:
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       movsx     rdx,r15b
       lea       r8,[rbp-0E0]
       call      qword ptr [7FF7DF45EA30]
       jmp       near ptr M01_L08
M01_L39:
       mov       [rbp-118],r12
       mov       [rbp-110],r13d
       lea       rcx,[rbp-118]
       movsx     rdx,r15w
       lea       r8,[rbp-0E0]
       call      qword ptr [7FF7DF45EA60]
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5A9
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7DF45E9E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L41:
       mov       rcx,[rbp+18]
       call      qword ptr [7FF7DF45E808]
       jmp       near ptr M01_L16
M01_L42:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r12d,eax
       cmp       r12d,1
       jle       near ptr M01_L09
M01_L43:
       mov       rcx,[r15+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       movsxd    rcx,eax
       imul      r13,rcx
       jmp       near ptr M01_L09
M01_L44:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13C80
       mov       rdx,7FF7DED54000
       call      qword ptr [7FF7DF037798]
       mov       rsi,rax
       call      qword ptr [7FF7DF56D8A8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DF03DAE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L45:
       mov       rcx,r13
       mov       edx,r15d
       call      qword ptr [7FF7DF45E9A0]
       jmp       near ptr M01_L10
M01_L46:
       lea       rcx,[r13+20]
       call      qword ptr [7FF7DF245098]; System.Span`1[[System.Byte, System.Private.CoreLib]].GetPinnableReference()
       mov       r12,rax
       jmp       near ptr M01_L11
M01_L47:
       cmp       esi,0FF
       jg        short M01_L48
       mov       rdx,[rbp+18]
       cmp       byte ptr [rdx],0
       jne       short M01_L48
       mov       r13d,2
       jmp       near ptr M01_L12
M01_L48:
       mov       r13d,5
       mov       ecx,3
       cmp       esi,0FFFF
       cmovle    r13d,ecx
       jmp       near ptr M01_L12
M01_L49:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,ebx
       call      qword ptr [7FF7DF56D878]
       mov       ebx,eax
       jmp       near ptr M01_L13
M01_L50:
       mov       edx,r13d
       add       rdx,r12
       jb        near ptr M01_L60
       mov       rcx,r12
       add       rcx,1
       jb        near ptr M01_L60
       movsxd    r8,ebx
       test      r8,r8
       jl        near ptr M01_L60
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L51:
       cmp       ebx,0FF
       jg        near ptr M01_L53
       mov       rdx,[rbp+18]
       cmp       byte ptr [rdx],0
       jne       near ptr M01_L53
       cmp       r13d,2
       je        short M01_L52
       mov       r8d,r13d
       add       r8,r12
       jb        near ptr M01_L60
       mov       rax,r8
       mov       rcx,r12
       add       rcx,2
       jb        near ptr M01_L60
       movsxd    r8,ebx
       test      r8,r8
       jl        near ptr M01_L60
       mov       rdx,rax
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L52:
       mov       byte ptr [r12],0D9
       mov       [r12+1],bl
       mov       r8,rdi
       mov       ecx,ebx
       add       ecx,2
       jo        near ptr M01_L60
       mov       eax,ecx
       add       eax,[r8+18]
       jo        near ptr M01_L60
       mov       [r8+18],eax
       lea       rax,[r8+20]
       cmp       ecx,[rax+8]
       ja        near ptr M01_L57
       mov       r10d,ecx
       add       r10,[rax]
       mov       eax,[rax+8]
       sub       eax,ecx
       mov       [r8+20],r10
       mov       [r8+28],eax
       jmp       near ptr M01_L15
M01_L53:
       cmp       ebx,0FFFF
       jg        near ptr M01_L55
       cmp       r13d,3
       je        short M01_L54
       mov       r8d,r13d
       add       r8,r12
       jb        near ptr M01_L60
       mov       rax,r8
       mov       rcx,r12
       add       rcx,3
       jb        near ptr M01_L60
       movsxd    r8,ebx
       test      r8,r8
       jl        near ptr M01_L60
       mov       rdx,rax
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L54:
       mov       byte ptr [r12],0DA
       cmp       ebx,0FFFF
       ja        near ptr M01_L60
       mov       r8d,ebx
       add       r12,1
       jb        near ptr M01_L60
       mov       ecx,r8d
       sar       ecx,8
       mov       [r12],cl
       mov       [r12+1],r8b
       mov       r8,rdi
       mov       ecx,ebx
       add       ecx,3
       jo        near ptr M01_L60
       mov       eax,ecx
       add       eax,[r8+18]
       jo        near ptr M01_L60
       mov       [r8+18],eax
       lea       rax,[r8+20]
       cmp       ecx,[rax+8]
       ja        near ptr M01_L57
       mov       r10d,ecx
       add       r10,[rax]
       mov       eax,[rax+8]
       sub       eax,ecx
       mov       [r8+20],r10
       mov       [r8+28],eax
       jmp       near ptr M01_L15
M01_L55:
       cmp       r13d,5
       je        short M01_L56
       mov       r8d,r13d
       add       r8,r12
       jb        near ptr M01_L60
       mov       rax,r8
       mov       rcx,r12
       add       rcx,5
       jb        near ptr M01_L60
       movsxd    r8,ebx
       test      r8,r8
       jl        short M01_L60
       mov       rdx,rax
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L56:
       mov       byte ptr [r12],0DB
       test      ebx,ebx
       jl        short M01_L60
       mov       ecx,ebx
       mov       rdx,r12
       add       rdx,1
       jb        short M01_L60
       call      qword ptr [7FF7DF45EC40]
       mov       rcx,rdi
       mov       eax,ebx
       add       eax,5
       jo        short M01_L60
       mov       edx,eax
       add       edx,[rcx+18]
       jo        short M01_L60
       mov       [rcx+18],edx
       lea       rdx,[rcx+20]
       cmp       eax,[rdx+8]
       jbe       short M01_L58
M01_L57:
       call      qword ptr [7FF7DEF87198]
       int       3
M01_L58:
       mov       r8d,eax
       add       r8,[rdx]
       mov       edx,[rdx+8]
       sub       edx,eax
       mov       [rcx+20],r8
       mov       [rcx+28],edx
       jmp       near ptr M01_L15
M01_L59:
       mov       rcx,rax
       mov       r9,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       mov       r11,7FF7DED60A88
       call      qword ptr [r11]
       jmp       short M01_L63
M01_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L62:
       mov       rcx,rax
       mov       r11,r14
       mov       rdx,[rbp+18]
       mov       r8,rbx
       mov       r9,rsi
       call      qword ptr [r14]
       nop
M01_L63:
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,138
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L64:
       call      qword ptr [7FF7DF456C70]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L65:
       mov       cx,[rsi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FF7DF03F570]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L02
       sub       rsp,48
       cmp       qword ptr [rbp-128],0
       je        short M01_L66
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FF7DF56EAF0]
M01_L66:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,842
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FF7DED5A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,86C
       mov       rdx,7FF7DF467118
       call      qword ptr [7FF7DF037798]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF7DEE17828]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7DF45C2D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,48
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,48
       ret
; Total bytes of code 3076
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L01
       test      r8b,18
       je        short M02_L03
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       vzeroupper
       ret
M02_L01:
       cmp       r8,40
       ja        short M02_L05
M02_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M02_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L08
M02_L03:
       test      r8b,4
       je        short M02_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L04:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L05:
       cmp       r8,800
       ja        near ptr M02_L10
       cmp       r8,100
       jb        short M02_L06
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
M02_L06:
       mov       r9,r8
       shr       r9,6
M02_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L02
M02_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M02_L00
M02_L09:
       cmp       rcx,rdx
       jne       short M02_L10
       cmp       [rdx],dl
       jmp       near ptr M02_L00
M02_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF7DEE166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
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
       call      00007FF83EAA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DEE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BF9B5F0008
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
       call      qword ptr [7FF7DF56DC80]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,240
       add       rax,0FFFFFFFFFFFFFFF8
       mov       edx,ecx
       and       edx,0FFFFFF
       mov       r8d,edx
       mov       r10d,ecx
       sar       r10d,18
       jne       short M04_L01
       cmp       [rax],edx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       ret
M04_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M04_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],r8d
       jle       short M04_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       jmp       qword ptr [7FF7DF034120]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```

