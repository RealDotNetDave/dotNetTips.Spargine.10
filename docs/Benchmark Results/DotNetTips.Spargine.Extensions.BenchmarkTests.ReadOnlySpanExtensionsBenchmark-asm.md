## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F40CB0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE4D8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030B4408]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030B4420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95590]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030B4408]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C11B07FD88
       call      qword ptr [7FFA030B4420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031EE778]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C11B070008
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
       call      qword ptr [7FFA031E7240]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144960]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2AA2A66FD88
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE7F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AA2A660008
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
       call      qword ptr [7FFA031D72B8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02EF2970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EC6CB8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0301CCD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0301CCF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02ECE028]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA0301CCD8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2401480FF88
       call      qword ptr [7FFA0301CCF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0313F2E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24014800008
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
       call      qword ptr [7FFA0313F7F8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F22970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EF6CB8]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0304CCF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0304CD08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02EFE028]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA0304CCF0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,256A773FF88
       call      qword ptr [7FFA0304CD08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0316F1E0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,256A7730008
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
       call      qword ptr [7FFA0316F810]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02EF2970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EC6CB8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0301CC90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0301CCA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02ECDB18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA0301CC90]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D4011DFD88
       call      qword ptr [7FFA0301CCA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0313F258]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D4011D0008
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
       call      qword ptr [7FFA0313F7C8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144930]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21A5ECBFD88
       call      qword ptr [7FFA03144948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE820]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21A5ECB0008
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
       call      qword ptr [7FFA031D7378]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F02970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02ED6CD0]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030A5050]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030A5068]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02EDDB30]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030A5050]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25D1F0DFD88
       call      qword ptr [7FFA030A5068]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0321DE00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,25D1F0D0008
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
       call      qword ptr [7FFA0321C5B8]
       int       3
; Total bytes of code 231
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+278]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030566B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030566D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5EF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030566B8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23E47EBFF88
       call      qword ptr [7FFA030566D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA032A5F38]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23E47EB0008
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
       call      qword ptr [7FFA0316F2E8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F519A0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02ECE9A0]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030B4918]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030B4930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95D10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030B4918]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,268B568FF88
       call      qword ptr [7FFA030B4930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031CE7C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,268B5680008
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
       call      qword ptr [7FFA031C72A0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F71FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EEE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03154960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03154978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FB5848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03154960]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1FE4905FD88
       call      qword ptr [7FFA03154978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031EE808]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FE49050008
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
       call      qword ptr [7FFA031E72E8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144960]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2159C36FD88
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE838]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2159C360008
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
       call      qword ptr [7FFA031D7300]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F51FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02ECE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95998]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03134930]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29C721AFD88
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031CE838]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29C721A0008
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
       call      qword ptr [7FFA031C7300]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144960]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C908BCFD88
       call      qword ptr [7FFA03144978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE820]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C908BC0008
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
       call      qword ptr [7FFA031D7360]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F91FA0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02F0E9E8]
       mov       ecx,3
       mov       rdx,7FFA02D77550
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C54878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D77550
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03174918]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03174930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FD5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03174918]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2992221FD88
       call      qword ptr [7FFA03174930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0320E820]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29922210008
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
       call      qword ptr [7FFA03207378]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02EF2970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EC6CB8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030854E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03085500]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02ECDD70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030854E8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24DBD9EFD88
       call      qword ptr [7FFA03085500]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031FDA58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,24DBD9E0008
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
       call      qword ptr [7FFA031F7D68]
       int       3
; Total bytes of code 231
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FFA02F22970
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFA02EF6CB8]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0305F6F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0305F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02EFE028]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA0305F6F0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,246F790FF88
       call      qword ptr [7FFA0305F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA03245728]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 641
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,246F7900008
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
       call      qword ptr [7FFA0319FE88]
       int       3
; Total bytes of code 231
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F51FA0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0313D5A8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02ECE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03134930]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C18E5EFD88
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031CE7A8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C18E5E0008
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
       call      qword ptr [7FFA031C7270]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0314D698]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144930]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2F0AD62FD88
       call      qword ptr [7FFA03144948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE7C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2F0AD620008
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
       call      qword ptr [7FFA031D7288]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F71FA0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0315D698]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EEE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03154948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03154960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FB5AA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03154948]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C167C5FD88
       call      qword ptr [7FFA03154960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031EE7A8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C167C50008
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
       call      qword ptr [7FFA031E7270]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F40CB0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA030BD0E0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EDE4D8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030B4468]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030B4480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95848]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA030B4468]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B845EFFF88
       call      qword ptr [7FFA030B4480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031EE760]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B845EF0008
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
       call      qword ptr [7FFA031E7240]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F61FA0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0314D698]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EDE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144918]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FA5EF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03144918]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2F3E942FF88
       call      qword ptr [7FFA03144930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031DE790]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2F3E9420008
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
       call      qword ptr [7FFA031D72E8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F51FA0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0313D6E0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02ECE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134990]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA031349A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02F95D58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA03134990]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,242DF0EFF88
       call      qword ptr [7FFA031349A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA031CE7C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,242DF0E0008
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
       call      qword ptr [7FFA031C7330]
       int       3
; Total bytes of code 244
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02F819A0
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA03214FC0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EFE9D0]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA031554E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03155500]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02FC5A88]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA031554E8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1FBD346FD88
       call      qword ptr [7FFA03155500]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA0321E4A8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M02_L00
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M02_L00
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       test      rsi,rsi
       je        short M02_L01
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,1FBD3460008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFA032178A0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FFA02EF2970
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M00_L02
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA0321F330]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFA02EC6CD0]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302F858]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302F870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFA02ECE040]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFA0302F858]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2BCA39CFF88
       call      qword ptr [7FFA0302F870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFA03215848]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,2BCA39C0008
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
       call      qword ptr [7FFA0315FE88]
       int       3
