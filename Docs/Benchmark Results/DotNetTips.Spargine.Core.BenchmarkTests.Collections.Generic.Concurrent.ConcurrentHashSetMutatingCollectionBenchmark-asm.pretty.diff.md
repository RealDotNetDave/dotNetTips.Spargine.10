## DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark-20260725-214457
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC202EE8
+       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
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
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
+       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
 ; 			this._budget = Math.Max(1, buckets.Length / lockCount);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
+       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
 ; 		}
 ; 		^
        nop
        add       rsp,28
        ret
 ; Total bytes of code 210
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
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1EAC10
+       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1E3690
+       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
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
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
+       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
 ; 			this._budget = Math.Max(1, buckets.Length / lockCount);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
+       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
 ; 		}
 ; 		^
        nop
        add       rsp,28
        ret
 ; Total bytes of code 210
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
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1CACF8
+       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1BFC10
+       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
-       mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
-       pop       rbp
-       ret
-M01_L00:
-       sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
-       add       rsp,28
-       ret
-; Total bytes of code 210
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
-       je        short M02_L00
+       je        short M01_L00
        mov       rax,[rbp-20]
        mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
+       jmp       short M01_L01
+M01_L00:
        mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1C7AF8
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6BE0]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6C10]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC0C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC277810]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC232E60
-       call      qword ptr [7FF8AC1EC378]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1EC3D8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2E298]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2B7930]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC3F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC217408
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1EC468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1EC420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1E3690
+       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
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
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
+       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
 ; 			this._budget = Math.Max(1, buckets.Length / lockCount);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
+       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
 ; 		}
 ; 		^
        nop
        add       rsp,28
        ret
 ; Total bytes of code 210
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
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1CACF8
+       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1BFC10
+       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
-       mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
-       pop       rbp
-       ret
-M01_L00:
-       sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
-       add       rsp,28
-       ret
-; Total bytes of code 210
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
-       je        short M02_L00
+       je        short M01_L00
        mov       rax,[rbp-20]
        mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
+       jmp       short M01_L01
+M01_L00:
        mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1C7AF8
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6BE0]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6C10]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC0C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC277810]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC202EE8
-       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62B0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1D62C8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC2DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2B7930]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1EAC10
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6310]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1E3690
-       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1BFC10
+       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
-       mov       ecx,1
-       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
-       pop       rbp
-       ret
-M01_L00:
-       sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
-       add       rsp,28
-       ret
-; Total bytes of code 210
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
-       je        short M02_L00
+       je        short M01_L00
        mov       rax,[rbp-20]
        mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
+       jmp       short M01_L01
+M01_L00:
        mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1CACF8
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1C7AF8
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1E3690
-       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6BE0]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1CACF8
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1E3690
-       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6C10]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1CACF8
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1E3690
-       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC0C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC277810]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1CACF8
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDDACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1E3690
-       call      qword ptr [7FF8AC1B63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp-28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp-20],ymm4
-       mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       r8d,[rax+8]
-       mov       rcx,[rbp-20]
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8AC1B6418]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8ABC0DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       add       rsp,50
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2B7930]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-M01_L00:
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
-       nop
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
        add       rsp,28
        ret
-; Total bytes of code 210
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1CACF8
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1B64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1B6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1BFC10
-       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
+       xor       eax,eax
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
+       xor       eax,eax
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
+       xor       edx,edx
+       div       r14d
+       mov       ecx,1
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6BE0]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE1A8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE0B8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
+       add       rsp,28
+       ret
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M01_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1C7AF8
-       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1BFC10
-       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
+       xor       eax,eax
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
+       xor       eax,eax
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
+       xor       edx,edx
+       div       r14d
+       mov       ecx,1
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2A6C10]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC1EE118]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EE028]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
+       add       rsp,28
+       ret
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M01_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1C7AF8
-       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1BFC10
-       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
+       xor       eax,eax
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
+       xor       eax,eax
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
+       xor       edx,edx
+       div       r14d
+       mov       ecx,1
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC0C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC277810]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0CE328]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0CE160]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
+       add       rsp,28
+       ret
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M01_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1C7AF8
-       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       edx,edx
+       mov       [rcx],edx
+       mov       [rbx-4],edx
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
        push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+2D8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC1BFC10
