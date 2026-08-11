## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark.CopyToAsyncPooledCustomBuffer()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-48],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFAE0A0FC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-50],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-60],rdx
       lea       rcx,[rbp-48]
       call      qword ptr [7FFAE0DBE448]; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<CopyToAsyncPooledCustomBuffer>d__1.MoveNext()
       nop
       mov       rdx,[rbp-60]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-58],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E37258]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFAE0E34F78]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFAE0E36328]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-60]
       mov       rax,[rbp-50]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-50]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-58],0
       je        short M00_L13
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E37258]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 374
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFAE0E35DB8]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFB0FB3AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFB0FB38FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<CopyToAsyncPooledCustomBuffer>d__1.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+18]
       mov       [rbp-1C],eax
       mov       rbx,[rcx]
       cmp       dword ptr [rbp-1C],0
       je        short M03_L00
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,17053C00D48
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,200000002000
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+29],0
       mov       byte ptr [rsi+2B],1
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L00:
       cmp       dword ptr [rbp-1C],0
       je        short M03_L01
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1B0E8D46D78
       mov       [rax+10],rcx
       xor       ecx,ecx
       mov       [rax+24],ecx
       mov       dword ptr [rax+28],1010101
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L01:
       cmp       dword ptr [rbp-1C],0
       je        near ptr M03_L16
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       [rbp-60],r8
       mov       [rbp-90],rax
       mov       [rbp-88],rdx
       mov       dword ptr [rbp-6C],1000
       mov       [rbp-58],r8
       mov       dword ptr [rbp-70],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L13
M03_L02:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L03
       call      qword ptr [7FFAE0A0FC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L03:
       mov       [rbp-98],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0A0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAE0DBE7C0]; DotNetTips.Spargine.Extensions.StreamExtensions+<CopyToAsyncPooled>d__2.MoveNext()
       nop
       mov       rdx,[rbp-0A8]
       cmp       rdx,[rsi+10]
       je        short M03_L04
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0A0]
       cmp       rdx,rdi
       je        short M03_L06
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L05
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L12
M03_L05:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L11
M03_L06:
       mov       rax,[rbp-60]
       test      rax,rax
       je        near ptr M03_L14
M03_L07:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L15
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L17
M03_L09:
       mov       rax,[rbp-30]
       mov       rax,[rax+38]
       mov       rdx,[rbx+88]
       mov       [rdx+18],rax
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       [rax],rdx
       jne       near ptr M03_L19
       cmp       byte ptr [rax+2B],0
       je        near ptr M03_L18
       mov       edx,[rax+20]
       sub       edx,[rax+18]
       movsxd    rsi,edx
M03_L10:
       mov       rax,[rbx+88]
       mov       [rax+18],rsi
       jmp       near ptr M03_L20
M03_L11:
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L06
M03_L12:
       mov       rcx,rdi
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFAE0E37258]
       jmp       near ptr M03_L06
M03_L13:
       mov       ecx,4
       call      qword ptr [7FFAE0E34F78]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L02
M03_L14:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFAE0E362F8]
       jmp       near ptr M03_L07
M03_L15:
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rsi,[rbp+10]
       mov       [rsi+18],ecx
       lea       rcx,[rsi+28]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       [rsi+30],edx
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       call      qword ptr [7FFAE0E372A0]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFAE0E372B8]
       jmp       short M03_L21
M03_L16:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+28]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+28],rdx
       mov       [rcx+30],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+18],0FFFFFFFF
       jmp       near ptr M03_L08
M03_L17:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFAE0E35DB8]
       jmp       near ptr M03_L09
M03_L18:
       xor       ecx,ecx
       call      qword ptr [7FFAE0E34C18]
       int       3
M03_L19:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M03_L10
M03_L20:
       call      M03_L31
       jmp       short M03_L22
M03_L21:
       call      M03_L31
       jmp       short M03_L23
M03_L22:
       call      M03_L34
       jmp       short M03_L24
M03_L23:
       call      M03_L34
       jmp       short M03_L25
M03_L24:
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       short M03_L26
       mov       rdx,17053C00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L25:
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L26:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFAE0E36310]
       jmp       short M03_L25
       sub       rsp,28
       mov       rdx,[rbp-0A8]
       mov       rax,[rbp-98]
       cmp       rdx,[rax+10]
       je        short M03_L27
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
M03_L27:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0A0]
       cmp       rdx,rbx
       je        short M03_L30
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L28
       cmp       qword ptr [rbx+10],0
       jne       short M03_L29