; Total bytes of code 231
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2BBA6C00AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,2BB90C00100
       mov       r8,[r8]
       mov       rdx,2FC25B73110
       call      qword ptr [7FFA02CE4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B52100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ADF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031C0CD8
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D548]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02EFE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03164960]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03164978]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,2FC25B60008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA031F5068]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5440]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031F4B28]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA031FE8C8]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA031FF6C0]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2BBA6C00AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA031F54A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA031FF6C0]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA031F5068]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5530]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,33362595CAC6
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,33362595CAC6
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA031F4A38]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE7C0]
       mov       r8,33362595CAC6
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE7D8]
       mov       r8,33362595CAC6
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EF4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B85DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA031FE7F0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE808]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE808]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA031FF498]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA031FE718]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03167828]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA031FE820]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AD76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2BB90C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,33362595CAC6
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,2FC25B60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA031F5080]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AD7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA031F54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D7C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2FC25B60008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA031F72B8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031E3894
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031E389C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031E3890
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031E388C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031E3888
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031E3884
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031E38A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031E38A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA031F4180]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031E3880
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02EFE358]
M10_L15:
       mov       rcx,7FFA031E3898
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA031FF6C0]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2268C800AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,22676800100
       mov       r8,[r8]
       mov       rdx,2670B953110
       call      qword ptr [7FFA02CE4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B52100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ADF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031C16D8
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D668]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02EFE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03164918]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03164930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,2670B940008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA031F5098]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5440]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031F4B58]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA031FE8F8]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA031FF6F0]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2268C800AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA031F54D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA031FF6F0]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA031F5098]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5530]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,0D30D2B34C633
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,0D30D2B34C633
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA031F4A68]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE7F0]
       mov       r8,0D30D2B34C633
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE808]
       mov       r8,0D30D2B34C633
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EF4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B85DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA031FE820]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE838]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE838]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA031FF4C8]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA031FE748]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03167930]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA031FE850]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AD76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,22676800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0D30D2B34C633
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,2670B940008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA031F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AD7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA031F54E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D7C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2670B940008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA031F72E8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031E3E64
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031E3E6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031E3E60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031E3E5C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031E3E58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031E3E54
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031E3E70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031E3E74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA031F41B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031E3E50
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02EFE358]
M10_L15:
       mov       rcx,7FFA031E3E68
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA031FF6F0]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2BCC8C00AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,2BCB2C00100
       mov       r8,[r8]
       mov       rdx,2FD47CB3110
       call      qword ptr [7FFA02CB4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B22100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02AAF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031916D8
       cmp       [rcx],ecx
       call      qword ptr [7FFA0313D638]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02ECE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D37550
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03134930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03134948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,2FD47CA0008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA031C4FD8]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F951D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031C4B10]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA031CE8C8]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA031C5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D47960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA031CFC60]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02ECEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2BCC8C00AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       call      qword ptr [7FFA031C5488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D47960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA031CFC60]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02ECEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA031C4FD8]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F952C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,97A7A34B8F20
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,97A7A34B8F20
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA031C4A08]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031CE7F0]
       mov       r8,97A7A34B8F20
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031CE808]
       mov       r8,97A7A34B8F20
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EC4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B55DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA031CE820]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031CE838]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031CE838]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA031CFA50]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA031CE748]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03137900]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA031CE850]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AA76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2BCB2C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02BFFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,97A7A34B8F20
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,2FD47CA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       call      qword ptr [7FFA031C5068]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02ECEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA031C5470]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AA7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA031C5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA031C54A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D4C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2FD47CA0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA031C72B8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031B3E64
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031B3E6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031B3E60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031B3E5C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031B3E58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031B3E54
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031B3E70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031B3E74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA031C4168]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031B3E50
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02ECE358]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FFA031B3E68
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02ECEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D47960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA031C5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA031CFC60]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2374A400AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,23734400100
       mov       r8,[r8]
       mov       rdx,277C9543110
       call      qword ptr [7FFA02CF4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B62100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031D16D8
       cmp       [rcx],ecx
       call      qword ptr [7FFA0317D668]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02F0E9E8]
       mov       ecx,3
       mov       rdx,7FFA02D77550
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C54878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D77550
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03174918]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03174930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,277C9530008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA03205098]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FD5440]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA03204B58]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA0320E910]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rsi,rax
       call      qword ptr [7FFA032054D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D87960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA0320F708]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02F0EB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2374A400AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       call      qword ptr [7FFA032054D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D87960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA0320F708]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02F0EB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA03205098]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FD5530]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,0D3318E12E90E
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,0D3318E12E90E
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA03204A68]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA0320E808]
       mov       r8,0D3318E12E90E
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA0320E820]
       mov       r8,0D3318E12E90E
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02F04F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B95DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA0320E838]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA0320E850]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA0320E850]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA0320F4E0]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA0320E760]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03177930]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA0320E868]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AE76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,23734400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C3FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0D3318E12E90E
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,277C9530008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       call      qword ptr [7FFA032050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02F0EB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rsi,rax
       call      qword ptr [7FFA032054B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AE7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rsi,rax
       call      qword ptr [7FFA032054D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA032054E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D8C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,277C9530008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA03207300]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031F3984
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031F398C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031F3980
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031F397C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031F3978
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031F3974
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031F3990
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031F3994
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA032041B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031F3970
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02F0E358]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FFA031F3988
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02F0EB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D87960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       rsi,rax
       call      qword ptr [7FFA032054D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B9DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA0320F708]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2533B000AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,25325000100
       mov       r8,[r8]
       mov       rdx,293BA123110
       call      qword ptr [7FFA02CD4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B42100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ACF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031B0CA8
       cmp       [rcx],ecx
       call      qword ptr [7FFA0315D6B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02EEE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA031549A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA031549C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,293BA110008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA031F50C8]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FB5440]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA031F4B88]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA031FE928]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA031F5500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA031FF720]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2533B000AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       call      qword ptr [7FFA031F5500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA031FF720]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA031F50C8]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FB5530]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,0D32AC31CF36A
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,0D32AC31CF36A
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA031F4A98]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE850]
       mov       r8,0D32AC31CF36A
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FE868]
       mov       r8,0D32AC31CF36A
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EE4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B75DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA031FE880]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE898]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FE898]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA031FF4F8]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA031FE7A8]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03157978]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA031FE8B0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AC76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,25325000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C1FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0D32AC31CF36A
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,293BA110008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       call      qword ptr [7FFA031F50E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02EEEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA031F54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AC7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA031F5500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA031F5518]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D6C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,293BA110008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA031F73A8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031D340C
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031D3414
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031D3408
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031D3404
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031D3400
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031D33FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031D3418
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031D341C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA031F41E0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031D33F8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02EEE358]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FFA031D3410
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA031F5500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA031FF720]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L10
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L11
       mov       r8,2308A800AC8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L13
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L12
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L13
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L17
       add       r14d,2
       jo        near ptr M00_L17
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L15
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L16
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,23074800100
       mov       r8,[r8]
       mov       rdx,27109873110
       call      qword ptr [7FFA02CE4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L07
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M00_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B52100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ADF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L08:
       call      M00_L18
       nop
       mov       rbx,[rbp-50]
M00_L09:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA031C05B0
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D578]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFA02EFE9E8]
       mov       ecx,3
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D67550
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03164930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03164948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,27109860008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FFA03205080]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5440]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L15:
       mov       ecx,13CC2
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA03204B40]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA0320E8F8]
       jmp       near ptr M00_L02
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA032054B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [r15+10],0
       jne       short M00_L20
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L30
M00_L20:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L22
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L21
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA0320FC90]
       jmp       near ptr M00_L30
