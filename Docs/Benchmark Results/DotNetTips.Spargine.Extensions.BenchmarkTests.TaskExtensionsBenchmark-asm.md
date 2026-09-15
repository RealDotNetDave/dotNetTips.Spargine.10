## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark.WithTimeoutAsyncTask()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FFCDFD04F90]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-38],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-40],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-48],rdx
       lea       rcx,[rbp-30]
       call      qword ptr [7FFCDFFAE1D8]; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<WithTimeoutAsyncTask>d__5.MoveNext()
       nop
       mov       rdx,[rbp-48]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-40]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-40],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-40]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCE00468B0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFCE0045110]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFCE0045AB8]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-48]
       mov       rax,[rbp-38]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-38]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-40]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-40],0
       je        short M00_L13
       mov       rdx,[rbp-40]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCE00468B0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 356
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
       jmp       qword ptr [7FFCE0045A58]
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
       call      qword ptr [7FFD30469030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD30469038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFD3046AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD30468FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<WithTimeoutAsyncTask>d__5.MoveNext()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx]
       test      eax,eax
       je        near ptr M03_L04
       mov       rax,2474B000C08
       mov       rbx,[rax]
       test      dword ptr [rbx+34],1600000
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Threading.Tasks.VoidTaskResult>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,247610001C0
       mov       r9,[r9]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,3E8
       call      qword ptr [7FFCE0045A28]
       mov       rbx,rsi
M03_L01:
       mov       [rbp-20],rbx
       xor       edx,edx
       mov       [rbp-18],edx
       test      byte ptr [rbp-18],4
       jne       short M03_L03
       mov       rdx,[rbp-20]
       test      dword ptr [rdx+34],1600000
       je        short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       mov       eax,[rbp-18]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       je        short M03_L06
       jmp       short M03_L05
M03_L03:
       xor       edx,edx
       mov       rcx,[rbp+10]
       mov       [rcx],edx
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-18]
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       lea       rdx,[rcx+8]
       call      qword ptr [7FFCE0046928]
       mov       rdx,rax
       lea       rcx,[rbp-20]
       call      qword ptr [7FFCE0046940]
       jmp       short M03_L07
M03_L04:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+10]
       vmovdqu   xmmword ptr [rbp-20],xmm0
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       [rcx+18],rdx
       mov       dword ptr [rcx],0FFFFFFFF
       jmp       short M03_L02
M03_L05:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFCE0045A58]
       nop
M03_L06:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx],0FFFFFFFE
       add       rcx,8
       cmp       qword ptr [rcx],0
       jne       short M03_L08
       mov       rdx,2474B000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L07:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M03_L08:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFCE0045AA0]
       jmp       short M03_L07
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx],0FFFFFFFE
       add       rcx,8
       call      qword ptr [7FFCDFFAE2B0]
       lea       rax,[M03_L07]
       add       rsp,28
       ret
; Total bytes of code 376
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD30481D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark.WithTimeoutAsyncTaskOfT()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FFCDFD14F90]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFCDFFA6B08]; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<WithTimeoutAsyncTaskOfT>d__6.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFCDFFAF7F8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFCDFFAF0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFCDFFAF330]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFCDFFAF7F8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
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
       jmp       qword ptr [7FFCDFFAF2D0]
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
       call      qword ptr [7FFD30469030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD30469038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFD3046AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD30468FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<WithTimeoutAsyncTaskOfT>d__6.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L06
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M03_L04
       test      dword ptr [rsi+34],1600000
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,28AA2C00198
       mov       r9,[r9]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,3E8
       call      qword ptr [7FFCDFFAF2A0]
       mov       rsi,rdi
M03_L01:
       cmp       [rsi],sil
       mov       [rbp-28],rsi
       xor       edx,edx
       mov       [rbp-20],edx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L05
       mov       rdx,[rbp-28]
       test      dword ptr [rdx+34],1600000
       je        near ptr M03_L05
M03_L02:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L07
M03_L03:
       mov       rdx,[rbp-28]
       mov       edx,[rdx+38]
       mov       rax,[rbx+90]
       mov       [rax+38],edx
       jmp       near ptr M03_L08
M03_L04:
       call      qword ptr [7FFCDFF37558]
       mov       ecx,0E84
       mov       rdx,7FFCDFDA39F0
       call      qword ptr [7FFCDFBB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC64F28
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFDA39F0
       call      qword ptr [7FFCDFBB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF997858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDFFAF990]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDFFAF9A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       xor       edx,edx
       mov       rcx,[rbp+10]
       mov       [rcx+8],edx
       lea       rcx,[rcx+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFCDFFAF870]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFCDFFAF888]
       jmp       short M03_L09
M03_L06:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCDFFAF2D0]
       jmp       near ptr M03_L03
