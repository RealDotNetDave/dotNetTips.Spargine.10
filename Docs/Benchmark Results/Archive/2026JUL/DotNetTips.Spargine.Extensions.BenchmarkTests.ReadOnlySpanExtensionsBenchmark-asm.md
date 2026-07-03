## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5551198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56BF798]
       mov       ecx,3
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D510F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D510F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D510F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD758]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD770]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5745C20]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD758]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2FF8958FD90
       call      qword ptr [7FF7D58DD770]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DDDB8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2FF89580008
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
       call      qword ptr [7FF7D58DF1C8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5521198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D568F078]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57158C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD230]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1A5FB21FF90
       call      qword ptr [7FF7D58BD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD8C0]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A5FB210008
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
       call      qword ptr [7FF7D58BF198]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5551198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56BEB68]
       mov       ecx,3
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD470]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD488]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57357D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD470]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B0F5C8FFE0
       call      qword ptr [7FF7D58DD488]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD8C0]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B0F5C80008
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
       call      qword ptr [7FF7D58DF198]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5521198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D568F078]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD188]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD1A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5715B00]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD188]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28E397EFFC8
       call      qword ptr [7FF7D58BD1A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD938]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28E397E0008
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
       call      qword ptr [7FF7D58BF210]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5521198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D568F078]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5715500]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD230]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2236D48FD90
       call      qword ptr [7FF7D58BD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD938]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2236D480008
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
       call      qword ptr [7FF7D58BF210]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5541198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56AF018]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57354A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD218]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,277201DFD90
       call      qword ptr [7FF7D58DD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD8A8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,277201D0008
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
       call      qword ptr [7FF7D58DF198]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5551198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56BF018]
       mov       ecx,3
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58ED248]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58ED260]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5745470]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58ED248]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2AE067CFD90
       call      qword ptr [7FF7D58ED260]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58ED8D8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AE067C0008
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
       call      qword ptr [7FF7D58EF900]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+280]
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
       mov       rax,7FF7D5531198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D569F030]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57D4E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57D4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5725980]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D57D4E58]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1EB85DDFF90
       call      qword ptr [7FF7D57D4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D57D5620]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EB85DD0008
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
       call      qword ptr [7FF7D591CBD0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5521198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D568F030]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD188]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD1A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5715878]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD188]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A51B56FF90
       call      qword ptr [7FF7D58BD1A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD8C0]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A51B560008
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
       call      qword ptr [7FF7D58BF1B0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5541198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56AF018]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD200]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD218]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57354A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD200]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E47F15FD90
       call      qword ptr [7FF7D58DD218]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD890]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E47F150008
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
       call      qword ptr [7FF7D58DF168]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5541198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56AF078]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5735500]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD230]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C46D12FD90
       call      qword ptr [7FF7D58DD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD938]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C46D120008
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
       call      qword ptr [7FF7D58DF210]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5531198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D569EB38]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD650]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD668]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5715488]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD650]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,236912CFF90
       call      qword ptr [7FF7D58BD668]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD8A8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,236912C0008
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
       call      qword ptr [7FF7D58BF180]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5531198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D569F018]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5725860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58CD218]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2526A8CFF90
       call      qword ptr [7FF7D58CD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58CD8A8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2526A8C0008
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
       call      qword ptr [7FF7D58CF198]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5511198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D567F018]
       mov       ecx,3
       mov       rdx,7FF7D54DC1D0
       call      qword ptr [7FF7D50DF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53A5AC0
       call      qword ptr [7FF7D50DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54DC1D0
       call      qword ptr [7FF7D50DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58AD230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58AD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5705968]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58AD230]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29132D9FF90
       call      qword ptr [7FF7D58AD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58AD8C0]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29132D90008
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
       call      qword ptr [7FF7D58AF1B0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5531198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D569F018]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD110]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD128]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57254A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58CD110]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E2C2F6FD90
       call      qword ptr [7FF7D58CD128]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58CD8D8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E2C2F60008
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
       call      qword ptr [7FF7D58CF978]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+290]
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
       mov       rax,7FF7D5541198
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D56AF018]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57E4E28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57E4E40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5735968]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D57E4E28]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2ED53BFFF90
       call      qword ptr [7FF7D57E4E40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D57E55F0]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2ED53BF0008
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
       call      qword ptr [7FF7D592CC18]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5531198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58C6688]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D569F030]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD158]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD170]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5725878]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58CD158]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2230526FF90
       call      qword ptr [7FF7D58CD170]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58CD890]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22305260008
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
       call      qword ptr [7FF7D58CF168]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5521198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58B6688]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D568F018]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57154A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD218]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F5B13EFD90
       call      qword ptr [7FF7D58BD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD8A8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F5B13E0008
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
       call      qword ptr [7FF7D58BF180]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5521198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58A6148]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D568EBC8]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58AD560]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58AD578]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5705050]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58AD560]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2B03178FD90
       call      qword ptr [7FF7D58AD578]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58AD860]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B031780008
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
       call      qword ptr [7FF7D58AF138]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5541198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58D6700]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D56AF078]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD188]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5735500]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD170]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D293A3FD90
       call      qword ptr [7FF7D58DD188]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD920]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D293A30008
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
       call      qword ptr [7FF7D58DF210]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5541198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58D66A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D56AF018]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD200]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD218]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57354A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58DD200]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E59B99FD90
       call      qword ptr [7FF7D58DD218]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58DD890]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E59B990008
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
       call      qword ptr [7FF7D58DF180]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5521198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58B6628]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D568F078]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58BD218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58BD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D5715500]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D58BD218]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22085DEFD90
       call      qword ptr [7FF7D58BD230]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D58BD920]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22085DE0008
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
       call      qword ptr [7FF7D58BF1F8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5521198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D58ED938]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D568F018]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57CD230]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57CD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57154A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D57CD230]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,251E0C9FD90
       call      qword ptr [7FF7D57CD248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D57CD9F8]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,251E0C90008
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
       call      qword ptr [7FF7D58EFBD0]
       int       3
