## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ClonePersonRecordRecord()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,2E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFD60
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+2E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+300],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L10
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L10
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L11
M00_L02:
       mov       rcx,21E75C00AC8
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L12
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L13
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+210],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+1D0]
       vmovdqu   ymmword ptr [rsp+288],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1F0]
       vmovdqu   ymmword ptr [rsp+2A8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+210]
       vmovdqu   xmmword ptr [rsp+2C8],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+280]
       vmovdqu   ymmword ptr [rsp+220],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+2A0]
       vmovdqu   ymmword ptr [rsp+240],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+2C0]
       vmovdqu   ymmword ptr [rsp+260],ymm0
       mov       byte ptr [rsp+220],0
       xor       eax,eax
       mov       [rsp+228],rax
       mov       [rsp+230],rdx
       mov       [rsp+238],rax
       mov       [rsp+240],eax
       mov       [rsp+248],rcx
       mov       [rsp+250],r8d
       mov       [rsp+258],rdi
       mov       [rsp+260],eax
       mov       [rsp+264],r8d
       mov       [rsp+278],rax
       lea       rdx,[rsp+220]
       mov       r8,rsi
       mov       rcx,7FFC0362C0E8
       call      qword ptr [7FFC0353CCC0]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+230],0
       je        near ptr M00_L16
       mov       rdx,[rsp+258]
       mov       ecx,[rsp+260]
       mov       eax,[rsp+264]
       mov       esi,[rsp+240]
       cmp       esi,eax
       ja        near ptr M00_L14
       test      rdx,rdx
       je        near ptr M00_L15
       mov       eax,ecx
       mov       r8d,esi
       add       rax,r8
       mov       r8d,[rdx+8]
       cmp       rax,r8
       ja        near ptr M00_L23
       lea       rdi,[rdx+rcx+10]
M00_L04:
       test      esi,esi
       je        near ptr M00_L17
       mov       edx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r8d,esi
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       test      rbp,rbp
       je        near ptr M00_L21
       mov       esi,[rbp+8]
M00_L06:
       xor       edi,edi
       xor       r14d,r14d
       test      rbp,rbp
       je        short M00_L08
       mov       rdx,[rbp]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L22
       lea       rdi,[rbp+10]
       mov       r14d,[rbp+8]
M00_L07:
       cmp       esi,r14d
       ja        near ptr M00_L23
       mov       r14d,esi
M00_L08:
       mov       edx,esi
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+38]
       vmovdqu   ymmword ptr [rsp+130],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+58]
       vmovdqu   ymmword ptr [rsp+150],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+170],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+190],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+128]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+148]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+168]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+188]
       vmovdqu   ymmword ptr [rsp+108],ymm0
       xor       r8d,r8d
       mov       [rsp+0A8],r8d
       mov       [rsp+0B0],rdx
       mov       [rsp+0B8],r8
       mov       [rsp+0C0],r8d
       mov       byte ptr [rsp+0C4],0
       mov       [rsp+0C5],cl
       mov       [rsp+100],rbp
       mov       [rsp+108],r8d
       mov       [rsp+10C],esi
       mov       [rsp+110],rdi
       mov       [rsp+118],r14d
       mov       [rsp+120],r8
       lea       rdx,[rsp+0A8]
       mov       rcx,7FFC038B8F68
       call      qword ptr [7FFC037ED1B8]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,2E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L09:
       call      qword ptr [7FFC032FE220]
       mov       ecx,3
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03025770
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC0344FFD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03534000]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,0E
       call      qword ptr [7FFC0353CD08]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,0E
       call      qword ptr [7FFC0353CD08]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,21E75C00AF8
       mov       rbp,[rcx]
       mov       rcx,21E75C00AC8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC030D71E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       ecx,28
       call      qword ptr [7FFC02CCF348]
       int       3
M00_L15:
       or        ecx,esi
       jne       near ptr M00_L23
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L16:
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       cmp       qword ptr [rsp+1C8],0
       jne       short M00_L19
       jmp       short M00_L18
M00_L17:
       mov       rbp,25EF4CA6EF8
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F1C
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCF228]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       ebp,[rsp+240]
       test      ebp,ebp
       jle       short M00_L20
       lea       rcx,[rsp+228]
       call      qword ptr [7FFC03A957A0]
       mov       ecx,ebp
       add       rcx,[rsp+238]
       jo        near ptr M00_L24
       mov       [rsp+238],rcx
       xor       ecx,ecx
       mov       [rsp+240],ecx
       mov       rcx,[rsp+228]
       mov       edx,ebp
       mov       r11,7FFC02C11828
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+248],xmm0
M00_L20:
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       mov       rdx,[rsp+1C8]
       cmp       [rdx],dl
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FFC0353E2F8]
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FFC037ED128]
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC0353E340]
       jmp       near ptr M00_L05
M00_L21:
       xor       ebp,ebp
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L22:
       lea       rdx,[rsp+28]
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+28]
       mov       r14d,[rsp+30]
       jmp       near ptr M00_L07
M00_L23:
       call      qword ptr [7FFC02EFF1B0]
       int       3
M00_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1663
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rbx,rbx
       je        near ptr M01_L64
M01_L00:
       mov       rdi,rbx
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L65
M01_L01:
       cmp       dword ptr [rdi+20],0
       jne       near ptr M01_L27
M01_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M01_L22
M01_L03:
       mov       rax,[rcx+18]
       mov       r15,[rax+18]
       test      r15,r15
       je        near ptr M01_L23
M01_L04:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L62
       test      rsi,rsi
       je        near ptr M01_L36
       mov       rcx,rsi
       call      qword ptr [7FFC02EF61C0]; System.Object.GetType()
       mov       r15,rax
       mov       rbx,r15
       mov       rcx,25EF4CA27E0
       cmp       rbx,rcx
       je        near ptr M01_L37
       mov       rcx,21E75C00D60
       mov       r14,[rcx]
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L08
       mov       r13,[r14+18]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r11,7FFC02C11860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rdx,[r14+8]
       mov       ecx,r12d
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L50
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r14,[r14+10]
       xor       eax,eax
       mov       [rbp-0E4],eax
       dec       edx
       mov       r10d,[r14+8]
       mov       [rbp-0E8],r10d
       cmp       r10d,edx
       jbe       short M01_L08
M01_L05:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r14+rdx*8+10]
       mov       [rbp-118],r9
       cmp       [r9+8],r12d
       jne       short M01_L06
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rbx
       mov       r11,7FFC02C11868
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-118]
       jne       short M01_L07
M01_L06:
       mov       edx,[r9+0C]
       mov       eax,[rbp-0E4]
       inc       eax
       mov       r10d,[rbp-0E8]
       cmp       r10d,eax
       jb        near ptr M01_L24
       cmp       r10d,edx
       mov       [rbp-0E4],eax
       jbe       short M01_L08
       jmp       short M01_L05
M01_L07:
       add       r9,10
       test      r9,r9
       jne       short M01_L12
M01_L08:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L39
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L09:
       test      eax,eax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L41
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L42
M01_L11:
       test      rax,rax
       je        short M01_L15
M01_L12:
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L38
       xor       eax,eax
M01_L13:
       test      rax,rax
       jne       short M01_L15
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L43
M01_L14:
       test      rax,rax
       je        near ptr M01_L44
M01_L15:
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L45
       mov       rcx,21E75C00D20
       mov       rcx,[rcx]
       mov       r13,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L25
M01_L16:
       mov       ecx,[r13+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L49
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L50
       mov       ecx,edx
       mov       rcx,[r13+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L47
M01_L17:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L46
       mov       r13,[rcx+18]
M01_L18:
       mov       rdx,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L48
       mov       rcx,21E75C00D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       edx,[r14+8]
       mov       ecx,edx
       sub       ecx,1
       jo        near ptr M01_L49
       and       ecx,eax
       cmp       ecx,edx
       jae       near ptr M01_L50
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       test      rdx,rdx
       je        near ptr M01_L52
M01_L20:
       cmp       [rdx+10],rbx
       jne       near ptr M01_L51
       mov       r14,[rdx+18]
M01_L21:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r8,[rbp+18]
       mov       r9,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M01_L63
M01_L22:
       mov       rdx,7FFC03630900
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L03
M01_L23:
       mov       rdx,7FFC03630920
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFC02CCF480]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFC02EF7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L16
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFC02EF7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L19
M01_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFC03630B68
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L29:
       mov       rcx,rax
       call      qword ptr [7FFC02CC5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L02
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0353E280]
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FFC0353E2B0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rdx,7FFC03630900
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L33
       jmp       short M01_L34
M01_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L33:
       mov       rdx,7FFC03630920
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L34:
       mov       rdx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r14]
       mov       esi,[rbp-0A0]
       test      esi,esi
       jle       short M01_L35
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFC03A957A0]
       mov       ecx,esi
       add       rcx,[rbp-0A8]
       jo        short M01_L32
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,esi
       mov       r11,7FFC02C11848
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L35:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0353E2F8]
       mov       r9d,[rbx+24]
       mov       r8d,[rbx+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC0353E328]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L63
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC03A95B30]
       jmp       near ptr M01_L63
M01_L36:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC0353E898]
       jmp       near ptr M01_L63
M01_L37:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FFC03A95B48]
       jmp       near ptr M01_L63
M01_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L13
M01_L39:
       mov       rcx,r15
       mov       rdx,25EF4CA6D90
       call      qword ptr [7FFC02C0A608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L09
M01_L40:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L10
M01_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L11
M01_L43:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L14
M01_L44:
       mov       rcx,21E75C00D58
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFC03641790]
       jmp       near ptr M01_L63
M01_L45:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1FB
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC030D71E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L17
M01_L47:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21E75C00D28
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FFC02F31C80]; Precode of System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r13,rax
       mov       rcx,25EF4CB3B98
       mov       rdx,25EF4CB3BC0
       call      qword ptr [7FFC0353E910]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFC0353EB38]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo)
       mov       r13,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-120],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-120]
       mov       [rsp+20],r12
       mov       rdx,r13
       mov       rcx,7FFC036495C8
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0353F240]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0353E970]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r13,rax
       mov       rcx,21E75C00D20
       mov       rcx,[rcx]
       mov       rdx,rbx
       mov       r8,r13
       call      qword ptr [7FFC0353E988]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       near ptr M01_L18
M01_L48:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC0353E400]
       int       3
M01_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L51:
       mov       rdx,[rdx+8]
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L52:
       mov       rdx,21E75C00D50
       mov       rcx,[rdx]
       mov       [rbp-0F0],rcx
       mov       byte ptr [rbp-0E0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CC5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,21E75C00D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC0317CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ecx,[r14+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L57
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L58
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M01_L55
M01_L53:
       cmp       [rcx+10],rbx
       je        short M01_L54
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L53
       jmp       short M01_L55
M01_L54:
       mov       r14,[rcx+18]
       mov       ecx,1
       jmp       short M01_L56
M01_L55:
       xor       r14d,r14d
       xor       ecx,ecx
M01_L56:
       test      ecx,ecx
       jne       near ptr M01_L61
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,25EF4CB3AF8
       call      qword ptr [7FFC02C0A5B8]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       r14,rax
       mov       rcx,25EF4CA27E0
       mov       rdx,25EF4CB3B20
       call      qword ptr [7FFC0353E910]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-0F8],rax
       mov       rdx,25EF4CB3B48
       mov       [rbp-138],rdx
       mov       rcx,rdx
       call      qword ptr [7FFC02C0A5B0]; Precode of System.RuntimeType.MakeByRefType()
       mov       rcx,rax
       mov       rdx,25EF4CA7EC8
       call      qword ptr [7FFC0353E910]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-100],rax
       mov       rcx,25EF4CA27E0
       mov       rdx,25EF4CA1640
       call      qword ptr [7FFC0353E910]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-108],rax
       mov       r8,25EF4CB3278
       mov       [rbp-140],r8
       mov       rcx,r8
       mov       rdx,25EF4CAA148
       call      qword ptr [7FFC0353E910]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-110],rax
       mov       rcx,r12
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC02C0A5B0]; Precode of System.RuntimeType.MakeByRefType()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-140]
       mov       [r12+20],rbx
       mov       rcx,r14
       mov       r8,r12
       mov       rdx,25EF4CB3B70
       call      qword ptr [7FFC0353D428]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(System.Type, System.String, System.Type[])
       mov       rbx,rax
       mov       rcx,[rbp-0F8]
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC0366CC00]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       mov       r14,rax
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M01_L59
       mov       rcx,[rbp-108]
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFC0366CC00]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       jmp       short M01_L60
M01_L57:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L59:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       call      qword ptr [7FFC0353E940]
M01_L60:
       mov       r12,[rbp-110]
       mov       [rsp+20],r12
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,[rbp-100]
       mov       r9,rax
       call      qword ptr [7FFC0353E958]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression)
       mov       rbx,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],r14
       mov       rdx,rbx
       mov       rcx,7FFC03706100
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0353F240]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0353E970]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r14,rax
       mov       rcx,21E75C00D50
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFC0353E988]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       nop
M01_L61:
       cmp       byte ptr [rbp-0E0],0
       je        near ptr M01_L21
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CC6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M01_L21
M01_L62:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r15]
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
       call      qword ptr [7FFC0353CD20]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rbx,rax
       jmp       near ptr M01_L00
M01_L65:
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC030D4C90]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L01
       sub       rsp,28
       cmp       qword ptr [rbp-128],0
       je        short M01_L66
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC03A95B30]
M01_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-0E0],0
       je        short M01_L67
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CC6820]; System.Threading.Monitor.Exit(System.Object)
M01_L67:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,812
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C0A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02EF5470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC0353E358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,28
       ret
; Total bytes of code 3023
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M02_L02
M02_L00:
       cmp       rcx,rdx
       je        near ptr M02_L13
M02_L01:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CC66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M02_L02:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M02_L00
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L03
       cmp       r8,40
       jbe       short M02_L05
       cmp       r8,800
       ja        short M02_L01
       jmp       near ptr M02_L09
M02_L03:
       test      r8b,18
       je        short M02_L07
       jmp       short M02_L06
M02_L04:
       vzeroupper
       ret
M02_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M02_L12
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L12
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L12
M02_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L04
M02_L07:
       test      r8b,4
       je        short M02_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L04
M02_L08:
       test      r8,r8
       je        short M02_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L04
M02_L09:
       cmp       r8,100
       jb        short M02_L10
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
M02_L10:
       mov       r9,r8
       shr       r9,6
M02_L11:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L11
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L05
M02_L12:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M02_L04
M02_L13:
       cmp       [rdx],dl
       jmp       near ptr M02_L04
; Total bytes of code 333
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
       sub       rsp,138
       lea       rbp,[rsp+170]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M03_L01
       mov       rcx,21E75C00AC8
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L51
M03_L01:
       mov       rsi,rbx
       cmp       dword ptr [rsi+20],0
       jne       near ptr M03_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M03_L13
M03_L02:
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        near ptr M03_L14
M03_L03:
       mov       rdx,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.ArrayFormatter<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rax],rcx
       jne       near ptr M03_L47
       mov       rdi,[rbp+18]
       lea       r14,[rdi+8]
       mov       rcx,r14
       cmp       byte ptr [rcx+15],0
       je        near ptr M03_L26
       mov       rdx,[rcx+60]
       mov       eax,[rcx+68]
       mov       ebx,[rcx+10]
       mov       ecx,ebx
       cmp       ecx,eax
       jae       near ptr M03_L49
       movzx     ecx,byte ptr [rdx+rcx]
       cmp       ecx,0C0
       je        near ptr M03_L27
       mov       rcx,r14
       mov       rdx,[rcx+60]
       mov       ecx,[rcx+68]
       cmp       ebx,ecx
       ja        near ptr M03_L35
       mov       eax,ebx
       add       rdx,rax
       sub       ecx,ebx
       mov       dword ptr [rbp-100],1
       test      ecx,ecx
       je        near ptr M03_L32
       movzx     eax,byte ptr [rdx]
       mov       r8d,eax
       cmp       r8d,90
       jl        near ptr M03_L38
       cmp       r8d,9F
       jg        near ptr M03_L33
       and       eax,0F
       cmp       eax,0FF
       ja        near ptr M03_L48
       mov       ebx,eax
M03_L04:
       xor       edx,edx
M03_L05:
       test      ebx,ebx
       jl        near ptr M03_L48
       mov       ecx,ebx
       mov       [rbp-0F8],ecx
       test      edx,edx
       jne       near ptr M03_L42
       mov       rcx,r14
       movsxd    rdx,dword ptr [rbp-100]
       test      rdx,0FFFFFFFF80000000
       jne       near ptr M03_L39
       mov       eax,[rcx+68]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       jo        near ptr M03_L48
       cmp       eax,edx
       jle       near ptr M03_L39
       add       r8d,edx
       jo        near ptr M03_L48
       mov       [rcx+10],r8d
       add       rdx,[rcx+8]
       jo        near ptr M03_L48
       mov       [rcx+8],rdx
M03_L06:
       cmp       qword ptr [r14],0
       jl        near ptr M03_L43
M03_L07:
       mov       rdx,[r14]
       sub       rdx,[r14+8]
       jo        near ptr M03_L48
       movsxd    rbx,dword ptr [rbp-0F8]
       cmp       rdx,rbx
       jl        near ptr M03_L26
       mov       edx,[rbp-0F8]
       test      edx,edx
       je        near ptr M03_L46
       mov       rdx,[rsi+8]
       mov       rcx,7FFC03707118
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       r14,rax
       mov       rdx,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037ED3C8]; MessagePack.MessagePackSecurity.DepthStep(MessagePack.MessagePackReader ByRef)
       nop
       xor       r15d,r15d
       mov       r13d,[rbx+8]
       cmp       r13d,r15d
       jg        short M03_L09
       jmp       short M03_L11
M03_L08:
       mov       rcx,r14
       mov       r8,rsi
       mov       rdx,rdi
       mov       r11,7FFC02C118A8
       call      qword ptr [r11]
       mov       r8,rax
       movsxd    rdx,r15d
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       r15d,1
       jo        short M03_L10
       cmp       r13d,r15d
       jle       short M03_L11
M03_L09:
       mov       rcx,[rdi+78]
       mov       [rbp-0F0],rcx
       cmp       qword ptr [rbp-0F0],0
       je        short M03_L08
       mov       rcx,[rbp-0F0]
       cmp       dword ptr [rcx+20],0
       je        short M03_L08
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFC03A94348]
       int       3
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L11:
       mov       ecx,[rdi]
       sub       ecx,1
       jo        near ptr M03_L48
       mov       [rdi],ecx
M03_L12:
       mov       [rbp-140],rbx
       jmp       near ptr M03_L50
M03_L13:
       mov       rdx,7FFC038A5D68
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
M03_L14:
       mov       rdx,7FFC038A5D88
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M03_L03
M03_L15:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0353E280]
       mov       rdx,[rbp-48]
       mov       [rbp-148],rdx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp-148]
       call      qword ptr [7FFC037ED2D8]
       test      eax,eax
       je        near ptr M03_L20
       mov       rdx,[rbp-148]
       cmp       [rdx],dl
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFC0353E2F8]
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D0]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC037ED2F0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rdx,7FFC038A5D68
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,[rbp+10]
M03_L17:
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rdx,7FFC038A5D88
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M03_L19:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0D0]
       mov       r11,rdi
       mov       r8,rbx
       call      qword ptr [rdi]
       mov       [rbp-140],rax
       jmp       short M03_L25
M03_L20:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        short M03_L21
       jmp       short M03_L22
M03_L21:
       mov       rdx,7FFC038A5D68
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M03_L22:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M03_L23
       jmp       short M03_L24
M03_L23:
       mov       rdx,7FFC038A5D88
       call      qword ptr [7FFC02CCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M03_L24:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC0353E1C0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       mov       r11,rdi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [rdi]
       mov       [rbp-140],rax
       call      M03_L52
       jmp       near ptr M03_L50
M03_L25:
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M03_L50
       mov       rdx,[rbp-148]
       call      qword ptr [7FFC03A95B30]
       jmp       near ptr M03_L50
M03_L26:
       call      qword ptr [7FFC037ED4A0]
       int       3
M03_L27:
       mov       rcx,r14
       mov       eax,[rcx+68]
       sub       eax,ebx
       jo        near ptr M03_L48
       cmp       eax,1
       jle       short M03_L28
       mov       eax,ebx
       add       eax,1
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       jmp       near ptr M03_L31
M03_L28:
       cmp       byte ptr [rcx+14],0
       je        short M03_L29
       mov       edx,1
       call      qword ptr [7FFC037ED578]
       jmp       short M03_L31
M03_L29:
       mov       eax,[rcx+68]
       sub       eax,ebx
       jo        near ptr M03_L48
       cmp       eax,1
       jne       short M03_L30
       mov       eax,ebx
       add       eax,1
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       short M03_L31
M03_L30:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1078
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC037ED590]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L31:
       xor       ebx,ebx
       jmp       near ptr M03_L12
M03_L32:
       xor       ebx,ebx
       mov       edx,2
       jmp       near ptr M03_L05
M03_L33:
       cmp       r8d,0DC
       je        short M03_L34
       cmp       r8d,0DD
       jne       near ptr M03_L38
       mov       dword ptr [rbp-100],5
       inc       rdx
       dec       ecx
       mov       [rbp-138],rdx
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       lea       rdx,[rbp-110]
       call      qword ptr [7FFC037ED548]; MessagePack.MessagePackPrimitives.TryReadBigEndian(System.ReadOnlySpan`1<Byte>, UInt32 ByRef)
       test      eax,eax
       je        short M03_L37
       jmp       short M03_L36
M03_L34:
       mov       dword ptr [rbp-100],3
       inc       rdx
       dec       ecx
       mov       [rbp-138],rdx
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       lea       rdx,[rbp-108]
       call      qword ptr [7FFC037ED530]; MessagePack.MessagePackPrimitives.TryReadBigEndian(System.ReadOnlySpan`1<Byte>, UInt16 ByRef)
       test      eax,eax
       je        short M03_L37
       movzx     ebx,word ptr [rbp-108]
       jmp       near ptr M03_L04
M03_L35:
       call      qword ptr [7FFC02EFF1B0]
       int       3
M03_L36:
       mov       ebx,[rbp-110]
       jmp       near ptr M03_L04
M03_L37:
       xor       ebx,ebx
       mov       edx,3
       jmp       near ptr M03_L05
M03_L38:
       xor       ebx,ebx
       mov       edx,1
       jmp       near ptr M03_L05
M03_L39:
       cmp       byte ptr [rcx+14],0
       je        short M03_L40
       call      qword ptr [7FFC037ED578]
       jmp       near ptr M03_L06
M03_L40:
       mov       eax,[rcx+68]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       jo        near ptr M03_L48
       cmp       eax,edx
       jne       short M03_L41
       mov       eax,r8d
       add       eax,edx
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,rdx
       add       rax,[rcx+8]
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       near ptr M03_L06
M03_L41:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1078
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC037ED590]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L42:
       lea       r8,[rbp-0F8]
       lea       r9,[rbp-100]
       mov       rcx,rdi
       call      qword ptr [7FFC037ED518]
       test      eax,eax
       jne       near ptr M03_L06
       jmp       near ptr M03_L26
M03_L43:
       lea       rdx,[rbp-128]
       mov       rcx,r14
       call      qword ptr [7FFC037ED5C0]
       mov       rdx,[rbp-128]
       mov       rbx,[rbp-120]
       mov       r15d,[rbp-118]
       and       r15d,7FFFFFFF
       mov       r13d,[rbp-114]
       and       r13d,7FFFFFFF
       cmp       rdx,rbx
       je        short M03_L44
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r13,r13d
       add       r13,[rax+10]
       movsxd    rdx,r15d
       add       rdx,[r12+10]
       sub       r13,rdx
       jmp       short M03_L45
M03_L44:
       sub       r13d,r15d
       movsxd    r13,r13d
M03_L45:
       mov       [r14],r13
       jmp       near ptr M03_L07
M03_L46:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,21E75C01B30
       mov       rbx,[rax]
       jmp       near ptr M03_L12
M03_L47:
       mov       rcx,rax
       mov       r11,r14
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [r14]
       mov       rbx,rax
       jmp       near ptr M03_L12
M03_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L50:
       mov       rax,[rbp-140]
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
M03_L51:
       mov       rcx,21E75C00AF8
       mov       rbx,[rcx]
       mov       rcx,21E75C00AC8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L01
M03_L52:
       sub       rsp,28
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        short M03_L53
       mov       rdx,[rbp-148]
       call      qword ptr [7FFC03A95B30]
M03_L53:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdi,[rbp+18]
       mov       ecx,[rdi]
       sub       ecx,1
       jo        short M03_L54
       mov       [rdi],ecx
       add       rsp,28
       ret
M03_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8CC
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C0A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC035B27D8
       call      qword ptr [7FFC02CCF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02EF5470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC0353E358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 2149
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25EF4CA0008
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
       call      qword ptr [7FFC038ED218]
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
       jne       short M05_L01
       cmp       [rax],edx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       ret
M05_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M05_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],r8d
       jle       short M05_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       jmp       qword ptr [7FFC02CCD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ClonePersonRecordRecord()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,2E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFD60
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+2E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+300],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L10
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L10
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L11
M00_L02:
       mov       rcx,25031C00AD8
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L12
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L13
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+210],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+1D0]
       vmovdqu   ymmword ptr [rsp+288],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1F0]
       vmovdqu   ymmword ptr [rsp+2A8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+210]
       vmovdqu   xmmword ptr [rsp+2C8],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+280]
       vmovdqu   ymmword ptr [rsp+220],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+2A0]
       vmovdqu   ymmword ptr [rsp+240],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+2C0]
       vmovdqu   ymmword ptr [rsp+260],ymm0
       mov       byte ptr [rsp+220],0
       xor       eax,eax
       mov       [rsp+228],rax
       mov       [rsp+230],rdx
       mov       [rsp+238],rax
       mov       [rsp+240],eax
       mov       [rsp+248],rcx
       mov       [rsp+250],r8d
       mov       [rsp+258],rdi
       mov       [rsp+260],eax
       mov       [rsp+264],r8d
       mov       [rsp+278],rax
       lea       rdx,[rsp+220]
       mov       r8,rsi
       mov       rcx,7FFC03606C68
       call      qword ptr [7FFC035755D8]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+230],0
       je        near ptr M00_L16
       mov       rdx,[rsp+258]
       mov       ecx,[rsp+260]
       mov       eax,[rsp+264]
       mov       esi,[rsp+240]
       cmp       esi,eax
       ja        near ptr M00_L14
       test      rdx,rdx
       je        near ptr M00_L15
       mov       eax,ecx
       mov       r8d,esi
       add       rax,r8
       mov       r8d,[rdx+8]
       cmp       rax,r8
       ja        near ptr M00_L23
       lea       rdi,[rdx+rcx+10]
M00_L04:
       test      esi,esi
       je        near ptr M00_L17
       mov       edx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r8d,esi
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       test      rbp,rbp
       je        near ptr M00_L21
       mov       esi,[rbp+8]
M00_L06:
       xor       edi,edi
       xor       r14d,r14d
       test      rbp,rbp
       je        short M00_L08
       mov       rdx,[rbp]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L22
       lea       rdi,[rbp+10]
       mov       r14d,[rbp+8]
M00_L07:
       cmp       esi,r14d
       ja        near ptr M00_L23
       mov       r14d,esi
M00_L08:
       mov       edx,esi
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+38]
       vmovdqu   ymmword ptr [rsp+130],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+58]
       vmovdqu   ymmword ptr [rsp+150],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+170],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+190],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+128]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+148]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+168]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+188]
       vmovdqu   ymmword ptr [rsp+108],ymm0
       xor       r8d,r8d
       mov       [rsp+0A8],r8d
       mov       [rsp+0B0],rdx
       mov       [rsp+0B8],r8
       mov       [rsp+0C0],r8d
       mov       byte ptr [rsp+0C4],0
       mov       [rsp+0C5],cl
       mov       [rsp+100],rbp
       mov       [rsp+108],r8d
       mov       [rsp+10C],esi
       mov       [rsp+110],rdi
       mov       [rsp+118],r14d
       mov       [rsp+120],r8
       lea       rdx,[rsp+0A8]
       mov       rcx,7FFC03891C10
       call      qword ptr [7FFC03855B60]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,2E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L09:
       call      qword ptr [7FFC03306B50]
       mov       ecx,3
       mov       rdx,7FFC03164600
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03035770
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03164600
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC0343CAF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0343CB10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,0E
       call      qword ptr [7FFC03575620]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,0E
       call      qword ptr [7FFC03575620]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,2501BC02010
       mov       rbp,[rcx]
       mov       rcx,25031C00AD8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC030E71E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       ecx,28
       call      qword ptr [7FFC02CDF348]
       int       3
M00_L15:
       or        ecx,esi
       jne       near ptr M00_L23
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L16:
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       cmp       qword ptr [rsp+1C8],0
       jne       short M00_L19
       jmp       short M00_L18
M00_L17:
       mov       rbp,290B0C96EF8
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F1C
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CDF228]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       ebp,[rsp+240]
       test      ebp,ebp
       jle       short M00_L20
       lea       rcx,[rsp+228]
       call      qword ptr [7FFC038E6808]
       mov       ecx,ebp
       add       rcx,[rsp+238]
       jo        near ptr M00_L24
       mov       [rsp+238],rcx
       xor       ecx,ecx
       mov       [rsp+240],ecx
       mov       rcx,[rsp+228]
       mov       edx,ebp
       mov       r11,7FFC02C21670
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+248],xmm0
M00_L20:
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       mov       rdx,[rsp+1C8]
       cmp       [rdx],dl
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FFC03576C28]
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FFC03855AD0]
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC03576C70]
       jmp       near ptr M00_L05
M00_L21:
       xor       ebp,ebp
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L22:
       lea       rdx,[rsp+28]
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+28]
       mov       r14d,[rsp+30]
       jmp       near ptr M00_L07
M00_L23:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1663
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rbx,rbx
       je        near ptr M01_L64
M01_L00:
       mov       rdi,rbx
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L65
M01_L01:
       cmp       dword ptr [rdi+20],0
       jne       near ptr M01_L27
M01_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M01_L22
M01_L03:
       mov       rax,[rcx+18]
       mov       r15,[rax+18]
       test      r15,r15
       je        near ptr M01_L23
M01_L04:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L62
       test      rsi,rsi
       je        near ptr M01_L36
       mov       rcx,rsi
       call      qword ptr [7FFC02F061C0]; System.Object.GetType()
       mov       r15,rax
       mov       rbx,r15
       mov       rcx,290B0C927E0
       cmp       rbx,rcx
       je        near ptr M01_L37
       mov       rcx,25031C00D60
       mov       r14,[rcx]
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L08
       mov       r13,[r14+18]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r11,7FFC02C216A8
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rdx,[r14+8]
       mov       ecx,r12d
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L50
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r14,[r14+10]
       xor       eax,eax
       mov       [rbp-0E4],eax
       dec       edx
       mov       r10d,[r14+8]
       mov       [rbp-0E8],r10d
       cmp       r10d,edx
       jbe       short M01_L08
M01_L05:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r14+rdx*8+10]
       mov       [rbp-118],r9
       cmp       [r9+8],r12d
       jne       short M01_L06
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rbx
       mov       r11,7FFC02C216B0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-118]
       jne       short M01_L07
M01_L06:
       mov       edx,[r9+0C]
       mov       eax,[rbp-0E4]
       inc       eax
       mov       r10d,[rbp-0E8]
       cmp       r10d,eax
       jb        near ptr M01_L24
       cmp       r10d,edx
       mov       [rbp-0E4],eax
       jbe       short M01_L08
       jmp       short M01_L05
M01_L07:
       add       r9,10
       test      r9,r9
       jne       short M01_L12
M01_L08:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L39
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L09:
       test      eax,eax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L41
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L42
M01_L11:
       test      rax,rax
       je        short M01_L15
M01_L12:
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L38
       xor       eax,eax
M01_L13:
       test      rax,rax
       jne       short M01_L15
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L43
M01_L14:
       test      rax,rax
       je        near ptr M01_L44
M01_L15:
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L45
       mov       rcx,25031C00D20
       mov       rcx,[rcx]
       mov       r13,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L25
M01_L16:
       mov       ecx,[r13+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L49
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L50
       mov       ecx,edx
       mov       rcx,[r13+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L47
M01_L17:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L46
       mov       r13,[rcx+18]
M01_L18:
       mov       rdx,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L48
       mov       rcx,25031C00D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       edx,[r14+8]
       mov       ecx,edx
       sub       ecx,1
       jo        near ptr M01_L49
       and       ecx,eax
       cmp       ecx,edx
       jae       near ptr M01_L50
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       test      rdx,rdx
       je        near ptr M01_L52
M01_L20:
       cmp       [rdx+10],rbx
       jne       near ptr M01_L51
       mov       r14,[rdx+18]
M01_L21:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r8,[rbp+18]
       mov       r9,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M01_L63
M01_L22:
       mov       rdx,7FFC03610900
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L03
M01_L23:
       mov       rdx,7FFC03610920
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFC02CDF480]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFC02F07258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L16
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFC02F07258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L19
M01_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFC03610B68
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L29:
       mov       rcx,rax
       call      qword ptr [7FFC02CD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L02
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03576BB0]
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FFC03576BE0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rdx,7FFC03610900
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L33
       jmp       short M01_L34
M01_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L33:
       mov       rdx,7FFC03610920
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L34:
       mov       rdx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r14]
       mov       esi,[rbp-0A0]
       test      esi,esi
       jle       short M01_L35
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFC038E6808]
       mov       ecx,esi
       add       rcx,[rbp-0A8]
       jo        short M01_L32
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,esi
       mov       r11,7FFC02C21690
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L35:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC03576C28]
       mov       r9d,[rbx+24]
       mov       r8d,[rbx+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC03576C58]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L63
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC038E72E8]
       jmp       near ptr M01_L63
M01_L36:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC035771C8]
       jmp       near ptr M01_L63
M01_L37:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FFC038E7300]
       jmp       near ptr M01_L63
M01_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L13
M01_L39:
       mov       rcx,r15
       mov       rdx,290B0C96D90
       call      qword ptr [7FFC02C1A608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L09
M01_L40:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L10
M01_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L11
M01_L43:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L14
M01_L44:
       mov       rcx,25031C00D58
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFC0360C098]
       jmp       near ptr M01_L63
M01_L45:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1FB
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC030E71E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L17
M01_L47:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25031C00D28
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FFC02F41C80]; Precode of System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r13,rax
       mov       rcx,290B0CA3B98
       mov       rdx,290B0CA3BC0
       call      qword ptr [7FFC03577240]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFC03577468]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo)
       mov       r13,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-120],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-120]
       mov       [rsp+20],r12
       mov       rdx,r13
       mov       rcx,7FFC03623F40
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC03577B70]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC035772A0]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r13,rax
       mov       rcx,25031C00D20
       mov       rcx,[rcx]
       mov       rdx,rbx
       mov       r8,r13
       call      qword ptr [7FFC035772B8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       near ptr M01_L18
M01_L48:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC03576D30]
       int       3
