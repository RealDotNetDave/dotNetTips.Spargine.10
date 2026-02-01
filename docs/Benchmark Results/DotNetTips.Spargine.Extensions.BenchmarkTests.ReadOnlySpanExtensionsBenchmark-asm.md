## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC600CB0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5C6B20]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC72C828]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC72C840]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC5CDB78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC72C828]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2E3123FFD88
       call      qword ptr [7FF7DC72C840]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC84EC40]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E3123F0008
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
       call      qword ptr [7FF7DC84F2E8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC63F230
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5CE700]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B43A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC695500]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7B43A8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,294CA35FD88
       call      qword ptr [7FF7DC7B43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DE1C0]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,294CA350008
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
       call      qword ptr [7FF7DC8D6CD0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE700]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675758]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC794378]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E48890FD88
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE1D8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E488900008
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
       call      qword ptr [7FF7DC8B6C10]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC5E0CB0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5A6B20]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70C858]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC5ADB78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC70C840]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,219EFC9FD88
       call      qword ptr [7FF7DC70C858]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC82EC58]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,219EFC90008
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
       call      qword ptr [7FF7DC82F2A0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794360]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675A70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC794360]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21B899FFF88
       call      qword ptr [7FF7DC794378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE190]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21B899F0008
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
       call      qword ptr [7FF7DC8B6D18]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC63F230
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5CE700]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B4378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B4390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC695758]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7B4378]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2BD67DCFD88
       call      qword ptr [7FF7DC7B4390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DE1A8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2BD67DC0008
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
       call      qword ptr [7FF7DC8D6D60]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC8144B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC8144C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675C08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC8144B0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B65C6FFF88
       call      qword ptr [7FF7DC8144C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DDE18]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B65C6F0008
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
       call      qword ptr [7FF7DC81E490]
       int       3
; Total bytes of code 231
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE700]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7265B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7265C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675A28]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7265B0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2AA878EFF88
       call      qword ptr [7FF7DC7265C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC975A28]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AA878E0008
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
       call      qword ptr [7FF7DC82ED00]
       int       3
; Total bytes of code 235
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7943C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7943D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6757A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7943C0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27A974FFD88
       call      qword ptr [7FF7DC7943D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE1A8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A974F0008
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
       call      qword ptr [7FF7DC8B6CB8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62E560
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5CE220]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FE70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FE88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC685278]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC73FE70]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B3B73EFD88
       call      qword ptr [7FF7DC73FE88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DE178]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B3B73E0008
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
       call      qword ptr [7FF7DC8D6CA0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC641AE0
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5BE748]
       mov       ecx,3
       mov       rdx,7FF7DC4255C8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC304A98
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4255C8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A43A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC685698]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7A43A8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2253AE2FD88
       call      qword ptr [7FF7DC7A43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8CE1D8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2253AE20008
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
       call      qword ptr [7FF7DC8C6CE8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5BE748]
       mov       ecx,3
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A43C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A43D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6857A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7A43C0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E4F8C4FD88
       call      qword ptr [7FF7DC7A43D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8CE1D8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E4F8C40008
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
       call      qword ptr [7FF7DC8C6CE8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC63F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5CE748]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B4360]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B4378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC695A70]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7B4360]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,283A18EFF88
       call      qword ptr [7FF7DC7B4378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DE190]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,283A18E0008
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
       call      qword ptr [7FF7DC8D6D18]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC8144E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC8144F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675698]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC8144E0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22665B0FD88
       call      qword ptr [7FF7DC8144F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE1C0]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22665B00008
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
       call      qword ptr [7FF7DC8B6D78]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC60E560
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5AE250]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC71FFC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC71FFD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6652A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC71FFC0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28BFC68FD88
       call      qword ptr [7FF7DC71FFD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8DDE00]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28BFC680008
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
       call      qword ptr [7FF7DC80E478]
       int       3
; Total bytes of code 231
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62F240
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC5BE748]
       mov       ecx,3
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC834360]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC834378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6857A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC834360]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22A9C7DFD88
       call      qword ptr [7FF7DC834378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC985A70]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22A9C7D0008
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
       call      qword ptr [7FF7DC83ED60]
       int       3
