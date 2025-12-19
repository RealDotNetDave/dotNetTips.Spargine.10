## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKeyPrefix()
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
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-0A8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       lea       rcx,[rbp-58]
       mov       rax,7FFC6CF5B3F0
       mov       [rbp-98],rax
       lea       rax,[M00_L00]
       mov       [rbp-88],rax
       lea       rax,[rbp-0A8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFCF9310930
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M00_L01
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-0A0]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L03
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-48],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFCCC488D20
       lea       rdx,[rax+0C]
       mov       ecx,[rax+8]
       cmp       ecx,20
       jl        near ptr M00_L04
       mov       dword ptr [rbp-60],20
       mov       [rbp-68],rdx
       vmovups   xmm0,[rbp-48]
       vmovups   xmm1,[7FFC6C928410]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFC6C928420]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFC6C928430]
       vpmovzxbw xmm2,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm3,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rdx],xmm2
       vmovups   [rdx+10],xmm1
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm0
       xor       edx,edx
       mov       [rbp-68],rdx
M00_L02:
       xor       edx,edx
       mov       [rbp-68],rdx
       mov       rdx,rax
       mov       rcx,21DC6A706A0
       call      qword ptr [7FFC6C847858]; System.String.Concat(System.String, System.String)
       mov       [rbp-70],rax
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFC6CFFCDF8
       cmp       [rcx],ecx
       call      qword ptr [7FFC6CF6ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       mov       ecx,eax
       call      qword ptr [7FFC6D016928]
       int       3
M00_L04:
       xor       edx,edx
       mov       [rbp-60],edx
       jmp       short M00_L02
; Total bytes of code 456
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
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21DC6A60008
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
       call      qword ptr [7FFC6D0166A0]
       int       3
; Total bytes of code 244
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateSortableKeyWithPrefix()
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
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-0A8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       lea       rcx,[rbp-58]
       mov       rax,7FFC6CF4C5F8
       mov       [rbp-98],rax
       lea       rax,[M00_L00]
       mov       [rbp-88],rax
       lea       rax,[rbp-0A8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFCF9310930
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M00_L01
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-0A0]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L03
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-48],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFCCC488D20
       lea       rdx,[rax+0C]
       mov       ecx,[rax+8]
       cmp       ecx,20
       jl        near ptr M00_L04
       mov       dword ptr [rbp-60],20
       mov       [rbp-68],rdx
       vmovups   xmm0,[rbp-48]
       vmovups   xmm1,[7FFC6C918400]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFC6C918410]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFC6C918420]
       vpmovzxbw xmm2,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm3,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rdx],xmm2
       vmovups   [rdx+10],xmm1
       vmovups   [rdx+20],xmm3
       vmovups   [rdx+30],xmm0
       xor       edx,edx
       mov       [rbp-68],rdx
M00_L02:
       xor       edx,edx
       mov       [rbp-68],rdx
       mov       rdx,rax
       mov       rcx,20A25B706A0
       call      qword ptr [7FFC6C837858]; System.String.Concat(System.String, System.String)
       mov       [rbp-70],rax
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFC6CFECDF8
       cmp       [rcx],ecx
       call      qword ptr [7FFC6CF5ED78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L03:
       mov       ecx,eax
       call      qword ptr [7FFC6D006940]
       int       3
M00_L04:
       xor       edx,edx
       mov       [rbp-60],edx
       jmp       short M00_L02
; Total bytes of code 456
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
       call      00007FFCCC488D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6C835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6C835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20A25B60008
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
       call      qword ptr [7FFC6D0066D0]
       int       3
; Total bytes of code 244
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateKey()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,168
       vzeroupper
       vmovaps   [rsp+150],xmm6
       vmovaps   [rsp+140],xmm7
       vmovaps   [rsp+130],xmm8
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-70],xmm4
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+10],rcx
       lea       rcx,[rbp-170]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-158],rcx
       mov       rcx,rbp
       mov       [rbp-148],rcx
       lea       rcx,[rbp-90]
       mov       rax,7FFC6CF4B3F0
       mov       [rbp-160],rax
       lea       rax,[M00_L01]
       mov       [rbp-150],rax
       lea       rax,[rbp-170]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFCF9310930
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M00_L02
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-168]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-80],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFCCC488D20
       mov       rbx,rax
       lea       rsi,[rbx+0C]
       mov       r8d,[rbx+8]
       cmp       r8d,20
       jl        near ptr M00_L05
       mov       dword ptr [rbp-98],20
       mov       [rbp-0A0],rsi
       vmovups   xmm0,[rbp-80]
       vmovups   xmm1,[7FFC6C918280]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFC6C918290]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vmovaps   [rbp-0F0],xmm3
       vpshufb   xmm1,xmm3,[7FFC6C9182A0]
       vmovaps   [rbp-0F0],xmm1
       vxorps    xmm1,xmm1,xmm1
       vmovaps   [rbp-100],xmm1
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-130],ymm1
       vmovdqu   xmmword ptr [rbp-110],xmm1
       vmovaps   [rbp-180],xmm0
       lea       r8,[rbp-180]
       lea       rdx,[rbp-0F0]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-100]
       call      qword ptr [7FFC6C8377B0]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-130]
       vmovaps   xmm6,[rbp-120]
       vmovaps   [rbp-180],xmm0
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFC6D007840]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm7,[rbp-0C0]
       vmovups   xmm8,[rbp-0B0]
       vmovaps   [rbp-180],xmm6
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0E0]
       call      qword ptr [7FFC6D007840]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rbp-0E0]
       vmovups   xmm1,[rbp-0D0]
       vmovups   [rsi],xmm7
       vmovups   [rsi+10],xmm8
       vmovups   [rsi+20],xmm0
       vmovups   [rsi+30],xmm1
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
M00_L03:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-138],rbx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       lea       r8,[rbp-138]
       mov       rdx,7FFC6CFECFA0
       cmp       [rcx],ecx
       call      qword ptr [7FFC6CF5ED00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vmovaps   xmm6,[rsp+150]
       vmovaps   xmm7,[rsp+140]
       vmovaps   xmm8,[rsp+130]
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       mov       ecx,eax
       call      qword ptr [7FFC6D0068C8]
       int       3
M00_L05:
       xor       ecx,ecx
       mov       [rbp-98],ecx
       jmp       short M00_L03
; Total bytes of code 717
```
```assembly
; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       vmovups   xmm0,[r8]
       vmovups   [rcx+10],xmm0
       vmovups   xmm0,[r9]
       vmovups   [rcx+20],xmm0
       ret
; Total bytes of code 29
```
```assembly
; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rcx],xmm1
       vmovups   [rcx+10],xmm0
       mov       rax,rcx
       ret