M01_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L51:
       mov       rdx,[rdx+8]
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L52:
       mov       rdx,25031C00D50
       mov       rcx,[rdx]
       mov       [rbp-0F0],rcx
       mov       byte ptr [rbp-0E0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CD5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,25031C00D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC0318CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ecx,[r14+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L57
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L58
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M01_L55
M01_L53:
       cmp       [rcx+10],rbx
       je        short M01_L54
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L53
       jmp       short M01_L55
M01_L54:
       mov       r14,[rcx+18]
       mov       ecx,1
       jmp       short M01_L56
M01_L55:
       xor       r14d,r14d
       xor       ecx,ecx
M01_L56:
       test      ecx,ecx
       jne       near ptr M01_L61
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,290B0CA3AF8
       call      qword ptr [7FFC02C1A5B8]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       r14,rax
       mov       rcx,290B0C927E0
       mov       rdx,290B0CA3B20
       call      qword ptr [7FFC03577240]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-0F8],rax
       mov       rdx,290B0CA3B48
       mov       [rbp-138],rdx
       mov       rcx,rdx
       call      qword ptr [7FFC02C1A5B0]; Precode of System.RuntimeType.MakeByRefType()
       mov       rcx,rax
       mov       rdx,290B0C97EC8
       call      qword ptr [7FFC03577240]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-100],rax
       mov       rcx,290B0C927E0
       mov       rdx,290B0C91640
       call      qword ptr [7FFC03577240]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-108],rax
       mov       r8,290B0CA3278
       mov       [rbp-140],r8
       mov       rcx,r8
       mov       rdx,290B0C9A148
       call      qword ptr [7FFC03577240]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-110],rax
       mov       rcx,r12
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC02C1A5B0]; Precode of System.RuntimeType.MakeByRefType()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-140]
       mov       [r12+20],rbx
       mov       rcx,r14
       mov       r8,r12
       mov       rdx,290B0CA3B70
       call      qword ptr [7FFC03575D40]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(System.Type, System.String, System.Type[])
       mov       rbx,rax
       mov       rcx,[rbp-0F8]
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC036A5530]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       mov       r14,rax
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M01_L59
       mov       rcx,[rbp-108]
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFC036A5530]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       jmp       short M01_L60
M01_L57:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L59:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       call      qword ptr [7FFC03577270]
M01_L60:
       mov       r12,[rbp-110]
       mov       [rsp+20],r12
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,[rbp-100]
       mov       r9,rax
       call      qword ptr [7FFC03577288]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression)
       mov       rbx,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],r14
       mov       rdx,rbx
       mov       rcx,7FFC036DFF78
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC03577B70]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC035772A0]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r14,rax
       mov       rcx,25031C00D50
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFC035772B8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       nop
M01_L61:
       cmp       byte ptr [rbp-0E0],0
       je        near ptr M01_L21
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CD6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M01_L21
M01_L62:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r15]
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
       call      qword ptr [7FFC03575638]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rbx,rax
       jmp       near ptr M01_L00
M01_L65:
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC030E4C90]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L01
       sub       rsp,28
       cmp       qword ptr [rbp-128],0
       je        short M01_L66
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC038E72E8]
M01_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-0E0],0
       je        short M01_L67
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CD6820]; System.Threading.Monitor.Exit(System.Object)
M01_L67:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,812
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C1A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02F05470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC03576C88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,28
       ret
; Total bytes of code 3023
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M02_L02
M02_L00:
       cmp       rcx,rdx
       je        near ptr M02_L13
M02_L01:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M02_L02:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M02_L00
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M02_L06
       cmp       r8,40
       jbe       short M02_L03
       cmp       r8,800
       ja        short M02_L01
       jmp       near ptr M02_L10
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       vzeroupper
       ret
M02_L06:
       test      r8b,18
       je        short M02_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L08:
       test      r8b,4
       je        short M02_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L09:
       test      r8,r8
       je        short M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L05
M02_L10:
       cmp       r8,100
       jb        short M02_L11
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
M02_L11:
       mov       r9,r8
       shr       r9,6
M02_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L13:
       cmp       [rdx],dl
       jmp       near ptr M02_L05
; Total bytes of code 320
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
       sub       rsp,138
       lea       rbp,[rsp+170]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M03_L01
       mov       rcx,25031C00AD8
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L51
M03_L01:
       mov       rsi,rbx
       cmp       dword ptr [rsi+20],0
       jne       near ptr M03_L15
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        near ptr M03_L13
M03_L02:
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        near ptr M03_L14
M03_L03:
       mov       rdx,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.ArrayFormatter<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rax],rcx
       jne       near ptr M03_L47
       mov       rdi,[rbp+18]
       lea       r14,[rdi+8]
       mov       rcx,r14
       cmp       byte ptr [rcx+15],0
       je        near ptr M03_L26
       mov       rdx,[rcx+60]
       mov       eax,[rcx+68]
       mov       ebx,[rcx+10]
       mov       ecx,ebx
       cmp       ecx,eax
       jae       near ptr M03_L49
       movzx     ecx,byte ptr [rdx+rcx]
       cmp       ecx,0C0
       je        near ptr M03_L27
       mov       rcx,r14
       mov       rdx,[rcx+60]
       mov       ecx,[rcx+68]
       cmp       ebx,ecx
       ja        near ptr M03_L35
       mov       eax,ebx
       add       rdx,rax
       sub       ecx,ebx
       mov       dword ptr [rbp-100],1
       test      ecx,ecx
       je        near ptr M03_L32
       movzx     eax,byte ptr [rdx]
       mov       r8d,eax
       cmp       r8d,90
       jl        near ptr M03_L38
       cmp       r8d,9F
       jg        near ptr M03_L33
       and       eax,0F
       cmp       eax,0FF
       ja        near ptr M03_L48
       mov       ebx,eax
M03_L04:
       xor       edx,edx
M03_L05:
       test      ebx,ebx
       jl        near ptr M03_L48
       mov       ecx,ebx
       mov       [rbp-0F8],ecx
       test      edx,edx
       jne       near ptr M03_L42
       mov       rcx,r14
       movsxd    rdx,dword ptr [rbp-100]
       test      rdx,0FFFFFFFF80000000
       jne       near ptr M03_L39
       mov       eax,[rcx+68]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       jo        near ptr M03_L48
       cmp       eax,edx
       jle       near ptr M03_L39
       add       r8d,edx
       jo        near ptr M03_L48
       mov       [rcx+10],r8d
       add       rdx,[rcx+8]
       jo        near ptr M03_L48
       mov       [rcx+8],rdx
M03_L06:
       cmp       qword ptr [r14],0
       jl        near ptr M03_L43
M03_L07:
       mov       rdx,[r14]
       sub       rdx,[r14+8]
       jo        near ptr M03_L48
       movsxd    rbx,dword ptr [rbp-0F8]
       cmp       rdx,rbx
       jl        near ptr M03_L26
       mov       edx,[rbp-0F8]
       test      edx,edx
       je        near ptr M03_L46
       mov       rdx,[rsi+8]
       mov       rcx,7FFC036F0FD8
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       r14,rax
       mov       rdx,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03855D70]; MessagePack.MessagePackSecurity.DepthStep(MessagePack.MessagePackReader ByRef)
       nop
       xor       r15d,r15d
       mov       r13d,[rbx+8]
       cmp       r13d,r15d
       jg        short M03_L09
       jmp       short M03_L11
M03_L08:
       mov       rcx,r14
       mov       r8,rsi
       mov       rdx,rdi
       mov       r11,7FFC02C216F8
       call      qword ptr [r11]
       mov       r8,rax
       movsxd    rdx,r15d
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       r15d,1
       jo        short M03_L10
       cmp       r13d,r15d
       jle       short M03_L11
M03_L09:
       mov       rcx,[rdi+78]
       mov       [rbp-0F0],rcx
       cmp       qword ptr [rbp-0F0],0
       je        short M03_L08
       mov       rcx,[rbp-0F0]
       cmp       dword ptr [rcx+20],0
       je        short M03_L08
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFC038E5C20]
       int       3
M03_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L11:
       mov       ecx,[rdi]
       sub       ecx,1
       jo        near ptr M03_L48
       mov       [rdi],ecx
M03_L12:
       mov       [rbp-140],rbx
       jmp       near ptr M03_L50
M03_L13:
       mov       rdx,7FFC03877CB8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
M03_L14:
       mov       rdx,7FFC03877CD8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M03_L03
M03_L15:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03576BB0]
       mov       rcx,[rbp-50]
       mov       [rbp-148],rcx
       mov       rdx,[rbp-48]
       mov       [rbp-150],rdx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp-150]
       call      qword ptr [7FFC03855C80]
       test      eax,eax
       je        near ptr M03_L20
       mov       rdx,[rbp-150]
       cmp       [rdx],dl
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFC03576C28]
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D0]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC03855C98]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rdx,7FFC03877CB8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M03_L17:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rdx,7FFC03877CD8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M03_L19:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0D0]
       mov       r11,rdi
       mov       r8,rbx
       call      qword ptr [rdi]
       mov       [rbp-140],rax
       jmp       near ptr M03_L25
M03_L20:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+10]
       test      rsi,rsi
       je        short M03_L21
       jmp       short M03_L22
M03_L21:
       mov       rdx,7FFC03877CB8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M03_L22:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M03_L23
       jmp       short M03_L24
M03_L23:
       mov       rdx,7FFC03877CD8
       call      qword ptr [7FFC02CDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M03_L24:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03576AF0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       mov       r11,rdi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [rdi]
       mov       [rbp-140],rax
       cmp       qword ptr [rbp-148],0
       je        near ptr M03_L50
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-150]
       call      qword ptr [7FFC038E72E8]
       jmp       near ptr M03_L50
M03_L25:
       call      M03_L52
       jmp       near ptr M03_L50
M03_L26:
       call      qword ptr [7FFC03855E48]
       int       3
M03_L27:
       mov       rcx,r14
       mov       eax,[rcx+68]
       sub       eax,ebx
       jo        near ptr M03_L48
       cmp       eax,1
       jle       short M03_L28
       mov       eax,ebx
       add       eax,1
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       jmp       near ptr M03_L31
M03_L28:
       cmp       byte ptr [rcx+14],0
       je        short M03_L29
       mov       edx,1
       call      qword ptr [7FFC03855F20]
       jmp       short M03_L31
M03_L29:
       mov       eax,[rcx+68]
       sub       eax,ebx
       jo        near ptr M03_L48
       cmp       eax,1
       jne       short M03_L30
       mov       eax,ebx
       add       eax,1
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,[rcx+8]
       add       rax,1
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       short M03_L31
M03_L30:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1078
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03855F38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L31:
       xor       ebx,ebx
       jmp       near ptr M03_L12
M03_L32:
       xor       ebx,ebx
       mov       edx,2
       jmp       near ptr M03_L05
M03_L33:
       cmp       r8d,0DC
       je        short M03_L34
       cmp       r8d,0DD
       jne       near ptr M03_L38
       mov       dword ptr [rbp-100],5
       inc       rdx
       dec       ecx
       mov       [rbp-138],rdx
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       lea       rdx,[rbp-110]
       call      qword ptr [7FFC03855EF0]; MessagePack.MessagePackPrimitives.TryReadBigEndian(System.ReadOnlySpan`1<Byte>, UInt32 ByRef)
       test      eax,eax
       je        short M03_L37
       jmp       short M03_L36
M03_L34:
       mov       dword ptr [rbp-100],3
       inc       rdx
       dec       ecx
       mov       [rbp-138],rdx
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       lea       rdx,[rbp-108]
       call      qword ptr [7FFC03855ED8]; MessagePack.MessagePackPrimitives.TryReadBigEndian(System.ReadOnlySpan`1<Byte>, UInt16 ByRef)
       test      eax,eax
       je        short M03_L37
       movzx     ebx,word ptr [rbp-108]
       jmp       near ptr M03_L04
M03_L35:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M03_L36:
       mov       ebx,[rbp-110]
       jmp       near ptr M03_L04
M03_L37:
       xor       ebx,ebx
       mov       edx,3
       jmp       near ptr M03_L05
M03_L38:
       xor       ebx,ebx
       mov       edx,1
       jmp       near ptr M03_L05
M03_L39:
       cmp       byte ptr [rcx+14],0
       je        short M03_L40
       call      qword ptr [7FFC03855F20]
       jmp       near ptr M03_L06
M03_L40:
       mov       eax,[rcx+68]
       mov       r8d,[rcx+10]
       sub       eax,r8d
       jo        near ptr M03_L48
       cmp       eax,edx
       jne       short M03_L41
       mov       eax,r8d
       add       eax,edx
       jo        near ptr M03_L48
       mov       [rcx+10],eax
       mov       rax,rdx
       add       rax,[rcx+8]
       jo        near ptr M03_L48
       mov       [rcx+8],rax
       mov       byte ptr [rcx+15],0
       jmp       near ptr M03_L06
M03_L41:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1078
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03855F38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L42:
       lea       r8,[rbp-0F8]
       lea       r9,[rbp-100]
       mov       rcx,rdi
       call      qword ptr [7FFC03855EC0]
       test      eax,eax
       jne       near ptr M03_L06
       jmp       near ptr M03_L26
M03_L43:
       lea       rdx,[rbp-128]
       mov       rcx,r14
       call      qword ptr [7FFC03855F68]
       mov       rdx,[rbp-128]
       mov       rbx,[rbp-120]
       mov       r15d,[rbp-118]
       and       r15d,7FFFFFFF
       mov       r13d,[rbp-114]
       and       r13d,7FFFFFFF
       cmp       rdx,rbx
       je        short M03_L44
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r13,r13d
       add       r13,[rax+10]
       movsxd    rdx,r15d
       add       rdx,[r12+10]
       sub       r13,rdx
       jmp       short M03_L45
M03_L44:
       sub       r13d,r15d
       movsxd    r13,r13d
M03_L45:
       mov       [r14],r13
       jmp       near ptr M03_L07
M03_L46:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,25031C01A20
       mov       rbx,[rax]
       jmp       near ptr M03_L12
M03_L47:
       mov       rcx,rax
       mov       r11,r14
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [r14]
       mov       rbx,rax
       jmp       near ptr M03_L12
M03_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L50:
       mov       rax,[rbp-140]
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
M03_L51:
       mov       rcx,2501BC02010
       mov       rbx,[rcx]
       mov       rcx,25031C00AD8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L01
M03_L52:
       sub       rsp,28
       cmp       qword ptr [rbp-148],0
       je        short M03_L53
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-150]
       call      qword ptr [7FFC038E72E8]
M03_L53:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdi,[rbp+18]
       mov       ecx,[rdi]
       sub       ecx,1
       jo        short M03_L54
       mov       [rdi],ecx
       add       rsp,28
       ret
M03_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8CC
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C1A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC0358D270
       call      qword ptr [7FFC02CDF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02F05470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC03576C88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 2179
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,290B0C90008
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
       call      qword ptr [7FFC038E6FB8]
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
       jne       short M05_L01
       cmp       [rax],edx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       ret
M05_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M05_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],r8d
       jle       short M05_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       jmp       qword ptr [7FFC02CDD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ClonePersonRecordRecord()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,210
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+210],xmm4
       vmovdqa   xmmword ptr [rsp+rax+220],xmm4
       vmovdqa   xmmword ptr [rsp+rax+230],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L18
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L18
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L19
M00_L02:
       mov       rcx,1B072000AD8
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L20
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L21
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+140],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+100]
       vmovdqu   ymmword ptr [rsp+1B8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+120]
       vmovdqu   ymmword ptr [rsp+1D8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+140]
       vmovdqu   xmmword ptr [rsp+1F8],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+1B0]
       vmovdqu   ymmword ptr [rsp+150],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1D0]
       vmovdqu   ymmword ptr [rsp+170],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1F0]
       vmovdqu   ymmword ptr [rsp+190],ymm0
       mov       byte ptr [rsp+150],0
       xor       eax,eax
       mov       [rsp+158],rax
       mov       [rsp+160],rdx
       mov       [rsp+168],rax
       mov       [rsp+170],eax
       mov       [rsp+178],rcx
       mov       [rsp+180],r8d
       mov       [rsp+188],rdi
       mov       [rsp+190],eax
       mov       [rsp+194],r8d
       mov       [rsp+1A8],rax
       lea       rdx,[rsp+150]
       mov       r8,rsi
       mov       rcx,7FFC0364F6B0
       call      qword ptr [7FFC034ECAC8]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+160],0
       jne       near ptr M00_L22
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+198]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       cmp       qword ptr [rsp+0E8],0
       je        near ptr M00_L25
       mov       esi,[rsp+170]
       test      esi,esi
       jle       near ptr M00_L06
       cmp       qword ptr [rsp+160],0
       jne       near ptr M00_L10
M00_L04:
       mov       ecx,esi
       add       rcx,[rsp+168]
       jo        near ptr M00_L42
       mov       [rsp+168],rcx
       xor       ecx,ecx
       mov       [rsp+170],ecx
       mov       rdi,[rsp+158]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rdi],rcx
       jne       near ptr M00_L39
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        near ptr M00_L34
       add       esi,[rcx+3C]
       jo        near ptr M00_L42
       mov       edx,esi
       mov       eax,[rcx+24]
       cmp       edx,eax
       jg        near ptr M00_L35
       mov       [rcx+3C],esi
       cmp       byte ptr [rdi+34],0
       je        short M00_L05
       cmp       dword ptr [rdi+30],8000
       jl        near ptr M00_L36
M00_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+178],xmm0
M00_L06:
       vmovdqu   xmm0,xmmword ptr [rsp+198]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       rdx,[rsp+0E8]
       cmp       [rdx],dl
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC034EE118]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+0C8]
       mov       rsi,[rsp+0D0]
       mov       edi,[rsp+0D8]
       and       edi,7FFFFFFF
       mov       ebp,[rsp+0DC]
       and       ebp,7FFFFFFF
       cmp       rdx,rsi
       jne       near ptr M00_L16
       sub       ebp,edi
       movsxd    rdx,ebp
M00_L07:
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC0380DF38]; System.Buffers.ReadOnlySequence`1[[System.Byte, System.Private.CoreLib]].get_IsSingleSegment()
       test      eax,eax
       jne       near ptr M00_L40
       mov       [rsp+38],rdi
       mov       [rsp+40],ebp
       lea       rdx,[rsp+38]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC0380D740]; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
M00_L08:
       vmovdqu   xmm0,xmmword ptr [rsp+198]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       lea       rcx,[rsp+0E0]
       call      qword ptr [7FFC034EE160]; MessagePack.SequencePool+Rental.Dispose()
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FFC03A95FE0]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+58]
       mov       r8d,[rsp+5C]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       mov       [rsp+34],r8d
       lea       rdx,[rsp+28]
       mov       rcx,7FFC038CF8A0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC034ECA68]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       mov       [rsp+48],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+48]
       mov       rdx,7FFC038E3908
       cmp       [rcx],ecx
       call      qword ptr [7FFC0380E808]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,210
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L10:
       lea       rdx,[rsp+198]
       mov       rcx,[rsp+160]
       cmp       [rcx],ecx
       call      qword ptr [7FFC034EE0A0]; MessagePack.SequencePool.Rent()
       mov       rcx,[rsp+1A0]
       mov       [rsp+158],rcx
       mov       rcx,[rsp+158]
       mov       rdx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rcx],rdx
       jne       near ptr M00_L29
       mov       edx,[rsp+170]
       call      qword ptr [7FFC0380D188]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       mov       rdi,rax
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        near ptr M00_L26
       mov       ebp,[rcx+8]
       xor       r14d,r14d
M00_L11:
       xor       r15d,r15d
       xor       r13d,r13d
       test      rcx,rcx
       je        short M00_L13
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L28
       lea       r15,[rcx+10]
       mov       r13d,[rcx+8]
M00_L12:
       and       r14d,7FFFFFFF
       mov       edx,r14d
       mov       ecx,ebp
       add       rcx,rdx
       mov       r8d,r13d
       cmp       rcx,r8
       ja        near ptr M00_L32
       add       r15,rdx
       mov       r13d,ebp
M00_L13:
       mov       edx,[rdi+3C]
       cmp       edx,r13d
       ja        near ptr M00_L32
       mov       ecx,edx
       add       rcx,r15
       sub       r13d,edx
       mov       [rsp+0B8],rcx
       mov       [rsp+0C0],r13d
M00_L14:
       mov       r8,[rsp+188]
       mov       ecx,[rsp+190]
       mov       edx,[rsp+194]
       mov       eax,[rsp+170]
       cmp       eax,edx
       ja        near ptr M00_L30
       test      r8,r8
       je        near ptr M00_L31
       mov       edx,eax
       add       rdx,rcx
       mov       r10d,[r8+8]
       cmp       rdx,r10
       ja        near ptr M00_L32
       lea       rdx,[r8+rcx+10]
M00_L15:
       cmp       eax,[rsp+0C0]
       jg        near ptr M00_L33
       mov       r8d,eax
       mov       rcx,[rsp+0B8]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       xor       ecx,ecx
       mov       [rsp+160],rcx
       jmp       near ptr M00_L04
M00_L16:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    rdx,ebp
       add       rdx,[rax+10]
       movsxd    rcx,edi
       add       rcx,[r14+10]
       sub       rdx,rcx
       jmp       near ptr M00_L07
M00_L17:
       call      qword ptr [7FFC0331DF50]
       mov       ecx,3
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03045770
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC0346FD98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0346FDB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       ecx,0E
       call      qword ptr [7FFC034ECB10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L19:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,0E
       call      qword ptr [7FFC034ECB10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L20:
       mov       rcx,1B05C002010
       mov       rbp,[rcx]
       mov       rcx,1B072000AD8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L21:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC030F71E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rdx,[rsp+188]
       mov       ecx,[rsp+190]
       mov       eax,[rsp+194]
       mov       r8d,[rsp+170]
       cmp       r8d,eax
       ja        near ptr M00_L30
       test      rdx,rdx
       jne       short M00_L23
       or        ecx,r8d
       jne       near ptr M00_L32
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L24
M00_L23:
       mov       eax,ecx
       mov       r10d,r8d
       add       rax,r10
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        near ptr M00_L32
       mov       ecx,ecx
       lea       rdx,[rdx+rcx+10]
M00_L24:
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       lea       rdx,[rsp+38]
       lea       rcx,[rsp+0F0]
       call      qword ptr [7FFC0319C108]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rcx,[rsp+0F0]
       call      qword ptr [7FFC031974E0]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       mov       rsi,rax
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0F1C
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC02CEF228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       mov       rcx,[rdi+30]
       test      rcx,rcx
       jne       short M00_L27
       xor       ecx,ecx
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L11
M00_L27:
       lea       rdx,[rsp+0A8]
       mov       r11,7FFC02C31950
       call      qword ptr [r11]
       mov       rcx,[rsp+0A8]
       mov       r14d,[rsp+0B0]
       mov       ebp,[rsp+0B4]
       jmp       near ptr M00_L11
M00_L28:
       lea       rdx,[rsp+98]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r15,[rsp+98]
       mov       r13d,[rsp+0A0]
       jmp       near ptr M00_L12
M00_L29:
       lea       rdx,[rsp+0B8]
       mov       r8d,[rsp+170]
       mov       r11,7FFC02C31948
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L30:
       mov       ecx,28
       call      qword ptr [7FFC02CEF348]
       int       3
M00_L31:
       or        ecx,eax
       jne       short M00_L32
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M00_L15
M00_L32:
       call      qword ptr [7FFC02F1F1B0]
       int       3
M00_L33:
       call      qword ptr [7FFC0319C768]
       int       3
M00_L34:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,171
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC030F7930]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       ecx,1078
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC0380D278]
       int       3
M00_L36:
       lea       rcx,[rsp+80]
       mov       rdx,rdi
       call      qword ptr [7FFC034EE118]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+80]
       mov       rsi,[rsp+88]
       mov       ebp,[rsp+90]
       and       ebp,7FFFFFFF
       mov       r14d,[rsp+94]
       and       r14d,7FFFFFFF
       cmp       rdx,rsi
       je        short M00_L37
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r14,r14d
       add       r14,[rax+10]
       movsxd    rcx,ebp
       add       rcx,[r15+10]
       sub       r14,rcx
       jmp       short M00_L38
M00_L37:
       sub       r14d,ebp
       movsxd    r14,r14d
M00_L38:
       mov       rcx,r14
       shr       rcx,3F
       add       rcx,r14
       sar       rcx,1
       mov       edx,7FFFFFFF
       cmp       rcx,7FFFFFFF
       cmovl     rdx,rcx
       movsxd    rcx,edx
       cmp       rdx,rcx
       jne       near ptr M00_L42
       mov       ecx,8000
       cmp       edx,8000
       cmovl     ecx,edx
       cmp       [rdi+30],ecx
       jge       near ptr M00_L05
       mov       [rdi+30],ecx
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFC02C31940
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L40:
       lea       rcx,[rsp+0C8]
       lea       rdx,[rsp+70]
       call      qword ptr [7FFC03A95FC8]
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+60]
       call      qword ptr [7FFC033AF018]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       cmp       [rsp+68],ebp
       jle       short M00_L41
       mov       ecx,6
       call      qword ptr [7FFC0380D848]
       int       3
M00_L41:
       mov       [rsp+38],rdi
       mov       [rsp+40],ebp
       lea       rdx,[rsp+38]
       lea       rcx,[rsp+60]
       call      qword ptr [7FFC0329EEF8]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       jmp       near ptr M00_L08
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2465
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rbx,rbx
       je        near ptr M01_L64
M01_L00:
       mov       rdi,rbx
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L65
M01_L01:
       cmp       dword ptr [rdi+20],0
       jne       near ptr M01_L27
M01_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M01_L22
M01_L03:
       mov       rax,[rcx+18]
       mov       r15,[rax+18]
       test      r15,r15
       je        near ptr M01_L23
M01_L04:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFC034EDFE0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L62
       test      rsi,rsi
       je        near ptr M01_L36
       mov       rcx,rsi
       call      qword ptr [7FFC02F161C0]; System.Object.GetType()
       mov       r15,rax
       mov       rbx,r15
       mov       rcx,1F0F10827E0
       cmp       rbx,rcx
       je        near ptr M01_L37
       mov       rcx,1B072000D60
       mov       r14,[rcx]
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L08
       mov       r13,[r14+18]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r11,7FFC02C319C0
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rdx,[r14+8]
       mov       ecx,r12d
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L50
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r14,[r14+10]
       xor       eax,eax
       mov       [rbp-0E4],eax
       dec       edx
       mov       r10d,[r14+8]
       mov       [rbp-0E8],r10d
       cmp       r10d,edx
       jbe       short M01_L08
M01_L05:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r14+rdx*8+10]
       mov       [rbp-118],r9
       cmp       [r9+8],r12d
       jne       short M01_L06
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rbx
       mov       r11,7FFC02C319C8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-118]
       jne       short M01_L07
M01_L06:
       mov       edx,[r9+0C]
       mov       eax,[rbp-0E4]
       inc       eax
       mov       r10d,[rbp-0E8]
       cmp       r10d,eax
       jb        near ptr M01_L24
       cmp       r10d,edx
       mov       [rbp-0E4],eax
       jbe       short M01_L08
       jmp       short M01_L05
M01_L07:
       add       r9,10
       test      r9,r9
       jne       short M01_L12
M01_L08:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L39
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L09:
       test      eax,eax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L41
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L42
M01_L11:
       test      rax,rax
       je        short M01_L15
M01_L12:
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L38
       xor       eax,eax
M01_L13:
       test      rax,rax
       jne       short M01_L15
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L43
M01_L14:
       test      rax,rax
       je        near ptr M01_L44
M01_L15:
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L45
       mov       rcx,1B072000D20
       mov       rcx,[rcx]
       mov       r13,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L25
M01_L16:
       mov       ecx,[r13+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L49
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L50
       mov       ecx,edx
       mov       rcx,[r13+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L47
M01_L17:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L46
       mov       r13,[rcx+18]
M01_L18:
       mov       rdx,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L48
       mov       rcx,1B072000D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       edx,[r14+8]
       mov       ecx,edx
       sub       ecx,1
       jo        near ptr M01_L49
       and       ecx,eax
       cmp       ecx,edx
       jae       near ptr M01_L50
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       test      rdx,rdx
       je        near ptr M01_L52
M01_L20:
       cmp       [rdx+10],rbx
       jne       near ptr M01_L51
       mov       r14,[rdx+18]
M01_L21:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r8,[rbp+18]
       mov       r9,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M01_L63
M01_L22:
       mov       rdx,7FFC03650900
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L03
M01_L23:
       mov       rdx,7FFC03650920
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFC02CEF480]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFC02F17258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L16
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFC02F17258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L19
M01_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L28
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFC03650B68
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L29:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L02
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC034EE0A0]; MessagePack.SequencePool.Rent()
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FFC034EE0D0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rdx,7FFC03650900
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L33
       jmp       short M01_L34
M01_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L33:
       mov       rdx,7FFC03650920
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L34:
       mov       rdx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFC034EDFE0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r14]
       mov       esi,[rbp-0A0]
       test      esi,esi
       jle       short M01_L35
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFC0380CFC0]; MessagePack.BufferWriter.MigrateToSequence()
       mov       ecx,esi
       add       rcx,[rbp-0A8]
       jo        short M01_L32
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,esi
       mov       r11,7FFC02C319A8
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L35:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC034EE118]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       r9d,[rbx+24]
       mov       r8d,[rbx+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC034EE148]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L63
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0380D8C0]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
       jmp       near ptr M01_L63
M01_L36:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC034EE6B8]
       jmp       near ptr M01_L63
M01_L37:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FFC03A96310]
       jmp       near ptr M01_L63
M01_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L13
M01_L39:
       mov       rcx,r15
       mov       rdx,1F0F1086D90
       call      qword ptr [7FFC02C2A608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L09
M01_L40:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L10
M01_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L11
M01_L43:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L14
M01_L44:
       mov       rcx,1B072000D58
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFC03664AE0]
       jmp       near ptr M01_L63
M01_L45:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1FB
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC030F71E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L17
M01_L47:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1B072000D28
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FFC02F51C80]; Precode of System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r13,rax
       mov       rcx,1F0F1093B98
       mov       rdx,1F0F1093BC0
       call      qword ptr [7FFC034EE730]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFC034EE958]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo)
       mov       r13,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-120],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-120]
       mov       [rsp+20],r12
       mov       rdx,r13
       mov       rcx,7FFC0366C918
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC034EF060]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC034EE790]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r13,rax
       mov       rcx,1B072000D20
       mov       rcx,[rcx]
       mov       rdx,rbx
       mov       r8,r13
       call      qword ptr [7FFC034EE7A8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       near ptr M01_L18
M01_L48:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC034EE220]
       int       3
M01_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L51:
       mov       rdx,[rdx+8]
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L52:
       mov       rdx,1B072000D50
       mov       rcx,[rdx]
       mov       [rbp-0F0],rcx
       mov       byte ptr [rbp-0E0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CE5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1B072000D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ecx,[r14+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L57
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L58
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M01_L55
M01_L53:
       cmp       [rcx+10],rbx
       je        short M01_L54
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L53
       jmp       short M01_L55
M01_L54:
       mov       r14,[rcx+18]
       mov       ecx,1
       jmp       short M01_L56
M01_L55:
       xor       r14d,r14d
       xor       ecx,ecx
M01_L56:
       test      ecx,ecx
       jne       near ptr M01_L61
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,1F0F1093AF8
       call      qword ptr [7FFC02C2A5B8]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       r14,rax
       mov       rcx,1F0F10827E0
       mov       rdx,1F0F1093B20
       call      qword ptr [7FFC034EE730]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-0F8],rax
       mov       rdx,1F0F1093B48
       mov       [rbp-138],rdx
       mov       rcx,rdx
       call      qword ptr [7FFC02C2A5B0]; Precode of System.RuntimeType.MakeByRefType()
       mov       rcx,rax
       mov       rdx,1F0F1087EC8
       call      qword ptr [7FFC034EE730]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-100],rax
       mov       rcx,1F0F10827E0
       mov       rdx,1F0F1081640
       call      qword ptr [7FFC034EE730]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-108],rax
       mov       r8,1F0F1093278
       mov       [rbp-140],r8
       mov       rcx,r8
       mov       rdx,1F0F108A148
       call      qword ptr [7FFC034EE730]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-110],rax
       mov       rcx,r12
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC02C2A5B0]; Precode of System.RuntimeType.MakeByRefType()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-140]
       mov       [r12+20],rbx
       mov       rcx,r14
       mov       r8,r12
       mov       rdx,1F0F1093B70
       call      qword ptr [7FFC034ED230]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(System.Type, System.String, System.Type[])
       mov       rbx,rax
       mov       rcx,[rbp-0F8]
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC0368CA20]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       mov       r14,rax
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M01_L59
       mov       rcx,[rbp-108]
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFC0368CA20]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       jmp       short M01_L60
M01_L57:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L59:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       call      qword ptr [7FFC034EE760]
M01_L60:
       mov       r12,[rbp-110]
       mov       [rsp+20],r12
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,[rbp-100]
       mov       r9,rax
       call      qword ptr [7FFC034EE778]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression)
       mov       rbx,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],r14
       mov       rdx,rbx
       mov       rcx,7FFC03728C70
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC034EF060]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC034EE790]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r14,rax
       mov       rcx,1B072000D50
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFC034EE7A8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       nop
M01_L61:
       cmp       byte ptr [rbp-0E0],0
       je        near ptr M01_L21
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CE6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M01_L21
M01_L62:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r15]
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
       call      qword ptr [7FFC034ECB28]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rbx,rax
       jmp       near ptr M01_L00
M01_L65:
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC030F4C90]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L01
       sub       rsp,28
       cmp       qword ptr [rbp-128],0
       je        short M01_L66
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0380D8C0]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
M01_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-0E0],0
       je        short M01_L67
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CE6820]; System.Threading.Monitor.Exit(System.Object)
M01_L67:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,812
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C2A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02F15470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC034EE178]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,28
       ret
; Total bytes of code 3022
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rdx+20]
       test      rcx,rcx
       je        short M02_L03
       mov       r8,[rdx+28]
       test      r8,r8
       je        short M02_L03
       mov       edx,[rcx+38]
       mov       eax,[r8+3C]
       cmp       rcx,r8
       je        short M02_L00
       mov       r10,[rcx+10]
       cmp       r10,[r8+10]
       jg        short M02_L05
M02_L00:
       mov       r10d,[rcx+24]
       cmp       r10d,edx
       jb        short M02_L05
       mov       r10d,[r8+24]
       cmp       r10d,eax
       jb        short M02_L05
       cmp       rcx,r8
       je        short M02_L04
M02_L01:
       mov       [rbx],rcx
       mov       [rbx+8],r8
       mov       [rbx+10],edx
       mov       [rbx+14],eax
M02_L02:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L03:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1B072001910
       mov       rax,[rax]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rax+18]
       mov       [rbx+10],rcx
       jmp       short M02_L02
M02_L04:
       cmp       eax,edx
       jge       short M02_L01
M02_L05:
       call      qword ptr [7FFC03A95380]
       int       3
; Total bytes of code 151
```
```assembly
; System.Buffers.ReadOnlySequence`1[[System.Byte, System.Private.CoreLib]].get_IsSingleSegment()
       mov       rax,[rcx]
       cmp       rax,[rcx+8]
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 14
```
```assembly
; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       mov       rdx,[rbx]
       mov       rbp,[rbx+8]
       mov       r14d,[rbx+10]
       and       r14d,7FFFFFFF
       mov       r15d,r14d
       mov       r13d,[rbx+14]
       and       r13d,7FFFFFFF
       cmp       rdx,rbp
       jne       near ptr M04_L03
       sub       r13d,r15d
       movsxd    r13,r13d
M04_L00:
       mov       edx,edi
       cmp       r13,rdx
       jg        near ptr M04_L11
       mov       rbp,[rbx]
M04_L01:
       xor       r15d,r15d
       test      rbp,rbp
       je        near ptr M04_L12
       mov       edx,[rbx+10]
       sar       edx,1F
       mov       r13d,[rbx+14]
       mov       ecx,r13d
       sar       ecx,1F
       lea       edx,[rcx+rdx*2]
       mov       r12d,edx
       neg       r12d
       mov       rax,[rbx+8]
       mov       [rsp+20],rax
       and       r13d,7FFFFFFF
       test      r12d,r12d
       jne       near ptr M04_L13
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,[rsp+20]
       cmp       rax,r12
       jne       near ptr M04_L09
       mov       rcx,[r12+18]
       mov       ebp,[r12+20]
       mov       r12d,[r12+24]
       sub       r13d,r14d
       mov       eax,r14d
       mov       edx,r13d
       add       rdx,rax
       mov       eax,r12d
       cmp       rdx,rax
       jbe       short M04_L04
M04_L02:
       mov       ecx,21
       call      qword ptr [7FFC02CEF348]
       int       3
M04_L03:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r13,r13d
       add       r13,[rax+10]
       movsxd    rdx,r15d
       add       rdx,[r12+10]
       sub       r13,rdx
       jmp       near ptr M04_L00
M04_L04:
       add       r14d,ebp
M04_L05:
       mov       edx,1
M04_L06:
       mov       rbp,r15
       xor       eax,eax
       xor       r15d,r15d
       test      dl,dl
       je        near ptr M04_L10
       xor       edx,edx
       xor       r12d,r12d
       test      rcx,rcx
       je        short M04_L08
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M04_L17
       lea       rdx,[rcx+10]
       mov       r12d,[rcx+8]
M04_L07:
       and       r14d,7FFFFFFF
       mov       r8d,r14d
       mov       ecx,r13d
       add       rcx,r8
       mov       eax,r12d
       cmp       rcx,rax
       ja        near ptr M04_L20
       add       rdx,r8
       mov       r12d,r13d