M03_L08:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L10
       mov       rdx,28A8CC00C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L09:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L10:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFCDFFAF318]
       jmp       short M03_L09
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFCDFFA6BF8]
       lea       rax,[M03_L09]
       add       rsp,28
       ret
; Total bytes of code 573
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD30481D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark.IgnoreCancellation()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
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
       call      qword ptr [7FFCDFD34F90]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFCDFFC6AD8]; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<IgnoreCancellation>d__3.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFCDFFCFA68]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFCDFFCF288]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFCDFFCF2E8]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFCDFFCFA68]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 362
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
       jmp       qword ptr [7FFCDFFC6CD0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFD30469030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD30469038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFD3046AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD30468FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark+<IgnoreCancellation>d__3.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],1
       jbe       short M03_L00
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rbp+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
M03_L00:
       cmp       dword ptr [rbp-1C],0
       je        near ptr M03_L24
       cmp       dword ptr [rbp-1C],1
       je        near ptr M03_L31
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+24],0
       jne       near ptr M03_L16
       cmp       dword ptr [rbx+20],0
       jne       short M03_L03
       lea       r11,[rbx+20]
       mov       edx,1
       xor       eax,eax
       lock cmpxchg [r11],edx
       test      eax,eax
       jne       short M03_L03
       mov       r11,[rbx+8]
       test      r11,r11
       jne       near ptr M03_L19
M03_L01:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M03_L20
M03_L02:
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M03_L21
M03_L03:
       mov       rax,12FF1400C08
       mov       rax,[rax]
M03_L04:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       edx,edx
       mov       [rbp-28],edx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L23
       mov       rdx,[rbp-30]
       test      dword ptr [rdx+34],1600000
       je        near ptr M03_L23
M03_L05:
       mov       rdx,[rbp-30]
       mov       eax,[rbp-28]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       jne       near ptr M03_L25
M03_L06:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+24],0
       jne       near ptr M03_L26
       cmp       dword ptr [rbx+20],0
       je        near ptr M03_L27
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],500000
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[rdi+40]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+38],1
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-58],rsi
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L28
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L28
M03_L07:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M03_L08
       call      qword ptr [7FFCDFD34F90]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M03_L08:
       mov       [rbp-60],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-68],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-70],rdx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCDFFC6C88]; DotNetTips.Spargine.Extensions.TaskExtensions+<IgnoreCancellation>d__2.MoveNext()
       nop
       mov       rdx,[rbp-70]
       cmp       rdx,[rbx+10]
       je        short M03_L09
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L09:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rsi
       je        short M03_L11
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L10
       cmp       qword ptr [rsi+10],0
       jne       short M03_L15
M03_L10:
       cmp       qword ptr [rbp-68],0
       jne       short M03_L14
M03_L11:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L29
M03_L12:
       cmp       [rax],al
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       near ptr M03_L30
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L30
M03_L13:
       mov       rcx,[rbp-30]
       mov       edx,[rbp-28]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       je        near ptr M03_L33
       jmp       near ptr M03_L32
M03_L14:
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M03_L11
M03_L15:
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FFCDFFCFA68]
       jmp       short M03_L11
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FFCDF9BC9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M03_L17
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rax
       call      qword ptr [7FFCDF9B7C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M03_L18:
       cmp       [rcx],ecx
       call      qword ptr [7FFCDFED76D8]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rbx,rax
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,170863B1150
       call      qword ptr [7FFCDFBDD890]; System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDFFCF690]
       mov       rcx,rsi
       call      qword ptr [7FFCDFFCF378]
       jmp       near ptr M03_L04
M03_L19:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       rcx,r11
       mov       r11,7FFCDF9008F8
       call      qword ptr [r11]
       jmp       near ptr M03_L01
M03_L20:
       mov       rcx,rax
       call      qword ptr [7FFCDFFCF420]
       jmp       near ptr M03_L02