; Total bytes of code 32
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.KeyGeneratorBenchmark.GenerateSortableKey()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       lea       rcx,[rbp-50]
       mov       rax,7FFCFA4D5380
       call      rax
       mov       rbx,[rbp-50]
       mov       rax,22EFF801A98
       mov       rdi,[rax]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFCCC79F778],0
       jne       near ptr M00_L05
M00_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M00_L06
       add       rbx,[rdi+10]
M00_L01:
       mov       rdi,3FFFFFFFFFFFFFFF
       and       rbx,rdi
       lea       rcx,[rbp-70]
       mov       rax,7FFC6CF4C5F8
       mov       [rbp-0A8],rax
       lea       rax,[M00_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFCF9310930
       call      rax
M00_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M00_L03
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M00_L03:
       mov       rdx,[rbp-0B0]
       mov       [rsi+8],rdx
       test      eax,eax
       jne       near ptr M00_L04
       movsx     rcx,word ptr [rbp-6A]
       mov       rdx,[rbp-68]
       mov       [rbp-58],rdx
       mov       rdx,346DC5D63886594B
       mulx      rbx,rbx,rbx
       shr       rbx,0B
       mov       rsi,0FFFFC77CEDD32800
       add       rbx,rsi
       js        near ptr M00_L07
       mov       rdx,rbx
       sar       rdx,10
       movsx     rbx,bx
       and       ecx,0FFFF0FFF
       or        ecx,7000
       movsx     rcx,cx
       movzx     eax,byte ptr [rbp-58]
       and       eax,0FFFFFF3F
       or        eax,80
       mov       [rbp-58],al
       mov       [rbp-48],edx
       mov       [rbp-44],bx
       mov       [rbp-42],cx
       mov       rcx,[rbp-58]
       mov       [rbp-40],rcx
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFCCC488D20
       mov       rbx,rax
       lea       rdx,[rbx+0C]
       mov       ecx,[rbx+8]
       mov       [rbp-0C8],rdx
       mov       [rbp-0C0],ecx
       lea       rdx,[rbp-0C8]
       lea       rcx,[rbp-48]
       lea       r8,[rbp-78]
       mov       r9d,20
       call      qword ptr [7FFC6D0065F8]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, Int32)
       mov       [rbp-80],rbx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+18]
       mov       rdx,[rbp-80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L04:
       mov       ecx,eax
       call      qword ptr [7FFC6D0069E8]
       int       3
M00_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFC6CE26010]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       ecx,1667
       mov       rdx,7FFC6C774000
       call      qword ptr [7FFC6CAB7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6D0069D0]
       int       3
; Total bytes of code 595
```
```assembly
; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,0A8
       vmovaps   [rsp+90],xmm6
       xor       eax,eax
       mov       [rsp+88],rax
       mov       ebx,r9d
       movzx     r9d,bl
       cmp       r9d,[rdx+8]
       jg        near ptr M01_L04
       mov       [r8],r9d
       sar       ebx,8
       mov       rdx,[rdx]
       mov       [rsp+88],rdx
       mov       rsi,rdx
       test      bl,bl
       jne       near ptr M01_L05