M00_L22:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L24
M00_L23:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L23
M00_L24:
       cmp       rbx,r15
       je        near ptr M00_L29
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L27
       cmp       ecx,400
       jge       short M00_L25
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L26
M00_L25:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L28:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L29:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L30:
       mov       rax,2308A800AC8
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L42
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L31
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA032054B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       cmp       qword ptr [r15+10],0
       jne       short M00_L32
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L43
M00_L32:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L34
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L33
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA0320FC90]
       jmp       near ptr M00_L43
M00_L34:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L36
M00_L35:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L35
M00_L36:
       cmp       rsi,r15
       je        near ptr M00_L41
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L41:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L43
M00_L42:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L47
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FFA03205080]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FC5530]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L47
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1671
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,637670421D3C
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,637670421D3C
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA03204A50]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA0320E820]
       mov       r8,637670421D3C
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA0320E838]
       mov       r8,637670421D3C
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EF4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B85DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA0320E850]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA0320E868]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA0320E868]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA0320FA80]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA0320E778]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA03167858]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA0320E880]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AD76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,23074800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,637670421D3C
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,27109860008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       call      qword ptr [7FFA03205098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L01
       test      r8b,18
       jne       short M03_L03
       test      r8b,4
       je        short M03_L04
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M03_L08
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L08
M03_L03:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L04:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L06
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
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L02
M03_L08:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L08
       cmp       edx,esi
       jl        near ptr M04_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L09
       cmp       eax,400
       jge       short M04_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L04:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA032054A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L07:
       call      qword ptr [7FFA02AD7198]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA032054B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA032054D0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FFA02D7C9A8]
       int       3
