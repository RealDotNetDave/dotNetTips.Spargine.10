## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0315D3F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFA031B6D08
       call      qword ptr [7FFA0315D398]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFA031B6E20
       call      qword ptr [7FFA0315D3C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031969E8
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2A33026B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2A330260008
       call      qword ptr [7FFA02F0EBB0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03196D70
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2A3302730F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A330260008
       call      qword ptr [7FFA02F0EBB0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			list.Insert(0, item);
; 			^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       r8,[rbp+20]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A535F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFA03196ED0
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0315D4D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0315D488]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA030BCE58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFA0318E570
       call      qword ptr [7FFA030BCDF8]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFA0318E688
       call      qword ptr [7FFA030BCE28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Insert(0, item);
; 			^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03176930
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2EBCA66B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2EBCA660008
       call      qword ptr [7FFA02EDE568]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03176CB8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2EBCA6730F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2EBCA660008
       call      qword ptr [7FFA02EDE568]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       r8,[rbp+20]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A335F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFA03176E18
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA030BCF30]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030BCEE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA030DCEE8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFA031AE570
       call      qword ptr [7FFA030DCE88]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFA031AE688
       call      qword ptr [7FFA030DCEB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Insert(0, item);
; 			^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031968E0
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,29CBDD4B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,29CBDD40008
       call      qword ptr [7FFA02EFE640]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03196C68
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,29CBDD530F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,29CBDD40008
       call      qword ptr [7FFA02EFE640]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       r8,[rbp+20]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A535F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 270
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFA03196DC8
       call      qword ptr [7FFA02B87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA030DCFC0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA030DCF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       je        short M00_L01
       test      ebp,ebp
       jg        near ptr M00_L11
M00_L00:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       ecx,4
M00_L02:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L03
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L07
M00_L03:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L02
M00_L05:
       call      qword ptr [7FFA02EC6E80]
       mov       ecx,0F
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0301CE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0301CE70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFA02EC6E80]
       mov       ecx,708
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0301CE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0301CE70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA03015620]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA031CC8E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA02E4D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L00
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2362B5E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FFA0313FE58]
       int       3
; Total bytes of code 244
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA03015620]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031CC8E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       ebp,[rdx+8]
       jne       near ptr M00_L04
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L03
       mov       ecx,4
M00_L00:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jle       short M00_L02
       jmp       near ptr M00_L11
M00_L05:
       call      qword ptr [7FFA02EE6E80]
       mov       ecx,0F
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0303CE40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0303CE58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFA02EE6E80]
       mov       ecx,708
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0303CE40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0303CE58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA03035608]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA031EC648]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA02E6D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,1A448C10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA0315FEA0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L06
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L09
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L10
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L04
       jmp       short M03_L05
M03_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L10:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
       jmp       short M03_L07
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA03035608]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031EC648]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       je        short M00_L01
       test      ebp,ebp
       jg        near ptr M00_L11
M00_L00:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       ecx,4
M00_L02:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L03
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L07
M00_L03:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L02
M00_L05:
       call      qword ptr [7FFA02EEEB98]
       mov       ecx,0F
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03154C00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03154C18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFA02EEEB98]
       mov       ecx,708
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03154C00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03154C18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02EEE550]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA031D4CA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA02E6D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L00
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,1E736160008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA031D7D50]
       int       3
; Total bytes of code 235
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L02
       cmp       rax,4000
       ja        short M05_L05
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L03
M05_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L04
M05_L01:
       add       rsp,38
       ret
M05_L02:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EEE550]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031D4CA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       ebp,[rdx+8]
       jne       near ptr M00_L04
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L03
       mov       ecx,4
M00_L00:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jle       short M00_L02
       jmp       near ptr M00_L11
M00_L05:
       call      qword ptr [7FFA02EEEBF8]
       mov       ecx,0F
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0306ED18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0306ED30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFA02EEEBF8]
       mov       ecx,708
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0306ED18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0306ED30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02EEEA00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA03066268]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA02E6D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2D353D20008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA0320C3F0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EEEA00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA03066268]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       ebp,[rdx+8]
       jne       near ptr M00_L04
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L03
       mov       ecx,4
M00_L00:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jle       short M00_L02
       jmp       near ptr M00_L11
M00_L05:
       call      qword ptr [7FFA02EDECD0]
       mov       ecx,0F
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03066A18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03066A30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFA02EDECD0]
       mov       ecx,708
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03066A18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03066A30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02EDEA00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA030666B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFA02E5D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,237FC620008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA0317F5A0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L02
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EDEA00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA030666B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0316D3C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFA031C0048
       call      qword ptr [7FFA0316D368]; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFA031C0160
       call      qword ptr [7FFA0316D398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031A88B0
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2631B9130F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2631B900008
       call      qword ptr [7FFA02EEEB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031A88F0
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2631B90B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2631B900008
       call      qword ptr [7FFA02EEEB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			list.Add(item);
; 			^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A43598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFA031A8A48
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0316D4A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0316D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0317D3C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFA031CF588
       call      qword ptr [7FFA0317D368]; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFA031CF6A0
       call      qword ptr [7FFA0317D398]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Add(item);
; 			^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031B88B0
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,28BACB830F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,28BACB70008
       call      qword ptr [7FFA02F0EB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031B88F0
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,28BACB7B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,28BACB70008
       call      qword ptr [7FFA02F0EB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A63598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFA031B8A48
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0317D4A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0317D458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFA02EDE448]
       mov       ecx,708
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030B43C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030B43D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFA02EDE448]
       mov       ecx,0F
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030B43C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030B43D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       mov       r14d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M01_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02ED6148]
       int       3
M01_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M01_L00
M01_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M01_L08
       test      r14d,r14d
       jg        short M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L04
M01_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L04:
       mov       rdx,7FFA03214A60
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L03
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M01_L09
       mov       rcx,rax
M01_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M01_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       rdx,7FFA031C1C90
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L06
; Total bytes of code 309
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,19D2A600008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFA031D7798]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFA02EDEBF8]
       mov       ecx,708
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144B10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144B28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFA02EDEBF8]
       mov       ecx,0F
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144B10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144B28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        near ptr M01_L03
       test      r15d,r15d
       jle       near ptr M01_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M01_L02
       test      r14,r14
       je        near ptr M01_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M01_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L11
       cmp       edi,[r14+8]
       ja        near ptr M01_L11
       cmp       edi,[r15+8]
       ja        near ptr M01_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L09
       cmp       r8,4000
       ja        near ptr M01_L08
       mov       rcx,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFA0318EC00
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02ED6148]
       int       3
M01_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L02
M01_L08:
       mov       rcx,rax
       call      qword ptr [7FFA02EDE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L10:
       xor       r13d,r13d
       jmp       short M01_L12
M01_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA031C7210]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M01_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA031C7210]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA031C4B10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L02
M01_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA03214AA8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 525
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,2AE04730008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFA031C7CC0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFA02EDEBF8]
       mov       ecx,708
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144BA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144BB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFA02EDEBF8]
       mov       ecx,0F
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144BA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144BB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        near ptr M01_L03
       test      r15d,r15d
       jle       near ptr M01_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M01_L02
       test      r14,r14
       je        near ptr M01_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M01_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L11
       cmp       edi,[r14+8]
       ja        near ptr M01_L11
       cmp       edi,[r15+8]
       ja        near ptr M01_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L09
       cmp       r8,4000
       ja        near ptr M01_L08
       mov       rcx,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFA0318AE58
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02ED6148]
       int       3
