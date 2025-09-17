## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF450]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFE779CF480]
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
       call      qword ptr [7FFE779CF498]
       int       3
M00_L09:
       mov       r11,7FFE77200AE0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE77200AD8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A6E2F0
       call      qword ptr [7FFE772B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,226484A03E0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,226484A0360
       mov       [rsp+38],rcx
       mov       rcx,226484A0390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1E5B34020E8
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
       mov       rdx,1E5B3400A10
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
       mov       rcx,7FFE77AD7DC8
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
       mov       rcx,7FFE77AD7DCC
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
       jmp       qword ptr [7FFE7745FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,186FA801A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,1C78FAA0360
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A3E6D0
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+70]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       mov       r8,187108000F0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,5
       call      rax
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77752340
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE779974B0]
       int       3
; Total bytes of code 245
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
       mov       r9,186FA800A10
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
       jmp       qword ptr [7FFE7742FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       rbx,[rcx+138]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,1FCF7C01A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+58],rdx
       mov       rdx,23D8CA90360
       mov       [rsp+68],rdx
       mov       [rsp+60],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5E6D0
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+48],r8
       mov       dword ptr [rsp+50],64
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       mov       r8,[rsp+68]
       mov       [rsp+40],r8
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,1FCF7C020E8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       edx,1
       call      rax
       nop
       add       rsp,70
       pop       rbx
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77772340
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE779B74C8]
       int       3
; Total bytes of code 227
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
       mov       r9,1FCF7C00A10
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,204BC401A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,24551500338
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A3A0D8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+70]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       mov       r8,204D24000E8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,4
       call      rax
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77752340
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE779A74C8]
       int       3
; Total bytes of code 242
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
       mov       r9,204BC400A10
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
       jmp       qword ptr [7FFE7742FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,21267801A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,252FC850360
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A6A6C8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+70]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       mov       r8,212678020E8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       call      rax
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77782340
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE779C74C8]
       int       3
; Total bytes of code 245
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
       mov       r9,21267800A10
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
       jmp       qword ptr [7FFE7745FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,2236D001A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,26402350360
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A4A6C8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+70]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       mov       r8,2236D0020E8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       xor       edx,edx
       call      rax
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77762340
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE779A74B0]
       int       3
; Total bytes of code 242
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
       mov       r9,2236D000A10
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
       jmp       qword ptr [7FFE7743FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningILoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,[rcx+138]
       mov       rsi,[rcx+140]
       test      rbx,rbx
       je        near ptr M00_L00
       mov       rcx,17065001A68
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+60],rdx
       mov       rdx,1B0FA040360
       mov       [rsp+70],rdx
       mov       [rsp+68],rcx
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5D578
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],64
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+70]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       mov       r8,170650020E8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+50]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,3
       call      rax
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1BF
       mov       rdx,7FFE77772340
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE779C7390]
       int       3
; Total bytes of code 245
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
       mov       r9,17065000A10
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779BF498]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFE779BF4C8]
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
       call      qword ptr [7FFE779BF4E0]
       int       3
M00_L09:
       mov       r11,7FFE771F0B80
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0B78
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5E2F0
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,17691C703F0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,17691C70360
       mov       [rsp+30],rcx
       mov       rcx,17691C70398
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,13612C000F8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       rcx,rbx
       mov       [rsp+20],rsi
       mov       edx,5
       call      rdi
       jmp       near ptr M00_L04
; Total bytes of code 448
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
       mov       rdx,135FCC00A10
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
       mov       rcx,7FFE77AAA270
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
       mov       rcx,7FFE77AAA274
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779C7810]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFE779C7840]
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
       call      qword ptr [7FFE779C7858]
       int       3
