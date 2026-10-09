## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD5787CFD8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFD5787CFF0]
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
       call      qword ptr [7FFD5787D008]
       int       3
M00_L09:
       mov       r11,7FFD570F0AC0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0AB8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57851AB0
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1A7F27C0F38
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,1A7F27C0EB8
       mov       [rsp+38],rcx
       mov       rcx,1A7F27C0EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1675D802200
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
       mov       rdx,1675D800A10
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
       mov       rcx,7FFD578835A0
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
       mov       rcx,7FFD578835A4
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,18FE0001AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,1D074EC0EB8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5786A1C0
       call      qword ptr [7FFD571C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,18FE00021E8
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
       mov       rdx,7FFD575B1DE0
       call      qword ptr [7FFD573E77C8]
       mov       rcx,rax
       call      qword ptr [7FFD57895470]
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
       mov       r9,18FE0000A10
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
       jmp       qword ptr [7FFD5733FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       push      rbx
       sub       rsp,80
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,[rcx+1B0]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,19325001AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,1D3BA170EB8
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5785A200
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   ymm0,ymmword ptr [rsp+60]
       vmovdqu   ymmword ptr [rsp+30],ymm0
       mov       [rsp+20],r8
       mov       r8,1933B0001F0
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
       mov       rdx,7FFD575A1DE0
       call      qword ptr [7FFD573D77C8]
       mov       rcx,rax
       call      qword ptr [7FFD57885488]
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
       mov       r9,19325000A10
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1BEC7C01AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,1FF5CA40EB8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57839B70
       call      qword ptr [7FFD57195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1BEDDC001F0
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
       mov       rdx,7FFD57581DE0
       call      qword ptr [7FFD573B77C8]
       mov       rcx,rax
       call      qword ptr [7FFD57865488]
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
       mov       r9,1BEC7C00A10
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
       jmp       qword ptr [7FFD5730FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2777FC01AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,2B814C70EB8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5782CEC0
       call      qword ptr [7FFD57195920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,27795C001F0
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
       mov       rdx,7FFD57581DE0
       call      qword ptr [7FFD573B77C8]
       mov       rcx,rax
       call      qword ptr [7FFD57845470]
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
       mov       r9,2777FC00A10
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
       jmp       qword ptr [7FFD5730FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,25A7FC01AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,29B14CB0EB8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849830
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,25A95C001F0
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
       mov       rdx,7FFD57591DE0
       call      qword ptr [7FFD573C77C8]
       mov       rcx,rax
       call      qword ptr [7FFD57875410]
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
       mov       r9,25A7FC00A10
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1FAD7401AF0
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,23B6C1D0EB8
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5785A200
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1FAED4001F0
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
       mov       rdx,7FFD575A1DE0
       call      qword ptr [7FFD573D77C8]
       mov       rcx,rax
       call      qword ptr [7FFD578854A0]
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
       mov       r9,1FAD7400A10
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
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
       call      qword ptr [7FFD578A5E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFD578A5E60]
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
       call      qword ptr [7FFD578A5E78]
       int       3
M00_L09:
       mov       r11,7FFD57120A28
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57120A20
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57879740
       call      qword ptr [7FFD571D5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,17EE5340F48
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,17EE5340EB8
       mov       [rsp+30],rcx
       mov       rcx,17EE5340EF0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFD571D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,13E664001F0
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
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,13E50400A10
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
       mov       rcx,7FFD578BF938
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
       mov       rcx,7FFD578BF93C
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
       jmp       qword ptr [7FFD5734FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
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
       call      qword ptr [7FFD57885E30]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFD57885E48]
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
       call      qword ptr [7FFD57885E60]
       int       3
M00_L09:
       mov       r11,7FFD57100A28
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57100A20
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57859DC0
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2E402EF0F58
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,2E402EF0EB8
       mov       [rsp+30],rcx
       mov       rcx,2E402EF0EF0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFD571B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2A3840001F0
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
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,2A36E000A10
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
       mov       rcx,7FFD5789FA10
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
       mov       rcx,7FFD5789FA14
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFD57875E60]
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
       call      qword ptr [7FFD57875E78]
       int       3
M00_L09:
       mov       r11,7FFD570F0A20
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A18
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849740
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2B09EF98258
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,2B09EFA0EB8
       mov       [rsp+38],rcx
       mov       rcx,2B09EFA0EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,270200001F0
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
       mov       rdx,2700A000A10
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
       mov       rcx,7FFD5788FA48
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
       mov       rcx,7FFD5788FA4C
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFD57875E60]
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
       call      qword ptr [7FFD57875E78]
       int       3
M00_L09:
       mov       r11,7FFD570F0A28
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A20
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849DC0
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1DEC1238258
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,1DEC1240EB8
       mov       [rsp+38],rcx
       mov       rcx,1DEC1240EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,19E420001F0
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
       mov       rdx,19E2C000A10
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
       mov       rcx,7FFD5788FA10
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
       mov       rcx,7FFD5788FA14
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57895E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFD57895E60]
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
       call      qword ptr [7FFD57895E78]
       int       3
M00_L09:
       mov       r11,7FFD57110A20
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57110A18
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57869740
       call      qword ptr [7FFD571C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2559EDF0F48
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,2559EDF0EB8
       mov       [rsp+38],rcx
       mov       rcx,2559EDF0EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFD571C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,215200001F0
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
       mov       rdx,2150A000A10
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
       mov       rcx,7FFD578AFA10
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
       mov       rcx,7FFD578AFA14
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
       jmp       qword ptr [7FFD5733FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
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
       call      qword ptr [7FFD57875E30]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFD57875E48]
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
       call      qword ptr [7FFD57875E60]
       int       3
M00_L09:
       mov       r11,7FFD57100A20
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57100A18
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5784CA70
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2455B1D0F40
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,2455B1D0EB8
       mov       [rsp+30],rcx
       mov       rcx,2455B1D0EE8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFD571B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,204DC0001F0
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
       mov       rdx,204C6000A10
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
       mov       rcx,7FFD5789EF88
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
       mov       rcx,7FFD5789EF8C
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
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
       call      qword ptr [7FFD57865E00]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFD57865E18]
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
       call      qword ptr [7FFD57865E30]
       int       3
M00_L09:
       mov       r11,7FFD570F0A28
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A20
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5783CA80
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2982B600F50
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,2982B600EB8
       mov       [rsp+30],rcx
       mov       rcx,2982B600EE8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,257AC8001F0
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
       mov       rdx,25796800A10
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
       mov       rcx,7FFD5788EF88
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
       mov       rcx,7FFD5788EF8C
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E30]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFD57875E48]
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
       call      qword ptr [7FFD57875E60]
       int       3
M00_L09:
       mov       r11,7FFD570F0A28
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A20
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849DC0
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,271A9880F40
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,271A9880EB8
       mov       [rsp+38],rcx
       mov       rcx,271A9880EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2312A8001F0
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
       mov       rdx,23114800A10
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
       mov       rcx,7FFD5788FA10
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
       mov       rcx,7FFD5788FA14
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E18]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFD57875E30]
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
       call      qword ptr [7FFD57875E48]
       int       3