M01_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L02
M01_L08:
       mov       rcx,rax
       call      qword ptr [7FFA02EDE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L10:
       xor       r13d,r13d
       jmp       short M01_L12
M01_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA031C73F0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M01_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA031C73F0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA031C49C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L02
M01_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA03214940
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 525
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,23269980008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFA031C7EA0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L01
       test      rdx,rdx
       je        near ptr M00_L02
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFA02EF6E80]
       mov       ecx,708
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0304CE88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0304CEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       call      qword ptr [7FFA02EF6E80]
       mov       ecx,0F
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0304CE88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0304CEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFA02ADE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L00
; Total bytes of code 434
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,2B63F5D0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA0316FF90]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M02_L01
       mov       r14d,4
M02_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M02_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EF6148]
       int       3
M02_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M02_L00
M02_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M02_L08
       test      r14d,r14d
       jg        short M02_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0C8]
       test      rdx,rdx
       je        short M02_L04
M02_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFA03261C20
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L03
M02_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M02_L09
       mov       rcx,rax
M02_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M02_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
M02_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       rdx,7FFA0322E8B8
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L06
; Total bytes of code 309
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L01
       test      rdx,rdx
       je        near ptr M00_L02
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFA02EFE610]
       mov       ecx,708
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03177BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03177BD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       call      qword ptr [7FFA02EFE610]
       mov       ecx,0F
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03177BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03177BD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFA02ADE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L00
; Total bytes of code 434
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,22099C80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFA0322C540]
       int       3
; Total bytes of code 231
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M02_L04
       mov       r15d,4
M02_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M02_L07
       cmp       [r14+8],r15d
       je        short M02_L03
       test      r15d,r15d
       jle       near ptr M02_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M02_L05
       mov       rcx,rax
M02_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M02_L06
M02_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFA03098160
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M02_L02
M02_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EF6148]
       int       3
M02_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdx,7FFA03183150
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
; Total bytes of code 321
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rsi,rsi
       je        short M00_L02
       test      rdx,rdx
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA02AAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFA02EC6E80]
       mov       ecx,708
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302F8E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302F900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFA02EC6E80]
       mov       ecx,0F
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0302F8E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0302F900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        short M01_L03
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFA02FDE598
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EC6148]
       int       3
M01_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA02FDEE40
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 318
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,2612CBB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFA03214048]
       int       3
; Total bytes of code 231
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rdi,rdi
       je        near ptr M00_L42
       test      rsi,rsi
       je        near ptr M00_L41
       mov       r14,rsi
       mov       rcx,1D322802000
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       lea       rcx,[r13+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L43
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFA02955A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r12d
       mov       [r15+1C],ecx
M00_L03:
       mov       [rbp-78],r15
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-78]
       cmp       [r15],rcx
       jne       near ptr M00_L32
       lea       r14,[r15+8]
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L34
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L16
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r15+10]
M00_L05:
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L18
M00_L06:
       mov       r12,[r13+10]
       mov       rax,[r13+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L27
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L20
       mov       rcx,1D322800068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L26
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0F872A392
       mov       r9d,0D6775063
       cmp       edx,8
       jb        near ptr M00_L21
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L22
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r13+8]
       mov       ecx,r10d
       imul      rcx,[r13+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       js        short M00_L13
M00_L11:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L28
M00_L12:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L11
M00_L13:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L29
       mov       edx,[r13+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L14:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r13+28],ecx
       mov       rcx,[r13+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L15:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r13+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L16:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r15
       mov       r11,7FFA028A1AE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA0295E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       cmp       edx,4
       jb        short M00_L23
M00_L22:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L23:
       mov       r11d,80
       test      dl,1
       je        short M00_L24
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L24:
       test      dl,2
       je        short M00_L25
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L25:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L27:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFA028A1AF0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFA028A1AF8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L12
M00_L29:
       mov       ecx,[r13+2C]
       mov       r11d,ecx
       dec       dword ptr [r13+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L15
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r13
       call      qword ptr [7FFA031EE040]
       mov       rcx,[r13+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L14
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFA02CDD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFA0295E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r15
       mov       r11,7FFA028A1AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L17
       jmp       near ptr M00_L47
M00_L33:
       call      qword ptr [7FFA02B77A08]
       int       3
M00_L34:
       call      qword ptr [7FFA02B7C138]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r13+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L48
M00_L37:
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r8
       jne       near ptr M00_L53
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L52
       mov       r14d,[rdi+14]
       xor       r15d,r15d
       cmp       r14d,[rdi+14]
       jne       near ptr M00_L51
M00_L38:
       cmp       r15d,[rdi+10]
       jae       short M00_L40
       mov       r8,[rdi+8]
       cmp       r15d,[r8+8]
       jae       near ptr M00_L59
       mov       r12,[r8+r15*8+10]
       inc       r15d
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA0295E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L49
M00_L39:
       cmp       r14d,[rdi+14]
       je        short M00_L38
       jmp       near ptr M00_L51
M00_L40:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFA0316FE00
       cmp       [rcx],ecx
       call      qword ptr [7FFA03155860]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L41:
       call      qword ptr [7FFA02EE6E98]
       mov       ecx,708
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rsi,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C34878
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D56BA0
       call      qword ptr [7FFA02B77798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02957840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0303CEA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0303CEB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       jmp       near ptr M00_L40
M00_L43:
       mov       r8,r15
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA031EF180]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFA031EEAF0]
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,r14
       mov       r11,7FFA028A1AC8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D338800C60
       mov       r15,[rcx]
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,r14
       mov       r11,7FFA028A1AD0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L47:
       mov       rcx,r15
       mov       r11,7FFA028A1AE8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L48:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFA031EEB08]
       jmp       near ptr M00_L37
M00_L49:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L50
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L50:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02ACE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L51:
       call      qword ptr [7FFA02B7C138]
       int       3
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D338800C60
       mov       rcx,[rcx]
       jmp       short M00_L54
M00_L53:
       mov       rcx,rdi
       mov       r11,7FFA028A1AA8
       call      qword ptr [r11]
       mov       rcx,rax
M00_L54:
       mov       [rbp-68],rcx
M00_L55:
       mov       rcx,[rbp-68]
       mov       r11,[rcx]
       mov       r11,7FFA028A1AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L58
       mov       rcx,[rbp-68]
       mov       r11,7FFA028A1AB8
       call      qword ptr [r11]
       mov       rdi,rax
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFA0295E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L55
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L56
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       short M00_L57
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L55
M00_L56:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFA02ACE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L55
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       mov       rcx,[rbp-68]
       mov       r11,7FFA028A1AC0
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L60
       mov       rcx,[rbp-68]
       mov       r11,7FFA028A1AC0
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L61
       mov       rcx,rax
       mov       r11,7FFA028A1AE8
       call      qword ptr [r11]
M00_L61:
       nop
       add       rsp,28
       ret
; Total bytes of code 2580
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFA53781408
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA031EEB20]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CD5D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA031EEB38]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFA02955A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFA0325C558
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EBEA8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA543E8070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA543F92E0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA543F5B40]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EB4E0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA543F7728]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA543E8078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543ED118]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M05_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L07
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M05_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M05_L12
M05_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M05_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M05_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M05_L06
M05_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L04
M05_L06:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L07:
       mov       rdx,7FFA031C5820
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,r15
       call      00007FFA6254E4B0
       test      eax,eax
       je        short M05_L10
       mov       r15d,eax
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       call      qword ptr [7FFA0295E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M05_L09
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M05_L03
M05_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L15
       jmp       short M05_L16
M05_L15:
       mov       rdx,7FFA031C5838
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L05
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L17:
       call      qword ptr [7FFA02B77A08]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L13
M06_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M06_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L12
M06_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M06_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M06_L15
       mov       rcx,1D322800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M06_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F872A392
       mov       r8d,0D6775063
       cmp       edx,8
       jb        near ptr M06_L16
       mov       r10d,edx
       shr       r10d,3
M06_L02:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M06_L02
       test      dl,4
       jne       near ptr M06_L17
M06_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M06_L04:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M06_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M06_L08
M06_L06:
       cmp       eax,[rbp+8]
       jae       near ptr M06_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M06_L23
M06_L07:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M06_L26
       test      eax,eax
       jge       short M06_L06
M06_L08:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M06_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M06_L28
M06_L09:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M06_L10:
       cmp       ebp,[rax+8]
       jae       near ptr M06_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M06_L29
M06_L11:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L12:
       mov       rdx,7FFA031C5820
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L01
M06_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0295E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M06_L00
M06_L14:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L15:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L16:
       cmp       edx,4
       jb        short M06_L18
M06_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M06_L03
M06_L18:
       mov       r10d,80
       test      dl,1
       je        short M06_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M06_L19:
       test      dl,2
       je        short M06_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L20:
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rdx,7FFA031C5838
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L07
       mov       eax,[rsp+3C]
       mov       [rdi],eax
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L26:
       call      qword ptr [7FFA02B77A08]
       int       3
M06_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M06_L10
M06_L28:
       mov       rcx,rbx
       call      qword ptr [7FFA031EE040]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M06_L09
M06_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L11
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02CDD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA0295E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M06_L11
M06_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1091
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L00
       test      rbx,rbx
       je        near ptr M08_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M08_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M08_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       test      rbx,rbx
       je        short M08_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L02
M08_L01:
       mov       rax,213B7880008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       call      qword ptr [7FFA0315FFC0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFA02955C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M10_L01
       mov       r14d,4
M10_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M10_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EE6148]
       int       3
M10_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M10_L00
M10_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M10_L08
       test      r14d,r14d
       jg        short M10_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0C8]
       test      rdx,rdx
       je        short M10_L04
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L08
M10_L04:
       mov       rdx,7FFA0321F240
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M10_L09
       mov       rcx,rax