M00_L09:
       mov       r11,7FFE772009A8
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE772009A0
       mov       edx,5
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A297D0
       call      qword ptr [7FFE772B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1C0B6F30400
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       rcx,1C0B6F30360
       mov       [rsp+30],rcx
       mov       rcx,1C0B6F30398
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,18037C000C8
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
       call      qword ptr [7FFED6CEFC20]
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE7799EE80]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFE7799EEB0]
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
       call      qword ptr [7FFE7799EEC8]
       int       3
M00_L09:
       mov       r11,7FFE771E0AF0
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771E0AE8
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A36B98
       call      qword ptr [7FFE77295920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,17A640E8340
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,17A640F0360
       mov       [rsp+38],rcx
       mov       rcx,17A640F0390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFE77295728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,139E50000F0
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
       mov       rdx,139CF000A10
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
       mov       rcx,7FFE77AC82D8
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
       mov       rcx,7FFE77AC82DC
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
       jmp       qword ptr [7FFE7743FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE77295C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779BF240]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFE779BF270]
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
       call      qword ptr [7FFE779BF288]
       int       3
M00_L09:
       mov       r11,7FFE771E0AF0
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771E0AE8
       mov       edx,1
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A4CBF8
       call      qword ptr [7FFE77295920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1AB9C3A8340
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       rcx,1AB9C3B0338
       mov       [rsp+38],rcx
       mov       rcx,1AB9C3B0368
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct
       call      qword ptr [7FFE77295728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16B0BC000E8
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
       mov       rdx,16B07400A10
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
       mov       rcx,7FFE77AB7560
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
       mov       rcx,7FFE77AB7564
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
       jmp       qword ptr [7FFE7743FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE77295C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779977F8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFE77997828]
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
       call      qword ptr [7FFE77997840]
       int       3
M00_L09:
       mov       r11,7FFE771D09A8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771D09A0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE779F97D0
       call      qword ptr [7FFE77285920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,20C2B6B03F0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       rcx,20C2B6B0360
       mov       [rsp+38],rcx
       mov       rcx,20C2B6B0390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct
       call      qword ptr [7FFE77285728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1CB968020C0
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
       call      qword ptr [7FFED6CEFC20]
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
       jmp       qword ptr [7FFE77285C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779A77F8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFE779A7828]
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
       call      qword ptr [7FFE779A7840]
       int       3
M00_L09:
       mov       r11,7FFE771E09A8
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771E09A0
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A097D0
       call      qword ptr [7FFE77295920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,23739FD03E8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,23739FD0360
       mov       [rsp+30],rcx
       mov       rcx,23739FD0390
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFE77295728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1F6A4C020C0
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
       call      qword ptr [7FFED6CEFC20]
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
       jmp       qword ptr [7FFE77295C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779DF390]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFE779DF3C0]
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
       call      qword ptr [7FFE779DF3D8]
       int       3
M00_L09:
       mov       r11,7FFE77200AF0
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE77200AE8
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A6A2E8
       call      qword ptr [7FFE772B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,288AEF003F8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       rcx,288AEF00360
       mov       [rsp+30],rcx
       mov       rcx,288AEF00390
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2481A0020E8
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
       mov       rdx,2481A000A10
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
       mov       rcx,7FFE77AD7DC8
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
       mov       rcx,7FFE77AD7DCC
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
       jmp       qword ptr [7FFE7745FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF450]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFE779CF480]
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
       call      qword ptr [7FFE779CF498]
       int       3
M00_L09:
       mov       r11,7FFE77200AE0
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE77200AD8
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A6E398
       call      qword ptr [7FFE772B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1D5FAC603E8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,1D5FAC60360
       mov       [rsp+38],rcx
       mov       rcx,1D5FAC60390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1957BC000F0
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
       mov       rdx,19565C00A10
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
       mov       rcx,7FFE77AD7D90
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
       mov       rcx,7FFE77AD7D94
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
       jmp       qword ptr [7FFE7745FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE7799EA90]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFE7799EAC0]
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
       call      qword ptr [7FFE7799EAD8]
       int       3
M00_L09:
       mov       r11,7FFE771F0AF0
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0AE8
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A35970
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,32CA6690400
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       rcx,32CA6690360
       mov       [rsp+38],rcx
       mov       rcx,32CA6690390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2EC278000D0
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
       mov       rdx,2EC11800A10
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
       mov       rcx,7FFE77ABF378
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
       mov       rcx,7FFE77ABF37C
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF420]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFE779CF450]
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
       call      qword ptr [7FFE779CF468]
       int       3
M00_L09:
       mov       r11,7FFE771F0AF8
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0AF0
       mov       edx,4
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5E2F0
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,273A5490418
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       rcx,273A5490360
       mov       [rsp+30],rcx
       mov       rcx,273A5490398
       mov       [rsp+38],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,233104020E8
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
       mov       rdx,23310400A10
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
       mov       rcx,7FFE77AC7E78
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
       mov       rcx,7FFE77AC7E7C
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF318]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFE779CF348]
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
       call      qword ptr [7FFE779CF360]
       int       3