M04_L08:
       cmp       r12d,edi
       ja        near ptr M04_L19
       mov       r8d,r12d
       mov       rcx,rsi
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       test      rbp,rbp
       je        short M04_L10
       mov       ecx,r12d
       add       rsi,rcx
       sub       edi,r12d
       mov       r14d,r15d
       jmp       near ptr M04_L01
M04_L09:
       mov       r15,[rax+8]
       test      r15,r15
       je        near ptr M04_L18
       mov       rcx,[rax+18]
       mov       ebp,[rax+20]
       mov       r12d,[rax+24]
       cmp       r14d,r12d
       ja        near ptr M04_L02
       lea       edx,[r14+rbp]
       sub       r12d,r14d
       mov       r13d,r12d
       mov       r14d,edx
       jmp       near ptr M04_L05
M04_L10:
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
M04_L11:
       mov       ecx,6
       call      qword ptr [7FFC0380D848]
       int       3
M04_L12:
       xor       ecx,ecx
       xor       r14d,r14d
       xor       r13d,r13d
       xor       edx,edx
       jmp       near ptr M04_L06
M04_L13:
       mov       rax,[rsp+20]
       cmp       rbp,rax
       jne       near ptr M04_L18
       cmp       r12d,1
       jne       short M04_L16
       mov       rdx,rax
       mov       rcx,offset MT_System.Byte[]
       call      qword ptr [7FFC02CE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       sub       r13d,r14d
       test      rax,rax
       jne       short M04_L14
       mov       ecx,r14d
       or        ecx,r13d
       jne       near ptr M04_L20
       xor       ecx,ecx
       xor       r12d,r12d
       xor       r13d,r13d
       jmp       short M04_L15
M04_L14:
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rax+8]
       cmp       rdx,rcx
       ja        near ptr M04_L20
       mov       rcx,rax
       mov       r12d,r14d
M04_L15:
       mov       r14d,r12d
       jmp       near ptr M04_L05
M04_L16:
       mov       rdx,rax
       mov       rcx,offset MT_System.Buffers.MemoryManager<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       lea       rdx,[rsp+38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       sub       r13d,r14d
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rsp+44]
       cmp       rdx,rcx
       ja        short M04_L20
       mov       rcx,[rsp+38]
       add       r14d,[rsp+40]
       jmp       near ptr M04_L05
M04_L17:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,[rsp+28]
       mov       r12d,[rsp+30]
       jmp       near ptr M04_L07
M04_L18:
       call      qword ptr [7FFC03A95140]
       int       3
M04_L19:
       call      qword ptr [7FFC0319C768]
       int       3
M04_L20:
       call      qword ptr [7FFC02F1F1B0]
       int       3
; Total bytes of code 764
```
```assembly
; MessagePack.SequencePool+Rental.Dispose()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       vzeroupper
       lea       rbp,[rsp+150]
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0A0],rdx
       mov       rdx,rbp
       mov       [rbp-90],rdx
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M05_L08
       mov       [rbp-0D0],rdi
       mov       rbx,[rbx+8]
       mov       [rbp-0C8],rbx
       mov       r14,[rbx+20]
       test      r14,r14
       jne       near ptr M05_L15
M05_L00:
       xor       ecx,ecx
       mov       [rbx+28],rcx
       mov       [rbx+20],rcx
       mov       rdi,[rbp-0D0]
       mov       rcx,[rdi+8]
       mov       [rbp-0D8],rcx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M05_L02
M05_L01:
       test      dword ptr [rax],80000000
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M05_L43
       mov       [rbp-120],rax
       mov       rcx,rax
       call      qword ptr [7FFC03A963B8]
       test      eax,eax
       je        near ptr M05_L52
       xor       ecx,ecx
       mov       rax,[rbp-120]
       mov       [rax],ecx
       jmp       near ptr M05_L10
M05_L02:
       cmp       qword ptr [rbp-0D8],0
       je        short M05_L04
       mov       rcx,[rbp-0D8]
       call      00007FFC627F9E20
       test      eax,eax
       je        short M05_L05
M05_L03:
       mov       dword ptr [rbp-3C],1
       mov       rsi,[rdi+8]
       mov       r14d,[rsi+10]
       cmp       r14d,[rdi+18]
       jge       short M05_L07
       mov       dword ptr [rbx+30],8000
       mov       rcx,[rsi+8]
       cmp       [rcx+8],r14d
       jbe       short M05_L06
       mov       edx,r14d
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rsi+14]
       inc       r14d
       mov       [rsi+10],r14d
       jmp       short M05_L07
M05_L04:
       xor       ecx,ecx
       call      qword ptr [7FFC038F7A68]
       int       3
M05_L05:
       mov       rcx,[rbp-0D8]
       call      qword ptr [7FFC03007FA8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M05_L03
M05_L06:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC034EFFA8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       nop
M05_L07:
       mov       rcx,[rbp-0D8]
       call      00007FFC628B6030
       test      eax,eax
       jne       near ptr M05_L53
M05_L08:
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
M05_L09:
       cmp       dword ptr [rbp-4C],0
       je        short M05_L10
       mov       rax,[rbp-108]
       add       rax,1C
       mov       ecx,[rax]
       test      ecx,80000000
       je        near ptr M05_L01
       and       ecx,0FFFFFFFE
       mov       [rax],ecx
M05_L10:
       cmp       dword ptr [rbp-50],0
       je        near ptr M05_L44
       mov       ecx,[rbp-0BC]
M05_L11:
       mov       rax,1B05C000B40
       mov       rax,[rax]
       mov       [rbp-100],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M05_L45
M05_L12:
       xor       ecx,ecx
       mov       r14,[rbp-0E0]
       mov       [r14+28],rcx
M05_L13:
       mov       rbx,[rbp-0C8]
       mov       r13,[rbx+8]
       mov       r12d,[r13+10]
       mov       rcx,[r13+8]
       cmp       [rcx+8],r12d
       jbe       near ptr M05_L50
       mov       edx,r12d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r13+14]
       inc       r12d
       mov       [r13+10],r12d
M05_L14:
       mov       r15,[rbp-0E8]
       mov       r14,r15
       test      r14,r14
       je        near ptr M05_L00
M05_L15:
       mov       [rbp-0E0],r14
       mov       rdx,[r14+8]
       mov       r15,rdx
       test      r15,r15
       je        short M05_L16
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       cmp       [r15],rcx
       jne       near ptr M05_L42
M05_L16:
       mov       [rbp-0E8],r15
       mov       r13,[rbx+18]
       mov       eax,[r14+3C]
       sub       eax,[r14+38]
       jo        near ptr M05_L55
       xor       eax,eax
       mov       [r14+18],rax
       mov       [r14+20],rax
       mov       [r14+8],rax
       mov       [r14+10],rax
       mov       [r14+38],rax
       mov       r12,[r14+28]
       test      r12,r12
       je        near ptr M05_L48
       mov       [rbp-0F0],r12
       mov       rax,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [r13],rax
       jne       near ptr M05_L47
       mov       [rbp-0F8],r13
       mov       ecx,[r12+8]
       mov       [rbp-0BC],ecx
       test      ecx,ecx
       je        near ptr M05_L12
       mov       r12,[rbp-0F0]
       lea       eax,[rcx-1]
       or        eax,0F
       lzcnt     eax,eax
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       rdx,[r13+8]
       cmp       [rdx+8],eax
       setg      r8b
       movzx     r8d,r8b
       mov       [rbp-40],r8d
       test      r8d,r8d
       mov       r13,[rbp-0F8]
       je        near ptr M05_L11
       cmp       eax,[rdx+8]
       jae       near ptr M05_L54
       mov       rax,[rdx+rax*8+10]
       mov       [rbp-108],rax
       mov       rax,[rbp-108]
       cmp       [rax],al
       mov       rax,[rbp-108]
       cmp       ecx,[rax+10]
       jne       near ptr M05_L51
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       rdx,[rbp-108]
       add       rdx,1C
       mov       [rbp-118],rdx
       mov       eax,[rdx]
       mov       [rbp-60],eax
       mov       r10d,eax
       and       r10d,80000001
       cmp       r10d,80000000
       jne       short M05_L18
       mov       r10d,eax
       or        r10d,1
       lock cmpxchg [rdx],r10d
       mov       r10d,[rbp-60]
       cmp       eax,r10d
       sete      r9b
       movzx     r9d,r9b
       mov       [rbp-4C],r9d
       jne       short M05_L18
M05_L17:
       mov       rdx,[rbp-108]
       mov       edx,[rdx+18]
       test      edx,edx
       setne     al
       movzx     eax,al
       mov       [rbp-50],eax
       test      eax,eax
       je        near ptr M05_L09
       mov       r10,[rbp-108]
       mov       r10,[r10+8]
       dec       edx
       mov       r9,[rbp-108]
       mov       [r9+18],edx
       movsxd    rdx,edx
       mov       rcx,r10
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M05_L09
M05_L18:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M05_L26
       test      dword ptr [rdx],80000000
       jne       near ptr M05_L25
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-74],eax
       mov       rdx,[rbp-118]
       cmp       [rdx],eax
       je        near ptr M05_L27
       xor       ecx,ecx
       mov       [rbp-80],ecx
M05_L19:
       cmp       dword ptr [rbp-80],0A
       jl        short M05_L22
       cmp       dword ptr [rbp-80],14
       jl        near ptr M05_L28
       mov       ecx,1
       call      qword ptr [7FFC02CEF198]; System.Threading.Thread.Sleep(Int32)
M05_L20:
       cmp       dword ptr [rbp-80],7FFFFFFF
       je        near ptr M05_L34
       mov       eax,[rbp-80]
       inc       eax
M05_L21:
       mov       [rbp-80],eax
       mov       r8,[rbp-118]
       cmp       dword ptr [r8],0
       jne       short M05_L19
       xor       eax,eax
       mov       rdx,[rbp-118]
       mov       ecx,[rbp-74]
       lock cmpxchg [rdx],ecx
       test      eax,eax
       sete      r8b
       movzx     r8d,r8b
       mov       [rbp-4C],r8d
       test      eax,eax
       je        near ptr M05_L17
       jmp       short M05_L19
M05_L22:
       call      00007FFC62905E50
       cmp       dword ptr [rbp-80],1E
       jg        short M05_L23
       mov       ecx,[rbp-80]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L24
M05_L23:
       cmp       eax,400
       jge       near ptr M05_L33
       mov       ecx,eax
       mov       rax,7FFC628A4580
       call      rax
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M05_L32
       mov       r12,[rbp-0F0]
       mov       r13,[rbp-0F8]
       jmp       near ptr M05_L20
M05_L24:
       mov       eax,ecx
       jmp       short M05_L23
M05_L25:
       mov       r10d,7FFFFFFF
       mov       rdx,[rbp-118]
       mov       eax,[rdx]
       test      al,1
       jne       near ptr M05_L36
       mov       r9d,eax
       or        r9d,1
       mov       [rbp-64],eax
       lock cmpxchg [rdx],r9d
       mov       r9d,[rbp-64]
       cmp       eax,r9d
       sete      r11b
       movzx     r11d,r11b
       mov       [rbp-4C],r11d
       jne       near ptr M05_L35
       jmp       near ptr M05_L17
M05_L26:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC03A96358]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC030F5AE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       rcx,offset MT_System.Threading.LockRecursionException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC03A96370]
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFC03A95F38]
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L28:
       mov       ecx,[rbp-80]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L22
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       r8d,66666667
       mov       eax,r8d
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       jne       short M05_L29
       xor       ecx,ecx
       call      qword ptr [7FFC02CEF198]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L20
M05_L29:
       mov       rax,7FFC02D4F490
       mov       [rbp-0A8],rax
       lea       rax,[M05_L30]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFC02D4F4B0]
M05_L30:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M05_L31
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M05_L31:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r12,[rbp-0F0]
       mov       r13,[rbp-0F8]
       jmp       near ptr M05_L20
M05_L32:
       call      CORINFO_HELP_POLL_GC
       mov       r12,[rbp-0F0]
       mov       r13,[rbp-0F8]
       jmp       near ptr M05_L20
M05_L33:
       mov       ecx,eax
       call      qword ptr [7FFC03A96388]
       jmp       near ptr M05_L20
M05_L34:
       mov       eax,0A
       jmp       near ptr M05_L21
M05_L35:
       xor       eax,eax
       mov       [rbp-70],eax
       cmp       r10d,0C
       jg        short M05_L37
       jmp       short M05_L41
M05_L36:
       not       eax
       and       eax,7FFFFFFE
       je        short M05_L35
       mov       r10d,2
       lock xadd [rdx],r10d
       add       r10d,2
       and       r10d,7FFFFFFE
       sar       r10d,1
       mov       rdx,[rbp-118]
       jmp       short M05_L35
M05_L37:
       mov       dword ptr [rbp-70],0A
       jmp       short M05_L41
M05_L38:
       test      eax,7FFFFFFE
       je        short M05_L39
       lea       r10d,[rax-2]
       or        r10d,1
       jmp       short M05_L40
M05_L39:
       mov       r10d,eax
       or        r10d,1
M05_L40:
       mov       [rbp-64],eax
       lock cmpxchg [rdx],r10d
       mov       r10d,[rbp-64]
       cmp       eax,r10d
       sete      r9b
       movzx     r9d,r9b
       mov       [rbp-4C],r9d
       je        near ptr M05_L17
M05_L41:
       lea       rcx,[rbp-70]
       mov       edx,28
       call      qword ptr [7FFC03A963A0]
       mov       rdx,[rbp-118]
       mov       eax,[rdx]
       test      al,1
       je        short M05_L38
       jmp       short M05_L41
M05_L42:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M05_L16
M05_L43:
       and       dword ptr [rax],0FFFFFFFE
       jmp       near ptr M05_L10
M05_L44:
       mov       rcx,1B05C000B40
       mov       rax,[rcx]
       mov       [rbp-110],rax
       cmp       byte ptr [rax+9D],0
       je        near ptr M05_L46
       mov       rcx,r12
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-54],eax
       mov       rcx,[rbp-108]
       mov       edx,[rcx+10]
       mov       [rbp-58],edx
       mov       rcx,[rbp-108]
       mov       r8d,[rcx+14]
       mov       [rbp-5C],r8d
       mov       rcx,[rbp-108]
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       xor       edx,edx
       mov       [rsp+28],edx
       mov       [rsp+20],eax
       mov       edx,[rbp-54]
       mov       r8d,[rbp-58]
       mov       r9d,[rbp-5C]
       mov       rcx,[rbp-110]
       call      qword ptr [7FFC033AFDB0]
       mov       ecx,[rbp-0BC]
       jmp       near ptr M05_L11
M05_L45:
       mov       rcx,r12
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp-0BC]
       mov       [rbp-44],eax
       mov       rcx,r13
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-100]
       mov       r8d,r12d
       mov       r9d,[rbp-44]
       mov       edx,3
       call      qword ptr [7FFC03A94000]
       cmp       dword ptr [rbp-40],0
       jne       near ptr M05_L12
       mov       eax,[rbp-0BC]
       mov       [rbp-48],eax
       mov       rcx,r13
       call      qword ptr [7FFC0319CE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       dword ptr [rsp+28],1
       mov       edx,r12d
       mov       r8d,[rbp-48]
       mov       rcx,[rbp-100]
       call      qword ptr [7FFC033AFDB0]
       jmp       near ptr M05_L12
M05_L46:
       mov       ecx,[rbp-0BC]
       jmp       near ptr M05_L11
M05_L47:
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M05_L12
M05_L48:
       mov       r14,[rbp-0E0]
       mov       rcx,[r14+30]
       test      rcx,rcx
       je        short M05_L49
       mov       r11,7FFC02C31A50
       call      qword ptr [r11]
M05_L49:
       xor       edx,edx
       mov       [r14+30],rdx
       jmp       near ptr M05_L13
M05_L50:
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFC034EFFA8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       jmp       near ptr M05_L14
M05_L51:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC033AFD38]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFC02C24000
       call      qword ptr [7FFC02CEF210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC030F79D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L52:
       call      qword ptr [7FFC03A963D0]
       int       3
M05_L53:
       mov       ecx,eax
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFC0300CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M05_L08
M05_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       je        short M05_L57
       cmp       qword ptr [rbp-0D8],0
       jne       short M05_L56
       xor       ecx,ecx
       call      qword ptr [7FFC038F7A68]
       int       3
M05_L56:
       mov       rcx,[rbp-0D8]
       call      00007FFC628B6030
       test      eax,eax
       je        short M05_L57
       mov       ecx,eax
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FFC0300CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M05_L57:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-4C],0
       je        short M05_L61
       mov       rax,[rbp-108]
       add       rax,1C
       mov       rbx,rax
       mov       ecx,[rbx]
       test      ecx,80000000
       je        short M05_L58
       and       ecx,0FFFFFFFE
       mov       [rbx],ecx
       jmp       short M05_L61
M05_L58:
       test      dword ptr [rbx],80000000
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M05_L60
       mov       rcx,rbx
       call      qword ptr [7FFC03A963B8]
       test      eax,eax
       jne       short M05_L59
       call      qword ptr [7FFC03A963D0]
       int       3
M05_L59:
       xor       eax,eax
       mov       [rbx],eax
       jmp       short M05_L61
M05_L60:
       and       dword ptr [rbx],0FFFFFFFE
M05_L61:
       add       rsp,38
       ret
; Total bytes of code 2380
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       eax,[rsi+8]
       mov       [rbx+0C],eax
M06_L00:
       pop       rbx
       pop       rsi
       ret
M06_L01:
       xor       eax,eax
       mov       [rbx],rax
       mov       [rbx+8],rax
       jmp       short M06_L00
; Total bytes of code 49
```
```assembly
; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1A8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M07_L00:
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       add       rax,30
       jne       short M07_L00
       mov       [rsp+1A0],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       mov       rbp,[rdx]
       mov       r14d,[rdx+8]
       mov       r15d,[rdx+0C]
       xor       r13d,r13d
       xor       r12d,r12d
       test      rbp,rbp
       je        short M07_L02
       mov       rdx,[rbp]
       test      dword ptr [rdx],80000000
       je        near ptr M07_L05
       lea       r13,[rbp+10]
       mov       r12d,[rbp+8]
M07_L01:
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M07_L06
       add       r13,rax
       mov       r12d,r15d
M07_L02:
       movsxd    rcx,r15d
       test      r15d,r15d
       setg      dl
       movzx     edx,dl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+70],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+30]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+50]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+70]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+120],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C0]
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0E0]
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+100]
       vmovdqu   ymmword ptr [rsp+180],ymm0
       xor       eax,eax
       mov       [rsp+120],eax
       mov       [rsp+128],rcx
       mov       [rsp+130],rax
       mov       [rsp+138],eax
       mov       byte ptr [rsp+13C],0
       mov       [rsp+13D],dl
       mov       [rsp+178],rbp
       mov       [rsp+180],r14d
       mov       [rsp+184],r15d
       mov       [rsp+188],r13
       mov       [rsp+190],r12d
       mov       [rsp+198],rdi
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L04
M07_L03:
       lea       rdx,[rsp+120]
       mov       r8,rsi
       call      qword ptr [7FFC0380D9F8]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       nop
       vzeroupper
       add       rsp,1A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L04:
       mov       rcx,rbx
       mov       rdx,7FFC038D62E0
       call      qword ptr [7FFC02CEF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L03
M07_L05:
       lea       rdx,[rsp+20]
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rsp+20]
       mov       r12d,[rsp+28]
       jmp       near ptr M07_L01
M07_L06:
       call      qword ptr [7FFC02F1F1B0]
       int       3
; Total bytes of code 558
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
; MessagePack.SequencePool.Rent()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rdx,[rcx+8]
       mov       [rbp-20],rdx
       xor       eax,eax
       mov       [rbp-14],eax
       test      rdx,rdx
       je        short M09_L01
       mov       rcx,rdx
       call      00007FFC627F9E20
       test      eax,eax
       je        short M09_L02
M09_L00:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       edx,[rax+10]
       test      edx,edx
       jle       short M09_L08
       dec       edx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M09_L03
       inc       dword ptr [rax+14]
       mov       [rax+10],edx
       mov       eax,edx
       mov       rbx,[r8+rax*8+10]
       mov       eax,edx
       mov       edx,r10d
       cmp       rax,rdx
       jae       short M09_L04
       xor       edx,edx
       mov       [r8+rax*8+10],rdx
       jmp       short M09_L05
M09_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC038F7A68]
       int       3
M09_L02:
       mov       rcx,[rbp-20]
       call      qword ptr [7FFC03007FA8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M09_L00
M09_L03:
       mov       rcx,rax
       call      qword ptr [7FFC03A94EA0]
       int       3
M09_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L05:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       jne       short M09_L09
M09_L06:
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rbx
M09_L07:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M09_L08:
       call      M09_L13
       jmp       short M09_L10
M09_L09:
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC0300CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M09_L06
M09_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M09_L11
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.MemoryPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC0380D038]
       jmp       short M09_L12