M10_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M10_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFA02AC5050]; System.Array.Copy(System.Array, System.Array, Int32)
M10_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M10_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L09:
       mov       rdx,7FFA0321BE98
       call      qword ptr [7FFA0295C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L06
; Total bytes of code 309
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rdi,rdi
       je        near ptr M00_L42
       test      rsi,rsi
       je        near ptr M00_L41
       mov       r14,rsi
       mov       rcx,1E663400AC0
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       lea       rcx,[r13+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L43
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFA02945A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r12d
       mov       [r15+1C],ecx
M00_L03:
       mov       [rbp-78],r15
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-78]
       cmp       [r15],rcx
       jne       near ptr M00_L32
       lea       r14,[r15+8]
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L34
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L16
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r15+10]
M00_L05:
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L18
M00_L06:
       mov       r12,[r13+10]
       mov       rax,[r13+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L27
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L20
       mov       rcx,1E64D400068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L26
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0B7EBEF71
       mov       r9d,0DB65FB29
       cmp       edx,8
       jb        near ptr M00_L21
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L22
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r13+8]
       mov       ecx,r10d
       imul      rcx,[r13+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L29
       mov       edx,[r13+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r13+28],ecx
       mov       rcx,[r13+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r13+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L28
M00_L15:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r15
       mov       r11,7FFA02891D18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA0294E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       cmp       edx,4
       jb        short M00_L23
M00_L22:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L23:
       mov       r11d,80
       test      dl,1
       je        short M00_L24
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L24:
       test      dl,2
       je        short M00_L25
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L25:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L27:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFA02891D28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFA02891D30
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L15
M00_L29:
       mov       ecx,[r13+2C]
       mov       r11d,ecx
       dec       dword ptr [r13+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r13
       call      qword ptr [7FFA032A6208]
       mov       rcx,[r13+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFA02CCD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFA0294E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r15
       mov       r11,7FFA02891D10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L17
       jmp       near ptr M00_L47
M00_L33:
       call      qword ptr [7FFA02B67A08]
       int       3
M00_L34:
       call      qword ptr [7FFA02B6C138]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r13+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L48
M00_L37:
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r8
       jne       near ptr M00_L53
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L52
       mov       r14d,[rdi+14]
       xor       r15d,r15d
       cmp       r14d,[rdi+14]
       jne       near ptr M00_L51
M00_L38:
       cmp       r15d,[rdi+10]
       jae       short M00_L40
       mov       r8,[rdi+8]
       cmp       r15d,[r8+8]
       jae       near ptr M00_L59
       mov       r12,[r8+r15*8+10]
       inc       r15d
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA0294E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L49
M00_L39:
       cmp       r14d,[rdi+14]
       je        short M00_L38
       jmp       near ptr M00_L51
M00_L40:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFA031A2750
       cmp       [rcx],ecx
       call      qword ptr [7FFA0314D440]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L41:
       call      qword ptr [7FFA02EDEBF8]
       mov       ecx,708
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D46BA0
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA03144B40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03144B58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       jmp       near ptr M00_L40
M00_L43:
       mov       r8,r15
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA032A76F0]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFA032A6EC8]
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,r14
       mov       r11,7FFA02891D00
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E663400D50
       mov       r15,[rcx]
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,r14
       mov       r11,7FFA02891D08
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L47:
       mov       rcx,r15
       mov       r11,7FFA02891D20
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L48:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFA032A6EE0]
       jmp       near ptr M00_L37
M00_L49:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L50
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L50:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L51:
       call      qword ptr [7FFA02B6C138]
       int       3
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E663400D50
       mov       rcx,[rcx]
       jmp       short M00_L54
M00_L53:
       mov       rcx,rdi
       mov       r11,7FFA02891CE0
       call      qword ptr [r11]
       mov       rcx,rax
M00_L54:
       mov       [rbp-68],rcx
M00_L55:
       mov       rcx,[rbp-68]
       mov       r11,[rcx]
       mov       r11,7FFA02891CE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L58
       mov       rcx,[rbp-68]
       mov       r11,7FFA02891CF0
       call      qword ptr [r11]
       mov       rdi,rax
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFA0294E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L55
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L56
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       short M00_L57
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L55
M00_L56:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFA02ABE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L55
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       mov       rcx,[rbp-68]
       mov       r11,7FFA02891CF8
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L60
       mov       rcx,[rbp-68]
       mov       r11,7FFA02891CF8
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L61
       mov       rcx,rax
       mov       r11,7FFA02891D20
       call      qword ptr [r11]
M00_L61:
       nop
       add       rsp,28
       ret
; Total bytes of code 2589
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFA53781408
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA031C6700]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CC5D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA031C6718]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFA02945A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFA03280400
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 169
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EBEA8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA543E8070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA543F92E0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA543F5B40]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EB4E0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA543F7728]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA543E8078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543ED118]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M05_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L08
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M05_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M05_L12
M05_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M05_L10
       mov       rcx,r15
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M05_L09
M05_L02:
       mov       r15d,eax
