## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF840]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB4EAEF870]
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
       call      qword ptr [7FFB4EAEF888]
       int       3
M00_L09:
       mov       r11,7FFB4E310B58
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B50
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB86040
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,183CE530A08
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,183CE530988
       mov       [rsp+38],rcx
       mov       rcx,183CE5309B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1434F400120
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
       mov       rdx,14339400A10
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
       mov       rcx,7FFB4EBF6DD0
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
       mov       rcx,7FFB4EBF6DD4
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,2C5BB001A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,3064FFD0988
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB8A2F8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,2C5BB002118
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
       mov       rdx,7FFB4E886C28
       call      qword ptr [7FFB4E647738]
       mov       rcx,rax
       call      qword ptr [7FFB4EBA6460]
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
       mov       r9,2C5BB000A10
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,23290001A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,27325150988
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB7A0F8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   ymm0,ymmword ptr [rsp+60]
       vmovdqu   ymmword ptr [rsp+30],ymm0
       mov       [rsp+20],r8
       mov       r8,23290002118
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
       mov       rdx,7FFB4E876C28
       call      qword ptr [7FFB4E637738]
       mov       rcx,rax
       call      qword ptr [7FFB4EB96460]
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
       mov       r9,23290000A10
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
       jmp       qword ptr [7FFB4E55FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,21C7D801A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,25D12900960
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB95E40
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,21C7D802110
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
       mov       rdx,7FFB4E896C28
       call      qword ptr [7FFB4E657738]
       mov       rcx,rax
       call      qword ptr [7FFB4EBB6460]
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
       mov       r9,21C7D800A10
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
       jmp       qword ptr [7FFB4E57FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,218B8C01A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,2594D9D0988
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EBA6430
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,218B8C02118
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
       mov       rdx,7FFB4E8A6C28
       call      qword ptr [7FFB4E667738]
       mov       rcx,rax
       call      qword ptr [7FFB4EBC6430]
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
       mov       r9,218B8C00A10
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
       jmp       qword ptr [7FFB4E58FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,21D10001A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,25DA4F50988
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB6A0E8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,21D10002118
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
       mov       rdx,7FFB4E866C28
       call      qword ptr [7FFB4E627738]
       mov       rcx,rax
       call      qword ptr [7FFB4EB86418]
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
       mov       r9,21D10000A10
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
       jmp       qword ptr [7FFB4E54FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,1F0ED801A80
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+68],rdx
       mov       rdx,23182770988
       mov       [rsp+78],rdx
       mov       [rsp+70],rcx
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB8AF68
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       dword ptr [rsp+60],64
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+38],ymm0
       mov       [rsp+20],rsi
       mov       r8,1F0ED802118
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
       mov       rdx,7FFB4E886C28
       call      qword ptr [7FFB4E647738]
       mov       rcx,rax
       call      qword ptr [7FFB4EBA64A8]
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
       mov       r9,1F0ED800A10
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAFF840]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFB4EAFF870]
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
       call      qword ptr [7FFB4EAFF888]
       int       3
M00_L09:
       mov       r11,7FFB4E320B58
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E320B50
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB96040
       call      qword ptr [7FFB4E3D5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2A213640A18
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,2A213640988
       mov       [rsp+30],rcx
       mov       rcx,2A2136409C0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFB4E3D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2617E802118
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
       mov       rdx,2617E800A10
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
       mov       rcx,7FFB4EC07450
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
       mov       rcx,7FFB4EC07454
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
       jmp       qword ptr [7FFB4E57FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF840]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFB4EAEF870]
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
       call      qword ptr [7FFB4EAEF888]
       int       3
M00_L09:
       mov       r11,7FFB4E310B48
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B40
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB86040
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,2701A800A28
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,2701A800988
       mov       [rsp+30],rcx
       mov       rcx,2701A8009C0
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,22F9B800120
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
       mov       rdx,22F85800A10
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
       mov       rcx,7FFB4EBF65D8
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
       mov       rcx,7FFB4EBF65DC
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EB0F960]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFB4EB0F990]
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
       call      qword ptr [7FFB4EB0F9A8]
       int       3
