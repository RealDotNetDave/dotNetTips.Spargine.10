## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C41C000]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       call      qword ptr [7FF86C417E10]; System.Threading.CancellationToken.get_None()
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r9,[rbp-18]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF86C41C018]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C417FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C41C030]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       call      qword ptr [7FF86C417E10]; System.Threading.CancellationToken.get_None()
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r9,[rbp-30]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF86C41C018]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C417FA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C453F10
       call      qword ptr [7FF86C417FC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+50]
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
       call      qword ptr [7FF86C417D08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FF86C41C048]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF86C41C0A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C41C078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,[rax+58]
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
       mov       rdx,7FF86C439118
       call      qword ptr [7FF86BE3C420]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C41C0A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C41C0C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3E6340]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       mov       r8d,14
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3E6358]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-1C],eax
       mov       edx,[rbp-1C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3E62F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3E6370]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp-10]
       mov       r8d,0A
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3E6358]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
       mov       [rbp-2C],eax
       mov       edx,[rbp-2C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3E62F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C3FC730
       call      qword ptr [7FF86C3E6310]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+50]
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
       call      qword ptr [7FF86C3E6058]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       call      qword ptr [7FF86C3E6388]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, Int32)
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
       call      qword ptr [7FF86C3E63E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3E63B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,[rax+58]
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
       mov       rdx,7FF86C3DC7D0
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M05_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3E63E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3E6400]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F67D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       ecx,14
       call      qword ptr [7FF86C1271F8]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-18],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F67F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-34],eax
       mov       edx,[rbp-34]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6808]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       mov       ecx,0A
       call      qword ptr [7FF86C1271F8]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-30],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F67F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
       mov       [rbp-38],eax
       mov       edx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C409D40
       call      qword ptr [7FF86C3F67A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+50]
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
       call      qword ptr [7FF8AC23F360]
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
       call      qword ptr [7FF86C3F64F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M03_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF86C3F6820]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon, System.TimeSpan)
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
       call      qword ptr [7FF86C3F6898]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F6868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,[rax+58]
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
       mov       rdx,7FF86C3D8708
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M06_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6898]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F68B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+2E8]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-18],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F67A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F67C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
       mov       [rbp-28],rax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F67A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C409CD8
       call      qword ptr [7FF86C3F6760]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+50]
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
       mov       rdx,7FF86C3D84A8
       call      qword ptr [7FF86BBFC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1A71251BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,1A712510008
       call      qword ptr [7FF86C014210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		if (this.IsNotInCollection(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF86C3F64C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].IsNotInCollection(System.__Canon)
       test      eax,eax
       je        short M02_L02
; 			base.Add(item, cancellationToken);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF86C3F67F0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.Threading.CancellationToken)
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
       mov       rax,[rax+58]
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
       mov       rdx,7FF86C3D8638
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6868]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F6820]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