; Total bytes of code 235
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62F240
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC7AD050]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5BE748]
       mov       ecx,3
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3038B0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A43F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A4408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6857A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7A43F0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F9406CFD88
       call      qword ptr [7FF7DC7A4408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8CE160]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F9406C0008
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
       call      qword ptr [7FF7DC8C6C70]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61E588
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC79CAF8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5BE268]
       mov       ecx,3
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC72FED0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC72FEE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675590]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC72FED0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,205887FFF88
       call      qword ptr [7FF7DC72FEE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8CE0E8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,205887F0008
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
       call      qword ptr [7FF7DC8C6BF8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62F230
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC7ACF90]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5BE700]
       mov       ecx,3
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC303D40
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC424028
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A4318]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A4330]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC685A28]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC7A4318]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,287DA21FF88
       call      qword ptr [7FF7DC7A4330]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8CE100]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,287DA210008
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
       call      qword ptr [7FF7DC8C6BF8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC60E560
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC78CA50]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5AE220]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC71FE88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC71FEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC665020]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC71FE88]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23CCAB4FD88
       call      qword ptr [7FF7DC71FEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE148]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23CCAB40008
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
       call      qword ptr [7FF7DC8B6C58]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC61F240
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC79D020]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5AE718]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC675518]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC794378]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27F2A91FD88
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8BE160]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27F2A910008
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
       call      qword ptr [7FF7DC8B6D00]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC5FE560
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC7FCAF8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC59E250]
       mov       ecx,3
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E40A0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70FF78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70FF90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC655578]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC70FF78]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,159E631FF88
       call      qword ptr [7FF7DC70FF90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8AE0E8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,159E6310008
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
       call      qword ptr [7FF7DC8A6C88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC62E588
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8E4B10]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5CE280]
       mov       ecx,3
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC434028
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC825068]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC825080]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC6851D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC825068]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C29B1AFD88
       call      qword ptr [7FF7DC825080]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC8EDEC0]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C29B1A0008
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
       call      qword ptr [7FF7DC8E7318]
       int       3
; Total bytes of code 231
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF7DC60F4F8
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF87E143670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L02
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC97F3A8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7DC5AE0D0]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC71C4C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC71C4E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7DC665128]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7DC71C4C8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23AE9B3FD88
       call      qword ptr [7FF7DC71C4E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7DC975A28]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23AE9B30008
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
       call      qword ptr [7FF7DC83EE38]
       int       3