; Total bytes of code 621
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,27109860008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA03207360]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA10]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M07_L01
       cmp       qword ptr [rdi+10],0
       je        short M07_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA031E340C
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA031E3414
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA031E3408
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA031E3404
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA031E3400
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA031E33FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA031E3418
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA031E341C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA03204198]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA031E33F8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02EFE358]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FFA031E3410
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EFEB08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D77960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA028A4000
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       call      qword ptr [7FFA032054B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B8DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA0320FC90]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA5440DA20]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M12_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L12
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L13
       mov       r8,20206800B00
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-40],r8
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L10
       lea       r8,[rdi+20]
       mov       rdx,[rbp-40]
       test      r8,r8
       je        near ptr M00_L14
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-40]
       jne       near ptr M00_L10
M00_L00:
       mov       rdi,[rbp-40]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L20
       add       r14d,2
       jo        near ptr M00_L20
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L18
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L19
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,201F0800100
       mov       r8,[r8]
       mov       rdx,24285793110
       call      qword ptr [7FFA02CC4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L06
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L06
       mov       r15,[rbp-50]
       mov       r13,[r15+8]
       mov       r12d,[r15+18]
       lea       ecx,[r12+rdi]
       cmp       ecx,[r13+8]
       jbe       short M00_L04
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ABF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L04:
       movsxd    r8,r12d
       lea       rcx,[r13+r8*2+10]
       cmp       edi,2
       jle       short M00_L07
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       add       edi,r12d
       mov       [r15+18],edi
M00_L06:
       mov       r15,[rbp-50]
       inc       r14d
       cmp       r14d,esi
       jl        near ptr M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B32100]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       short M00_L08
M00_L07:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       edi,2
       jne       short M00_L05
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M00_L05
M00_L08:
       call      M00_L21
       nop
       mov       rbx,[rbp-58]
M00_L09:
       mov       [rbp-48],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-48]
       mov       rdx,7FFA031EFD80
       cmp       [rcx],ecx
       call      qword ptr [7FFA031F4D50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-40]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02EDD758]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFA02ED6CD0]
       mov       ecx,3
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D47550
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302CDF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302CE10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rbx,24285780008
       jmp       near ptr M00_L09
M00_L14:
       call      qword ptr [7FFA03146CE8]
       int       3
M00_L15:
       cmp       qword ptr [r15+10],0
       jne       short M00_L16
       xor       edx,edx
       mov       [rbp-40],rdx
       jmp       short M00_L17
M00_L16:
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFA0314C210]
       test      eax,eax
       jne       near ptr M00_L11
M00_L17:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L18:
       mov       ecx,13CC2
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA03146C40]
       int       3
M00_L19:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA03146D30]
       jmp       near ptr M00_L02
M00_L20:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L21:
       sub       rsp,28
       mov       r15,[rbp-50]
       cmp       dword ptr [r15+20],0
       jge       short M00_L22
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA03146C88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       cmp       qword ptr [r15+10],0
       jne       short M00_L23
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L33
M00_L23:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L25
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L24
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D57960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L33
M00_L24:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA0314D800]
       jmp       near ptr M00_L33
M00_L25:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L27
M00_L26:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L26
M00_L27:
       cmp       rbx,r15
       je        near ptr M00_L32
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L30
       cmp       ecx,400
       jge       short M00_L28
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L29
M00_L28:
       xor       edx,edx
       call      qword ptr [7FFA02ED6DF0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L29:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L31
M00_L30:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L31:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L32:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L33:
       mov       rax,20206800B00
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L45
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L46
       cmp       dword ptr [r15+20],0
       jge       short M00_L34
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       call      qword ptr [7FFA03146C88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       cmp       qword ptr [r15+10],0
       jne       short M00_L35
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L47
M00_L35:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L37
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L36
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D57960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L47
M00_L36:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA0314D800]
       jmp       near ptr M00_L47
M00_L37:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L39
M00_L38:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L38
M00_L39:
       cmp       rsi,r15
       je        near ptr M00_L44
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L42
       cmp       ecx,400
       jge       short M00_L40
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L41
M00_L40:
       xor       edx,edx
       call      qword ptr [7FFA02ED6DF0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L41:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L43
M00_L42:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L43:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L44:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L47
M00_L45:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L47
M00_L46:
       add       rsp,28
       ret
M00_L47:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L49
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L48
       call      qword ptr [7FFA03146CE8]
       int       3
M00_L48:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L46
M00_L49:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L50
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02EDDED8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M00_L46
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFA0314C2E8]
       jmp       short M00_L46
M00_L50:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L46
; Total bytes of code 1757
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,95E76E1B5C2C
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L19
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L19
       cmp       edi,1
       je        near ptr M01_L11
       cmp       edi,2
       jne       near ptr M01_L12
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L13
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L21
       cmp       r14d,44
       je        near ptr M01_L22
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        near ptr M01_L24
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L09
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,95E76E1B5C2C
       cmp       [rbp+0A0],r8
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L12:
       cmp       edi,3
       jne       short M01_L13
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L13
       cmp       ecx,0A
       jae       short M01_L13
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L13:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       cmp       r15d,5F5E100
       jge       short M01_L16
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L15:
       cmp       eax,edi
       jae       short M01_L18
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L14
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFA031F6508]
       int       3
