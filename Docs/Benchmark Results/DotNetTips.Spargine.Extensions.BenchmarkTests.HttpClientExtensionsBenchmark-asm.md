## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.GetAndDeserializeFromStreamAsyncOptions()
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
       call      qword ptr [7FF7D8E14A38]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D9164BA0]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeFromStreamAsyncOptions>d__11.MoveNext()
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
       call      qword ptr [7FF7D9277480]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D9275EC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D927CED0]
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
       call      qword ptr [7FF7D9277480]
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
       jmp       qword ptr [7FF7D9276AC0]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeFromStreamAsyncOptions>d__11.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       [rbp-98],rax
       mov       rax,1B6AE400D50
       mov       rax,[rax]
       mov       [rbp-90],rax
       mov       rax,1B6AE400D60
       mov       rax,[rax]
       mov       [rbp-88],rax
       mov       [rbp-68],rdx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8E14A38]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0A8],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0B0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0B8],rdx
       lea       rcx,[rbp-98]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeFromStreamAsync>d__8<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9165008]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeFromStreamAsync>d__8`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0B8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0B0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0B0],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0A0],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0A0]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-0B0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0B0]
       call      qword ptr [7FF7D9277480]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D9275EC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9277450]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D927DCB0]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D92FB588
       call      qword ptr [7FF7D927DCC8]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D9276AC0]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,1B6AE400C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D927CEB8]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0B8]
       mov       rax,[rbp-0A8]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0B0]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-0B0],0
       je        short M03_L21
       mov       rdx,[rbp-0B0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-0B0]
       call      qword ptr [7FF7D9277480]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9164CF0]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 887
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.GetAndDeserializeFromStreamAsyncTypeInfo()
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
       call      qword ptr [7FF7D8E14930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D91643F0]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeFromStreamAsyncTypeInfo>d__12.MoveNext()
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
       call      qword ptr [7FF7D9286B08]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D9285878]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D928C558]
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
       call      qword ptr [7FF7D9286B08]
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
       jmp       qword ptr [7FF7D92860D0]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeFromStreamAsyncTypeInfo>d__12.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       [rbp-98],rax
       mov       rax,1A34DC00D48
       mov       rax,[rax]
       mov       [rbp-90],rax
       mov       rax,1A34DC00D68
       mov       rax,[rax]
       mov       [rbp-88],rax
       mov       [rbp-68],rdx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8E14930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0A8],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0B0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0B8],rdx
       lea       rcx,[rbp-98]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeFromStreamAsync>d__7<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9164858]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeFromStreamAsync>d__7`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0B8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0B0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0B0],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0A0],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0A0]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-0B0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0B0]
       call      qword ptr [7FF7D9286B08]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D9285878]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9286AD8]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D928D5C0]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D9316528
       call      qword ptr [7FF7D928D5D8]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D92860D0]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,1A34DC00C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D928C540]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0B8]
       mov       rax,[rbp-0A8]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0B0]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-0B0],0
       je        short M03_L21
       mov       rdx,[rbp-0B0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-0B0]
       call      qword ptr [7FF7D9286B08]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9164540]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 887
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PostAndDeserializeAsyncOptions()
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
       call      qword ptr [7FF7D8CAFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D9164348]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndDeserializeAsyncOptions>d__16.MoveNext()
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
       call      qword ptr [7FF7D9286940]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D916E880]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D9287AF8]
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
       call      qword ptr [7FF7D9286940]
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
       jmp       qword ptr [7FF7D9284780]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndDeserializeAsyncOptions>d__16.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L15
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       mov       r8,2420F000D48
       mov       r8,[r8]
       mov       r10,2420F000D58
       mov       r10,[r10]
       test      rax,rax
       je        near ptr M03_L10
       test      rdx,rdx
       je        near ptr M03_L11
       xor       r9d,r9d
       mov       [rbp-70],r9
       mov       [rbp-98],rax
       mov       rax,24225000448
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],r8
       mov       [rbp-0B8],rdx
       mov       [rbp-0B0],r10
       mov       [rbp-68],r9
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CAFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0C8],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0D0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0D8],rdx
       lea       rcx,[rbp-0B8]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload, DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9164960]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0D8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0D0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0D0],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L14
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L14
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L16
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0C0],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0C0]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L17
M03_L08:
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D9286940]
       jmp       near ptr M03_L04