; Total bytes of code 235
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,179E2800AC8
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
       call      00007FF83BB54230
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
       mov       r8,179CC800180
       mov       r8,[r8]
       mov       rdx,1BA615D3110
       call      qword ptr [7FF7DC384A98]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2B5688]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2A7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC84C498
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CAE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC59E238]
       mov       ecx,3
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D40
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70FEA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70FEB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,1BA615C0008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8A49D8]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6549C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8A4510]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8AE268]
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8AF060]
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,179E2800AC8
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4E88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF060]
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8A49D8]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC654AB0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,0E1C62636BDFB
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
       call      00007FF83BB9AFE0
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
       mov       r8,0E1C62636BDFB
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
       call      qword ptr [7FF7DC8AE088]
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
       call      qword ptr [7FF7DC8AE190]
       mov       r8,0E1C62636BDFB
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
       call      qword ptr [7FF7DC8AE1A8]
       mov       r8,0E1C62636BDFB
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
       call      qword ptr [7FF7DC594DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF4D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8AE1C0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8AE1D8]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8AE1D8]
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
       call      qword ptr [7FF7DC8AEE38]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8AE0E8]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC776DA8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8AE1F0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1EF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,179CC800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2DF030]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0E1C62636BDFB
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BA615C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4A68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC516490]
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
       jmp       qword ptr [7FF7DBF466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC1EF1B0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8A4EA0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC41C768]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BA615C0008
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
       call      qword ptr [7FF7DC8A6CA0]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC890144
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC89014C
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
       mov       rcx,7FF7DC890140
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC89013C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC890138
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC890134
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC890150
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC890154
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC77FC18]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC890130
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC59E0B8]
M10_L15:
       mov       rcx,7FF7DC890148
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF060]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,20ED6400AC8
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
       call      00007FF83BB54230
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
       mov       r8,20EC0400180
       mov       r8,[r8]
       mov       rdx,24F55733110
       call      qword ptr [7FF7DC384A98]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2B5688]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2A7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC84C498
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC77CB10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC59E238]
       mov       ecx,3
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D40
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70FE88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70FEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,24F55720008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8A4A80]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC654C30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8A4540]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8AE280]
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8AF078]
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,20ED6400AC8
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4EB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF078]
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8A4A80]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC654D20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,6B169914EB4B
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
       call      00007FF83BB9AFE0
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
       mov       r8,6B169914EB4B
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
       call      qword ptr [7FF7DC8ADD58]
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
       call      qword ptr [7FF7DC8AE178]
       mov       r8,6B169914EB4B
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
       call      qword ptr [7FF7DC8AE190]
       mov       r8,6B169914EB4B
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
       call      qword ptr [7FF7DC594DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF4D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8AE1A8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8AE1C0]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8AE1C0]
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
       call      qword ptr [7FF7DC8AEE50]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8AE0D0]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC776DD8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8AE1D8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1EF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,20EC0400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2DF030]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,6B169914EB4B
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24F55720008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4A98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC516490]
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
       jmp       qword ptr [7FF7DBF466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4EA0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
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
       call      qword ptr [7FF7DC1EF1B0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8A4ED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC41C768]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24F55720008
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
       call      qword ptr [7FF7DC8A6CB8]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC890854
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC89085C
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
       mov       rcx,7FF7DC890850
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC89084C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC890848
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC890844
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC890860
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC890864
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC77FD98]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC890840
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC59E0B8]
M10_L15:
       mov       rcx,7FF7DC890858
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC417720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC516490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF078]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,20260C00AC8
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
       call      00007FF83BB54230
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
       mov       r8,2024AC00180
       mov       r8,[r8]
       mov       rdx,242DF9E3110
       call      qword ptr [7FF7DC394A98]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2C5688]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2B7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC86DA30
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC5AE700]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,242DF9D0008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8B4A98]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC674FD8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8B4558]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8BE2B0]
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4ED0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC526490]
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
       call      qword ptr [7FF7DC427720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8BF0A8]
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
       call      qword ptr [7FF7DC5AE820]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,20260C00AC8
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4ED0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC526490]
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
       call      qword ptr [7FF7DC427720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF0A8]
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
       call      qword ptr [7FF7DC5AE820]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8B4A98]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC6750C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,5AFA0D6619A
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
       call      00007FF83BB9AFE0
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
       mov       r8,5AFA0D6619A
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
       call      qword ptr [7FF7DC8BD860]
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
       call      qword ptr [7FF7DC8BE1A8]
       mov       r8,5AFA0D6619A
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
       call      qword ptr [7FF7DC8BE1C0]
       mov       r8,5AFA0D6619A
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
       call      qword ptr [7FF7DC5A4DF8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF5D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8BE1D8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8BE1F0]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8BE1F0]
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
       call      qword ptr [7FF7DC8BEE80]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8BE100]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC7972A0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8BE208]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1FF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2024AC00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2EF030]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,5AFA0D6619A
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,242DF9D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC526490]
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
       jmp       qword ptr [7FF7DBF566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE820]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC526490]
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
       call      qword ptr [7FF7DC1FF1B0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4ED0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC526490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8B4EE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC42C768]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,242DF9D0008
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
       call      qword ptr [7FF7DC8B6CE8]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC890E64
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC890E6C
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
       mov       rcx,7FF7DC890E60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC890E5C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC890E58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC890E54
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC890E70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC890E74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC79FC48]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC890E50
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC5AE0B8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FF7DC890E68
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE820]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC427720]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4ED0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC526490]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF0A8]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1A2CA400AC8
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
       call      00007FF83BB54230
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
       mov       r8,1A2B4400180
       mov       r8,[r8]
       mov       rdx,1E349443110
       call      qword ptr [7FF7DC394AF8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2CB5D0]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2B7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC86D5A8
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC79CEE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7943A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,1E349430008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8B4A68]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC675140]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8B4528]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8BE250]
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8BF600]
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
       call      qword ptr [7FF7DC5AE868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,1A2CA400AC8
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4E88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF600]
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
       call      qword ptr [7FF7DC5AE868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8B4A68]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC675230]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,5506D43D95A0
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
       call      00007FF83BB9AFE0
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
       mov       r8,5506D43D95A0
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
       call      qword ptr [7FF7DC8BD7E8]
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
       call      qword ptr [7FF7DC8BE190]
       mov       r8,5506D43D95A0
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
       call      qword ptr [7FF7DC8BE1A8]
       mov       r8,5506D43D95A0
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
       call      qword ptr [7FF7DC5A4E28]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF5D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8BE1C0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8BE1D8]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8BE1D8]
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
       call      qword ptr [7FF7DC8BF3F0]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8BE0E8]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC7971C8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8BE1F0]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1FFFD8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1A2B4400398
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC280D48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,5506D43D95A0
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E349430008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4A80]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC5264C0]
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
       jmp       qword ptr [7FF7DBF566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC1FF2A0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8B4EA0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC42C798]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E349430008
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
       call      qword ptr [7FF7DC8B6C88]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC89149C
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC8914A4
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
       mov       rcx,7FF7DC891498
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC891494
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC891490
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC89148C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC8914A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC8914AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC79FC18]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC891488
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC5AE0E8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FF7DC8914A0
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E88]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF600]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,1BD30400AC8
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
       call      00007FF83BB54230
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
       mov       r8,1BD1A400180
       mov       r8,[r8]
       mov       rdx,1FDAF5D3110
       call      qword ptr [7FF7DC394AF8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2C5688]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2B7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC85BB18
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC78C9F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC5AE250]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F38B0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC71FE40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC71FE58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,1FDAF5C0008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8B4A50]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC664C48]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8B4510]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8BE238]
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8BF540]
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,1BD30400AC8
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF540]
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8B4A50]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC664D38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,0ABB64DD11633
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
       call      00007FF83BB9AFE0
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
       mov       r8,0ABB64DD11633
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
       call      qword ptr [7FF7DC8B61C0]
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
       call      qword ptr [7FF7DC8BE1C0]
       mov       r8,0ABB64DD11633
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
       call      qword ptr [7FF7DC8BE1D8]
       mov       r8,0ABB64DD11633
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
       call      qword ptr [7FF7DC5A4E28]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF5D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8BE1F0]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8BE208]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8BE208]
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
       call      qword ptr [7FF7DC8BF5E8]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8BE118]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC786CD0]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8BE220]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1FF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1BD1A400B38
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2E3B80]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0ABB64DD11633
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FDAF5C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8B4A68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC5264C0]
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
       jmp       qword ptr [7FF7DBF566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC1FF1B0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8B4E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC42C798]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FDAF5C0008
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
       call      qword ptr [7FF7DC8B6D00]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC8A1CA4
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC8A1CAC
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
       mov       rcx,7FF7DC8A1CA0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC8A1C9C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC8A1C98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC8A1C94
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC8A1CB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC8A1CB4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC78FC30]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC8A1C90
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC5AE130]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FF7DC8A1CA8
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8B4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8BF540]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,19651000AC8
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
       call      00007FF83BB54230
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
       mov       r8,1963B000180
       mov       r8,[r8]
       mov       rdx,1D6D0143110
       call      qword ptr [7FF7DC384AF8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2BB5D0]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L08