M01_L17:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L19
M01_L18:
       jmp       near ptr M01_L01
M01_L19:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L20
       test      r14d,r14d
       je        short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L20:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L21:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L22:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FC5A0]
       mov       r8,95E76E1B5C2C
       cmp       [rbp+0A0],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       xor       eax,eax
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA031FC5B8]
       mov       r8,95E76E1B5C2C
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02ED4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B65DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA031FC5D0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FC5E8]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA031FC5E8]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA031FD9B0]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA0314D590]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA0314D5A8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA031FC600]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AB76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,201F0800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C0FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,95E76E1B5C2C
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1189
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M02_L07
       cmp       eax,esi
       jl        near ptr M02_L07
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M02_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M02_L08
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M02_L09
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M02_L00:
       cmp       ebp,edx
       ja        near ptr M02_L05
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M02_L10
       cmp       edx,esi
       jl        near ptr M02_L10
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M02_L11
       cmp       eax,400
       jge       short M02_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L03
M02_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02ED6DF0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M02_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rax,ebp
       lea       rdx,[rdi+rax*2]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M02_L12
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M02_L04:
       cmp       esi,eax
       jbe       short M02_L06
M02_L05:
       call      qword ptr [7FFA02D5C9A8]
       int       3
M02_L06:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA031FD338]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L08:
       test      ecx,ecx
       jne       short M02_L09
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M02_L00
M02_L09:
       call      qword ptr [7FFA02AB7198]
       int       3
M02_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA03146C88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L11:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0314D4E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L12:
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M02_L04
; Total bytes of code 614
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
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       call      00007FFA625E4CB0
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
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24285780008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       call      qword ptr [7FFA03146D78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rsp+28],eax
M06_L00:
       mov       ebp,[rbx+60]
       mov       eax,ebp
       and       eax,[rbx+18]
       mov       r14d,[rdi+8]
       cmp       eax,r14d
       jae       near ptr M06_L05
       mov       r15d,eax
       shl       r15,4
       lea       r13,[rdi+r15+10]
       mov       ecx,[r13+8]
       lea       edx,[rbp+1]
       sub       ecx,edx
       jne       short M06_L02
       lea       rcx,[rbx+60]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M06_L00
       mov       rdx,[rdi+r15+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M06_L01
       xor       eax,eax
       mov       [rdi+r15+10],rax
       add       ebp,r14d
       mov       [r13+8],ebp
M06_L01:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L02:
       test      ecx,ecx
       jge       short M06_L00
       movzx     ecx,byte ptr [rbx+1D]
       mov       edx,[rbx+0A0]
       mov       eax,edx
       sub       eax,ebp
       test      eax,eax
       jle       short M06_L04
       test      ecx,ecx
       je        short M06_L03
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,ebp
       test      edx,edx
       jle       short M06_L04
M06_L03:
       lea       rcx,[rsp+28]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA0314C2D0]
       jmp       near ptr M06_L00
M06_L04:
       xor       eax,eax
       mov       [rsi],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,24285780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       call      qword ptr [7FFA031477F8]
       int       3
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L04
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L09
M08_L00:
       test      dl,4
       jne       near ptr M08_L11
M08_L01:
       test      dl,2
       je        short M08_L02
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L06
M08_L05:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L05
M08_L06:
       test      al,20
       jne       short M08_L08
M08_L07:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L08:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L07
M08_L09:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L10:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L10
       jmp       near ptr M08_L00
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 229
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFA03217D54
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFA03217D5C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFA03217D50
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFA03217D4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFA03217D48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFA03217D44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFA03217D60
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFA03217D64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFA03147108]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFA03217D40
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02F7D4A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FFA03217D58
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02ED6DF0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D57960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA03146C88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA0314D800]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
M12_L00:
       mov       ebp,[rbx+0A0]
       mov       eax,ebp
       and       eax,[rbx+18]
       cmp       eax,[rdi+8]
       jae       near ptr M12_L04
       shl       rax,4
       lea       r14,[rdi+rax+10]
       mov       edx,[r14+8]
       sub       edx,ebp
       jne       short M12_L02
       lea       rcx,[rbx+0A0]
       lea       edx,[rbp+1]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M12_L01
       mov       rcx,7FFA03194778
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,r14
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r14+8],ebp
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L01:
       mov       rcx,7FFA0319477C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L00
