## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF708]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE074F2E8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE074F2E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE074F2E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F2E340]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F2E358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D85BA8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F2E340]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,220C29AFDE0
       call      qword ptr [7FFAE0F2E358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F2E550]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,220C29A0008
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
       call      qword ptr [7FFAE0F2F900]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DBC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DBD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5C20]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F4DBC0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,200FBCEFFE0
       call      qword ptr [7FFAE0F4DBD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4E4D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,200FBCE0008
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
       call      qword ptr [7FFAE0F4FD38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3A8]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DC08]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,253D054FDE0
       call      qword ptr [7FFAE0F3DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4A8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,253D0540008
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
       call      qword ptr [7FFAE0F3FD08]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3D8]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DC20]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23F97C2FDE0
       call      qword ptr [7FFAE0F3DC38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23F97C20008
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
       call      qword ptr [7FFAE0F3FD80]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0B91FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CEF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B5CC18
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5CC18
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F2DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F2DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D85860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F2DC08]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23E7F89FDE0
       call      qword ptr [7FFAE0F2DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F2E508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23E7F890008
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
       call      qword ptr [7FFAE0F2FD68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0B91FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CEF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B5CC18
       call      qword ptr [7FFAE074F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A14CA0
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B5CC18
       call      qword ptr [7FFAE074F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE074D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F2DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F2DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D85830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F2DC08]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2EA868FFDE0
       call      qword ptr [7FFAE0F2DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F2E508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0745818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EA868F0008
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
       call      qword ptr [7FFAE0F2FD68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E5DD70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E5DD88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0E5DD70]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2BD0E13FDE0
       call      qword ptr [7FFAE0E5DD88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F5E538]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2BD0E130008
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
       call      qword ptr [7FFAE0FF43C0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRecord()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0EF58]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E55968]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E55980]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA53F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0E55968]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23BD44EFDE0
       call      qword ptr [7FFAE0E55980]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0E562F8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,23BD44E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFAE10247C8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0EF58]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DBD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA57B8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBC0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D4ABB7FFE0
       call      qword ptr [7FFAE0F3DBD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D4ABB70008
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
       call      qword ptr [7FFAE0F3FD38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95C20]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBD8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25E1A22FFE0
       call      qword ptr [7FFAE0F3DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25E1A220008
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
       call      qword ptr [7FFAE0F3FD50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBF0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27823C7FDE0
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27823C70008
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
       call      qword ptr [7FFAE0F3FD50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F4DC08]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2595AAAFDE0
       call      qword ptr [7FFAE0F4DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4E508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2595AAA0008
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
       call      qword ptr [7FFAE0F4FD68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0F3D8]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DC38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5878]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F4DC20]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26F09BDFDE0
       call      qword ptr [7FFAE0F4DC38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4E520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26F09BD0008
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
       call      qword ptr [7FFAE0F4FD80]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95BF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DC08]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2125FE3FFE0
       call      qword ptr [7FFAE0F3DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2125FE30008
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
       call      qword ptr [7FFAE0F3FD68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0D0EF58]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E5DDA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E5DDB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA53C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0E5DDA0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,263973BFDE0
       call      qword ptr [7FFAE0E5DDB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0E5E730]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,263973B0008
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
       call      qword ptr [7FFAE1004420]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomRef()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2F0]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-90],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+rcx*8]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E45968]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E45980]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0E45968]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26C4FFFFDE0
       call      qword ptr [7FFAE0E45980]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0E46310]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 644
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,26C4FFF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFAE10140F0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F472A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DBA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F4DBA8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24340F8FDE0
       call      qword ptr [7FFAE0F4DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4E4C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,24340F80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F4FD20]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F37288]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0CFF390]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3E2C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3E2E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95BF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3E2C8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20DDD3FFFE0
       call      qword ptr [7FFAE0F3E2E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,20DDD3F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F3FD20]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F372D0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBA8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,3193119FDE0
       call      qword ptr [7FFAE0F3DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,31931190008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F3FD20]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BB1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F47300]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DBD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0DA5830]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F4DBD8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F9D3C2FDE0
       call      qword ptr [7FFAE0F4DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4E4F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1F9D3C20008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F4FD50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F37300]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBF0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E0CC6EFDE0
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,1E0CC6E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F3FD50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BA1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F37300]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D95860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0F3DBF0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28299D3FDE0
       call      qword ptr [7FFAE0F3DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F3E4F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,28299D30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F3FD68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0BC1FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F472E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0D17630]
       mov       ecx,3
       mov       rdx,7FFAE0B8CC18
       call      qword ptr [7FFAE077F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A44CA0
       call      qword ptr [7FFAE077F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE077D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B8CC18
       call      qword ptr [7FFAE077F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE077D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE1014AF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE1014408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D1DAE8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE1014AF8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,19A2284FDE0
       call      qword ptr [7FFAE1014408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0F4FA50]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0775818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0775818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,19A22840008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FFAE0F4FB58]
       int       3
; Total bytes of code 244
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.PickRandomVal()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0B8],rdx
       mov       rdx,rbp
       mov       [rbp-0A8],rdx
       mov       [rbp+10],rbx
       mov       rdx,[rbx+2E8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rdi,[rdx+10]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       je        near ptr M00_L05
       mov       [rbp-0D8],rdi
       lea       r15d,[r14-1]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       edx,r13d
       shr       edx,2
       or        r13d,edx
       mov       edx,r13d
       shr       edx,4
       or        r13d,edx
       mov       edx,r13d
       shr       edx,8
       or        r13d,edx
       mov       edx,r13d
       shr       edx,10
       or        r13d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFAE0B81FD8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB8E523670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M00_L02
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L08
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r13d
       and       eax,[rbp-3C]
       cmp       eax,r15d
       ja        near ptr M00_L00
M00_L03:
       cmp       eax,r14d
       jae       near ptr M00_L09
       mov       ecx,eax
       imul      rcx,50
       mov       rdi,[rbp-0D8]
       vmovdqu   ymm0,ymmword ptr [rdi+rcx]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymm0,ymmword ptr [rdi+rcx+20]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmm0,xmmword ptr [rdi+rcx+40]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFAE0F4FC00]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       nop
       vzeroupper
       add       rsp,0C8
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
       call      qword ptr [7FFAE0CDF1C8]
       mov       ecx,3
       mov       rdx,7FFAE0B4CC18
       call      qword ptr [7FFAE073F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A04CA0
       call      qword ptr [7FFAE073F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE073D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B4CC18
       call      qword ptr [7FFAE073F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE073D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E27078]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E27090]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFAE0D75770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFAE0E27078]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28635E6FDE0
       call      qword ptr [7FFAE0E27090]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFAE0E25D40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
       ret
; Total bytes of code 1
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0735818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0735818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,28635E60008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFAE0FE4708]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,27268401EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE075F348]
       int       3