M05_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M05_L07
M05_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L05
M05_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L08:
       mov       rdx,7FFA03214DE0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L09:
       mov       rcx,r15
       call      qword ptr [7FFA0294E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M05_L03
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L15
       jmp       short M05_L16
M05_L15:
       mov       rdx,7FFA03214DF8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L17:
       call      qword ptr [7FFA02B67A08]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L13
M06_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M06_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L12
M06_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M06_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M06_L15
       mov       rcx,1E64D400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M06_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B7EBEF71
       mov       r8d,0DB65FB29
       cmp       edx,8
       jb        near ptr M06_L16
       mov       r10d,edx
       shr       r10d,3
M06_L02:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M06_L02
       test      dl,4
       jne       near ptr M06_L17
M06_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M06_L04:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M06_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M06_L10
M06_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M06_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M06_L28
M06_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M06_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M06_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M06_L29
M06_L09:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L10:
       cmp       eax,[rbp+8]
       jae       near ptr M06_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M06_L23
M06_L11:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M06_L26
       test      eax,eax
       jge       short M06_L10
       jmp       near ptr M06_L06
M06_L12:
       mov       rdx,7FFA03214DE0
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L01
M06_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0294E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M06_L00
M06_L14:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L15:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L16:
       cmp       edx,4
       jb        short M06_L18
M06_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M06_L03
M06_L18:
       mov       r10d,80
       test      dl,1
       je        short M06_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M06_L19:
       test      dl,2
       je        short M06_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L20:
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rdx,7FFA03214DF8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L11
       mov       eax,[rsp+3C]
       mov       [rdi],eax
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L26:
       call      qword ptr [7FFA02B67A08]
       int       3
M06_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M06_L08
M06_L28:
       mov       rcx,rbx
       call      qword ptr [7FFA032A6208]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M06_L07
M06_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02CCD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA0294E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M06_L09
M06_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1100
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L00
       test      rbx,rbx
       je        near ptr M08_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M08_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M08_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       test      rbx,rbx
       je        short M08_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L02
M08_L01:
       mov       rax,226E24D0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       call      qword ptr [7FFA031C7DC8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M10_L04
       mov       r15d,4
M10_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M10_L06
       cmp       [r14+8],r15d
       je        near ptr M10_L03
       test      r15d,r15d
       jle       near ptr M10_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M10_L05
       mov       rcx,rax
M10_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M10_L02
       test      r14,r14
       je        near ptr M10_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M10_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M10_L11
       cmp       edi,[r14+8]
       ja        near ptr M10_L11
       cmp       edi,[r15+8]
       ja        near ptr M10_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M10_L09
       cmp       r8,4000
       ja        near ptr M10_L08
       mov       rcx,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M10_L07
M10_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M10_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M10_L00
M10_L05:
       mov       rdx,7FFA0318B590
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L01
M10_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02ED6148]
       int       3
M10_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L02
M10_L08:
       mov       rcx,rax
       call      qword ptr [7FFA02EDE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M10_L02
M10_L09:
       mov       rcx,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L02
M10_L10:
       xor       r13d,r13d
       jmp       short M10_L12
M10_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA031C7300]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M10_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA031C7300]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA031C4AB0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M10_L02
M10_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L14
       jmp       short M10_L15
M10_L14:
       mov       rdx,7FFA03215158
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M10_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L03
; Total bytes of code 525
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rdi,rdi
       je        near ptr M00_L42
       test      rsi,rsi
       je        near ptr M00_L41
       mov       r14,rsi
       mov       rcx,2438F002AB8
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       lea       rcx,[r13+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L43
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFA02935A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r12d
       mov       [r15+1C],ecx
M00_L03:
       mov       [rbp-78],r15
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-78]
       cmp       [r15],rcx
       jne       near ptr M00_L32
       lea       r14,[r15+8]
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L34
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L16
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r15+10]
M00_L05:
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L18
M00_L06:
       mov       r12,[r13+10]
       mov       rax,[r13+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L27
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L20
       mov       rcx,2438F000068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L26
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0C2CE2041
       mov       r9d,0B9A6BECA
       cmp       edx,8
       jb        near ptr M00_L21
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L22
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r13+8]
       mov       ecx,r10d
       imul      rcx,[r13+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L29
       mov       edx,[r13+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r13+28],ecx
       mov       rcx,[r13+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r13+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L28
M00_L15:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r15
       mov       r11,7FFA02881E48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA0293E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       cmp       edx,4
       jb        short M00_L23
M00_L22:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L23:
       mov       r11d,80
       test      dl,1
       je        short M00_L24
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L24:
       test      dl,2
       je        short M00_L25
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L25:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L27:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFA02881E58
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFA02881E60
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L15
M00_L29:
       mov       ecx,[r13+2C]
       mov       r11d,ecx
       dec       dword ptr [r13+30]
       mov       ecx,[r13+2C]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r13
       call      qword ptr [7FFA03295ED8]
       mov       rcx,[r13+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFA02CBD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFA0293E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r15
       mov       r11,7FFA02881E40
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L17
       jmp       near ptr M00_L47
M00_L33:
       call      qword ptr [7FFA02B57A08]
       int       3
M00_L34:
       call      qword ptr [7FFA02B5C138]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r13+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L48
M00_L37:
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r8
       jne       near ptr M00_L53
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L52
       mov       r14d,[rdi+14]
       xor       r15d,r15d
       cmp       r14d,[rdi+14]
       jne       near ptr M00_L51
M00_L38:
       cmp       r15d,[rdi+10]
       jae       short M00_L40
       mov       r8,[rdi+8]
       cmp       r15d,[r8+8]
       jae       near ptr M00_L59
       mov       r12,[r8+r15*8+10]
       inc       r15d
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA0293E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L49
M00_L39:
       cmp       r14d,[rdi+14]
       je        short M00_L38
       jmp       near ptr M00_L51
M00_L40:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFA03182580
       cmp       [rcx],ecx
       call      qword ptr [7FFA030ACF90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L41:
       call      qword ptr [7FFA02ECE610]
       mov       ecx,708
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D36BA0
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA030A45D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA030A45E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       jmp       near ptr M00_L40
M00_L43:
       mov       r8,r15
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA032974F8]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFA03296E80]
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,r14
       mov       r11,7FFA02881E30
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2438F002D40
       mov       r15,[rcx]
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,r14
       mov       r11,7FFA02881E38
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L47:
       mov       rcx,r15
       mov       r11,7FFA02881E50
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L48:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFA03296E98]
       jmp       near ptr M00_L37
M00_L49:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L50
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L50:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02AAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L51:
       call      qword ptr [7FFA02B5C138]
       int       3
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2438F002D40
       mov       rcx,[rcx]
       jmp       short M00_L54
M00_L53:
       mov       rcx,rdi
       mov       r11,7FFA02881E10
       call      qword ptr [r11]
       mov       rcx,rax
M00_L54:
       mov       [rbp-68],rcx
M00_L55:
       mov       rcx,[rbp-68]
       mov       r11,[rcx]
       mov       r11,7FFA02881E18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L58
       mov       rcx,[rbp-68]
       mov       r11,7FFA02881E20
       call      qword ptr [r11]
       mov       rdi,rax
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFA0293E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L55
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L56
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       short M00_L57
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L55
M00_L56:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFA02AAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L55
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       mov       rcx,[rbp-68]
       mov       r11,7FFA02881E28
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L60
       mov       rcx,[rbp-68]
       mov       r11,7FFA02881E28
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L61
       mov       rcx,rax
       mov       r11,7FFA02881E50
       call      qword ptr [r11]
M00_L61:
       nop
       add       rsp,28
       ret
; Total bytes of code 2593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFA53781408
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA031C6400]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CB5D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA031C6418]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFA02935A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFA032708A0
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EBEA8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA543E8070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA543F92E0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA543F5B40]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EB4E0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA543F7728]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA543E8078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543ED118]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M05_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L08
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M05_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M05_L12
M05_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M05_L10
       mov       rcx,r15
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M05_L09
M05_L02:
       mov       r15d,eax