-       call      qword ptr [7FF8AC0FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
+       push      r15
+       push      r14
+       push      r13
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,40
+       lea       rbp,[rsp+70]
+       xor       eax,eax
+       mov       [rbp-48],rax
+       mov       rbx,rcx
+       mov       rsi,[rbx+2D8]
+       mov       [rbp-50],rsi
+       cmp       [rsi],sil
+       xor       ecx,ecx
+       mov       [rbp-34],ecx
+       mov       rcx,[rsi+10]
+       mov       rdi,[rcx+10]
+       xor       r14d,r14d
+       test      rdi,rdi
+       je        near ptr M00_L18
+       cmp       dword ptr [rdi+8],0
+       jle       near ptr M00_L18
+M00_L00:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L02
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L01
+M00_L04:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L00
+M00_L05:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       mov       edi,[rcx+8]
+       mov       rcx,[rsi+10]
+       mov       r14,[rcx+10]
+       mov       r15d,1
+       cmp       edi,1
+       jle       short M00_L12
+       test      r14,r14
+       je        short M00_L06
+       cmp       [r14+8],edi
+       jge       near ptr M00_L29
+M00_L06:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       cmp       r15d,[r14+8]
+       jae       short M00_L09
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L08
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L07
+M00_L11:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        near ptr M00_L35
+       cmp       r15d,edi
+       jl        short M00_L06
+M00_L12:
+       mov       rdi,[rsi+10]
+       mov       rcx,[rdi+10]
+       mov       r14d,[rcx+8]
+       mov       rcx,[rdi+18]
+       mov       rdx,[rdi+18]
+       mov       edx,[rdx+8]
+       test      rcx,rcx
+       je        near ptr M00_L32
+       lea       rax,[rcx+10]
+       xor       r8d,r8d
+       mov       r10,[rcx]
+       cmp       dword ptr [r10+4],18
+       jne       near ptr M00_L31
+M00_L13:
+       mov       r9d,r8d
+       neg       r9d
+       test      r8d,r8d
+       jg        near ptr M00_L34
+       test      r9d,r9d
+       jl        near ptr M00_L34
+       lea       r8d,[r9+rdx]
+       cmp       r8d,[rcx+8]
+       ja        near ptr M00_L34
+       movzx     ecx,word ptr [r10]
+       mov       r8d,r9d
+       imul      r8,rcx
+       add       r8,rax
+       mov       edx,edx
+       imul      rdx,rcx
+       test      dword ptr [r10],1000000
+       jne       near ptr M00_L30
+       mov       rcx,r8
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
+       xor       eax,eax
+       mov       r8,[rdi]
+       cmp       dword ptr [r8+4],18
+       jne       near ptr M00_L33
+M00_L15:
+       mov       r10d,eax
+       neg       r10d
+       test      eax,eax
+       jg        near ptr M00_L34
+       test      r10d,r10d
+       jl        near ptr M00_L34
+       lea       eax,[r10+rcx]
+       cmp       eax,[rdi+8]
+       ja        near ptr M00_L34
+       movzx     eax,word ptr [r8]
+       imul      r10,rax
+       add       r10,rdx
+       mov       edx,ecx
+       imul      rdx,rax
+       test      dword ptr [r8],1000000
+       jne       short M00_L16
+       mov       rcx,r10
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
+       xor       edx,edx
+       div       r14d
+       mov       ecx,1
+       cmp       eax,1
+       cmovg     ecx,eax
+       mov       [rsi+18],ecx
+       jmp       near ptr M00_L36
+M00_L18:
+       xor       ecx,ecx
+       mov       [rbp-38],ecx
+       cmp       r14d,[rdi+8]
+       jae       short M00_L21
+       mov       ecx,r14d
+       mov       r15,[rdi+rcx*8+10]
+       test      r15,r15
+       je        short M00_L20
+       mov       rcx,r15
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L19
+M00_L23:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r14d,1
+       jo        near ptr M00_L35
+       test      r14d,r14d
+       jle       short M00_L18
+       jmp       near ptr M00_L05
+M00_L24:
+       mov       ecx,r15d
+       mov       r13,[r14+rcx*8+10]
+       test      r13,r13
+       je        short M00_L26
+       mov       rcx,r13
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L25
+M00_L28:
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        near ptr M00_L35
+       mov       [rbp-34],ecx
+       add       r15d,1
+       jo        short M00_L35
+       cmp       r15d,edi
+       jge       near ptr M00_L12
+M00_L29:
+       xor       ecx,ecx
+       mov       [rbp-3C],ecx
+       jmp       short M00_L24
+M00_L30:
+       shr       rdx,3
+       mov       rcx,r8
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       jmp       near ptr M00_L14
+M00_L31:
+       mov       r9d,[r10+4]
+       add       r9d,0FFFFFFE8
+       shr       r9d,3
+       movsxd    r8,r9d
+       mov       r8d,[rax+r8*4]
+       shl       r9d,3
+       movsxd    r9,r9d
+       add       rax,r9
+       jmp       near ptr M00_L13
+M00_L32:
+       mov       ecx,2
+       call      qword ptr [7FF8ABC3C258]
+       int       3
+M00_L33:
+       mov       r10d,[r8+4]
+       add       r10d,0FFFFFFE8
+       shr       r10d,3
+       movsxd    rax,r10d
+       mov       eax,[rdx+rax*4]
+       shl       r10d,3
+       movsxd    r10,r10d
+       add       rdx,r10
+       jmp       near ptr M00_L15
+M00_L34:
+       call      qword ptr [7FF8AC2B7930]
+       int       3
+M00_L35:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L36:
+       xor       edi,edi
+       cmp       dword ptr [rbp-34],0
+       jle       short M00_L39
+M00_L37:
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L42
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L41
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       short M00_L40
+M00_L38:
+       add       edi,1
+       jo        short M00_L43
+       cmp       edi,[rbp-34]
+       jl        short M00_L37
+M00_L39:
+       mov       rcx,[rbx+2D8]
+       mov       [rbp-48],rcx
+       mov       rdi,[rbx+88]
+       mov       rdx,[rbp-48]
+       lea       rcx,[rdi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rdi+8],rax
+       add       rsp,40
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+M00_L40:
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L44
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L45
+       mov       [rbp-34],ecx
+M00_L44:
+       add       rsp,28
+       ret
+M00_L45:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L46
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L47
+       mov       [rbp-34],ecx
+M00_L46:
+       add       rsp,28
+       ret
+M00_L47:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-38],0
+       je        short M00_L48
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L49
+       mov       [rbp-34],ecx
+M00_L48:
+       add       rsp,28
+       ret
+M00_L49:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       cmp       dword ptr [rbp-3C],0
+       je        short M00_L50
+       mov       ecx,[rbp-34]
+       add       ecx,1
+       jo        short M00_L51
+       mov       [rbp-34],ecx
+M00_L50:
+       add       rsp,28
+       ret
+M00_L51:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+       sub       rsp,28
+       xor       edi,edi
+       cmp       edi,[rbp-34]
+       jge       short M00_L57
+M00_L52:
+       mov       rsi,[rbp-50]
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       cmp       edi,[rcx+8]
+       jae       short M00_L55
+       mov       eax,edi
+       mov       r14,[rcx+rax*8+10]
+       test      r14,r14
+       je        short M00_L54
+       mov       rcx,r14
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8AC0F5E90]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F5CC8]
+       int       3
+M00_L55:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L56:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L57:
+       add       rsp,28
+       ret
+; Total bytes of code 1262
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rdx
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+20],r8
-       mov       rax,[rbp+18]
-       mov       rax,[rax+18]
-       mov       rax,[rax+10]
-       mov       [rbp-20],rax
-       cmp       qword ptr [rbp-20],0
-       je        short M01_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8AC1C7AF8
-       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC0FE7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC0FE778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,40
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 130
+; Total bytes of code 105
+; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       push      rbx
+       test      rdx,rdx
+       je        short M02_L03
+       lea       rbx,[rcx+rdx]
+       cmp       rdx,10
+       jbe       short M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+M02_L01:
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       dec       rax
+       jne       short M02_L01
+       and       rdx,3F
+       cmp       rdx,10
+       ja        short M02_L04
+M02_L02:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rbx-10],xmm0
+M02_L03:
+       pop       rbx
+       ret
+M02_L04:
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx],xmm0
+       cmp       rdx,20
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+10],xmm0
+       cmp       rdx,30
+       jbe       short M02_L02
+       vxorps    xmm0,xmm0,xmm0
+       vmovups   [rcx+20],xmm0
+       jmp       short M02_L02
+M02_L05:
+       test      dl,18
+       je        short M02_L06
+       xor       eax,eax
+       mov       [rcx],rax
+       mov       [rbx-8],rax
+       jmp       short M02_L03
+M02_L06:
+       test      dl,4
+       je        short M02_L07
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
+       jmp       short M02_L03
+M02_L07:
+       mov       byte ptr [rcx],0
+       test      dl,2
+       je        short M02_L03
+       mov       word ptr [rbx-2],0
+       jmp       short M02_L03
+M02_L08:
+       mov       rax,rcx
+       and       rax,3F
+       neg       rax
+       add       rax,40
+       vxorps    ymm0,ymm0,ymm0
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,rax
+       sub       rdx,rax
+       jmp       near ptr M02_L00
+M02_L09:
+       cmp       [rcx],cl
+       pop       rbx
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
+; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       cmp       rdx,8
+       jb        short M03_L01
+M03_L00:
+       xor       eax,eax
+       mov       [rcx+rdx*8-8],rax
+       mov       [rcx+rdx*8-10],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-20],rax
+       mov       [rcx+rdx*8-28],rax
+       mov       [rcx+rdx*8-30],rax
+       mov       [rcx+rdx*8-38],rax
+       mov       [rcx+rdx*8-40],rax
+       add       rdx,0FFFFFFFFFFFFFFF8
+       cmp       rdx,8
+       jae       short M03_L00
+M03_L01:
+       cmp       rdx,4
+       jae       short M03_L03
+       cmp       rdx,2
+       jae       short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L02:
+       ret
+M03_L03:
+       xor       eax,eax
+       mov       [rcx+10],rax
+       mov       [rcx+18],rax
+       mov       [rcx+rdx*8-18],rax
+       mov       [rcx+rdx*8-10],rax
+M03_L04:
+       xor       eax,eax
+       mov       [rcx+8],rax
+       mov       [rcx+rdx*8-8],rax
+M03_L05:
+       xor       eax,eax
+       mov       [rcx],rax
+       jmp       short M03_L02
+; Total bytes of code 114
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
        call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC2A6BE0]
