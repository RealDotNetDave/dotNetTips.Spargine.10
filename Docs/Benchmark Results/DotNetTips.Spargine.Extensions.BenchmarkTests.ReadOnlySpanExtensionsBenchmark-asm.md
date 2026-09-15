## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFE15D98
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF6FE58]
       mov       ecx,3
       mov       rdx,7FFCDFDF0DB8
       call      qword ptr [7FFCDFBDC030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFCA57E0
       call      qword ptr [7FFCDFBDC030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDF0DB8
       call      qword ptr [7FFCDFBDC030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0227870]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDFF6F618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE0006268]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0227870]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22D250FFEB0
       call      qword ptr [7FFCDFF6F618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE0225998]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22D250F0008
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
       call      qword ptr [7FFCE019E8E0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDD5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF3EF58]
       mov       ecx,3
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0224C18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFA53B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0224C18]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2ABE2F5FEB0
       call      qword ptr [7FFCE015F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE015E0D0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2ABE2F50008
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
       call      qword ptr [7FFCE015FA38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDD5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF3EF10]
       mov       ecx,3
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0224C30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE015F480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFA5770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0224C30]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24B73C600B0
       call      qword ptr [7FFCE015F480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE015E0D0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24B73C50008
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
       call      qword ptr [7FFCE015FA50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDF5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5EC70]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244BE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC5050]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0244BE8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2E478D1FEB0
       call      qword ptr [7FFCE017F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017E088]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E478D10008
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
       call      qword ptr [7FFCE017F9F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDF5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF577E0]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE018D2D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018D2F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFF5DC20]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE018D2D8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D71CFCFEB0
       call      qword ptr [7FFCE018D2F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018CD20]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D71CFC0008
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
       call      qword ptr [7FFCE018D2C0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDF5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5EC70]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0245338]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC5050]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0245338]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23B0AADFEB0
       call      qword ptr [7FFCE017F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017E0B8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23B0AAD0008
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
       call      qword ptr [7FFCE017FA38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFE05598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF6EF58]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244000]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019FD80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD5770]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0244000]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2EA541500B0
       call      qword ptr [7FFCE019FD80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE019E0E8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EA54140008
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
       call      qword ptr [7FFCE02444E0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFCDFDF5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF5EBC8]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0087888]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE00878A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC4FF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0087888]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2536713FEB0
       call      qword ptr [7FFCE00878A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE0085CC8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25367130008
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
       call      qword ptr [7FFCE02648B8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFE15598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF777C8]
       mov       ecx,3
       mov       rdx,7FFCDFDF0598
       call      qword ptr [7FFCDFBE7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFCA4F28
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDF0598
       call      qword ptr [7FFCDFBE7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE019CC48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019CC60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFF7E1F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE019CC48]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,213BDAF00E8
       call      qword ptr [7FFCE019CC60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE019CAF8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,213BDAE0008
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
       call      qword ptr [7FFCE019D248]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDE5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF4EBC8]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0234BE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFB5A40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0234BE8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B7A0D80100
       call      qword ptr [7FFCE016F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE016DFB0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B7A0D70008
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
       call      qword ptr [7FFCE016FA08]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDE5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF4EC58]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0234BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFB5548]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0234BD0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2241FC900B0
       call      qword ptr [7FFCE016F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE016E088]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2241FC80008
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
       call      qword ptr [7FFCE016F9F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDE5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF4EF58]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0234C48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFB5B78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0234C48]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1BA92BF0100
       call      qword ptr [7FFCE016F480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE016E0D0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BA92BE0008
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
       call      qword ptr [7FFCE016FA50]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDF5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF577C8]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017CCC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017CCD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFF5DC08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE017CCC0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2FDE099FEB0
       call      qword ptr [7FFCE017CCD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017CA20]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2FDE0990008
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
       call      qword ptr [7FFCE017D278]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFE05598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF6EBC8]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0255338]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD4FF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0255338]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2507D04FEB0
       call      qword ptr [7FFCE018F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018E0B8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2507D040008
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
       call      qword ptr [7FFCE018FA38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDE5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF4EC58]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017F6C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017F6D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFB5080]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE017F6C0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,265E97CFEB0
       call      qword ptr [7FFCE017F6D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017E0D0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,265E97C0008
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
       call      qword ptr [7FFCE02244B0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+300]
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
       mov       rax,7FFCDFDD5598
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFF3EC70]
       mov       ecx,3
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE00678A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE00678B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFA5050]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE00678A0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,16C75CBFEB0
       call      qword ptr [7FFCE00678B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE0065E18]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16C75CB0008
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
       call      qword ptr [7FFCE02448D0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFE05598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE0186EE0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF6EF58]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254BA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD53B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0254BA0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,252DCB1FEB0
       call      qword ptr [7FFCE018F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018E088]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,252DCB10008
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
       call      qword ptr [7FFCE018FA08]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFE05598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE0186AC0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF6EBC8]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254B88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD4FF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0254B88]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C4B9CEFEB0
       call      qword ptr [7FFCE018F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018DF98]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C4B9CE0008
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
       call      qword ptr [7FFCE018F9F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFDE5598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE01773C0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF4F198]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0234BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD5C08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0234BD0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C0FC0B00B0
       call      qword ptr [7FFCE017F468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017E0D0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C0FC0A0008
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
       call      qword ptr [7FFCE017FA38]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFDF5598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE0176B68]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF5EC58]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0244BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC5080]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0244BD0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D0F6AAFEB0
       call      qword ptr [7FFCE017F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE017E0A0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D0F6AA0008
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
       call      qword ptr [7FFCE017FA20]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFE05598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE0186C40]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF6EC70]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFD5080]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0254BB8]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20DEA78FEB0
       call      qword ptr [7FFCE018F438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018E0A0]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20DEA780008
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
       call      qword ptr [7FFCE018FA08]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFE05598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE0197438]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF6F4F8]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE019DCE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019DCF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCE00058F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE019DCE0]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24D0C3BFEB0
       call      qword ptr [7FFCE019DCF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE019E130]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24D0C3B0008
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
       call      qword ptr [7FFCE019FA68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFDF5598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE018C108]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF5EF70]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE018FF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018F4B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC5380]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE018FF60]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,296524BFEB0
       call      qword ptr [7FFCE018F4B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE018E0B8]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,296524B0008
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
       call      qword ptr [7FFCE0234480]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+2F8]
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
       mov       rax,7FFCDFDF5598
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFD69353670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD3F8F3A90],0
       je        short M00_L02
       call      qword ptr [7FFD3F8E2648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCE01CFDC8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FFCDFF5EE50]
       mov       ecx,3
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC84F28
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDD0598
       call      qword ptr [7FFCDFBC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0097888]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE00978A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFCDFFC53B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FFCE0097888]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B45D78FEB0
       call      qword ptr [7FFCE00978A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FFCE0095E18]
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B45D780008
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
       call      qword ptr [7FFCE02547F8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,1D67F001E80
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBB78D0]
       int       3