M00_L09:
       mov       r11,7FFD57100A20
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57100A18
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5784CA70
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,246E6700F58
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,246E6700EB8
       mov       [rsp+38],rcx
       mov       rcx,246E6700EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFD571B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,206678001F0
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
       mov       rdx,20651800A10
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
       mov       rcx,7FFD5789EFC0
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
       mov       rcx,7FFD5789EFC4
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
       mov       rsi,[rcx+1A8]
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
       call      qword ptr [7FFD57895E18]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFD57895E30]
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
       call      qword ptr [7FFD57895E48]
       int       3
M00_L09:
       mov       r11,7FFD57120A20
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57120A18
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD5786CA80
       call      qword ptr [7FFD571D5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,26A822B0F70
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       rcx,26A822B0EB8
       mov       [rsp+30],rcx
       mov       rcx,26A822B0EF0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct
       call      qword ptr [7FFD571D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,26B160001F0
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
       mov       rdx,26B00000A10
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
       mov       rcx,7FFD578BEFC0
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
       mov       rcx,7FFD578BEFC4
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
       jmp       qword ptr [7FFD5734FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57885E60]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFD57885E78]
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
       call      qword ptr [7FFD57885E90]
       int       3
M00_L09:
       mov       r11,7FFD57100A20
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD57100A18
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57859740
       call      qword ptr [7FFD571B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2C2EF340F80
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       rcx,2C2EF340EB8
       mov       [rsp+38],rcx
       mov       rcx,2C2EF340EF0
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct
       call      qword ptr [7FFD571B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,282704001F0
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
       mov       rdx,2825A400A10
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
       mov       rcx,7FFD5789FA10
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
       mov       rcx,7FFD5789FA14
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
       jmp       qword ptr [7FFD5732FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFD57875E60]
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
       call      qword ptr [7FFD57875E78]
       int       3
M00_L09:
       mov       r11,7FFD570F0A28
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A20
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849DC0
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,22B31EE0F38
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,22B31EE0EB8
       mov       [rsp+38],rcx
       mov       rcx,22B31EE0EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1EAB30001F0
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
       mov       rdx,1EA9D000A10
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
       mov       rcx,7FFD5788FA10
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
       mov       rcx,7FFD5788FA14
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFD57875E60]
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
       call      qword ptr [7FFD57875E78]
       int       3
M00_L09:
       mov       r11,7FFD570F0A28
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A20
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849DB0
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,26055050F48
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,26055050EB8
       mov       [rsp+38],rcx
       mov       rcx,26055050EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,21FD60001F0
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
       mov       rdx,21FC0000A10
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
       mov       rcx,7FFD5788FA48
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
       mov       rcx,7FFD5788FA4C
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E60]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFD57875E78]
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
       call      qword ptr [7FFD57875E90]
       int       3
M00_L09:
       mov       r11,7FFD570F0A20
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A18
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849740
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1CBAD3D0F50
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,1CBAD3D0EB8
       mov       [rsp+38],rcx
       mov       rcx,1CBAD3D0EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,18B2E4001F0
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
       mov       rdx,18B18400A10
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
       mov       rcx,7FFD5788FA10
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
       mov       rcx,7FFD5788FA14
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+1B0]
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
       call      qword ptr [7FFD57875E48]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFD57875E60]
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
       call      qword ptr [7FFD57875E78]
       int       3
M00_L09:
       mov       r11,7FFD570F0A20
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFD570F0A18
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFD57849740
       call      qword ptr [7FFD571A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,302D1220F38
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,302D1220EB8
       mov       [rsp+38],rcx
       mov       rcx,302D1220EE8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFD571A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2C2524001F0
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
       mov       rdx,2C23C400A10
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
       mov       rcx,7FFD5788FA00
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
       mov       rcx,7FFD5788FA04
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
       jmp       qword ptr [7FFD5731FFD8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

