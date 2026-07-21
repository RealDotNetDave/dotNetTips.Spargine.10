## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Diagnostics.StopwatchScopeBenchmark.CreateAndDispose()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rcx
       mov       [rbp+10],rbx
       mov       rsi,[rbx+198]
       mov       [rbp-48],rsi
       mov       rcx,offset MT_System.Diagnostics.Stopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-50],rdi
       cmp       byte ptr [rdi+18],0
       jne       short M00_L00
       lea       rcx,[rbp-20]
       mov       rax,7FF956025F50
       call      rax
       mov       rax,[rbp-20]
       mov       rdi,[rbp-50]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+18],1
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M00_L04
M00_L00:
       mov       rdi,[rbp-50]
       mov       [rbp-60],rdi
       mov       rsi,[rbp-48]
       mov       [rbp-58],rsi
       mov       rsi,[rdi+8]
       cmp       byte ptr [rdi+18],0
       je        short M00_L01
       lea       rcx,[rbp-28]
       mov       rax,7FF956025F50
       call      rax
       mov       rax,[rbp-28]
       mov       rdi,[rbp-50]
       sub       rax,[rdi+10]
       add       rsi,rax
       cmp       dword ptr [7FF907B64A90],0
       jne       short M00_L02
M00_L01:
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rsi
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rcx,7FFFFFFFFFFFFFFF
       vcvttsd2si rax,xmm1
       vucomisd  xmm0,qword ptr [7FF8A831F188]
       cmovb     rcx,rax
       mov       [rbp-30],rcx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rbp-30]
       call      qword ptr [7FF8A825FEA0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       jmp       short M00_L03
M00_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L01
M00_L03:
       call      M00_L05
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L05:
       sub       rsp,28
       vzeroupper
       mov       rax,[rbp-60]
       cmp       byte ptr [rax+18],0
       je        short M00_L06
       mov       rbx,[rax+8]
       lea       rcx,[rbp-38]
       call      00007FF8A7C18C90
       mov       rcx,[rbp-38]
       mov       rax,[rbp-60]
       sub       rcx,[rax+10]
       add       rcx,rbx
       mov       [rax+8],rcx
       mov       byte ptr [rax+18],0
M00_L06:
       cmp       qword ptr [rbp-58],0
       je        short M00_L08
       mov       rbx,[rax+8]
       cmp       byte ptr [rax+18],0
       je        short M00_L07
       lea       rcx,[rbp-40]
       call      00007FF8A7C18C90
       mov       rdx,[rbp-40]
       mov       rax,[rbp-60]
       sub       rdx,[rax+10]
       add       rbx,rdx
M00_L07:
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rbx
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rdx,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FF8A831F188]
       cmovb     rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.Diagnostics.StopwatchScopeBenchmark+<>c.<Setup>b__2_0(System.TimeSpan)
       mov       rsi,[rbp-58]
       cmp       [rsi+18],rcx
       je        short M00_L08
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 469
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Diagnostics.StopwatchScopeBenchmark+<>c.<Setup>b__2_0(System.TimeSpan)
       ret
; Total bytes of code 1
```