M00_L06:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L07:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2A7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF7DC84C498
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7FCAE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC59E250]
       mov       ecx,3
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E40A0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC70FF90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC70FFA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rbx,1D6D0130008
       jmp       near ptr M00_L09
M00_L12:
       call      qword ptr [7FF7DC8A4A50]
       int       3
M00_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC654C48]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC8A4510]
       int       3
M00_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8AE238]
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
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
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L30
M00_L21:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC8AF5E8]
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
       call      qword ptr [7FF7DC59E370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L26:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,19651000AC8
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC5164C0]
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
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L43
M00_L33:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF5E8]
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
       call      qword ptr [7FF7DC59E370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC8A4A50]
       int       3
M00_L44:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC654D38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,29C7D598BC80
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
       call      00007FF83BB9AFE0
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
       mov       r8,29C7D598BC80
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
       call      qword ptr [7FF7DC8A61C0]
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
       call      qword ptr [7FF7DC8AE178]
       mov       r8,29C7D598BC80
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
       call      qword ptr [7FF7DC8AE190]
       mov       r8,29C7D598BC80
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
       call      qword ptr [7FF7DC594E28]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF4D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DC8AE1A8]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DC8AE1C0]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DC8AE1C0]
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
       call      qword ptr [7FF7DC8AF3D8]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8AE0D0]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC7F6DA8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DC8AE1D8]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1EF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,1963B0003A0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC299698]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,29C7D598BC80
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D6D0130008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC8A4A68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC5164C0]
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
       jmp       qword ptr [7FF7DBF466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
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
       call      qword ptr [7FF7DC1EF1B0]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC8A4E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L04
M04_L11:
       call      qword ptr [7FF7DC41C798]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D6D0130008
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
       call      qword ptr [7FF7DC8A6D00]
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
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FF7DC892214
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FF7DC89221C
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
       mov       rcx,7FF7DC892210
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FF7DC89220C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FF7DC892208
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FF7DC892204
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FF7DC892220
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FF7DC892224
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF7DC7FFCF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rcx,7FF7DC892200
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC70C660]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L15:
       mov       rcx,7FF7DC892218
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC8A4E70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC8AF5E8]
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
       call      qword ptr [7FF8375BCAE0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L11
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
       test      esi,esi
       je        near ptr M00_L12
       mov       r8,14F48800B48
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L14
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L13
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF83BB54230
       cmp       rax,[rbp-38]
       jne       near ptr M00_L14
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       imul      r14d,esi,2
       jo        near ptr M00_L18
       add       r14d,2
       jo        near ptr M00_L18
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L17
M00_L02:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       xor       r14d,r14d
M00_L03:
       movzx     ecx,byte ptr [rbx+r14]
       mov       r8,14F32800180
       mov       r8,[r8]
       mov       rdx,18FC7963110
       call      qword ptr [7FF7DC384AF8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2B5728]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       short M00_L09
M00_L06:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L04
M00_L07:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L04
M00_L08:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FF7DC2A71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L09:
       call      M00_L19
       nop
       mov       rbx,[rbp-50]
M00_L10:
       mov       [rbp-40],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FF7DC8F0F70
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC8C6760]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC59E748]
       mov       ecx,3
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E40A0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC404028
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC8044F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC804510]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       rbx,18FC7950008
       jmp       near ptr M00_L10