M00_L09:
       mov       r11,7FFB4E330B48
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E330B40
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EBA71B0
       call      qword ptr [7FFB4E3E5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2AF04C48290
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,2AF04C50988
       mov       [rsp+38],rcx
       mov       rcx,2AF04C509B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFB4E3E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,26E6FC02118
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
       mov       rdx,26E6FC00A10
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
       mov       rcx,7FFB4EC17450
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
       mov       rcx,7FFB4EC17454
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
       jmp       qword ptr [7FFB4E58FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EACF930]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFB4EACF960]
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
       call      qword ptr [7FFB4EACF978]
       int       3
M00_L09:
       mov       r11,7FFB4E2F0B58
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E2F0B50
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB6A0F0
       call      qword ptr [7FFB4E3A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,28E4DF98290
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,28E4DFA0988
       mov       [rsp+38],rcx
       mov       rcx,28E4DFA09B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFB4E3A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,24DCF000120
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
       mov       rdx,24DB9000A10
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
       mov       rcx,7FFB4EBD6F40
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
       mov       rcx,7FFB4EBD6F44
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
       jmp       qword ptr [7FFB4E54FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EACF828]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB4EACF858]
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
       call      qword ptr [7FFB4EACF870]
       int       3
M00_L09:
       mov       r11,7FFB4E2F0B48
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E2F0B40
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB66040
       call      qword ptr [7FFB4E3A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2EB11D90A18
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,2EB11D90988
       mov       [rsp+38],rcx
       mov       rcx,2EB11D909B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFB4E3A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2AA7CC02118
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
       mov       rdx,2AA7CC00A10
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
       mov       rcx,7FFB4EBD6DD8
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
       mov       rcx,7FFB4EBD6DDC
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
       jmp       qword ptr [7FFB4E54FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF900]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB4EAEF930]
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
       call      qword ptr [7FFB4EAEF948]
       int       3
M00_L09:
       mov       r11,7FFB4E310B58
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B50
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB89F08
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,28A4BC50A10
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,28A4BC50988
       mov       [rsp+30],rcx
       mov       rcx,28A4BC509B8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,249B6C02118
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
       mov       rdx,249B6C00A10
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
       mov       rcx,7FFB4EBF6538
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
       mov       rcx,7FFB4EBF653C
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EACF918]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB4EACF948]
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
       call      qword ptr [7FFB4EACF960]
       int       3
M00_L09:
       mov       r11,7FFB4E2F0B58
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E2F0B50
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB69F08
       call      qword ptr [7FFB4E3A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1AB50960A20
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,1AB50960988
       mov       [rsp+30],rcx
       mov       rcx,1AB509609B8
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFB4E3A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16ABB802118
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
       mov       rdx,16ABB800A10
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
       mov       rcx,7FFB4EBD6928
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
       mov       rcx,7FFB4EBD692C
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
       jmp       qword ptr [7FFB4E54FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EADF840]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFB4EADF870]
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
       call      qword ptr [7FFB4EADF888]
       int       3
M00_L09:
       mov       r11,7FFB4E300B58
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E300B50
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB76040
       call      qword ptr [7FFB4E3B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2418B100A10
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,2418B100988
       mov       [rsp+38],rcx
       mov       rcx,2418B1009B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFB4E3B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2010C000120
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
       mov       rdx,200F6000A10
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
       mov       rcx,7FFB4EBE74C0
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
       mov       rcx,7FFB4EBE74C4
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
       jmp       qword ptr [7FFB4E55FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAFF840]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFB4EAFF870]
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
       call      qword ptr [7FFB4EAFF888]
       int       3