M03_L10:
       call      qword ptr [7FF7D903F078]
       mov       ecx,443
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D54F28
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D9287E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D916EB38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FF7D903F078]
       mov       ecx,459
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D54F28
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D9287E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D916EB38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF7D916E880]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9285830]
       jmp       near ptr M03_L05
M03_L14:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D928CA80]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D92F9500
       call      qword ptr [7FF7D928CA98]
       jmp       short M03_L18
M03_L15:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D9284780]
       jmp       near ptr M03_L07
M03_L17:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L19
       mov       rdx,2420F000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L18:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D9287AE0]
       jmp       short M03_L18
       sub       rsp,28
       mov       rdx,[rbp-0D8]
       mov       rax,[rbp-0C8]
       cmp       rdx,[rax+10]
       je        short M03_L20
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0C8]
M03_L20:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0D0]
       cmp       rdx,rbx
       je        short M03_L23
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L21
       cmp       qword ptr [rbx+10],0
       jne       short M03_L22
M03_L21:
       cmp       qword ptr [rbp-0D0],0
       je        short M03_L23
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L23
M03_L22:
       mov       rcx,rbx
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D9286940]
M03_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9164498]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1248
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PostAndDeserializeAsyncTypeInfo()
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
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D91842D0]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndDeserializeAsyncTypeInfo>d__17.MoveNext()
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
       call      qword ptr [7FF7D92B6550]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D918EE08]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D92B7660]
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
       call      qword ptr [7FF7D92B6550]
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
       jmp       qword ptr [7FF7D92B4660]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndDeserializeAsyncTypeInfo>d__17.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L15
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       mov       r8,219F6800D48
       mov       r8,[r8]
       mov       r10,219F6800D68
       mov       r10,[r10]
       test      rax,rax
       je        near ptr M03_L10
       test      rdx,rdx
       je        near ptr M03_L11
       xor       r9d,r9d
       mov       [rbp-70],r9
       mov       [rbp-0A0],rax
       mov       rax,21A0C800448
       mov       rax,[rax]
       mov       [rbp-0B0],rax
       mov       [rbp-0A8],r8
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],r10
       mov       [rbp-98],r10
       mov       [rbp-68],r9
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0D0],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0D8],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0E0],rdx
       lea       rcx,[rbp-0C0]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__18<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload, DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9184B70]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__18`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0E0]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0D8]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0D8],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L14
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L14
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L16
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0C8],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0C8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L17
M03_L08:
       mov       rdx,[rbp-0D8]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FF7D92B6550]
       jmp       near ptr M03_L04
M03_L10:
       call      qword ptr [7FF7D905F210]
       mov       ecx,443
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D74F28
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D92B77F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D918F0D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FF7D905F210]
       mov       ecx,459
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D74F28
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D92B77F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D918F0D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF7D918EE08]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D92B5518]
       jmp       near ptr M03_L05
M03_L14:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D92BC408]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D93241D0
       call      qword ptr [7FF7D92BC420]
       jmp       short M03_L18
M03_L15:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D92B4660]
       jmp       near ptr M03_L07
M03_L17:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L19
       mov       rdx,219F6800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L18:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92B7648]
       jmp       short M03_L18
       sub       rsp,28
       mov       rdx,[rbp-0E0]
       mov       rax,[rbp-0D0]
       cmp       rdx,[rax+10]
       je        short M03_L20
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0D0]
M03_L20:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0D8]
       cmp       rdx,rbx
       je        short M03_L23
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L21
       cmp       qword ptr [rbx+10],0
       jne       short M03_L22
M03_L21:
       cmp       qword ptr [rbp-0D8],0
       je        short M03_L23
       mov       rdx,[rbp-0D8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L23
M03_L22:
       mov       rcx,rbx
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FF7D92B6550]
M03_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9184420]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1262
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PostAndEnsureSuccessAsyncOptions()
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
       call      qword ptr [7FF7D8E04930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D91649D8]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndEnsureSuccessAsyncOptions>d__18.MoveNext()
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
       call      qword ptr [7FF7D9287150]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D9284B58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D9287810]
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
       call      qword ptr [7FF7D9287150]
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
       jmp       qword ptr [7FF7D9285FC8]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndEnsureSuccessAsyncOptions>d__18.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       xor       r8d,r8d
       mov       [rbp-48],r8
       mov       [rbp-80],rax
       mov       rax,233BA000D48
       mov       rax,[rax]
       mov       [rbp-78],rax
       mov       [rbp-70],rdx
       mov       rax,233BA000D58
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       [rbp-40],r8
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8E04930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-90],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-98],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A0],rdx
       lea       rcx,[rbp-80]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<PostAndEnsureSuccessAsync>d__15<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9164C60]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<PostAndEnsureSuccessAsync>d__15`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0A0]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-98]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-98],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rax,[rbp-28]
       mov       eax,[rax+38]
       mov       [rbp-88],eax
       mov       rax,[rbx+90]
       cmp       [rax],al
       lea       rcx,[rbp-88]
       call      qword ptr [7FF7D9167588]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Net.HttpStatusCode, System.Net.Primitives]](System.Net.HttpStatusCode ByRef)
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9287150]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D9284B58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-48]
       call      qword ptr [7FF7D9167498]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D928C618]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D928C630]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D9285FC8]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,233BA000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92877F8]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-90]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-98]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-98],0
       je        short M03_L21
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9287150]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9164AF8]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 846
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PostAndEnsureSuccessAsyncTypeInfo()
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
       call      qword ptr [7FF7D8C9FD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D90AFEE8]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndEnsureSuccessAsyncTypeInfo>d__19.MoveNext()
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
       call      qword ptr [7FF7D9284C30]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D914DB48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D9285308]
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
       call      qword ptr [7FF7D9284C30]
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
       jmp       qword ptr [7FF7D914F8E8]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PostAndEnsureSuccessAsyncTypeInfo>d__19.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       xor       r8d,r8d
       mov       [rbp-48],r8
       mov       [rbp-80],rax
       mov       rax,19E26400D48
       mov       rax,[rax]
       mov       [rbp-78],rax
       mov       [rbp-70],rdx
       mov       rax,19E26400D68
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       [rbp-40],r8
       mov       dword ptr [rbp-50],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8C9FD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-90],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-98],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A0],rdx
       lea       rcx,[rbp-80]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<PostAndEnsureSuccessAsync>d__14<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9144180]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<PostAndEnsureSuccessAsync>d__14`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0A0]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-98]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-98],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rax,[rbp-28]
       mov       eax,[rax+38]
       mov       [rbp-88],eax
       mov       rax,[rbx+90]
       cmp       [rax],al
       lea       rcx,[rbp-88]
       call      qword ptr [7FF7D9146A30]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Net.HttpStatusCode, System.Net.Primitives]](System.Net.HttpStatusCode ByRef)
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9284C30]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D914DB48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-48]
       call      qword ptr [7FF7D9146940]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D92860E8]
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D9286100]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D914F8E8]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,19E26400C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92852F0]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-90]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-98]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-98],0
       je        short M03_L21
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9284C30]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9144018]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 846
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.DeleteAndDeserializeAsync()
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
       call      qword ptr [7FF7D8E14930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D9174B70]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<DeleteAndDeserializeAsync>d__8.MoveNext()
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
       call      qword ptr [7FF7D92873C0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D9285C20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D928CAF8]
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
       call      qword ptr [7FF7D92873C0]
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
       jmp       qword ptr [7FF7D9286898]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<DeleteAndDeserializeAsync>d__8.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       [rbp-0A0],rax
       mov       rax,26E52800D48
       mov       rax,[rax]
       mov       [rbp-98],rax
       mov       rax,26E52800D58
       mov       rax,[rax]
       mov       [rbp-90],rax
       mov       [rbp-68],rdx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8E14930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0B0],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0B8],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0C0],rdx
       lea       rcx,[rbp-0A0]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<DeleteAndDeserializeAsync>d__4<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9174FD8]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<DeleteAndDeserializeAsync>d__4`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0C0]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0B8]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0B8],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0A8],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0A8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-0B8]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FF7D92873C0]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D9285C20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9287240]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D928D8D8]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D93182C8
       call      qword ptr [7FF7D928D8F0]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D9286898]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,26E52800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D928CAE0]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0C0]
       mov       rax,[rbp-0B0]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0B8]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-0B8],0
       je        short M03_L21
       mov       rdx,[rbp-0B8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FF7D92873C0]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9174CC0]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 894
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.DownloadToStreamAsync()
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
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-48],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-50],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-58],rdx
       lea       rcx,[rbp-40]
       call      qword ptr [7FF7D91842E8]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<DownloadToStreamAsync>d__9.MoveNext()
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
       call      qword ptr [7FF7D918EEC8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D918D410]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D918EE98]
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
       call      qword ptr [7FF7D918EEC8]
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
       jmp       qword ptr [7FF7D918EB68]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<DownloadToStreamAsync>d__9.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
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
       mov       rcx,170B05D62A0
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
       mov       rax,[rbx+1A8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-98],rax
       mov       rax,1301B800D60
       mov       rax,[rax]
       mov       [rbp-90],rax
       mov       [rbp-88],rdx
       mov       [rbp-68],r8
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+40]
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
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L02:
       mov       [rbp-0A0],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0A8],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0B0],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF7D9184480]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<DownloadToStreamAsync>d__5.MoveNext()
       nop
       mov       rdx,[rbp-0B0]
       cmp       rdx,[rsi+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0A8]
       cmp       rdx,rdi
       je        short M03_L05
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L04
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L04:
       cmp       qword ptr [rbp-0A8],0
       jne       near ptr M03_L10