M12_L02:
       test      edx,edx
       jl        short M12_L03
       mov       rcx,7FFA03194784
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FFA03194780
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlySpanExtensionsBenchmark.BytesToString()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       test      r8,r8
       je        near ptr M00_L13
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L14
       mov       r8,2E5E1000D70
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L11
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L15
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L11
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L21
       add       r14d,2
       jo        near ptr M00_L21
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L19
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L20
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,2E5CB000100
       mov       r8,[r8]
       mov       rdx,326601B2D40
       call      qword ptr [7FFA02CD4CD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        short M00_L05
       mov       r15,[rbp-48]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L08
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M00_L07
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       je        short M00_L06
M00_L04:
       add       edi,r13d
       mov       [r15+18],edi
M00_L05:
       mov       r15,[rbp-48]
       inc       r14d
       cmp       r14d,esi
       jl        short M00_L03
       mov       rcx,r15
       call      qword ptr [7FFA02B42100]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L09
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L04
M00_L07:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L08:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFA02ACF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L09:
       call      M00_L22
       nop
       mov       rbx,[rbp-50]
M00_L10:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFA03375690
       cmp       [rcx],ecx
       call      qword ptr [7FFA032BF978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-38]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FB5368]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L16
M00_L12:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L13:
       call      qword ptr [7FFA02EEEA00]
       mov       ecx,3
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D57550
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030666D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030666E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rbx,326601A0008
       jmp       near ptr M00_L10
M00_L15:
       call      qword ptr [7FFA03067228]
       int       3
M00_L16:
       cmp       qword ptr [r15+10],0
       jne       short M00_L17
       xor       edx,edx
       mov       [rbp-38],rdx
       jmp       short M00_L18
M00_L17:
       lea       rdx,[rbp-38]
       mov       rcx,r14
       call      qword ptr [7FFA032B6A48]
       test      eax,eax
       jne       near ptr M00_L12
M00_L18:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L19:
       mov       ecx,13CC2
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA03066CD0]
       int       3
M00_L20:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFA032B6208]
       jmp       near ptr M00_L02
M00_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L22:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L23
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA030676F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       cmp       qword ptr [r15+10],0
       jne       short M00_L24
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L34
M00_L24:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L26
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L25
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L34
M00_L25:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFA032B7A80]
       jmp       near ptr M00_L34
M00_L26:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L28
M00_L27:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L27
M00_L28:
       cmp       rbx,r15
       je        near ptr M00_L33
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L31
       cmp       ecx,400
       jge       short M00_L29
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L30
M00_L29:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L30:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L32
M00_L31:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L32:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L33:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L34:
       mov       rax,2E5E1000D70
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L46
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L47
       cmp       dword ptr [r15+20],0
       jge       short M00_L35
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       call      qword ptr [7FFA030676F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       cmp       qword ptr [r15+10],0
       jne       short M00_L36
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L48
M00_L36:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L38
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L37
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L48
M00_L37:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA032B7A80]
       jmp       near ptr M00_L48
M00_L38:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L40
M00_L39:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L39
M00_L40:
       cmp       rsi,r15
       je        near ptr M00_L45
       mov       rdx,[r15+8]
       mov       ecx,[rdx+8]
       add       ecx,[r15+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L43
       cmp       ecx,400
       jge       short M00_L41
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L42
M00_L41:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L42:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L44
M00_L43:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L44:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L45:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L48
M00_L46:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M00_L48
M00_L47:
       add       rsp,28
       ret
M00_L48:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L50
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L49
       call      qword ptr [7FFA03067228]
       int       3
M00_L49:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       je        short M00_L47
M00_L50:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L51
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FB6028]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M00_L47
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFA032B6BE0]
       jmp       short M00_L47
M00_L51:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L47
; Total bytes of code 1742
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       mov       rax,0FAF2F84CCBC3
       mov       [rbp+0A0],rax
       mov       ebx,ecx
       test      rdx,rdx
       jne       near ptr M01_L08
       xor       esi,esi
       xor       edi,edi
M01_L00:
       xor       r14d,r14d
       test      edi,edi
       jle       near ptr M01_L20
       movzx     r14d,word ptr [rsi]
       mov       eax,r14d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L20
       cmp       edi,1
       je        near ptr M01_L12
       cmp       edi,2
       jne       near ptr M01_L13
       movzx     r15d,word ptr [rsi+2]
       add       r15d,0FFFFFFD0
       cmp       r15d,0A
       jae       near ptr M01_L14
M01_L01:
       mov       r13d,r14d
       and       r14d,0FFDF
       cmp       r14d,47
       je        near ptr M01_L22
       cmp       r14d,44
       je        near ptr M01_L23
