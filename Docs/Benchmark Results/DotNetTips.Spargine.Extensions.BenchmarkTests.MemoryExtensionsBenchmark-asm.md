## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MemoryExtensionsBenchmark.IsEqualTo()
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
       mov       rcx,[rbx+1A8]
       mov       esi,[rbx+1B0]
       mov       edx,[rbx+1B4]
       mov       rdi,[rbx+1B8]
       mov       ebp,[rbx+1C0]
       mov       r14d,[rbx+1C4]
       cmp       edx,r14d
       jne       near ptr M00_L08
       xor       r15d,r15d
       xor       r13d,r13d
       test      rcx,rcx
       je        short M00_L01
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L09
       lea       r15,[rcx+10]
       mov       r13d,[rcx+8]
M00_L00:
       and       esi,7FFFFFFF
       mov       edx,esi
       mov       ecx,r14d
       add       rcx,rdx
       mov       eax,r13d
       cmp       rcx,rax
       ja        near ptr M00_L11
       add       r15,rdx
       mov       r13d,r14d
M00_L01:
       xor       esi,esi
       xor       r12d,r12d
       test      rdi,rdi
       je        short M00_L03
       mov       rdx,[rdi]
       test      dword ptr [rdx],80000000
       je        near ptr M00_L10
       lea       rsi,[rdi+10]
       mov       r12d,[rdi+8]
M00_L02:
       and       ebp,7FFFFFFF
       mov       eax,ebp
       mov       ecx,r14d
       add       rcx,rax
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M00_L11
       add       rsi,rax
       mov       r12d,r14d
M00_L03:
       cmp       r13d,r12d
       jne       near ptr M00_L12
       mov       rax,r15
       mov       rcx,rsi
       mov       edx,r12d
       cmp       rdx,8
       jb        near ptr M00_L13
       cmp       rax,rcx
       jne       short M00_L06
M00_L04:
       mov       eax,1
M00_L05:
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vzeroupper
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
M00_L06:
       cmp       rdx,20
       jae       near ptr M00_L17
       cmp       rdx,10
       jae       near ptr M00_L20
       add       rdx,0FFFFFFFFFFFFFFF8
       mov       rax,[r15]
       sub       rax,[rsi]
       mov       rcx,[r15+rdx]
       sub       rcx,[rsi+rdx]
       or        rax,rcx
       sete      al
       movzx     eax,al
M00_L07:
       jmp       short M00_L05
M00_L08:
       xor       eax,eax
       jmp       short M00_L05
M00_L09:
       lea       rdx,[rsp+38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r15,[rsp+38]
       mov       r13d,[rsp+40]
       jmp       near ptr M00_L00
M00_L10:
       lea       rdx,[rsp+28]
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rsp+28]
       mov       r12d,[rsp+30]
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FFC03797198]
       int       3
M00_L12:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L13:
       cmp       rdx,4
       jae       short M00_L16
       xor       eax,eax
       mov       rcx,rdx
       and       rcx,2
       je        short M00_L14
       movzx     eax,word ptr [r15]
       movzx     r8d,word ptr [rsi]
       sub       eax,r8d
M00_L14:
       test      dl,1
       je        short M00_L15
       movzx     edx,byte ptr [r15+rcx]
       movzx     ecx,byte ptr [rsi+rcx]
       sub       edx,ecx
       or        eax,edx