M05_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M05_L07
M05_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L05
M05_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L08:
       mov       rdx,7FFA032053E8
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L09:
       mov       rcx,r15
       call      qword ptr [7FFA0293E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M05_L03
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L15
       jmp       short M05_L16
M05_L15:
       mov       rdx,7FFA03205400
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L17:
       call      qword ptr [7FFA02B57A08]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L12
M06_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M06_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L02
M06_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M06_L14
       mov       r13,[rsi+28]
       test      r13,r13
       jne       short M06_L03
       xor       eax,eax
       jmp       short M06_L04
M06_L02:
       mov       rdx,7FFA032053E8
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L01
M06_L03:
       mov       ecx,4
       call      qword ptr [7FFA030ACF18]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
M06_L04:
       mov       r13d,eax
M06_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M06_L10
M06_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M06_L19
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M06_L20
M06_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M06_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M06_L22
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M06_L21
M06_L09:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L10:
       cmp       eax,[rbp+8]
       jae       near ptr M06_L22
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        short M06_L15
M06_L11:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M06_L18
       test      eax,eax
       jge       short M06_L10
       jmp       near ptr M06_L06
M06_L12:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0293E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M06_L00
M06_L13:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L14:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       jmp       near ptr M06_L04
M06_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L16
       jmp       short M06_L17
M06_L16:
       mov       rdx,7FFA03205400
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L17:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L11
       mov       eax,[rsp+3C]
       mov       [rdi],eax
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L18:
       call      qword ptr [7FFA02B57A08]
       int       3
M06_L19:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L22
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M06_L08
M06_L20:
       mov       rcx,rbx
       call      qword ptr [7FFA03295ED8]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M06_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M06_L07
M06_L21:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02CBD848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA0293E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M06_L09
M06_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 741
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L00
       test      rbx,rbx
       je        near ptr M08_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M08_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M08_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       test      rbx,rbx
       je        short M08_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L02
M08_L01:
       mov       rax,28423FC0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       call      qword ptr [7FFA031C7A80]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M10_L01
       mov       r14d,4
M10_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M10_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EC6148]
       int       3
M10_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M10_L00
M10_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M10_L08
       test      r14d,r14d
       jg        short M10_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L04
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L08
M10_L04:
       mov       rdx,7FFA03205760
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M10_L09
       mov       rcx,rax
M10_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M10_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
M10_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M10_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L09:
       mov       rdx,7FFA031B2860
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L06
; Total bytes of code 309
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rdi,rdi
       je        near ptr M00_L42
       test      rsi,rsi
       je        near ptr M00_L41
       mov       r14,rsi
       mov       rcx,2C245C00B58
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       lea       rcx,[r13+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L43
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFA02965A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r12d
       mov       [r15+1C],ecx
M00_L03:
       mov       [rbp-78],r15
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-78]
       cmp       [r15],rcx
       jne       near ptr M00_L32
       lea       r14,[r15+8]
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L34
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L19
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r15+10]
M00_L05:
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L21
M00_L06:
       mov       r12,[r13+10]
       mov       rax,[r13+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L28
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L23
       mov       rcx,2C22FC00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L27
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0EAEF1E8
       mov       r9d,728BB9D6
       cmp       edx,8
       jb        near ptr M00_L14
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L15
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r13+8]
       mov       ecx,r10d
       imul      rcx,[r13+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L16
M00_L11:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L18
       mov       edx,[r13+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r13+28],ecx
       mov       rcx,[r13+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r13+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       cmp       edx,4
       jb        near ptr M00_L24
M00_L15:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L16:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L29
M00_L17:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L16
       jmp       near ptr M00_L11
M00_L18:
       mov       ecx,[r13+2C]
       mov       r11d,ecx
       dec       dword ptr [r13+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L19:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L20:
       mov       rcx,r15
       mov       r11,7FFA028B1F38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L21:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA0296E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L22:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L23:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L24:
       mov       r11d,80
       test      dl,1
       je        short M00_L25
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L25:
       test      dl,2
       je        short M00_L26
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L27:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFA028B1F48
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L29:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFA028B1F50
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L17
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r13
       call      qword ptr [7FFA03377030]
       mov       rcx,[r13+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FFA02CED848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FFA0296E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r15
       mov       r11,7FFA028B1F30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L47
M00_L33:
       call      qword ptr [7FFA02B87A08]
       int       3
M00_L34:
       call      qword ptr [7FFA02B8C138]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r13+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L48
M00_L37:
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r8
       jne       near ptr M00_L53
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L52
       mov       r14d,[rdi+14]
       xor       r15d,r15d
       cmp       r14d,[rdi+14]
       jne       near ptr M00_L51
M00_L38:
       cmp       r15d,[rdi+10]
       jae       short M00_L40
       mov       r8,[rdi+8]
       cmp       r15d,[r8+8]
       jae       near ptr M00_L59
       mov       r12,[r8+r15*8+10]
       inc       r15d
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA0296E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L49
M00_L39:
       cmp       r14d,[rdi+14]
       je        short M00_L38
       jmp       near ptr M00_L51
M00_L40:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFA0325A510
       cmp       [rcx],ecx
       call      qword ptr [7FFA032265F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L41:
       call      qword ptr [7FFA02EFE610]
       mov       ecx,708
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rsi,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C44878
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D66BA0
       call      qword ptr [7FFA02B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0317C018]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0317C030]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       jmp       near ptr M00_L40
M00_L43:
       mov       r8,r15
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA0337C3F0]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFA03377F78]
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,r14
       mov       r11,7FFA028B1F20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C245C00D68
       mov       r15,[rcx]
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,r14
       mov       r11,7FFA028B1F28
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L47:
       mov       rcx,r15
       mov       r11,7FFA028B1F40
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L48:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFA03377F90]
       jmp       near ptr M00_L37
M00_L49:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L50
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L50:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02ADE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L51:
       call      qword ptr [7FFA02B8C138]
       int       3
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C245C00D68
       mov       rcx,[rcx]
       jmp       short M00_L54
M00_L53:
       mov       rcx,rdi
       mov       r11,7FFA028B1F00
       call      qword ptr [r11]
       mov       rcx,rax
M00_L54:
       mov       [rbp-68],rcx
M00_L55:
       mov       rcx,[rbp-68]
       mov       r11,[rcx]
       mov       r11,7FFA028B1F08
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L58
       mov       rcx,[rbp-68]
       mov       r11,7FFA028B1F10
       call      qword ptr [r11]
       mov       rdi,rax
       lea       r8,[rbp-50]
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFA0296E940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L55
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L56
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       short M00_L57
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L55
M00_L56:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFA02ADE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L55
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       mov       rcx,[rbp-68]
       mov       r11,7FFA028B1F18
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L60
       mov       rcx,[rbp-68]
       mov       r11,7FFA028B1F18
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L61
       mov       rcx,rax
       mov       r11,7FFA028B1F40
       call      qword ptr [r11]
M00_L61:
       nop
       add       rsp,28
       ret
; Total bytes of code 2593
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFA53781408
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA0317D8C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CE5D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA0317D8D8]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFA02965A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFA03398FD8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 169
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EBEA8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA543E8070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA543F92E0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA543F5B40]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543EB4E0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA543F7728]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA543E8078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA543E7FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFA543ED118]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M05_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L08
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M05_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M05_L12
M05_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M05_L10
       mov       rcx,r15
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M05_L09
M05_L02:
       mov       r15d,eax