M01_L02:
       cmp       r14d,58
       jne       near ptr M01_L25
       mov       edx,1
       test      r15d,r15d
       cmovle    r15d,edx
       mov       edx,ebx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       sar       edx,2
       inc       edx
       cmp       r15d,edx
       mov       r14d,edx
       cmovge    r14d,r15d
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       test      rax,rax
       je        short M01_L09
       lea       rcx,[rax+0C]
       mov       [rbp+38],rcx
       mov       rcx,[rbp+38]
M01_L03:
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,r15d
       jmp       short M01_L06
M01_L04:
       lea       r10d,[r13-21]
       movzx     r10d,r10w
M01_L05:
       add       r8d,r10d
       mov       [rcx],r8w
       shr       ebx,4
M01_L06:
       dec       edx
       js        short M01_L10
M01_L07:
       mov       r8d,ebx
       and       r8d,0F
       add       rcx,0FFFFFFFFFFFFFFFE
       cmp       r8d,0A
       jge       short M01_L04
       mov       r10d,30
       jmp       short M01_L05
M01_L08:
       lea       rsi,[rdx+0C]
       mov       edi,[rdx+8]
       jmp       near ptr M01_L00
M01_L09:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M01_L03
M01_L10:
       test      ebx,ebx
       jne       short M01_L07
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       r8,0FAF2F84CCBC3
       cmp       [rbp+0A0],r8
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L01
M01_L13:
       cmp       edi,3
       jne       short M01_L14
       movzx     eax,word ptr [rsi+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [rsi+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L14
       cmp       ecx,0A
       jae       short M01_L14
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L01
M01_L14:
       xor       r15d,r15d
       mov       eax,1
       jmp       short M01_L16
M01_L15:
       cmp       r15d,5F5E100
       jge       short M01_L17
       lea       ecx,[rax+1]
       mov       eax,eax
       movzx     eax,word ptr [rsi+rax*2]
       lea       edx,[r15+r15*4]
       lea       r15d,[rax+rdx*2-30]
       mov       eax,ecx
M01_L16:
       cmp       eax,edi
       jae       short M01_L19
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2]
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       jbe       short M01_L15
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFA03066C58]
       int       3
M01_L18:
       mov       edx,eax
       cmp       word ptr [rsi+rdx*2],0
       jne       short M01_L20
M01_L19:
       jmp       near ptr M01_L01
M01_L20:
       mov       r15d,0FFFFFFFF
       test      edi,edi
       je        short M01_L21
       test      r14d,r14d
       je        short M01_L21
       xor       r14d,r14d
       jmp       near ptr M01_L01
M01_L21:
       mov       r14d,47
       jmp       near ptr M01_L01
M01_L22:
       test      r15d,r15d
       jg        near ptr M01_L02
M01_L23:
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA03395650]
       mov       r8,0FAF2F84CCBC3
       cmp       [rbp+0A0],r8
       je        short M01_L24
       call      CORINFO_HELP_FAIL_FAST
M01_L24:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       cmp       r14d,42
       jne       short M01_L27
       mov       ecx,ebx
       mov       edx,r15d
       call      qword ptr [7FFA03395668]
       mov       r8,0FAF2F84CCBC3
       cmp       [rbp+0A0],r8
       je        short M01_L26
       call      CORINFO_HELP_FAIL_FAST
M01_L26:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       test      r8,r8
       je        short M01_L28
       mov       rcx,r8
       call      qword ptr [7FFA02EE4F90]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFA02B75DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FFA03395680]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA03395698]
       lea       rcx,[rax+0A]
       mov       edx,ebx
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L31
M01_L30:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFA53780328
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L30
M01_L31:
       test      edx,edx
       je        short M01_L33
M01_L32:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L31
M01_L33:
       test      r8d,r8d
       jg        short M01_L32
       mov       rbx,rcx
       add       eax,0A
       mov       r12d,eax
       sub       r12d,ecx
       mov       [rbp+70],r12d
       mov       [rbp+74],r12d
       lea       rcx,[rbp+70]
       call      qword ptr [7FFA03395698]
       jmp       short M01_L35
M01_L34:
       lea       rdx,[rax+1]
       lea       rcx,[rbx+1]
       movzx     r8d,byte ptr [rbx]
       mov       [rax],r8b
       mov       rax,rdx
       mov       rbx,rcx
M01_L35:
       dec       r12d
       jns       short M01_L34
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],20
       lea       rdx,[rbp+18]
       lea       rcx,[rbp+50]
       call      qword ptr [7FFA03396820]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFA032B6178]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FFA032B6190]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFA033956B0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FFA02AC76D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2E5CB000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA02C1FB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0FAF2F84CCBC3
       cmp       [rbp+0A0],r8
       je        short M01_L39
       call      CORINFO_HELP_FAIL_FAST