M03_L21:
       mov       rcx,rsi
       call      qword ptr [7FFCDFFCFBD0]
       cmp       qword ptr [rsi+10],0
       setne     cl
       movzx     ecx,cl
       mov       byte ptr [rsi+34],0
       test      ecx,ecx
       je        near ptr M03_L03
       mov       rcx,12FF1400C00
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      qword ptr [7FFCDF9B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,130074001C8
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M03_L22
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      qword ptr [7FFCDF9B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,130074001C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFCDFFCB360
       call      qword ptr [7FFCDF9B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      qword ptr [7FFCDF9B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,130074001C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L22:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FFCDF9B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,130074001E0
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       xor       r9d,r9d
       mov       dword ptr [rsp+20],8
       call      qword ptr [7FFCDFFCFBE8]
       jmp       near ptr M03_L04
M03_L23:
       xor       edx,edx
       mov       [rbp-1C],edx
       mov       rcx,[rbp+10]
       mov       [rcx+8],edx
       lea       rcx,[rcx+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFCDFFCFAC8]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFCDFFCFAE0]
       jmp       near ptr M03_L34
M03_L24:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L05
M03_L25:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFCDFFC6CD0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L06
M03_L26:
       mov       ecx,46
       call      qword ptr [7FFCDFFCF438]
       int       3
M03_L27:
       mov       ecx,38
       call      qword ptr [7FFCDFBD78D0]
       int       3
M03_L28:
       mov       ecx,4
       call      qword ptr [7FFCDFFCF288]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L07
M03_L29:
       lea       rcx,[rbp-48]
       call      qword ptr [7FFCDFFCF2E8]
       jmp       near ptr M03_L12
M03_L30:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],1
       lea       rcx,[rcx+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFCDFFCFAC8]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFCDFFCFAE0]
       jmp       short M03_L35
M03_L31:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rbp-1C],0FFFFFFFF
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L13
M03_L32:
       call      qword ptr [7FFCDFFC6CD0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       nop
M03_L33:
       call      M03_L43
       jmp       short M03_L36
M03_L34:
       call      M03_L43
       jmp       short M03_L37
M03_L35:
       call      M03_L43
       jmp       short M03_L37
M03_L36:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       xor       edx,edx
       mov       [rcx],rdx
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L38
       mov       rdx,12FF1400C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L37:
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L38:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFCDFFCF2D0]
       jmp       short M03_L37
       sub       rsp,38
       mov       rdx,[rbp-70]
       mov       rax,[rbp-60]
       cmp       rdx,[rax+10]
       je        short M03_L39
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
M03_L39:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rsi
       je        short M03_L42
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L40
       cmp       qword ptr [rsi+10],0
       jne       short M03_L41
M03_L40:
       cmp       qword ptr [rbp-68],0
       je        short M03_L42
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M03_L42
M03_L41:
       mov       rcx,rsi
       mov       rdx,[rbp-68]
       call      qword ptr [7FFCDFFCFA68]
M03_L42:
       nop
       add       rsp,38
       ret
M03_L43:
       sub       rsp,38
       cmp       dword ptr [rbp-1C],0
       jge       near ptr M03_L47
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L47
       mov       r11,offset MT_System.Threading.CancellationTokenSource
       cmp       [rbx],r11
       jne       near ptr M03_L48
       cmp       byte ptr [rbx+24],0
       jne       short M03_L46
       mov       r11,[rbx+8]
       test      r11,r11
       je        short M03_L44
       xor       eax,eax
       mov       [rbx+8],rax
       mov       rcx,r11
       mov       r11,7FFCDF900900
       call      qword ptr [r11]
M03_L44:
       xor       edx,edx
       mov       [rbx+18],rdx
       cmp       qword ptr [rbx+10],0
       je        short M03_L45
       lea       rdx,[rbx+10]
       xor       eax,eax
       mov       rsi,rax
       xchg      rsi,[rdx]
       test      rsi,rsi
       je        short M03_L45
       cmp       dword ptr [rbx+20],1
       je        short M03_L45
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFCE0041078]
       mov       rcx,rsi
       call      qword ptr [7FFCDF9B7AF8]; System.GC.SuppressFinalize(System.Object)
M03_L45:
       mov       byte ptr [rbx+24],1
M03_L46:
       mov       rax,[rbx]
       test      dword ptr [rax],100000
       je        short M03_L47
       mov       rcx,rbx
       call      00007FFD3F5F0B60
M03_L47:
       nop
       add       rsp,38
       ret
M03_L48:
       mov       rcx,rbx
       mov       r11,7FFCDF9008F0
       call      qword ptr [r11]
       jmp       short M03_L47
       sub       rsp,38
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       xor       eax,eax
       mov       [rcx],rax
       add       rcx,10
       call      qword ptr [7FFCDFFC6C10]
       lea       rax,[M03_L37]
       add       rsp,38
       ret
; Total bytes of code 1779
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD30481D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFCDFFCF480]
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       near ptr M05_L10
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr M05_L09
       test      sil,2
       jne       near ptr M05_L08
       mov       ecx,[rbx+34]
       test      ecx,200000
       jne       near ptr M05_L11
       test      ecx,400000
       je        near ptr M05_L12
       mov       eax,6