+       call      qword ptr [7FF8AC2A6C10]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC1EE118]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC1EE118]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC1EE028]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       rdi,[rsi+10]
        mov       rcx,[rdi+10]
        mov       r14d,[rcx+8]
        mov       rcx,[rdi+18]
        mov       rdx,[rdi+18]
        mov       edx,[rdx+8]
        test      rcx,rcx
        je        near ptr M00_L32
        lea       rax,[rcx+10]
        xor       r8d,r8d
        mov       r10,[rcx]
        cmp       dword ptr [r10+4],18
        jne       near ptr M00_L31
 M00_L13:
        mov       r9d,r8d
        neg       r9d
        test      r8d,r8d
        jg        near ptr M00_L34
        test      r9d,r9d
        jl        near ptr M00_L34
        lea       r8d,[r9+rdx]
        cmp       r8d,[rcx+8]
        ja        near ptr M00_L34
        movzx     ecx,word ptr [r10]
        mov       r8d,r9d
        imul      r8,rcx
        add       r8,rax
        mov       edx,edx
        imul      rdx,rcx
        test      dword ptr [r10],1000000
        jne       near ptr M00_L30
        mov       rcx,r8
-       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
 M00_L14:
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        lea       rdx,[rdi+10]
        xor       eax,eax
        mov       r8,[rdi]
        cmp       dword ptr [r8+4],18
        jne       near ptr M00_L33
 M00_L15:
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
-       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r9d,[r10+4]
        add       r9d,0FFFFFFE8
        shr       r9d,3
        movsxd    r8,r9d
        mov       r8d,[rax+r8*4]
        shl       r9d,3
        movsxd    r9,r9d
        add       rax,r9
        jmp       near ptr M00_L13
 M00_L32:
        mov       ecx,2
-       call      qword ptr [7FF8ABC3C258]
+       call      qword ptr [7FF8ABC0C258]
        int       3
 M00_L33:
        mov       r10d,[r8+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC2A6BE0]
+       call      qword ptr [7FF8AC277810]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC0CE328]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC0CE328]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
        call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEF88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC04FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC2A6BE0]
+       call      qword ptr [7FF8AC2B7930]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC0F5E90]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE1A8]
+       call      qword ptr [7FF8AC0F5E90]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE0B8]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        test      dl,18
        je        short M02_L06
        xor       eax,eax
        mov       [rcx],rax
        mov       [rbx-8],rax
        jmp       short M02_L03
 M02_L06:
        test      dl,4
        je        short M02_L07
-       xor       edx,edx
-       mov       [rcx],edx
-       mov       [rbx-4],edx
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
        jmp       short M02_L03
 M02_L07:
        mov       byte ptr [rcx],0
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC104510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       rdi,[rsi+10]
        mov       rcx,[rdi+10]
        mov       r14d,[rcx+8]
        mov       rcx,[rdi+18]
        mov       rdx,[rdi+18]
        mov       edx,[rdx+8]
        test      rcx,rcx
        je        near ptr M00_L32
        lea       rax,[rcx+10]
        xor       r8d,r8d
        mov       r10,[rcx]
        cmp       dword ptr [r10+4],18
        jne       near ptr M00_L31
 M00_L13:
        mov       r9d,r8d
        neg       r9d
        test      r8d,r8d
        jg        near ptr M00_L34
        test      r9d,r9d
        jl        near ptr M00_L34
        lea       r8d,[r9+rdx]
        cmp       r8d,[rcx+8]
        ja        near ptr M00_L34
        movzx     ecx,word ptr [r10]
        mov       r8d,r9d
        imul      r8,rcx
        add       r8,rax
        mov       edx,edx
        imul      rdx,rcx
        test      dword ptr [r10],1000000
        jne       near ptr M00_L30
        mov       rcx,r8
-       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
 M00_L14:
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        lea       rdx,[rdi+10]
        xor       eax,eax
        mov       r8,[rdi]
        cmp       dword ptr [r8+4],18
        jne       near ptr M00_L33
 M00_L15:
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
-       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r9d,[r10+4]
        add       r9d,0FFFFFFE8
        shr       r9d,3
        movsxd    r8,r9d
        mov       r8d,[rax+r8*4]
        shl       r9d,3
        movsxd    r9,r9d
        add       rax,r9
        jmp       near ptr M00_L13
 M00_L32:
        mov       ecx,2
-       call      qword ptr [7FF8ABC3C258]
+       call      qword ptr [7FF8ABC0C258]
        int       3
 M00_L33:
        mov       r10d,[r8+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC2A6C10]
+       call      qword ptr [7FF8AC277810]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE118]
+       call      qword ptr [7FF8AC0CE328]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE118]
+       call      qword ptr [7FF8AC0CE328]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0CE160]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
        call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1EEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC04FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC2A6C10]
