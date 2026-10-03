## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C02DE60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2F0]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C435998
       call      qword ptr [7FF86C4064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-8],eax
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C4064F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FF86C406508]; System.Array.Clear(System.Array, Int32, Int32)
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FF86C406508]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FF86BE4DA10]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C406520]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 210
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
       mov       rdx,7FF86C417780
       call      qword ptr [7FF86BE47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C406598]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C406550]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BFFDE60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2F0]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C3F9398
       call      qword ptr [7FF86C3D6058]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-8],eax
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3D60A0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FF86C3D60B8]; System.Array.Clear(System.Array, Int32, Int32)
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FF86C3D60B8]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FF86BE1DA10]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3D60D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 210
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
       mov       rdx,7FF86C3E9318
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3D6148]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3D6100]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BFFDE60]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2F0]
       mov       rcx,[rbp+10]
       mov       rdx,7FF86C405390
       call      qword ptr [7FF86C3D63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3E7698
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3D6490]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3D6448]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2F0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C405F50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C01DE78]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C405F38]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF86C405F80]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 54
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
       call      qword ptr [7FF86C405FC8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C405F98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2F0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F64F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C01DE78]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F64D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
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
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF86C3F6520]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 54
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
       call      qword ptr [7FF86C3F6568]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F6538]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2F0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C2EE7D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C00DE78]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C2EE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
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
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C2EE850]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C2EE820]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C020698]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FF86C405998
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF86C4059A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FF86BB40A50
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3D64C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3D64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF86C405AA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FF86BB40A48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FF86C405CC4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FF86C405BB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FF86C405BB8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FF86BB40A58
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FF86C405CC0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FF8AC22DB38]
       mov       rcx,[rbx+8]
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L00
       mov       rcx,rsi
       call      qword ptr [7FF8AC22DB60]
       mov       rcx,[rbx+8]
       mov       r11,rax
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L00:
       mov       rcx,rsi
       call      qword ptr [7FF8AC22BC88]
       mov       rcx,rax
       call      qword ptr [7FF8AC2290A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M02_L00
       mov       rax,[rbp-38]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-30]
       mov       rdx,7FF86C31BA60
       call      qword ptr [7FF86BBFC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,298F06CBC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,298F06C0008
       call      qword ptr [7FF86C014240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M02_L02
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-40]
       mov       rdx,7FF86C31BA80
       call      qword ptr [7FF86BBFC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       r8d,[rbp-24]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FF86C2FEA48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 279
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
       call      qword ptr [7FF86C3D6730]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3D6700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C040698]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FF86C425998
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF86C4259A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FF86BB60A50
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F64A8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF86C425AA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FF86BB60A48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FF86C425CC4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FF86C425BB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FF86C425BB8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FF86BB60A58
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FF86C425CC0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FF8AC22DB38]
       mov       rcx,[rbx+8]
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L00
       mov       rcx,rsi
       call      qword ptr [7FF8AC22DB60]
       mov       rcx,[rbx+8]
       mov       r11,rax
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L00:
       mov       rcx,rsi
       call      qword ptr [7FF8AC22BC88]
       mov       rcx,rax
       call      qword ptr [7FF8AC2290A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M02_L00
       mov       rax,[rbp-38]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-30]
       mov       rdx,7FF86C33BA60
       call      qword ptr [7FF86BC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,28DC602BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,28DC6020008
       call      qword ptr [7FF86C034240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M02_L02
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-40]
       mov       rdx,7FF86C33BA80
       call      qword ptr [7FF86BC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       r8d,[rbp-24]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FF86C31EA30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 279
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
       call      qword ptr [7FF86C3F6718]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F66E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C040698]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FF86C425988
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF86C425990
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FF86BB60FA0
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2F0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F64C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3F64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF86C425A98
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FF86BB60F98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FF86C425CB4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FF86C425BA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FF86C425BA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FF86BB60FA8
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FF86C425CB0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L00
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp-40]
       mov       rdx,7FF86C33BA60
       call      qword ptr [7FF86BC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L01:
       mov       rax,1CF8FE4BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,1CF8FE40008
       call      qword ptr [7FF86C034240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M01_L02
       mov       rax,[rbp-58]
       mov       [rbp-20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-50]
       mov       rdx,7FF86C33BA80
       call      qword ptr [7FF86BC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L03:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,7FF86C4F9BE8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-34],eax
       mov       r8d,[rbp-34]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FF86C31EA60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 332
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
       call      qword ptr [7FF86C3F6730]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3F6700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