M09_L11:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC0380D050]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]]..ctor(System.Buffers.ArrayPool`1<Byte>)
M09_L12:
       mov       dword ptr [rsi+30],8000
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rsi
       jmp       near ptr M09_L07
M09_L13:
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M09_L15
       cmp       qword ptr [rbp-20],0
       jne       short M09_L14
       xor       ecx,ecx
       call      qword ptr [7FFC038F7A68]
       int       3
M09_L14:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       je        short M09_L15
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC0300CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M09_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        near ptr M10_L12
       xor       edx,edx
       mov       [rsp+38],rdx
       test      esi,esi
       je        near ptr M10_L13
       mov       rcx,[rbx+28]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M10_L01
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M10_L15
       mov       eax,[rdx+8]
M10_L00:
       sub       eax,[rdi+3C]
       jo        near ptr M10_L29
       cmp       eax,esi
       jge       short M10_L03
M10_L01:
       mov       ecx,[rbx+30]
       cmp       ecx,esi
       cmovl     ecx,esi
       mov       [rsp+3C],ecx
M10_L02:
       mov       byte ptr [rsp+38],1
M10_L03:
       cmp       byte ptr [rsp+38],0
       je        near ptr M10_L10
       mov       rcx,[rbx+8]
       mov       eax,[rcx+10]
       test      eax,eax
       jle       near ptr M10_L17
       dec       eax
       mov       rdx,[rcx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M10_L18
       inc       dword ptr [rcx+14]
       mov       [rcx+10],eax
       mov       ecx,eax
       mov       rsi,[rdx+rcx*8+10]
       mov       ecx,eax
       cmp       rcx,r8
       jae       near ptr M10_L28
       mov       ecx,eax
       xor       eax,eax
       mov       [rdx+rcx*8+10],rax
M10_L04:
       mov       rdi,rsi
       mov       rbp,[rbx+18]
       test      rbp,rbp
       je        near ptr M10_L23
       cmp       byte ptr [rsp+38],0
       je        near ptr M10_L19
       cmp       dword ptr [rsp+3C],0FFFFFFFF
       je        near ptr M10_L20
       mov       edx,[rsp+3C]
M10_L05:
       mov       rcx,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [rbp],rcx
       jne       near ptr M10_L21
       mov       rcx,rbp
       call      qword ptr [7FFC036264D8]; System.Buffers.ConfigurableArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       r14,rax
M10_L06:
       lea       rcx,[rdi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M10_L22
       mov       rdx,r14
       mov       ebp,[rdx+8]
M10_L07:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+20],eax
       mov       [rdi+24],ebp
M10_L08:
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M10_L11
       mov       rdx,rcx
       mov       eax,[rdx+3C]
       sub       eax,[rdx+38]
       jo        near ptr M10_L29
       test      eax,eax
       jle       near ptr M10_L24
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0380D2F0]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].SetNext(SequenceSegment<Byte>)
M10_L09:
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M10_L10:
       mov       rax,[rbx+28]
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L11:
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L10
M10_L12:
       mov       ecx,1C1
       mov       rdx,7FFC035D5C50
       call      qword ptr [7FFC02CEF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC0380D278]
       int       3
M10_L13:
       mov       rdi,[rbx+28]
       test      rdi,rdi
       je        short M10_L14
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0380D1D0]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_WritableBytes()
       test      eax,eax
       jne       near ptr M10_L03
M10_L14:
       mov       dword ptr [rsp+3C],0FFFFFFFF
       jmp       near ptr M10_L02
M10_L15:
       mov       rcx,[rdi+30]
       test      rcx,rcx
       jne       short M10_L16
       xor       eax,eax
       jmp       near ptr M10_L00
M10_L16:
       lea       rdx,[rsp+28]
       mov       r11,7FFC02C31880
       call      qword ptr [r11]
       mov       eax,[rsp+34]
       jmp       near ptr M10_L00
M10_L17:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       jmp       near ptr M10_L04
M10_L18:
       call      qword ptr [7FFC03A94EA0]
       int       3
M10_L19:
       call      qword ptr [7FFC03315ED8]
       int       3
M10_L20:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[7FFC02C2B1C8]
       jmp       near ptr M10_L05
M10_L21:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M10_L06
M10_L22:
       xor       edx,edx
       xor       ebp,ebp
       jmp       near ptr M10_L07
M10_L23:
       mov       rbp,[rbx+10]
       lea       rcx,[rsp+38]
       call      qword ptr [7FFC0331EE08]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0380D248]
       jmp       near ptr M10_L08
M10_L24:
       mov       rsi,[rbx+20]
       cmp       [rbx+20],rcx
       jne       short M10_L26
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L27
M10_L25:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
M10_L26:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       cmp       rax,[rbx+28]
       jne       short M10_L25
M10_L27:
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0380D2F0]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].SetNext(SequenceSegment<Byte>)
       mov       rdx,[rbx+28]
       mov       rcx,rbx
       call      qword ptr [7FFC0380D320]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].RecycleAndGetNext(SequenceSegment<Byte>)
       jmp       near ptr M10_L09
M10_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M10_L29:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 781
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M11_L02
M11_L00:
       cmp       rcx,rdx
       je        near ptr M11_L13
M11_L01:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M11_L02:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M11_L00
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M11_L06
       cmp       r8,40
       jbe       short M11_L03
       cmp       r8,800
       ja        short M11_L01
       jmp       near ptr M11_L10
M11_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M11_L08
M11_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M11_L05:
       vzeroupper
       ret
M11_L06:
       test      r8b,18
       je        short M11_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M11_L05
M11_L07:
       test      r8b,4
       je        short M11_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M11_L05
M11_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M11_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M11_L04
M11_L09:
       test      r8,r8
       je        short M11_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M11_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M11_L05
M11_L10:
       cmp       r8,100
       jb        short M11_L11
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
M11_L11:
       mov       r9,r8
       shr       r9,6
M11_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M11_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M11_L03
       jmp       near ptr M11_L04
M11_L13:
       cmp       [rdx],dl
       jmp       near ptr M11_L05
; Total bytes of code 320
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M12_L00
       cmp       [rdx],rcx
       jne       short M12_L01
M12_L00:
       mov       rax,rdx
       ret
M12_L01:
       jmp       qword ptr [7FFC02F14D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F0F1080008
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
       call      qword ptr [7FFC038FDC20]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,240
       add       rax,0FFFFFFFFFFFFFFF8
       mov       edx,ecx
       and       edx,0FFFFFF
       mov       r8d,edx
       mov       r10d,ecx
       sar       r10d,18
       jne       short M14_L01
       cmp       [rax],edx
       jle       short M14_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M14_L03
M14_L00:
       ret
M14_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M14_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M14_L00
M14_L02:
       cmp       [rax+4],r8d
       jle       short M14_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M14_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M14_L03
       jmp       short M14_L00
M14_L03:
       jmp       qword ptr [7FFC02CED4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        short M16_L00
       mov       rcx,7FFC03983C8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,[rbx+8]
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r8d,esi
       mov       rdx,[rbx]
       lea       rcx,[rdi+10]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,7FFC03983C88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,1F0F1086EF8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 115
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M17_L01
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M17_L02
       lea       rdi,[rcx+10]
       mov       ebp,[rcx+8]
M17_L00:
       mov       eax,[rbx+8]
       and       eax,7FFFFFFF
       mov       ecx,[rbx+0C]
       mov       edx,ecx
       add       rdx,rax
       mov       r8d,ebp
       cmp       rdx,r8
       ja        short M17_L03
       add       rdi,rax
       mov       ebp,ecx
M17_L01:
       mov       [rsi],rdi
       mov       [rsi+8],ebp
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M17_L02:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+28]
       mov       ebp,[rsp+30]
       jmp       short M17_L00
M17_L03:
       call      qword ptr [7FFC02F1F1B0]
       int       3
; Total bytes of code 131
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       sub       rsp,28
       mov       rax,rdx
       mov       r8d,[rcx+8]
       cmp       r8d,[rax+8]
       ja        short M18_L00
       mov       rdx,[rcx]
       mov       rcx,[rax]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
M18_L00:
       call      qword ptr [7FFC0319C768]
       int       3
; Total bytes of code 42
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ClonePersonRecordRecord()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E8
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+1E0],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L16
M00_L02:
       mov       rcx,20D31000AC8
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L17
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+118],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+0D8]
       vmovdqu   ymmword ptr [rsp+190],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0F8]
       vmovdqu   ymmword ptr [rsp+1B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+118]
       vmovdqu   xmmword ptr [rsp+1D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+188]
       vmovdqu   ymmword ptr [rsp+128],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1A8]
       vmovdqu   ymmword ptr [rsp+148],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1C8]
       vmovdqu   ymmword ptr [rsp+168],ymm0
       mov       byte ptr [rsp+128],0
       xor       eax,eax
       mov       [rsp+130],rax
       mov       [rsp+138],rdx
       mov       [rsp+140],rax
       mov       [rsp+148],eax
       mov       [rsp+150],rcx
       mov       [rsp+158],r8d
       mov       [rsp+160],rdi
       mov       [rsp+168],eax
       mov       [rsp+16C],r8d
       mov       [rsp+180],rax
       lea       rdx,[rsp+128]
       mov       r8,rsi
       mov       rcx,7FFC03633650
       call      qword ptr [7FFC0354D1D0]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+138],0
       jne       near ptr M00_L19
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0C8],xmm0
       mov       rdx,[rsp+178]
       test      rdx,rdx
       je        near ptr M00_L22
       mov       esi,[rsp+148]
       test      esi,esi
       jle       near ptr M00_L06
       cmp       qword ptr [rsp+138],0
       jne       near ptr M00_L10
M00_L04:
       mov       ecx,esi
       add       rcx,[rsp+140]
       jo        near ptr M00_L40
       mov       [rsp+140],rcx
       xor       ecx,ecx
       mov       [rsp+148],ecx
       mov       rdi,[rsp+130]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rdi],rcx
       jne       near ptr M00_L32
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        near ptr M00_L27
       add       esi,[rcx+3C]
       jo        near ptr M00_L40
       mov       edx,esi
       mov       eax,[rcx+24]
       cmp       edx,eax
       jg        near ptr M00_L28
       mov       [rcx+3C],esi
       cmp       byte ptr [rdi+34],0
       je        short M00_L05
       cmp       dword ptr [rdi+30],8000
       jl        near ptr M00_L29
M00_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
M00_L06:
       mov       rdx,[rsp+178]
       cmp       [rdx],dl
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFC0354E808]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+0B0]
       mov       rsi,[rsp+0B8]
       mov       edi,[rsp+0C0]
       and       edi,7FFFFFFF
       mov       ebp,[rsp+0C4]
       and       ebp,7FFFFFFF
       cmp       rdx,rsi
       jne       near ptr M00_L13
       sub       ebp,edi
       movsxd    rdx,ebp
M00_L07:
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       rdx,[rsp+0B0]
       cmp       rdx,[rsp+0B8]
       je        near ptr M00_L33
       mov       [rsp+30],rdi
       mov       [rsp+38],ebp
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFC037EDD70]; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
M00_L08:
       mov       rcx,[rsp+170]
       mov       rdx,[rsp+178]
       test      rcx,rcx
       je        short M00_L09
       call      qword ptr [7FFC037EDEF0]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+48]
       mov       rdx,rsi
       call      qword ptr [7FFC03A65FE0]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,[rsp+48]
       mov       ecx,[rsp+50]
       mov       r8d,[rsp+54]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       mov       [rsp+2C],r8d
       lea       rdx,[rsp+20]
       mov       rcx,7FFC038AF190
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354D170]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,7FFC038C3558
       cmp       [rcx],ecx
       call      qword ptr [7FFC037EEE38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,1E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L10:
       lea       rdx,[rsp+170]
       mov       rcx,[rsp+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0354E790]; MessagePack.SequencePool.Rent()
       mov       rcx,[rsp+178]
       mov       [rsp+130],rcx
       mov       rcx,[rsp+130]
       mov       rdx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rcx],rdx
       jne       near ptr M00_L23
       mov       edx,[rsp+148]
       call      qword ptr [7FFC037ED7E8]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       mov       rcx,rax
       lea       rdx,[rsp+0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037ED800]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_RemainingSpan()
M00_L11:
       mov       r8,[rsp+160]
       mov       ecx,[rsp+168]
       mov       edx,[rsp+16C]
       mov       eax,[rsp+148]
       cmp       eax,edx
       ja        near ptr M00_L24
       test      r8,r8
       je        near ptr M00_L25
       mov       edx,eax
       add       rdx,rcx
       mov       r10d,[r8+8]
       cmp       rdx,r10
       ja        near ptr M00_L26
       lea       rdx,[r8+rcx+10]
M00_L12:
       mov       rcx,[rsp+0A0]
       mov       r8d,[rsp+0A8]
       cmp       eax,r8d
       jg        near ptr M00_L39
       mov       r8d,eax
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       xor       ecx,ecx
       mov       [rsp+138],rcx
       jmp       near ptr M00_L04
M00_L13:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    rdx,ebp
       add       rdx,[rax+10]
       movsxd    rcx,edi
       add       rcx,[r14+10]
       sub       rdx,rcx
       jmp       near ptr M00_L07
M00_L14:
       call      qword ptr [7FFC032EE700]
       mov       ecx,3
       mov       rdx,7FFC03144600
       call      qword ptr [7FFC02CBF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03015630
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03144600
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC035444B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC035444C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       ecx,0E
       call      qword ptr [7FFC0354D218]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L16:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,0E
       call      qword ptr [7FFC0354D218]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,20D31000AF8
       mov       rbp,[rcx]
       mov       rcx,20D31000AC8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC030C71B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       rdx,[rsp+160]
       mov       ecx,[rsp+168]
       mov       eax,[rsp+16C]
       mov       r8d,[rsp+148]
       cmp       r8d,eax
       ja        near ptr M00_L24
       test      rdx,rdx
       jne       short M00_L20
       or        ecx,r8d
       jne       near ptr M00_L26
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L21
M00_L20:
       mov       eax,ecx
       mov       r10d,r8d
       add       rax,r10
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        near ptr M00_L26
       mov       ecx,ecx
       lea       rdx,[rdx+rcx+10]
M00_L21:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC0316C0D8]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC031674B0]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       mov       rsi,rax
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0F1C
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC02CBF228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       lea       rdx,[rsp+0A0]
       mov       r8d,[rsp+148]
       mov       r11,7FFC02C01960
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L24:
       mov       ecx,28
       call      qword ptr [7FFC02CBF348]
       int       3
M00_L25:
       or        ecx,eax
       jne       short M00_L26
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M00_L12
M00_L26:
       call      qword ptr [7FFC02EEF1B0]
       int       3
M00_L27:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,171
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC030C7900]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       mov       ecx,1078
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC037ED8D8]
       int       3
M00_L29:
       lea       rcx,[rsp+88]
       mov       rdx,rdi
       call      qword ptr [7FFC0354E808]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+88]
       mov       rsi,[rsp+90]
       mov       ebp,[rsp+98]
       and       ebp,7FFFFFFF
       mov       r14d,[rsp+9C]
       and       r14d,7FFFFFFF
       cmp       rdx,rsi
       je        short M00_L30
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r14,r14d
       add       r14,[rax+10]
       movsxd    rcx,ebp
       add       rcx,[r15+10]
       sub       r14,rcx
       jmp       short M00_L31
M00_L30:
       sub       r14d,ebp
       movsxd    r14,r14d
M00_L31:
       mov       rcx,r14
       shr       rcx,3F
       add       rcx,r14
       sar       rcx,1
       mov       edx,7FFFFFFF
       cmp       rcx,7FFFFFFF
       cmovl     rdx,rcx
       movsxd    rcx,edx
       cmp       rdx,rcx
       jne       near ptr M00_L40
       mov       ecx,8000
       cmp       edx,8000
       cmovl     ecx,edx
       cmp       [rdi+30],ecx
       jge       near ptr M00_L05
       mov       [rdi+30],ecx
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFC02C01958
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L33:
       mov       r8,[rsp+0B0]
       test      r8,r8
       jne       short M00_L34
       xor       edx,edx
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M00_L37
M00_L34:
       mov       r14d,[rsp+0C0]
       mov       r15d,[rsp+0C4]
       cmp       r8,[rsp+0B8]
       setne     r9b
       movzx     r9d,r9b
       mov       edx,r14d
       or        edx,r15d
       jl        short M00_L36
       mov       rdx,r8
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rax+18]
       mov       r8d,[rax+20]
       mov       ecx,[rax+24]
       sub       r15d,r14d
       mov       eax,r14d
       mov       r10d,r15d
       add       rax,r10
       cmp       rax,rcx
       jbe       short M00_L35
       mov       ecx,21
       call      qword ptr [7FFC02CBF348]
       int       3
M00_L35:
       add       r8d,r14d
       jmp       short M00_L37
M00_L36:
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFC038D7930]
       mov       rdx,[rsp+58]
       mov       r8d,[rsp+60]
       mov       r15d,[rsp+64]
M00_L37:
       mov       [rsp+78],rdx
       mov       [rsp+80],r8d
       mov       [rsp+84],r15d
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       call      qword ptr [7FFC0339F7C8]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       mov       r14d,[rsp+70]
       cmp       r14d,ebp
       jle       short M00_L38
       mov       ecx,6
       call      qword ptr [7FFC037EDE78]
       int       3
M00_L38:
       mov       r8d,r14d
       mov       rcx,rdi
       mov       rdx,[rsp+68]
       call      qword ptr [7FFC032EE028]
       jmp       near ptr M00_L08
M00_L39:
       call      qword ptr [7FFC0316C738]
       int       3
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2379
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rbx,rbx
       je        near ptr M01_L66
M01_L00:
       mov       rdi,rbx
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L67
M01_L01:
       cmp       dword ptr [rdi+20],0
       jne       near ptr M01_L39
M01_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M01_L22
M01_L03:
       mov       rax,[rcx+18]
       mov       r15,[rax+18]
       test      r15,r15
       je        near ptr M01_L23
M01_L04:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFC0354E6D0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L64
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rsi
       call      qword ptr [7FFC02EE61C0]; System.Object.GetType()
       mov       r15,rax
       mov       rbx,r15
       mov       rcx,24DAFF627E0
       cmp       rbx,rcx
       je        near ptr M01_L49
       mov       rcx,20D31000D60
       mov       r14,[rcx]
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L08
       mov       r13,[r14+18]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r11,7FFC02C019B8
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rdx,[r14+8]
       mov       ecx,r12d
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L61
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r14,[r14+10]
       xor       eax,eax
       mov       [rbp-0E4],eax
       dec       edx
       mov       r10d,[r14+8]
       mov       [rbp-0E8],r10d
       cmp       r10d,edx
       jbe       short M01_L08
M01_L05:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r14+rdx*8+10]
       mov       [rbp-118],r9
       cmp       [r9+8],r12d
       jne       short M01_L06
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rbx
       mov       r11,7FFC02C019C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-118]
       jne       short M01_L07
M01_L06:
       mov       edx,[r9+0C]
       mov       eax,[rbp-0E4]
       inc       eax
       mov       r10d,[rbp-0E8]
       cmp       r10d,eax
       jb        near ptr M01_L24
       cmp       r10d,edx
       mov       [rbp-0E4],eax
       jbe       short M01_L08
       jmp       short M01_L05
M01_L07:
       add       r9,10
       test      r9,r9
       jne       short M01_L12
M01_L08:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M01_L52
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L51
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L09:
       test      eax,eax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L53
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L54
M01_L11:
       test      rax,rax
       je        short M01_L15
M01_L12:
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L50
       xor       eax,eax
M01_L13:
       test      rax,rax
       jne       short M01_L15
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L55
M01_L14:
       test      rax,rax
       je        near ptr M01_L56
M01_L15:
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L57
       mov       rcx,20D31000D20
       mov       rcx,[rcx]
       mov       r13,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L25
M01_L16:
       mov       ecx,[r13+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L60
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L61
       mov       ecx,edx
       mov       rcx,[r13+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L17:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L58
       mov       r13,[rcx+18]
M01_L18:
       mov       rdx,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L59
       mov       rcx,20D31000D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L27
M01_L19:
       mov       edx,[r14+8]
       mov       ecx,edx
       sub       ecx,1
       jo        near ptr M01_L60
       and       ecx,eax
       cmp       ecx,edx
       jae       near ptr M01_L61
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       test      rdx,rdx
       je        near ptr M01_L28
M01_L20:
       cmp       [rdx+10],rbx
       jne       near ptr M01_L62
       mov       r14,[rdx+18]
M01_L21:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r8,[rbp+18]
       mov       r9,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M01_L65
M01_L22:
       mov       rdx,7FFC03640900
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L03
M01_L23:
       mov       rdx,7FFC03640920
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFC02CBF480]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFC02EE7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L16
M01_L26:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20D31000D28
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FFC02F21C80]; Precode of System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r13,rax
       mov       rcx,24DAFF73B98
       mov       rdx,24DAFF73BC0
       call      qword ptr [7FFC0354EE20]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFC0354F048]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo)
       mov       r13,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-120],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-120]
       mov       [rsp+20],r12
       mov       rdx,r13
       mov       rcx,7FFC03650918
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354F750]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0354EE80]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r13,rax
       mov       rcx,20D31000D20
       mov       rcx,[rcx]
       mov       rdx,rbx
       mov       r8,r13
       call      qword ptr [7FFC0354EE98]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       near ptr M01_L18
M01_L27:
       mov       rcx,rbx
       call      qword ptr [7FFC02EE7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L19
M01_L28:
       mov       rdx,20D31000D50
       mov       rcx,[rdx]
       mov       [rbp-0F0],rcx
       mov       byte ptr [rbp-0E0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CB5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,20D31000D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ecx,[r14+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L34
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L35
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M01_L32
M01_L29:
       cmp       [rcx+10],rbx
       jne       short M01_L31
       mov       r14,[rcx+18]
       mov       ecx,1
M01_L30:
       test      ecx,ecx
       jne       near ptr M01_L38
       jmp       short M01_L33
M01_L31:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L29
M01_L32:
       xor       r14d,r14d
       xor       ecx,ecx
       jmp       short M01_L30
M01_L33:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,24DAFF73AF8
       call      qword ptr [7FFC02BFA5B8]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       r14,rax
       mov       rcx,24DAFF627E0
       mov       rdx,24DAFF73B20
       call      qword ptr [7FFC0354EE20]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-0F8],rax
       mov       rdx,24DAFF73B48
       mov       [rbp-138],rdx
       mov       rcx,rdx
       call      qword ptr [7FFC02BFA5B0]; Precode of System.RuntimeType.MakeByRefType()
       mov       rcx,rax
       mov       rdx,24DAFF67EC8
       call      qword ptr [7FFC0354EE20]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-100],rax
       mov       rcx,24DAFF627E0
       mov       rdx,24DAFF61640
       call      qword ptr [7FFC0354EE20]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-108],rax
       mov       r8,24DAFF73278
       mov       [rbp-140],r8
       mov       rcx,r8
       mov       rdx,24DAFF6A148
       call      qword ptr [7FFC0354EE20]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-110],rax
       mov       rcx,r12
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC02BFA5B0]; Precode of System.RuntimeType.MakeByRefType()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-140]
       mov       [r12+20],rbx
       mov       rcx,r14
       mov       r8,r12
       mov       rdx,24DAFF73B70
       call      qword ptr [7FFC0354D938]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(System.Type, System.String, System.Type[])
       mov       rbx,rax
       mov       rcx,[rbp-0F8]
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC0366D110]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       mov       r14,rax
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M01_L36
       mov       rcx,[rbp-108]
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFC0366D110]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       jmp       short M01_L37
M01_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L36:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       call      qword ptr [7FFC0354EE50]
M01_L37:
       mov       r12,[rbp-110]
       mov       [rsp+20],r12
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,[rbp-100]
       mov       r9,rax
       call      qword ptr [7FFC0354EE68]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression)
       mov       rbx,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],r14
       mov       rdx,rbx
       mov       rcx,7FFC0370C8D8
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354F750]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0354EE80]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r14,rax
       mov       rcx,20D31000D50
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFC0354EE98]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       nop
M01_L38:
       cmp       byte ptr [rbp-0E0],0
       je        near ptr M01_L21
       jmp       near ptr M01_L63
M01_L39:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L40
       jmp       short M01_L41
M01_L40:
       mov       rdx,7FFC03640B68
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L41:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L02
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0354E790]; MessagePack.SequencePool.Rent()
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FFC0354E7C0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rdx,7FFC03640900
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L43:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L45
       jmp       short M01_L46
M01_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L45:
       mov       rdx,7FFC03640920
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L46:
       mov       rdx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFC0354E6D0]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r14]
       mov       esi,[rbp-0A0]
       test      esi,esi
       jle       short M01_L47
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFC037ED620]; MessagePack.BufferWriter.MigrateToSequence()
       mov       ecx,esi
       add       rcx,[rbp-0A8]
       jo        short M01_L44
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,esi
       mov       r11,7FFC02C019A0
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L47:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0354E808]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       r9d,[rbx+24]
       mov       r8d,[rbx+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC0354E838]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L65
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC037EDEF0]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
       jmp       near ptr M01_L65
M01_L48:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC0354EDA8]
       jmp       near ptr M01_L65
M01_L49:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FFC03A66328]
       jmp       near ptr M01_L65
M01_L50:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L13
M01_L51:
       mov       rcx,r15
       mov       rdx,24DAFF66C10
       call      qword ptr [7FFC02BFA608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L09
M01_L52:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L53:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L10
M01_L54:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L11
M01_L55:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L14
M01_L56:
       mov       rcx,20D31000D58
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFC03638A80]
       jmp       near ptr M01_L65
M01_L57:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1FB
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC030C71B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L17
       jmp       near ptr M01_L26
M01_L59:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC0354E910]
       int       3
M01_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L62:
       mov       rdx,[rdx+8]
       test      rdx,rdx
       jne       near ptr M01_L20
       jmp       near ptr M01_L28
M01_L63:
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CB6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M01_L21
M01_L64:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r15]
       nop
M01_L65:
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
M01_L66:
       call      qword ptr [7FFC0354D230]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rbx,rax
       jmp       near ptr M01_L00
M01_L67:
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC030C4C60]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L01
       sub       rsp,28
       cmp       qword ptr [rbp-128],0
       je        short M01_L68
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC037EDEF0]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
M01_L68:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-0E0],0
       je        short M01_L69
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CB6820]; System.Threading.Monitor.Exit(System.Object)
M01_L69:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,812
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02BFA310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02EE5470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC0354E868]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,28
       ret
; Total bytes of code 3037
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rdx+20]
       test      rcx,rcx
       je        short M02_L03
       mov       r8,[rdx+28]
       test      r8,r8
       je        short M02_L03
       mov       edx,[rcx+38]
       mov       eax,[r8+3C]
       cmp       rcx,r8
       je        short M02_L00
       mov       r10,[rcx+10]
       cmp       r10,[r8+10]
       jg        short M02_L05
M02_L00:
       mov       r10d,[rcx+24]
       cmp       r10d,edx
       jb        short M02_L05
       mov       r10d,[r8+24]
       cmp       r10d,eax
       jb        short M02_L05
       cmp       rcx,r8
       je        short M02_L04
M02_L01:
       mov       [rbx],rcx
       mov       [rbx+8],r8
       mov       [rbx+10],edx
       mov       [rbx+14],eax
M02_L02:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L03:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,20D31001910
       mov       rax,[rax]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rax+18]
       mov       [rbx+10],rcx
       jmp       short M02_L02
M02_L04:
       cmp       eax,edx
       jge       short M02_L01
M02_L05:
       call      qword ptr [7FFC03A653B0]
       int       3
; Total bytes of code 151
```
```assembly
; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       mov       rdx,[rbx]
       mov       rbp,[rbx+8]
       mov       r14d,[rbx+10]
       and       r14d,7FFFFFFF
       mov       r15d,r14d
       mov       r13d,[rbx+14]
       and       r13d,7FFFFFFF
       cmp       rdx,rbp
       jne       near ptr M03_L03
       sub       r13d,r15d
       movsxd    r13,r13d
M03_L00:
       mov       edx,edi
       cmp       r13,rdx
       jg        near ptr M03_L11
       mov       rbp,[rbx]
M03_L01:
       xor       r15d,r15d
       test      rbp,rbp
       je        near ptr M03_L12
       mov       edx,[rbx+10]
       sar       edx,1F
       mov       r13d,[rbx+14]
       mov       ecx,r13d
       sar       ecx,1F
       lea       edx,[rcx+rdx*2]
       mov       r12d,edx
       neg       r12d
       mov       rax,[rbx+8]
       mov       [rsp+20],rax
       and       r13d,7FFFFFFF
       test      r12d,r12d
       jne       near ptr M03_L13
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,[rsp+20]
       cmp       rax,r12
       jne       near ptr M03_L09
       mov       rcx,[r12+18]
       mov       ebp,[r12+20]
       mov       r12d,[r12+24]
       sub       r13d,r14d
       mov       eax,r14d
       mov       edx,r13d
       add       rdx,rax
       mov       eax,r12d
       cmp       rdx,rax
       jbe       short M03_L04
M03_L02:
       mov       ecx,21
       call      qword ptr [7FFC02CBF348]
       int       3
M03_L03:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r13,r13d
       add       r13,[rax+10]
       movsxd    rdx,r15d
       add       rdx,[r12+10]
       sub       r13,rdx
       jmp       near ptr M03_L00
M03_L04:
       add       r14d,ebp
M03_L05:
       mov       edx,1
M03_L06:
       mov       rbp,r15
       xor       eax,eax
       xor       r15d,r15d
       test      dl,dl
       je        near ptr M03_L10
       xor       edx,edx
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L08
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M03_L17
       lea       rdx,[rcx+10]
       mov       r12d,[rcx+8]
M03_L07:
       and       r14d,7FFFFFFF
       mov       r8d,r14d
       mov       ecx,r13d
       add       rcx,r8
       mov       eax,r12d
       cmp       rcx,rax
       ja        near ptr M03_L20
       add       rdx,r8
       mov       r12d,r13d
M03_L08:
       cmp       r12d,edi
       ja        near ptr M03_L19
       mov       r8d,r12d
       mov       rcx,rsi
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       test      rbp,rbp
       je        short M03_L10
       mov       ecx,r12d
       add       rsi,rcx
       sub       edi,r12d
       mov       r14d,r15d
       jmp       near ptr M03_L01
M03_L09:
       mov       r15,[rax+8]
       test      r15,r15
       je        near ptr M03_L18
       mov       rcx,[rax+18]
       mov       ebp,[rax+20]
       mov       r12d,[rax+24]
       cmp       r14d,r12d
       ja        near ptr M03_L02
       lea       edx,[r14+rbp]
       sub       r12d,r14d
       mov       r13d,r12d
       mov       r14d,edx
       jmp       near ptr M03_L05
M03_L10:
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
M03_L11:
       mov       ecx,6
       call      qword ptr [7FFC037EDE78]
       int       3
M03_L12:
       xor       ecx,ecx
       xor       r14d,r14d
       xor       r13d,r13d
       xor       edx,edx
       jmp       near ptr M03_L06
M03_L13:
       mov       rax,[rsp+20]
       cmp       rbp,rax
       jne       near ptr M03_L18
       cmp       r12d,1
       jne       short M03_L16
       mov       rdx,rax
       mov       rcx,offset MT_System.Byte[]
       call      qword ptr [7FFC02CB58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       sub       r13d,r14d
       test      rax,rax
       jne       short M03_L14
       mov       ecx,r14d
       or        ecx,r13d
       jne       near ptr M03_L20
       xor       ecx,ecx
       xor       r12d,r12d
       xor       r13d,r13d
       jmp       short M03_L15
M03_L14:
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rax+8]
       cmp       rdx,rcx
       ja        near ptr M03_L20
       mov       rcx,rax
       mov       r12d,r14d
M03_L15:
       mov       r14d,r12d
       jmp       near ptr M03_L05
M03_L16:
       mov       rdx,rax
       mov       rcx,offset MT_System.Buffers.MemoryManager<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       lea       rdx,[rsp+38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       sub       r13d,r14d
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rsp+44]
       cmp       rdx,rcx
       ja        short M03_L20
       mov       rcx,[rsp+38]
       add       r14d,[rsp+40]
       jmp       near ptr M03_L05
M03_L17:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,[rsp+28]
       mov       r12d,[rsp+30]
       jmp       near ptr M03_L07
M03_L18:
       call      qword ptr [7FFC03A652A8]
       int       3
M03_L19:
       call      qword ptr [7FFC0316C738]
       int       3
M03_L20:
       call      qword ptr [7FFC02EEF1B0]
       int       3
; Total bytes of code 764
```
```assembly
; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
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
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rbx+20]
       test      rdi,rdi
       jne       near ptr M04_L15
M04_L00:
       xor       ecx,ecx
       mov       [rbx+28],rcx
       mov       [rbx+20],rcx
       mov       rcx,[rsi+8]
       mov       [rbp-70],rcx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M04_L02
M04_L01:
       test      dword ptr [rax],80000000
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L20
       mov       [rbp-90],rax
       mov       rcx,rax
       call      qword ptr [7FFC03A66028]
       test      eax,eax
       je        near ptr M04_L28
       xor       ecx,ecx
       mov       rax,[rbp-90]
       mov       [rax],ecx
       jmp       near ptr M04_L10
M04_L02:
       cmp       qword ptr [rbp-70],0
       je        short M04_L04
       mov       rcx,[rbp-70]
       call      00007FFC627F9E20
       test      eax,eax
       je        short M04_L05
M04_L03:
       mov       dword ptr [rbp-3C],1
       mov       rdi,[rsi+8]
       mov       r14d,[rdi+10]
       cmp       r14d,[rsi+18]
       jge       short M04_L07
       mov       dword ptr [rbx+30],8000
       mov       rcx,[rdi+8]
       cmp       [rcx+8],r14d
       jbe       short M04_L06
       mov       edx,r14d
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rdi+14]
       inc       r14d
       mov       [rdi+10],r14d
       jmp       short M04_L07
M04_L04:
       xor       ecx,ecx
       call      qword ptr [7FFC038D7A08]
       int       3
M04_L05:
       mov       rcx,[rbp-70]
       call      qword ptr [7FFC038DCCF0]
       jmp       short M04_L03
M04_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFC036646A8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       nop
M04_L07:
       mov       rcx,[rbp-70]
       call      00007FFC628B6030
       test      eax,eax
       jne       near ptr M04_L29
M04_L08:
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
M04_L09:
       cmp       byte ptr [rbp-50],0
       je        short M04_L10
       mov       rax,[rbp-80]
       add       rax,1C
       mov       ecx,[rax]
       test      ecx,80000000
       je        near ptr M04_L01
       and       ecx,0FFFFFFFE
       mov       [rax],ecx
M04_L10:
       cmp       dword ptr [rbp-54],0
       je        near ptr M04_L21
M04_L11:
       mov       rcx,20D1B000C90
       mov       rax,[rcx]
       mov       [rbp-78],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M04_L22
M04_L12:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M04_L13:
       mov       r15,[rbx+8]
       mov       r13d,[r15+10]
       mov       rcx,[r15+8]
       cmp       [rcx+8],r13d
       jbe       near ptr M04_L26
       mov       edx,r13d
       mov       r8,rdi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r15+14]
       inc       r13d
       mov       [r15+10],r13d
M04_L14:
       mov       rdi,r14
       test      rdi,rdi
       je        near ptr M04_L00
M04_L15:
       mov       rdx,[rdi+8]
       mov       r14,rdx
       test      r14,r14
       je        short M04_L16
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       cmp       [r14],rcx
       jne       near ptr M04_L19
M04_L16:
       mov       r15,[rbx+18]
       mov       eax,[rdi+3C]
       sub       eax,[rdi+38]
       jo        near ptr M04_L31
       xor       eax,eax
       mov       [rdi+18],rax
       mov       [rdi+20],rax
       mov       [rdi+8],rax
       mov       [rdi+10],rax
       mov       [rdi+38],rax
       mov       r13,[rdi+28]
       test      r13,r13
       je        near ptr M04_L24
       mov       rax,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [r15],rax
       jne       near ptr M04_L23
       mov       r12d,[r13+8]
       test      r12d,r12d
       je        near ptr M04_L12
       lea       eax,[r12-1]
       or        eax,0F
       lzcnt     eax,eax
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       r8,[r15+8]
       cmp       [r8+8],eax
       setg      r10b
       movzx     r10d,r10b
       mov       [rbp-40],r10d
       test      r10d,r10d
       je        near ptr M04_L11
       cmp       eax,[r8+8]
       jae       near ptr M04_L30
       mov       rax,[r8+rax*8+10]
       mov       [rbp-80],rax
       mov       rax,[rbp-80]
       cmp       [rax],al
       mov       rax,[rbp-80]
       cmp       r12d,[rax+10]
       jne       near ptr M04_L27
       mov       byte ptr [rbp-50],0
       mov       rcx,[rbp-80]
       add       rcx,1C
       mov       eax,[rcx]
       mov       [rbp-64],eax
       cmp       byte ptr [rbp-50],0
       jne       short M04_L18
       mov       r8d,eax
       and       r8d,80000001
       cmp       r8d,80000000
       jne       short M04_L18
       mov       r8d,eax
       or        r8d,1
       lock cmpxchg [rcx],r8d
       mov       r8d,[rbp-64]
       cmp       eax,r8d
       sete      dl
       movzx     edx,dl
       mov       [rbp-50],edx
       jne       short M04_L18
M04_L17:
       mov       rdx,[rbp-80]
       mov       edx,[rdx+18]
       test      edx,edx
       setne     al
       movzx     eax,al
       mov       [rbp-54],eax
       test      eax,eax
       je        near ptr M04_L09
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+8]
       dec       edx
       mov       r8,[rbp-80]
       mov       [r8+18],edx
       movsxd    rdx,edx
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M04_L09
M04_L18:
       lea       r8,[rbp-50]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03A64F30]
       jmp       short M04_L17
M04_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M04_L16
M04_L20:
       and       dword ptr [rax],0FFFFFFFE
       jmp       near ptr M04_L10
M04_L21:
       mov       rcx,20D1B000C90
       mov       rax,[rcx]
       mov       [rbp-88],rax
       cmp       byte ptr [rax+9D],0
       je        near ptr M04_L11
       mov       rcx,r13
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-58],eax
       mov       rcx,[rbp-80]
       mov       edx,[rcx+10]
       mov       [rbp-5C],edx
       mov       rcx,[rbp-80]
       mov       r8d,[rcx+14]
       mov       [rbp-60],r8d
       mov       rcx,[rbp-80]
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       xor       edx,edx
       mov       [rsp+28],edx
       mov       [rsp+20],eax
       mov       edx,[rbp-58]
       mov       r8d,[rbp-5C]
       mov       r9d,[rbp-60]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFC03444540]
       jmp       near ptr M04_L11
M04_L22:
       mov       rcx,r13
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       [rbp-44],r12d
       mov       rcx,r15
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-78]
       mov       r8d,r13d
       mov       r9d,[rbp-44]
       mov       edx,3
       call      qword ptr [7FFC038DFFC0]
       cmp       dword ptr [rbp-40],0
       jne       near ptr M04_L12
       mov       rcx,r15
       call      qword ptr [7FFC0316CDE0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       dword ptr [rsp+28],1
       mov       edx,r13d
       mov       r8d,r12d
       mov       rcx,[rbp-78]
       call      qword ptr [7FFC03444540]
       jmp       near ptr M04_L12
M04_L23:
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M04_L12
M04_L24:
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M04_L25
       mov       r11,7FFC02C01A58
       call      qword ptr [r11]
M04_L25:
       xor       edx,edx
       mov       [rdi+30],rdx
       jmp       near ptr M04_L13
M04_L26:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFC036646A8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       jmp       near ptr M04_L14
M04_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC034444C8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFC02BF4000
       call      qword ptr [7FFC02CBF210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC030C79A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L28:
       call      qword ptr [7FFC03A66040]
       int       3
M04_L29:
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FFC038DC1F8]
       jmp       near ptr M04_L08
M04_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M04_L33
       cmp       qword ptr [rbp-70],0
       jne       short M04_L32
       xor       ecx,ecx
       call      qword ptr [7FFC038D7A08]
       int       3
M04_L32:
       mov       rcx,[rbp-70]
       call      00007FFC628B6030
       test      eax,eax
       je        short M04_L33
       mov       ecx,eax
       mov       rdx,[rbp-70]
       call      qword ptr [7FFC038DC1F8]
M04_L33:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       byte ptr [rbp-50],0
       je        short M04_L37
       mov       rax,[rbp-80]
       add       rax,1C
       mov       rbx,rax
       mov       ecx,[rbx]
       test      ecx,80000000
       je        short M04_L34
       and       ecx,0FFFFFFFE
       mov       [rbx],ecx
       jmp       short M04_L37
M04_L34:
       test      dword ptr [rbx],80000000
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M04_L36
       mov       rcx,rbx
       call      qword ptr [7FFC03A66028]
       test      eax,eax
       jne       short M04_L35
       call      qword ptr [7FFC03A66040]
       int       3
M04_L35:
       xor       eax,eax
       mov       [rbx],eax
       jmp       short M04_L37
M04_L36:
       and       dword ptr [rbx],0FFFFFFFE
M04_L37:
       add       rsp,38
       ret
; Total bytes of code 1347
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       eax,[rsi+8]
       mov       [rbx+0C],eax
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       xor       eax,eax
       mov       [rbx],rax
       mov       [rbx+8],rax
       jmp       short M05_L00
; Total bytes of code 49
```
```assembly
; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1A8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M06_L00:
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       add       rax,30
       jne       short M06_L00
       mov       [rsp+1A0],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       mov       rbp,[rdx]
       mov       r14d,[rdx+8]
       mov       r15d,[rdx+0C]
       xor       r13d,r13d
       xor       r12d,r12d
       test      rbp,rbp
       je        short M06_L02
       mov       rdx,[rbp]
       test      dword ptr [rdx],80000000
       je        near ptr M06_L05
       lea       r13,[rbp+10]
       mov       r12d,[rbp+8]
M06_L01:
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M06_L06
       add       r13,rax
       mov       r12d,r15d
M06_L02:
       movsxd    rcx,r15d
       test      r15d,r15d
       setg      dl
       movzx     edx,dl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+70],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+30]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+50]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+70]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+120],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C0]
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0E0]
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+100]
       vmovdqu   ymmword ptr [rsp+180],ymm0
       xor       eax,eax
       mov       [rsp+120],eax
       mov       [rsp+128],rcx
       mov       [rsp+130],rax
       mov       [rsp+138],eax
       mov       byte ptr [rsp+13C],0
       mov       [rsp+13D],dl
       mov       [rsp+178],rbp
       mov       [rsp+180],r14d
       mov       [rsp+184],r15d
       mov       [rsp+188],r13
       mov       [rsp+190],r12d
       mov       [rsp+198],rdi
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M06_L04
M06_L03:
       lea       rdx,[rsp+120]
       mov       r8,rsi
       call      qword ptr [7FFC037EE028]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       nop
       vzeroupper
       add       rsp,1A8
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
       mov       rcx,rbx
       mov       rdx,7FFC038B1400
       call      qword ptr [7FFC02CBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L03
M06_L05:
       lea       rdx,[rsp+20]
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rsp+20]
       mov       r12d,[rsp+28]
       jmp       near ptr M06_L01
M06_L06:
       call      qword ptr [7FFC02EEF1B0]
       int       3
; Total bytes of code 558
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
; MessagePack.SequencePool.Rent()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rdx,[rcx+8]
       mov       [rbp-20],rdx
       xor       eax,eax
       mov       [rbp-14],eax
       test      rdx,rdx
       je        short M08_L01
       mov       rcx,rdx
       call      00007FFC627F9E20
       test      eax,eax
       je        short M08_L02
M08_L00:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       edx,[rax+10]
       test      edx,edx
       jle       short M08_L08
       dec       edx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M08_L03
       inc       dword ptr [rax+14]
       mov       [rax+10],edx
       mov       eax,edx
       mov       rbx,[r8+rax*8+10]
       mov       eax,edx
       mov       edx,r10d
       cmp       rax,rdx
       jae       short M08_L04
       xor       edx,edx
       mov       [r8+rax*8+10],rdx
       jmp       short M08_L05
M08_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC038D7A08]
       int       3
M08_L02:
       mov       rcx,[rbp-20]
       call      qword ptr [7FFC038DCCF0]
       jmp       short M08_L00
M08_L03:
       mov       rcx,rax
       call      qword ptr [7FFC03A64F00]
       int       3
M08_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L05:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       jne       short M08_L09
M08_L06:
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rbx
M08_L07:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M08_L08:
       call      M08_L13
       jmp       short M08_L10
M08_L09:
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC038DC1F8]
       jmp       short M08_L06
M08_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M08_L11
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.MemoryPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037ED698]
       jmp       short M08_L12
M08_L11:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC037ED6B0]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]]..ctor(System.Buffers.ArrayPool`1<Byte>)
M08_L12:
       mov       dword ptr [rsi+30],8000
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rsi
       jmp       near ptr M08_L07
M08_L13:
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M08_L15
       cmp       qword ptr [rbp-20],0
       jne       short M08_L14
       xor       ecx,ecx
       call      qword ptr [7FFC038D7A08]
       int       3
M08_L14:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       je        short M08_L15
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC038DC1F8]
M08_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        near ptr M09_L14
       xor       edx,edx
       mov       [rsp+48],rdx
       test      esi,esi
       je        near ptr M09_L15
       mov       rcx,[rbx+28]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M09_L01
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M09_L17
       mov       eax,[rdx+8]
M09_L00:
       sub       eax,[rdi+3C]
       jo        near ptr M09_L35
       cmp       eax,esi
       jge       short M09_L03
M09_L01:
       mov       ecx,[rbx+30]
       cmp       ecx,esi
       cmovl     ecx,esi
       mov       [rsp+4C],ecx
M09_L02:
       mov       byte ptr [rsp+48],1
M09_L03:
       cmp       byte ptr [rsp+48],0
       je        near ptr M09_L12
       mov       rcx,[rbx+8]
       mov       eax,[rcx+10]
       test      eax,eax
       jle       near ptr M09_L19
       dec       eax
       mov       rdx,[rcx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M09_L20
       inc       dword ptr [rcx+14]
       mov       [rcx+10],eax
       mov       ecx,eax
       mov       rsi,[rdx+rcx*8+10]
       mov       ecx,eax
       cmp       rcx,r8
       jae       near ptr M09_L34
       mov       ecx,eax
       xor       eax,eax
       mov       [rdx+rcx*8+10],rax
M09_L04:
       mov       rdi,rsi
       mov       rbp,[rbx+18]
       test      rbp,rbp
       je        near ptr M09_L25
       cmp       byte ptr [rsp+48],0
       je        near ptr M09_L21
       cmp       dword ptr [rsp+4C],0FFFFFFFF
       je        near ptr M09_L22
       mov       edx,[rsp+4C]
M09_L05:
       mov       rcx,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [rbp],rcx
       jne       near ptr M09_L23
       mov       rcx,rbp
       call      qword ptr [7FFC0360A450]; System.Buffers.ConfigurableArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       r14,rax
M09_L06:
       lea       rcx,[rdi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M09_L24
       mov       rdx,r14
       mov       ebp,[rdx+8]
M09_L07:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+20],eax
       mov       [rdi+24],ebp
M09_L08:
       mov       rbp,[rbx+28]
       test      rbp,rbp
       je        near ptr M09_L13
       mov       rcx,rbp
       mov       esi,[rcx+3C]
       mov       r14d,[rcx+38]
       sub       esi,r14d
       jo        near ptr M09_L35
       test      esi,esi
       jle       near ptr M09_L30
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,r14d
       add       rdx,[rbp+10]
       jo        near ptr M09_L35
       mov       ecx,esi
       add       rdx,rcx
       jo        near ptr M09_L35
       mov       [rdi+10],rdx
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M09_L26
M09_L09:
       test      rdx,rdx
       je        near ptr M09_L27
       mov       eax,[rdx+8]
       xor       esi,esi
M09_L10:
       mov       ecx,[rbp+38]
       mov       r14d,[rbp+3C]
       sub       r14d,ecx
       jo        near ptr M09_L35
       add       r14d,ecx
       jo        near ptr M09_L35
       cmp       r14d,eax
       ja        near ptr M09_L29
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       mov       [rbp+24],r14d
M09_L11:
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M09_L12:
       mov       rax,[rbx+28]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L13:
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L12
M09_L14:
       mov       ecx,1C1
       mov       rdx,7FFC035B9B70
       call      qword ptr [7FFC02CBF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC037ED8D8]
       int       3
M09_L15:
       mov       rdi,[rbx+28]
       test      rdi,rdi
       je        short M09_L16
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037ED830]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_WritableBytes()
       test      eax,eax
       jne       near ptr M09_L03
M09_L16:
       mov       dword ptr [rsp+4C],0FFFFFFFF
       jmp       near ptr M09_L02
M09_L17:
       mov       rcx,[rdi+30]
       test      rcx,rcx
       jne       short M09_L18
       xor       eax,eax
       jmp       near ptr M09_L00
M09_L18:
       lea       rdx,[rsp+38]
       mov       r11,7FFC02C01878
       call      qword ptr [r11]
       mov       eax,[rsp+44]
       jmp       near ptr M09_L00
M09_L19:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       jmp       near ptr M09_L04
M09_L20:
       call      qword ptr [7FFC03A64F00]
       int       3
M09_L21:
       call      qword ptr [7FFC032E5EA8]
       int       3
M09_L22:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      qword ptr [7FFC02CB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[7FFC02BFB1C8]
       jmp       near ptr M09_L05
M09_L23:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M09_L06
M09_L24:
       xor       edx,edx
       xor       ebp,ebp
       jmp       near ptr M09_L07
M09_L25:
       mov       rbp,[rbx+10]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFC032EF5B8]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037ED8A8]
       jmp       near ptr M09_L08
M09_L26:
       cmp       qword ptr [rbp+30],0
       je        near ptr M09_L11
       jmp       near ptr M09_L09
M09_L27:
       mov       rcx,[rbp+30]
       test      rcx,rcx
       jne       short M09_L28
       xor       edx,edx
       xor       esi,esi
       xor       eax,eax
       jmp       near ptr M09_L10
M09_L28:
       lea       rdx,[rsp+28]
       mov       r11,7FFC02C01880
       call      qword ptr [r11]
       mov       rdx,[rsp+28]
       mov       esi,[rsp+30]
       mov       eax,[rsp+34]
       jmp       near ptr M09_L10
M09_L29:
       call      qword ptr [7FFC02EEF1B0]
       int       3
M09_L30:
       mov       rsi,[rbx+20]
       cmp       [rbx+20],rbp
       jne       short M09_L32
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L33
M09_L31:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
M09_L32:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       cmp       rax,[rbx+28]
       jne       short M09_L31
M09_L33:
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037ED950]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].SetNext(SequenceSegment<Byte>)
       mov       rdx,[rbx+28]
       mov       rcx,rbx
       call      qword ptr [7FFC037ED980]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].RecycleAndGetNext(SequenceSegment<Byte>)
       jmp       near ptr M09_L11
M09_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 975
```
```assembly
; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_RemainingSpan()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M10_L03
       mov       edi,[rcx+8]
       xor       ebp,ebp
M10_L00:
       xor       r14d,r14d
       xor       r15d,r15d
       test      rcx,rcx
       je        short M10_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M10_L05
       lea       r14,[rcx+10]
       mov       r15d,[rcx+8]
M10_L01:
       and       ebp,7FFFFFFF
       mov       eax,ebp
       mov       ecx,edi
       add       rcx,rax
       mov       edx,r15d
       cmp       rcx,rdx
       ja        near ptr M10_L06
       add       r14,rax
       mov       r15d,edi
M10_L02:
       mov       eax,[rsi+3C]
       cmp       eax,r15d
       ja        short M10_L06
       mov       ecx,eax
       add       rcx,r14
       sub       r15d,eax
       mov       [rbx],rcx
       mov       [rbx+8],r15d
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       short M10_L04
       xor       ecx,ecx
       xor       ebp,ebp
       xor       edi,edi
       jmp       short M10_L00