+       call      qword ptr [7FF8AC2B7930]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE118]
+       call      qword ptr [7FF8AC0F5E90]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC1EE118]
+       call      qword ptr [7FF8AC0F5E90]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        test      dl,18
        je        short M02_L06
        xor       eax,eax
        mov       [rcx],rax
        mov       [rbx-8],rax
        jmp       short M02_L03
 M02_L06:
        test      dl,4
        je        short M02_L07
-       xor       edx,edx
-       mov       [rcx],edx
-       mov       [rbx-4],edx
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
        jmp       short M02_L03
 M02_L07:
        mov       byte ptr [rcx],0
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC1044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
mov       dword ptr [rbp-38],1
        jmp       short M00_L04
 M00_L02:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L07
 M00_L11:
        mov       ecx,[rbp-34]
        mov       rdi,[rsi+10]
        mov       rcx,[rdi+10]
        mov       r14d,[rcx+8]
        mov       rcx,[rdi+18]
        mov       rdx,[rdi+18]
        mov       edx,[rdx+8]
        test      rcx,rcx
        je        near ptr M00_L32
        lea       rax,[rcx+10]
        xor       r8d,r8d
        mov       r10,[rcx]
        cmp       dword ptr [r10+4],18
        jne       near ptr M00_L31
 M00_L13:
        mov       r9d,r8d
        neg       r9d
        test      r8d,r8d
        jg        near ptr M00_L34
        test      r9d,r9d
        jl        near ptr M00_L34
        lea       r8d,[r9+rdx]
        cmp       r8d,[rcx+8]
        ja        near ptr M00_L34
        movzx     ecx,word ptr [r10]
        mov       r8d,r9d
        imul      r8,rcx
        add       r8,rax
        mov       edx,edx
        imul      rdx,rcx
        test      dword ptr [r10],1000000
        jne       near ptr M00_L30
        mov       rcx,r8
-       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
 M00_L14:
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        mov       rdi,[rdi+8]
        mov       ecx,[rdi+8]
        lea       rdx,[rdi+10]
        xor       eax,eax
        mov       r8,[rdi]
        cmp       dword ptr [r8+4],18
        jne       near ptr M00_L33
 M00_L15:
        mov       r10d,eax
        neg       r10d
        test      eax,eax
        jg        near ptr M00_L34
        test      r10d,r10d
        jl        near ptr M00_L34
        lea       eax,[r10+rcx]
        cmp       eax,[rdi+8]
        ja        near ptr M00_L34
        movzx     eax,word ptr [r8]
        imul      r10,rax
        add       r10,rdx
        mov       edx,ecx
        imul      rdx,rax
        test      dword ptr [r8],1000000
        jne       short M00_L16
        mov       rcx,r10
-       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8AC1DE9A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F7138]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8AC00F690]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8AC04FA68]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        jmp       near ptr M00_L14
 M00_L31:
        mov       r9d,[r10+4]
        mov       r9d,[r10+4]
        add       r9d,0FFFFFFE8
        shr       r9d,3
        movsxd    r8,r9d
        mov       r8d,[rax+r8*4]
        shl       r9d,3
        movsxd    r9,r9d
        add       rax,r9
        jmp       near ptr M00_L13
 M00_L32:
        mov       ecx,2
-       call      qword ptr [7FF8ABC0C258]
+       call      qword ptr [7FF8ABC3C258]
        int       3
 M00_L33:
        mov       r10d,[r8+4]
        mov       r10d,[r8+4]
        add       r10d,0FFFFFFE8
        shr       r10d,3
        movsxd    rax,r10d
        mov       eax,[rdx+rax*4]
        shl       r10d,3
        movsxd    r10,r10d
        add       rdx,r10
        jmp       near ptr M00_L15
 M00_L34:
-       call      qword ptr [7FF8AC277810]
+       call      qword ptr [7FF8AC2B7930]
        int       3
 M00_L35:
        call      CORINFO_HELP_OVERFLOW
        mov       rcx,[rbx+2D8]
        mov       [rbp-48],rcx
        mov       rdi,[rbx+88]
        mov       rdx,[rbp-48]
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rdi+8],rax
        add       rsp,40
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L40:
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC0CE328]
+       call      qword ptr [7FF8AC0F5E90]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L42:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        xor       edi,edi
        cmp       edi,[rbp-34]
        jge       short M00_L57
 M00_L52:
        mov       rsi,[rbp-50]
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        cmp       edi,[rcx+8]
        jae       short M00_L55
        mov       eax,edi
        mov       r14,[rcx+rax*8+10]
        test      r14,r14
        je        short M00_L54
        mov       rcx,r14
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8AC0CE328]
+       call      qword ptr [7FF8AC0F5E90]
 M00_L53:
        add       edi,1
        jo        short M00_L56
        add       edi,1
        jo        short M00_L56
        cmp       edi,[rbp-34]
        jl        short M00_L52
        jmp       short M00_L57
 M00_L54:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0CE160]
+       call      qword ptr [7FF8AC0F5CC8]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        test      dl,18
        je        short M02_L06
        xor       eax,eax
        mov       [rcx],rax
        mov       [rbx-8],rax
        jmp       short M02_L03
 M02_L06:
        test      dl,4
        je        short M02_L07
-       xor       edx,edx
-       mov       [rcx],edx
-       mov       [rbx-4],edx
+       xor       eax,eax
+       mov       [rcx],eax
+       mov       [rbx-4],eax
        jmp       short M02_L03
 M02_L07:
        mov       byte ptr [rcx],0
        mov       rax,rcx
        and       rax,3F
        neg       rax
        add       rax,40
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
        vmovdqu   ymmword ptr [rcx+20],ymm0
        add       rcx,rax
        sub       rdx,rax
        jmp       near ptr M02_L00
 M02_L09:
        cmp       [rcx],cl
        pop       rbx
-       jmp       qword ptr [7FF8AC0C4DF8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8AC0F6970]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 231
 ; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
        cmp       rdx,8
        jb        short M03_L01
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
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
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 54
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+; 		return item is null ? false : this.TryRemove(item);
+; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        je        short M02_L00
+       mov       rcx,7FF8AC2FDDD0
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 M02_L00:
+       mov       rcx,7FF8AC2FDDD4
+       call      CORINFO_HELP_COUNTPROFILE32
        xor       eax,eax
        add       rsp,20
        pop       rbp
        ret
-; Total bytes of code 54
+; Total bytes of code 84
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,18188800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,523CE4D8
+       mov       ebx,72076968
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB971510
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB971508
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,20A9B800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8F823CB4
+       mov       ebx,9143E1C4
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB961508
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB961500
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1B8FD800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB941448
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB941440
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1C919000068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC0F75D0]
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB951600
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1E63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB9515F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+M00_L30:
        nop
-       add       rsp,30
-       pop       rbp
+       add       rsp,28
        ret