M05_L02:
       cmp       eax,6
       jne       short M05_L05
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M05_L03
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       near ptr M05_L16
M05_L03:
       xor       ecx,ecx
M05_L04:
       test      rcx,rcx
       je        near ptr M05_L17
       call      qword ptr [7FFCDFFCF4E0]
       int       3
M05_L05:
       cmp       eax,7
       jne       short M05_L08
       mov       rcx,[rbx+28]
       mov       rsi,[rcx+18]
       mov       rdi,[rsi+10]
       cmp       byte ptr [rsi+20],0
       jne       short M05_L07
       mov       rcx,[rsi]
       test      dword ptr [rcx],100000
       jne       near ptr M05_L18
M05_L06:
       mov       byte ptr [rsi+20],1
M05_L07:
       cmp       dword ptr [rdi+10],0
       jle       near ptr M05_L19
       mov       rcx,[rdi+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M05_L21
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDFFCF4E0]
       int       3
M05_L08:
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M05_L09
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       near ptr M05_L20
M05_L09:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L10:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFCDFFCF4C8]
       jmp       near ptr M05_L01
M05_L11:
       mov       eax,7
       jmp       near ptr M05_L02
M05_L12:
       test      ecx,1000000
       je        short M05_L13
       mov       eax,5
       jmp       near ptr M05_L02
M05_L13:
       test      ecx,800000
       je        short M05_L14
       mov       eax,4
       jmp       near ptr M05_L02
M05_L14:
       test      ecx,20000
       je        short M05_L15
       mov       eax,3
       jmp       near ptr M05_L02
M05_L15:
       test      ecx,2000000
       setne     al
       movzx     eax,al
       mov       edx,2
       test      ecx,10000
       cmovne    eax,edx
       jmp       near ptr M05_L02
M05_L16:
       mov       rcx,[rcx+18]
       jmp       near ptr M05_L04
M05_L17:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCanceledException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCDFFC6D48]; System.Threading.Tasks.TaskCanceledException..ctor(System.Threading.Tasks.Task)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L18:
       mov       rcx,rsi
       call      00007FFD3F5F0B60
       jmp       near ptr M05_L06
M05_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCDFFCF4F8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L20:
       xor       edx,edx
       call      qword ptr [7FFCDFFCF498]
       jmp       near ptr M05_L09
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 496
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TaskExtensionsBenchmark.UnwrapAggregate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,rsi
       mov       rax,offset MT_System.AggregateException
       cmp       [rcx],rax
       jne       near ptr M00_L05
M00_L00:
       test      rcx,rcx
       je        near ptr M00_L06
       call      qword ptr [7FFCDFF96A78]; System.AggregateException.Flatten()
       mov       rdi,rax
       mov       rax,[rdi+78]
       test      rax,rax
       jne       short M00_L01
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rdi+70]
       test      rdx,rdx
       je        near ptr M00_L07
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+78]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L01:
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Exception[]
       cmp       [rcx],r11
       jne       near ptr M00_L08
       mov       esi,[rcx+8]
       cmp       esi,1
       jne       near ptr M00_L09