M00_L13:
       call      qword ptr [7FF7DC80C090]
       int       3
M00_L14:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC665140]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L15
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L15:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L16:
       mov       ecx,13CC2
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC807B40]
       int       3
M00_L17:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC8CDF98]
       jmp       near ptr M00_L02
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       sub       rsp,28
       mov       r15,[rbp-48]
       cmp       dword ptr [r15+20],0
       jge       short M00_L20
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC80C600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       cmp       qword ptr [r15+10],0
       jne       short M00_L21
       xor       eax,eax
       mov       [r15+18],rax
       jmp       near ptr M00_L31
M00_L21:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       ebx,eax
       neg       ebx
       test      ebx,ebx
       jle       short M00_L23
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,ebx
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L22
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L31
M00_L22:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DCA15488]
       jmp       near ptr M00_L31
M00_L23:
       mov       rbx,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L25
M00_L24:
       mov       rbx,[rbx+10]
       cmp       dword ptr [rbx+1C],0
       jg        short M00_L24
M00_L25:
       cmp       rbx,r15
       je        near ptr M00_L30
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
       jge       short M00_L28
       cmp       ecx,400
       jge       short M00_L26
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L27
M00_L26:
       xor       edx,edx
       call      qword ptr [7FF7DC59E868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L27:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L29
M00_L28:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L29:
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbx+1C]
       mov       [r15+1C],edx
M00_L30:
       mov       edx,[rbx+1C]
       neg       edx
       mov       [r15+18],edx