M10_L04:
       lea       rdx,[rsp+38]
       mov       r11,7FFC02C01A10
       call      qword ptr [r11]
       mov       rcx,[rsp+38]
       mov       ebp,[rsp+40]
       mov       edi,[rsp+44]
       jmp       near ptr M10_L00
M10_L05:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,[rsp+28]
       mov       r15d,[rsp+30]
       jmp       near ptr M10_L01
M10_L06:
       call      qword ptr [7FFC02EEF1B0]
       int       3
; Total bytes of code 248
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M11_L02
M11_L00:
       cmp       rcx,rdx
       je        near ptr M11_L14
M11_L01:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M11_L02:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M11_L00
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M11_L06
       cmp       r8,40
       jbe       short M11_L03
       cmp       r8,800
       ja        short M11_L01
       jmp       near ptr M11_L11
M11_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M11_L08
M11_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M11_L05:
       vzeroupper
       ret
M11_L06:
       test      r8b,18
       je        short M11_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M11_L05
M11_L07:
       test      r8b,4
       je        short M11_L10
       jmp       short M11_L09
M11_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M11_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M11_L04
M11_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M11_L05
M11_L10:
       test      r8,r8
       je        short M11_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M11_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M11_L05
M11_L11:
       cmp       r8,100
       jb        short M11_L12
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
M11_L12:
       mov       r9,r8
       shr       r9,6
M11_L13:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M11_L13
       and       r8,3F
       cmp       r8,10
       ja        near ptr M11_L03
       jmp       near ptr M11_L04
M11_L14:
       cmp       [rdx],dl
       jmp       near ptr M11_L05
; Total bytes of code 322
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M12_L00
       cmp       [rdx],rcx
       jne       short M12_L01
M12_L00:
       mov       rax,rdx
       ret
M12_L01:
       jmp       qword ptr [7FFC02EE4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24DAFF60008
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
       call      qword ptr [7FFC038DDBF0]
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
       jne       short M14_L01
       cmp       [rax],edx
       jle       short M14_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M14_L03
M14_L00:
       ret
M14_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M14_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M14_L00
M14_L02:
       cmp       [rax+4],r8d
       jle       short M14_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M14_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M14_L03
       jmp       short M14_L00
M14_L03:
       jmp       qword ptr [7FFC02CBD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        short M16_L00
       mov       rcx,7FFC03942C6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,[rbx+8]
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r8d,esi
       mov       rdx,[rbx]
       lea       rcx,[rdi+10]
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,7FFC03942C68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,24DAFF66DC8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 115
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M17_L01
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M17_L02
       lea       rdi,[rcx+10]
       mov       ebp,[rcx+8]
M17_L00:
       mov       eax,[rbx+8]
       and       eax,7FFFFFFF
       mov       ecx,[rbx+0C]
       mov       edx,ecx
       add       rdx,rax
       mov       r8d,ebp
       cmp       rdx,r8
       ja        short M17_L03
       add       rdi,rax
       mov       ebp,ecx
M17_L01:
       mov       [rsi],rdi
       mov       [rsi+8],ebp
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M17_L02:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+28]
       mov       ebp,[rsp+30]
       jmp       short M17_L00
M17_L03:
       call      qword ptr [7FFC02EEF1B0]
       int       3
; Total bytes of code 131
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ClonePersonRecordRecord()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E8
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+1E0],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rdi,[rax+10]
       test      rdi,rdi
       je        near ptr M00_L16
M00_L02:
       mov       rcx,1F89B400AC8
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L17
M00_L03:
       mov       rdx,[r9+18]
       test      rdx,rdx
       je        near ptr M00_L18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+118],xmm0
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+10]
       vmovdqu   ymm0,ymmword ptr [rsp+0D8]
       vmovdqu   ymmword ptr [rsp+190],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0F8]
       vmovdqu   ymmword ptr [rsp+1B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+118]
       vmovdqu   xmmword ptr [rsp+1D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+188]
       vmovdqu   ymmword ptr [rsp+128],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1A8]
       vmovdqu   ymmword ptr [rsp+148],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+1C8]
       vmovdqu   ymmword ptr [rsp+168],ymm0
       mov       byte ptr [rsp+128],0
       xor       eax,eax
       mov       [rsp+130],rax
       mov       [rsp+138],rdx
       mov       [rsp+140],rax
       mov       [rsp+148],eax
       mov       [rsp+150],rcx
       mov       [rsp+158],r8d
       mov       [rsp+160],rdi
       mov       [rsp+168],eax
       mov       [rsp+16C],r8d
       mov       [rsp+180],rax
       lea       rdx,[rsp+128]
       mov       r8,rsi
       mov       rcx,7FFC03673650
       call      qword ptr [7FFC0357D200]; MessagePack.MessagePackSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackWriter ByRef, System.__Canon, MessagePack.MessagePackSerializerOptions)
       cmp       qword ptr [rsp+138],0
       jne       near ptr M00_L19
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0C8],xmm0
       mov       rdx,[rsp+178]
       test      rdx,rdx
       je        near ptr M00_L22
       mov       esi,[rsp+148]
       test      esi,esi
       jle       near ptr M00_L06
       cmp       qword ptr [rsp+138],0
       jne       near ptr M00_L10
M00_L04:
       mov       ecx,esi
       add       rcx,[rsp+140]
       jo        near ptr M00_L40
       mov       [rsp+140],rcx
       xor       ecx,ecx
       mov       [rsp+148],ecx
       mov       rdi,[rsp+130]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rdi],rcx
       jne       near ptr M00_L32
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        near ptr M00_L27
       add       esi,[rcx+3C]
       jo        near ptr M00_L40
       mov       edx,esi
       mov       eax,[rcx+24]
       cmp       edx,eax
       jg        near ptr M00_L28
       mov       [rcx+3C],esi
       cmp       byte ptr [rdi+34],0
       je        short M00_L05
       cmp       dword ptr [rdi+30],8000
       jl        near ptr M00_L29
M00_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
M00_L06:
       mov       rdx,[rsp+178]
       cmp       [rdx],dl
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFC0357E838]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+0B0]
       mov       rsi,[rsp+0B8]
       mov       edi,[rsp+0C0]
       and       edi,7FFFFFFF
       mov       ebp,[rsp+0C4]
       and       ebp,7FFFFFFF
       cmp       rdx,rsi
       jne       near ptr M00_L13
       sub       ebp,edi
       movsxd    rdx,ebp
M00_L07:
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       rdx,[rsp+0B0]
       cmp       rdx,[rsp+0B8]
       je        near ptr M00_L33
       mov       [rsp+30],rdi
       mov       [rsp+38],ebp
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FFC0382DDA0]; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
M00_L08:
       mov       rcx,[rsp+170]
       mov       rdx,[rsp+178]
       test      rcx,rcx
       je        short M00_L09
       call      qword ptr [7FFC0382DF20]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+48]
       mov       rdx,rsi
       call      qword ptr [7FFC03AA54E8]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,[rsp+48]
       mov       ecx,[rsp+50]
       mov       r8d,[rsp+54]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       mov       [rsp+2C],r8d
       lea       rdx,[rsp+20]
       mov       rcx,7FFC038EF190
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0357D1A0]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,7FFC03903558
       cmp       [rcx],ecx
       call      qword ptr [7FFC0382EE68]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,1E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L10:
       lea       rdx,[rsp+170]
       mov       rcx,[rsp+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0357E7C0]; MessagePack.SequencePool.Rent()
       mov       rcx,[rsp+178]
       mov       [rsp+130],rcx
       mov       rcx,[rsp+130]
       mov       rdx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       cmp       [rcx],rdx
       jne       near ptr M00_L23
       mov       edx,[rsp+148]
       call      qword ptr [7FFC0382D818]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       mov       rcx,rax
       lea       rdx,[rsp+0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0382D830]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_RemainingSpan()
M00_L11:
       mov       r8,[rsp+160]
       mov       ecx,[rsp+168]
       mov       edx,[rsp+16C]
       mov       eax,[rsp+148]
       cmp       eax,edx
       ja        near ptr M00_L24
       test      r8,r8
       je        near ptr M00_L25
       mov       edx,eax
       add       rdx,rcx
       mov       r10d,[r8+8]
       cmp       rdx,r10
       ja        near ptr M00_L26
       lea       rdx,[r8+rcx+10]
M00_L12:
       mov       rcx,[rsp+0A0]
       mov       r8d,[rsp+0A8]
       cmp       eax,r8d
       jg        near ptr M00_L39
       mov       r8d,eax
       call      qword ptr [7FFC02CF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       xor       ecx,ecx
       mov       [rsp+138],rcx
       jmp       near ptr M00_L04
M00_L13:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    rdx,ebp
       add       rdx,[rax+10]
       movsxd    rcx,edi
       add       rcx,[r14+10]
       sub       rdx,rcx
       jmp       near ptr M00_L07
M00_L14:
       call      qword ptr [7FFC0332E730]
       mov       ecx,3
       mov       rdx,7FFC03184600
       call      qword ptr [7FFC02CFF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03055770
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03184600
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC035744F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03574510]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       ecx,0E
       call      qword ptr [7FFC0357D248]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L16:
       mov       rcx,offset MT_System.Byte[]
       mov       edx,10000
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ecx,0E
       call      qword ptr [7FFC0357D248]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,1F89B400AF8
       mov       rbp,[rcx]
       mov       rcx,1F89B400AC8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,rbp
       jmp       near ptr M00_L03
M00_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1E1
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC031071E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       rdx,[rsp+160]
       mov       ecx,[rsp+168]
       mov       eax,[rsp+16C]
       mov       r8d,[rsp+148]
       cmp       r8d,eax
       ja        near ptr M00_L24
       test      rdx,rdx
       jne       short M00_L20
       or        ecx,r8d
       jne       near ptr M00_L26
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L21
M00_L20:
       mov       eax,ecx
       mov       r10d,r8d
       add       rax,r10
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        near ptr M00_L26
       mov       ecx,ecx
       lea       rdx,[rdx+rcx+10]
M00_L21:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC031AC108]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC031A74E0]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       mov       rsi,rax
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0F1C
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC02CFF228]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       lea       rdx,[rsp+0A0]
       mov       r8d,[rsp+148]
       mov       r11,7FFC02C41940
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L24:
       mov       ecx,28
       call      qword ptr [7FFC02CFF348]
       int       3
M00_L25:
       or        ecx,eax
       jne       short M00_L26
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M00_L12
M00_L26:
       call      qword ptr [7FFC02F2F1B0]
       int       3
M00_L27:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,171
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03107930]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       mov       ecx,1078
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC0382D908]
       int       3
M00_L29:
       lea       rcx,[rsp+88]
       mov       rdx,rdi
       call      qword ptr [7FFC0357E838]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       rdx,[rsp+88]
       mov       rsi,[rsp+90]
       mov       ebp,[rsp+98]
       and       ebp,7FFFFFFF
       mov       r14d,[rsp+9C]
       and       r14d,7FFFFFFF
       cmp       rdx,rsi
       je        short M00_L30
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r14,r14d
       add       r14,[rax+10]
       movsxd    rcx,ebp
       add       rcx,[r15+10]
       sub       r14,rcx
       jmp       short M00_L31
M00_L30:
       sub       r14d,ebp
       movsxd    r14,r14d
M00_L31:
       mov       rcx,r14
       shr       rcx,3F
       add       rcx,r14
       sar       rcx,1
       mov       edx,7FFFFFFF
       cmp       rcx,7FFFFFFF
       cmovl     rdx,rcx
       movsxd    rcx,edx
       cmp       rdx,rcx
       jne       near ptr M00_L40
       mov       ecx,8000
       cmp       edx,8000
       cmovl     ecx,edx
       cmp       [rdi+30],ecx
       jge       near ptr M00_L05
       mov       [rdi+30],ecx
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFC02C41938
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L33:
       mov       r8,[rsp+0B0]
       test      r8,r8
       jne       short M00_L34
       xor       edx,edx
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M00_L37
M00_L34:
       mov       r14d,[rsp+0C0]
       mov       r15d,[rsp+0C4]
       cmp       r8,[rsp+0B8]
       setne     r9b
       movzx     r9d,r9b
       mov       edx,r14d
       or        edx,r15d
       jl        short M00_L36
       mov       rdx,r8
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rax+18]
       mov       r8d,[rax+20]
       mov       ecx,[rax+24]
       sub       r15d,r14d
       mov       eax,r14d
       mov       r10d,r15d
       add       rax,r10
       cmp       rax,rcx
       jbe       short M00_L35
       mov       ecx,21
       call      qword ptr [7FFC02CFF348]
       int       3
M00_L35:
       add       r8d,r14d
       jmp       short M00_L37
M00_L36:
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+58]
       call      qword ptr [7FFC03917978]
       mov       rdx,[rsp+58]
       mov       r8d,[rsp+60]
       mov       r15d,[rsp+64]
M00_L37:
       mov       [rsp+78],rdx
       mov       [rsp+80],r8d
       mov       [rsp+84],r15d
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       call      qword ptr [7FFC033DF810]; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       mov       r14d,[rsp+70]
       cmp       r14d,ebp
       jle       short M00_L38
       mov       ecx,6
       call      qword ptr [7FFC0382DEA8]
       int       3
M00_L38:
       mov       r8d,r14d
       mov       rcx,rdi
       mov       rdx,[rsp+68]
       call      qword ptr [7FFC0332E058]
       jmp       near ptr M00_L08
M00_L39:
       call      qword ptr [7FFC031AC768]
       int       3
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2379
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rbx,rbx
       je        near ptr M01_L65
M01_L00:
       mov       rdi,rbx
       mov       rdx,[rbp+18]
       movzx     ecx,byte ptr [rdx]
       mov       [rbp-44],ecx
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       cmp       byte ptr [rbp-50],0
       jne       near ptr M01_L66
M01_L01:
       cmp       dword ptr [rdi+20],0
       jne       near ptr M01_L39
M01_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M01_L22
M01_L03:
       mov       rax,[rcx+18]
       mov       r15,[rax+18]
       test      r15,r15
       je        near ptr M01_L23
M01_L04:
       mov       rdx,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFC0357E700]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,offset MT_MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
       cmp       [rax],rcx
       jne       near ptr M01_L63
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rsi
       call      qword ptr [7FFC02F261C0]; System.Object.GetType()
       mov       r15,rax
       mov       rbx,r15
       mov       rcx,2391A5627E0
       cmp       rbx,rcx
       je        near ptr M01_L49
       mov       rcx,1F89B400D60
       mov       r14,[rcx]
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L08
       mov       r13,[r14+18]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r11,7FFC02C41998
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rdx,[r14+8]
       mov       ecx,r12d
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L61
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r14,[r14+10]
       xor       eax,eax
       mov       [rbp-0E4],eax
       dec       edx
       mov       r10d,[r14+8]
       mov       [rbp-0E8],r10d
       cmp       r10d,edx
       jbe       short M01_L08
M01_L05:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r14+rdx*8+10]
       mov       [rbp-118],r9
       cmp       [r9+8],r12d
       jne       short M01_L06
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rbx
       mov       r11,7FFC02C419A0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-118]
       jne       short M01_L07
M01_L06:
       mov       edx,[r9+0C]
       mov       eax,[rbp-0E4]
       inc       eax
       mov       r10d,[rbp-0E8]
       cmp       r10d,eax
       jb        near ptr M01_L24
       cmp       r10d,edx
       mov       [rbp-0E4],eax
       jbe       short M01_L08
       jmp       short M01_L05
M01_L07:
       add       r9,10
       test      r9,r9
       jne       short M01_L12
M01_L08:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M01_L52
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L51
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L09:
       test      eax,eax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L53
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       short M01_L12
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L54
M01_L11:
       test      rax,rax
       je        short M01_L15
M01_L12:
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L50
       xor       eax,eax
M01_L13:
       test      rax,rax
       jne       short M01_L15
       mov       rax,rsi
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rax],rdx
       jne       near ptr M01_L55
M01_L14:
       test      rax,rax
       je        near ptr M01_L56
M01_L15:
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L57
       mov       rcx,1F89B400D20
       mov       rcx,[rcx]
       mov       r13,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L25
M01_L16:
       mov       ecx,[r13+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L60
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L61
       mov       ecx,edx
       mov       rcx,[r13+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L26
M01_L17:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L58
       mov       r13,[rcx+18]
M01_L18:
       mov       rdx,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L59
       mov       rcx,1F89B400D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      00007FFC628B6270
       test      eax,eax
       je        near ptr M01_L27
M01_L19:
       mov       edx,[r14+8]
       mov       ecx,edx
       sub       ecx,1
       jo        near ptr M01_L60
       and       ecx,eax
       cmp       ecx,edx
       jae       near ptr M01_L61
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       test      rdx,rdx
       je        near ptr M01_L28
M01_L20:
       cmp       [rdx+10],rbx
       jne       near ptr M01_L62
       mov       r14,[rdx+18]
M01_L21:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r8,[rbp+18]
       mov       r9,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M01_L64
M01_L22:
       mov       rdx,7FFC03680900
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L03
M01_L23:
       mov       rdx,7FFC03680920
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFC02CFF480]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFC02F27258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L16
M01_L26:
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F89B400D28
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FFC02F61C80]; Precode of System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r13,rax
       mov       rcx,2391A573B98
       mov       rdx,2391A573BC0
       call      qword ptr [7FFC0357EE50]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFC0357F078]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo)
       mov       r13,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-120],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-120]
       mov       [rsp+20],r12
       mov       rdx,r13
       mov       rcx,7FFC03690918
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0357F780]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0357EEB0]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r13,rax
       mov       rcx,1F89B400D20
       mov       rcx,[rcx]
       mov       rdx,rbx
       mov       r8,r13
       call      qword ptr [7FFC0357EEC8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       near ptr M01_L18
M01_L27:
       mov       rcx,rbx
       call      qword ptr [7FFC02F27258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L19
M01_L28:
       mov       rdx,1F89B400D50
       mov       rcx,[rdx]
       mov       [rbp-0F0],rcx
       mov       byte ptr [rbp-0E0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1F89B400D50
       mov       rcx,[rcx]
       mov       r14,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ecx,[r14+8]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M01_L35
       and       edx,eax
       cmp       edx,ecx
       jae       near ptr M01_L36
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L33
M01_L29:
       cmp       [rcx+10],rbx
       jne       near ptr M01_L32
       mov       r14,[rcx+18]
       mov       ecx,1
M01_L30:
       test      ecx,ecx
       jne       near ptr M01_L38
       mov       r12,offset MT_System.Type[]
       mov       rcx,r12
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,2391A573AF8
       call      qword ptr [7FFC02C3A5B8]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       r14,rax
       mov       rcx,2391A5627E0
       mov       rdx,2391A573B20
       call      qword ptr [7FFC0357EE50]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-0F8],rax
       mov       rdx,2391A573B48
       mov       [rbp-138],rdx
       mov       rcx,rdx
       call      qword ptr [7FFC02C3A5B0]; Precode of System.RuntimeType.MakeByRefType()
       mov       rcx,rax
       mov       rdx,2391A567EC8
       call      qword ptr [7FFC0357EE50]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-100],rax
       mov       rcx,2391A5627E0
       mov       rdx,2391A561640
       call      qword ptr [7FFC0357EE50]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-108],rax
       mov       r8,2391A573278
       mov       [rbp-140],r8
       mov       rcx,r8
       mov       rdx,2391A56A148
       call      qword ptr [7FFC0357EE50]; System.Linq.Expressions.Expression.Parameter(System.Type, System.String)
       mov       [rbp-110],rax
       mov       rcx,r12
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC02C3A5B0]; Precode of System.RuntimeType.MakeByRefType()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-140]
       mov       [r12+20],rbx
       mov       rcx,r14
       mov       r8,r12
       mov       rdx,2391A573B70
       call      qword ptr [7FFC0357D968]; System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(System.Type, System.String, System.Type[])
       mov       rbx,rax
       mov       rcx,[rbp-0F8]
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC036AD140]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       mov       r14,rax
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M01_L37
       jmp       near ptr M01_L34
M01_L31:
       mov       r12,[rbp-110]
       mov       [rsp+20],r12
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,[rbp-100]
       mov       r9,rax
       call      qword ptr [7FFC0357EE98]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression)
       mov       rbx,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+18]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],r14
       mov       rdx,rbx
       mov       rcx,7FFC0374C8D8
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0357F780]; System.Linq.Expressions.Expression.Lambda[[System.__Canon, System.Private.CoreLib]](System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC0357EEB0]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Compile()
       mov       r14,rax
       mov       rcx,1F89B400D50
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,r14
       call      qword ptr [7FFC0357EEC8]; MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.Type, System.__Canon)
       jmp       short M01_L38
M01_L32:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L29
M01_L33:
       xor       r14d,r14d
       xor       ecx,ecx
       jmp       near ptr M01_L30
M01_L34:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFC036AD140]; System.Linq.Expressions.Expression.Convert(System.Linq.Expressions.Expression, System.Type, System.Reflection.MethodInfo)
       jmp       near ptr M01_L31
M01_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L37:
       mov       rcx,[rbp-108]
       mov       rdx,r15
       call      qword ptr [7FFC0357EE80]
       jmp       near ptr M01_L31
M01_L38:
       cmp       byte ptr [rbp-0E0],0
       je        near ptr M01_L21
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CF6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M01_L21
M01_L39:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L40
       jmp       short M01_L41
M01_L40:
       mov       rdx,7FFC03680B68
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L41:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [rax],0
       jne       near ptr M01_L02
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC0357E7C0]; MessagePack.SequencePool.Rent()
       mov       rcx,[rbp-60]
       mov       [rbp-128],rcx
       mov       rdx,[rbp-58]
       mov       [rbp-130],rdx
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp+18]
       mov       r8,[rbp-130]
       call      qword ptr [7FFC0357E7F0]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rdx,7FFC03680900
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L43:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+18]
       mov       r14,[rdx+18]
       test      r14,r14
       je        short M01_L45
       jmp       short M01_L46
M01_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L45:
       mov       rdx,7FFC03680920
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
M01_L46:
       mov       rdx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFC0357E700]; MessagePack.FormatterResolverExtensions.GetFormatterWithVerify[[System.__Canon, System.Private.CoreLib]](MessagePack.IFormatterResolver)
       mov       rcx,rax
       lea       rdx,[rbp-0C0]
       mov       r11,r14
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r14]
       mov       esi,[rbp-0A0]
       test      esi,esi
       jle       short M01_L47
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFC0382D650]; MessagePack.BufferWriter.MigrateToSequence()
       mov       ecx,esi
       add       rcx,[rbp-0A8]
       jo        short M01_L44
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       rcx,[rbp-0B8]
       mov       edx,esi
       mov       r11,7FFC02C41980
       call      qword ptr [r11]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
M01_L47:
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0357E838]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       mov       r9d,[rbx+24]
       mov       r8d,[rbx+20]
       lea       rcx,[rbp-0D8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC0357E868]
       nop
       cmp       qword ptr [rbp-128],0
       je        near ptr M01_L64
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0382DF20]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
       jmp       near ptr M01_L64
M01_L48:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC0357EDD8]
       jmp       near ptr M01_L64
M01_L49:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FFC03AA5830]
       jmp       near ptr M01_L64
M01_L50:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L13
M01_L51:
       mov       rcx,r15
       mov       rdx,2391A566D90
       call      qword ptr [7FFC02C3A608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L09
M01_L52:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L53:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IDictionary
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L10
M01_L54:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L11
M01_L55:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M01_L14
M01_L56:
       mov       rcx,1F89B400D58
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFC03678A80]
       jmp       near ptr M01_L64
M01_L57:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1FB
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC031071E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L17
       jmp       near ptr M01_L26
M01_L59:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC0357E940]
       int       3
M01_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L62:
       mov       rdx,[rdx+8]
       test      rdx,rdx
       jne       near ptr M01_L20
       jmp       near ptr M01_L28
M01_L63:
       mov       rcx,rax
       mov       r11,r15
       mov       rdx,[rbp+18]
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [r15]
       nop
M01_L64:
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
M01_L65:
       call      qword ptr [7FFC0357D260]; MessagePack.MessagePackSerializer.get_DefaultOptions()
       mov       rbx,rax
       jmp       near ptr M01_L00
M01_L66:
       mov       cx,[rdi+2E]
       mov       [rbp-50],cx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC03104C90]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].get_Value()
       mov       rdx,[rbp+18]
       mov       [rdx],al
       jmp       near ptr M01_L01
       sub       rsp,28
       cmp       qword ptr [rbp-128],0
       je        short M01_L67
       mov       rcx,[rbp-128]
       mov       rdx,[rbp-130]
       call      qword ptr [7FFC0382DF20]; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
M01_L67:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-0E0],0
       je        short M01_L68
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC02CF6820]; System.Threading.Monitor.Exit(System.Object)
M01_L68:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_MessagePack.MessagePackSerializationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,812
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFC02C3A310]; Precode of System.RuntimeType.get_FullName()
       mov       r14,rax
       mov       ecx,83C
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFC02F25470]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC0357E898]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdx,[rbp+18]
       mov       ecx,[rbp-44]
       mov       [rdx],cl
       add       rsp,28
       ret
; Total bytes of code 3063
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].op_Implicit(Nerdbank.Streams.Sequence`1<Byte>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rdx+20]
       test      rcx,rcx
       je        short M02_L03
       mov       r8,[rdx+28]
       test      r8,r8
       je        short M02_L03
       mov       edx,[rcx+38]
       mov       eax,[r8+3C]
       cmp       rcx,r8
       je        short M02_L00
       mov       r10,[rcx+10]
       cmp       r10,[r8+10]
       jg        short M02_L05
M02_L00:
       mov       r10d,[rcx+24]
       cmp       r10d,edx
       jb        short M02_L05
       mov       r10d,[r8+24]
       cmp       r10d,eax
       jb        short M02_L05
       cmp       rcx,r8
       je        short M02_L04
M02_L01:
       mov       [rbx],rcx
       mov       [rbx+8],r8
       mov       [rbx+10],edx
       mov       [rbx+14],eax
M02_L02:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L03:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1F89B401910
       mov       rax,[rax]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rax+18]
       mov       [rbx+10],rcx
       jmp       short M02_L02
M02_L04:
       cmp       eax,edx
       jge       short M02_L01
M02_L05:
       call      qword ptr [7FFC03AA53B0]
       int       3
; Total bytes of code 151
```
```assembly
; System.Buffers.BuffersExtensions.CopyToMultiSegment[[System.Byte, System.Private.CoreLib]](System.Buffers.ReadOnlySequence`1<Byte> ByRef, System.Span`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       mov       rdx,[rbx]
       mov       rbp,[rbx+8]
       mov       r14d,[rbx+10]
       and       r14d,7FFFFFFF
       mov       r15d,r14d
       mov       r13d,[rbx+14]
       and       r13d,7FFFFFFF
       cmp       rdx,rbp
       jne       near ptr M03_L03
       sub       r13d,r15d
       movsxd    r13,r13d
M03_L00:
       mov       edx,edi
       cmp       r13,rdx
       jg        near ptr M03_L11
       mov       rbp,[rbx]
M03_L01:
       xor       r15d,r15d
       test      rbp,rbp
       je        near ptr M03_L12
       mov       edx,[rbx+10]
       sar       edx,1F
       mov       r13d,[rbx+14]
       mov       ecx,r13d
       sar       ecx,1F
       lea       edx,[rcx+rdx*2]
       mov       r12d,edx
       neg       r12d
       mov       rax,[rbx+8]
       mov       [rsp+20],rax
       and       r13d,7FFFFFFF
       test      r12d,r12d
       jne       near ptr M03_L13
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,[rsp+20]
       cmp       rax,r12
       jne       near ptr M03_L09
       mov       rcx,[r12+18]
       mov       ebp,[r12+20]
       mov       r12d,[r12+24]
       sub       r13d,r14d
       mov       eax,r14d
       mov       edx,r13d
       add       rdx,rax
       mov       eax,r12d
       cmp       rdx,rax
       jbe       short M03_L04
M03_L02:
       mov       ecx,21
       call      qword ptr [7FFC02CFF348]
       int       3
M03_L03:
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rdx,rbp
       mov       rcx,offset MT_System.Buffers.ReadOnlySequenceSegment<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       movsxd    r13,r13d
       add       r13,[rax+10]
       movsxd    rdx,r15d
       add       rdx,[r12+10]
       sub       r13,rdx
       jmp       near ptr M03_L00
M03_L04:
       add       r14d,ebp
M03_L05:
       mov       edx,1
M03_L06:
       mov       rbp,r15
       xor       eax,eax
       xor       r15d,r15d
       test      dl,dl
       je        near ptr M03_L10
       xor       edx,edx
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L08
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M03_L17
       lea       rdx,[rcx+10]
       mov       r12d,[rcx+8]
M03_L07:
       and       r14d,7FFFFFFF
       mov       r8d,r14d
       mov       ecx,r13d
       add       rcx,r8
       mov       eax,r12d
       cmp       rcx,rax
       ja        near ptr M03_L20
       add       rdx,r8
       mov       r12d,r13d
M03_L08:
       cmp       r12d,edi
       ja        near ptr M03_L19
       mov       r8d,r12d
       mov       rcx,rsi
       call      qword ptr [7FFC02CF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       test      rbp,rbp
       je        short M03_L10
       mov       ecx,r12d
       add       rsi,rcx
       sub       edi,r12d
       mov       r14d,r15d
       jmp       near ptr M03_L01
M03_L09:
       mov       r15,[rax+8]
       test      r15,r15
       je        near ptr M03_L18
       mov       rcx,[rax+18]
       mov       ebp,[rax+20]
       mov       r12d,[rax+24]
       cmp       r14d,r12d
       ja        near ptr M03_L02
       lea       edx,[r14+rbp]
       sub       r12d,r14d
       mov       r13d,r12d
       mov       r14d,edx
       jmp       near ptr M03_L05
M03_L10:
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
M03_L11:
       mov       ecx,6
       call      qword ptr [7FFC0382DEA8]
       int       3
M03_L12:
       xor       ecx,ecx
       xor       r14d,r14d
       xor       r13d,r13d
       xor       edx,edx
       jmp       near ptr M03_L06
M03_L13:
       mov       rax,[rsp+20]
       cmp       rbp,rax
       jne       near ptr M03_L18
       cmp       r12d,1
       jne       short M03_L16
       mov       rdx,rax
       mov       rcx,offset MT_System.Byte[]
       call      qword ptr [7FFC02CF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       sub       r13d,r14d
       test      rax,rax
       jne       short M03_L14
       mov       ecx,r14d
       or        ecx,r13d
       jne       near ptr M03_L20
       xor       ecx,ecx
       xor       r12d,r12d
       xor       r13d,r13d
       jmp       short M03_L15
M03_L14:
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rax+8]
       cmp       rdx,rcx
       ja        near ptr M03_L20
       mov       rcx,rax
       mov       r12d,r14d
M03_L15:
       mov       r14d,r12d
       jmp       near ptr M03_L05
M03_L16:
       mov       rdx,rax
       mov       rcx,offset MT_System.Buffers.MemoryManager<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       lea       rdx,[rsp+38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       sub       r13d,r14d
       mov       edx,r14d
       mov       ecx,r13d
       add       rdx,rcx
       mov       ecx,[rsp+44]
       cmp       rdx,rcx
       ja        short M03_L20
       mov       rcx,[rsp+38]
       add       r14d,[rsp+40]
       jmp       near ptr M03_L05
M03_L17:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,[rsp+28]
       mov       r12d,[rsp+30]
       jmp       near ptr M03_L07
M03_L18:
       call      qword ptr [7FFC03AA52A8]
       int       3
M03_L19:
       call      qword ptr [7FFC031AC768]
       int       3
M03_L20:
       call      qword ptr [7FFC02F2F1B0]
       int       3
; Total bytes of code 764
```
```assembly
; MessagePack.SequencePool.Return(Nerdbank.Streams.Sequence`1<Byte>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rdx+20]
       test      rbx,rbx
       jne       near ptr M04_L12
M04_L00:
       xor       ecx,ecx
       mov       rdx,[rbp+18]
       mov       [rdx+28],rcx
       mov       [rdx+20],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       [rbp-40],rax
       xor       eax,eax
       mov       [rbp-24],eax
       cmp       qword ptr [rbp-40],0
       je        short M04_L02
       mov       rcx,[rbp-40]
       call      00007FFC627F9E20
       test      eax,eax
       je        short M04_L03
M04_L01:
       mov       dword ptr [rbp-24],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       esi,[rbx+10]
       cmp       esi,[rcx+18]
       jge       short M04_L05
       mov       rdx,[rbp+18]
       mov       dword ptr [rdx+30],8000
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       jbe       short M04_L04
       mov       edx,esi
       mov       r8,[rbp+18]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rbx+14]
       inc       esi
       mov       [rbx+10],esi
       jmp       short M04_L05
M04_L02:
       xor       ecx,ecx
       call      qword ptr [7FFC03917A50]
       int       3
M04_L03:
       mov       rcx,[rbp-40]
       call      qword ptr [7FFC03016EC8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M04_L01
M04_L04:
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC036A46D8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       nop
M04_L05:
       mov       rcx,[rbp-40]
       call      00007FFC628B6030
       test      eax,eax
       jne       near ptr M04_L24
M04_L06:
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L07:
       call      M04_L29
       nop
       cmp       dword ptr [rbp-34],0
       je        near ptr M04_L17
M04_L08:
       mov       rcx,1F885400B18
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L18
M04_L09:
       mov       rcx,[rbp-48]
       xor       r11d,r11d
       mov       [rcx+28],r11
M04_L10:
       mov       rdx,[rbp+18]
       mov       rbx,[rdx+8]
       mov       esi,[rbx+10]
       mov       rcx,[rbx+8]
       cmp       [rcx+8],esi
       jbe       near ptr M04_L22
       mov       edx,esi
       mov       r8,[rbp-48]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rbx+14]
       inc       esi
       mov       [rbx+10],esi
M04_L11:
       mov       rbx,[rbp-50]
       test      rbx,rbx
       je        near ptr M04_L00
M04_L12:
       mov       [rbp-48],rbx
       mov       rcx,[rbx+8]
       mov       rax,rcx
       test      rax,rax
       je        short M04_L13
       mov       r8,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       cmp       [rax],r8
       jne       near ptr M04_L16
M04_L13:
       mov       [rbp-50],rax
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+18]
       mov       eax,[rbx+3C]
       sub       eax,[rbx+38]
       jo        near ptr M04_L26
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       mov       [rbx+8],rax
       mov       [rbx+10],rax
       mov       [rbx+38],rax
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M04_L20
       mov       [rbp-58],rax
       mov       rax,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [rcx],rax
       jne       near ptr M04_L19
       mov       [rbp-60],rcx
       mov       rax,[rbp-58]
       mov       ebx,[rax+8]
       test      ebx,ebx
       je        near ptr M04_L09
       lea       eax,[rbx-1]
       or        eax,0F
       lzcnt     eax,eax
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       setg      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       je        near ptr M04_L08
       cmp       eax,[r8+8]
       jae       near ptr M04_L25
       mov       rax,[r8+rax*8+10]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       cmp       [rax],al
       mov       rax,[rbp-68]
       cmp       ebx,[rax+10]
       jne       near ptr M04_L23
       mov       byte ptr [rbp-30],0
       mov       rcx,[rbp-68]
       add       rcx,1C
       mov       eax,[rcx]
       mov       [rbp-38],eax
       cmp       byte ptr [rbp-30],0
       jne       short M04_L15
       mov       r8d,eax
       and       r8d,80000001
       cmp       r8d,80000000
       jne       short M04_L15
       mov       r8d,eax
       or        r8d,1
       lock cmpxchg [rcx],r8d
       mov       r8d,[rbp-38]
       cmp       eax,r8d
       sete      r10b
       movzx     r10d,r10b
       mov       [rbp-30],r10d
       jne       short M04_L15
M04_L14:
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+18]
       test      ecx,ecx
       setne     r8b
       movzx     r8d,r8b
       mov       [rbp-34],r8d
       cmp       dword ptr [rbp-34],0
       je        near ptr M04_L07
       mov       r8,[rbp-68]
       mov       r8,[r8+8]
       dec       ecx
       mov       rax,[rbp-68]
       mov       [rax+18],ecx
       movsxd    rdx,ecx
       mov       rcx,r8
       mov       r8,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M04_L07
M04_L15:
       lea       r8,[rbp-30]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03AA4F30]
       jmp       short M04_L14