M03_L05:
       mov       rax,[rbp-70]
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
       mov       eax,[rbp-28]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       jne       near ptr M03_L16
M03_L08:
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
       mov       rax,[rbx+90]
       mov       [rax+18],rsi
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-0A8]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L05
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF7D918EEC8]
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF7D918D410]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L01
M03_L13:
       lea       rcx,[rbp-70]
       call      qword ptr [7FF7D918EE98]
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
       call      qword ptr [7FF7D92B49A8]
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7D92B49C0]
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
       mov       edx,eax
       call      qword ptr [7FF7D918EB68]
       jmp       near ptr M03_L08
M03_L17:
       xor       ecx,ecx
       call      qword ptr [7FF7D918D0C8]
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
       mov       rdx,1301B800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L22:
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L23:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D918EE80]
       jmp       short M03_L22
       sub       rsp,28
       mov       rdx,[rbp-0B0]
       mov       rax,[rbp-0A0]
       cmp       rdx,[rax+10]
       je        short M03_L24
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A0]
M03_L24:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0A8]
       cmp       rdx,rbx
       je        short M03_L27
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L25
       cmp       qword ptr [rbx+10],0
       jne       short M03_L26
M03_L25:
       cmp       qword ptr [rbp-0A8],0
       je        short M03_L27
       mov       rdx,[rbp-0A8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L27
M03_L26:
       mov       rcx,rbx
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF7D918EEC8]
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
       call      00007FF8386E0B60
       nop