M03_L28:
       cmp       qword ptr [rbp-0A0],0
       je        short M03_L30
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L30
M03_L29:
       mov       rcx,rbx
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFAE0E37258]
M03_L30:
       nop
       add       rsp,28
       ret
M03_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L32
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M03_L32
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L33
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L32
       call      00007FFB4039D4D0
       nop
M03_L32:
       add       rsp,28
       ret
M03_L33:
       mov       r11,7FFAE06C0AA0
       call      qword ptr [r11]
       jmp       short M03_L32
M03_L34:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L35
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M03_L35
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L36
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L35
       call      00007FFB4039D4D0
       nop
M03_L35:
       add       rsp,28
       ret
M03_L36:
       mov       r11,7FFAE06C0AA8
       call      qword ptr [r11]
       jmp       short M03_L35
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       call      qword ptr [7FFAE0DBE580]
       lea       rax,[M03_L25]
       add       rsp,28
       ret
; Total bytes of code 1287
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB0FB51D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark.CopyToAsyncPooledDefaultBuffer()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-48],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFAE09DFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-50],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-60],rdx
       lea       rcx,[rbp-48]
       call      qword ptr [7FFAE0D8E430]; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<CopyToAsyncPooledDefaultBuffer>d__2.MoveNext()
       nop
       mov       rdx,[rbp-60]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-58],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E075E8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFAE0E05500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFAE0E066A0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-60]
       mov       rax,[rbp-50]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-50]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-58],0
       je        short M00_L13
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E075E8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 374
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFAE0E062B0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFB0FB3AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFB0FB38FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<CopyToAsyncPooledDefaultBuffer>d__2.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+18]
       mov       [rbp-1C],eax
       mov       rbx,[rcx]
       cmp       dword ptr [rbp-1C],0
       je        short M03_L00
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,21D86000D48
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,200000002000
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+29],0
       mov       byte ptr [rsi+2B],1
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L00:
       cmp       dword ptr [rbp-1C],0
       je        short M03_L01
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,25E1B186D78
       mov       [rax+10],rcx
       xor       ecx,ecx
       mov       [rax+24],ecx
       mov       dword ptr [rax+28],1010101
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L01:
       cmp       dword ptr [rbp-1C],0
       je        near ptr M03_L16
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       [rbp-60],r8
       mov       [rbp-90],rax
       mov       [rbp-88],rdx
       mov       dword ptr [rbp-6C],14000
       mov       [rbp-58],r8
       mov       dword ptr [rbp-70],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L13
M03_L02:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L03
       call      qword ptr [7FFAE09DFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L03:
       mov       [rbp-98],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0A0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAE0D8E7C0]; DotNetTips.Spargine.Extensions.StreamExtensions+<CopyToAsyncPooled>d__2.MoveNext()
       nop
       mov       rdx,[rbp-0A8]
       cmp       rdx,[rsi+10]
       je        short M03_L04
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0A0]
       cmp       rdx,rdi
       je        short M03_L06
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L05
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L12
M03_L05:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L11
M03_L06:
       mov       rax,[rbp-60]
       test      rax,rax
       je        near ptr M03_L14
M03_L07:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L15
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L17
M03_L09:
       mov       rax,[rbp-30]
       mov       rax,[rax+38]
       mov       rdx,[rbx+88]
       mov       [rdx+18],rax
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       [rax],rdx
       jne       near ptr M03_L19
       cmp       byte ptr [rax+2B],0
       je        near ptr M03_L18
       mov       edx,[rax+20]
       sub       edx,[rax+18]
       movsxd    rsi,edx
M03_L10:
       mov       rax,[rbx+88]
       mov       [rax+18],rsi
       jmp       near ptr M03_L20
M03_L11:
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L06
M03_L12:
       mov       rcx,rdi
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFAE0E075E8]
       jmp       near ptr M03_L06
M03_L13:
       mov       ecx,4
       call      qword ptr [7FFAE0E05500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L02
M03_L14:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFAE0E06670]
       jmp       near ptr M03_L07