M04_L16:
       mov       rdx,rcx
       mov       rcx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M04_L13
M04_L17:
       mov       rcx,1F885400B18
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+9D],0
       je        near ptr M04_L08
       mov       rcx,[rbp-58]
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-68]
       mov       edi,[rcx+10]
       mov       rcx,[rbp-68]
       mov       r14d,[rcx+14]
       mov       rcx,[rbp-68]
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       xor       edx,edx
       mov       [rsp+28],edx
       mov       [rsp+20],eax
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,r14d
       mov       rcx,rbx
       call      qword ptr [7FFC03484588]
       jmp       near ptr M04_L08
M04_L18:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       mov       edi,ecx
       mov       r14d,edi
       mov       rcx,[rbp-60]
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rbx
       mov       r8d,esi
       mov       r9d,r14d
       mov       edx,3
       call      qword ptr [7FFC0391D4E8]
       cmp       dword ptr [rbp-28],0
       jne       near ptr M04_L09
       mov       rcx,[rbp-60]
       call      qword ptr [7FFC031ACE10]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       dword ptr [rsp+28],1
       mov       edx,esi
       mov       r8d,edi
       mov       rcx,rbx
       call      qword ptr [7FFC03484588]
       jmp       near ptr M04_L09
M04_L19:
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M04_L09
M04_L20:
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M04_L21
       mov       r11,7FFC02C41A10
       call      qword ptr [r11]
M04_L21:
       xor       ecx,ecx
       mov       [rbx+30],rcx
       jmp       near ptr M04_L10
M04_L22:
       mov       rcx,rbx
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC036A46D8]; System.Collections.Generic.Stack`1[[System.__Canon, System.Private.CoreLib]].PushWithResize(System.__Canon)
       jmp       near ptr M04_L11
M04_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC03484510]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFC02C34000
       call      qword ptr [7FFC02CFF210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC031079D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FFC0301CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M04_L06
M04_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-24],0
       je        short M04_L28
       cmp       qword ptr [rbp-40],0
       jne       short M04_L27
       xor       ecx,ecx
       call      qword ptr [7FFC03917A50]
       int       3
M04_L27:
       mov       rcx,[rbp-40]
       call      00007FFC628B6030
       test      eax,eax
       je        short M04_L28
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FFC0301CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M04_L28:
       nop
       add       rsp,38
       ret
M04_L29:
       sub       rsp,38
       cmp       byte ptr [rbp-30],0
       je        near ptr M04_L34
       mov       rbx,[rbp-68]
       add       rbx,1C
       mov       eax,[rbx]
       test      eax,80000000
       je        short M04_L30
       and       eax,0FFFFFFFE
       mov       [rbx],eax
       jmp       short M04_L34
M04_L30:
       test      dword ptr [rbx],80000000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L33
       test      dword ptr [rbx],80000000
       je        short M04_L31
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC03AA5878]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC03107930]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L31:
       mov       esi,[rbx]
       and       esi,7FFFFFFF
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       esi,eax
       je        short M04_L32
       call      qword ptr [7FFC03AA5548]
       int       3
M04_L32:
       xor       ecx,ecx
       mov       [rbx],ecx
       jmp       short M04_L34
M04_L33:
       and       dword ptr [rbx],0FFFFFFFE
M04_L34:
       add       rsp,38
       ret
; Total bytes of code 1336
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       eax,[rsi+8]
       mov       [rbx+0C],eax
M05_L00:
       pop       rbx
       pop       rsi
       ret
M05_L01:
       xor       eax,eax
       mov       [rbx],rax
       mov       [rbx+8],rax
       jmp       short M05_L00
; Total bytes of code 49
```
```assembly
; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.ReadOnlyMemory`1<Byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1A8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M06_L00:
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       add       rax,30
       jne       short M06_L00
       mov       [rsp+1A0],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       mov       rbp,[rdx]
       mov       r14d,[rdx+8]
       mov       r15d,[rdx+0C]
       xor       r13d,r13d
       xor       r12d,r12d
       test      rbp,rbp
       je        short M06_L02
       mov       rdx,[rbp]
       test      dword ptr [rdx],80000000
       je        near ptr M06_L05
       lea       r13,[rbp+10]
       mov       r12d,[rbp+8]
M06_L01:
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       ecx,r15d
       add       rcx,rax
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M06_L06
       add       r13,rax
       mov       r12d,r15d
M06_L02:
       movsxd    rcx,r15d
       test      r15d,r15d
       setg      dl
       movzx     edx,dl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+70],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+30]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+50]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+70]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+120],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C0]
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0E0]
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+100]
       vmovdqu   ymmword ptr [rsp+180],ymm0
       xor       eax,eax
       mov       [rsp+120],eax
       mov       [rsp+128],rcx
       mov       [rsp+130],rax
       mov       [rsp+138],eax
       mov       byte ptr [rsp+13C],0
       mov       [rsp+13D],dl
       mov       [rsp+178],rbp
       mov       [rsp+180],r14d
       mov       [rsp+184],r15d
       mov       [rsp+188],r13
       mov       [rsp+190],r12d
       mov       [rsp+198],rdi
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M06_L04
M06_L03:
       lea       rdx,[rsp+120]
       mov       r8,rsi
       call      qword ptr [7FFC0382E058]; MessagePack.MessagePackSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](MessagePack.MessagePackReader ByRef, MessagePack.MessagePackSerializerOptions)
       nop
       vzeroupper
       add       rsp,1A8
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
       mov       rcx,rbx
       mov       rdx,7FFC038F1410
       call      qword ptr [7FFC02CFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L03
M06_L05:
       lea       rdx,[rsp+20]
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rsp+20]
       mov       r12d,[rsp+28]
       jmp       near ptr M06_L01
M06_L06:
       call      qword ptr [7FFC02F2F1B0]
       int       3
; Total bytes of code 558
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
; MessagePack.SequencePool.Rent()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rdx,[rcx+8]
       mov       [rbp-20],rdx
       xor       eax,eax
       mov       [rbp-14],eax
       test      rdx,rdx
       je        short M08_L01
       mov       rcx,rdx
       call      00007FFC627F9E20
       test      eax,eax
       je        short M08_L02
M08_L00:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       edx,[rax+10]
       test      edx,edx
       jle       short M08_L08
       dec       edx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M08_L03
       inc       dword ptr [rax+14]
       mov       [rax+10],edx
       mov       eax,edx
       mov       rbx,[r8+rax*8+10]
       mov       eax,edx
       mov       edx,r10d
       cmp       rax,rdx
       jae       short M08_L04
       xor       edx,edx
       mov       [r8+rax*8+10],rdx
       jmp       short M08_L05
M08_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC03917A50]
       int       3
M08_L02:
       mov       rcx,[rbp-20]
       call      qword ptr [7FFC03016EC8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M08_L00
M08_L03:
       mov       rcx,rax
       call      qword ptr [7FFC03AA4F00]
       int       3
M08_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L05:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       jne       short M08_L09
M08_L06:
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rbx
M08_L07:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M08_L08:
       call      M08_L13
       jmp       short M08_L10
M08_L09:
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC0301CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M08_L06
M08_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M08_L11
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rcx,offset MT_System.Buffers.MemoryPool<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC0382D6C8]
       jmp       short M08_L12
M08_L11:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC0382D6E0]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]]..ctor(System.Buffers.ArrayPool`1<Byte>)
M08_L12:
       mov       dword ptr [rsi+30],8000
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       mov       [rax],rcx
       mov       [rax+8],rsi
       jmp       near ptr M08_L07
M08_L13:
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M08_L15
       cmp       qword ptr [rbp-20],0
       jne       short M08_L14
       xor       ecx,ecx
       call      qword ptr [7FFC03917A50]
       int       3
M08_L14:
       mov       rcx,[rbp-20]
       call      00007FFC628B6030
       test      eax,eax
       je        short M08_L15
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC0301CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M08_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].GetSegment(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        near ptr M09_L14
       xor       edx,edx
       mov       [rsp+48],rdx
       test      esi,esi
       je        near ptr M09_L15
       mov       rcx,[rbx+28]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M09_L01
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M09_L17
       mov       eax,[rdx+8]
M09_L00:
       sub       eax,[rdi+3C]
       jo        near ptr M09_L35
       cmp       eax,esi
       jge       short M09_L03
M09_L01:
       mov       ecx,[rbx+30]
       cmp       ecx,esi
       cmovl     ecx,esi
       mov       [rsp+4C],ecx
M09_L02:
       mov       byte ptr [rsp+48],1
M09_L03:
       cmp       byte ptr [rsp+48],0
       je        near ptr M09_L12
       mov       rcx,[rbx+8]
       mov       eax,[rcx+10]
       test      eax,eax
       jle       near ptr M09_L19
       dec       eax
       mov       rdx,[rcx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       near ptr M09_L20
       inc       dword ptr [rcx+14]
       mov       [rcx+10],eax
       mov       ecx,eax
       mov       rsi,[rdx+rcx*8+10]
       mov       ecx,eax
       cmp       rcx,r8
       jae       near ptr M09_L34
       mov       ecx,eax
       xor       eax,eax
       mov       [rdx+rcx*8+10],rax
M09_L04:
       mov       rdi,rsi
       mov       rbp,[rbx+18]
       test      rbp,rbp
       je        near ptr M09_L25
       cmp       byte ptr [rsp+48],0
       je        near ptr M09_L21
       cmp       dword ptr [rsp+4C],0FFFFFFFF
       je        near ptr M09_L22
       mov       edx,[rsp+4C]
M09_L05:
       mov       rcx,offset MT_System.Buffers.ConfigurableArrayPool<System.Byte>
       cmp       [rbp],rcx
       jne       near ptr M09_L23
       mov       rcx,rbp
       call      qword ptr [7FFC0364A450]; System.Buffers.ConfigurableArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       r14,rax
M09_L06:
       lea       rcx,[rdi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M09_L24
       mov       rdx,r14
       mov       ebp,[rdx+8]
M09_L07:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+20],eax
       mov       [rdi+24],ebp
M09_L08:
       mov       rbp,[rbx+28]
       test      rbp,rbp
       je        near ptr M09_L13
       mov       rcx,rbp
       mov       esi,[rcx+3C]
       mov       r14d,[rcx+38]
       sub       esi,r14d
       jo        near ptr M09_L35
       test      esi,esi
       jle       near ptr M09_L30
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,r14d
       add       rdx,[rbp+10]
       jo        near ptr M09_L35
       mov       ecx,esi
       add       rdx,rcx
       jo        near ptr M09_L35
       mov       [rdi+10],rdx
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M09_L26
M09_L09:
       test      rdx,rdx
       je        near ptr M09_L27
       mov       eax,[rdx+8]
       xor       esi,esi
M09_L10:
       mov       ecx,[rbp+38]
       mov       r14d,[rbp+3C]
       sub       r14d,ecx
       jo        near ptr M09_L35
       add       r14d,ecx
       jo        near ptr M09_L35
       cmp       r14d,eax
       ja        near ptr M09_L29
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       mov       [rbp+24],r14d
M09_L11:
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M09_L12:
       mov       rax,[rbx+28]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L13:
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L12
M09_L14:
       mov       ecx,1C1
       mov       rdx,7FFC035F9B70
       call      qword ptr [7FFC02CFF210]
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFC0382D908]
       int       3
M09_L15:
       mov       rdi,[rbx+28]
       test      rdi,rdi
       je        short M09_L16
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0382D860]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_WritableBytes()
       test      eax,eax
       jne       near ptr M09_L03
M09_L16:
       mov       dword ptr [rsp+4C],0FFFFFFFF
       jmp       near ptr M09_L02
M09_L17:
       mov       rcx,[rdi+30]
       test      rcx,rcx
       jne       short M09_L18
       xor       eax,eax
       jmp       near ptr M09_L00
M09_L18:
       lea       rdx,[rsp+38]
       mov       r11,7FFC02C417B0
       call      qword ptr [r11]
       mov       eax,[rsp+44]
       jmp       near ptr M09_L00
M09_L19:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       jmp       near ptr M09_L04
M09_L20:
       call      qword ptr [7FFC03AA4F00]
       int       3
M09_L21:
       call      qword ptr [7FFC03325ED8]
       int       3
M09_L22:
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>
       call      qword ptr [7FFC02CF5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[7FFC02C3B1C8]
       jmp       near ptr M09_L05
M09_L23:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M09_L06
M09_L24:
       xor       edx,edx
       xor       ebp,ebp
       jmp       near ptr M09_L07
M09_L25:
       mov       rbp,[rbx+10]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFC0332F5E8]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       edx,eax
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0382D8D8]
       jmp       near ptr M09_L08
M09_L26:
       cmp       qword ptr [rbp+30],0
       je        near ptr M09_L11
       jmp       near ptr M09_L09
M09_L27:
       mov       rcx,[rbp+30]
       test      rcx,rcx
       jne       short M09_L28
       xor       edx,edx
       xor       esi,esi
       xor       eax,eax
       jmp       near ptr M09_L10
M09_L28:
       lea       rdx,[rsp+28]
       mov       r11,7FFC02C417B8
       call      qword ptr [r11]
       mov       rdx,[rsp+28]
       mov       esi,[rsp+30]
       mov       eax,[rsp+34]
       jmp       near ptr M09_L10
M09_L29:
       call      qword ptr [7FFC02F2F1B0]
       int       3
M09_L30:
       mov       rsi,[rbx+20]
       cmp       [rbx+20],rbp
       jne       short M09_L32
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L33
M09_L31:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
M09_L32:
       mov       rdx,[rsi+8]
       mov       rcx,offset MT_Nerdbank.Streams.Sequence<System.Byte>+SequenceSegment
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       cmp       rax,[rbx+28]
       jne       short M09_L31
M09_L33:
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC0382D980]; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].SetNext(SequenceSegment<Byte>)
       mov       rdx,[rbx+28]
       mov       rcx,rbx
       call      qword ptr [7FFC0382D9B0]; Nerdbank.Streams.Sequence`1[[System.Byte, System.Private.CoreLib]].RecycleAndGetNext(SequenceSegment<Byte>)
       jmp       near ptr M09_L11
M09_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 975
```
```assembly
; Nerdbank.Streams.Sequence`1+SequenceSegment[[System.Byte, System.Private.CoreLib]].get_RemainingSpan()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M10_L03
       mov       edi,[rcx+8]
       xor       ebp,ebp
M10_L00:
       xor       r14d,r14d
       xor       r15d,r15d
       test      rcx,rcx
       je        short M10_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M10_L05
       lea       r14,[rcx+10]
       mov       r15d,[rcx+8]
M10_L01:
       and       ebp,7FFFFFFF
       mov       eax,ebp
       mov       ecx,edi
       add       rcx,rax
       mov       edx,r15d
       cmp       rcx,rdx
       ja        near ptr M10_L06
       add       r14,rax
       mov       r15d,edi
M10_L02:
       mov       eax,[rsi+3C]
       cmp       eax,r15d
       ja        short M10_L06
       mov       ecx,eax
       add       rcx,r14
       sub       r15d,eax
       mov       [rbx],rcx
       mov       [rbx+8],r15d
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       short M10_L04
       xor       ecx,ecx
       xor       ebp,ebp
       xor       edi,edi
       jmp       short M10_L00
M10_L04:
       lea       rdx,[rsp+38]
       mov       r11,7FFC02C419D8
       call      qword ptr [r11]
       mov       rcx,[rsp+38]
       mov       ebp,[rsp+40]
       mov       edi,[rsp+44]
       jmp       near ptr M10_L00
M10_L05:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,[rsp+28]
       mov       r15d,[rsp+30]
       jmp       near ptr M10_L01
M10_L06:
       call      qword ptr [7FFC02F2F1B0]
       int       3
; Total bytes of code 248
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M11_L02
M11_L00:
       cmp       rcx,rdx
       je        near ptr M11_L14
M11_L01:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M11_L02:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M11_L00
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M11_L06
       cmp       r8,40
       jbe       short M11_L03
       cmp       r8,800
       ja        short M11_L01
       jmp       near ptr M11_L11
M11_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M11_L08
M11_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M11_L05:
       vzeroupper
       ret
M11_L06:
       test      r8b,18
       je        short M11_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M11_L05
M11_L07:
       test      r8b,4
       je        short M11_L10
       jmp       short M11_L09
M11_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M11_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M11_L04
M11_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M11_L05
M11_L10:
       test      r8,r8
       je        short M11_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M11_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M11_L05
M11_L11:
       cmp       r8,100
       jb        short M11_L12
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
M11_L12:
       mov       r9,r8
       shr       r9,6
M11_L13:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M11_L13
       and       r8,3F
       cmp       r8,10
       ja        near ptr M11_L03
       jmp       near ptr M11_L04
M11_L14:
       cmp       [rdx],dl
       jmp       near ptr M11_L05
; Total bytes of code 322
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M12_L00
       cmp       [rdx],rcx
       jne       short M12_L01
M12_L00:
       mov       rax,rdx
       ret
M12_L01:
       jmp       qword ptr [7FFC02F24D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2391A560008
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
       call      qword ptr [7FFC0391DC98]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       add       rax,240
       add       rax,0FFFFFFFFFFFFFFF8
       mov       edx,ecx
       and       edx,0FFFFFF
       mov       r8d,edx
       mov       r10d,ecx
       sar       r10d,18
       jne       short M14_L01
       cmp       [rax],edx
       jle       short M14_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       r8d,0FFFFFFFE
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8+10]
       test      rax,rax
       je        short M14_L03
M14_L00:
       ret
M14_L01:
       mov       edx,ecx
       sar       edx,18
       cmp       edx,2
       jne       short M14_L02
       movsxd    rcx,r8d
       add       rax,rcx
       jmp       short M14_L00
M14_L02:
       cmp       [rax+4],r8d
       jle       short M14_L03
       mov       rax,[rax+10]
       movsxd    rdx,r8d
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M14_L03
       mov       rax,[rax]
       test      rax,rax
       je        short M14_L03
       jmp       short M14_L00
M14_L03:
       jmp       qword ptr [7FFC02CFD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
; Total bytes of code 127
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        short M16_L00
       mov       rcx,7FFC0398347C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,[rbx+8]
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r8d,esi
       mov       rdx,[rbx]
       lea       rcx,[rdi+10]
       call      qword ptr [7FFC02CF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,7FFC03983478
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,2391A566EF8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 115
```
```assembly
; System.ReadOnlyMemory`1[[System.Byte, System.Private.CoreLib]].get_Span()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M17_L01
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M17_L02
       lea       rdi,[rcx+10]
       mov       ebp,[rcx+8]
M17_L00:
       mov       eax,[rbx+8]
       and       eax,7FFFFFFF
       mov       ecx,[rbx+0C]
       mov       edx,ecx
       add       rdx,rax
       mov       r8d,ebp
       cmp       rdx,r8
       ja        short M17_L03
       add       rdi,rax
       mov       ebp,ecx
M17_L01:
       mov       [rsi],rdi
       mov       [rsi+8],ebp
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M17_L02:
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+28]
       mov       ebp,[rsp+30]
       jmp       short M17_L00
M17_L03:
       call      qword ptr [7FFC02F2F1B0]
       int       3
; Total bytes of code 131
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       jmp       near ptr M00_L15
M00_L00:
       cmp       edx,4
       jb        near ptr M00_L35
M00_L01:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L20
M00_L02:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L25
M00_L03:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC03565A70]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L28
M00_L04:
       mov       r8d,[r14+1C]
       mov       ecx,[r14+18]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L49
       test      r8d,r8d
       jle       near ptr M00_L49
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,[r14+18]
       test      r13d,r13d
       jle       short M00_L06
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       test      r8,r8
       je        near ptr M00_L46
       cmp       [r8+8],ecx
       jb        near ptr M00_L50
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L05:
       cmp       r13d,r8d
       ja        near ptr M00_L53
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L06:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L51
       cmp       edx,r12d
       jl        near ptr M00_L51
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L09
M00_L07:
       cmp       r12d,edx
       jl        short M00_L10
       mov       eax,r12d
M00_L08:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L52
       cmp       eax,400
       jge       short M00_L11
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
       jmp       short M00_L12
M00_L09:
       mov       edx,1F40
       jmp       short M00_L07
M00_L10:
       mov       eax,edx
       jmp       short M00_L08
M00_L11:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC032F72D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
M00_L12:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L47
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L13:
       cmp       r12d,r8d
       ja        near ptr M00_L53
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
M00_L14:
       inc       ebp
M00_L15:
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jle       near ptr M00_L29
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L30
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L30
M00_L16:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L17
       mov       rcx,1E82D400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L17
       mov       rcx,1E82D400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L31
M00_L17:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L33
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L32
       mov       r11,7FFC02C00D10
       mov       rdx,228C24C31C8
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L18:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L54
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L34
       mov       rcx,1E82D400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L38
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0AF941BAB
       mov       r8d,283132DD
       cmp       edx,8
       jb        near ptr M00_L00
       mov       r10d,edx
       shr       r10d,3
M00_L19:
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
       jne       short M00_L19
       test      dl,4
       jne       near ptr M00_L01
M00_L20:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L21:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L22:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L39
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L50
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L40
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        near ptr M00_L45
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        near ptr M00_L02
       cmp       r14d,64
       jb        short M00_L24
       mov       rdx,228C24B20A4
M00_L23:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L23
M00_L24:
       cmp       ecx,0A
       jb        near ptr M00_L02
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,228C24B20A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L25:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L26:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L27:
       test      r13d,r13d
       je        near ptr M00_L03
       cmp       [rsp+68],r15d
       ja        near ptr M00_L48
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L28:
       mov       r14,[rsp+70]
       mov       r15,228C24B0E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       cmp       [r8+8],edx
       jb        near ptr M00_L04
       movsxd    rdx,ecx
       mov       word ptr [r8+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,rdi
       call      qword ptr [7FFC02FF21E0]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L30:
       mov       ecx,2
       call      qword ptr [7FFC035E4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L16
M00_L31:
       call      qword ptr [7FFC02CBD590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L17
M00_L32:
       xor       ecx,ecx
       jmp       near ptr M00_L18
M00_L33:
       xor       ecx,ecx
       jmp       near ptr M00_L18
M00_L34:
       xor       edx,edx
       jmp       near ptr M00_L22
M00_L35:
       mov       r10d,80
       test      dl,1
       je        short M00_L36
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L36:
       test      dl,2
       je        short M00_L37
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L21
M00_L37:
       mov       ecx,r10d
       jmp       near ptr M00_L21
M00_L38:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L22
M00_L39:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC03565AA0]
       jmp       near ptr M00_L28
M00_L40:
       test      rcx,rcx
       je        short M00_L41
       call      qword ptr [7FFC032F5428]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L42
M00_L41:
       call      qword ptr [7FFC02CBD380]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L42:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L43
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L44
M00_L43:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L44:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03565B18]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L27
M00_L45:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L26
M00_L46:
       test      ecx,ecx
       jne       short M00_L50
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L05
M00_L47:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L13
M00_L48:
       call      qword ptr [7FFC03565AE8]
       int       3
M00_L49:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02BF4000
       call      qword ptr [7FFC02CBF2E8]
       mov       rsi,rax
       call      qword ptr [7FFC035E4EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03276AC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       call      qword ptr [7FFC02EFF888]
       int       3
M00_L51:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02BF4000
       call      qword ptr [7FFC02CBF2E8]
       mov       rsi,rax
       call      qword ptr [7FFC035E4ED0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03276AC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC035E4EE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      qword ptr [7FFC0316CDC8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2009
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,4EC5A3A05B98
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r14d,r8d
       mov       rbx,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M01_L18
       xor       r15d,r15d
M01_L00:
       mov       [rbp+44],r15b
       mov       r15d,edi
       cmp       byte ptr [rbp+44],0
       jne       near ptr M01_L07
M01_L01:
       mov       edx,[rbp+40]
       mov       edi,[rbp+50]
       cmp       edx,edi
       ja        near ptr M01_L26
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       r13,[r8+rcx*2]
       sub       edi,edx
       test      rbx,rbx
       jne       short M01_L04
       xor       r12d,r12d
       xor       eax,eax
M01_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M01_L05
       test      r15d,r15d
       jl        near ptr M01_L21
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FD7810]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M01_L03:
       test      eax,eax
       je        short M01_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M01_L08
M01_L04:
       lea       r12,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M01_L02
M01_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03427330]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M01_L03
M01_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC035E4E10]
       jmp       near ptr M01_L01
M01_L07:
       lea       rcx,[rbp+30]
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [7FFC035E4B10]
M01_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M01_L26
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M01_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M01_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M01_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M01_L11
       test      ecx,ecx
       jne       short M01_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC035E5188]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FD77B0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M01_L14
M01_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FD77B0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC035E5188]
       jmp       short M01_L14
M01_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FD77B0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L14
M01_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M01_L14
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L17
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M01_L28
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M01_L27
M01_L13:
       add       ebx,r14d
       mov       [rsi+18],ebx
M01_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M01_L15
       mov       rcx,1E82D400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC03022528]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L15:
       mov       r8,4EC5A3A05B98
       cmp       [rbp],r8
       je        short M01_L16
       call      CORINFO_HELP_FAIL_FAST
M01_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FD7840]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L14
M01_L18:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M01_L19
       mov       r11,7FFC02C00D00
       mov       rdx,228C24C31C8
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M01_L20
M01_L19:
       xor       r15d,r15d
M01_L20:
       jmp       near ptr M01_L00
M01_L21:
       test      r9,r9
       je        short M01_L22
       mov       rcx,r9
       call      qword ptr [7FFC032F5428]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L23
M01_L22:
       call      qword ptr [7FFC02CBD380]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L23:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L24
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L25
M01_L24:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L25:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03565B18]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M01_L03
M01_L26:
       call      qword ptr [7FFC02EFF888]
       int       3
M01_L27:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L13
M01_L28:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L13
; Total bytes of code 860
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M02_L05
       cmp       r8,40
       jbe       near ptr M02_L04
       cmp       r8,800
       ja        near ptr M02_L09
       cmp       r8,100
       jb        short M02_L00
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
M02_L00:
       mov       r9,r8
       shr       r9,6
M02_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L01
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
M02_L02:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L03:
       vzeroupper
       ret
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L02
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      r8b,18
       je        short M02_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L03
M02_L06:
       test      r8b,4
       je        short M02_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L03
M02_L07:
       test      r8,r8
       je        short M02_L03
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L03
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L03
M02_L08:
       cmp       rcx,rdx
       jne       short M02_L09
       cmp       [rdx],dl
       jmp       short M02_L03
M02_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFC62718018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFC62718020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
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
; Total bytes of code 193
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,228C24B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02BF4000
       call      qword ptr [7FFC02CBF2E8]
       mov       rbx,rax
       call      qword ptr [7FFC035E4F00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03276AC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CB6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C00CF8
       mov       rdx,228C24B1518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CB6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CBD380]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,228C24B20A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jg        near ptr M00_L14
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFC03010A18]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       movsxd    rcx,r13d
       mov       word ptr [rax+rcx*2+10],2D
       inc       r13d
       mov       [r14+18],r13d
       jmp       near ptr M00_L13
M00_L02:
       cmp       edx,4
       jb        near ptr M00_L36
M00_L03:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L19
M00_L04:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L24
M00_L05:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L25
M00_L06:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0356CF30]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L27
M00_L07:
       mov       edx,1F40
       jmp       near ptr M00_L30
M00_L08:
       mov       eax,r12d
M00_L09:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L52
       cmp       eax,400
       jl        short M00_L10
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC0330E868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L11
M00_L10:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L11:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L47
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L12:
       cmp       r12d,r8d
       ja        near ptr M00_L53
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
M00_L13:
       inc       ebp
       mov       eax,[rsi+8]
       movsxd    rcx,ebp
       cmp       rax,rcx
       jle       near ptr M00_L00
M00_L14:
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L31
M00_L15:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L16
       mov       rcx,1ECB4C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L16
       mov       rcx,1ECB4C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L32
M00_L16:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L34
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L33
       mov       r11,7FFC02C20F48
       mov       rdx,22D49D43230
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L17:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L54
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,1ECB4C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,99DDFD08
       mov       r8d,852A4F2
       cmp       edx,8
       jb        near ptr M00_L02
       mov       r10d,edx
       shr       r10d,3
M00_L18:
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
       jne       short M00_L18
       test      dl,4
       jne       near ptr M00_L03
M00_L19:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L20:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L21:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L40
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L50
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L41
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        near ptr M00_L05
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        near ptr M00_L04
       cmp       r14d,64
       jb        short M00_L23
       mov       rdx,22D49D320A4
       nop
M00_L22:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L22
M00_L23:
       cmp       ecx,0A
       jb        near ptr M00_L04
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,22D49D320A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L24:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L25:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L26:
       test      r13d,r13d
       je        near ptr M00_L06
       cmp       [rsp+68],r15d
       ja        near ptr M00_L48
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L27:
       mov       r14,[rsp+70]
       mov       r15,22D49D30E7C
       mov       r8,[r14+8]
       mov       rax,r8
       mov       ecx,[r14+18]
       mov       r13d,ecx
       lea       edx,[r13+1]
       cmp       [rax+8],edx
       jae       near ptr M00_L01
       mov       edx,[r14+1C]
       lea       edx,[rdx+rcx+1]
       cmp       edx,[r14+20]
       jg        near ptr M00_L49
       test      edx,edx
       jle       near ptr M00_L49
       mov       r13d,[r8+8]
       sub       r13d,ecx
       test      r13d,r13d
       jle       short M00_L29
       test      r8,r8
       je        near ptr M00_L46
       cmp       [r8+8],ecx
       jb        near ptr M00_L50
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L28:
       cmp       r13d,r8d
       ja        near ptr M00_L53
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L29:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L51
       cmp       edx,r12d
       jl        near ptr M00_L51
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        near ptr M00_L07
M00_L30:
       cmp       r12d,edx
       jge       near ptr M00_L08
       mov       eax,edx
       jmp       near ptr M00_L09
M00_L31:
       mov       ecx,2
       call      qword ptr [7FFC03625140]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L15
M00_L32:
       call      qword ptr [7FFC02CDD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L16
M00_L33:
       xor       ecx,ecx
       jmp       near ptr M00_L17
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L17
M00_L35:
       xor       edx,edx
       jmp       near ptr M00_L21
M00_L36:
       mov       r10d,80
       test      dl,1
       je        short M00_L37
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L37:
       test      dl,2
       je        short M00_L38
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L20
M00_L38:
       mov       ecx,r10d
       jmp       near ptr M00_L20
M00_L39:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L21
M00_L40:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC0356CF60]
       jmp       near ptr M00_L27
M00_L41:
       test      rcx,rcx
       je        short M00_L42
       call      qword ptr [7FFC03304DC8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L43
M00_L42:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L43:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L44
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L45
M00_L44:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L45:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0356CFD8]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L26
M00_L46:
       test      ecx,ecx
       jne       short M00_L50
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L28
M00_L47:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L12
M00_L48:
       call      qword ptr [7FFC0356CFA8]
       int       3
M00_L49:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03625338]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286460]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L51:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03625350]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286460]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03625368]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      qword ptr [7FFC0318C738]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2021
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,22D49D30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       call      qword ptr [7FFC03624CA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03286460]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,9A3C9952C8B8
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L19
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L18
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L22
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FF7138]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0346E850]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0362E868]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0362E5F8]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L18
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0362E9A0]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L13
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0362E9A0]
       jmp       short M02_L13
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L13
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L13
       mov       r14,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+rbx]
       cmp       ecx,[r14+8]
       jbe       short M02_L16
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L13:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L14
       mov       rcx,1ECB4C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC03030980]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L14:
       mov       r8,9A3C9952C8B8
       cmp       [rbp],r8
       je        short M02_L15
       call      CORINFO_HELP_FAIL_FAST
M02_L15:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L16:
       movsxd    r8,r15d
       lea       rcx,[r14+r8*2+10]
       cmp       ebx,2
       jg        near ptr M02_L28
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L27
M02_L17:
       add       ebx,r15d
       mov       [rsi+18],ebx
       jmp       near ptr M02_L13
M02_L18:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M02_L19:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L20
       mov       r11,7FFC02C20F38
       mov       rdx,22D49D43230
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L21
M02_L20:
       xor       r15d,r15d
M02_L21:
       jmp       near ptr M02_L00
M02_L22:
       test      r9,r9
       je        short M02_L23
       mov       rcx,r9
       call      qword ptr [7FFC03304DC8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L24
M02_L23:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L24:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L25
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L26
M02_L25:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L26:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0356CFD8]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L27:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L17
M02_L28:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L17
; Total bytes of code 862
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F37720
       mov       [rbp-68],rax
       lea       rax,[M03_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M03_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M03_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M04_L06
       cmp       r8,40
       jbe       short M04_L02
       cmp       r8,800
       ja        near ptr M04_L10
       cmp       r8,100
       jb        short M04_L00
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
M04_L00:
       mov       r9,r8
       shr       r9,6
M04_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M04_L03
M04_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L05
M04_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L04:
       vzeroupper
       ret
M04_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L03
M04_L06:
       test      r8b,18
       je        short M04_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L04
M04_L07:
       test      r8b,4
       jne       short M04_L08
       test      r8,r8
       je        short M04_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L04
M04_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M04_L04
M04_L09:
       cmp       rcx,rdx
       jne       short M04_L10
       cmp       [rdx],dl
       jmp       short M04_L04
M04_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 313
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C20F20
       mov       rdx,22D49D31518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,22D49D320A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jg        near ptr M00_L09
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFC03016DF8]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       cmp       edx,4
       jb        near ptr M00_L37
M00_L02:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L14
M00_L03:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,2855A5020A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L04:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L05:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L06:
       test      r13d,r13d
       je        near ptr M00_L21
       cmp       [rsp+68],r15d
       ja        near ptr M00_L49
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L07:
       mov       r14,[rsp+70]
       mov       r15,2855A500E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       cmp       [r8+8],edx
       jb        near ptr M00_L22
       movsxd    rdx,ecx
       mov       word ptr [r8+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
M00_L08:
       inc       ebp
       mov       eax,[rsi+8]
       movsxd    rcx,ebp
       cmp       rax,rcx
       jle       near ptr M00_L00
M00_L09:
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L32
M00_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,244C5400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,244C5400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L11:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L35
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L34
       mov       r11,7FFC02C30F48
       mov       rdx,2855A513230
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L12:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L55
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L36
       mov       rcx,244C5400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,63B7D688
       mov       r8d,0E6013E52
       cmp       edx,8
       jb        near ptr M00_L01
       mov       r10d,edx
       shr       r10d,3
M00_L13:
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
       jne       short M00_L13
       test      dl,4
       jne       near ptr M00_L02
M00_L14:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L16:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L41
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L51
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L42
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        short M00_L20
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        short M00_L19
       cmp       r14d,64
       jb        short M00_L18
       mov       rdx,2855A5020A4
       nop       dword ptr [rax]
M00_L17:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L17
M00_L18:
       cmp       ecx,0A
       jae       near ptr M00_L03
M00_L19:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L04
M00_L20:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L21:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC034FCFA8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L07
M00_L22:
       mov       r8d,[r14+1C]
       mov       ecx,[r14+18]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L50
       test      r8d,r8d
       jle       near ptr M00_L50
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,[r14+18]
       test      r13d,r13d
       jle       short M00_L24
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       test      r8,r8
       je        near ptr M00_L47
       cmp       [r8+8],ecx
       jb        near ptr M00_L51
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L23:
       cmp       r13d,r8d
       ja        near ptr M00_L54
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L24:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L52
       cmp       edx,r12d
       jl        near ptr M00_L52
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L26
M00_L25:
       cmp       r12d,edx
       jge       short M00_L27
       mov       eax,edx
       jmp       short M00_L28
M00_L26:
       mov       edx,1F40
       jmp       short M00_L25
M00_L27:
       mov       eax,r12d
M00_L28:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L53
       cmp       eax,400
       jl        short M00_L29
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC0331E8E0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L30
M00_L29:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L30:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L48
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L31:
       cmp       r12d,r8d
       ja        near ptr M00_L54
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
       jmp       near ptr M00_L08
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFC03635188]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L33:
       call      qword ptr [7FFC02CED4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L36:
       xor       edx,edx
       jmp       near ptr M00_L16
M00_L37:
       mov       r10d,80
       test      dl,1
       je        short M00_L38
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L38:
       test      dl,2
       je        short M00_L39
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L40:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L16
M00_L41:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC034FCFD8]
       jmp       near ptr M00_L07
