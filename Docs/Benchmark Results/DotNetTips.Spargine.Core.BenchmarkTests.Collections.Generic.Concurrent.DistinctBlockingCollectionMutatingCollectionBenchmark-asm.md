## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimeoutAndCancellationToken()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1FC1E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       call      qword ptr [7FF8AC1FC000]; System.Threading.CancellationToken.get_None()
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r9,[rbp-18]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1FC1F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1FC198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1FC210]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       call      qword ptr [7FF8AC1FC000]; System.Threading.CancellationToken.get_None()
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r9,[rbp-30]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1FC1F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1FC198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC234A38
       call      qword ptr [7FF8AC1FC1B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 228
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
; System.Threading.CancellationToken.get_None()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC1F7EE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FF8AC1FC228]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       nop
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M03_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 96
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
       call      qword ptr [7FF8AC1FC288]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1FC258]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M06_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M06_L01
M06_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC2192E0
       call      qword ptr [7FF8ABC1C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1FC288]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1FC2A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimeoutAndCancellationToken()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2166A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       call      qword ptr [7FF8AC2164C0]; System.Threading.CancellationToken.get_None()
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r9,[rbp-18]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2166B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216658]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2166D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       call      qword ptr [7FF8AC2164C0]; System.Threading.CancellationToken.get_None()
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r9,[rbp-30]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2166B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216658]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC237F28
       call      qword ptr [7FF8AC216670]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 228
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
; System.Threading.CancellationToken.get_None()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC2163B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FF8AC2166E8]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       nop
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M03_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 96
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
       call      qword ptr [7FF8AC216748]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC216718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M06_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M06_L01
M06_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC208490
       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216748]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC216760]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimeout()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E67C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E67D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-1C],eax
       mov       edx,[rbp-1C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E67F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp-10]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E67D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-2C],eax
       mov       edx,[rbp-2C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC2090C0
       call      qword ptr [7FF8AC1E6790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 201
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC1E64D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       call      qword ptr [7FF8AC1E6808]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M02_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 88
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
       call      qword ptr [7FF8AC1E6868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M05_L01
M05_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1D85C0
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6880]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimeout()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-1C],eax
       mov       edx,[rbp-1C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp-10]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-2C],eax
       mov       edx,[rbp-2C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC228548
       call      qword ptr [7FF8AC206790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 201
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC2064D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       call      qword ptr [7FF8AC206808]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M02_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 88
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
       call      qword ptr [7FF8AC206868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M05_L01
M05_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1F85C0
       call      qword ptr [7FF8ABC37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206880]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimespan()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0EE9B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       ecx,14
       call      qword ptr [7FF8ABF37048]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0EE9D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0EE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0EE9E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       ecx,0A
       call      qword ptr [7FF8ABF37048]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0EE9D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0EE970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC1C3F10
       call      qword ptr [7FF8AC0EE988]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 227
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
; System.TimeSpan.FromMilliseconds(Int64)
       sub       rsp,28
       mov       rax,346DC5D638865
       cmp       rcx,rax
       jg        short M02_L00
       mov       rax,0FFFCB923A29C779B
       cmp       rcx,rax
       jl        short M02_L00
       imul      rax,rcx,2710
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF90A68F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, timeout);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC0EE6D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8AC0EEA00]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       nop
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M03_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 88
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
       call      qword ptr [7FF8AC0EEA78]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0EEA48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M06_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M06_L01
M06_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1BAE08
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0EEA78]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0EEA90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAddWithTimespan()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2166D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       ecx,14
       call      qword ptr [7FF8ABF57048]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2166E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216688]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216700]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       ecx,0A
       call      qword ptr [7FF8ABF57048]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2166E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216688]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC237F28
       call      qword ptr [7FF8AC2166A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 227
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
; System.TimeSpan.FromMilliseconds(Int64)
       sub       rsp,28
       mov       rax,346DC5D638865
       cmp       rcx,rax
       jg        short M02_L00
       mov       rax,0FFFCB923A29C779B
       cmp       rcx,rax
       jl        short M02_L00
       imul      rax,rcx,2710
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF90A68F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, timeout);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC2163E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8AC216718]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       nop
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
M03_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 88
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
       call      qword ptr [7FF8AC216790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC216760]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M06_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M06_L01
M06_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC2084D8
       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC216790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2167A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC228060
       call      qword ptr [7FF8AC206778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 177
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+48]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-20]
       mov       rdx,7FF8AC1F8390
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,286120CBB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,286120C0008
       call      qword ptr [7FF8ABFBF468]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		if (this.IsNotInCollection(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC2064D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L02
; 			base.Add(item, cancellationToken);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8AC206808]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
M02_L02:
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1F8520
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206880]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2067A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC2284D0
       call      qword ptr [7FF8AC206760]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 177
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+48]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-20]
       mov       rdx,7FF8AC1F8390
       call      qword ptr [7FF8ABA1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,264AE09BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,264AE090008
       call      qword ptr [7FF8ABFBF468]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		if (this.IsNotInCollection(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC2064C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L02
; 			base.Add(item, cancellationToken);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8AC2067F0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
M02_L02:
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1F8520
       call      qword ptr [7FF8ABC37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206820]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC21DF48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC2284D0
       call      qword ptr [7FF8AC206760]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-50],3E8
M01_L00:
       mov       eax,[rbp-50]
       dec       eax
       mov       [rbp-50],eax
       cmp       dword ptr [rbp-50],0
       jg        short M01_L01
       lea       rcx,[rbp-50]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
; 		while (this.TryTake(out _))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2067A8]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L02
       mov       rcx,7FF8AC228550
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L02:
       mov       rcx,7FF8AC228554
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L00
; Total bytes of code 113
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
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1F86B0
       call      qword ptr [7FF8ABC37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206940]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC2068F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC20DAC0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC218060
       call      qword ptr [7FF8AC1F6778]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-50],3E8
M01_L00:
       mov       eax,[rbp-50]
       dec       eax
       mov       [rbp-50],eax
       cmp       dword ptr [rbp-50],0
       jg        short M01_L01
       lea       rcx,[rbp-50]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
; 		while (this.TryTake(out _))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F67C0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L02
       mov       rcx,7FF8AC2180E0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L02:
       mov       rcx,7FF8AC2180E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L00
; Total bytes of code 113
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
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1E8638
       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6958]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6910]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6250]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-1C],eax
       mov       edx,[rbp-1C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6748]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F67A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6250]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-2C],eax
       mov       edx,[rbp-2C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6748]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC218538
       call      qword ptr [7FF8AC1F6760]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 189
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return item is null || !this.IsNotInCollection(item) ? false : base.TryAdd(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC1F64A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8AC1F64C0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 72
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
       call      qword ptr [7FF8AC1F67F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F67C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
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
       je        short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M05_L01
M05_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8AC1E8588
       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F67F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6808]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