M00_L31:
       mov       rax,14F48800B48
       mov       rbx,[rax]
       mov       rsi,[rbx+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rax
       jne       near ptr M00_L43
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       add       eax,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L48
       cmp       dword ptr [r15+20],0
       jge       short M00_L32
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC80C600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       cmp       qword ptr [r15+10],0
       jne       short M00_L33
       xor       ecx,ecx
       mov       [r15+18],rcx
       jmp       near ptr M00_L44
M00_L33:
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L35
       mov       rdx,[r15+8]
       mov       ecx,[r15+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L34
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L44
M00_L34:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DCA15488]
       jmp       near ptr M00_L44
M00_L35:
       mov       rsi,r15
       cmp       dword ptr [r15+1C],0
       jle       short M00_L37
M00_L36:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L36
M00_L37:
       cmp       rsi,r15
       je        near ptr M00_L42
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
       jge       short M00_L40
       cmp       ecx,400
       jge       short M00_L38
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L39
M00_L38:
       xor       edx,edx
       call      qword ptr [7FF7DC59E868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L39:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L41
M00_L40:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L41:
       mov       rdx,[rsi+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [r15+1C],edx
M00_L42:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [r15+18],edx
       jmp       short M00_L44
M00_L43:
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M00_L48
M00_L44:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L46
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L45
       call      qword ptr [7FF7DC80C090]
       int       3
M00_L45:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
       test      rax,rax
       je        short M00_L48
M00_L46:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L47
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC665230]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L48
M00_L47:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1673
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
       mov       rax,0D7C4DA7AB44D
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
       call      00007FF83BB9AFE0
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
       mov       r8,0D7C4DA7AB44D
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
       call      qword ptr [7FF7DC80D9B0]
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
       call      qword ptr [7FF7DCA14138]
       mov       r8,0D7C4DA7AB44D
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
       call      qword ptr [7FF7DCA14150]
       mov       r8,0D7C4DA7AB44D
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
       call      qword ptr [7FF7DC594E28]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF4D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DCA14168]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DCA14180]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DCA14180]
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
       call      qword ptr [7FF7DCA15530]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC8CEB98]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC8C4AC8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DCA14198]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1EF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,14F32800B18
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2B9800]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,0D7C4DA7AB44D
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18FC7950008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC80C0A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC5164C0]
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
       jmp       qword ptr [7FF7DBF466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF7DC59E868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FF7DC41C798]
       int       3
M04_L06:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC80C4C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
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
       call      qword ptr [7FF7DC1EF1B0]
       int       3
M04_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC80C600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC80C618]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,18FC7950008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FF7DC80E4F0]
       int       3
; Total bytes of code 231
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
       call      qword ptr [7FF7DC665170]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M07_L00
       mov       rcx,7FF7DC934580
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M07_L01
       mov       rcx,7FF7DC934584
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rcx,7FF7DC934588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7DC8CE718]
; Total bytes of code 132
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       je        near ptr M10_L05
       test      rbx,rbx
       je        near ptr M10_L06
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M10_L06
       cmp       dword ptr [rcx+4],18
       jne       near ptr M10_L06
       cmp       edi,[rsi+8]
       ja        short M10_L06
       cmp       edi,[rbx+8]
       ja        short M10_L06
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       jne       short M10_L02
       mov       rcx,rbx
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M10_L00:
       cmp       dword ptr [7FF83BEAF778],0
       jne       short M10_L03
M10_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       cmp       r8,4000
       ja        short M10_L04
       mov       rcx,rbx
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
       je        short M10_L00
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
       jmp       qword ptr [7FF7DC59E0E8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L05:
       xor       ebp,ebp
       jmp       short M10_L07
M10_L06:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF7DC8CEB08]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M10_L07:
       test      rbx,rbx
       jne       short M10_L08
       xor       r9d,r9d
       jmp       short M10_L09
M10_L08:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC8CEB08]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M10_L09:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FF7DC807228]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M10_L00
; Total bytes of code 247
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
       call      qword ptr [7FF7DC59E868]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF4F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC417750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE84000
       call      qword ptr [7FF7DBF4F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC80C600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5164C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DCA15488]
       jmp       short M11_L09
; Total bytes of code 431
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,[rcx+8]
M12_L00:
       mov       eax,[rcx+0A0]
       mov       [rsp+24],eax
       mov       r8d,eax
       and       r8d,[rcx+18]
       cmp       r8d,[rdx+8]
       jae       near ptr M12_L02
       shl       r8,4
       lea       rdi,[rdx+r8+10]
       mov       r8d,[rdi+8]
       sub       r8d,eax
       jne       short M12_L01
       lea       r8,[rcx+0A0]
       lea       ebp,[rax+1]
       lock cmpxchg [r8],ebp
       cmp       eax,[rsp+24]
       jne       short M12_L00
       mov       rcx,rdi
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+8],ebp
       mov       rcx,7FF7DC934BB8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L01:
       test      r8d,r8d
       jge       short M12_L00
       mov       rcx,7FF7DC934BBC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7DC934BB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7DC8CE7C0]