M00_L42:
       test      rcx,rcx
       je        short M00_L43
       call      qword ptr [7FFC03314DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L44
M00_L43:
       call      qword ptr [7FFC02CED2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L44:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L45
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L46
M00_L45:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L46:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC034FD050]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L06
M00_L47:
       test      ecx,ecx
       jne       short M00_L51
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L23
M00_L48:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L31
M00_L49:
       call      qword ptr [7FFC034FD020]
       int       3
M00_L50:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C24000
       call      qword ptr [7FFC02CEF210]
       mov       rsi,rax
       call      qword ptr [7FFC03635368]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03296490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       call      qword ptr [7FFC02F1FA98]
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C24000
       call      qword ptr [7FFC02CEF210]
       mov       rsi,rax
       call      qword ptr [7FFC03635380]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03296490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03635398]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFC0319C768]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2014
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,2855A500008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C24000
       call      qword ptr [7FFC02CEF210]
       mov       rbx,rax
       call      qword ptr [7FFC03634CF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03296490]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,0B29717205062
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L18
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L17
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L21
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC03007A08]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0347E8C8]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0363E880]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0363E610]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L17
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363E9B8]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC030079A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC030079A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363E9B8]
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC030079A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L14
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L14
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       r14d,[rcx+rbx]
       cmp       r14d,[r8+8]
       ja        near ptr M02_L28
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M02_L27
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L26
M02_L13:
       mov       [rsi+18],r14d
M02_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L15
       mov       rcx,244C5400398
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC02FB80C0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L15:
       mov       r8,0B29717205062
       cmp       [rbp],r8
       je        short M02_L16
       call      CORINFO_HELP_FAIL_FAST
M02_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       call      qword ptr [7FFC02F1FA98]
       int       3
M02_L18:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L19
       mov       r11,7FFC02C30F38
       mov       rdx,2855A513230
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L20
M02_L19:
       xor       r15d,r15d
M02_L20:
       jmp       near ptr M02_L00
M02_L21:
       test      r9,r9
       je        short M02_L22
       mov       rcx,r9
       call      qword ptr [7FFC03314DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L23
M02_L22:
       call      qword ptr [7FFC02CED2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L23:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L24
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L25
M02_L24:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L25:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC034FD050]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L26:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L13
M02_L27:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L13
M02_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC03007A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L14
; Total bytes of code 866
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M03_L06
       cmp       r8,40
       jbe       short M03_L02
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L00
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
M03_L00:
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L03
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L05
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
M03_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L06:
       test      r8b,18
       je        short M03_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L04
M03_L07:
       test      r8b,4
       jne       short M03_L08
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L04
M03_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L04
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       short M03_L04
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 313
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F47720
       mov       [rbp-68],rax
       lea       rax,[M04_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M04_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M04_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C30F20
       mov       rdx,2855A501518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CED2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,2855A5020A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jg        near ptr M00_L09
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFC03010A18]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       cmp       edx,4
       jb        near ptr M00_L37
M00_L02:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L14
M00_L03:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,271064920A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L04:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L05:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L06:
       test      r13d,r13d
       je        near ptr M00_L21
       cmp       [rsp+68],r15d
       ja        near ptr M00_L49
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L07:
       mov       r14,[rsp+70]
       mov       r15,27106490E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       mov       edx,ecx
       lea       eax,[rdx+1]
       cmp       [r8+8],eax
       jb        near ptr M00_L22
       movsxd    rcx,edx
       mov       word ptr [r8+rcx*2+10],2D
       inc       edx
       mov       [r14+18],edx
M00_L08:
       inc       ebp
       mov       eax,[rsi+8]
       movsxd    rcx,ebp
       cmp       rax,rcx
       jle       near ptr M00_L00
M00_L09:
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L32
M00_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,23071400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,23071400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L11:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L35
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L34
       mov       r11,7FFC02C20F48
       mov       rdx,271064A3230
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L12:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L55
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L36
       mov       rcx,23071400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0E72D622
       mov       r8d,4354B967
       cmp       edx,8
       jb        near ptr M00_L01
       mov       r10d,edx
       shr       r10d,3
M00_L13:
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
       jne       short M00_L13
       test      dl,4
       jne       near ptr M00_L02
M00_L14:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L16:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L41
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L51
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L42
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        short M00_L20
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        short M00_L19
       cmp       r14d,64
       jb        short M00_L18
       mov       rdx,271064920A4
       nop
M00_L17:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L17
M00_L18:
       cmp       ecx,0A
       jae       near ptr M00_L03
M00_L19:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L04
M00_L20:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L21:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354CAC8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L07
M00_L22:
       mov       r8d,[r14+1C]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L50
       test      r8d,r8d
       jle       near ptr M00_L50
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,ecx
       test      r13d,r13d
       jle       short M00_L24
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L47
       cmp       [r8+8],ecx
       jb        near ptr M00_L51
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L23:
       cmp       r13d,r8d
       ja        near ptr M00_L54
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L24:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L52
       cmp       edx,r12d
       jl        near ptr M00_L52
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L26
M00_L25:
       cmp       r12d,edx
       jge       short M00_L27
       mov       eax,edx
       jmp       short M00_L28
M00_L26:
       mov       edx,1F40
       jmp       short M00_L25
M00_L27:
       mov       eax,r12d
M00_L28:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L53
       cmp       eax,400
       jl        short M00_L29
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC0330E3A0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L30
M00_L29:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L30:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L48
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L31:
       cmp       r12d,r8d
       ja        near ptr M00_L54
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
       jmp       near ptr M00_L08
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFC03635188]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L33:
       call      qword ptr [7FFC02CDD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L36:
       xor       edx,edx
       jmp       near ptr M00_L16
M00_L37:
       mov       r10d,80
       test      dl,1
       je        short M00_L38
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L38:
       test      dl,2
       je        short M00_L39
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L40:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L16
M00_L41:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC0354CAF8]
       jmp       near ptr M00_L07
M00_L42:
       test      rcx,rcx
       je        short M00_L43
       call      qword ptr [7FFC03304DC8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L44
M00_L43:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L44:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L45
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L46
M00_L45:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L46:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354CB70]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L06
M00_L47:
       test      ecx,ecx
       jne       short M00_L51
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L23
M00_L48:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L31
M00_L49:
       call      qword ptr [7FFC0354CB40]
       int       3
M00_L50:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03635380]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286460]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03635398]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286460]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC036353B0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFC0318C738]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2005
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,27106490008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       call      qword ptr [7FFC03634CF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03286460]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,79B02578EBDD
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L19
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L18
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L22
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FF7138]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0345E3A0]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0363E898]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0363E628]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L18
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363E9D0]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363E9D0]
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L14
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L14
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M02_L17
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M02_L28
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L27
M02_L13:
       add       ebx,r14d
       mov       [rsi+18],ebx
M02_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L15
       mov       rcx,23071400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC03030980]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L15:
       mov       r8,79B02578EBDD
       cmp       [rbp],r8
       je        short M02_L16
       call      CORINFO_HELP_FAIL_FAST
M02_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L14
M02_L18:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M02_L19:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L20
       mov       r11,7FFC02C20F38
       mov       rdx,271064A3230
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L21
M02_L20:
       xor       r15d,r15d
M02_L21:
       jmp       near ptr M02_L00
M02_L22:
       test      r9,r9
       je        short M02_L23
       mov       rcx,r9
       call      qword ptr [7FFC03304DC8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L24
M02_L23:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L24:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L25
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L26
M02_L25:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L26:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354CB70]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L27:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L13
M02_L28:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L13
; Total bytes of code 866
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       jne       short M03_L02
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       jbe       short M03_L06
       cmp       r8,800
       ja        near ptr M03_L08
       cmp       r8,100
       jb        short M03_L04
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
M03_L04:
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L07
M03_L06:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L07
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L07
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L07:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L08:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L08
       cmp       [rdx],dl
       jmp       near ptr M03_L00
; Total bytes of code 315
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F37720
       mov       [rbp-68],rax
       lea       rax,[M04_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M04_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M04_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C20F20
       mov       rdx,27106491518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,271064920A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jg        near ptr M00_L09
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFC02FF6890]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       cmp       edx,4
       jb        near ptr M00_L37
M00_L02:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L14
M00_L03:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,21D67B520A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L04:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L05:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L06:
       test      r13d,r13d
       je        near ptr M00_L21
       cmp       [rsp+68],r15d
       ja        near ptr M00_L49
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L07:
       mov       r14,[rsp+70]
       mov       r15,21D67B50E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       cmp       [r8+8],edx
       jb        near ptr M00_L22
       movsxd    rdx,ecx
       mov       word ptr [r8+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
M00_L08:
       inc       ebp
       mov       eax,[rsi+8]
       movsxd    rcx,ebp
       cmp       rax,rcx
       jle       near ptr M00_L00
M00_L09:
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L32
M00_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1DCD2C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1DCD2C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L11:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L35
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L34
       mov       r11,7FFC02C10F68
       mov       rdx,21D67B631B0
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L12:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L55
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L36
       mov       rcx,1DCD2C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8F736B29
       mov       r8d,5167053D
       cmp       edx,8
       jb        near ptr M00_L01
       mov       r10d,edx
       shr       r10d,3
M00_L13:
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
       jne       short M00_L13
       test      dl,4
       jne       near ptr M00_L02
M00_L14:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L16:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L41
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L51
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L42
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        short M00_L20
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        short M00_L19
       cmp       r14d,64
       jb        short M00_L18
       mov       rdx,21D67B520A4
       nop       dword ptr [rax]
M00_L17:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L17
M00_L18:
       cmp       ecx,0A
       jae       near ptr M00_L03
M00_L19:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L04
M00_L20:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L21:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0353CBB8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L07
M00_L22:
       mov       r8d,[r14+1C]
       mov       ecx,[r14+18]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L50
       test      r8d,r8d
       jle       near ptr M00_L50
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,[r14+18]
       test      r13d,r13d
       jle       short M00_L24
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       test      r8,r8
       je        near ptr M00_L47
       cmp       [r8+8],ecx
       jb        near ptr M00_L51
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L23:
       cmp       r13d,r8d
       ja        near ptr M00_L54
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L24:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L52
       cmp       edx,r12d
       jl        near ptr M00_L52
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L26
M00_L25:
       cmp       r12d,edx
       jge       short M00_L27
       mov       eax,edx
       jmp       short M00_L28
M00_L26:
       mov       edx,1F40
       jmp       short M00_L25
M00_L27:
       mov       eax,r12d
M00_L28:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L53
       cmp       eax,400
       jl        short M00_L29
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC032FE3B8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L30
M00_L29:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L30:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L48
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L31:
       cmp       r12d,r8d
       ja        near ptr M00_L54
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
       jmp       near ptr M00_L08
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFC0353D350]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L33:
       call      qword ptr [7FFC02CCD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L36:
       xor       edx,edx
       jmp       near ptr M00_L16
M00_L37:
       mov       r10d,80
       test      dl,1
       je        short M00_L38
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L38:
       test      dl,2
       je        short M00_L39
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L40:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L16
M00_L41:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC0353CBE8]
       jmp       near ptr M00_L07
M00_L42:
       test      rcx,rcx
       je        short M00_L43
       call      qword ptr [7FFC032F4DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L44
M00_L43:
       call      qword ptr [7FFC02CCD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L44:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L45
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L46
M00_L45:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L46:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0353CC60]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L06
M00_L47:
       test      ecx,ecx
       jne       short M00_L51
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L23
M00_L48:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L31
M00_L49:
       call      qword ptr [7FFC0353CC30]
       int       3
M00_L50:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C04000
       call      qword ptr [7FFC02CCF210]
       mov       rsi,rax
       call      qword ptr [7FFC0353D368]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03276490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       call      qword ptr [7FFC02EFF1B0]
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C04000
       call      qword ptr [7FFC02CCF210]
       mov       rsi,rax
       call      qword ptr [7FFC036253F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03276490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03625410]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFC0317C768]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2014
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,21D67B50008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C04000
       call      qword ptr [7FFC02CCF210]
       mov       rbx,rax
       call      qword ptr [7FFC03624E40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03276490]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,5FD00E97D7CB
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L18
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L17
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L21
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FE79D8]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0344E3B8]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0362E8C8]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0362E670]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L17
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0362EA00]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FE7960]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FE7960]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0362EA00]
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FE7960]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L14
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L14
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       r14d,[rcx+rbx]
       cmp       r14d,[r8+8]
       ja        near ptr M02_L28
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M02_L27
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L26
M02_L13:
       mov       [rsi+18],r14d
M02_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L15
       mov       rcx,1DCD2C00B10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC02FF2F98]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L15:
       mov       r8,5FD00E97D7CB
       cmp       [rbp],r8
       je        short M02_L16
       call      CORINFO_HELP_FAIL_FAST
M02_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       call      qword ptr [7FFC02EFF1B0]
       int       3
M02_L18:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L19
       mov       r11,7FFC02C10F58
       mov       rdx,21D67B631B0
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L20
M02_L19:
       xor       r15d,r15d
M02_L20:
       jmp       near ptr M02_L00
M02_L21:
       test      r9,r9
       je        short M02_L22
       mov       rcx,r9
       call      qword ptr [7FFC032F4DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L23
M02_L22:
       call      qword ptr [7FFC02CCD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L23:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L24
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L25
M02_L24:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L25:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0353CC60]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L26:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L13
M02_L27:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L13
M02_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FE7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M02_L14
; Total bytes of code 866
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M03_L06
       cmp       r8,40
       jbe       short M03_L02
       cmp       r8,800
       ja        near ptr M03_L09
       cmp       r8,100
       jb        short M03_L00
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
M03_L00:
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L03
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L05
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
M03_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L06:
       test      r8b,18
       jne       short M03_L08
       test      r8b,4
       jne       short M03_L07
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L04
M03_L07:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L04
M03_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L04
M03_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CC66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L09
       cmp       [rdx],dl
       jmp       short M03_L04
; Total bytes of code 313
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F27720
       mov       [rbp-68],rax
       lea       rax,[M04_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M04_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M04_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CC6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C10F40
       mov       rdx,21D67B51518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CC6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CCD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,21D67B520A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jg        near ptr M00_L09
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFC03006DF8]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       cmp       edx,4
       jb        near ptr M00_L37
M00_L02:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L14
M00_L03:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,24B74FD20A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L04:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L05:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L06:
       test      r13d,r13d
       je        near ptr M00_L21
       cmp       [rsp+68],r15d
       ja        near ptr M00_L49
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L07:
       mov       r14,[rsp+70]
       mov       r15,24B74FD0E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       cmp       [r8+8],edx
       jb        near ptr M00_L22
       movsxd    rdx,ecx
       mov       word ptr [r8+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
M00_L08:
       inc       ebp
       mov       eax,[rsi+8]
       movsxd    rcx,ebp
       cmp       rax,rcx
       jle       near ptr M00_L00
M00_L09:
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L32
M00_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,20AE0000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,20AE0000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L11:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L35
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L34
       mov       r11,7FFC02C20F68
       mov       rdx,24B74FE31B0
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L12:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L55
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L36
       mov       rcx,20AE0000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CAB92FC0
       mov       r8d,0FC4865F6
       cmp       edx,8
       jb        near ptr M00_L01
       mov       r10d,edx
       shr       r10d,3
M00_L13:
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
       jne       short M00_L13
       test      dl,4
       jne       near ptr M00_L02
M00_L14:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L16:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L41
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L51
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L42
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        short M00_L20
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        short M00_L19
       cmp       r14d,64
       jb        short M00_L18
       mov       rdx,24B74FD20A4
       nop       dword ptr [rax]
M00_L17:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L17
M00_L18:
       cmp       ecx,0A
       jae       near ptr M00_L03
M00_L19:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L04
M00_L20:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L21:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354CC00]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L07
M00_L22:
       mov       r8d,[r14+1C]
       mov       ecx,[r14+18]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L50
       test      r8d,r8d
       jle       near ptr M00_L50
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,[r14+18]
       test      r13d,r13d
       jle       short M00_L24
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       test      r8,r8
       je        near ptr M00_L47
       cmp       [r8+8],ecx
       jb        near ptr M00_L51
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L23:
       cmp       r13d,r8d
       ja        near ptr M00_L54
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L24:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L52
       cmp       edx,r12d
       jl        near ptr M00_L52
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L26
M00_L25:
       cmp       r12d,edx
       jge       short M00_L27
       mov       eax,edx
       jmp       short M00_L28
M00_L26:
       mov       edx,1F40
       jmp       short M00_L25
M00_L27:
       mov       eax,r12d
M00_L28:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L53
       cmp       eax,400
       jl        short M00_L29
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC0330E418]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L30
M00_L29:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L30:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L48
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L31:
       cmp       r12d,r8d
       ja        near ptr M00_L54
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
       jmp       near ptr M00_L08
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFC0354EEC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L33:
       call      qword ptr [7FFC02CDD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L36:
       xor       edx,edx
       jmp       near ptr M00_L16
M00_L37:
       mov       r10d,80
       test      dl,1
       je        short M00_L38
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L38:
       test      dl,2
       je        short M00_L39
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,r10d
       jmp       near ptr M00_L15
M00_L40:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L16
M00_L41:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC0354CC30]
       jmp       near ptr M00_L07
M00_L42:
       test      rcx,rcx
       je        short M00_L43
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L44
M00_L43:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L44:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L45
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L46
M00_L45:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L46:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354CCF0]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L06
M00_L47:
       test      ecx,ecx
       jne       short M00_L51
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L23
M00_L48:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L31
M00_L49:
       call      qword ptr [7FFC0354CC78]
       int       3
M00_L50:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC036353E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC036353F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03635410]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFC0318C768]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2014
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,24B74FD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       call      qword ptr [7FFC03634D98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03286490]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,0ED7EFF507AA6
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L19
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L18
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L22
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FF7A08]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0345E418]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0363E880]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0363E628]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L18
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363EA00]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF79A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF79A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363EA00]
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF79A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L14
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L14
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M02_L17
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M02_L28
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L27
M02_L13:
       add       ebx,r14d
       mov       [rsi+18],ebx
M02_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L15
       mov       rcx,20AE0000398
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC02FC8708]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L15:
       mov       r8,0ED7EFF507AA6
       cmp       [rbp],r8
       je        short M02_L16
       call      CORINFO_HELP_FAIL_FAST
M02_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L14
M02_L18:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M02_L19:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L20
       mov       r11,7FFC02C20F58
       mov       rdx,24B74FE31B0
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L21
M02_L20:
       xor       r15d,r15d
M02_L21:
       jmp       near ptr M02_L00
M02_L22:
       test      r9,r9
       je        short M02_L23
       mov       rcx,r9
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L24
M02_L23:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L24:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L25
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L26
M02_L25:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L26:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354CCF0]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L27:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L13
M02_L28:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L13
; Total bytes of code 866
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L01
       test      r8b,4
       je        short M03_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L02
M03_L00:
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L02
M03_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M03_L02:
       vzeroupper
       ret
M03_L03:
       cmp       r8,40
       jbe       short M03_L06
       cmp       r8,800
       ja        near ptr M03_L08
       cmp       r8,100
       jb        short M03_L04
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
M03_L04:
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L07
M03_L06:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L07
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L07
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L07:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L02
M03_L08:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L08
       cmp       [rdx],dl
       jmp       near ptr M03_L02
; Total bytes of code 315
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F37720
       mov       [rbp-68],rax
       lea       rax,[M04_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M04_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M04_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C20F40
       mov       rdx,24B74FD1518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,24B74FD20A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       jmp       near ptr M00_L07
M00_L00:
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
       jmp       near ptr M00_L06
M00_L01:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,2E6895E20A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L02:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L03:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L04:
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       [rsp+68],r15d
       ja        near ptr M00_L51
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L05:
       mov       r14,[rsp+70]
       mov       r15,2E6895E0E7C
       mov       r8,[r14+8]
       mov       ecx,[r14+18]
       mov       edx,ecx
       lea       eax,[rdx+1]
       cmp       [r8+8],eax
       jb        near ptr M00_L20
       movsxd    rcx,edx
       mov       word ptr [r8+rcx*2+10],2D
       inc       edx
       mov       [r14+18],edx
M00_L06:
       inc       ebp
M00_L07:
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jle       near ptr M00_L31
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L32
M00_L08:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L09
       mov       rcx,2A5F4800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L09
       mov       rcx,2A5F4800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L09:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L35
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L34
       mov       r11,7FFC02C211E0
       mov       rdx,2E6895F31B0
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L10:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L56
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L36
       mov       rcx,2A5F4800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L42
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1172AC64
       mov       r8d,5FBDEAFD
       cmp       edx,8
       jb        near ptr M00_L37
       mov       r10d,edx
       shr       r10d,3
M00_L11:
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
       jne       short M00_L11
       test      dl,4
       jne       near ptr M00_L38
M00_L12:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L13:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L14:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L43
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L53
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L44
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        short M00_L18
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        short M00_L17
       cmp       r14d,64
       jb        short M00_L16
       mov       rdx,2E6895E20A4
M00_L15:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L15
M00_L16:
       cmp       ecx,0A
       jae       near ptr M00_L01
M00_L17:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L02
M00_L18:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L03
M00_L19:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC0354E8C8]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L05
M00_L20:
       mov       r8d,[r14+1C]
       lea       r8d,[r8+rcx+1]
       cmp       r8d,[r14+20]
       jg        near ptr M00_L52
       test      r8d,r8d
       jle       near ptr M00_L52
       mov       r8,[r14+8]
       mov       r13d,[r8+8]
       sub       r13d,ecx
       test      r13d,r13d
       jle       short M00_L22
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L49
       cmp       [r8+8],ecx
       jb        near ptr M00_L53
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L21:
       cmp       r13d,r8d
       ja        near ptr M00_L30
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L22:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L54
       cmp       edx,r12d
       jl        near ptr M00_L54
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L24
M00_L23:
       cmp       r12d,edx
       jge       short M00_L25
       mov       eax,edx
       jmp       short M00_L26
M00_L24:
       mov       edx,1F40
       jmp       short M00_L23
M00_L25:
       mov       eax,r12d
M00_L26:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L55
       cmp       eax,400
       jl        short M00_L27
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC0330E3B8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
       jmp       short M00_L28
M00_L27:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
M00_L28:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L50
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L29:
       cmp       r12d,r8d
       jbe       near ptr M00_L00
M00_L30:
       call      qword ptr [7FFC0318C768]
       int       3
M00_L31:
       mov       rcx,rdi
       call      qword ptr [7FFC03010A18]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFC0354F5D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L08
M00_L33:
       call      qword ptr [7FFC02CDD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L09
M00_L34:
       xor       ecx,ecx
       jmp       near ptr M00_L10
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L10
M00_L36:
       xor       edx,edx
       jmp       near ptr M00_L14
M00_L37:
       cmp       edx,4
       jb        short M00_L39
M00_L38:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L12
M00_L39:
       mov       r10d,80
       test      dl,1
       je        short M00_L40
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L40:
       test      dl,2
       je        short M00_L41
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L13
M00_L41:
       mov       ecx,r10d
       jmp       near ptr M00_L13
M00_L42:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L14
M00_L43:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC0354E8F8]
       jmp       near ptr M00_L05
M00_L44:
       test      rcx,rcx
       je        short M00_L45
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L46
M00_L45:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L46:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L47
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L48
M00_L47:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L48:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354E9B8]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L49:
       test      ecx,ecx
       jne       short M00_L53
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L21
M00_L50:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L29
M00_L51:
       call      qword ptr [7FFC0354E940]
       int       3
M00_L52:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC036353C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L54:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC036353E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC036353F8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1990
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L03
       test      r8b,18
       je        short M01_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       vzeroupper
       ret
M01_L01:
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       jbe       short M01_L08
       cmp       r8,800
       jbe       short M01_L05
M01_L04:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       cmp       r8,100
       jb        short M01_L06
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
M01_L06:
       mov       r9,r8
       shr       r9,6
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L07
       and       r8,3F
       cmp       r8,10
       jbe       short M01_L09
M01_L08:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L10
M01_L09:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M01_L00
M01_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L09
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L09
M01_L11:
       cmp       rcx,rdx
       jne       near ptr M01_L04
       cmp       [rdx],dl
       jmp       near ptr M01_L00
; Total bytes of code 317
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,8713DC4D239D
       mov       [rbp],rax
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14d,r8d
       mov       rdi,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M02_L19
       xor       r15d,r15d
M02_L00:
       mov       [rbp+44],r15b
       mov       r15d,ebx
       cmp       byte ptr [rbp+44],0
       jne       near ptr M02_L07
M02_L01:
       mov       edx,[rbp+40]
       cmp       edx,[rbp+50]
       ja        near ptr M02_L18
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       rbx,[r8+rcx*2]
       mov       r13d,[rbp+50]
       sub       r13d,edx
       test      rdi,rdi
       jne       short M02_L04
       xor       r12d,r12d
       xor       eax,eax
M02_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M02_L05
       test      r15d,r15d
       jl        near ptr M02_L22
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FF7138]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M02_L03:
       test      eax,eax
       je        short M02_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M02_L08
M02_L04:
       lea       r12,[rdi+0C]
       mov       eax,[rdi+8]
       jmp       short M02_L02
M02_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0345E4D8]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC0363F558]
       jmp       near ptr M02_L01
M02_L07:
       lea       rcx,[rbp+30]
       mov       edx,ebx
       mov       r8,rdi
       call      qword ptr [7FFC0363F300]
M02_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M02_L18
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M02_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M02_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M02_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M02_L11
       test      ecx,ecx
       jne       short M02_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363F648]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC0363F648]
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L14
M02_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M02_L14
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M02_L17
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jg        near ptr M02_L28
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       je        near ptr M02_L27
M02_L13:
       add       ebx,r14d
       mov       [rsi+18],ebx
M02_L14:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M02_L15
       mov       rcx,2A5F4800B38
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC03024A50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L15:
       mov       r8,8713DC4D239D
       cmp       [rbp],r8
       je        short M02_L16
       call      CORINFO_HELP_FAIL_FAST
M02_L16:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L14
M02_L18:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M02_L19:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M02_L20
       mov       r11,7FFC02C211D0
       mov       rdx,2E6895F31B0
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M02_L21
M02_L20:
       xor       r15d,r15d
M02_L21:
       jmp       near ptr M02_L00
M02_L22:
       test      r9,r9
       je        short M02_L23
       mov       rcx,r9
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L24
M02_L23:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L24:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M02_L25
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M02_L26
M02_L25:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M02_L26:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],rbx
       mov       [rbp+10],r13d
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC0354E9B8]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M02_L03
M02_L27:
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       near ptr M02_L13
M02_L28:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L13
; Total bytes of code 866
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F37720
       mov       [rbp-68],rax
       lea       rax,[M03_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M03_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M03_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,2E6895E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       call      qword ptr [7FFC03634D80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03286490]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M07_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       mov       rcx,rbx
       mov       r11,7FFC02C211B8
       mov       rdx,2E6895E1518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC02CD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M07_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M08_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M09_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M09_L02
M09_L00:
       test      ecx,ecx
       je        short M09_L03
M09_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M09_L00
M09_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,2E6895E20A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M09_L02
       jmp       short M09_L00
M09_L03:
       test      edx,edx
       jg        short M09_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M09_L05
       cmp       edx,r8d
       jge       short M09_L07
M09_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M09_L04
M09_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M09_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M09_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M09_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M09_L07
       jmp       short M09_L05
M09_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.PerformAction_Record_Comparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
M00_L00:
       mov       ecx,[rsi+8]
       movsxd    rax,ebp
       cmp       rcx,rax
       jle       near ptr M00_L53
       mov       r14,rdi
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L25
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L25
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       mov       rcx,20894C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L02
       mov       rcx,20894C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L26
M00_L02:
       mov       [rsp+70],r14
       mov       [rsp+78],rcx
       test      rcx,rcx
       je        near ptr M00_L28
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        near ptr M00_L27
       mov       r11,7FFC02C21790
       mov       rdx,24929E92DB0
       call      qword ptr [r11]
       test      rax,rax
       setne     cl
       movzx     ecx,cl
M00_L03:
       mov       [rsp+80],cl
       cmp       ebp,[rsi+8]
       jae       near ptr M00_L54
       mov       rcx,[rsi+rbp*8+10]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        near ptr M00_L29
       mov       rcx,20894C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,379B89BD
       mov       r8d,5110EC32
       cmp       edx,8
       jb        near ptr M00_L30
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L31
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       xor       edx,eax
M00_L07:
       mov       r14d,edx
       cmp       byte ptr [rsp+80],0
       jne       near ptr M00_L36
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       rdx,rcx
       mov       eax,[rax+18]
       mov       r8d,eax
       mov       r15d,[rcx+8]
       sub       r15d,eax
       mov       eax,r8d
       mov       ecx,r15d
       add       rax,rcx
       mov       ecx,[rdx+8]
       cmp       rax,rcx
       ja        near ptr M00_L50
       mov       eax,r8d
       lea       r13,[rdx+rax*2+10]
       mov       rcx,[rsp+78]
       test      r14d,r14d
       jl        near ptr M00_L37
       mov       ecx,r14d
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,r14d
       mov       rdx,7FFC61AAC108
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,r15d
       jg        near ptr M00_L42
       mov       [rsp+68],ecx
       mov       [rsp+60],r13
       movsxd    rax,ecx
       lea       rax,[r13+rax*2]
       mov       ecx,r14d
       cmp       ecx,0A
       jb        near ptr M00_L18
       cmp       r14d,64
       jb        short M00_L09
       mov       rdx,24929E820A4
M00_L08:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M00_L08
M00_L09:
       cmp       ecx,0A
       jb        near ptr M00_L18
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,24929E820A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M00_L10:
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r13d,1
M00_L11:
       xor       eax,eax
       mov       [rsp+60],rax
M00_L12:
       test      r13d,r13d
       je        near ptr M00_L43
       cmp       [rsp+68],r15d
       ja        near ptr M00_L48
       mov       rcx,[rsp+70]
       mov       edx,[rsp+68]
       add       [rcx+18],edx
M00_L13:
       mov       r14,[rsp+70]
       mov       r15,24929E80E7C
       mov       r8,[r14+8]
       mov       rax,r8
       mov       ecx,[r14+18]
       mov       r13d,ecx
       mov       edx,[rax+8]
       lea       r10d,[r13+1]
       cmp       edx,r10d
       jae       near ptr M00_L44
       mov       eax,[r14+1C]
       lea       eax,[rax+rcx+1]
       cmp       eax,[r14+20]
       jg        near ptr M00_L49
       test      eax,eax
       jle       near ptr M00_L49
       mov       r13d,[r8+8]
       sub       r13d,ecx
       test      r13d,r13d
       jle       short M00_L15
       test      r8,r8
       je        near ptr M00_L45
       cmp       edx,ecx
       jb        near ptr M00_L50
       mov       eax,ecx
       lea       r8,[r8+rax*2+10]
       sub       edx,ecx
       mov       rcx,r8
M00_L14:
       cmp       r13d,edx
       ja        near ptr M00_L24
       mov       r8d,r13d
       add       r8,r8
       mov       rdx,r15
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [r14+18],ecx
M00_L15:
       mov       r12d,r13d
       neg       r12d
       inc       r12d
       mov       ecx,[r14+1C]
       lea       edx,[r12+rcx]
       mov       eax,[r14+18]
       add       edx,eax
       cmp       edx,[r14+20]
       jg        near ptr M00_L51
       cmp       edx,r12d
       jl        near ptr M00_L51
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L19
M00_L16:
       cmp       r12d,edx
       jge       near ptr M00_L46
M00_L17:
       add       ecx,edx
       cmp       ecx,edx
       jl        near ptr M00_L52
       cmp       edx,400
       jge       short M00_L20
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+28],rax
       jmp       short M00_L21
M00_L18:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M00_L10
M00_L19:
       mov       edx,1F40
       jmp       short M00_L16
M00_L20:
       mov       ecx,edx
       xor       edx,edx
       call      qword ptr [7FFC0330E418]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+28],rax
M00_L21:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       ecx,[r14+18]
       mov       [rax+18],ecx
       mov       ecx,[r14+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r14+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+10]
       mov       rax,[rsp+30]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+20]
       mov       rax,[rsp+30]
       mov       [rax+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r14+18]
       add       [r14+1C],ecx
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L47
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L22:
       cmp       r12d,r8d
       ja        short M00_L24
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r14+18],r12d
M00_L23:
       inc       ebp
       jmp       near ptr M00_L00
M00_L24:
       call      qword ptr [7FFC0318C768]
       int       3
M00_L25:
       mov       ecx,2
       call      qword ptr [7FFC03457768]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L26:
       call      qword ptr [7FFC02CDD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L27:
       xor       ecx,ecx
       jmp       near ptr M00_L03
M00_L28:
       xor       ecx,ecx
       jmp       near ptr M00_L03
M00_L29:
       xor       edx,edx
       jmp       near ptr M00_L07
M00_L30:
       cmp       edx,4
       jb        short M00_L32
M00_L31:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L32:
       mov       r10d,80
       test      dl,1
       je        short M00_L33
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L33:
       test      dl,2
       je        short M00_L34
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L34:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L35:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L07
M00_L36:
       lea       rcx,[rsp+70]
       xor       r8d,r8d
       call      qword ptr [7FFC036ECFA8]
       jmp       near ptr M00_L13
M00_L37:
       test      rcx,rcx
       je        short M00_L38
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L39
M00_L38:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L39:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M00_L40
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M00_L41
M00_L40:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M00_L41:
       mov       [rsp+48],r9
       mov       [rsp+50],ecx
       mov       [rsp+38],r13
       mov       [rsp+40],r15d
       lea       r8,[rsp+68]
       mov       [rsp+20],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       ecx,r14d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03456F10]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       mov       r13d,eax
       jmp       near ptr M00_L12
M00_L42:
       xor       eax,eax
       mov       [rsp+68],eax
       xor       r13d,r13d
       jmp       near ptr M00_L11
M00_L43:
       lea       rcx,[rsp+70]
       mov       edx,r14d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC036ECF78]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       jmp       near ptr M00_L13
M00_L44:
       movsxd    rcx,r13d
       mov       word ptr [rax+rcx*2+10],2D
       inc       r13d
       mov       [r14+18],r13d
       jmp       near ptr M00_L23
M00_L45:
       test      ecx,ecx
       jne       short M00_L50
       xor       ecx,ecx
       xor       edx,edx
       jmp       near ptr M00_L14
M00_L46:
       mov       edx,r12d
       jmp       near ptr M00_L17
M00_L47:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L22
M00_L48:
       call      qword ptr [7FFC036ECFF0]
       int       3
M00_L49:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03457948]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M00_L51:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rsi,rax
       call      qword ptr [7FFC03457960]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC03286490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFC03457978]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,rdi
       call      qword ptr [7FFC03010A18]; System.Text.StringBuilder.ToString()
       mov       [rsp+58],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1989
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L02
       test      r8b,4
       je        short M01_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       vzeroupper
       ret
M01_L01:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L00
M01_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       cmp       r8,100
       jb        short M01_L08
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
M01_L08:
       mov       r9,r8
       shr       r9,6
M01_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L04
       jmp       near ptr M01_L05
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CD66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFC02F37720
       mov       [rbp-68],rax
       lea       rax,[M02_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC628D0510
       call      rax
M02_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC62C1F778],0
       je        short M02_L01
       call      qword ptr [7FFC62C0D608]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC62730D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFC627187D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC6272FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC62730C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFC6272E468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M05_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M05_L00
       add       rsp,20
       pop       rbx
       ret
M05_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L01
       mov       rcx,rbx
       mov       r11,7FFC02C214F0
       mov       rdx,24929E81518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M05_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC6272F9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M06_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M06_L00
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC62718040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC627274D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r8]
       mov       r8d,[r8+8]
       mov       r10d,1
       test      edx,edx
       cmovle    edx,r10d
       mov       r10d,ecx
       neg       r10d
       mov       r11d,r10d
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rbx,7FFC61AAC108
       add       r10,[rbx+r11*8]
       sar       r10,20
       cmp       edx,r10d
       cmovge    r10d,edx
       add       r10d,r8d
       cmp       r10d,[r9+8]
       jg        near ptr M07_L06
       mov       r11,[rsp+60]
       mov       [r11],r10d
       mov       r11,[r9]
       mov       [rsp+28],r11
       movsxd    r10,r10d
       lea       r10,[r11+r10*2]
       neg       ecx
       cmp       ecx,64
       jae       short M07_L02
M07_L00:
       test      ecx,ecx
       je        short M07_L03