-; Total bytes of code 60
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+; Total bytes of code 987
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 54
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+; 		return item is null ? false : this.TryRemove(item);
+; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        je        short M02_L00
+       mov       rcx,7FF8AC2FDDD0
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 M02_L00:
+       mov       rcx,7FF8AC2FDDD4
+       call      CORINFO_HELP_COUNTPROFILE32
        xor       eax,eax
        add       rsp,20
        pop       rbp
        ret
-; Total bytes of code 54
+; Total bytes of code 84
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,18188800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,523CE4D8
+       mov       ebx,72076968
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB971510
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB971508
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,20A9B800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8F823CB4
+       mov       ebx,9143E1C4
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB961508
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB961500
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1B8FD800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB941448
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB941440
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1C919000068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC0F75D0]
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB951600
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB9515F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+M00_L30:
        nop
-       add       rsp,30
-       pop       rbp
+       add       rsp,28
        ret
-; Total bytes of code 60
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+; Total bytes of code 987
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
+; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+; 		return item is null ? false : this.TryRemove(item);
+; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       push      rbp
+       sub       rsp,20
+       lea       rbp,[rsp+20]
+       mov       [rbp+10],rcx
+       mov       [rbp+18],rdx
+       cmp       qword ptr [rbp+18],0
+       je        short M02_L00
+       mov       rcx,7FF8AC2FDDD0
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbp+10]
+       mov       rdx,[rbp+18]
+       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       nop
+       add       rsp,20
+       pop       rbp
+       ret
+M02_L00:
+       mov       rcx,7FF8AC2FDDD4
+       call      CORINFO_HELP_COUNTPROFILE32
+       xor       eax,eax
+       add       rsp,20
+       pop       rbp
+       ret
+; Total bytes of code 84
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,18188800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,523CE4D8
+       mov       ebx,72076968
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB971510
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB971508
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
+       nop
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,20A9B800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8F823CB4
+       mov       ebx,9143E1C4
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB961508
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB961500
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
+       nop
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1B8FD800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB941448
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB941440
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
+       nop
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E62B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1C919000068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC0F75D0]
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB951600
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E62F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB9515F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,30
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 60
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+; Total bytes of code 987
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,18188800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,523CE4D8
+       mov       ebx,72076968
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB971510
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,7FF8AC2FDDD0
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB971508
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       mov       rcx,7FF8AC2FDDD4
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1FDB48]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1FDA28]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,20A9B800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8F823CB4
+       mov       ebx,9143E1C4
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB961508
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,7FF8AC2FDDD0
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB961500
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       mov       rcx,7FF8AC2FDDD4
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1EE070]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1EDF80]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1B8FD800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB941448
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
-       pop       rbp
-       ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,7FF8AC2FDDD0
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB941440
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       mov       rcx,7FF8AC2FDDD4
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC1CDFE0]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC1CDEF0]
+       int       3
+; Total bytes of code 987
+; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
        nop
-       add       rsp,30
+       add       rsp,88
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 60
+; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,50
+       lea       rbp,[rsp+70]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
+       mov       [rbp-38],rax
        mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+2D8]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDFAD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
+       mov       r8,[rcx+2D8]
+       mov       [rbp-38],r8
+       mov       rdx,[rcx+48]
+       mov       [rbp-40],rdx
+       cmp       [r8],r8b
+       test      rdx,rdx
+       je        near ptr M00_L27
+       xor       eax,eax
+       mov       [rbp-2C],eax
+       mov       rax,[r8+8]
+       mov       [rbp-48],rax
+       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rax],r10
+       jne       near ptr M00_L23
+       mov       rax,[rbp-48]
+       mov       r10,[rdx+28]
+       test      r10,r10
+       je        near ptr M00_L16
+       mov       r9,1C919000068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
+       cmp       r10d,8
+       jb        near ptr M00_L17
+       mov       esi,r10d
+       shr       esi,3
+M00_L00:
+       add       r11d,[r9]
+       mov       edi,[r9+4]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       add       edi,r11d
+       mov       r11d,ebx
+       xor       r11d,edi
+       rol       edi,14
+       add       edi,r11d
+       rol       r11d,9
+       xor       r11d,edi
+       rol       edi,1B
+       add       edi,r11d
+       rol       r11d,13
+       mov       ebx,edi
+       add       r9,8
+       dec       esi
+       mov       ecx,ebx
+       mov       ebx,r11d
+       mov       r11d,ecx
+       jne       short M00_L00
+       test      r10b,4
+       jne       near ptr M00_L18
+M00_L01:
+       mov       esi,r10d
+       and       rsi,7
+       mov       r9d,[r9+rsi-4]
+       shr       r9d,8
+       or        r9d,80000000
+       not       r10d
+       shl       r10d,3
+       shrx      r10d,r9d,r10d
+M00_L02:
+       add       r10d,r11d
+       mov       r9d,ebx
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r9d,r10d
+       rol       r10d,14
+       add       r10d,r9d
+       rol       r9d,9
+       xor       r9d,r10d
+       rol       r10d,1B
+       add       r10d,r9d
+       rol       r9d,13
+       xor       r10d,r9d
+M00_L03:
+       mov       [rbp-24],r10d
+M00_L04:
+       mov       r8,[rbp-38]
+       mov       rbx,[r8+10]
+       mov       rsi,[rbx+8]
+       mov       rcx,[rbx+10]
+       mov       r10d,[rsi+8]
+       mov       r9d,[rcx+8]
+       mov       r11d,r9d
+       mov       eax,[rbp-24]
+       and       eax,7FFFFFFF
+       cdq
+       idiv      r10d
+       mov       edi,edx
+       mov       eax,edi
+       cdq
+       idiv      r11d
+       mov       r14d,edx
+       cmp       r14d,r9d
+       jae       near ptr M00_L28
+       mov       eax,r14d
+       mov       rcx,[rcx+rax*8+10]
+       mov       [rbp-50],rcx
+       xor       ecx,ecx
+       mov       [rbp-28],ecx
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L08
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DF30
+       test      eax,eax
+       je        short M00_L09
+M00_L05:
+       mov       dword ptr [rbp-28],1
+       mov       r8,[rbp-38]
+       cmp       rbx,[r8+10]
+       jne       near ptr M00_L25
+       cmp       edi,[rsi+8]
+       jae       near ptr M00_L11
+       mov       edx,edi
+       lea       rsi,[rsi+rdx*8+10]
+       mov       rdi,[rsi]
+       test      rdi,rdi
+       je        near ptr M00_L13
+M00_L06:
+       mov       edx,[rbp-24]
+       cmp       edx,[rdi+18]
+       je        short M00_L10
+M00_L07:
+       lea       rsi,[rdi+10]
+       mov       rdi,[rdi+10]
+       test      rdi,rdi
+       jne       short M00_L06
+       jmp       short M00_L13
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8AC0F75D0]
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8AB951600
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M00_L07
+       mov       rdx,[rdi+10]
+       mov       rcx,rsi
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       mov       rcx,[rbx+18]
+       cmp       r14d,[rcx+8]
+       jae       short M00_L11
+       mov       eax,r14d
+       lea       rcx,[rcx+rax*4+10]
+       mov       eax,[rcx]
+       sub       eax,1
+       jo        short M00_L12
+       mov       [rcx],eax
+       mov       dword ptr [rbp-2C],1
+       jmp       near ptr M00_L26
+M00_L11:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L12:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M00_L13:
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       push      rbp
-       mov       rbp,rsp
-       mov       [rbp+10],rcx
-       mov       rax,[rbp+10]
-       mov       rax,[rax+48]
+       mov       rax,[rcx+88]
+       mov       [rax+4C],bl
+       add       rsp,50
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
        pop       rbp
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 		return item is null ? false : this.TryRemove(item);
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       cmp       qword ptr [rbp+18],0
-       je        short M02_L00
-       mov       rcx,7FF8AC2FDDD0
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1D6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L18:
+       add       r11d,[r9]
+       xor       ebx,r11d
+       rol       r11d,14
+       add       r11d,ebx
+       rol       ebx,9
+       xor       ebx,r11d
+       rol       r11d,1B
+       add       r11d,ebx
+       rol       ebx,13
+       jmp       near ptr M00_L01
+M00_L19:
+       mov       esi,80
+       test      r10b,1
+       je        short M00_L20
+       mov       esi,r10d
+       and       rsi,2
+       movzx     esi,byte ptr [r9+rsi]
+       or        esi,8000
+M00_L20:
+       test      r10b,2
+       je        short M00_L21
+       shl       esi,10
+       movzx     r10d,word ptr [r9]
+       or        esi,r10d
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L21:
+       mov       r10d,esi
+       jmp       near ptr M00_L02
+M00_L22:
+       mov       rcx,r9
+       mov       rdx,r10
+       mov       r10,[r9]
+       mov       r10,[r10+48]
+       call      qword ptr [r10+18]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L23:
+       mov       rax,[rbp-48]
+       mov       rcx,rax
+       mov       r11,7FF8AB9515F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+       jmp       near ptr M00_L14
+M00_L25:
+       call      M00_L29
+       jmp       near ptr M00_L04
+M00_L26:
+       call      M00_L29
        nop