M05_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M05_L07
M05_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L05
M05_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L08:
       mov       rdx,7FFA031F8690
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L09:
       mov       rcx,r15
       call      qword ptr [7FFA0296E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M05_L03
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M05_L04
M05_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L15
       jmp       short M05_L16
M05_L15:
       mov       rdx,7FFA031F86A8
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L17:
       call      qword ptr [7FFA02B87A08]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L16
M06_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M06_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L15
M06_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M06_L23
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M06_L18
       mov       rcx,2C22FC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M06_L22
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0EAEF1E8
       mov       r8d,728BB9D6
       cmp       edx,8
       jb        near ptr M06_L10
       mov       r10d,edx
       shr       r10d,3
M06_L02:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M06_L02
       test      dl,4
       jne       near ptr M06_L11
M06_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M06_L04:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M06_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M06_L12
M06_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M06_L14
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M06_L28
M06_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M06_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M06_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M06_L29
M06_L09:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L10:
       cmp       edx,4
       jb        near ptr M06_L19
M06_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M06_L03
M06_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M06_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M06_L24
M06_L13:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M06_L27
       test      eax,eax
       jge       short M06_L12
       jmp       near ptr M06_L06
M06_L14:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M06_L08
M06_L15:
       mov       rdx,7FFA031F8690
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L01
M06_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0296E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M06_L00
M06_L17:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L18:
       xor       r13d,r13d
       jmp       near ptr M06_L05
M06_L19:
       mov       r10d,80
       test      dl,1
       je        short M06_L20
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M06_L20:
       test      dl,2
       je        short M06_L21
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L21:
       mov       ecx,r10d
       jmp       near ptr M06_L04
M06_L22:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L23:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M06_L05
M06_L24:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L25
       jmp       short M06_L26
M06_L25:
       mov       rdx,7FFA031F86A8
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L26:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L13
       mov       eax,[rsp+3C]
       mov       [rdi],eax
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L27:
       call      qword ptr [7FFA02B87A08]
       int       3
M06_L28:
       mov       rcx,rbx
       call      qword ptr [7FFA03377030]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M06_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M06_L07
M06_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02CED848]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA0296E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M06_L09
M06_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1104
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M08_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M08_L01
       test      rsi,rsi
       je        short M08_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M08_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       test      rsi,rsi
       je        short M08_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M08_L03
M08_L02:
       mov       rax,302C4B40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       call      qword ptr [7FFA0322C648]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFA02965C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M10_L04
       mov       r15d,4
M10_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M10_L07
       cmp       [r14+8],r15d
       je        short M10_L03
       test      r15d,r15d
       jle       near ptr M10_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M10_L05
       mov       rcx,rax
M10_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M10_L06
M10_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M10_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M10_L00
M10_L05:
       mov       rdx,7FFA03098160
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L01
M10_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFA02AD5050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M10_L02
M10_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA02EF6148]
       int       3
M10_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M10_L09
       jmp       short M10_L10
M10_L09:
       mov       rdx,7FFA03183100
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M10_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L03
; Total bytes of code 321
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFA0319ED80
       call      qword ptr [7FFA03147AB0]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFA0319F610
       call      qword ptr [7FFA0314D350]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFA0314D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       call      qword ptr [7FFA8B017CF8]
       mov       rcx,rax
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFA8B01A200]; Precode of System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       add       rsp,30
       pop       rbx
       ret
M01_L00:
       call      qword ptr [7FFA8B0195C8]
       int       3
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031888A8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rax,293590230F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,29359010008
       call      qword ptr [7FFA02EDEB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A33600]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0314D530]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0314D500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFA0319ED80
       call      qword ptr [7FFA03147AE0]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFA0319F610
       call      qword ptr [7FFA0314D380]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFA0314D3B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M01_L07
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L01:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L23
       mov       rcx,[rsi+18]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M01_L09
M01_L02:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L03:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L15
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L12
M01_L05:
       xor       edx,edx
       mov       [rbp-28],edx
       xor       esi,esi
M01_L06:
       cmp       byte ptr [rbp-28],0
       je        near ptr M01_L24
       mov       rcx,7FFA0339907C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       mov       rdx,7FFA0337DB68
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA031DA3E8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA031DA3C8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA0337DB88
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA0337DE00
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L04
M01_L12:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
M01_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA0337DE88
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L13
M01_L15:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M01_L21
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rax
       mov       r11,7FFA02891448
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L22
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L18
M01_L17:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M01_L19
M01_L18:
       mov       rcx,rdi
       mov       rdx,7FFA0337DD48
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L17
M01_L19:
       mov       rcx,[rbp-30]
       mov       r11,7FFA02891450
       call      qword ptr [r11]
       jmp       near ptr M01_L06
M01_L20:
       mov       ecx,11
       call      qword ptr [7FFA02B67E58]
       int       3
M01_L21:
       mov       rcx,rdi
       mov       rdx,7FFA0337DC90
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L16
M01_L22:
       call      M01_L25
       jmp       near ptr M01_L05
M01_L23:
       lea       rdx,[rbp-28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L24:
       mov       rcx,7FFA03399078
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFA03145620]
       int       3
M01_L25:
       sub       rsp,28
       mov       rcx,[rbp-30]
       test      rcx,rcx
       je        short M01_L26
       mov       r11,7FFA02891450
       call      qword ptr [r11]
M01_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 694
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031888A8
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rax,2B0B2E130F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2B0B2E00008
       call      qword ptr [7FFA02EDEB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A33600]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0314D560]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0314D530]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFA031CED70
       call      qword ptr [7FFA03177AC8]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFA031CF600
       call      qword ptr [7FFA0317D350]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFA0317D380]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M01_L07
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L01:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L23
       mov       rcx,[rsi+18]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M01_L09
M01_L02:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L03:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L15
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L12
M01_L05:
       xor       edx,edx
       mov       [rbp-28],edx
       xor       esi,esi
