## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rdi,2CED3E60AA0
       mov       rcx,28E55000180
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L04
M00_L00:
       mov       edx,25
       mov       rcx,offset MT_System.String
       call      00007FFE8C8950F0
       mov       r15,rax
       mov       [rbp-0B8],r15
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       [rbp-0C0],r13
       mov       rcx,offset DotNetTips.Spargine.Core.KeyGenerator+<>c.<GenerateKey>b__2_0(System.Span`1<Char>, System.String)
       cmp       [r14+18],rcx
       jne       near ptr M00_L06
       mov       rcx,54005300450054
       mov       [r13],rcx
       mov       word ptr [r13+8],5F
       lea       rcx,[rbp-60]
       mov       rax,7FFE2D1BE7D0
       mov       [rbp-90],rax
       lea       rax,[M00_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFADB80930
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L02
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rdx,[rbp-98]
       mov       [rsi+8],rdx
       test      eax,eax
       jne       near ptr M00_L05
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-48],xmm0
       mov       r13,[rbp-0C0]
       add       r13,0A
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],20
       lea       rdx,[rbp-0B0]
       lea       rcx,[rbp-48]
       lea       r8,[rbp-50]
       mov       r9d,20
       call      qword ptr [7FFE2D20EC70]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, Int32)
M00_L03:
       mov       r15,[rbp-0B8]
       mov       [rbp-68],r15
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-68]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,28E55000178
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.KeyGenerator+<>c.<GenerateKey>b__2_0(System.Span`1<Char>, System.String)
       call      qword ptr [7FFE2CBE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28E55000180
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L05:
       mov       ecx,eax
       call      qword ptr [7FFE2D20EC40]
       int       3
M00_L06:
       mov       [rbp-0B0],r13
       mov       dword ptr [rbp-0A8],25
       lea       rdx,[rbp-0B0]
       mov       r8,rdi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M00_L03
; Total bytes of code 564
```
```assembly
; DotNetTips.Spargine.Core.KeyGenerator+<>c.<GenerateKey>b__2_0(System.Span`1<Char>, System.String)
; 			p.AsSpan().CopyTo(span);
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 			span[p.Length] = '_';
; 			^^^^^^^^^^^^^^^^^^^^^
; 			_ = Guid.NewGuid().TryFormat(span[(p.Length + 1)..], out _, "N");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rdx
       mov       rsi,r8
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-88],r8
       mov       r8,rbp
       mov       [rbp-78],r8
       mov       r14,[rbx]
       mov       [rbp-0A8],r14
       mov       ebx,[rbx+8]
       test      rsi,rsi
       jne       near ptr M01_L04
       xor       edx,edx
       xor       r8d,r8d
M01_L00:
       cmp       r8d,ebx
       jg        near ptr M01_L05
       mov       r8d,r8d
       add       r8,r8
       mov       rcx,r14
       call      qword ptr [7FFE2CBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbp+20],rsi
       mov       ecx,[rsi+8]
       cmp       ecx,ebx
       jae       near ptr M01_L09
       mov       word ptr [r14+rcx*2],5F
       lea       rcx,[rbp-60]
       mov       rax,7FFE2D1BE7D0
       mov       [rbp-90],rax
       lea       rax,[M01_L01]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFFADB80930
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L02
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-98]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       near ptr M01_L06
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-50],xmm0
       mov       rsi,[rbp+20]
       mov       eax,[rsi+8]
       add       eax,1
       jo        near ptr M01_L10
       cmp       eax,ebx
       ja        near ptr M01_L07
       mov       ecx,eax
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+rcx*2]
       sub       ebx,eax
       cmp       ebx,20
       jl        near ptr M01_L08
       mov       dword ptr [rbp-40],20
       mov       [rbp-68],rcx
       vmovups   xmm0,[rbp-50]
       vmovups   xmm1,[7FFE2CC7F4B0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFE2CC7F4C0]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFE2CC7F4D0]
       vpmovzxbw xmm2,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm3,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rcx],xmm2
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm3
       vmovups   [rcx+30],xmm0
       xor       eax,eax
       mov       [rbp-68],rax
M01_L03:
       xor       eax,eax
       mov       [rbp-68],rax
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
M01_L04:
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       jmp       near ptr M01_L00
M01_L05:
       call      qword ptr [7FFE2D00CF00]
       int       3
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFE2D20EC40]
       int       3
M01_L07:
       call      qword ptr [7FFE2CD57198]
       int       3
M01_L08:
       xor       eax,eax
       mov       [rbp-40],eax
       jmp       short M01_L03
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 524
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
       jg        near ptr M02_L04
       mov       [r8],r9d
       sar       ebx,8
       mov       rdx,[rdx]
       mov       [rsp+88],rdx
       mov       rsi,rdx
       test      bl,bl
       jne       near ptr M02_L05
M02_L00:
       sar       ebx,8
       vmovups   xmm0,[rcx]
       vmovups   xmm1,[7FFE2CC82C20]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFE2CC82C30]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFE2CC82C40]
       test      ebx,ebx
       jl        near ptr M02_L06
       vxorps    xmm6,xmm6,xmm6
M02_L01:
       vpmovzxbw xmm2,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm3,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       test      ebx,ebx
       jl        near ptr M02_L07
       vmovups   [rsi],xmm2
       vmovups   [rsi+10],xmm1
       vmovups   [rsi+20],xmm3
       vmovups   [rsi+30],xmm0
       add       rsi,40
M02_L02:
       test      bl,bl
       jne       near ptr M02_L08
M02_L03:
       xor       eax,eax
       mov       [rsp+88],rax
       mov       eax,1
       vmovaps   xmm6,[rsp+90]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       ret
M02_L04:
       xor       eax,eax
       mov       [r8],eax
       vmovaps   xmm6,[rsp+90]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       ret
M02_L05:
       lea       rsi,[rdx+2]
       movzx     r8d,bl
       mov       [rdx],r8w
       jmp       near ptr M02_L00
M02_L06:
       vpshufb   xmm2,xmm0,[7FFE2CC82C50]
       vmovaps   [rsp+70],xmm2
       vpshufb   xmm2,xmm1,[7FFE2CC82C60]
       vmovaps   [rsp+60],xmm2
       vpshufb   xmm1,xmm1,[7FFE2CC82C70]
       vpshufb   xmm0,xmm0,[7FFE2CC82C80]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFE2CC82C90]
       vmovaps   [rsp+50],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+60]
       lea       r8,[rsp+70]
       lea       r9,[rsp+50]
       call      qword ptr [7FFE2CBE7798]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm1,[rsp+20]
       vmovaps   xmm0,[rsp+30]
       vmovaps   xmm6,[rsp+40]
       jmp       near ptr M02_L01
M02_L07:
       vpmovzxbw xmm1,xmm6
       vpsrldq   xmm4,xmm6,8
       vpmovzxbw xmm4,xmm4
       vmovups   [rsi],xmm2
       vmovups   [rsi+28],xmm3
       vmovups   [rsi+38],xmm0
       vmovups   [rsi+10],xmm1
       vmovups   [rsi+20],xmm4
       add       rsi,48
       jmp       near ptr M02_L02
M02_L08:
       movzx     eax,bl
       mov       [rsi],ax
       jmp       near ptr M02_L03
; Total bytes of code 483
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE2D295878]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFFACBE5380
       call      rax
       mov       rbx,[rbp-50]
       mov       rax,20C9B401B08
       mov       rdi,[rax]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L06
M00_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M00_L07
       add       rbx,[rdi+10]
M00_L01:
       mov       rdi,3FFFFFFFFFFFFFFF
       and       rbx,rdi
       lea       rcx,[rbp-70]
       mov       rax,7FFE2D254408
       mov       [rbp-0A8],rax
       lea       rax,[M00_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFADB80930
       call      rax
M00_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L03
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M00_L03:
       mov       rdx,[rbp-0B0]
       mov       [rsi+8],rdx
       test      eax,eax
       jne       near ptr M00_L05
       movsx     rcx,word ptr [rbp-6A]
       mov       rdx,[rbp-68]
       mov       [rbp-58],rdx
       mov       rdx,346DC5D63886594B
       mulx      rbx,rbx,rbx
       shr       rbx,0B
       mov       rsi,0FFFFC77CEDD32800
       add       rbx,rsi
       js        near ptr M00_L08
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
       call      00007FFE8C8950F0
       mov       rbx,rax
       lea       rdx,[rbx+0C]
       mov       esi,[rbx+8]
       mov       ecx,esi
       mov       [rbp-0C8],rdx
       mov       [rbp-0C0],ecx
       lea       rdx,[rbp-0C8]
       lea       rcx,[rbp-48]
       lea       r8,[rbp-78]
       mov       r9d,20
       call      qword ptr [7FFE2D2C52C0]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, Int32)
       mov       rcx,24D304C0AA0
       test      esi,esi
       je        near ptr M00_L09
       mov       edx,esi
       add       rdx,5
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L10
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE8C8950F0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8,rcx
       mov       rdx,54005300450054
       mov       [r8],rdx
       lea       r8,[rcx+8]
       mov       word ptr [r8],5F
       add       rcx,0A
       mov       r8d,esi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [rbp-80],rdi
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
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
M00_L05:
       mov       ecx,eax
       call      qword ptr [7FFE2D2C56B0]
       int       3
M00_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFE2D136CB8]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,1667
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C5698]
       int       3
M00_L09:
       mov       rdx,24D304B25A8
       call      qword ptr [7FFE2CC17840]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L10:
       call      qword ptr [7FFE2D2C5290]
       int       3
; Total bytes of code 742
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
       vmovups   xmm1,[7FFE2D320700]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFE2D320710]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFE2D320720]
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
       vpshufb   xmm2,xmm0,[7FFE2D320730]
       vmovaps   [rsp+70],xmm2
       vpshufb   xmm2,xmm1,[7FFE2D320740]
       vmovaps   [rsp+60],xmm2
       vpshufb   xmm1,xmm1,[7FFE2D320750]
       vpshufb   xmm0,xmm0,[7FFE2D320760]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFE2D320770]
       vmovaps   [rsp+50],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+60]
       lea       r8,[rsp+70]
       lea       r9,[rsp+50]
       call      qword ptr [7FFE2CC17798]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
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
       jne       short M02_L00
       test      r8b,4
       jne       short M02_L05
       test      r8,r8
       je        short M02_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L04
M02_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M02_L04
M02_L01:
       cmp       r8,40
       ja        short M02_L06
M02_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M02_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M02_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L04:
       vzeroupper
       ret
M02_L05:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M02_L04
M02_L06:
       cmp       r8,800
       ja        short M02_L10
       cmp       r8,100
       jb        short M02_L07
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
       ja        near ptr M02_L02
       jmp       near ptr M02_L03
M02_L09:
       cmp       rcx,rdx
       jne       short M02_L10
       cmp       [rdx],dl
       jmp       near ptr M02_L04
M02_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CC166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 315
```
```assembly
; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       call      qword ptr [7FFE8C669430]
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
       jne       near ptr M03_L04
M03_L00:
       lea       rcx,[rbp-20]
       lea       rdx,[rbp-30]
       call      qword ptr [7FFE8C696588]
       test      eax,eax
       je        near ptr M03_L05
       cmp       word ptr [rbp-24],3C
       jae       near ptr M03_L06
       mov       eax,0B2D05E00
       add       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M03_L07
M03_L01:
       lea       rcx,[rbp-38]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFE8C696588]
       test      eax,eax
       je        short M03_L05
       movzx     ecx,word ptr [rbp-3C]
       cmp       cx,[rbp-24]
       jne       short M03_L08
       mov       rsi,[rbp-20]
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFE8C67C8B8]
       mov       rbx,rax
M03_L02:
       call      qword ptr [7FFE8C6735D8]
       mov       rdi,rax
       call      qword ptr [7FFE8C6696B8]
       mov       [rdi+8],rsi
       mov       [rdi+10],rbx
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbx,[rbp-20]
       sub       rbx,rsi
       mov       rax,rbx
M03_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L04:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE8C67C8D8]
       jmp       short M03_L03
M03_L06:
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFE8C67C8B8]
       jmp       short M03_L03
M03_L07:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L01
M03_L08:
       movups    xmm0,[rbp-30]
       movups    [rbp-58],xmm0
       mov       word ptr [rbp-50],0
       mov       word ptr [rbp-4E],0
       mov       word ptr [rbp-4C],0
       mov       word ptr [rbp-4A],0
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFE8C679F40]
       test      eax,eax
       je        short M03_L05
       mov       rsi,0C87700CB80
       add       rsi,[rbp-60]
       mov       rcx,[rbp-20]
       sub       rcx,rsi
       mov       edx,0B2D05E00
       cmp       rcx,rdx
       jae       short M03_L06
       lea       rcx,[rbp-58]
       xor       edx,edx
       call      qword ptr [7FFE8C67C8B8]
       mov       rbx,0C87700CB80
       add       rbx,rax
       jmp       near ptr M03_L02
; Total bytes of code 402
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24D304B0008
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
       call      qword ptr [7FFE2D2C5290]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFE2D234518
       mov       [rbp-160],rax
       lea       rax,[M00_L01]
       mov       [rbp-150],rax
       lea       rax,[rbp-170]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFADB80930
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L02
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-168]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-80],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFE8C8950F0
       mov       rbx,rax
       lea       rsi,[rbx+0C]
       mov       r8d,[rbx+8]
       cmp       r8d,20
       jl        near ptr M00_L05
       mov       dword ptr [rbp-98],20
       mov       [rbp-0A0],rsi
       vmovups   xmm0,[rbp-80]
       vmovups   xmm1,[7FFE2CCA9D20]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFE2CCA9D30]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vmovaps   [rbp-0F0],xmm3
       vpshufb   xmm1,xmm3,[7FFE2CCA9D40]
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
       call      qword ptr [7FFE2CBF7798]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-130]
       vmovaps   xmm6,[rbp-120]
       vmovaps   [rbp-180],xmm0
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFE2D2A6400]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm7,[rbp-0C0]
       vmovups   xmm8,[rbp-0B0]
       vmovaps   [rbp-180],xmm6
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0E0]
       call      qword ptr [7FFE2D2A6400]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
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
       mov       rcx,[rbx+88]
       lea       r8,[rbp-138]
       mov       rdx,7FFE2D28AAD8
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D22E3D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE2D2A55C0]
       int       3
M00_L05:
       xor       ecx,ecx
       mov       [rbp-98],ecx
       jmp       short M00_L03
; Total bytes of code 720
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFFACBE5380
       call      rax
       mov       rbx,[rbp-50]
       mov       rax,1D958401B08
       mov       rdi,[rax]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFE8CB54A90],0
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
       mov       rax,7FFE2D224518
       mov       [rbp-0A8],rax
       lea       rax,[M00_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFADB80930
       call      rax
M00_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L03
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C8950F0
       mov       rbx,rax
       lea       rdx,[rbx+0C]
       mov       ecx,[rbx+8]
       mov       [rbp-0C8],rdx
       mov       [rbp-0C0],ecx
       lea       rdx,[rbp-0C8]
       lea       rcx,[rbp-48]
       lea       r8,[rbp-78]
       mov       r9d,20
       call      qword ptr [7FFE2D2952D8]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, Int32)
       mov       [rbp-80],rbx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
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
       call      qword ptr [7FFE2D2956C8]
       int       3
M00_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFE2D106CB8]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L07:
       mov       ecx,1667
       mov       rdx,7FFE2CB24000
       call      qword ptr [7FFE2CE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2956B0]
       int       3
; Total bytes of code 598
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
       vmovups   xmm1,[7FFE2D300580]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFE2D300590]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFE2D3005A0]
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
       vpshufb   xmm2,xmm0,[7FFE2D3005B0]
       vmovaps   [rsp+70],xmm2
       vpshufb   xmm2,xmm1,[7FFE2D3005C0]
       vmovaps   [rsp+60],xmm2
       vpshufb   xmm1,xmm1,[7FFE2D3005D0]
       vpshufb   xmm0,xmm0,[7FFE2D3005E0]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFE2D3005F0]
       vmovaps   [rsp+50],xmm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+60]
       lea       r8,[rsp+70]
       lea       r9,[rsp+50]
       call      qword ptr [7FFE2CBE7798]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
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
       call      qword ptr [7FFE8C669430]
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
       call      qword ptr [7FFE8C696588]
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
       call      qword ptr [7FFE8C696588]
       test      eax,eax
       je        short M02_L05
       movzx     ecx,word ptr [rbp-3C]
       cmp       cx,[rbp-24]
       jne       short M02_L08
       mov       rsi,[rbp-20]
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFE8C67C8B8]
       mov       rbx,rax
M02_L02:
       call      qword ptr [7FFE8C6735D8]
       mov       rdi,rax
       call      qword ptr [7FFE8C6696B8]
       mov       [rdi+8],rsi
       mov       [rdi+10],rbx
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8C67C8D8]
       jmp       short M02_L03
M02_L06:
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFE8C67C8B8]
       jmp       short M02_L03
M02_L07:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFE8C679F40]
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
       call      qword ptr [7FFE8C67C8B8]
       mov       rbx,0C87700CB80
       add       rbx,rax
       jmp       near ptr M02_L02
; Total bytes of code 402
```