M00_L09:
       mov       r11,7FFE771F0AF0
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0AE8
       mov       edx,4
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5D870
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,20F3C2D0428
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       rcx,20F3C2D0360
       mov       [rsp+38],rcx
       mov       rcx,20F3C2D0398
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1CEBD0000F0
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
       mov       rdx,1CEA7000A10
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
       mov       rcx,7FFE77AC7B58
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
       mov       rcx,7FFE77AC7B5C
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE7799F288]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFE7799F2B8]
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
       call      qword ptr [7FFE7799F2D0]
       int       3
M00_L09:
       mov       r11,7FFE771D0AF0
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771D0AE8
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A33978
       call      qword ptr [7FFE77285920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,1EE421E03E0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,1EE421E0360
       mov       [rsp+38],rcx
       mov       rcx,1EE421E0390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFE77285728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1ADC30000F0
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
       mov       rdx,1ADAD000A10
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
       mov       rcx,7FFE77A9F9B8
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
       mov       rcx,7FFE77A9F9BC
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
       jmp       qword ptr [7FFE7742FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE77285C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779AED90]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFE779AEDC0]
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
       call      qword ptr [7FFE779AEDD8]
       int       3
M00_L09:
       mov       r11,7FFE771F0AE0
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0AD8
       xor       edx,edx
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A42B28
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,25EBB9103F0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       rcx,25EBB910360
       mov       [rsp+38],rcx
       mov       rcx,25EBB910390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,21E3C8000F0
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
       mov       rdx,21E26800A10
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
       mov       rcx,7FFE77AD63C8
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
       mov       rcx,7FFE77AD63CC
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF2A0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFE779CF2D0]
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
       call      qword ptr [7FFE779CF2E8]
       int       3
M00_L09:
       mov       r11,7FFE77200AF0
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE77200AE8
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A63978
       call      qword ptr [7FFE772B5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,260D8C303E0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,260D8C30360
       mov       [rsp+38],rcx
       mov       rcx,260D8C30390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,22059C000F0
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
       mov       rdx,22043C00A10
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
       mov       rcx,7FFE77AD8428
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
       mov       rcx,7FFE77AD842C
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
       jmp       qword ptr [7FFE7745FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE779CF450]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFE779CF480]
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
       call      qword ptr [7FFE779CF498]
       int       3
M00_L09:
       mov       r11,7FFE771F0AE0
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L03
M00_L10:
       mov       rcx,rbx
       mov       r11,7FFE771F0AD8
       mov       edx,3
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE77A5E398
       call      qword ptr [7FFE772A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rsi,rax
       mov       rcx,2B791E803F8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],258
       mov       rcx,2B791E80360
       mov       [rsp+38],rcx
       mov       rcx,2B791E80390
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,276FCC020E8
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
       mov       rdx,276FCC00A10
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
       mov       rcx,7FFE77AC7DC8
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
       mov       rcx,7FFE77AC7DCC
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
       jmp       qword ptr [7FFE7744FEE8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