M01_L06:
       cmp       byte ptr [rbp-28],0
       je        near ptr M01_L24
       mov       rcx,7FFA033C91B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       mov       rdx,7FFA033AEA70
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA0320A328
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA0320A308
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA033AEA90
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA033AED08
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L04
M01_L12:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
M01_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA033AED90
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L13
M01_L15:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M01_L21
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rax
       mov       r11,7FFA028C1488
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L22
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L18
M01_L17:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M01_L19
M01_L18:
       mov       rcx,rdi
       mov       rdx,7FFA033AEC50
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L17
M01_L19:
       mov       rcx,[rbp-30]
       mov       r11,7FFA028C1490
       call      qword ptr [r11]
       jmp       near ptr M01_L06
M01_L20:
       mov       ecx,11
       call      qword ptr [7FFA02B97E58]
       int       3
M01_L21:
       mov       rcx,rdi
       mov       rdx,7FFA033AEB98
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L16
M01_L22:
       call      M01_L25
       jmp       near ptr M01_L05
M01_L23:
       lea       rdx,[rbp-28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L24:
       mov       rcx,7FFA033C91B0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFA03175638]
       int       3
M01_L25:
       sub       rsp,28
       mov       rcx,[rbp-30]
       test      rcx,rcx
       je        short M01_L26
       mov       r11,7FFA028C1490
       call      qword ptr [r11]
M01_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 694
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA031B88A8
       call      qword ptr [7FFA02B97B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rax,1B9CC3130F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1B9CC300008
       call      qword ptr [7FFA02F0EB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A63600]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0317D530]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0317D500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L00
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       short M00_L02
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L10
       mov       r14d,[rsi+10]
M00_L01:
       test      r14d,r14d
       jle       near ptr M00_L12
       mov       dword ptr [rbp-40],1
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L11
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L29
       mov       r14,[rcx+10]
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L13
       mov       rsi,[rdi+8]
       mov       r15d,[rdi+10]
       test      rsi,rsi
       je        near ptr M00_L14
       mov       r13d,[rsi+8]
       cmp       r13d,r15d
       jb        near ptr M00_L15
       test      r14,r14
       je        near ptr M00_L16
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L20
       cmp       r13d,r15d
       jl        near ptr M00_L22
M00_L03:
       mov       ecx,r12d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       rdx,r14
       mov       r11,7FFA028A1B70
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L21
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L28
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L27
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L27
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L27
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L27
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L27
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L26
       cmp       rax,4000
       ja        near ptr M00_L25
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L24
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L29
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L08:
       call      qword ptr [7FFA0303D5D8]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFA02B77E58]
       int       3
M00_L10:
       mov       rcx,rsi
       mov       r11,7FFA028A1B60
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,rsi
       mov       r11,7FFA028A1B68
       xor       edx,edx
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L12:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r14d,r14d
       jmp       near ptr M00_L02
M00_L13:
       call      qword ptr [7FFA0303D9B0]
       int       3
M00_L14:
       mov       ecx,2
       call      qword ptr [7FFA02B7C228]
       int       3
M00_L15:
       call      qword ptr [7FFA031EED30]
       int       3
M00_L16:
       xor       r9d,r9d
       jmp       short M00_L18
M00_L17:
       cmp       r9d,r13d
       jae       near ptr M00_L29
       mov       ecx,r9d
       cmp       qword ptr [rsi+rcx*8+10],0
       je        short M00_L19
       inc       r9d
M00_L18:
       cmp       r9d,r15d
       jl        short M00_L17
       jmp       short M00_L20
M00_L19:
       jmp       near ptr M00_L05
M00_L20:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L21:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L20
M00_L22:
       cmp       r12d,r13d
       jae       short M00_L29
       mov       ecx,r12d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L23
       mov       rdx,r14
       mov       r11,7FFA028A1B70
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L23:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L22
       jmp       short M00_L20
M00_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L25:
       mov       r8,rax
       call      qword ptr [7FFA03035620]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L26:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L27:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031EC858]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L28:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 840
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L06
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L09
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L10
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L04
       jmp       short M03_L05
M03_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L10:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
       jmp       short M03_L07
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFA028C1C90
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L00
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L01
M00_L00:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFA028C1C98
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       rsi,rcx
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L03:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFA028C1CA0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L21
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L08:
       call      qword ptr [7FFA031752F0]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFA02B97E58]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FFA031756C8]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFA02B9C228]
       int       3
M00_L13:
       call      qword ptr [7FFA032D73D8]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L05
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFA028C1CA0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFA02F0E568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031F4A50]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 759
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L00
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       short M00_L02
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L10
       mov       r14d,[rsi+10]
M00_L01:
       test      r14d,r14d
       jle       near ptr M00_L12
       mov       dword ptr [rbp-40],1
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L11
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L29
       mov       r14,[rcx+10]
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L13
       mov       rsi,[rdi+8]
       mov       r15d,[rdi+10]
       test      rsi,rsi
       je        near ptr M00_L14
       mov       r13d,[rsi+8]
       cmp       r13d,r15d
       jb        near ptr M00_L15
       test      r14,r14
       je        near ptr M00_L16
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L20
       cmp       r13d,r15d
       jl        near ptr M00_L22
M00_L03:
       mov       ecx,r12d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       rdx,r14
       mov       r11,7FFA02881BE0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L21
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L28
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L27
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L27
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L27
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L27
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L27
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L26
       cmp       rax,4000
       ja        near ptr M00_L25
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L24
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L29
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L08:
       call      qword ptr [7FFA0301D710]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFA02B57E58]
       int       3
M00_L10:
       mov       rcx,rsi
       mov       r11,7FFA02881BD0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,rsi
       mov       r11,7FFA02881BD8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L12:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r14d,r14d
       jmp       near ptr M00_L02
M00_L13:
       call      qword ptr [7FFA0301DAE8]
       int       3
M00_L14:
       mov       ecx,2
       call      qword ptr [7FFA02B5C228]
       int       3
M00_L15:
       call      qword ptr [7FFA031AED60]
       int       3
M00_L16:
       xor       r9d,r9d
       jmp       short M00_L18
M00_L17:
       cmp       r9d,r13d
       jae       near ptr M00_L29
       mov       ecx,r9d
       cmp       qword ptr [rsi+rcx*8+10],0
       je        short M00_L19
       inc       r9d
M00_L18:
       cmp       r9d,r15d
       jl        short M00_L17
       jmp       short M00_L20
M00_L19:
       jmp       near ptr M00_L05
M00_L20:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L21:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L20
M00_L22:
       cmp       r12d,r13d
       jae       short M00_L29
       mov       ecx,r12d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        short M00_L23
       mov       rdx,r14
       mov       r11,7FFA02881BE0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L23:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L22
       jmp       short M00_L20
M00_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L25:
       mov       r8,rax
       call      qword ptr [7FFA03015620]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L26:
       mov       r8,rax
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L27:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031AC7F8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L28:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 840
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       cmp       [rdx],rcx
       je        short M01_L02
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFA028A1EC8
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M00_L05
       xor       ecx,ecx
       mov       [rbp-40],ecx
M00_L00:
       mov       rsi,rcx
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L02:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFA028A1ED8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L03:
       mov       r9d,r12d
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jb        short M00_L06
       call      qword ptr [7FFA0316C918]
       int       3
M00_L05:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFA028A1ED0
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L06:
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L07
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L21
M00_L07:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L08:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFA02B77E58]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFA0316CCF0]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFA02B7C228]
       int       3