M00_L04:
       mov       rsi,2B2FD350008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0CFF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F3DBD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F3DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE0694000
       call      qword ptr [7FFAE075F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE0FF42D0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27268401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0756BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27268401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,2B2FD350008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B2FD350008
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
       call      qword ptr [7FFAE0F3FD50]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0ED3610]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0ED3620]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0ED3630]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F3EA00]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,195C5401EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE073F348]
       int       3
M00_L04:
       mov       rsi,1D65A560008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0CDF3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B4CC18
       call      qword ptr [7FFAE073F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A04CA0
       call      qword ptr [7FFAE073F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE073D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B4CC18
       call      qword ptr [7FFAE073F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE073D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F1DBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F1DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE0674000
       call      qword ptr [7FFAE073F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE0FD42D0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,195C5401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0736BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,195C5401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1D65A560008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0735818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0735818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D65A560008
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
       call      qword ptr [7FFAE0F1FD50]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0EB36F0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0EB3700]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0EB3710]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F1EA00]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,23F5A401EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE077F348]
       int       3
M00_L04:
       mov       rsi,27FEF320008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0D1F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B8CC18
       call      qword ptr [7FFAE077F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A44CA0
       call      qword ptr [7FFAE077F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE077D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B8CC18
       call      qword ptr [7FFAE077F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE077D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F5DBA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F5DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE06B4000
       call      qword ptr [7FFAE077F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE10142A0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23F5A401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0776BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23F5A401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,27FEF320008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0775818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0775818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27FEF320008
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
       call      qword ptr [7FFAE0F5FD08]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0EF76D0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0EF76E0]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0EF76F0]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F5E9B8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,1AC92401EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE076F348]
       int       3
M00_L04:
       mov       rsi,1ED27340008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0D0F3A8]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4E2F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4E310]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE06A4000
       call      qword ptr [7FFAE076F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE10042E8]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1AC92401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AC92401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1ED27340008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1ED27340008
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
       call      qword ptr [7FFAE0F4FD50]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0EE3D90]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0EE3DA0]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0EE3DB0]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F4EA00]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,2261E401EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE076F348]
       int       3
M00_L04:
       mov       rsi,266B3490008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0D0F3C0]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE06A4000
       call      qword ptr [7FFAE076F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE1004300]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2261E401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2261E401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,266B3490008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,266B3490008
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
       call      qword ptr [7FFAE0F4FD50]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0EE31B0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0EE31C0]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0EE31D0]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F4EA00]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,1967D001EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE076F348]
       int       3
