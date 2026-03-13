## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,4
       call      qword ptr [7FF8245FFCF0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FF8245FFD20]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245FFD38]
       int       3
M00_L09:
       mov       r11,7FF823E50BB8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E50BB0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF82466D868
       call      qword ptr [7FF823F05920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,22726DD0A28
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,22726DD09A8
       mov       [rsp+38],rcx
       mov       rcx,22726DD09D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1E6A7C00148
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 432
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1E691C00A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246C3BD0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246C3BD4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82407FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2C646C01A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,306DBA409A8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824688668
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,2C65CC00140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+58]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,5
       call      rax
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824378FE0
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8246966A0]
       int       3
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,2C646C00A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82407FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       push      rbx
       sub       rsp,80
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,19BAFC01A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,1DC449F09A8
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824687B18
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   ymm0,ymmword ptr [rsp+60]
       vmovdqu   ymmword ptr [rsp+30],ymm0
       mov       [rsp+20],r8
       mov       r8,19BC5C00140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       edx,1
       call      rax
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824388FE0
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF8246A6688]
       int       3
; Total bytes of code 236
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,19BAFC00A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82408FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2E7B5001A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,32849FF09A8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824628C20
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,2E7CB000118
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+58]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,4
       call      rax
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824378FE0
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF824674528]
       int       3
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,2E7B5000A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82407FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1A646801A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,1E6DB9A09A8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824638C10
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1A65C800118
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+58]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       call      rax
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824388FE0
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF8246845E8]
       int       3
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1A646800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82408FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1DE55401A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,21EEA5309A8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824658368
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1DE6B400140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+58]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       xor       edx,edx
       call      rax
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824358FE0
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF824676628]
       int       3
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1DE55400A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82405FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,22314801A90
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,263A97709A8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824608588
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,22314802110
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+58]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,3
       call      rax
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,191
       mov       rdx,7FF824358FE0
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF824654558]
       int       3
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,22314800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82405FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerBenchmark()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       cmp       r14d,ebp
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M00_L08
M00_L01:
       cmp       r14d,ebp
       setg      dil
       movzx     edi,dil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M00_L03:
       test      edi,edi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edi,edi
       jmp       short M00_L02
M00_L06:
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*4]
       lea       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       edx,5
       call      qword ptr [7FF8245D7F18]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FF8245D7F48]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FF8245D7F60]
       int       3
M00_L09:
       mov       r11,7FF823E409E0
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E409D8
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824618428
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,32956280A38
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,329562809A8
       mov       [rsp+30],rcx
       mov       rcx,329562809E0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2E8D7400118
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,5
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 449
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerExtensionsBenchmark()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       cmp       r14d,ebp
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M00_L08
M00_L01:
       cmp       r14d,ebp
       setg      dil
       movzx     edi,dil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M00_L03:
       test      edi,edi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edi,edi
       jmp       short M00_L02
M00_L06:
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*4]
       lea       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       edx,5
       call      qword ptr [7FF8245D7FD8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FF8245DC018]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FF8245DC030]
       int       3
M00_L09:
       mov       r11,7FF823E409E0
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E409D8
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824618840
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,25C0BF70A48
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,25C0BF709A8
       mov       [rsp+30],rcx
       mov       rcx,25C0BF709E0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,21B77002110
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,5
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 449
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF8245EFCA8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FF8245EFCD8]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245EFCF0]
       int       3
M00_L09:
       mov       r11,7FF823E30B28
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E30B20
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824667F98
       call      qword ptr [7FF823EE5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2B88E728290
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,2B88E7309A8
       mov       [rsp+38],rcx
       mov       rcx,2B88E7309D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FF823EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2780F800140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,277F9800A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246B30A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246B30AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82405FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823EE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF82460FC60]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FF82460FC90]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF82460FCA8]
       int       3
M00_L09:
       mov       r11,7FF823E50B28
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E50B20
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824677F98
       call      qword ptr [7FF823F05920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1E454518290
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,1E4545209A8
       mov       [rsp+38],rcx
       mov       rcx,1E4545209D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1A3D5400140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1A3BF400A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246D3198
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246D319C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82407FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,4
       call      qword ptr [7FF8245FFCD8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FF8245FFD08]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245FFD20]
       int       3
M00_L09:
       mov       r11,7FF823E40B28
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E40B20
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824678288
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,27482E70A38
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,27482E709A8
       mov       [rsp+38],rcx
       mov       rcx,27482E709D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,23404000140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,233EE000A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246C31C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246C31C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82406FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerBenchmark()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       cmp       r14d,ebp
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M00_L08
M00_L01:
       cmp       r14d,ebp
       setg      dil
       movzx     edi,dil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M00_L03:
       test      edi,edi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edi,edi
       jmp       short M00_L02
M00_L06:
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*4]
       lea       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       edx,4
       call      qword ptr [7FF8245FF7B0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FF8245FF7E0]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FF8245FF7F8]
       int       3
M00_L09:
       mov       r11,7FF823E50B28
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E50B20
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824676BA8
       call      qword ptr [7FF823F05920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2756DA30A30
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,2756DA309A8
       mov       [rsp+30],rcx
       mov       rcx,2756DA309D8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,234EEC00140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,4
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 449
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,234D8C00A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246D2E00
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246D2E04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82407FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerExtensionsBenchmark()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       cmp       r14d,ebp
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M00_L08
M00_L01:
       cmp       r14d,ebp
       setg      dil
       movzx     edi,dil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M00_L03:
       test      edi,edi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edi,edi
       jmp       short M00_L02
M00_L06:
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*4]
       lea       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       edx,4
       call      qword ptr [7FF82460F6C0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FF82460F6F0]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FF82460F708]
       int       3