-       add       rsp,20
-       pop       rbp
-       ret
-M02_L00:
-       mov       rcx,7FF8AC2FDDD4
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6328]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       mov       ebx,[rbp-2C]
+       jmp       near ptr M00_L15
+M00_L27:
+       xor       ebx,ebx
+       jmp       near ptr M00_L15
+M00_L28:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L29:
+       sub       rsp,28
+       cmp       dword ptr [rbp-28],0
+       je        short M00_L30
+       cmp       qword ptr [rbp-50],0
+       je        short M00_L31
+       mov       rcx,[rbp-50]
+       call      00007FF90B69DE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8AC0F6388]
+M00_L30:
        nop
-       add       rsp,30
-       pop       rbp
+       add       rsp,28
        ret
-; Total bytes of code 60
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8AC0F6298]
+       int       3
+; Total bytes of code 987
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,18188800068
+       mov       r9,20A9B800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,523CE4D8
-       mov       ebx,72076968
+       mov       r11d,8F823CB4
+       mov       ebx,9143E1C4
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC1EDF80]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB971510
+       mov       r11,7FF8AB961508
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB971508
+       mov       r11,7FF8AB961500
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC1EE070]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC1EE070]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC1EDF80]
        int       3
 ; Total bytes of code 987
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
        mov       [rbp+10],rcx
        lea       rcx,[rbp+10]
        mov       [rbp-98],rcx
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,18188800068
+       mov       r9,1B8FD800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,523CE4D8
-       mov       ebx,72076968
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC1CDEF0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB971510
+       mov       r11,7FF8AB941448
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB971508
+       mov       r11,7FF8AB941440
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC1CDFE0]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC1CDFE0]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC1CDEF0]
        int       3
 ; Total bytes of code 987
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
        mov       [rbp+10],rcx
        lea       rcx,[rbp+10]
        mov       [rbp-98],rcx
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,18188800068
+       mov       r9,1C919000068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,523CE4D8
-       mov       ebx,72076968
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1FD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F75D0]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB971510
+       mov       r11,7FF8AB951600
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB971508
+       mov       r11,7FF8AB9515F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC0F6388]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1FDB48]
+       call      qword ptr [7FF8AC0F6388]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1FDA28]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 ; Total bytes of code 987
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,20A9B800068
+       mov       r9,1B8FD800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,8F823CB4
-       mov       ebx,9143E1C4
+       mov       r11d,0D366FA4B
+       mov       ebx,53DF964F
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF80]
+       call      qword ptr [7FF8AC1CDEF0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB961508
+       mov       r11,7FF8AB941448
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB961500
+       mov       r11,7FF8AB941440
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE070]
+       call      qword ptr [7FF8AC1CDFE0]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE070]
+       call      qword ptr [7FF8AC1CDFE0]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF80]
+       call      qword ptr [7FF8AC1CDEF0]
        int       3
 ; Total bytes of code 987
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
        mov       [rbp+10],rcx
        lea       rcx,[rbp+10]
        mov       [rbp-98],rcx
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,20A9B800068
+       mov       r9,1C919000068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,8F823CB4
-       mov       ebx,9143E1C4
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF80]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1ED980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F75D0]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB961508
+       mov       r11,7FF8AB951600
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB961500
+       mov       r11,7FF8AB9515F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE070]
+       call      qword ptr [7FF8AC0F6388]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE070]
+       call      qword ptr [7FF8AC0F6388]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF80]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 ; Total bytes of code 987
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 105
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        test      rdx,rdx
        je        near ptr M00_L27
        xor       eax,eax
        mov       [rbp-2C],eax
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,1B8FD800068
+       mov       r9,1C919000068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,0D366FA4B
-       mov       ebx,53DF964F
+       mov       r11d,3A5C4F98
+       mov       ebx,0C312175
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDEF0]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1CEF28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0F75D0]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB941448
+       mov       r11,7FF8AB951600
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB941440
+       mov       r11,7FF8AB9515F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CDFE0]
+       call      qword ptr [7FF8AC0F6388]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L29
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L29:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L30
        cmp       qword ptr [rbp-50],0
        je        short M00_L31
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CDFE0]
+       call      qword ptr [7FF8AC0F6388]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDEF0]
+       call      qword ptr [7FF8AC0F6298]
        int       3
 ; Total bytes of code 987
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 105
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,25579C00068
+       mov       r9,1412BC00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,0CF3935E
-       mov       ebx,0B6BA4056
+       mov       r11d,8AF3BA27
+       mov       ebx,0CA6D8211
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC1EDF38]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1CD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEBB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB941510
+       mov       r11,7FF8AB961540
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB941508
+       mov       r11,7FF8AB961538
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC1EE028]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC1EE028]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC1EDF38]
        int       3
 ; Total bytes of code 980
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
+       sub       rsp,58
+       vzeroupper
+       lea       rbp,[rsp+90]
        mov       [rbp+10],rcx