M01_L39:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1182
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,326601A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       call      qword ptr [7FFA03067240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L02
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
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
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L07
       cmp       eax,esi
       jl        near ptr M04_L07
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L08
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L09
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L05
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L10
       cmp       edx,esi
       jl        near ptr M04_L10
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L11
       cmp       eax,400
       jl        short M04_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFA02EEEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M04_L03
M04_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M04_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rax,ebp
       lea       rdx,[rdi+rax*2]
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L12
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M04_L04:
       cmp       esi,eax
       jbe       short M04_L06
M04_L05:
       call      qword ptr [7FFA02D6C9A8]
       int       3
M04_L06:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA030676D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L08:
       test      ecx,ecx
       jne       short M04_L09
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFA02AC7198]
       int       3
M04_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA030676F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA03067708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L12:
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M04_L04
; Total bytes of code 614
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
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rsp+28],eax
M06_L00:
       mov       ebp,[rbx+60]
       mov       eax,ebp
       and       eax,[rbx+18]
       mov       r14d,[rdi+8]
       cmp       eax,r14d
       jae       near ptr M06_L05
       mov       r15d,eax
       shl       r15,4
       lea       r13,[rdi+r15+10]
       mov       ecx,[r13+8]
       lea       edx,[rbp+1]
       sub       ecx,edx
       jne       short M06_L02
       lea       rcx,[rbx+60]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M06_L00
       mov       rdx,[rdi+r15+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M06_L01
       xor       eax,eax
       mov       [rdi+r15+10],rax
       add       ebp,r14d
       mov       [r13+8],ebp
M06_L01:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L02:
       test      ecx,ecx
       jge       short M06_L00
       movzx     ecx,byte ptr [rbx+1D]
       mov       edx,[rbx+0A0]
       mov       eax,edx
       sub       eax,ebp
       test      eax,eax
       jle       short M06_L04
       test      ecx,ecx
       je        short M06_L03
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,ebp
       test      edx,edx
       jle       short M06_L04
M06_L03:
       lea       rcx,[rsp+28]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA032B6AD8]
       jmp       near ptr M06_L00
M06_L04:
       xor       eax,eax
       mov       [rsi],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
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
       je        near ptr M07_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L00
       test      rbx,rbx
       je        near ptr M07_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M07_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L00:
       test      rbx,rbx
       je        short M07_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L02
M07_L01:
       mov       rax,326601A0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       call      qword ptr [7FFA0317F2E8]
       int       3
; Total bytes of code 235
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M08_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M08_L10
M08_L00:
       test      dl,4
       jne       near ptr M08_L12
M08_L01:
       test      dl,2
       jne       short M08_L04
M08_L02:
       test      dl,1
       je        short M08_L03
       mov       [rcx+rax*2],r8w
M08_L03:
       vzeroupper
       ret
M08_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M08_L02
M08_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M08_L07
M08_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M08_L06
M08_L07:
       test      al,20
       jne       short M08_L09
M08_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M08_L03
M08_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M08_L08
M08_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M08_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M08_L11
       jmp       near ptr M08_L00
M08_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M08_L01
; Total bytes of code 231
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
       call      qword ptr [7FFA543E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFA543E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M10_L06
       test      rbx,rbx
       je        near ptr M10_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M10_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M10_L07
       cmp       edi,[rsi+8]
       ja        short M10_L07
       cmp       edi,[rbx+8]
       ja        short M10_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M10_L05
       cmp       r8,4000
       ja        short M10_L04
       mov       rcx,rbx
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M10_L02
M10_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M10_L03
M10_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L00
M10_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L01
M10_L04:
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA02EEE358]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M10_L00
M10_L06:
       xor       ebp,ebp
       jmp       short M10_L08
M10_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA0306C750]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M10_L08:
       test      rbx,rbx
       jne       short M10_L09
       xor       r9d,r9d
       jmp       short M10_L10
M10_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0306C750]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M10_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FFA03066058]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M10_L00
; Total bytes of code 246
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M11_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M11_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M11_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M11_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M11_L01
M11_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M11_L00
M11_L01:
       cmp       rdi,rbx
       je        near ptr M11_L06
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L02
       cmp       ecx,400
       jge       short M11_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L04
M11_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L05
M11_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EEEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M11_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M11_L09
M11_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M11_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D67960]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M11_L09
M11_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M11_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02894000
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       call      qword ptr [7FFA030676F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B7DA58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA032B7A80]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       r8,[rcx+8]
M12_L00:
       mov       eax,[rcx+0A0]
       mov       [rsp+24],eax
       mov       r10d,eax
       and       r10d,[rcx+18]
       cmp       r10d,[r8+8]
       jae       short M12_L02
       shl       r10,4
       lea       rbx,[r8+r10+10]
       mov       r10d,[rbx+8]
       sub       r10d,eax
       jne       short M12_L01
       lea       r10,[rcx+0A0]
       lea       esi,[rax+1]
       lock cmpxchg [r10],esi
       cmp       eax,[rsp+24]
       jne       short M12_L00
       mov       rcx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+8],esi
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L01:
       test      r10d,r10d
       jge       short M12_L00
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 115
```