; Total bytes of code 231
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,[rbx+288]
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
       mov       rax,7FF7D5531198
       mov       [rbp-0C0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0B0],rax
       lea       rax,[rbp-0D0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF950043670
       vzeroupper
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M00_L02
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7D592F2A0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person ByRef)
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
       call      qword ptr [7FF7D569F078]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57D4E10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57D4E28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF7D57358C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L06
       call      qword ptr [7FF7D57D4E10]
       mov       rbx,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22A48E6FF90
       call      qword ptr [7FF7D57D4E28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L08:
       mov       ecx,eax
       call      qword ptr [7FF7D57D5650]
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22A48E60008
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
       call      qword ptr [7FF7D592F588]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,1FCB4C00A40
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,23D33A20008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5054000
       call      qword ptr [7FF7D511F228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58DF780]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D511F360]
       int       3
M00_L06:
       call      qword ptr [7FF7D56BEB38]
       mov       ecx,3
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53E5AC0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D551C1D0
       call      qword ptr [7FF7D511F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD698]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD6B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1FCB4C00A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D5116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FCB4C00A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,23D33A20008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23D33A20008
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
       call      qword ptr [7FF7D58DF1C8]
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
       vmovups   xmm0,[7FF7D586FED0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D586FEE0]
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
       vmovups   xmm0,[7FF7D586FEF0]
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
       call      qword ptr [7FF7D58DDE18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,2006C000A40
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,240EAFC0008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5034000
       call      qword ptr [7FF7D50FF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58CF798]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50FF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D569F018]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD1D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD1E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2006C000A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2006C000A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,240EAFC0008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,240EAFC0008
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
       call      qword ptr [7FF7D58CF1E0]
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
       vmovups   xmm0,[7FF7D5860A30]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D5860A40]
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
       vmovups   xmm0,[7FF7D5860A50]
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
       call      qword ptr [7FF7D58CDE18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,15959C00A40
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,199D8D20008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5034000
       call      qword ptr [7FF7D50FF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58CF810]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50FF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D569F078]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD1D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD1E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,15959C00A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15959C00A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,199D8D20008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,199D8D20008
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
       call      qword ptr [7FF7D58CF258]
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
       vmovups   xmm0,[7FF7D58655D0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D58655E0]
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
       vmovups   xmm0,[7FF7D58655F0]
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
       call      qword ptr [7FF7D58CDE90]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,1F38E002A38
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,23422E30008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5024000
       call      qword ptr [7FF7D50EF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58AF798]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50EF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D568EB68]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58AD4B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58AD4D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F38E002A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F38E002A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,23422E30008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23422E30008
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
       call      qword ptr [7FF7D58AF1E0]
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
       vmovups   xmm0,[7FF7D583FEB0]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D583FEC0]
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
       vmovups   xmm0,[7FF7D583FED0]
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
       call      qword ptr [7FF7D58ADE18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,25697802A38
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,2972C5D0008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5044000
       call      qword ptr [7FF7D510F228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58DF828]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D510F360]
       int       3