M01_L00:
       sar       ebx,8
       vmovups   xmm0,[rcx]
       vmovups   xmm1,[7FFC6C919580]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFC6C919590]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFC6C9195A0]
       test      ebx,ebx
       jl        near ptr M01_L06
       vxorps    xmm6,xmm6,xmm6
M01_L01:
       vpmovzxbw xmm2,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm3,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       test      ebx,ebx
       jl        near ptr M01_L07
       vmovups   [rsi],xmm2
       vmovups   [rsi+10],xmm1
       vmovups   [rsi+20],xmm3
       vmovups   [rsi+30],xmm0
       add       rsi,40
M01_L02:
       test      bl,bl
       jne       near ptr M01_L08
M01_L03:
       xor       eax,eax
       mov       [rsp+88],rax
       mov       eax,1
       vmovaps   xmm6,[rsp+90]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       ret
M01_L04:
       xor       eax,eax
       mov       [r8],eax
       vmovaps   xmm6,[rsp+90]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       ret
M01_L05:
       lea       rsi,[rdx+2]
       movzx     r8d,bl
       mov       [rdx],r8w
       jmp       near ptr M01_L00
M01_L06:
       vpshufb   xmm2,xmm0,[7FFC6C9195B0]
       vmovaps   [rsp+70],xmm2
       vpshufb   xmm2,xmm1,[7FFC6C9195C0]
       vmovaps   [rsp+60],xmm2
       vpshufb   xmm1,xmm1,[7FFC6C9195D0]
       vpshufb   xmm0,xmm0,[7FFC6C9195E0]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFC6C9195F0]
       vmovaps   [rsp+50],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+60]
       lea       r8,[rsp+70]
       lea       r9,[rsp+50]
       call      qword ptr [7FFC6C8377B0]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm1,[rsp+20]
       vmovaps   xmm0,[rsp+30]
       vmovaps   xmm6,[rsp+40]
       jmp       near ptr M01_L01
M01_L07:
       vpmovzxbw xmm1,xmm6
       vpsrldq   xmm4,xmm6,8
       vpmovzxbw xmm4,xmm4
       vmovups   [rsi],xmm2
       vmovups   [rsi+28],xmm3
       vmovups   [rsi+38],xmm0
       vmovups   [rsi+10],xmm1
       vmovups   [rsi+20],xmm4
       add       rsi,48
       jmp       near ptr M01_L02
M01_L08:
       movzx     eax,bl
       mov       [rsi],ax
       jmp       near ptr M01_L03
; Total bytes of code 483
```
```assembly
; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       call      qword ptr [7FFCB8088418]
       mov       rax,[rax]
       lea       rcx,[rbp-20]
       call      rax
       mov       rdx,346DC5D63886594B
       mov       rax,rdx
       mul       qword ptr [rbp-20]
       shr       rdx,0B
       imul      rax,rdx,2710
       mov       rbx,[rbp-20]
       sub       rbx,rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M02_L04
M02_L00:
       lea       rcx,[rbp-20]
       lea       rdx,[rbp-30]
       call      qword ptr [7FFCB80B5678]
       test      eax,eax
       je        near ptr M02_L05
       cmp       word ptr [rbp-24],3C
       jae       near ptr M02_L06
       mov       eax,0B2D05E00
       add       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M02_L07
M02_L01:
       lea       rcx,[rbp-38]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFCB80B5678]
       test      eax,eax
       je        short M02_L05
       movzx     ecx,word ptr [rbp-3C]
       cmp       cx,[rbp-24]
       jne       short M02_L08
       mov       rsi,[rbp-20]
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFCB809B910]
       mov       rbx,rax
M02_L02:
       call      qword ptr [7FFCB8092680]
       mov       rdi,rax
       call      qword ptr [7FFCB80886A0]
       mov       [rdi+8],rsi
       mov       [rdi+10],rbx
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFCB8087FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbx,[rbp-20]
       sub       rbx,rsi
       mov       rax,rbx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L04:
       call      qword ptr [7FFCB8088028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFCB809B930]
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFCB809B910]
       jmp       short M02_L03
M02_L07:
       call      qword ptr [7FFCB8088028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L01
M02_L08:
       movups    xmm0,[rbp-30]
       movups    [rbp-58],xmm0
       mov       word ptr [rbp-50],0
       mov       word ptr [rbp-4E],0
       mov       word ptr [rbp-4C],0
       mov       word ptr [rbp-4A],0
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFCB8098FB0]
       test      eax,eax
       je        short M02_L05
       mov       rsi,0C87700CB80
       add       rsi,[rbp-60]
       mov       rcx,[rbp-20]
       sub       rcx,rsi
       mov       edx,0B2D05E00
       cmp       rcx,rdx
       jae       short M02_L06
       lea       rcx,[rbp-58]
       xor       edx,edx
       call      qword ptr [7FFCB809B910]
       mov       rbx,0C87700CB80
       add       rbx,rax
       jmp       near ptr M02_L02
; Total bytes of code 402
```