+       lea       rcx,[rbp-70]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       rbx,rax
+       mov       rcx,rsp
+       mov       [rbp-58],rcx
+       mov       rcx,rbp
+       mov       [rbp-48],rcx
        lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
+       mov       rax,7FF8ABA58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF90B69E370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF90B954A90],0
+       je        short M01_L01
+       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
+M01_L01:
+       mov       rax,[rbp-68]
+       mov       [rbx+8],rax
+       add       rsp,58
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 105
+; Total bytes of code 154
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
-       je        near ptr M00_L16
-       mov       r9,25579C00068
+       je        near ptr M00_L18
+       mov       r9,1F7C3800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,0CF3935E
-       mov       ebx,0B6BA4056
+       mov       r11d,3DC1FDF9
+       mov       ebx,48DC7886
        cmp       r10d,8
-       jb        near ptr M00_L17
+       jb        near ptr M00_L16
        mov       esi,r10d
        shr       esi,3
 M00_L00:
        add       r11d,[r9]
        mov       edi,[r9+4]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        add       edi,r11d
        mov       r11d,ebx
        xor       r11d,edi
        rol       edi,14
        add       edi,r11d
        rol       r11d,9
        xor       r11d,edi
        rol       edi,1B
        add       edi,r11d
        rol       r11d,13
        mov       ebx,edi
        add       r9,8
        dec       esi
        mov       ecx,ebx
        mov       ebx,r11d
        mov       r11d,ecx
        jne       short M00_L00
        test      r10b,4
-       jne       near ptr M00_L18
+       jne       near ptr M00_L17
 M00_L01:
        mov       esi,r10d
        and       rsi,7
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC0FE700]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1CD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEC70]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB941510
+       mov       r11,7FF8AB951670
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+88]
        mov       [rcx+4C],al
        add       rsp,50
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M00_L16:
-       xor       r10d,r10d
-       jmp       near ptr M00_L03
-M00_L17:
        cmp       r10d,4
        jb        short M00_L19
-M00_L18:
+M00_L17:
        add       r11d,[r9]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        jmp       near ptr M00_L01
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
 M00_L19:
        mov       esi,80
        test      r10b,1
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB941508
+       mov       r11,7FF8AB951668
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC0FF630]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC0FF630]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC0FE700]
        int       3
 ; Total bytes of code 980
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
        mov       [rbp+10],rcx
        lea       rcx,[rbp+10]
        mov       [rbp-98],rcx
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; Total bytes of code 105
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,25579C00068
+       mov       r9,1E916C00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,0CF3935E
-       mov       ebx,0B6BA4056
+       mov       r11d,5A2EC30C
+       mov       ebx,86256534
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1CD500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0E7678]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB941510
+       mov       r11,7FF8AB941650
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB941508
+       mov       r11,7FF8AB941648
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC0E63A0]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1CE040]
+       call      qword ptr [7FF8AC0E63A0]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1CDF50]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 ; Total bytes of code 980
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 105
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
-       je        near ptr M00_L16
-       mov       r9,1412BC00068
+       je        near ptr M00_L18
+       mov       r9,1F7C3800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,8AF3BA27
-       mov       ebx,0CA6D8211
+       mov       r11d,3DC1FDF9
+       mov       ebx,48DC7886
        cmp       r10d,8
-       jb        near ptr M00_L17
+       jb        near ptr M00_L16
        mov       esi,r10d
        shr       esi,3
 M00_L00:
        add       r11d,[r9]
        mov       edi,[r9+4]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        add       edi,r11d
        mov       r11d,ebx
        xor       r11d,edi
        rol       edi,14
        add       edi,r11d
        rol       r11d,9
        xor       r11d,edi
        rol       edi,1B
        add       edi,r11d
        rol       r11d,13
        mov       ebx,edi
        add       r9,8
        dec       esi
        mov       ecx,ebx
        mov       ebx,r11d
        mov       r11d,ecx
        jne       short M00_L00
        test      r10b,4
-       jne       near ptr M00_L18
+       jne       near ptr M00_L17
 M00_L01:
        mov       esi,r10d
        and       rsi,7
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF38]
+       call      qword ptr [7FF8AC0FE700]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1EEBB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC1EEC70]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB961540
+       mov       r11,7FF8AB951670
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+88]
        mov       [rcx+4C],al
        add       rsp,50
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M00_L16:
-       xor       r10d,r10d
-       jmp       near ptr M00_L03
-M00_L17:
        cmp       r10d,4
        jb        short M00_L19
-M00_L18:
+M00_L17:
        add       r11d,[r9]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        jmp       near ptr M00_L01
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
 M00_L19:
        mov       esi,80
        test      r10b,1
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB961538
+       mov       r11,7FF8AB951668
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0FF630]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0FF630]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF38]
+       call      qword ptr [7FF8AC0FE700]
        int       3
 ; Total bytes of code 980
 ; System.Threading.Monitor.Enter_Slowpath(System.Object)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,58
-       vzeroupper
-       lea       rbp,[rsp+90]
+       sub       rsp,88
+       lea       rbp,[rsp+0C0]
        mov       [rbp+10],rcx
-       lea       rcx,[rbp-70]
-       call      CORINFO_HELP_INIT_PINVOKE_FRAME
-       mov       rbx,rax
-       mov       rcx,rsp
-       mov       [rbp-58],rcx
-       mov       rcx,rbp
-       mov       [rbp-48],rcx
        lea       rcx,[rbp+10]