M00_L02:
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M00_L09
M00_L03:
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FFCDFF27558]
       mov       ecx,0E8E
       mov       rdx,7FFCDFD939F0
       call      qword ptr [7FFCDFBA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDFC54F28
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDFD939F0
       call      qword ptr [7FFCDFBA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF987858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDFF9F4B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDFF9F4C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,rsi
       jmp       near ptr M00_L03
M00_L07:
       mov       ecx,14
       call      qword ptr [7FFCDFBAC228]
       int       3
M00_L08:
       mov       r11,7FFCDF8D08C0
       call      qword ptr [r11]
       mov       esi,eax
       cmp       esi,1
       je        near ptr M00_L02
M00_L09:
       mov       rcx,rdi
       jmp       near ptr M00_L03
; Total bytes of code 446
```
```assembly
; System.AggregateException.Flatten()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,13133000198
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.AggregateException>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,131330001A0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCDFAFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       xor       ebp,ebp
M01_L00:
       cmp       [rdi+10],ebp
       jg        near ptr M01_L04
       mov       rcx,offset MT_System.AggregateException
       cmp       [rbx],rcx
       jne       near ptr M01_L25
       mov       rdi,[rbx+10]
       test      rdi,rdi
       jne       short M01_L03
       mov       rcx,171B1F01178
       call      qword ptr [7FFCDFBAD890]; System.SR.GetResourceString(System.String)
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDF98C9C0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L12
M01_L01:
       mov       rdx,[rcx+30]
       test      rdx,rdx
       jne       short M01_L02
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FFCDFAF4B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FFCDFF9EFE8]
       mov       rdi,rax
M01_L03:
       mov       ebx,[rsi+10]
       test      ebx,ebx
       je        near ptr M01_L26
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Exception[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M01_L29
       mov       rcx,[rsi]
       cmp       rcx,[rbp]
       jne       near ptr M01_L30
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L30
       cmp       ebx,[rsi+8]
       ja        near ptr M01_L30
       cmp       ebx,[rbp+8]
       ja        near ptr M01_L30
       mov       r8d,ebx
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L28
       cmp       r8,4000
       ja        near ptr M01_L13
       mov       rcx,rax
       call      00007FFD3F5B37A0
       cmp       dword ptr [7FFD3F8F3A90],0
       je        near ptr M01_L14
       jmp       near ptr M01_L27
M01_L04:
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       cmp       ebp,[rdi+10]
       jae       near ptr M01_L23
       mov       rcx,[rdi+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M01_L35
       mov       eax,ebp
       mov       rbp,[rcx+rax*8+10]
       mov       r15,[rbp+78]
       test      r15,r15
       jne       short M01_L05
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[rbp+70]
       test      rdx,rdx
       je        near ptr M01_L24
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+78]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
       xor       ebp,ebp
       jmp       near ptr M01_L10
M01_L06:
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCDFAFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L09
M01_L07:
       mov       eax,ebp
       mov       ebp,r14d
       mov       r14d,eax
       mov       rcx,[r15+8]
       mov       edx,r14d
       mov       r11,7FFCDF8D08D0
       call      qword ptr [r11]
       mov       r13,rax
       test      r13,r13
       je        short M01_L09
       mov       r8,r13
       mov       rdx,offset MT_System.InvalidOperationException
       cmp       [r8],rdx
       jne       near ptr M01_L19
       xor       r8d,r8d
M01_L08:
       test      r8,r8
       jne       near ptr M01_L20
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       edx,edx
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L09:
       inc       r14d
       mov       eax,ebp
       mov       ebp,r14d
       mov       r14d,eax
M01_L10:
       mov       rcx,[r15+8]
       mov       r11,offset MT_System.Exception[]
       cmp       [rcx],r11
       jne       near ptr M01_L22
       mov       r13d,[rcx+8]
M01_L11:
       cmp       ebp,r13d
       jl        near ptr M01_L07
       mov       ebp,r14d
       jmp       near ptr M01_L00
M01_L12:
       mov       rcx,rax
       call      qword ptr [7FFCDF987C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,rax
       call      qword ptr [7FFCDFF9EF40]
M01_L14:
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L32
M01_L15:
       mov       esi,[rbp+8]
       test      esi,esi
       je        near ptr M01_L33
       mov       rdi,[rbp+10]
M01_L16:
       mov       rcx,80131500E0434352
       mov       [rbx+68],rcx
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+70]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r8,[rbx+70]
       cmp       dword ptr [r8+8],0
       jle       short M01_L18
M01_L17:
       cmp       edi,esi
       jae       near ptr M01_L35
       mov       r8,[rbp+rdi*8+10]
       mov       rcx,[rbx+70]
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       cmp       qword ptr [rbp+rdi*8+10],0
       je        near ptr M01_L34
       inc       edi
       mov       rcx,[rbx+70]
       cmp       [rcx+8],edi
       jg        short M01_L17
M01_L18:
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L19:
       mov       rdx,r13
       mov       rcx,offset MT_System.AggregateException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r8,rax
       jmp       near ptr M01_L08
M01_L20:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L21
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M01_L09
M01_L21:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFCDFAFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L09
M01_L22:
       mov       r11,7FFCDF8D08D8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L11
M01_L23:
       call      qword ptr [7FFCDFF973C0]
       int       3
M01_L24:
       mov       ecx,14
       call      qword ptr [7FFCDFBAC228]
       int       3
M01_L25:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,13133000198
       mov       rbp,[rcx]
       jmp       near ptr M01_L14
M01_L27:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L14
M01_L28:
       mov       rcx,rax
       call      qword ptr [7FFCDF985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L29:
       xor       r14d,r14d
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCDFF2EB50]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M01_L31:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCDFF2EB50]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rbp
       call      qword ptr [7FFCDFF2EB68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L14
M01_L32:
       mov       rcx,171B1EF71E0
       call      qword ptr [7FFCDFBAD890]; System.SR.GetResourceString(System.String)
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L33:
       xor       edi,edi
       jmp       near ptr M01_L16
M01_L34:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDFF9F078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDFD05548]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1193
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
       mov       rax,171B1EF0008
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
       call      qword ptr [7FFCDFF9F798]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```