M03_L15:
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rsi,[rbp+10]
       mov       [rsi+18],ecx
       lea       rcx,[rsi+28]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       [rsi+30],edx
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       call      qword ptr [7FFAE0E07630]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFAE0E07648]
       jmp       short M03_L21
M03_L16:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+28]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+28],rdx
       mov       [rcx+30],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+18],0FFFFFFFF
       jmp       near ptr M03_L08
M03_L17:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFAE0E062B0]
       jmp       near ptr M03_L09
M03_L18:
       xor       ecx,ecx
       call      qword ptr [7FFAE0E051A0]
       int       3
M03_L19:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M03_L10
M03_L20:
       call      M03_L31
       jmp       short M03_L22
M03_L21:
       call      M03_L31
       jmp       short M03_L23
M03_L22:
       call      M03_L34
       jmp       short M03_L24
M03_L23:
       call      M03_L34
       jmp       short M03_L25
M03_L24:
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       short M03_L26
       mov       rdx,21D86000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L25:
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L26:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFAE0E06688]
       jmp       short M03_L25
       sub       rsp,28
       mov       rdx,[rbp-0A8]
       mov       rax,[rbp-98]
       cmp       rdx,[rax+10]
       je        short M03_L27
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
M03_L27:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0A0]
       cmp       rdx,rbx
       je        short M03_L30
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L28
       cmp       qword ptr [rbx+10],0
       jne       short M03_L29
M03_L28:
       cmp       qword ptr [rbp-0A0],0
       je        short M03_L30
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L30
M03_L29:
       mov       rcx,rbx
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFAE0E075E8]
M03_L30:
       nop
       add       rsp,28
       ret
M03_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L32
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M03_L32
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L33
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L32
       call      00007FFB4039D4D0
       nop
M03_L32:
       add       rsp,28
       ret
M03_L33:
       mov       r11,7FFAE0690A90
       call      qword ptr [r11]
       jmp       short M03_L32
M03_L34:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L35
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M03_L35
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L36
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L35
       call      00007FFB4039D4D0
       nop
M03_L35:
       add       rsp,28
       ret
M03_L36:
       mov       r11,7FFAE0690A98
       call      qword ptr [r11]
       jmp       short M03_L35
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       call      qword ptr [7FFAE0D8E568]
       lea       rax,[M03_L25]
       add       rsp,28
       ret
; Total bytes of code 1287
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB0FB51D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark.ReadExactlyAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-48],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFAE09FFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-50],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-60],rdx
       lea       rcx,[rbp-48]
       call      qword ptr [7FFAE0DAE3B8]; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<ReadExactlyAsync>d__3.MoveNext()
       nop
       mov       rdx,[rbp-60]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-58],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E370C0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFAE0E352A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFAE0E361A8]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-60]
       mov       rax,[rbp-50]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-50]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-58],0
       je        short M00_L13
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E370C0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 374
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFAE0E36028]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFB0FB3AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFB0FB38FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<ReadExactlyAsync>d__3.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+18]
       mov       [rbp-1C],eax
       mov       rbx,[rcx]
       cmp       dword ptr [rbp-1C],0
       je        short M03_L00
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,11CB0000D48
       mov       rdx,[rcx]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,200000002000
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+29],0
       mov       byte ptr [rsi+2B],1
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L00:
       cmp       dword ptr [rbp-1C],0
       je        near ptr M03_L17
       mov       edx,2000
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M03_L12
       mov       r8d,[rdx+8]
M03_L01:
       xor       r10d,r10d
       mov       [rbp-60],r10
       mov       [rbp-70],rax
       mov       [rbp-58],rdx
       mov       [rbp-50],r10d
       mov       [rbp-4C],r8d
       mov       [rbp-48],r10
       mov       dword ptr [rbp-68],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L13
M03_L02:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L03
       call      qword ptr [7FFAE09FFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L03:
       mov       [rbp-78],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-80],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-88],rdx
       lea       rcx,[rbp-70]
       call      qword ptr [7FFAE0DAE700]; DotNetTips.Spargine.Extensions.StreamExtensions+<ReadExactlyAsync>d__4.MoveNext()
       nop
       mov       rdx,[rbp-88]
       cmp       rdx,[rsi+10]
       je        short M03_L04
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-80]
       cmp       rdx,rdi
       je        short M03_L06
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L05
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L05:
       cmp       qword ptr [rbp-80],0
       jne       near ptr M03_L10
