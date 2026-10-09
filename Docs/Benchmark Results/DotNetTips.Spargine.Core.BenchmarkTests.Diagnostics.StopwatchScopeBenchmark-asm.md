## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+1A8]
       mov       [rbp-50],rcx
       mov       rcx,offset MT_System.Diagnostics.Stopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-48],rsi
       cmp       byte ptr [rsi+18],0
       jne       short M00_L00
       lea       rcx,[rbp-20]
       mov       rax,7FFDF1695F60
       call      rax
       mov       rax,[rbp-20]
       mov       rsi,[rbp-48]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+18],1
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M00_L04
M00_L00:
       mov       rsi,[rbp-48]
       mov       [rbp-58],rsi
       mov       rdi,[rsi+8]
       cmp       byte ptr [rsi+18],0
       je        short M00_L01
       lea       rcx,[rbp-28]
       mov       rax,7FFDF1695F60
       call      rax
       mov       rax,[rbp-28]
       mov       rsi,[rbp-48]
       sub       rax,[rsi+10]
       add       rdi,rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       short M00_L02
M00_L01:
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rdi
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rcx,7FFFFFFFFFFFFFFF
       vcvttsd2si rax,xmm1
       vucomisd  xmm0,qword ptr [7FFD57255B80]
       cmovb     rcx,rax
       mov       [rbp-30],rcx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-30]
       call      qword ptr [7FFD577DE6E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
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
       mov       rax,[rbp-58]
       cmp       byte ptr [rax+18],0
       je        short M00_L06
       mov       rbx,[rax+8]
       lea       rcx,[rbp-38]
       call      00007FFD57198C18
       mov       rcx,[rbp-38]
       mov       rax,[rbp-58]
       sub       rcx,[rax+10]
       add       rcx,rbx
       mov       [rax+8],rcx
       mov       byte ptr [rax+18],0
M00_L06:
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rbx,[rax+8]
       cmp       byte ptr [rax+18],0
       je        short M00_L07
       lea       rcx,[rbp-40]
       call      00007FFD57198C18
       mov       rdx,[rbp-40]
       mov       rax,[rbp-58]
       sub       rdx,[rax+10]
       add       rbx,rdx
M00_L07:
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rbx
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       rdx,7FFFFFFFFFFFFFFF
       vcvttsd2si rcx,xmm1
       vucomisd  xmm0,qword ptr [7FFD57255B80]
       cmovb     rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.Diagnostics.StopwatchScopeBenchmark+<>c.<Setup>b__2_0(System.TimeSpan)
       mov       rax,[rbp-50]
       cmp       [rax+18],rcx
       je        short M00_L08
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 461
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

