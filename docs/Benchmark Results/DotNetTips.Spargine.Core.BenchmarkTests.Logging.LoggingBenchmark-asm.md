## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E86C4F8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB5E86C510]
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
       call      qword ptr [7FFB5E86C528]
       int       3
M00_L09:
       mov       r11,7FFB5E0F0B28
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0F0B20
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E85ACA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2756BE10AD0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,2756BE10A50
       mov       [rsp+38],rcx
       mov       rcx,2756BE10A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,234D70021D8
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
; Total bytes of code 431
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
       mov       r9,234D7000A10
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
       jmp       qword ptr [7FFB5E1A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2C5C1401B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,30656520A50
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E82F7C8
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,2C5D74001B0
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
       mov       rdx,7FFB5E57C7C0
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E864618]
       int       3
; Total bytes of code 258
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
       mov       r9,2C5C1400A10
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       push      rbx
       sub       rsp,80
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1C544801B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,205D96F0A50
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7C9F50
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   ymm0,ymmword ptr [rsp+60]
       vmovdqu   ymmword ptr [rsp+30],ymm0
       mov       [rsp+20],r8
       mov       r8,1C55A800188
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
       mov       rdx,7FFB5E56C7C0
       call      qword ptr [7FFB5E3B77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E7BE6B8]
       int       3
; Total bytes of code 237
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
       mov       r9,1C544800A10
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
       jmp       qword ptr [7FFB5E30FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2027F001B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,24313F50A50
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7FF230
       call      qword ptr [7FFB5E175920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,202950001B0
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
       mov       rdx,7FFB5E54C7C0
       call      qword ptr [7FFB5E3977B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E834600]
       int       3
; Total bytes of code 255
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
       mov       r9,2027F000A10
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
       jmp       qword ptr [7FFB5E2EFFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,239B5401B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,27A4A490A50
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7FB518
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,239B5402188
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
       mov       rdx,7FFB5E56C7C0
       call      qword ptr [7FFB5E3B77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E844060]
       int       3
; Total bytes of code 258
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
       mov       r9,239B5400A10
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
       jmp       qword ptr [7FFB5E30FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,19256001B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,1D2EB070A50
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E82F7C8
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1926C0001B0
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
       mov       rdx,7FFB5E57C7C0
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E864708]
       int       3
; Total bytes of code 255
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
       mov       r9,19256000A10
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1DED7401B00
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,21F6C5D0A50
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E8098E8
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1DED7402180
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
       mov       rdx,7FFB5E57C7C0
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E7AFF78]
       int       3
; Total bytes of code 258
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
       mov       r9,1DED7400A10
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
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
       call      qword ptr [7FFB5E7CE490]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFB5E7CE4A8]
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
       call      qword ptr [7FFB5E7CE4C0]
       int       3
M00_L09:
       mov       r11,7FFB5E0F08F0
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0F08E8
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7D9A88
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2915AA50AE0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,2915AA50A50
       mov       [rsp+30],rcx
       mov       rcx,2915AA50A88
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFB5E1A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,250C5C02180
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E1A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
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
       call      qword ptr [7FFB5E7DE4A8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFB5E7DE4C0]
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
       call      qword ptr [7FFB5E7DE4D8]
       int       3
M00_L09:
       mov       r11,7FFB5E1008F0
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E1008E8
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7E9A88
       call      qword ptr [7FFB5E1B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1B184910AF0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,1B184910A50
       mov       [rsp+30],rcx
       mov       rcx,1B184910A88
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFB5E1B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,17105800188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E1B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7BE490]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFB5E7BE4A8]
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
       call      qword ptr [7FFB5E7BE4C0]
       int       3
M00_L09:
       mov       r11,7FFB5E0E08F0
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0E08E8
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7C9A88
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,20699028258
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,20699030A50
       mov       [rsp+38],rcx
       mov       rcx,20699030A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFB5E195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1C61A000188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E195C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E8444F8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFB5E844510]
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
       call      qword ptr [7FFB5E844528]
       int       3
M00_L09:
       mov       r11,7FFB5E0D0A38
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D0A30
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7E9A88
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,29ACD858258
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,29ACD860A50
       mov       [rsp+38],rcx
       mov       rcx,29ACD860A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,25A4E800188
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
       mov       rdx,25A38800A10
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
       mov       rcx,7FFB5E8283F0
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
       mov       rcx,7FFB5E8283F4
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
       jmp       qword ptr [7FFB5E2FFFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7AE490]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB5E7AE4A8]
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
       call      qword ptr [7FFB5E7AE4C0]
       int       3
M00_L09:
       mov       r11,7FFB5E0D08F0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D08E8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7B9A88
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1A7ACF40AE0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,1A7ACF40A50
       mov       [rsp+38],rcx
       mov       rcx,1A7ACF40A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16718002180
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
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
       call      qword ptr [7FFB5E864F48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB5E864F60]
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
       call      qword ptr [7FFB5E864F78]
       int       3