M03_L29:
       add       rsp,28
       ret
M03_L30:
       mov       r11,7FF7D89F0AD0
       call      qword ptr [r11]
       jmp       short M03_L29
       sub       rsp,28
       mov       rdx,rcx
       mov       rsi,[rbp+10]
       mov       dword ptr [rsi+10],0FFFFFFFE
       xor       ecx,ecx
       mov       [rsi+8],rcx
       lea       rcx,[rsi+18]
       call      qword ptr [7FF7D91843F0]
       lea       rax,[M03_L22]
       add       rsp,28
       ret
; Total bytes of code 1103
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.GetAndDeserializeAsync()
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
       call      qword ptr [7FF7D8CBFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D9174138]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeAsync>d__10.MoveNext()
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
       call      qword ptr [7FF7D9294A20]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D917E2B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D92949F0]
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
       call      qword ptr [7FF7D9294A20]
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
       jmp       qword ptr [7FF7D92945D0]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetAndDeserializeAsync>d__10.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-80],rax
       mov       rax,2B0F9800D48
       mov       rax,[rax]
       mov       [rbp-78],rax
       mov       rax,2B0F9800D58
       mov       rax,[rax]
       mov       [rbp-70],rax
       mov       [rbp-50],rdx
       mov       dword ptr [rbp-60],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CBFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-90],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-98],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A0],rdx
       lea       rcx,[rbp-80]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeAsync>d__6<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D91743F0]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetAndDeserializeAsync>d__6`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0A0]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-98]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-98],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-58]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-88],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-88]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9294A20]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,4
       call      qword ptr [7FF7D917E2B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D92946D8]
       jmp       near ptr M03_L05
M03_L12:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D9296E50]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D92CF5C0
       call      qword ptr [7FF7D9296E68]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D92945D0]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,2B0F9800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92949D8]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-90]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-98]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-98],0
       je        short M03_L21
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-98]
       call      qword ptr [7FF7D9294A20]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9174288]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 874
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.GetStreamAsync()
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
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D9184360]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetStreamAsync>d__13.MoveNext()
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
       call      qword ptr [7FF7D918F138]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D918D6E0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D918FD38]
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
       call      qword ptr [7FF7D918F138]
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
       jmp       qword ptr [7FF7D918EDA8]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<GetStreamAsync>d__13.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       [rbp-24],eax
       mov       rbx,[rcx]
       cmp       dword ptr [rbp-24],0
       je        near ptr M03_L17
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-68],rdx
       mov       [rbp-88],rax
       mov       rax,2347D800D60
       mov       rax,[rax]
       mov       [rbp-80],rax
       mov       [rbp-60],rdx
       mov       dword ptr [rbp-70],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L14
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L14
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-98],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0A0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-88]
       call      qword ptr [7FF7D9184558]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<GetStreamAsync>d__9.MoveNext()
       nop
       mov       rdx,[rbp-0A8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0A0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L13
M03_L03:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L12
M03_L04:
       mov       rax,[rbp-68]
       test      rax,rax
       je        near ptr M03_L15
M03_L05:
       cmp       [rax],al
       mov       [rbp-38],rax
       xor       ecx,ecx
       mov       [rbp-30],ecx
       test      byte ptr [rbp-30],4
       jne       near ptr M03_L16
       mov       rcx,[rbp-38]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L16
M03_L06:
       mov       rdx,[rbp-38]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L18
M03_L07:
       mov       rax,[rbp-38]
       mov       rsi,[rax+38]
       mov       [rbp-90],rsi
       mov       rsi,[rbp-90]
       mov       rdi,[rsi]
       mov       rax,offset MT_System.IO.MemoryStream
       cmp       rdi,rax
       jne       short M03_L10
       cmp       byte ptr [rsi+2B],0
       je        short M03_L09
       mov       eax,[rsi+20]
       sub       eax,[rsi+18]
       movsxd    r14,eax
M03_L08:
       mov       rax,[rbx+90]
       mov       [rax+18],r14
       jmp       short M03_L11
M03_L09:
       xor       ecx,ecx
       call      qword ptr [7FF7D918D398]
       int       3
M03_L10:
       mov       rcx,rsi
       mov       rax,[rdi+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       short M03_L08
M03_L11:
       call      M03_L22
       jmp       near ptr M03_L19
M03_L12:
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L13:
       mov       rcx,rdi
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF7D918F138]
       jmp       near ptr M03_L04
M03_L14:
       mov       ecx,4
       call      qword ptr [7FF7D918D6E0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L15:
       lea       rcx,[rbp-68]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream>
       call      qword ptr [7FF7D918F108]
       jmp       near ptr M03_L05
M03_L16:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-30]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D92C4978]
       mov       r8,rax
       lea       rdx,[rbp-38]
       mov       rcx,7FF7D92BF2D0
       call      qword ptr [7FF7D92C4990]
       jmp       short M03_L20
M03_L17:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rbp-24],0FFFFFFFF
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L18:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D918EDA8]
       jmp       near ptr M03_L07
M03_L19:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L21
       mov       rdx,2347D800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L20:
       nop
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L21:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D918FD20]
       jmp       short M03_L20
M03_L22:
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       jge       short M03_L23
       cmp       qword ptr [rbp-90],0
       je        short M03_L23
       mov       rsi,[rbp-90]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.MemoryStream
       cmp       rdi,rcx
       jne       short M03_L24
       mov       byte ptr [rsi+2B],0
       mov       word ptr [rsi+28],0
       xor       ecx,ecx
       mov       [rsi+30],rcx
       test      dword ptr [rdi],100000
       je        short M03_L23
       mov       rcx,rsi
       call      00007FF8386E0B60
M03_L23:
       nop
       add       rsp,28
       ret
M03_L24:
       mov       rcx,rsi
       mov       r11,7FF7D89F0AC0
       call      qword ptr [r11]
       jmp       short M03_L23
       sub       rsp,28
       mov       rdx,[rbp-0A8]
       mov       rax,[rbp-98]
       cmp       rdx,[rax+10]
       je        short M03_L25
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
M03_L25:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0A0]
       cmp       rdx,rbx
       je        short M03_L28
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L26
       cmp       qword ptr [rbx+10],0
       jne       short M03_L27
M03_L26:
       cmp       qword ptr [rbp-0A0],0
       je        short M03_L28
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L28
M03_L27:
       mov       rcx,rbx
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF7D918F138]
M03_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9184480]
       lea       rax,[M03_L20]
       add       rsp,28
       ret
; Total bytes of code 1027
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.HeadersAsync()
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
       call      qword ptr [7FF7D8E24930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D90CFA08]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<HeadersAsync>d__14.MoveNext()
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
       call      qword ptr [7FF7D92A4BD0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D92A41C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D92A5680]
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
       call      qword ptr [7FF7D92A4BD0]
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
       jmp       qword ptr [7FF7D92A4900]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<HeadersAsync>d__14.MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L27
       mov       rax,[rbx+1A8]
       xor       edx,edx
       mov       [rbp-68],rdx
       mov       [rbp-88],rax
       mov       rax,17E74000D48
       mov       rax,[rax]
       mov       [rbp-80],rax
       mov       [rbp-60],rdx
       mov       dword ptr [rbp-70],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L24
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L24
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8E24930]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-98],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0A0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-88]
       call      qword ptr [7FF7D90CFC78]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<HeadersAsync>d__10.MoveNext()
       nop
       mov       rdx,[rbp-0A8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0A0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L03:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L10
M03_L04:
       mov       rax,[rbp-68]
       test      rax,rax
       je        near ptr M03_L25
M03_L05:
       cmp       [rax],al
       mov       [rbp-48],rax
       xor       ecx,ecx
       mov       [rbp-40],ecx
       test      byte ptr [rbp-40],4
       jne       near ptr M03_L26
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L26
M03_L06:
       mov       rdx,[rbp-48]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L28
M03_L07:
       mov       rdx,[rbp-48]
       mov       rsi,[rdx+38]
       cmp       [rsi],sil
       mov       rdx,17E740025F0
       mov       rdi,[rdx]
       xor       r14d,r14d
       mov       rdx,[rsi+8]
       mov       r15,rdx
       test      r15,r15
       je        short M03_L08
       mov       r8,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [r15],r8
       je        short M03_L08
       xor       r15d,r15d
M03_L08:
       test      r15,r15
       je        near ptr M03_L21
       xor       r13d,r13d
       cmp       dword ptr [rsi+10],0
       jle       near ptr M03_L16
M03_L09:
       mov       edx,[r15+8]
       cmp       edx,r13d
       jle       near ptr M03_L16
       mov       r12d,r13d
       shl       r12,4
       mov       rdx,[r15+r12+18]
       mov       r8,offset MT_System.String
       cmp       [rdi],r8
       je        short M03_L12
       cmp       rdi,rdx
       jne       near ptr M03_L29
       jmp       short M03_L15
M03_L10:
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF7D92A4BD0]
       jmp       near ptr M03_L04
M03_L12:
       test      rdx,rdx
       je        short M03_L13
       mov       r8,offset MT_System.String
       cmp       [rdx],r8
       jne       short M03_L13
       jmp       short M03_L14
M03_L13:
       xor       edx,edx
M03_L14:
       mov       rcx,rdi
       mov       r8d,5
       call      qword ptr [7FF7D8C14B28]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M03_L29
M03_L15:
       lea       r14,[r15+r12+10]
M03_L16:
       test      r14,r14
       je        near ptr M03_L23
       mov       rsi,[r14]
       test      rsi,rsi
       jne       near ptr M03_L22
M03_L17:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r15
       mov       r8,rsi
       call      00007FF8386D21C0
       cmp       rax,rsi
       jne       near ptr M03_L31
       mov       rsi,r15
M03_L18:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF7D9175C20]; System.Net.Http.Headers.HttpHeaders.ParseRawHeaderValues(System.Net.Http.Headers.HeaderDescriptor, HeaderStoreItemInfo)
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7D9175C38]; System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo.GetSingleParsedValue()
M03_L19:
       mov       r8,rax
       test      r8,r8
       je        short M03_L20
       mov       r10,offset MT_System.Net.Http.Headers.EntityTagHeaderValue
       cmp       [r8],r10
       jne       near ptr M03_L32
M03_L20:
       mov       [rbp-90],r8
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-90]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L33
M03_L21:
       test      rdx,rdx
       je        near ptr M03_L16
       jmp       near ptr M03_L30
M03_L22:
       mov       rax,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       cmp       [rsi],rax
       jne       near ptr M03_L17
       jmp       short M03_L18
M03_L23:
       xor       eax,eax
       jmp       short M03_L19
M03_L24:
       mov       ecx,4
       call      qword ptr [7FF7D92A41C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L25:
       lea       rcx,[rbp-68]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.Http.Headers.HttpResponseHeaders>
       call      qword ptr [7FF7D92A4B40]
       jmp       near ptr M03_L05
M03_L26:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D92A6238]
       mov       r8,rax
       lea       rdx,[rbp-48]
       mov       rcx,7FF7D92DEBC0
       call      qword ptr [7FF7D92A6250]
       jmp       near ptr M03_L34
M03_L27:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L28:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D92A4900]
       jmp       near ptr M03_L07
M03_L29:
       inc       r13d
       cmp       r13d,[rsi+10]
       jge       near ptr M03_L16
       jmp       near ptr M03_L09
M03_L30:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Net.Http.Headers.HeaderDescriptor, System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7D92A4BA0]
       mov       r14,rax
       jmp       near ptr M03_L16
M03_L31:
       mov       rdx,rax
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L18
M03_L32:
       mov       rdx,rax
       mov       rcx,r10
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       jmp       near ptr M03_L20
M03_L33:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L35
       mov       rdx,17E74000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L34:
       nop
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L35:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92A5668]
       jmp       short M03_L34
       sub       rsp,28
       mov       rdx,[rbp-0A8]
       mov       rax,[rbp-98]
       cmp       rdx,[rax+10]
       je        short M03_L36
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
M03_L36:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0A0]
       cmp       rdx,rbx
       je        short M03_L39
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L37
       cmp       qword ptr [rbx+10],0
       jne       short M03_L38
M03_L37:
       cmp       qword ptr [rbp-0A0],0
       je        short M03_L39
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L39
M03_L38:
       mov       rcx,rbx
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF7D92A4BD0]
M03_L39:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D90CFBA0]
       lea       rax,[M03_L34]
       add       rsp,28
       ret
; Total bytes of code 1310
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PatchAndDeserializeAsync()
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
       call      qword ptr [7FF7D8CAFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D91643D8]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PatchAndDeserializeAsync>d__15.MoveNext()
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
       call      qword ptr [7FF7D92969E8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D916E898]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D9297BA0]
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
       call      qword ptr [7FF7D92969E8]
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
       jmp       qword ptr [7FF7D9294A80]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PatchAndDeserializeAsync>d__15.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L15
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       mov       r8,1FFB2C00D48
       mov       r8,[r8]
       mov       r10,1FFB2C00D58
       mov       r10,[r10]
       test      rax,rax
       je        near ptr M03_L10
       test      rdx,rdx
       je        near ptr M03_L11
       xor       r9d,r9d
       mov       [rbp-70],r9
       mov       [rbp-98],rax
       mov       rax,1FFB2C02468
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],r8
       mov       [rbp-0B8],rdx
       mov       [rbp-0B0],r10
       mov       [rbp-68],r9
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CAFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0C8],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0D0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0D8],rdx
       lea       rcx,[rbp-0B8]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload, DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D91649F0]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0D8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0D0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0D0],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L14
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L14
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L16
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0C0],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0C0]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L17
M03_L08:
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D92969E8]
       jmp       near ptr M03_L04
M03_L10:
       call      qword ptr [7FF7D903F210]
       mov       ecx,443
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D54F28
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D9297E28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D916EB50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FF7D903F210]
       mov       ecx,459
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D54F28
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E73000
       call      qword ptr [7FF7D8CA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8A87840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D9297E28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D916EB50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF7D916E898]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D9295920]
       jmp       near ptr M03_L05
M03_L14:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D929CA20]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D9304B10
       call      qword ptr [7FF7D929CA38]
       jmp       short M03_L18
M03_L15:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D9294A80]
       jmp       near ptr M03_L07
M03_L17:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L19
       mov       rdx,1FFB2C00C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L18:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D9297B88]
       jmp       short M03_L18
       sub       rsp,28
       mov       rdx,[rbp-0D8]
       mov       rax,[rbp-0C8]
       cmp       rdx,[rax+10]
       je        short M03_L20
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0C8]
M03_L20:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0D0]
       cmp       rdx,rbx
       je        short M03_L23
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L21
       cmp       qword ptr [rbx+10],0
       jne       short M03_L22
M03_L21:
       cmp       qword ptr [rbp-0D0],0
       je        short M03_L23
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L23
M03_L22:
       mov       rcx,rbx
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D92969E8]
M03_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9164528]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1248
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark.PutAndDeserializeAsync()
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
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7D91843C0]; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PutAndDeserializeAsync>d__20.MoveNext()
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
       call      qword ptr [7FF7D92B6A48]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7D918E958]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7D92B7C18]
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
       call      qword ptr [7FF7D92B6A48]
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
       jmp       qword ptr [7FF7D92B4AE0]
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
       call      qword ptr [7FF835C49030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF835C49038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF835C4AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF835C48FE8]; CORINFO_HELP_ASSIGN_REF
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+<PutAndDeserializeAsync>d__20.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L15
       mov       rax,[rbx+1A8]
       mov       rdx,[rbx+1B0]
       mov       r8,17E05800D48
       mov       r8,[r8]
       mov       r10,17E05800D58
       mov       r10,[r10]
       test      rax,rax
       je        near ptr M03_L10
       test      rdx,rdx
       je        near ptr M03_L11
       xor       r9d,r9d
       mov       [rbp-70],r9
       mov       [rbp-98],rax
       mov       rax,17E1B800440
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],r8
       mov       [rbp-0B8],rdx
       mov       [rbp-0B0],r10
       mov       [rbp-68],r9
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF7D8CCFD80]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-0C8],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-0D0],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-0D8],rdx
       lea       rcx,[rbp-0B8]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload, DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D91849D8]; DotNetTips.Spargine.Extensions.HttpClientExtensions+<SendAndDeserializeAsync>d__17`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-0D8]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-0D0]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-0D0],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L14
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L14
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L16
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-0C0],rdx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-0C0]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L17
M03_L08:
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D92B6A48]
       jmp       near ptr M03_L04