M03_L06:
       mov       rax,[rbp-60]
       test      rax,rax
       je        near ptr M03_L14
M03_L07:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L15
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L18
M03_L09:
       mov       rax,[rbp-30]
       mov       eax,[rax+38]
       mov       rdx,[rbx+88]
       mov       [rdx+38],eax
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L16
       movzx     eax,byte ptr [rax+10]
       mov       rdx,[rbx+88]
       mov       [rdx+4A],al
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-80]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L06
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-80]
       call      qword ptr [7FFAE0E370C0]
       jmp       near ptr M03_L06
M03_L12:
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M03_L01
M03_L13:
       mov       ecx,4
       call      qword ptr [7FFAE0E352A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L02
M03_L14:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFAE0E36160]
       jmp       near ptr M03_L07
M03_L15:
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rsi,[rbp+10]
       mov       [rsi+18],ecx
       lea       rcx,[rsi+28]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       [rsi+30],edx
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       call      qword ptr [7FFAE0E37108]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFAE0E37120]
       jmp       short M03_L20
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L17:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+28]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+28],rdx
       mov       [rcx+30],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+18],0FFFFFFFF
       jmp       near ptr M03_L08
M03_L18:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFAE0E36028]
       jmp       near ptr M03_L09
M03_L19:
       call      M03_L28
       jmp       short M03_L21
M03_L20:
       call      M03_L28
       jmp       short M03_L22
M03_L21:
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       short M03_L23
       mov       rdx,11CB0000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L22:
       nop
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L23:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFAE0E36190]
       jmp       short M03_L22
       sub       rsp,28
       mov       rdx,[rbp-88]
       mov       rax,[rbp-78]
       cmp       rdx,[rax+10]
       je        short M03_L24
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
M03_L24:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-80]
       cmp       rdx,rbx
       je        short M03_L27
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L25
       cmp       qword ptr [rbx+10],0
       jne       short M03_L26
M03_L25:
       cmp       qword ptr [rbp-80],0
       je        short M03_L27
       mov       rdx,[rbp-80]
       cmp       qword ptr [rdx+10],0
       je        short M03_L27
M03_L26:
       mov       rcx,rbx
       mov       rdx,[rbp-80]
       call      qword ptr [7FFAE0E370C0]
M03_L27:
       nop
       add       rsp,28
       ret
M03_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L29
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M03_L29
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L30
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L29
       call      00007FFB4039D4D0
       nop
M03_L29:
       add       rsp,28
       ret
M03_L30:
       mov       r11,7FFAE06B0A00
       call      qword ptr [r11]
       jmp       short M03_L29
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+18],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+20]
       call      qword ptr [7FFAE0DAE508]
       lea       rax,[M03_L22]
       add       rsp,28
       ret
; Total bytes of code 1074
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB0FB51D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark.WriteAllAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-40],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFAE09FFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-48],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-50],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-58],rdx
       lea       rcx,[rbp-40]
       call      qword ptr [7FFAE0DAE4C0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<WriteAllAsync>d__4.MoveNext()
       nop
       mov       rdx,[rbp-58]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-50],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFAE0E36D60]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFAE0E35230]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFAE0E35E30]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-58]
       mov       rax,[rbp-48]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-50],0
       je        short M00_L13
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFAE0E36D60]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFAE0E35D10]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB0FB39038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFB0FB3AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFB0FB38FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StreamExtensionsBenchmark+<WriteAllAsync>d__4.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+10]
       mov       [rbp-1C],eax
       mov       rbx,[rcx]
       cmp       dword ptr [rbp-1C],0
       je        short M03_L00
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,284913B6D78
       mov       [rax+10],rcx
       xor       ecx,ecx
       mov       [rax+24],ecx
       mov       dword ptr [rax+28],1010101
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L00:
       cmp       dword ptr [rbp-1C],0
       je        near ptr M03_L15
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,243FC400D48
       mov       rdx,[rdx]
       xor       r8d,r8d
       mov       [rbp-60],r8
       mov       [rbp-70],rax
       mov       [rbp-58],rdx
       mov       [rbp-50],r8d
       mov       dword ptr [rbp-4C],2000
       mov       [rbp-48],r8
       mov       dword ptr [rbp-68],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L01:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L02
       call      qword ptr [7FFAE09FFC60]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L02:
       mov       [rbp-78],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-80],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-88],rdx
       lea       rcx,[rbp-70]
       call      qword ptr [7FFAE0DAE730]; DotNetTips.Spargine.Extensions.StreamExtensions+<WriteAllAsync>d__5.MoveNext()
       nop
       mov       rdx,[rbp-88]
       cmp       rdx,[rsi+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-80]
       cmp       rdx,rdi
       je        short M03_L05
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L04
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L04:
       cmp       qword ptr [rbp-80],0
       jne       near ptr M03_L10