M00_L06:
       call      qword ptr [7FF7D56AF078]
       mov       ecx,3
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53D5AC0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D550C1D0
       call      qword ptr [7FF7D510F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D510D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58DD1D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58DD1E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25697802A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D5106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25697802A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,2972C5D0008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2972C5D0008
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
       call      qword ptr [7FF7D58DF258]
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
       vmovups   xmm0,[7FF7D5875790]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D58757A0]
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
       vmovups   xmm0,[7FF7D58757B0]
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
       call      qword ptr [7FF7D58DDE90]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,1C312402A38
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,203A7420008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5034000
       call      qword ptr [7FF7D50FF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D58CF768]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50FF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D569F078]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D58CD068]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D58CD080]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C312402A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C312402A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,203A7420008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,203A7420008
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
       call      qword ptr [7FF7D58CF1F8]
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
       vmovups   xmm0,[7FF7D5865490]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D58654A0]
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
       vmovups   xmm0,[7FF7D58654B0]
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
       call      qword ptr [7FF7D58CDE18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,26742800AC0
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,2A7C1700008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5034000
       call      qword ptr [7FF7D50FF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D5994798]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50FF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D569F078]
       mov       ecx,3
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53C5AC0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54FC1D0
       call      qword ptr [7FF7D50FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57DD2C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57DD2D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26742800AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26742800AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,2A7C1700008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A7C1700008
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
       call      qword ptr [7FF7D58FFC48]
       int       3
; Total bytes of code 231
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
       vmovups   xmm0,[7FF7D5A00F30]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D5A00F40]
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
       vmovups   xmm0,[7FF7D5A00F50]
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
       call      qword ptr [7FF7D57DDF68]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+278]
       test      rcx,rcx
       je        near ptr M00_L06
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L08
       cmp       esi,3FFFFFFF
       jl        short M00_L00
       cmp       esi,3FFFFFFF
       jg        near ptr M00_L04
M00_L00:
       mov       rcx,20408002AE0
       mov       rdi,[rcx]
       lea       ebp,[rsi+rsi]
       mov       [rsp+38],rax
       mov       [rsp+40],esi
       xor       ecx,ecx
       mov       [rsp+48],ecx
       test      rdi,rdi
       je        near ptr M00_L07
M00_L01:
       test      ebp,ebp
       jg        short M00_L02
       test      ebp,ebp
       jne       near ptr M00_L05
       mov       r14,2449D1A0008
       jmp       short M00_L03
M00_L02:
       mov       edx,ebp
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r14,rax
       cmp       [r14],r14b
       lea       rdx,[r14+0C]
       mov       [rsp+20],rdx
       mov       [rsp+28],ebp
       lea       rdx,[rsp+20]
       lea       r8,[rsp+38]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
M00_L03:
       mov       [rsp+30],r14
       mov       rbx,[rbx+60]
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
M00_L04:
       mov       ecx,11AD
       mov       rdx,7FF7D5024000
       call      qword ptr [7FF7D50EF228]
       mov       r8,rax
       mov       ecx,esi
       mov       edx,3FFFFFFF
       call      qword ptr [7FF7D5994990]
       int       3
M00_L05:
       mov       ecx,28
       call      qword ptr [7FF7D50EF360]
       int       3
M00_L06:
       call      qword ptr [7FF7D568F078]
       mov       ecx,3
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D53B5AC0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D54EC1D0
       call      qword ptr [7FF7D50EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D50ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D57C4F18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D57C4F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20408002AD8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       call      qword ptr [7FF7D50E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20408002AE0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,2449D1A0008
       jmp       near ptr M00_L03
; Total bytes of code 525
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
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D50E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2449D1A0008
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
       call      qword ptr [7FF7D591F600]
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
       vmovups   xmm0,[7FF7D59BBF10]
M02_L03:
       xor       r8d,r8d
       mov       ecx,ecx
       lea       r10,[rcx-4]
       vbroadcastss xmm1,dword ptr [7FF7D59BBF20]
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
       vmovups   xmm0,[7FF7D59BBF30]
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
       call      qword ptr [7FF7D57C5BC0]
       int       3
; Total bytes of code 44
```