M00_L04:
       mov       rsi,21714050008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF477C8]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017D0C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8D4000
       call      qword ptr [7FFCDFBB7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE017C9F0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D67F001E78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D67F001E80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,21714050008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21714050008
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
       call      qword ptr [7FFCE017D170]
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
       vmovups   xmm0,[7FFCE00A5790]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE00A57A0]
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
       vmovups   xmm0,[7FFCE00A57B0]
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
       call      qword ptr [7FFCE017F4C8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,23748C01E80
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBB78D0]
       int       3
M00_L04:
       mov       rsi,277DDA10008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF477C8]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE017CF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE017CF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8D4000
       call      qword ptr [7FFCDFBB7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE017CB28]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23748C01E78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23748C01E80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,277DDA10008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,277DDA10008
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
       call      qword ptr [7FFCE017D188]
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
       vmovups   xmm0,[7FFCE00A6630]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE00A6640]
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
       vmovups   xmm0,[7FFCE00A6650]
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
       call      qword ptr [7FFCE017F558]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,16867C01EA8
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBD78D0]
       int       3
M00_L04:
       mov       rsi,1A8FCAF0008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF6F1B0]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0254BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE019F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8F4000
       call      qword ptr [7FFCDFBD7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE019FFA8]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,16867C01EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16867C01EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1A8FCAF0008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A8FCAF0008
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
       call      qword ptr [7FFCE019FA20]
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
       vmovups   xmm0,[7FFCE0131270]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE0131280]
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
       vmovups   xmm0,[7FFCE0131290]
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
       call      qword ptr [7FFCE019E5F8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,18B03801E80
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBD78D0]
       int       3