M03_L05:
       mov       rax,[rbp-60]
       test      rax,rax
       je        near ptr M03_L13
M03_L06:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L14
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L16
M03_L08:
       mov       rax,[rbp-30]
       mov       eax,[rax+38]
       mov       rdx,[rbx+88]
       mov       [rdx+38],eax
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       [rax],rdx
       jne       near ptr M03_L18
       cmp       byte ptr [rax+2B],0
       je        near ptr M03_L17
       mov       edx,[rax+20]
       sub       edx,[rax+18]
       movsxd    rsi,edx
M03_L09:
       mov       rax,[rbx+88]
       mov       [rax+18],rsi
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-80]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L05
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-80]
       call      qword ptr [7FFAE0E36D60]
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,4
       call      qword ptr [7FFAE0E35230]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L01
M03_L13:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFAE0E35DE8]
       jmp       near ptr M03_L06
M03_L14:
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rsi,[rbp+10]
       mov       [rsi+10],ecx
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       [rsi+28],edx
       lea       rdx,[rsi+18]
       mov       rcx,rsi
       call      qword ptr [7FFAE0E36DA8]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFAE0E36DC0]
       jmp       short M03_L20
M03_L15:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+20],rdx
       mov       [rcx+28],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+10],0FFFFFFFF
       jmp       near ptr M03_L07
M03_L16:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFAE0E35D10]
       jmp       near ptr M03_L08
M03_L17:
       xor       ecx,ecx
       call      qword ptr [7FFAE0E34ED0]
       int       3
M03_L18:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M03_L09
M03_L19:
       call      M03_L28
       jmp       short M03_L21
M03_L20:
       call      M03_L28
       jmp       short M03_L22
M03_L21:
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+10],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       lea       rcx,[rsi+18]
       cmp       qword ptr [rcx],0
       jne       short M03_L23
       mov       rdx,243FC400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L22:
       nop
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L23:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFAE0E35E18]
       jmp       short M03_L22
       sub       rsp,28
       mov       rdx,[rbp-88]
       mov       rax,[rbp-78]
       cmp       rdx,[rax+10]
       je        short M03_L24
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
M03_L24:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-80]
       cmp       rdx,rbx
       je        short M03_L27
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L25
       cmp       qword ptr [rbx+10],0
       jne       short M03_L26
M03_L25:
       cmp       qword ptr [rbp-80],0
       je        short M03_L27
       mov       rdx,[rbp-80]
       cmp       qword ptr [rdx+10],0
       je        short M03_L27
M03_L26:
       mov       rcx,rbx
       mov       rdx,[rbp-80]
       call      qword ptr [7FFAE0E36D60]
M03_L27:
       nop
       add       rsp,28
       ret
M03_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       jge       short M03_L29
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M03_L29
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.MemoryStream
       cmp       rax,rdx
       jne       short M03_L30
       mov       byte ptr [rcx+2B],0
       mov       word ptr [rcx+28],0
       xor       edx,edx
       mov       [rcx+30],rdx
       test      dword ptr [rax],100000
       je        short M03_L29
       call      00007FFB4039D4D0
       nop
M03_L29:
       add       rsp,28
       ret
M03_L30:
       mov       r11,7FFAE06B0A00
       call      qword ptr [r11]
       jmp       short M03_L29
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+10],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       lea       rcx,[rsi+18]
       call      qword ptr [7FFAE0DAE610]
       lea       rax,[M03_L22]
       add       rsp,28
       ret
; Total bytes of code 1047
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB0FB51D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