M00_L09:
       mov       r11,7FFB5E0F0A40
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0F0A38
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E82F300
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,292F63D0AD8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,292F63D0A50
       mov       [rsp+30],rcx
       mov       rcx,292F63D0A80
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFB5E1A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,252614021A8
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
       mov       rdx,25261400A10
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
       mov       rcx,7FFB5E8742E0
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
       mov       rcx,7FFB5E8742E4
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB5E1A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
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
       call      qword ptr [7FFB5E844FC0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB5E844FD8]
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
       call      qword ptr [7FFB5E844FF0]
       int       3
M00_L09:
       mov       r11,7FFB5E0D0A40
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D0A38
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E80F300
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1C4CC640AE8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,1C4CC640A50
       mov       [rsp+30],rcx
       mov       rcx,1C4CC640A80
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,184378021A8
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
       mov       rdx,18437800A10
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
       mov       rcx,7FFB5E854420
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
       mov       rcx,7FFB5E854424
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
       jmp       qword ptr [7FFB5E2FFFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E864F48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFB5E864F60]
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
       call      qword ptr [7FFB5E864F78]
       int       3
M00_L09:
       mov       r11,7FFB5E0F0A38
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0F0A30
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E82ED78
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,24C0CFF0AD8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,24C0CFF0A50
       mov       [rsp+38],rcx
       mov       rcx,24C0CFF0A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFB5E1A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,20B780021A8
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
       mov       rdx,20B78000A10
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
       mov       rcx,7FFB5E8740F0
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
       mov       rcx,7FFB5E8740F4
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
       jmp       qword ptr [7FFB5E31FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB5E1A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7AE490]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFB5E7AE4A8]
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
       call      qword ptr [7FFB5E7AE4C0]
       int       3
M00_L09:
       mov       r11,7FFB5E0D08F0
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D08E8
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7B9A28
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,201E2320AF0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,201E2320A50
       mov       [rsp+38],rcx
       mov       rcx,201E2320A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1C14D402180
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
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
       call      qword ptr [7FFB5E7AE4D8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB5E7AE4F0]
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
       call      qword ptr [7FFB5E7AE508]
       int       3
M00_L09:
       mov       r11,7FFB5E0D08F0
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D08E8
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7B9420
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,24243580B08
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       rcx,24243580A50
       mov       [rsp+30],rcx
       mov       rcx,24243580A88
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,201C4400188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7AE4A8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB5E7AE4C0]
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
       call      qword ptr [7FFB5E7AE4D8]
       int       3
M00_L09:
       mov       r11,7FFB5E0D08F0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D08E8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7B9A78
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,21EA2720B18
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       rcx,21EA2720A50
       mov       [rsp+38],rcx
       mov       rcx,21EA2720A88
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1DE0D802180
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7BE4A8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFB5E7BE4C0]
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
       call      qword ptr [7FFB5E7BE4D8]
       int       3
M00_L09:
       mov       r11,7FFB5E0E08F0
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0E08E8
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7C9A78
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,249BB2E0AD0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,249BB2E0A50
       mov       [rsp+38],rcx
       mov       rcx,249BB2E0A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFB5E195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2093C400188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E195C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7BE4A8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFB5E7BE4C0]
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
       call      qword ptr [7FFB5E7BE4D8]
       int       3
M00_L09:
       mov       r11,7FFB5E0E08F0
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0E08E8
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7C9A88
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2100DAE0AE0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,2100DAE0A50
       mov       [rsp+38],rcx
       mov       rcx,2100DAE0A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFB5E195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1CF8EC00188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E195C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E7AE4F0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFB5E7AE508]
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
       call      qword ptr [7FFB5E7AE520]
       int       3
M00_L09:
       mov       r11,7FFB5E0D08F0
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0D08E8
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E7B9420
       call      qword ptr [7FFB5E185920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2A7444F0AE8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,2A7444F0A50
       mov       [rsp+38],rcx
       mov       rcx,2A7444F0A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFB5E185728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,266C5400188
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
       call      qword ptr [7FFBBDBF4C30]
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
       jmp       qword ptr [7FFB5E185C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+140]
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
       call      qword ptr [7FFB5E854F30]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFB5E854F48]
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
       call      qword ptr [7FFB5E854F60]
       int       3
M00_L09:
       mov       r11,7FFB5E0E0A40
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB5E0E0A38
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E81ED78
       call      qword ptr [7FFB5E195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1E6D8A20AD0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,1E6D8A20A50
       mov       [rsp+38],rcx
       mov       rcx,1E6D8A20A80
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFB5E195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1A659C001B0
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
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1A643C00A10
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
       mov       rcx,7FFB5E8640F0
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
       mov       rcx,7FFB5E8640F4
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
       jmp       qword ptr [7FFB5E30FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB5E195C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