M00_L09:
       mov       r11,7FFB4E320B58
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E320B50
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB96040
       call      qword ptr [7FFB4E3D5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2FA06FE0A28
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,2FA06FE0988
       mov       [rsp+38],rcx
       mov       rcx,2FA06FE09B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFB4E3D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2B972002118
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
       mov       rdx,2B972000A10
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
       mov       rcx,7FFB4EC07488
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
       mov       rcx,7FFB4EC0748C
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
       jmp       qword ptr [7FFB4E57FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EADF900]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFB4EADF930]
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
       call      qword ptr [7FFB4EADF948]
       int       3
M00_L09:
       mov       r11,7FFB4E300B58
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E300B50
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB7A538
       call      qword ptr [7FFB4E3B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,17F84040A18
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       rcx,17F84040960
       mov       [rsp+30],rcx
       mov       rcx,17F84040998
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct
       call      qword ptr [7FFB4E3B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,13EEF002110
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
       mov       rdx,13EEF000A10
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
       mov       rcx,7FFB4EBE73E0
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
       mov       rcx,7FFB4EBE73E4
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
       jmp       qword ptr [7FFB4E55FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAFF750]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFB4EAFF780]
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
       call      qword ptr [7FFB4EAFF798]
       int       3
M00_L09:
       mov       r11,7FFB4E320B48
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E320B40
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB95A40
       call      qword ptr [7FFB4E3D5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1F287AF0A28
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       rcx,1F287AF0960
       mov       [rsp+38],rcx
       mov       rcx,1F287AF0998
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct
       call      qword ptr [7FFB4E3D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1B1F2C02110
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
       mov       rdx,1B1F2C00A10
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
       mov       rcx,7FFB4EC06DD8
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
       mov       rcx,7FFB4EC06DDC
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
       jmp       qword ptr [7FFB4E57FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF7F8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFB4EAEF828]
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
       call      qword ptr [7FFB4EAEF840]
       int       3
M00_L09:
       mov       r11,7FFB4E310B58
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B50
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB86040
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,30A50510A08
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,30A50510988
       mov       [rsp+38],rcx
       mov       rcx,30A505109B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2C9BB402118
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
       mov       rdx,2C9BB400A10
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
       mov       rcx,7FFB4EBF6DD8
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
       mov       rcx,7FFB4EBF6DDC
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EACFA80]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFB4EACFAB0]
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
       call      qword ptr [7FFB4EACFAC8]
       int       3
M00_L09:
       mov       r11,7FFB4E2F0B58
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E2F0B50
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB6AB78
       call      qword ptr [7FFB4E3A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1D4E6C20A18
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,1D4E6C20988
       mov       [rsp+38],rcx
       mov       rcx,1D4E6C209B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFB4E3A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,19467C00120
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
       mov       rdx,19451C00A10
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
       mov       rcx,7FFB4EBD6DD8
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
       mov       rcx,7FFB4EBD6DDC
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
       jmp       qword ptr [7FFB4E54FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF900]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFB4EAEF930]
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
       call      qword ptr [7FFB4EAEF948]
       int       3
M00_L09:
       mov       r11,7FFB4E310B58
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B50
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB89CF8
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,25EC13E0A08
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,25EC13E0988
       mov       [rsp+38],rcx
       mov       rcx,25EC13E09B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,21E42400120
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
       mov       rdx,21E2C400A10
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
       mov       rcx,7FFB4EBF6538
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
       mov       rcx,7FFB4EBF653C
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       call      qword ptr [7FFB4EAEF918]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFB4EAEF948]
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
       call      qword ptr [7FFB4EAEF960]
       int       3
M00_L09:
       mov       r11,7FFB4E310B48
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFB4E310B40
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB4EB89CF8
       call      qword ptr [7FFB4E3C5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1FFF68B0A20
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,1FFF68B0988
       mov       [rsp+38],rcx
       mov       rcx,1FFF68B09B8
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFB4E3C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1BF61802118
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
       mov       rdx,1BF61800A10
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
       mov       rcx,7FFB4EBF6928
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
       mov       rcx,7FFB4EBF692C
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
       jmp       qword ptr [7FFB4E56FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFB4E3C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