-       mov       rax,7FF8ABA58210
-       mov       [rbp-60],rax
-       lea       rax,[M01_L00]
-       mov       [rbp-50],rax
-       lea       rax,[rbp-70]
-       mov       [rbx+8],rax
-       mov       byte ptr [rbx+4],0
-       mov       rax,7FF90B69E370
-       call      rax
-M01_L00:
-       mov       byte ptr [rbx+4],1
-       cmp       dword ptr [7FF90B954A90],0
-       je        short M01_L01
-       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
-M01_L01:
-       mov       rax,[rbp-68]
-       mov       [rbx+8],rax
-       add       rsp,58
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
+       nop
+       add       rsp,88
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 154
+; Total bytes of code 105
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
        je        near ptr M00_L16
-       mov       r9,1412BC00068
+       mov       r9,1E916C00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,8AF3BA27
-       mov       ebx,0CA6D8211
+       mov       r11d,5A2EC30C
+       mov       ebx,86256534
        cmp       r10d,8
        jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF38]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1EEBB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0E7678]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB961540
+       mov       r11,7FF8AB941650
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB961538
+       mov       r11,7FF8AB941648
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0E63A0]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC1EE028]
+       call      qword ptr [7FF8AC0E63A0]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC1EDF38]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 ; Total bytes of code 980
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,58
-       vzeroupper
-       lea       rbp,[rsp+90]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp-70]
-       call      CORINFO_HELP_INIT_PINVOKE_FRAME
-       mov       rbx,rax
-       mov       rcx,rsp
-       mov       [rbp-58],rcx
-       mov       rcx,rbp
-       mov       [rbp-48],rcx
-       lea       rcx,[rbp+10]
-       mov       rax,7FF8ABA58210
-       mov       [rbp-60],rax
-       lea       rax,[M01_L00]
-       mov       [rbp-50],rax
-       lea       rax,[rbp-70]
-       mov       [rbx+8],rax
-       mov       byte ptr [rbx+4],0
-       mov       rax,7FF90B69E370
-       call      rax
-M01_L00:
-       mov       byte ptr [rbx+4],1
-       cmp       dword ptr [7FF90B954A90],0
-       je        short M01_L01
-       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
-M01_L01:
-       mov       rax,[rbp-68]
-       mov       [rbx+8],rax
-       add       rsp,58
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 154
```
**Diff for TryRemove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
        push      rbp
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,50
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-48],xmm4
        xor       eax,eax
        mov       [rbp-38],rax
        mov       [rbp+10],rcx
        mov       r8,[rcx+2D8]
        mov       [rbp-38],r8
        mov       rdx,[rcx+48]
        mov       [rbp-40],rdx
        cmp       [r8],r8b
        xor       eax,eax
        mov       [rbp-2C],eax
        test      rdx,rdx
        je        near ptr M00_L14
        mov       rax,[r8+8]
        mov       [rbp-48],rax
        mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       [rax],r10
        jne       near ptr M00_L23
        mov       rax,[rbp-48]
        mov       r10,[rdx+28]
        test      r10,r10
-       je        near ptr M00_L18
-       mov       r9,1F7C3800068
+       je        near ptr M00_L16
+       mov       r9,1E916C00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,3DC1FDF9
-       mov       ebx,48DC7886
+       mov       r11d,5A2EC30C
+       mov       ebx,86256534
        cmp       r10d,8
-       jb        near ptr M00_L16
+       jb        near ptr M00_L17
        mov       esi,r10d
        shr       esi,3
 M00_L00:
        add       r11d,[r9]
        mov       edi,[r9+4]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        add       edi,r11d
        mov       r11d,ebx
        xor       r11d,edi
        rol       edi,14
        add       edi,r11d
        rol       r11d,9
        xor       r11d,edi
        rol       edi,1B
        add       edi,r11d
        rol       r11d,13
        mov       ebx,edi
        add       r9,8
        dec       esi
        mov       ecx,ebx
        mov       ebx,r11d
        mov       r11d,ecx
        jne       short M00_L00
        test      r10b,4
-       jne       near ptr M00_L17
+       jne       near ptr M00_L18
 M00_L01:
        mov       esi,r10d
        and       rsi,7
        lea       rsi,[rdi+10]
        mov       rdi,[rdi+10]
        test      rdi,rdi
        jne       short M00_L06
        jmp       short M00_L13
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0FE700]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8AC1EEC70]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8AC0E7678]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8AB951670
+       mov       r11,7FF8AB941650
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L07
        mov       rdx,[rdi+10]
        mov       rcx,rsi
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rcx,[rbx+18]
        cmp       r14d,[rcx+8]
        jae       short M00_L11
        mov       eax,r14d
        lea       rcx,[rcx+rax*4+10]
        mov       eax,[rcx]
        sub       eax,1
        jo        short M00_L12
        mov       [rcx],eax
        mov       dword ptr [rbp-2C],1
        jmp       near ptr M00_L26
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+88]
        mov       [rcx+4C],al
        add       rsp,50
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       rbp
        ret
 M00_L16:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
+M00_L17:
        cmp       r10d,4
        jb        short M00_L19
-M00_L17:
+M00_L18:
        add       r11d,[r9]
        xor       ebx,r11d
        rol       r11d,14
        add       r11d,ebx
        rol       ebx,9
        xor       ebx,r11d
        rol       r11d,1B
        add       r11d,ebx
        rol       ebx,13
        jmp       near ptr M00_L01
-M00_L18:
-       xor       r10d,r10d
-       jmp       near ptr M00_L03
 M00_L19:
        mov       esi,80
        test      r10b,1
        mov       rcx,r9
        mov       rdx,r10
        mov       r10,[r9]
        mov       r10,[r10+48]
        call      qword ptr [r10+18]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L23:
        mov       rax,[rbp-48]
        mov       rcx,rax
-       mov       r11,7FF8AB951668
+       mov       r11,7FF8AB941648
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC0FF630]
+       call      qword ptr [7FF8AC0E63A0]
        jmp       near ptr M00_L14
 M00_L25:
        call      M00_L28
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L28:
        sub       rsp,28
        cmp       dword ptr [rbp-28],0
        je        short M00_L29
        cmp       qword ptr [rbp-50],0
        je        short M00_L30
        mov       rcx,[rbp-50]
        call      00007FF90B69DE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8AC0FF630]
+       call      qword ptr [7FF8AC0E63A0]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8AC0FE700]
+       call      qword ptr [7FF8AC0E62B0]
        int       3
 ; Total bytes of code 980
-; System.Threading.Monitor.Enter_Slowpath(System.Object)
-       push      rbp
-       push      r15
-       push      r14
-       push      r13
-       push      r12
-       push      rdi
-       push      rsi
-       push      rbx
-       sub       rsp,88
-       lea       rbp,[rsp+0C0]
-       mov       [rbp+10],rcx
-       lea       rcx,[rbp+10]
-       mov       [rbp-98],rcx
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r13
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-; Total bytes of code 105
```