M00_L15:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L07
M00_L16:
       lea       rax,[rdx-4]
       mov       ecx,[r15]
       sub       ecx,[rsi]
       mov       edx,[r15+rax]
       sub       edx,[rsi+rax]
       or        ecx,edx
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L07
M00_L17:
       xor       r8d,r8d
       add       rdx,0FFFFFFFFFFFFFFE0
       je        short M00_L19
       vmovups   ymm0,[rax]
       vpcmpeqb  ymm0,ymm0,[rcx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M00_L23
M00_L18:
       add       r8,20
       cmp       rdx,r8
       jbe       short M00_L19
       vmovups   ymm0,[rax+r8]
       vpcmpeqb  ymm0,ymm0,[rcx+r8]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M00_L23
       jmp       short M00_L18
M00_L19:
       vmovups   ymm0,[rax+rdx]
       vpcmpeqb  ymm0,ymm0,[rcx+rdx]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M00_L23
       jmp       near ptr M00_L04
M00_L20:
       xor       r8d,r8d
       add       rdx,0FFFFFFFFFFFFFFF0
       je        short M00_L22
M00_L21:
       vmovups   xmm0,[rax+r8]
       vpcmpeqb  xmm0,xmm0,[rcx+r8]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M00_L23
       add       r8,10
       cmp       rdx,r8
       ja        short M00_L21
M00_L22:
       vmovups   xmm0,[rax+rdx]
       vpcmpeqb  xmm0,xmm0,[rcx+rdx]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       je        near ptr M00_L04
M00_L23:
       xor       eax,eax
       jmp       near ptr M00_L05
; Total bytes of code 669
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MemoryExtensionsBenchmark.IsNotEmpty()
       mov       eax,[rcx+1B4]
       test      eax,eax
       setne     al
       movzx     eax,al
       mov       rcx,[rcx+90]
       mov       [rcx+4C],al
       ret
; Total bytes of code 25
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MemoryExtensionsBenchmark.ToArrayIfNeeded()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       mov       edi,[rbx+1B0]
       mov       ebp,[rbx+1B4]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,[rsi]
       test      dword ptr [rcx],80000000
       je        short M00_L03
       mov       edx,edi
       and       edx,7FFFFFFF
       mov       r14d,[rsi+8]
       cmp       r14d,edx
       jb        short M00_L02
       sub       r14d,edx
       cmp       r14d,ebp
       jb        short M00_L02
       mov       r14,rsi
       mov       r15d,ebp
M00_L00:
       test      r14,r14
       je        near ptr M00_L11
       test      edx,edx
       jne       near ptr M00_L11
       cmp       [r14+8],r15d
       jne       near ptr M00_L11
M00_L01:
       mov       [rsp+20],r14
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       rcx,rsi
       mov       r8d,ebp
       call      qword ptr [7FFC03C4F108]
       int       3
M00_L03:
       lea       rdx,[rsp+58]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M00_L04
       mov       rdx,[rsp+58]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       r8d,edi
       add       r8d,[rsp+60]
       lea       rcx,[rsp+48]
       mov       r9d,ebp
       call      qword ptr [7FFC03C4F120]
       mov       r14,[rsp+48]
       mov       edx,[rsp+50]
       mov       r15d,[rsp+54]
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jne       short M00_L05
       mov       rcx,offset MT_System.ArraySegment<System.Byte>
       call      qword ptr [7FFC03635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2B6F0C001A8
       mov       rdx,[rdx]
       mov       r14,[rdx+8]
       mov       ecx,[rdx+10]
       mov       r15d,[rdx+14]
       mov       edx,ecx
       jmp       near ptr M00_L00
M00_L05:
       xor       r14d,r14d
       xor       r15d,r15d
       test      rsi,rsi
       je        short M00_L08
       mov       rdx,[rsi]
       test      dword ptr [rdx],80000000
       je        short M00_L06
       lea       r14,[rsi+10]
       mov       edx,[rsi+8]
       mov       r15d,edx
       jmp       short M00_L07
M00_L06:
       lea       rdx,[rsp+38]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,[rsp+38]
       mov       r15d,[rsp+40]
M00_L07:
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       ecx,ebp
       add       rcx,rax
       mov       edx,r15d
       cmp       rcx,rdx
       ja        near ptr M00_L14
       add       r14,rax
       mov       r15d,ebp
M00_L08:
       test      r15d,r15d
       jne       short M00_L09
       mov       r14,2F76FD962A0
       jmp       short M00_L10
M00_L09:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       r8d,r15d
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      qword ptr [7FFC03635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,rsi
M00_L10:
       jmp       near ptr M00_L01
M00_L11:
       xor       r14d,r14d
       xor       r15d,r15d
       test      rsi,rsi
       je        short M00_L16
       mov       rdx,[rsi]
       test      dword ptr [rdx],80000000
       je        short M00_L12
       lea       r14,[rsi+10]
       mov       edx,[rsi+8]
       mov       r15d,edx
       jmp       short M00_L13
M00_L12:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,[rsp+28]
       mov       r15d,[rsp+30]
M00_L13:
       and       edi,7FFFFFFF
       mov       edx,edi
       mov       ecx,ebp
       add       rcx,rdx
       mov       eax,r15d
       cmp       rcx,rax
       jbe       short M00_L15
M00_L14:
       call      qword ptr [7FFC037A7198]
       int       3
M00_L15:
       add       r14,rdx
       mov       r15d,ebp
M00_L16:
       test      r15d,r15d
       jne       short M00_L17
       mov       r14,2F76FD962A0
       jmp       short M00_L18
M00_L17:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       r8d,r15d
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      qword ptr [7FFC03635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,rsi
M00_L18:
       jmp       near ptr M00_L01
; Total bytes of code 633
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
       jmp       qword ptr [7FFC03635C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       jmp       qword ptr [7FFC036366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.MemoryExtensionsBenchmark.TryGetArraySegment()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+1A8]
       mov       esi,[rbx+1B0]
       mov       edi,[rbx+1B4]
       test      rcx,rcx
       je        near ptr M00_L04
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M00_L03
       mov       edx,esi
       and       edx,7FFFFFFF
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jb        short M00_L02
       sub       r8d,edx
       cmp       r8d,edi
       jb        short M00_L02
M00_L00:
       mov       esi,1
M00_L01:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       mov       [rsp+2C],edi
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC03C56C28]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ArraySegment`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<Byte> ByRef)
       mov       rax,[rbx+90]
       mov       [rax+4C],sil
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       r8d,edi
       call      qword ptr [7FFC03C5F000]
       int       3
M00_L03:
       lea       rdx,[rsp+40]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M00_L04
       mov       rdx,[rsp+40]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       mov       r8d,esi
       add       r8d,[rsp+48]
       lea       rcx,[rsp+30]
       mov       r9d,edi
       call      qword ptr [7FFC03C5F018]
       mov       rcx,[rsp+30]
       mov       edx,[rsp+38]
       mov       edi,[rsp+3C]
       jmp       near ptr M00_L00
M00_L04:
       test      edi,edi
       jne       short M00_L05
       mov       rcx,offset MT_System.ArraySegment<System.Byte>
       call      qword ptr [7FFC03645728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,133D08021A0
       mov       rcx,[rcx]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       mov       edi,[rcx+14]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L05:
       xor       ecx,ecx
       xor       edx,edx
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L01
; Total bytes of code 294
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ArraySegment`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](System.ArraySegment`1<Byte> ByRef)
       ret
; Total bytes of code 1
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
       jmp       qword ptr [7FFC03645C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