M00_L04:
       mov       rsi,1D711DE0008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0D0F360]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0F4DBD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0F4DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE06A4000
       call      qword ptr [7FFAE076F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE1004240]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1967D001EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1967D001EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1D711DE0008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D711DE0008
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
       call      qword ptr [7FFAE0F4FCD8]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0EE6AB0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0EE6AC0]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0EE6AD0]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F4E970]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,156A6C01EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE075F348]
       int       3
M00_L04:
       mov       rsi,1973BD60008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0CFF3D8]
       mov       ecx,3
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A24CA0
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B6CC18
       call      qword ptr [7FFAE075F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE075D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E4ECD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E4ECE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE0694000
       call      qword ptr [7FFAE075F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE0FE4FC0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,156A6C01EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0756BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,156A6C01EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1973BD60008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0755818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1973BD60008
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
       call      qword ptr [7FFAE0FE43C0]
       int       3
; Total bytes of code 244
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE0F0E4B0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE0F0E4C0]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE0F0E4D0]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0F4EA18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L08
       cmp       edi,3FFFFFFF
       jl        short M00_L00
       cmp       edi,3FFFFFFF
       jg        near ptr M00_L06
M00_L00:
       mov       rcx,2411C801EA8
       mov       rbp,[rcx]
       lea       r14d,[rdi+rdi]
       mov       [rsp+38],rsi
       mov       [rsp+40],edi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rbp,rbp
       je        near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jle       short M00_L03
       mov       edx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       rsi,rax
       cmp       [rsi],sil
       lea       rdx,[rsi+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],r14d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
M00_L02:
       mov       [rsp+30],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       test      r14d,r14d
       je        short M00_L04
       mov       ecx,28
       call      qword ptr [7FFAE076F348]
       int       3
M00_L04:
       mov       rsi,281B1710008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFAE0D0EF70]
       mov       ecx,3
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFAE0A34CA0
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFAE0B7CC18
       call      qword ptr [7FFAE076F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE076D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAE0E5FA20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFAE0E5FA38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFAE06A4000
       call      qword ptr [7FFAE076F210]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFAE1025488]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2411C801EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFAE0766BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2411C801EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,281B1710008
       jmp       near ptr M00_L02
; Total bytes of code 529
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB403E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAE0765818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,281B1710008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFAE10240C0]
       int       3
; Total bytes of code 235
```
```assembly
; System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,[r8]
       mov       ecx,[r8+8]
       mov       r8d,[r8+10]
       cmp       ecx,4
       jge       near ptr M02_L02
       xor       r10d,r10d
       test      ecx,ecx
       jle       short M02_L01
M02_L00:
       movzx     r9d,byte ptr [rax+r10]
       mov       r11,[rdx]
       mov       ebx,[rdx+8]
       lea       esi,[r10+r10]
       mov       edi,r9d
       and       edi,0F0
       shl       edi,4
       and       r9d,0F
       lea       r9d,[rdi+r9-8989]
       mov       edi,r9d
       neg       edi
       and       edi,7070
       shr       edi,4
       lea       r9d,[rdi+r9+0B9B9]
       or        r9d,r8d
       lea       edi,[rsi+1]
       cmp       edi,ebx
       jae       near ptr M02_L07
       movzx     ebp,r9b
       mov       [r11+rdi*2],bp
       cmp       esi,ebx
       jae       near ptr M02_L07
       mov       ebx,esi
       shr       r9d,8
       mov       [r11+rbx*2],r9w
       inc       r10d
       cmp       r10d,ecx
       jl        short M02_L00
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,[rdx]
       test      r8d,r8d
       je        short M02_L05
       vmovups   xmm0,[7FFAE104E230]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFAE104E240]
M02_L04:
       vmovd     xmm2,dword ptr [rax+r8]
       vpsrlq    xmm3,xmm2,4
       vpunpcklbw xmm2,xmm3,xmm2
       vpand     xmm2,xmm1,xmm2
       vpshufb   xmm2,xmm0,xmm2
       vpmovzxbw xmm2,xmm2
       vmovups   [rdx+r8*4],xmm2
       add       r8,4
       cmp       r8,rcx
       je        short M02_L01
       cmp       r8,r10
       jbe       short M02_L04
       jmp       short M02_L06
M02_L05:
       vmovups   xmm0,[7FFAE104E250]
       jmp       short M02_L03
M02_L06:
       mov       r8,r10
       jmp       short M02_L04
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 261
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
       call      qword ptr [7FFAE0E567C0]
       int       3
; Total bytes of code 44
```