M00_L04:
       mov       rsi,1CB987C0008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF677C8]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE018CD38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE018CD50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8F4000
       call      qword ptr [7FFCDFBD7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE018CA50]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18B03801E78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18B03801E80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1CB987C0008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CB987C0008
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
       call      qword ptr [7FFCE018D1D0]
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
       vmovups   xmm0,[7FFCE00C5250]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE00C5260]
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
       vmovups   xmm0,[7FFCE00C5270]
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
       call      qword ptr [7FFCE018F558]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,25254001E80
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBB78D0]
       int       3
M00_L04:
       mov       rsi,292E8DC0008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF4EC28]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0235290]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8D4000
       call      qword ptr [7FFCDFBB7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE016FF78]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,25254001E78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25254001E80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,292E8DC0008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,292E8DC0008
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
       call      qword ptr [7FFCE016F9F0]
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
       vmovups   xmm0,[7FFCE01020B0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE01020C0]
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
       vmovups   xmm0,[7FFCE01020D0]
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
       call      qword ptr [7FFCE016E5B0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,212E9001E90
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBB78D0]
       int       3
M00_L04:
       mov       rsi,2537E030008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF4ED30]
       mov       ecx,3
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC74F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDC0598
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0235290]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8D4000
       call      qword ptr [7FFCDFBB7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE016FF18]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,212E9001E88
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,212E9001E90
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,2537E030008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2537E030008
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
       call      qword ptr [7FFCE016F9F0]
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
       vmovups   xmm0,[7FFCE0102DD0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE0102DE0]
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
       vmovups   xmm0,[7FFCE0102DF0]
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
       call      qword ptr [7FFCE016E5B0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,281F2401EA8
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBA78D0]
       int       3
M00_L04:
       mov       rsi,2C287320008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF3EF70]
       mov       ecx,3
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDB0598
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE016FF48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE016F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8C4000
       call      qword ptr [7FFCDFBA7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE02150E0]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,281F2401EA0
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF986BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,281F2401EA8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,2C287320008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C287320008
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
       call      qword ptr [7FFCE0214468]
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
       vmovups   xmm0,[7FFCE0127AB0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE0127AC0]
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
       vmovups   xmm0,[7FFCE0127AD0]
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
       call      qword ptr [7FFCE016E5E0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+2E8]
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
       mov       rcx,180DD401E90
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
       call      00007FFD3F6352E0
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFCDFBD78D0]
       int       3
M00_L04:
       mov       rsi,1C1724D0008
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFCDFF6EDA8]
       mov       ecx,3
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC94F28
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDE0598
       call      qword ptr [7FFCDFBD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF9B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCE0097810]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCE0097828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,11AD
       mov       rdx,7FFCDF8F4000
       call      qword ptr [7FFCDFBD7798]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFCE0275470]
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,180DD401E88
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,180DD401E90
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       rsi,1C1724D0008
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
       call      00007FFD3F6352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDF9B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C1724D0008
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
       call      qword ptr [7FFCE02747C8]
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
       vmovups   xmm0,[7FFCE029D310]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FFCE029D320]
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
       vmovups   xmm0,[7FFCE029D330]
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
       call      qword ptr [7FFCE00962C8]
       int       3
; Total bytes of code 44
```