M12_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 188
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,21853800D70
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
       call      00007FF83BB54230
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
       mov       r8,2183D800180
       mov       r8,[r8]
       mov       rdx,258D2652D40
       call      qword ptr [7FF7DC394AF8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF7DC2B7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L06
M00_L04:
       movsxd    r8,r12d
       lea       rcx,[r13+r8*2+10]
       cmp       edi,2
       jle       short M00_L07
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       add       edi,r12d
       mov       [r15+18],edi
M00_L06:
       mov       r15,[rbp-50]
       inc       r14d
       cmp       r14d,esi
       jl        near ptr M00_L03
       mov       rcx,r15
       call      qword ptr [7FF7DC2CB600]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF7DCA2E6D8
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC97F318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF7DC664A08]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L15
M00_L11:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF7DC5AE250]
       mov       ecx,3
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC414028
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC716580]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC716598]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rbx,258D2640008
       jmp       near ptr M00_L09
M00_L14:
       call      qword ptr [7FF7DC716FA0]
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
       call      qword ptr [7FF7DC976568]
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7DC716AC0]
       int       3
M00_L19:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF7DC975C20]
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC7174C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],ebx
       jmp       near ptr M00_L33
M00_L24:
       mov       rcx,r15
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FF7DC9774C8]
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L29:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rax,21853800D70
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC7174C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r15
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [r15+18],esi
       jmp       near ptr M00_L47
M00_L36:
       mov       rcx,r15
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FF7DC9774C8]
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L41:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC716FA0]
       int       3
M00_L48:
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF83BB54230
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
       call      qword ptr [7FF7DC665170]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M00_L46
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF7DC976610]
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
       mov       rax,1A3824C7C84C
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
       call      00007FF83BB9AFE0
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
       mov       r8,1A3824C7C84C
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
       call      qword ptr [7FF7DC83E298]
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
       call      qword ptr [7FF7DCA64F30]
       mov       r8,1A3824C7C84C
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
       call      qword ptr [7FF7DCA64F48]
       mov       r8,1A3824C7C84C
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
       call      qword ptr [7FF7DC5A4E28]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r14,rax
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FF7DBF5D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r14,rax
M01_L29:
       lea       r8,[rbp+90]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],0B
       lea       r8,[rbp+28]
       lea       rcx,[rbp+70]
       mov       edx,1
       call      qword ptr [7FF7DCA64F60]
       mov       dword ptr [rbp+70],0A
       mov       byte ptr [rbp+78],0
       lea       rcx,[rbp+70]
       call      qword ptr [7FF7DCA64F78]
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
       mov       r9,7FF836930260
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
       call      qword ptr [7FF7DCA64F78]
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
       call      qword ptr [7FF7DCA66100]
       test      r13d,r13d
       je        short M01_L36
       mov       [rsp+20],r14
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+70]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FF7DC975B90]
       jmp       short M01_L37
M01_L36:
       mov       [rbp+8],rsi
       mov       [rbp+10],edi
       lea       r8,[rbp+8]
       lea       rdx,[rbp+70]
       lea       rcx,[rbp+50]
       mov       r9,r14
       call      qword ptr [7FF7DC975BA8]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L37:
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FF7DCA64F90]
       lea       rcx,[rbp+40]
       call      qword ptr [7FF7DC1FF6F0]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       r15,rax
       mov       rdx,[rbp+50]
       test      rdx,rdx
       je        short M01_L38
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       rcx,2183D8003A0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF7DC2AC488]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L38:
       mov       rax,r15
       mov       r8,1A3824C7C84C
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jl        short M02_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M02_L03
M02_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
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
       call      qword ptr [7FF7DC42C798]
       int       3
M02_L06:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC7174B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC1FF1B0]
       int       3
M02_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC7174C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L11:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC7174E0]
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
       jmp       qword ptr [7FF7DBF566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FF83BB9AFE0
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
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,258D2640008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC716FB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC5264C0]
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
       call      qword ptr [7FF7DC9765F8]
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,258D2640008
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
       call      qword ptr [7FF7DC83ED60]
       int       3
; Total bytes of code 235
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FF83BB4B8A0
       cmp       dword ptr [7FF83BEAF778],0
       jne       short M10_L02
M10_L00:
       cmp       dword ptr [7FF83BEAF778],0
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
       jmp       qword ptr [7FF7DC5AE0B8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M10_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M10_L00
M10_L06:
       xor       ebp,ebp
       jmp       short M10_L08
M10_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF7DC834348]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M10_L08:
       test      rbx,rbx
       jne       short M10_L09
       xor       r9d,r9d
       jmp       short M10_L10
M10_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC834348]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M10_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FF7DC716268]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF7DC5AE370]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF7DC427750]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
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
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC7174C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC5264C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF7DC9774C8]
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