M00_L09:
       mov       r11,7FF823E60B28
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E60B20
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824686340
       call      qword ptr [7FF823F15920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,20D398F0A40
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,20D398F09A8
       mov       [rsp+30],rcx
       mov       rcx,20D398F09D8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FF823F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1CCBA800140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,4
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 449
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1CCA4800A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246E33E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246E33EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82408FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,2
       call      qword ptr [7FF8245EF7B0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FF8245EF7E0]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245EF7F8]
       int       3
M00_L09:
       mov       r11,7FF823E40B28
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E40B20
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824666BA8
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,32E268E0A30
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,32E268E09A8
       mov       [rsp+38],rcx
       mov       rcx,32E268E09D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2EDA7800140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,2ED91800A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246C3198
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246C319C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82406FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,2
       call      qword ptr [7FF8245DC000]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FF8245DC030]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245DC048]
       int       3
M00_L09:
       mov       r11,7FF823E409E0
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E409D8
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824618840
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2B448900A48
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,2B4489009A8
       mov       [rsp+38],rcx
       mov       rcx,2B4489009D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,273B3802110
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureErrorFastLoggerExtensionsBenchmark()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       cmp       r14d,ebp
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M00_L08
M00_L01:
       cmp       r14d,ebp
       setg      dil
       movzx     edi,dil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M00_L03:
       test      edi,edi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edi,edi
       jmp       short M00_L02
M00_L06:
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*4]
       lea       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       edx,4
       call      qword ptr [7FF8245EFCC0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FF8245EFCF0]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FF8245EFD08]
       int       3
M00_L09:
       mov       r11,7FF823E30B30
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E30B28
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824668298
       call      qword ptr [7FF823EE5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1A75D430A60
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       rcx,1A75D4309A8
       mov       [rsp+30],rcx
       mov       rcx,1A75D4309E0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct
       call      qword ptr [7FF823EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,166C8402138
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,4
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 449
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,166C8400A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246B3198
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246B319C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82405FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823EE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFoundFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,4
       call      qword ptr [7FF8245C7EE8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FF8245C7F18]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245C7F30]
       int       3
M00_L09:
       mov       r11,7FF823E309E0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E309D8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8246081B8
       call      qword ptr [7FF823EE5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,185A0F70A70
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       rcx,185A0F709A8
       mov       [rsp+38],rcx
       mov       rcx,185A0F709E0
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct
       call      qword ptr [7FF823EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,14522000118
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8245EFCF0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FF8245EFD20]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245EFD38]
       int       3
M00_L09:
       mov       r11,7FF823E30B28
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E30B20
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824668298
       call      qword ptr [7FF823EE5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1D832870A28
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,1D8328709A8
       mov       [rsp+38],rcx
       mov       rcx,1D8328709D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FF823EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,197B3800140
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1979D800A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M01_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
       mov       rcx,7FF8246B3198
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
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
       test      r11d,r11d
       je        short M01_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M01_L00
M01_L02:
       mov       rcx,7FF8246B319C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF82405FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
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
       jmp       qword ptr [7FF823EE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8245CC000]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FF8245CC030]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245CC048]
       int       3
M00_L09:
       mov       r11,7FF823E309E0
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E309D8
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824608840
       call      qword ptr [7FF823EE5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,29DCB3A0A38
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,29DCB3A09A8
       mov       [rsp+38],rcx
       mov       rcx,29DCB3A09D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FF823EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,25D36402110
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 418
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerExtensionsBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF8245FC018]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FF8245FC048]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245FC060]
       int       3
M00_L09:
       mov       r11,7FF823E609E0
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E609D8
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824638840
       call      qword ptr [7FF823F15920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,29A3F400A40
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,29A3F4009A8
       mov       [rsp+38],rcx
       mov       rcx,29A3F4009D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FF823F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,259C0400118
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerBenchmark()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,[rcx+138]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M00_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M00_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        short M00_L06
M00_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M00_L08
M00_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M00_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M00_L03:
       test      esi,esi
       jne       near ptr M00_L11
M00_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       esi,esi
       jmp       short M00_L02
M00_L06:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF8245D7FC0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FF8245DC000]
       test      eax,eax
       jne       short M00_L00
M00_L07:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L06
       jmp       short M00_L00
M00_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M00_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8245DC018]
       int       3
M00_L09:
       mov       r11,7FF823E409E0
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FF823E409D8
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF824618840
       call      qword ptr [7FF823EF5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1DB719A0A28
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,1DB719A09A8
       mov       [rsp+38],rcx
       mov       rcx,1DB719A09D8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FF823EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,19ADC802110
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      rsi
       jmp       near ptr M00_L04
; Total bytes of code 433
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       call      qword ptr [7FF883968C18]
       mov       rcx,[rax]
       add       rcx,8
       mov       rax,[rdi]
       mov       r8d,ebx
       rol       r8d,5
       add       r8d,eax
       mov       edx,esi
       ror       edx,5
       add       r8d,edx
       mov       rdx,[rcx]
       movsxd    r10,r8d
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       movzx     ecx,byte ptr [rdx+10]
       shr       r10,cl
       xor       ecx,ecx
M01_L00:
       lea       r9d,[r10+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       r8d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M01_L02
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
       test      r11d,r11d
       je        short M01_L02
       inc       ecx
       add       r10d,ecx
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r10d,r9d
       cmp       ecx,8
       jl        short M01_L00
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
; Total bytes of code 239
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
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