M03_L10:
       call      qword ptr [7FF7D905F210]
       mov       ecx,443
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D74F28
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D92B7E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D918EC88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       call      qword ptr [7FF7D905F210]
       mov       ecx,459
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF7D8D74F28
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7D8E93000
       call      qword ptr [7FF7D8CC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7D8AA7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7D92B7E70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7D918EC88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF7D918E958]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L13:
       lea       rcx,[rbp-70]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Extensions.BenchmarkTests.HttpClientExtensionsBenchmark+SamplePayload>
       call      qword ptr [7FF7D92B5980]
       jmp       near ptr M03_L05
M03_L14:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FF7D92BCAE0]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF7D9325730
       call      qword ptr [7FF7D92BCAF8]
       jmp       short M03_L18
M03_L15:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L16:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7D92B4AE0]
       jmp       near ptr M03_L07
M03_L17:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L19
       mov       rdx,17E05800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L18:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF7D92B7C00]
       jmp       short M03_L18
       sub       rsp,28
       mov       rdx,[rbp-0D8]
       mov       rax,[rbp-0C8]
       cmp       rdx,[rax+10]
       je        short M03_L20
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0C8]
M03_L20:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-0D0]
       cmp       rdx,rbx
       je        short M03_L23
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L21
       cmp       qword ptr [rbx+10],0
       jne       short M03_L22
M03_L21:
       cmp       qword ptr [rbp-0D0],0
       je        short M03_L23
       mov       rdx,[rbp-0D0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L23
M03_L22:
       mov       rcx,rbx
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF7D92B6A48]
M03_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7D9184510]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1248
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF835C61D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