M07_L01:
       dec       edx
       mov       r9d,0CCCCCCCD
       mov       r11d,ecx
       imul      r9,r11
       shr       r9,23
       lea       r11d,[r9+r9*4]
       add       r11d,r11d
       mov       ebx,ecx
       sub       ebx,r11d
       mov       ecx,r9d
       add       r10,0FFFFFFFFFFFFFFFE
       add       ebx,30
       mov       [r10],bx
       jmp       short M07_L00
M07_L02:
       add       r10,0FFFFFFFFFFFFFFFC
       add       edx,0FFFFFFFE
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r11d,r9d,64
       sub       ecx,r11d
       mov       r11,24929E820A4
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [r10],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M07_L02
       jmp       short M07_L00
M07_L03:
       test      edx,edx
       jg        short M07_L01
       mov       rcx,r10
       lea       edx,[r8-1]
       test      edx,edx
       jl        short M07_L05
       cmp       edx,r8d
       jge       short M07_L07
M07_L04:
       add       rcx,0FFFFFFFFFFFFFFFE
       mov       r8d,edx
       movzx     r8d,word ptr [rax+r8*2]
       mov       [rcx],r8w
       dec       edx
       jns       short M07_L04
M07_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
       add       rsp,30
       pop       rbx
       ret
M07_L06:
       xor       eax,eax
       mov       r11,[rsp+60]
       mov       [r11],eax
       add       rsp,30
       pop       rbx
       ret
M07_L07:
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       edx,r8d
       jae       short M07_L08
       mov       r10d,edx
       movzx     r10d,word ptr [rax+r10*2]
       mov       [rcx],r10w
       dec       edx
       jns       short M07_L07
       jmp       short M07_L05
M07_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 338
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormattedWithTempSpace[[System.Int32, System.Private.CoreLib]](Int32, Int32, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       mov       [rbp+50],rax
       mov       rax,8B9D2C67DBE3
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r14d,r8d
       mov       rbx,r9
       mov       rcx,[rsi+8]
       test      [rsp],esp
       sub       rsp,200
       lea       r11,[rsp+30]
       mov       [rbp+30],rcx
       mov       [rbp+48],r11
       mov       dword ptr [rbp+50],100
       xor       r11d,r11d
       mov       [rbp+38],r11
       mov       [rbp+40],r11d
       test      rcx,rcx
       jne       near ptr M08_L16
       xor       r15d,r15d
M08_L00:
       mov       [rbp+44],r15b
       mov       r15d,edi
       cmp       byte ptr [rbp+44],0
       jne       near ptr M08_L07
M08_L01:
       mov       edx,[rbp+40]
       mov       edi,[rbp+50]
       cmp       edx,edi
       ja        near ptr M08_L24
       mov       r8,[rbp+48]
       mov       ecx,edx
       lea       r13,[r8+rcx*2]
       sub       edi,edx
       test      rbx,rbx
       jne       short M08_L04
       xor       r12d,r12d
       xor       eax,eax
M08_L02:
       mov       r9,[rbp+30]
       test      eax,eax
       jne       short M08_L05
       test      r15d,r15d
       jl        near ptr M08_L19
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       rdx,[rbp+8]
       lea       r8,[rbp+28]
       mov       ecx,r15d
       call      qword ptr [7FFC02FF7138]; System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M08_L03:
       test      eax,eax
       je        short M08_L06
       mov       ecx,[rbp+40]
       add       ecx,[rbp+28]
       mov       [rbp+40],ecx
       jmp       short M08_L08
M08_L04:
       lea       r12,[rbx+0C]
       mov       eax,[rbx+8]
       jmp       short M08_L02
M08_L05:
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       r8,[rbp+28]
       mov       [rsp+28],r8
       lea       r8,[rbp+18]
       lea       rcx,[rbp+8]
       mov       [rsp+20],rcx
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03456F28]; System.Number.<TryFormatInt32>g__TryFormatInt32Slow|22_0[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       jmp       short M08_L03
M08_L06:
       lea       rcx,[rbp+30]
       call      qword ptr [7FFC03815200]
       jmp       near ptr M08_L01
M08_L07:
       lea       rcx,[rbp+30]
       mov       edx,edi
       mov       r8,rbx
       call      qword ptr [7FFC03814FC0]
M08_L08:
       mov       ebx,[rbp+40]
       cmp       ebx,[rbp+50]
       ja        near ptr M08_L24
       mov       rdi,[rbp+48]
       mov       r15d,r14d
       test      r15d,r15d
       je        near ptr M08_L12
       xor       ecx,ecx
       test      r15d,r15d
       jge       short M08_L09
       mov       ecx,1
       mov       r15d,r14d
       neg       r15d
M08_L09:
       sub       r15d,ebx
       test      r15d,r15d
       jle       short M08_L11
       test      ecx,ecx
       jne       short M08_L10
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC036EEB20]
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M08_L13
M08_L10:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rsi]
       mov       r8d,r15d
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC036EEB20]
       jmp       short M08_L13
M08_L11:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M08_L13
M08_L12:
       mov       rsi,[rsi]
       cmp       [rsi],sil
       test      ebx,ebx
       je        short M08_L13
       mov       r14,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+rbx]
       cmp       ecx,[r14+8]
       jbe       near ptr M08_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC02FF7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M08_L13:
       mov       rdx,[rbp+38]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+48],xmm0
       mov       [rbp+40],ecx
       test      rdx,rdx
       je        short M08_L14
       mov       rcx,20894C00B20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC030171C8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M08_L14:
       mov       r8,8B9D2C67DBE3
       cmp       [rbp],r8
       je        short M08_L15
       call      CORINFO_HELP_FAIL_FAST
M08_L15:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L16:
       mov       r11,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],r11
       je        short M08_L17
       mov       r11,7FFC02C21780
       mov       rdx,24929E92DB0
       call      qword ptr [r11]
       test      rax,rax
       setne     r15b
       movzx     r15d,r15b
       jmp       short M08_L18
M08_L17:
       xor       r15d,r15d
M08_L18:
       jmp       near ptr M08_L00
M08_L19:
       test      r9,r9
       je        short M08_L20
       mov       rcx,r9
       call      qword ptr [7FFC03304DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M08_L21
M08_L20:
       call      qword ptr [7FFC02CDD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M08_L21:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M08_L22
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M08_L23
M08_L22:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M08_L23:
       mov       [rbp+18],r9
       mov       [rbp+20],ecx
       mov       [rbp+8],r13
       mov       [rbp+10],edi
       lea       r8,[rbp+28]
       mov       [rsp+20],r8
       lea       r8,[rbp+18]
       lea       r9,[rbp+8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03456F10]; System.Number.TryNegativeInt32ToDecStr[[System.Char, System.Private.CoreLib]](Int32, Int32, System.ReadOnlySpan`1<Char>, System.Span`1<Char>, Int32 ByRef)
       jmp       near ptr M08_L03
M08_L24:
       call      qword ptr [7FFC02F0F1B0]
       int       3
M08_L25:
       movsxd    r8,r15d
       lea       rcx,[r14+r8*2+10]
       cmp       ebx,2
       jg        short M08_L26
       movzx     r8d,word ptr [rdi]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M08_L27
       movzx     r8d,word ptr [rdi+2]
       mov       [rcx+2],r8w
       jmp       short M08_L27
M08_L26:
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L27:
       add       ebx,r15d
       mov       [rsi+18],ebx
       jmp       near ptr M08_L13
; Total bytes of code 844
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M09_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC62908D20
       mov       rsi,rax
M09_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M09_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M09_L03
       cmp       [rdx+8],r8d
       jb        short M09_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC02CD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M09_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rax,24929E80008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC02C14000
       call      qword ptr [7FFC02CDF210]
       mov       rbx,rax
       call      qword ptr [7FFC03457240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03286490]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.UpsertRecord_Record()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L17
       test      rdi,rdi
       je        near ptr M00_L18
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M00_L23
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L22
       cmp       r14d,[rsi+8]
       ja        near ptr M00_L22
       cmp       r14d,[rbp+8]
       ja        near ptr M00_L22
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L21
       cmp       r8,4000
       ja        near ptr M00_L20
       mov       rcx,rax
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L19
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L24
       lea       r14,[rbp+10]
       mov       ebp,[rbp+8]
M00_L01:
       mov       rcx,23FAA800AC8
       mov       r15,[rcx]
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L12
M00_L02:
       cmp       r13d,ebp
       jge       near ptr M00_L13
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       test      r12,r12
       je        short M00_L06
       cmp       r12,rdi
       je        near ptr M00_L30
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L26
       test      rdx,rdx
       je        short M00_L04
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L25
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       xor       eax,eax
M00_L05:
       test      eax,eax
       jne       near ptr M00_L40
M00_L06:
       inc       r13d
       jmp       short M00_L02
M00_L07:
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L31
       test      r12,r12
       je        short M00_L11
       cmp       r12,rdi
       je        near ptr M00_L32
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L33
       test      rdx,rdx
       je        short M00_L09
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L35
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L08:
       test      eax,eax
       jne       near ptr M00_L34
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L40
M00_L11:
       inc       r13d
M00_L12:
       cmp       r13d,ebp
       jl        short M00_L07
M00_L13:
       mov       ebp,0FFFFFFFF
M00_L14:
       test      ebp,ebp
       jge       near ptr M00_L41
       mov       ebp,[rsi+8]
       inc       ebp
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdx,[rsi+10]
       mov       esi,[rsi+8]
       lea       rcx,[r14+10]
       mov       r8d,ebp
       cmp       esi,r8d
       jg        near ptr M00_L42
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L44
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L43
M00_L15:
       cmp       esi,ebp
       jae       near ptr M00_L45
       mov       ecx,esi
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       [rsp+30],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L17:
       call      qword ptr [7FFC032FE730]
       mov       ecx,3
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03025B10
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC035544B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC035544C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       r14,rsi
       jmp       near ptr M00_L16
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFC032FE0B8]
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC036143F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23FAA800C30
       mov       rbp,[rcx]
       jmp       near ptr M00_L00
M00_L24:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L01
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L26:
       test      rdx,rdx
       jne       near ptr M00_L04
M00_L27:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L28
       test      ecx,ecx
       je        near ptr M00_L04
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L04
       jmp       short M00_L29
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L04
M00_L29:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L05
M00_L30:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,r15
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFC02C110B0
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L33:
       test      rdx,rdx
       jne       near ptr M00_L09
M00_L34:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L36
       jmp       short M00_L38
M00_L35:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L08
M00_L36:
       test      ecx,ecx
       jne       near ptr M00_L09
M00_L37:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L39
M00_L38:
       test      ecx,ecx
       je        near ptr M00_L09
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L37
M00_L39:
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L10
M00_L40:
       mov       ebp,r13d
       jmp       near ptr M00_L14
M00_L41:
       mov       edx,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC02CD1AB8]
       cmp       ebp,[r14+8]
       jae       short M00_L45
       mov       ecx,ebp
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L42:
       call      qword ptr [7FFC02EFFA98]
       int       3
M00_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L15
M00_L44:
       call      qword ptr [7FFC032FE0B8]
       jmp       near ptr M00_L15
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1501
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28029900008
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
       call      qword ptr [7FFC036174F8]
       int       3
; Total bytes of code 244
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L00:
       test      r8b,4
       je        short M02_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L01:
       test      r8,r8
       je        short M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L02:
       cmp       r8,40
       ja        short M02_L06
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L09
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       vzeroupper
       ret
M02_L06:
       cmp       r8,800
       ja        near ptr M02_L12
       cmp       r8,100
       jae       short M02_L10
M02_L07:
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L10:
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
       jmp       short M02_L07
M02_L11:
       cmp       rcx,rdx
       jne       short M02_L12
       cmp       [rdx],dl
       jmp       near ptr M02_L05
M02_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CC66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       je        near ptr M03_L07
       test      rsi,rsi
       je        near ptr M03_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M03_L00
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
       jne       near ptr M03_L08
M03_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M03_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M03_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M03_L01:
       sub       edi,eax
       js        near ptr M03_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M03_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M03_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M03_L02:
       sub       ebp,eax
       js        near ptr M03_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M03_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M03_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62729320]
       test      eax,eax
       je        short M03_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M03_L16
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
M03_L03:
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
       jne       short M03_L04
       cmp       r8,14
       jne       near ptr M03_L15
       jmp       near ptr M03_L14
M03_L04:
       cmp       r8,4000
       ja        near ptr M03_L13
       jmp       near ptr M03_L12
M03_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M03_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M03_L08:
       call      qword ptr [7FFC62722830]
       mov       rbx,rax
       call      qword ptr [7FFC6272DDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272C810]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC627409B0]
       int       3
M03_L10:
       call      qword ptr [7FFC627225F8]
       mov       rbx,rax
       call      qword ptr [7FFC6272CC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC6272B218]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FFC627225F8]
       mov       r14,rax
       call      qword ptr [7FFC6272CC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC6272B218]
       mov       rcx,r14
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M03_L05
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L05
M03_L13:
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
M03_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M03_L05
M03_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC6272C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L05
M03_L16:
       call      qword ptr [7FFC62722620]
       mov       rbx,rax
       call      qword ptr [7FFC6272D730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272B298]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFC02CC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        near ptr M05_L04
       test      rbx,rbx
       je        short M05_L00
       test      rsi,rsi
       je        near ptr M05_L05
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M05_L01
       mov       rcx,7FFC03605F44
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,7FFC03605F48
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FFC03605F50
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M05_L02
       call      qword ptr [7FFC02CCC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L03
M05_L02:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       mov       rcx,7FFC03605F40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L05:
       mov       rcx,7FFC03605F4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L00
; Total bytes of code 206
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.UpsertRecord_Record()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L19
       test      rdi,rdi
       je        near ptr M00_L20
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M00_L24
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L23
       cmp       r14d,[rsi+8]
       ja        near ptr M00_L23
       cmp       r14d,[rbp+8]
       ja        near ptr M00_L23
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L22
       cmp       r8,4000
       jbe       short M00_L00
       mov       rcx,rax
       call      qword ptr [7FFC0355F9C0]
       jmp       short M00_L01
M00_L00:
       mov       rcx,rax
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L21
M00_L01:
       test      rbp,rbp
       je        near ptr M00_L25
       lea       r14,[rbp+10]
       mov       ebp,[rbp+8]
M00_L02:
       mov       rcx,2A0CE800AC8
       mov       r15,[rcx]
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L13
M00_L03:
       cmp       r13d,ebp
       jge       near ptr M00_L14
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       test      r12,r12
       je        short M00_L07
       cmp       r12,rdi
       je        near ptr M00_L31
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L27
       test      rdx,rdx
       je        short M00_L05
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L26
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L04:
       test      eax,eax
       jne       near ptr M00_L28
M00_L05:
       xor       eax,eax
M00_L06:
       test      eax,eax
       jne       near ptr M00_L41
M00_L07:
       inc       r13d
       jmp       short M00_L03
M00_L08:
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L32
       test      r12,r12
       je        short M00_L12
       cmp       r12,rdi
       je        near ptr M00_L33
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L34
       test      rdx,rdx
       je        short M00_L10
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L36
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       jne       near ptr M00_L35
M00_L10:
       xor       eax,eax
M00_L11:
       test      eax,eax
       jne       near ptr M00_L41
M00_L12:
       inc       r13d
M00_L13:
       cmp       r13d,ebp
       jl        short M00_L08
M00_L14:
       mov       ebp,0FFFFFFFF
M00_L15:
       test      ebp,ebp
       jge       near ptr M00_L42
       mov       ebp,[rsi+8]
       inc       ebp
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdx,[rsi+10]
       mov       esi,[rsi+8]
       lea       rcx,[r14+10]
       mov       r8d,ebp
       cmp       esi,r8d
       jg        near ptr M00_L43
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L16
       call      qword ptr [7FFC0355F9C0]
       jmp       short M00_L17
M00_L16:
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L44
M00_L17:
       cmp       esi,ebp
       jae       near ptr M00_L45
       mov       ecx,esi
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L18:
       mov       [rsp+30],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L19:
       call      qword ptr [7FFC0331E250]
       mov       ecx,3
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03045770
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC03554000]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03554018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       mov       r14,rsi
       jmp       near ptr M00_L18
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,rax
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L23:
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC03624318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A0CE800C30
       mov       rbp,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L02
M00_L26:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L04
M00_L27:
       test      rdx,rdx
       jne       near ptr M00_L05
M00_L28:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L29
       test      ecx,ecx
       je        near ptr M00_L05
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L05
       jmp       short M00_L30
M00_L29:
       test      ecx,ecx
       jne       near ptr M00_L05
M00_L30:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L05
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L05
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L05
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L05
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L05
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L06
M00_L31:
       mov       eax,1
       jmp       near ptr M00_L06
M00_L32:
       mov       rcx,r15
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFC02C310B8
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L33:
       mov       eax,1
       jmp       near ptr M00_L11
M00_L34:
       test      rdx,rdx
       jne       near ptr M00_L10
M00_L35:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L37
       jmp       short M00_L39
M00_L36:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L09
M00_L37:
       test      ecx,ecx
       jne       near ptr M00_L10
M00_L38:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       jmp       short M00_L40
M00_L39:
       test      ecx,ecx
       je        near ptr M00_L10
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L10
       jmp       short M00_L38
M00_L40:
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L11
M00_L41:
       mov       ebp,r13d
       jmp       near ptr M00_L15
M00_L42:
       mov       edx,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC02CF1AB8]
       cmp       ebp,[r14+8]
       jae       short M00_L45
       mov       ecx,ebp
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L18
M00_L43:
       call      qword ptr [7FFC02F1F1B0]
       int       3
M00_L44:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L17
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1487
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E14DA80008
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
       call      qword ptr [7FFC03627510]
       int       3
; Total bytes of code 244
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L05
M02_L00:
       test      r8b,4
       je        short M02_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L05
M02_L01:
       test      r8,r8
       je        short M02_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L05
M02_L02:
       cmp       r8,40
       ja        short M02_L06
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L09
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L05:
       vzeroupper
       ret
M02_L06:
       cmp       r8,800
       ja        near ptr M02_L12
       cmp       r8,100
       jae       short M02_L10
M02_L07:
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L10:
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
       jmp       short M02_L07
M02_L11:
       cmp       rcx,rdx
       jne       short M02_L12
       cmp       [rdx],dl
       jmp       near ptr M02_L05
M02_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       je        near ptr M03_L07
       test      rsi,rsi
       je        near ptr M03_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M03_L00
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
       jne       near ptr M03_L08
M03_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M03_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M03_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M03_L01:
       sub       edi,eax
       js        near ptr M03_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M03_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M03_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M03_L02:
       sub       ebp,eax
       js        near ptr M03_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M03_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M03_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62729320]
       test      eax,eax
       je        short M03_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M03_L16
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
M03_L03:
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
       jne       short M03_L04
       cmp       r8,14
       jne       near ptr M03_L15
       jmp       near ptr M03_L14
M03_L04:
       cmp       r8,4000
       ja        near ptr M03_L13
       jmp       near ptr M03_L12
M03_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M03_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M03_L08:
       call      qword ptr [7FFC62722830]
       mov       rbx,rax
       call      qword ptr [7FFC6272DDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272C810]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC627409B0]
       int       3
M03_L10:
       call      qword ptr [7FFC627225F8]
       mov       rbx,rax
       call      qword ptr [7FFC6272CC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC6272B218]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FFC627225F8]
       mov       r14,rax
       call      qword ptr [7FFC6272CC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC6272B218]
       mov       rcx,r14
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M03_L05
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L05
M03_L13:
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
M03_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M03_L05
M03_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC6272C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L05
M03_L16:
       call      qword ptr [7FFC62722620]
       mov       rbx,rax
       call      qword ptr [7FFC6272D730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272B298]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFC02CE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        near ptr M05_L04
       test      rbx,rbx
       je        short M05_L00
       test      rsi,rsi
       je        near ptr M05_L05
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M05_L01
       mov       rcx,7FFC0363484C
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,7FFC03634850
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FFC03634858
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M05_L02
       call      qword ptr [7FFC02CEC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L03
M05_L02:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       mov       rcx,7FFC03634848
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L05:
       mov       rcx,7FFC03634854
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L00
; Total bytes of code 206
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.UpsertRecord_Record()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L17
       test      rdi,rdi
       je        near ptr M00_L18
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M00_L23
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L22
       cmp       r14d,[rsi+8]
       ja        near ptr M00_L22
       cmp       r14d,[rbp+8]
       ja        near ptr M00_L22
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L21
       cmp       r8,4000
       ja        near ptr M00_L20
       mov       rcx,rax
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L19
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L24
       lea       r14,[rbp+10]
       mov       ebp,[rbp+8]
M00_L01:
       mov       rcx,13A1E000AC8
       mov       r15,[rcx]
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L12
M00_L02:
       cmp       r13d,ebp
       jge       near ptr M00_L13
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       test      r12,r12
       je        short M00_L06
       cmp       r12,rdi
       je        near ptr M00_L30
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L26
       test      rdx,rdx
       je        short M00_L04
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L25
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       xor       eax,eax
M00_L05:
       test      eax,eax
       jne       near ptr M00_L40
M00_L06:
       inc       r13d
       jmp       short M00_L02
M00_L07:
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L31
       test      r12,r12
       je        short M00_L11
       cmp       r12,rdi
       je        near ptr M00_L32
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L33
       test      rdx,rdx
       je        short M00_L09
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L35
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L08:
       test      eax,eax
       jne       near ptr M00_L34
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L40
M00_L11:
       inc       r13d
M00_L12:
       cmp       r13d,ebp
       jl        short M00_L07
M00_L13:
       mov       ebp,0FFFFFFFF
M00_L14:
       test      ebp,ebp
       jge       near ptr M00_L41
       mov       ebp,[rsi+8]
       inc       ebp
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdx,[rsi+10]
       mov       esi,[rsi+8]
       lea       rcx,[r14+10]
       mov       r8d,ebp
       cmp       esi,r8d
       jg        near ptr M00_L42
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L44
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L43
M00_L15:
       cmp       esi,ebp
       jae       near ptr M00_L45
       mov       ecx,esi
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       [rsp+30],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L17:
       call      qword ptr [7FFC032FE730]
       mov       ecx,3
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03025B10
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03154600
       call      qword ptr [7FFC02CCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC035544B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC035544C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       r14,rsi
       jmp       near ptr M00_L16
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFC032FE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC036143A8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13A1E000C30
       mov       rbp,[rcx]
       jmp       near ptr M00_L00
M00_L24:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L01
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L26:
       test      rdx,rdx
       jne       near ptr M00_L04
M00_L27:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L28
       test      ecx,ecx
       je        near ptr M00_L04
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L04
       jmp       short M00_L29
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L04
M00_L29:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L05
M00_L30:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,r15
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFC02C110B0
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L33:
       test      rdx,rdx
       jne       near ptr M00_L09
M00_L34:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L36
       jmp       short M00_L38
M00_L35:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L08
M00_L36:
       test      ecx,ecx
       jne       near ptr M00_L09
M00_L37:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L39
M00_L38:
       test      ecx,ecx
       je        near ptr M00_L09
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L37
M00_L39:
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CC6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L10
M00_L40:
       mov       ebp,r13d
       jmp       near ptr M00_L14
M00_L41:
       mov       edx,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC02CD1AB8]
       cmp       ebp,[r14+8]
       jae       short M00_L45
       mov       ecx,ebp
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L42:
       call      qword ptr [7FFC02EFFA98]
       int       3
M00_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L15
M00_L44:
       call      qword ptr [7FFC032FE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1501
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17A9CF30008
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
       call      qword ptr [7FFC03617528]
       int       3
; Total bytes of code 244
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M02_L07
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       je        short M03_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L05
M03_L00:
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L05
M03_L01:
       test      r8,r8
       je        short M03_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L05
M03_L02:
       cmp       r8,40
       ja        short M03_L06
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M03_L10
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L05:
       vzeroupper
       ret
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L09
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L03
       jmp       short M03_L04
M03_L09:
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
       jmp       short M03_L07
M03_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L04
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L05
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CC66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
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
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62729320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L08:
       call      qword ptr [7FFC62722830]
       mov       rbx,rax
       call      qword ptr [7FFC6272DDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272C810]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC627409B0]
       int       3
M04_L10:
       call      qword ptr [7FFC627225F8]
       mov       rbx,rax
       call      qword ptr [7FFC6272CC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC6272B218]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFC627225F8]
       mov       r14,rax
       call      qword ptr [7FFC6272CC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC6272B218]
       mov       rcx,r14
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC6272C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFC62722620]
       mov       rbx,rax
       call      qword ptr [7FFC6272D730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272B298]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       jmp       qword ptr [7FFC02CC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        near ptr M06_L04
       test      rbx,rbx
       je        short M06_L00
       test      rsi,rsi
       je        near ptr M06_L05
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M06_L01
       mov       rcx,7FFC036058E4
       call      CORINFO_HELP_COUNTPROFILE32
M06_L00:
       mov       rcx,7FFC036058E8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,7FFC036058F0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M06_L02
       call      qword ptr [7FFC02CCC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L03
M06_L02:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M06_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,7FFC036058E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       rcx,7FFC036058EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L00
; Total bytes of code 206
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.UpsertRecord_Record()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L17
       test      rdi,rdi
       je        near ptr M00_L18
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M00_L23
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L22
       cmp       r14d,[rsi+8]
       ja        near ptr M00_L22
       cmp       r14d,[rbp+8]
       ja        near ptr M00_L22
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L21
       cmp       r8,4000
       ja        near ptr M00_L20
       mov       rcx,rax
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L19
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L24
       lea       r14,[rbp+10]
       mov       ebp,[rbp+8]
M00_L01:
       mov       rcx,1DC23400AC8
       mov       r15,[rcx]
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L12
M00_L02:
       cmp       r13d,ebp
       jge       near ptr M00_L13
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       test      r12,r12
       je        short M00_L06
       cmp       r12,rdi
       je        near ptr M00_L30
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L26
       test      rdx,rdx
       je        short M00_L04
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L25
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       xor       eax,eax
M00_L05:
       test      eax,eax
       jne       near ptr M00_L40
M00_L06:
       inc       r13d
       jmp       short M00_L02
M00_L07:
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L31
       test      r12,r12
       je        short M00_L11
       cmp       r12,rdi
       je        near ptr M00_L32
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L33
       test      rdx,rdx
       je        short M00_L09
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L35
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L08:
       test      eax,eax
       jne       near ptr M00_L34
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L40
M00_L11:
       inc       r13d
M00_L12:
       cmp       r13d,ebp
       jl        short M00_L07
M00_L13:
       mov       ebp,0FFFFFFFF
M00_L14:
       test      ebp,ebp
       jge       near ptr M00_L41
       mov       ebp,[rsi+8]
       inc       ebp
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdx,[rsi+10]
       mov       esi,[rsi+8]
       lea       rcx,[r14+10]
       mov       r8d,ebp
       cmp       esi,r8d
       jg        near ptr M00_L42
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L44
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L43
M00_L15:
       cmp       esi,ebp
       jae       near ptr M00_L45
       mov       ecx,esi
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       [rsp+30],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L17:
       call      qword ptr [7FFC0331E730]
       mov       ecx,3
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03045B10
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC03574480]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03574498]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       r14,rsi
       jmp       near ptr M00_L16
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFC0331E0B8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC036341E0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DC23400C30
       mov       rbp,[rcx]
       jmp       near ptr M00_L00
M00_L24:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L01
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L26:
       test      rdx,rdx
       jne       near ptr M00_L04
M00_L27:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L28
       test      ecx,ecx
       je        near ptr M00_L04
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L04
       jmp       short M00_L29
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L04
M00_L29:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L05
M00_L30:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,r15
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFC02C30F28
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L33:
       test      rdx,rdx
       jne       near ptr M00_L09
M00_L34:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L36
       jmp       short M00_L38
M00_L35:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L08
M00_L36:
       test      ecx,ecx
       jne       near ptr M00_L09
M00_L37:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L39
M00_L38:
       test      ecx,ecx
       je        near ptr M00_L09
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L37
M00_L39:
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L09
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L10
M00_L40:
       mov       ebp,r13d
       jmp       near ptr M00_L14
M00_L41:
       mov       edx,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC02CF1AB8]
       cmp       ebp,[r14+8]
       jae       short M00_L45
       mov       ecx,ebp
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L42:
       call      qword ptr [7FFC02F1FA98]
       int       3
M00_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L15
M00_L44:
       call      qword ptr [7FFC0331E0B8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1501
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21CA23D0008
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
       call      qword ptr [7FFC036374C8]
       int       3
; Total bytes of code 244
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M02_L07
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       je        short M03_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L05
M03_L00:
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L05
M03_L01:
       test      r8,r8
       je        short M03_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L05
M03_L02:
       cmp       r8,40
       ja        short M03_L06
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M03_L10
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L05:
       vzeroupper
       ret
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L09
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L03
       jmp       short M03_L04
M03_L09:
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
       jmp       short M03_L07
M03_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L04
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L05
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
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
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62729320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L08:
       call      qword ptr [7FFC62722830]
       mov       rbx,rax
       call      qword ptr [7FFC6272DDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272C810]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC627409B0]
       int       3
M04_L10:
       call      qword ptr [7FFC627225F8]
       mov       rbx,rax
       call      qword ptr [7FFC6272CC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC6272B218]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFC627225F8]
       mov       r14,rax
       call      qword ptr [7FFC6272CC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC6272B218]
       mov       rcx,r14
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC6272C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFC62722620]
       mov       rbx,rax
       call      qword ptr [7FFC6272D730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272B298]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       jmp       qword ptr [7FFC02CE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        near ptr M06_L04
       test      rbx,rbx
       je        short M06_L00
       test      rsi,rsi
       je        near ptr M06_L05
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M06_L01
       mov       rcx,7FFC03625E6C
       call      CORINFO_HELP_COUNTPROFILE32
M06_L00:
       mov       rcx,7FFC03625E70
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,7FFC03625E78
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M06_L02
       call      qword ptr [7FFC02CEC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L03
M06_L02:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M06_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,7FFC03625E68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       rcx,7FFC03625E74
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L00
; Total bytes of code 206
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.UpsertRecord_Record()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L17
       test      rdi,rdi
       je        near ptr M00_L18
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M00_L23
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L22
       cmp       r14d,[rsi+8]
       ja        near ptr M00_L22
       cmp       r14d,[rbp+8]
       ja        near ptr M00_L22
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L21
       cmp       r8,4000
       ja        near ptr M00_L20
       mov       rcx,rax
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L19
M00_L00:
       test      rbp,rbp
       je        near ptr M00_L24
       lea       r14,[rbp+10]
       mov       ebp,[rbp+8]
M00_L01:
       mov       rcx,214AA800AC8
       mov       r15,[rcx]
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       short M00_L08
M00_L02:
       cmp       r13d,ebp
       jge       near ptr M00_L13
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       test      r12,r12
       je        short M00_L06
       cmp       r12,rdi
       je        near ptr M00_L30
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L26
       test      rdx,rdx
       je        short M00_L04
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L25
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       xor       eax,eax
M00_L05:
       test      eax,eax
       jne       short M00_L12
M00_L06:
       inc       r13d
       jmp       short M00_L02
M00_L07:
       inc       r13d
M00_L08:
       cmp       r13d,ebp
       jge       short M00_L13
       mov       ecx,r13d
       mov       r12,[r14+rcx*8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L31
       test      r12,r12
       je        short M00_L07
       cmp       r12,rdi
       je        near ptr M00_L32
       mov       rcx,[r12+8]
       mov       rdx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L33
       test      rdx,rdx
       je        short M00_L10
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L35
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       jne       near ptr M00_L34
M00_L10:
       xor       eax,eax
M00_L11:
       test      eax,eax
       je        short M00_L07
M00_L12:
       mov       ebp,r13d
       jmp       short M00_L14
M00_L13:
       mov       ebp,0FFFFFFFF
M00_L14:
       test      ebp,ebp
       jge       near ptr M00_L40
       mov       ebp,[rsi+8]
       inc       ebp
       movsxd    rdx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdx,[rsi+10]
       mov       esi,[rsi+8]
       lea       rcx,[r14+10]
       mov       r8d,ebp
       cmp       esi,r8d
       jg        near ptr M00_L41
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L43
       call      00007FFC628B5D60
       cmp       dword ptr [7FFC62C1F778],0
       jne       near ptr M00_L42
M00_L15:
       cmp       esi,ebp
       jae       near ptr M00_L44
       mov       ecx,esi
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       [rsp+30],r14
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L17:
       call      qword ptr [7FFC0331E238]
       mov       ecx,3
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFC03045770
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC03174600
       call      qword ptr [7FFC02CEF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC02CED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC03554000]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC03554018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       mov       r14,rsi
       jmp       near ptr M00_L16
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFC0346C7B0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC03624318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,214AA800C30
       mov       rbp,[rcx]
       jmp       near ptr M00_L00
M00_L24:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M00_L01
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L26:
       test      rdx,rdx
       jne       near ptr M00_L04
M00_L27:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L28
       test      ecx,ecx
       je        near ptr M00_L04
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L04
       jmp       short M00_L29
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L04
M00_L29:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L05
M00_L30:
       mov       eax,1
       jmp       near ptr M00_L05
M00_L31:
       mov       rcx,r15
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFC02C30F30
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L11
M00_L33:
       test      rdx,rdx
       jne       near ptr M00_L10
M00_L34:
       lea       r8,[r12+40]
       movzx     r10d,byte ptr [r8]
       mov       r9,[r8+10]
       lea       r11,[rdi+40]
       movzx     ecx,byte ptr [r11]
       mov       rax,[r11+10]
       test      r10d,r10d
       je        short M00_L36
       jmp       short M00_L38
M00_L35:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L09
M00_L36:
       test      ecx,ecx
       jne       near ptr M00_L10
M00_L37:
       mov       rcx,[r12+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       jmp       short M00_L39
M00_L38:
       test      ecx,ecx
       je        near ptr M00_L10
       cmp       r9,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L10
       jmp       short M00_L37
M00_L39:
       mov       rcx,[r12+18]
       mov       rdx,[rdi+18]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+20]
       mov       rdx,[rdi+20]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+28]
       mov       rdx,[rdi+28]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+30]
       mov       rdx,[rdi+30]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L10
       mov       rcx,[r12+38]
       mov       rdx,[rdi+38]
       call      qword ptr [7FFC02CE6E20]; System.String.Equals(System.String, System.String)
       jmp       near ptr M00_L11
M00_L40:
       mov       edx,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFC02CF1AB8]
       cmp       ebp,[r14+8]
       jae       short M00_L44
       mov       ecx,ebp
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L41:
       call      qword ptr [7FFC02F1F1B0]
       int       3
M00_L42:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L15
M00_L43:
       call      qword ptr [7FFC0346C7B0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L15
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1486
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
       call      00007FFC62908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC02CE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25529690008
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
       call      qword ptr [7FFC036275A0]
       int       3
; Total bytes of code 244
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M02_L07
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       je        short M03_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L05
M03_L00:
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L05
M03_L01:
       test      r8,r8
       je        short M03_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L05
M03_L02:
       cmp       r8,40
       ja        short M03_L06
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M03_L10
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L05:
       vzeroupper
       ret
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L09
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L03
       jmp       short M03_L04
M03_L09:
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
       jmp       short M03_L07
M03_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L04
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L05
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC02CE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
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
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62729400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC627409C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62729320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC6272B268]
       int       3
M04_L08:
       call      qword ptr [7FFC62722830]
       mov       rbx,rax
       call      qword ptr [7FFC6272DDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272C810]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC627409B0]
       int       3
M04_L10:
       call      qword ptr [7FFC627225F8]
       mov       rbx,rax
       call      qword ptr [7FFC6272CC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC6272B218]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFC627225F8]
       mov       r14,rax
       call      qword ptr [7FFC6272CC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC6272B218]
       mov       rcx,r14
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC627296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFC62718028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC6272C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFC62722620]
       mov       rbx,rax
       call      qword ptr [7FFC6272D730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6272B298]
       mov       rcx,rbx
       call      qword ptr [7FFC62717FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       jmp       qword ptr [7FFC02CE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        near ptr M06_L04
       test      rbx,rbx
       je        short M06_L00
       test      rsi,rsi
       je        near ptr M06_L05
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M06_L01
       mov       rcx,7FFC036341C4
       call      CORINFO_HELP_COUNTPROFILE32
M06_L00:
       mov       rcx,7FFC036341C8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,7FFC036341D0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M06_L02
       call      qword ptr [7FFC02CEC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L03
M06_L02:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M06_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,7FFC036341C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       rcx,7FFC036341CC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L00
; Total bytes of code 206
```