M00_L13:
       call      qword ptr [7FFA0336C0D8]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L04
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L02
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFA028A1ED8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L07
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFA03055380]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA0305E8C8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L07
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L08
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 762
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029566E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFA028B24E0
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M00_L05
       xor       ecx,ecx
       mov       [rbp-40],ecx
M00_L00:
       mov       rsi,rcx
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L02:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFA028B24F0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L03:
       mov       r9d,r12d
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jb        short M00_L06
       call      qword ptr [7FFA03175350]
       int       3
M00_L05:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFA028B24E8
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L06:
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L07
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       near ptr M00_L21
M00_L07:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L08:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFA02B87E58]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFA0317E0E8]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFA02B8C228]
       int       3
M00_L13:
       call      qword ptr [7FFA0339CD20]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L04
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L02
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFA028B24F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L07
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFA02EFE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA03076238]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L07
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L08
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 762
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA6254DC70
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       jne       short M03_L02
       test      r8b,4
       je        short M03_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA029666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M04_L09
       test      rsi,rsi
       je        near ptr M04_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L10
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M04_L07
       sub       edi,eax
       js        near ptr M04_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA543F9368]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M04_L06
       sub       ebp,eax
       js        near ptr M04_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA543F9288]
       test      eax,eax
       je        short M04_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M04_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543FC900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M04_L15
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       cmp       r8,4000
       jbe       short M04_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M04_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA543F9608]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L02
       jmp       near ptr M04_L14
M04_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFA544108D0]
       int       3
M04_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA543FB1E8]
       int       3
M04_L10:
       call      qword ptr [7FFA543F2768]
       mov       rbx,rax
       call      qword ptr [7FFA543FDD30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FC790]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFA544108B8]
       int       3
M04_L12:
       call      qword ptr [7FFA543F2530]
       mov       rdi,rax
       call      qword ptr [7FFA543FCBE8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFA543FB198]
       mov       rcx,rdi
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L13:
       call      qword ptr [7FFA543F2530]
       mov       rbp,rax
       call      qword ptr [7FFA543FCBE0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFA543FB198]
       mov       rcx,rbp
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
M04_L14:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L02
M04_L15:
       call      qword ptr [7FFA543E8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L16:
       call      qword ptr [7FFA543F2558]
       mov       rbx,rax
       call      qword ptr [7FFA543FD6B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA543FB218]
       mov       rcx,rbx
       call      qword ptr [7FFA543E7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFA02D36858
       call      qword ptr [7FFA02D44108]; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFA0314C538
       call      qword ptr [7FFA03135668]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFA03135698]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       call      qword ptr [7FFA8B017E10]
       mov       rcx,rax
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFA8B01A238]; Precode of System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       add       rsp,30
       pop       rbx
       ret
M01_L00:
       call      qword ptr [7FFA8B0195C8]
       int       3
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03126D10
       call      qword ptr [7FFA02B57B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1644BBC30F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1644BBB0008
       call      qword ptr [7FFA02EC6DF0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			var index = list.LastIndexOf(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031356E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].LastIndexOf(System.__Canon)
       mov       [rbp-0C],eax
; 			if (index >= 0)
; 			^^^^^^^^^^^^^^^
       cmp       dword ptr [rbp-0C],0
       jl        short M02_L02
; 				list.RemoveAt(index);
; 				^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       edx,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A23610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
; 				return true;
; 				^^^^^^^^^^^^
       mov       eax,1
       add       rsp,50
       pop       rbp
       ret
; 			return false;
; 			^^^^^^^^^^^^^
M02_L02:
       xor       eax,eax
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA03135818]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA031357E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFA02D56858
       call      qword ptr [7FFA02D64108]; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFA031AF588
       call      qword ptr [7FFA0315D380]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFA0315D3B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       call      qword ptr [7FFA8B017E10]
       mov       rcx,rax
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFA8B01A238]; Precode of System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       add       rsp,30
       pop       rbx
       ret
M01_L00:
       call      qword ptr [7FFA8B0195C8]
       int       3
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFA03198800
       call      qword ptr [7FFA02B77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2619A9330F0
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2619A920008
       call      qword ptr [7FFA02EEEB50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			var index = list.LastIndexOf(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0315D3F8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].LastIndexOf(System.__Canon)
       mov       [rbp-0C],eax
; 			if (index >= 0)
; 			^^^^^^^^^^^^^^^
       cmp       dword ptr [rbp-0C],0
       jl        short M02_L02
; 				list.RemoveAt(index);
; 				^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       edx,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02A43610]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
; 				return true;
; 				^^^^^^^^^^^^
       mov       eax,1
       add       rsp,50
       pop       rbp
       ret
; 			return false;
; 			^^^^^^^^^^^^^
M02_L02:
       xor       eax,eax
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA0315D530]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0315D500]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA02891A88
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B67E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA02891A78
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA02891A80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA0302D950]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA0314F1E0]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA031DEB68]
       int       3
M00_L20:
       call      qword ptr [7FFA031DEB50]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA02891A88
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA0302D578]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E5D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       cmp       [rdx],rcx
       je        short M01_L02
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L05
       cmp       rax,4000
       ja        short M02_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L02
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L01:
       add       rsp,38
       ret
M02_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA03025608]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       r8,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031DC678]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA028A1D78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B77E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA028A1D68
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA028A1D70
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA03155608]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA0315FAE0]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EE6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02EE6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02EE6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B7C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA032B70D8]
       int       3
M00_L20:
       call      qword ptr [7FFA032B70C0]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA028A1D78
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA03155230]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E6D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFA02955818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EEE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031D4978]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA02891C40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B67E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA02891C30
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA02891C38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA03145680]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA031D4438]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA032A72D0]
       int       3
M00_L20:
       call      qword ptr [7FFA032A72B8]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA02891C40
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA031452A8]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E5D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EDE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA0314FD08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA02891D48
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B67E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA02891D38
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA02891D40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA030B50C8]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA030BF570]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02ED6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B6C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA032A7210]
       int       3
M00_L20:
       call      qword ptr [7FFA032A71F8]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA02891D48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA030B4CF0]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E5D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA0304CDB0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA031C4DC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA028B1F28
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B87E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA028B1F18
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA028B1F20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA0316CAB0]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA032371E0]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B8C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA0336C0D8]
       int       3
M00_L20:
       call      qword ptr [7FFA0336C0C0]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA028B1F28
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA0316C6D8]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E7D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L05
       cmp       rax,4000
       ja        short M02_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L02
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L01:
       add       rsp,38
       ret
M02_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EFE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       r8,rax
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA03076550]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFA028B2658
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFA02B87E58]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFA028B2648
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFA028B2650
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFA0318E118]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFA03394438]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFA02EF6148]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFA02B8C228]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFA0339CCC0]
       int       3
M00_L20:
       call      qword ptr [7FFA0339CCA8]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFA028B2658
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFA03185338]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA02E7D0B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L05
       cmp       rax,4000
       ja        short M02_L04
       mov       r8,rax
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L02
M02_L00:
       cmp       dword ptr [7FFA628A3B10],0
       jne       short M02_L03
M02_L01:
       add       rsp,38
       ret
M02_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFA02EFE568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       r8,rax
       call      qword ptr [7FFA02965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFA03076598]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

