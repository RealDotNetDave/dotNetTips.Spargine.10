## DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark-20260721-010556
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A83F6288
+       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
+       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
+       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
 ; 			this._budget = Math.Max(1, buckets.Length / lockCount);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
+       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A83E8910
+       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A8413690
+       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
-       mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A83FACF8
+       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A8433690
+       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+; 		var locksAcquired = 0;
+; 		^^^^^^^^^^^^^^^^^^^^^^
+; 			this.AcquireAllLocks(ref locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var tables = this._tables;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var locks = tables._locks;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var buckets = tables._buckets;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(buckets, 0, buckets.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this._budget = Math.Max(1, buckets.Length / lockCount);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this.ReleaseLocks(0, locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 		}
+; 		^
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
        xor       eax,eax
        mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        lea       rdx,[rbp-8]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
        mov       rax,[rbp+10]
        mov       rax,[rax+10]
        mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-10]
        mov       rax,[rax+10]
        mov       eax,[rax+8]
        mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-10]
        mov       rax,[rax+18]
        mov       r8d,[rax+8]
        mov       rax,[rbp-10]
        mov       rcx,[rax+18]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
        mov       rax,[rbp-10]
        mov       rax,[rax+8]
        mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       r8d,[rax+8]
        mov       rcx,[rbp-20]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
        mov       rcx,[rbp+10]
        mov       [rcx+18],eax
        call      M01_L00
        nop
+       mov       rcx,7FF8A852DD04
+       call      CORINFO_HELP_COUNTPROFILE32
+       nop
        add       rsp,50
        pop       rbp
        ret
 M01_L00:
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       mov       rcx,7FF8A852DD00
+       call      CORINFO_HELP_COUNTPROFILE32
        xor       eax,eax
        mov       [rbp-28],eax
        lea       rdx,[rbp-28]
        lea       r8,[rbp-8]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
+       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 210
+; Total bytes of code 241
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A841ACF8
+       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E3C258]
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
+       call      qword ptr [7FF8A84A6BC8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83EE190]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83EE190]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E1C258]
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
+       call      qword ptr [7FF8A8486D60]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83BE088]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83BE088]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E2C228]
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
+       call      qword ptr [7FF8A84A78E8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82EE7F0]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82EE7F0]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A801ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A84410D8
-       call      qword ptr [7FF8A83FC048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83FC090]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83FC0A8]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E3E268]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E4C228]
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
+       call      qword ptr [7FF8A84D7300]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82FDDE8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       call      qword ptr [7FF8A83FC0C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82FDDE8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       mov       rdx,7FF8A8427488
-       call      qword ptr [7FF8A7E3C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83FC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A8413690
+       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
-       mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A83FACF8
+       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A8433690
+       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+; 		var locksAcquired = 0;
+; 		^^^^^^^^^^^^^^^^^^^^^^
+; 			this.AcquireAllLocks(ref locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var tables = this._tables;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var locks = tables._locks;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var buckets = tables._buckets;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(buckets, 0, buckets.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this._budget = Math.Max(1, buckets.Length / lockCount);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this.ReleaseLocks(0, locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 		}
+; 		^
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
        xor       eax,eax
        mov       [rbp-8],eax
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        lea       rdx,[rbp-8]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
        mov       rax,[rbp+10]
        mov       rax,[rax+10]
        mov       [rbp-10],rax
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-10]
        mov       rax,[rax+10]
        mov       eax,[rax+8]
        mov       [rbp-14],eax
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-10]
        mov       rax,[rax+18]
        mov       r8d,[rax+8]
        mov       rax,[rbp-10]
        mov       rcx,[rax+18]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
        mov       rax,[rbp-10]
        mov       rax,[rax+8]
        mov       [rbp-20],rax
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp-20]
        mov       r8d,[rax+8]
        mov       rcx,[rbp-20]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
        mov       rax,[rbp-20]
        mov       eax,[rax+8]
        cdq
        idiv      dword ptr [rbp-14]
        mov       edx,eax
        mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
+       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
        mov       rcx,[rbp+10]
        mov       [rcx+18],eax
        call      M01_L00
        nop
+       mov       rcx,7FF8A852DD04
+       call      CORINFO_HELP_COUNTPROFILE32
+       nop
        add       rsp,50
        pop       rbp
        ret
 M01_L00:
        sub       rsp,28
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+       mov       rcx,7FF8A852DD00
+       call      CORINFO_HELP_COUNTPROFILE32
        xor       eax,eax
        mov       [rbp-28],eax
        lea       rdx,[rbp-28]
        lea       r8,[rbp-8]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
-; 		}
-; 		^
+       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 210
+; Total bytes of code 241
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A841ACF8
+       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E3C258]
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
+       call      qword ptr [7FF8A84A6BC8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83EE190]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83EE190]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E1C258]
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
+       call      qword ptr [7FF8A8486D60]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83BE088]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83BE088]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E2C228]
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
+       call      qword ptr [7FF8A84A78E8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82EE7F0]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82EE7F0]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7FFACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A83F6288
-       call      qword ptr [7FF8A83C5F50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A83C5F98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A83C5FB0]; System.Array.Clear(System.Array, Int32, Int32)
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E2DA10]; System.Math.Max(Int32, Int32)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E4C228]
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
+       call      qword ptr [7FF8A84D7300]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82FDDE8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       call      qword ptr [7FF8A83C5FC8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82FDDE8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       mov       rdx,7FF8A83E8910
-       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83C6040]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83C5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8413690
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8A8433690
+       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
+; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+; 		var locksAcquired = 0;
+; 		^^^^^^^^^^^^^^^^^^^^^^
+; 			this.AcquireAllLocks(ref locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var tables = this._tables;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var locks = tables._locks;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			var buckets = tables._buckets;
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			Array.Clear(buckets, 0, buckets.Length);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this._budget = Math.Max(1, buckets.Length / lockCount);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this.ReleaseLocks(0, locksAcquired);
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 		}
+; 		^
+       push      rbp
+       sub       rsp,50
+       lea       rbp,[rsp+50]
+       xor       eax,eax
+       mov       [rbp-28],rax
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   ymmword ptr [rbp-20],ymm4
+       mov       [rbp+10],rcx
+       xor       eax,eax
+       mov       [rbp-8],eax
+       lea       rdx,[rbp-8]
+       mov       rcx,[rbp+10]
+       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
+       mov       rax,[rbp+10]
+       mov       rax,[rax+10]
+       mov       [rbp-10],rax
+       mov       rax,[rbp-10]
+       mov       rax,[rax+10]
+       mov       eax,[rax+8]
+       mov       [rbp-14],eax
+       mov       rax,[rbp-10]
+       mov       rax,[rax+18]
+       mov       r8d,[rax+8]
+       mov       rax,[rbp-10]
+       mov       rcx,[rax+18]
+       xor       edx,edx
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
+       mov       rax,[rbp-10]
+       mov       rax,[rax+8]
+       mov       [rbp-20],rax
+       mov       rax,[rbp-20]
+       mov       r8d,[rax+8]
+       mov       rcx,[rbp-20]
+       xor       edx,edx
+       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
+       mov       rax,[rbp-20]
+       mov       eax,[rax+8]
+       cdq
+       idiv      dword ptr [rbp-14]
+       mov       edx,eax
+       mov       ecx,1
+       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
+       mov       rcx,[rbp+10]
+       mov       [rcx+18],eax
+       call      M01_L00
+       nop
+       mov       rcx,7FF8A852DD04
+       call      CORINFO_HELP_COUNTPROFILE32
+       nop
+       add       rsp,50
+       pop       rbp
+       ret
+M01_L00:
+       sub       rsp,28
+       mov       rcx,7FF8A852DD00
+       call      CORINFO_HELP_COUNTPROFILE32
+       xor       eax,eax
+       mov       [rbp-28],eax
+       lea       rdx,[rbp-28]
+       lea       r8,[rbp-8]
+       mov       rcx,[rbp+10]
+       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
+       nop
+       add       rsp,28
+       ret
+; Total bytes of code 241
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
-       je        short M01_L00
+       je        short M02_L00
        mov       rax,[rbp-20]
        mov       [rbp-10],rax
-       jmp       short M01_L01
-M01_L00:
+       jmp       short M02_L01
+M02_L00:
        mov       rcx,[rbp+18]
-       mov       rdx,7FF8A83FACF8
-       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8A841ACF8
+       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M01_L01:
+M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
-       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8413690
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E3C258]
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
+       call      qword ptr [7FF8A84A6BC8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83EE190]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83EE190]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       mov       rdx,7FF8A83FACF8
-       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8413690
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E1C258]
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
+       call      qword ptr [7FF8A8486D60]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83BE088]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83BE088]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       mov       rdx,7FF8A83FACF8
-       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8413690
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E2C228]
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
+       call      qword ptr [7FF8A84A78E8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82EE7F0]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82EE7F0]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       mov       rdx,7FF8A83FACF8
-       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A800ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8413690
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E4C228]
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
+       call      qword ptr [7FF8A84D7300]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82FDDE8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82FDDE8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       mov       rdx,7FF8A83FACF8
-       call      qword ptr [7FF8A7E37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8433690
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 		}
-; 		^
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
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
+       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       mov       rcx,7FF8A852DD04
-       call      CORINFO_HELP_COUNTPROFILE32
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E3C258]
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
+       call      qword ptr [7FF8A84A6BC8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83EE190]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-       mov       rcx,7FF8A852DD00
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
        add       rsp,28
        ret
-; Total bytes of code 241
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83EE190]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EE0A0]
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
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8A841ACF8
-       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8433690
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 		}
-; 		^
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
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
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       mov       rcx,7FF8A852DD04
-       call      CORINFO_HELP_COUNTPROFILE32
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E1C258]
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
+       call      qword ptr [7FF8A8486D60]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A83BE088]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-       mov       rcx,7FF8A852DD00
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
        add       rsp,28
        ret
-; Total bytes of code 241
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A83BE088]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83BDF98]
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
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8A841ACF8
-       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8433690
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 		}
-; 		^
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
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
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       mov       rcx,7FF8A852DD04
-       call      CORINFO_HELP_COUNTPROFILE32
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E2C228]
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
+       call      qword ptr [7FF8A84A78E8]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82EE7F0]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-       mov       rcx,7FF8A852DD00
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
        add       rsp,28
        ret
-; Total bytes of code 241
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82EE7F0]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82EE700]
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
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8A841ACF8
-       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A802ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       mov       rax,[rbp+10]
-       mov       r8,[rax+2D8]
-       mov       rcx,[rbp+10]
-       mov       rdx,7FF8A8433690
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-; 		var locksAcquired = 0;
-; 		^^^^^^^^^^^^^^^^^^^^^^
-; 			this.AcquireAllLocks(ref locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var tables = this._tables;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var locks = tables._locks;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			var buckets = tables._buckets;
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			Array.Clear(buckets, 0, buckets.Length);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this._budget = Math.Max(1, buckets.Length / lockCount);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 			this.ReleaseLocks(0, locksAcquired);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-; 		}
-; 		^
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L03
+M00_L01:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L04
+M00_L02:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L03:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L10
+M00_L07:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L11
+M00_L08:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L09:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L10:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+M00_L14:
+       mov       rdi,[rdi+8]
+       mov       ecx,[rdi+8]
+       lea       rdx,[rdi+10]
        xor       eax,eax
-       mov       [rbp-8],eax
-       lea       rdx,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
-       mov       rax,[rbp+10]
-       mov       rax,[rax+10]
-       mov       [rbp-10],rax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+10]
-       mov       eax,[rax+8]
-       mov       [rbp-14],eax
-       mov       rax,[rbp-10]
-       mov       rax,[rax+18]
-       mov       r8d,[rax+8]
-       mov       rax,[rbp-10]
-       mov       rcx,[rax+18]
-       xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-10]
-       mov       rax,[rax+8]
-       mov       [rbp-20],rax
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
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       jmp       short M00_L17
+M00_L16:
+       shr       rdx,3
+       mov       rcx,r10
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+M00_L17:
+       mov       eax,[rdi+8]
        xor       edx,edx
-       call      qword ptr [7FF8A8406418]; System.Array.Clear(System.Array, Int32, Int32)
-       mov       rax,[rbp-20]
-       mov       eax,[rax+8]
-       cdq
-       idiv      dword ptr [rbp-14]
-       mov       edx,eax
+       div       r14d
        mov       ecx,1
-       call      qword ptr [7FF8A7E5DA10]; System.Math.Max(Int32, Int32)
-       mov       rcx,[rbp+10]
-       mov       [rcx+18],eax
-       call      M01_L00
-       nop
-       mov       rcx,7FF8A852DD04
-       call      CORINFO_HELP_COUNTPROFILE32
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L22
+M00_L19:
+       mov       dword ptr [rbp-38],1
+       jmp       short M00_L23
+M00_L20:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L21:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L22:
+       mov       rcx,r15
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      00007FF9078ADF30
+       test      eax,eax
+       je        short M00_L27
+M00_L25:
+       mov       dword ptr [rbp-3C],1
+       jmp       short M00_L28
+M00_L26:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L27:
+       mov       rcx,r13
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
+       call      qword ptr [7FF8A7E4C228]
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
+       call      qword ptr [7FF8A84D7300]
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
+       call      00007FF9078ADE50
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
+       call      qword ptr [7FF8A82FDDE8]
+       jmp       short M00_L38
+M00_L41:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
+       int       3
+M00_L42:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+M00_L43:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
        sub       rsp,28
-       mov       rcx,7FF8A852DD00
-       call      CORINFO_HELP_COUNTPROFILE32
-       xor       eax,eax
-       mov       [rbp-28],eax
-       lea       rdx,[rbp-28]
-       lea       r8,[rbp-8]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
        add       rsp,28
        ret
-; Total bytes of code 241
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L53
+       mov       ecx,eax
+       mov       rdx,r14
+       call      qword ptr [7FF8A82FDDE8]
+M00_L53:
+       add       edi,1
+       jo        short M00_L56
+       cmp       edi,[rbp-34]
+       jl        short M00_L52
+       jmp       short M00_L57
+M00_L54:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A82FEB50]
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
-       je        short M02_L00
-       mov       rax,[rbp-20]
-       mov       [rbp-10],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp+18]
-       mov       rdx,7FF8A841ACF8
-       call      qword ptr [7FF8A7E57B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
-       mov       [rbp-10],rax
-M02_L01:
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84064A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
-       lea       r8,[rbp+20]
-       mov       rdx,[rbp-10]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
+       jbe       near ptr M02_L05
+       cmp       rdx,40
+       jbe       short M02_L04
+       cmp       rdx,400
+       ja        near ptr M02_L09
+       cmp       rdx,100
+       jae       near ptr M02_L08
+M02_L00:
+       mov       rax,rdx
+       shr       rax,6
+       nop       dword ptr [rax+rax]
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
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E3C258]
+       call      qword ptr [7FF8A7E1C258]
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
-       call      qword ptr [7FF8A84A6BC8]
+       call      qword ptr [7FF8A8486D60]
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
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A83BE088]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A83BE088]
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A83BDF98]
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
-       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 240
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E3C258]
+       call      qword ptr [7FF8A7E2C228]
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
-       call      qword ptr [7FF8A84A6BC8]
+       call      qword ptr [7FF8A84A78E8]
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
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A82EE7F0]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A82EE7F0]
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L57:
        add       rsp,28
        ret
 ; Total bytes of code 1262
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        push      rbx
        test      rdx,rdx
        je        short M02_L03
        lea       rbx,[rcx+rdx]
        cmp       rdx,10
-       jbe       near ptr M02_L05
+       jbe       short M02_L05
        cmp       rdx,40
        jbe       short M02_L04
        cmp       rdx,400
        ja        near ptr M02_L09
        cmp       rdx,100
        jae       near ptr M02_L08
 M02_L00:
        mov       rax,rdx
        shr       rax,6
-       nop       dword ptr [rax+rax]
 M02_L01:
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
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
-       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
-; Total bytes of code 240
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEFA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A824FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E3C258]
+       call      qword ptr [7FF8A7E4C228]
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
-       call      qword ptr [7FF8A84A6BC8]
+       call      qword ptr [7FF8A84D7300]
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
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A82FDDE8]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A83EE190]
+       call      qword ptr [7FF8A82FDDE8]
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
-       call      qword ptr [7FF8A83EE0A0]
+       call      qword ptr [7FF8A82FEB50]
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
-       jmp       qword ptr [7FF8A83044F8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 240
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
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E1C258]
+       call      qword ptr [7FF8A7E2C228]
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
-       call      qword ptr [7FF8A8486D60]
+       call      qword ptr [7FF8A84A78E8]
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
-       call      qword ptr [7FF8A83BE088]
+       call      qword ptr [7FF8A82EE7F0]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A83BE088]
+       call      qword ptr [7FF8A82EE7F0]
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
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82EE700]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L57:
        add       rsp,28
        ret
 ; Total bytes of code 1262
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        push      rbx
        test      rdx,rdx
        je        short M02_L03
        lea       rbx,[rcx+rdx]
        cmp       rdx,10
-       jbe       near ptr M02_L05
+       jbe       short M02_L05
        cmp       rdx,40
        jbe       short M02_L04
        cmp       rdx,400
        ja        near ptr M02_L09
        cmp       rdx,100
        jae       near ptr M02_L08
 M02_L00:
        mov       rax,rdx
        shr       rax,6
-       nop       dword ptr [rax+rax]
 M02_L01:
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
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
-       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
-; Total bytes of code 240
+       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 231
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
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83BEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A822F708]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E1C258]
+       call      qword ptr [7FF8A7E4C228]
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
-       call      qword ptr [7FF8A8486D60]
+       call      qword ptr [7FF8A84D7300]
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
-       call      qword ptr [7FF8A83BE088]
+       call      qword ptr [7FF8A82FDDE8]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A83BE088]
+       call      qword ptr [7FF8A82FDDE8]
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
-       call      qword ptr [7FF8A83BDF98]
+       call      qword ptr [7FF8A82FEB50]
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
-       jmp       qword ptr [7FF8A82D40A8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
 ; Total bytes of code 240
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
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L03:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L01
 M00_L04:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L11
 M00_L08:
        xor       ecx,ecx
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L09:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L10:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
-       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
+       call      qword ptr [7FF8A7C257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        jmp       short M00_L17
 M00_L16:
        shr       rdx,3
        mov       rcx,r10
-       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
 M00_L17:
        mov       eax,[rdi+8]
        xor       edx,edx
        mov       dword ptr [rbp-38],1
        jmp       short M00_L23
 M00_L20:
        xor       ecx,ecx
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 M00_L22:
        mov       rcx,r15
-       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L19
 M00_L23:
        mov       ecx,[rbp-34]
        mov       dword ptr [rbp-3C],1
        jmp       short M00_L28
 M00_L26:
        xor       ecx,ecx
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L27:
        mov       rcx,r13
-       call      qword ptr [7FF8A83EEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82FDDD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L25
 M00_L28:
        mov       ecx,[rbp-34]
        xor       ecx,ecx
        mov       [rbp-3C],ecx
        jmp       short M00_L24
 M00_L30:
        shr       rdx,3
        mov       rcx,r8
-       call      qword ptr [7FF8A823F720]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
+       call      qword ptr [7FF8A8247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
-       call      qword ptr [7FF8A7E2C228]
+       call      qword ptr [7FF8A7E4C228]
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
-       call      qword ptr [7FF8A84A78E8]
+       call      qword ptr [7FF8A84D7300]
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
-       call      qword ptr [7FF8A82EE7F0]
+       call      qword ptr [7FF8A82FDDE8]
        jmp       short M00_L38
 M00_L41:
        xor       ecx,ecx
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L53
        mov       ecx,eax
        mov       rdx,r14
-       call      qword ptr [7FF8A82EE7F0]
+       call      qword ptr [7FF8A82FDDE8]
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
-       call      qword ptr [7FF8A82EE700]
+       call      qword ptr [7FF8A82FEB50]
        int       3
 M00_L55:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L57:
        add       rsp,28
        ret
 ; Total bytes of code 1262
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
 ; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
        push      rbx
        test      rdx,rdx
        je        short M02_L03
        lea       rbx,[rcx+rdx]
        cmp       rdx,10
-       jbe       short M02_L05
+       jbe       near ptr M02_L05
        cmp       rdx,40
        jbe       short M02_L04
        cmp       rdx,400
        ja        near ptr M02_L09
        cmp       rdx,100
        jae       near ptr M02_L08
 M02_L00:
        mov       rax,rdx
        shr       rax,6
+       nop       dword ptr [rax+rax]
 M02_L01:
        vxorps    ymm0,ymm0,ymm0
        vmovdqu   ymmword ptr [rcx],ymm0
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
-       jmp       qword ptr [7FF8A82E54E8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
-; Total bytes of code 231
+       jmp       qword ptr [7FF8A82F4F90]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
+; Total bytes of code 240
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
        call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       rcx,7FF8A850D5F8
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 M02_L00:
+       mov       rcx,7FF8A850D5FC
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,2901D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,7E14F4F3
+       mov       ebx,1497159A
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83CDFF8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B414F8
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B414F0
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83CDFF8]
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,12512C00068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,4771CDF6
+       mov       ebx,0BCEEFBBC
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83EDA10]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B61348
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B61340
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EDA10]
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
+       sub       rsp,58
+       vzeroupper
+       lea       rbp,[rsp+90]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
+       lea       rcx,[rbp-70]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       rbx,rax
+       mov       rcx,rsp
+       mov       [rbp-58],rcx
+       mov       rcx,rbp
+       mov       [rbp-48],rcx
+       lea       rcx,[rbp+10]
+       mov       rax,7FF8A7C58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF9078AE370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF907B64A90],0
+       je        short M01_L01
+       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
+M01_L01:
+       mov       rax,[rbp-68]
+       mov       [rbx+8],rax
+       add       rsp,58
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
+; Total bytes of code 154
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8EED5214
+       mov       ebx,67757602
+       cmp       r10d,8
+       jb        near ptr M00_L16
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
+       jne       near ptr M00_L17
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A831E6E8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B81668
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L17:
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
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
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
+       mov       r11,7FF8A7B81660
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A831E6E8]
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,1C45D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83162C8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B71600
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F63D0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B715F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83162C8]
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
-       call      qword ptr [7FF8A83F6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       rcx,7FF8A850D5F8
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 M02_L00:
+       mov       rcx,7FF8A850D5FC
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
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,2901D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,7E14F4F3
+       mov       ebx,1497159A
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83CDFF8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B414F8
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B414F0
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83CDFF8]
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
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,12512C00068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,4771CDF6
+       mov       ebx,0BCEEFBBC
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83EDA10]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B61348
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B61340
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EDA10]
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
+       sub       rsp,58
+       vzeroupper
+       lea       rbp,[rsp+90]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
+       lea       rcx,[rbp-70]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       rbx,rax
+       mov       rcx,rsp
+       mov       [rbp-58],rcx
+       mov       rcx,rbp
+       mov       [rbp-48],rcx
+       lea       rcx,[rbp+10]
+       mov       rax,7FF8A7C58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF9078AE370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF907B64A90],0
+       je        short M01_L01
+       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
+M01_L01:
+       mov       rax,[rbp-68]
+       mov       [rbx+8],rax
+       add       rsp,58
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
+; Total bytes of code 154
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8EED5214
+       mov       ebx,67757602
+       cmp       r10d,8
+       jb        near ptr M00_L16
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
+       jne       near ptr M00_L17
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A831E6E8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B81668
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L17:
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
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
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
+       mov       r11,7FF8A7B81660
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A831E6E8]
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
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83F6208]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A801AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,1C45D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83162C8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B71600
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83F61F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       call      qword ptr [7FF8A83F6238]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B715F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 54
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83162C8]
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
-       call      qword ptr [7FF8A83F6280]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83F6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       rcx,7FF8A850D5F8
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbp+10]
+       mov       rdx,[rbp+18]
+       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+       nop
+       add       rsp,20
+       pop       rbp
+       ret
+M02_L00:
+       mov       rcx,7FF8A850D5FC
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
-       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,2901D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,7E14F4F3
+       mov       ebx,1497159A
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83CDFF8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B414F8
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       r11,7FF8A7B414F0
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83CDFF8]
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
-       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,12512C00068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,4771CDF6
+       mov       ebx,0BCEEFBBC
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83EDA10]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B61348
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       r11,7FF8A7B61340
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EDA10]
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
+       sub       rsp,58
+       vzeroupper
+       lea       rbp,[rsp+90]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
+       lea       rcx,[rbp-70]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       rbx,rax
+       mov       rcx,rsp
+       mov       [rbp-58],rcx
+       mov       rcx,rbp
+       mov       [rbp-48],rcx
+       lea       rcx,[rbp+10]
+       mov       rax,7FF8A7C58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF9078AE370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF907B64A90],0
+       je        short M01_L01
+       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
+M01_L01:
+       mov       rax,[rbp-68]
+       mov       [rbx+8],rax
+       add       rsp,58
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
+; Total bytes of code 154
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
-       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8EED5214
+       mov       ebx,67757602
+       cmp       r10d,8
+       jb        near ptr M00_L16
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
+       jne       near ptr M00_L17
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A831E6E8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B81668
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L17:
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
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
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
+       mov       r11,7FF8A7B81660
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A831E6E8]
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
-       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A84063D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A802AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,1C45D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83162C8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B71600
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A84063B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
+       mov       r11,7FF8A7B715F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 18
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83162C8]
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
-       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,2901D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,7E14F4F3
+       mov       ebx,1497159A
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83CDFF8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B414F8
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       mov       rcx,7FF8A850D5F8
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B414F0
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
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
-       mov       rcx,7FF8A850D5FC
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83CE0E8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83CDFF8]
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
-       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,12512C00068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,4771CDF6
+       mov       ebx,0BCEEFBBC
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83EDA10]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B61348
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       mov       rcx,7FF8A850D5F8
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B61340
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
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
-       mov       rcx,7FF8A850D5FC
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83EDB30]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83EDA10]
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
+       sub       rsp,58
+       vzeroupper
+       lea       rbp,[rsp+90]
        mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
+       lea       rcx,[rbp-70]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       rbx,rax
+       mov       rcx,rsp
+       mov       [rbp-58],rcx
+       mov       rcx,rbp
+       mov       [rbp-48],rcx
+       lea       rcx,[rbp+10]
+       mov       rax,7FF8A7C58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF9078AE370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF907B64A90],0
+       je        short M01_L01
+       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
+M01_L01:
+       mov       rax,[rbp-68]
+       mov       [rbx+8],rax
+       add       rsp,58
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
+; Total bytes of code 154
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
-       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,8EED5214
+       mov       ebx,67757602
+       cmp       r10d,8
+       jb        near ptr M00_L16
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
+       jne       near ptr M00_L17
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A831E6E8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B81668
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       mov       rcx,7FF8A850D5F8
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
+M00_L16:
+       cmp       r10d,4
+       jb        short M00_L19
+M00_L17:
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
+M00_L18:
+       xor       r10d,r10d
+       jmp       near ptr M00_L03
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
+       mov       r11,7FF8A7B81660
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
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
-       mov       rcx,7FF8A850D5FC
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A831E7D8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A831E6E8]
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
-       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       call      qword ptr [7FF8A83E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
-       mov       [rbp-10],rax
-       mov       rdx,[rbp-10]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A800AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
+       mov       r9,1C45D800068
+       mov       r9,[r9]
+       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
+       cmp       [r9],r11
+       jne       near ptr M00_L22
+       lea       r9,[r10+0C]
+       mov       r10d,[r10+8]
+       add       r10d,r10d
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
+       call      00007FF9078ADF30
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
+       call      qword ptr [7FF8A83162C8]
+       int       3
+M00_L09:
+       mov       rcx,[rbp-50]
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       jmp       short M00_L05
+M00_L10:
+       mov       rdx,[rdi+8]
+       mov       rcx,[rbp-48]
+       mov       r8,[rbp-40]
+       mov       r11,7FF8A7B71600
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       jne       near ptr M00_L24
+M00_L14:
+       xor       ebx,ebx
+M00_L15:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8A83E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       mov       rcx,7FF8A850D5F8
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
+       mov       r11,7FF8A7B715F8
+       call      qword ptr [r11]
+       mov       r10d,eax
+       mov       rax,[rbp-48]
+       jmp       near ptr M00_L03
+M00_L24:
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
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
-       mov       rcx,7FF8A850D5FC
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
+       call      00007FF9078ADE50
+       test      eax,eax
+       je        short M00_L30
+       mov       ecx,eax
+       mov       rdx,[rbp-50]
+       call      qword ptr [7FF8A83163B8]
+M00_L30:
+       nop
+       add       rsp,28
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+M00_L31:
+       xor       ecx,ecx
+       call      qword ptr [7FF8A83162C8]
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
-       call      qword ptr [7FF8A83E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8A83E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       lea       rcx,[rbp+10]
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,2901D800068
+       mov       r9,12512C00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7E14F4F3
-       mov       ebx,1497159A
+       mov       r11d,4771CDF6
+       mov       ebx,0BCEEFBBC
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
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A83EDA10]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B414F8
+       mov       r11,7FF8A7B61348
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
-       mov       r11,7FF8A7B414F0
+       mov       r11,7FF8A7B61340
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A83EDB30]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A83EDB30]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A83EDA10]
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
-       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
-       nop
-       add       rsp,88
+       mov       rax,7FF8A7C58210
+       mov       [rbp-60],rax
+       lea       rax,[M01_L00]
+       mov       [rbp-50],rax
+       lea       rax,[rbp-70]
+       mov       [rbx+8],rax
+       mov       byte ptr [rbx+4],0
+       mov       rax,7FF9078AE370
+       call      rax
+M01_L00:
+       mov       byte ptr [rbx+4],1
+       cmp       dword ptr [7FF907B64A90],0
+       je        short M01_L01
+       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
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
-       je        near ptr M00_L16
-       mov       r9,2901D800068
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7E14F4F3
-       mov       ebx,1497159A
+       mov       r11d,8EED5214
+       mov       ebx,67757602
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
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A831E6E8]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B414F8
+       mov       r11,7FF8A7B81668
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
        mov       rax,[rcx+88]
        mov       [rax+4C],bl
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
-       mov       r11,7FF8A7B414F0
+       mov       r11,7FF8A7B81660
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A831E7D8]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A831E7D8]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A831E6E8]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,2901D800068
+       mov       r9,1C45D800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7E14F4F3
-       mov       ebx,1497159A
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A83162C8]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83CD518]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B414F8
+       mov       r11,7FF8A7B71600
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
-       mov       r11,7FF8A7B414F0
+       mov       r11,7FF8A7B715F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A83163B8]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE0E8]
+       call      qword ptr [7FF8A83163B8]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83CDFF8]
+       call      qword ptr [7FF8A83162C8]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       je        near ptr M00_L16
-       mov       r9,12512C00068
+       je        near ptr M00_L18
+       mov       r9,22BC0400068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,4771CDF6
-       mov       ebx,0BCEEFBBC
+       mov       r11d,8EED5214
+       mov       ebx,67757602
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
-       call      qword ptr [7FF8A83EDA10]
+       call      qword ptr [7FF8A831E6E8]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B61348
+       mov       r11,7FF8A7B81668
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
        mov       rax,[rcx+88]
        mov       [rax+4C],bl
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
-       mov       r11,7FF8A7B61340
+       mov       r11,7FF8A7B81660
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83EDB30]
+       call      qword ptr [7FF8A831E7D8]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83EDB30]
+       call      qword ptr [7FF8A831E7D8]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EDA10]
+       call      qword ptr [7FF8A831E6E8]
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
-       mov       rax,7FF8A7C58210
-       mov       [rbp-60],rax
-       lea       rax,[M01_L00]
-       mov       [rbp-50],rax
-       lea       rax,[rbp-70]
-       mov       [rbx+8],rax
-       mov       byte ptr [rbx+4],0
-       mov       rax,7FF9078AE370
-       call      rax
-M01_L00:
-       mov       byte ptr [rbx+4],1
-       cmp       dword ptr [7FF907B64A90],0
-       je        short M01_L01
-       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
-M01_L01:
-       mov       rax,[rbp-68]
-       mov       [rbx+8],rax
-       add       rsp,58
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,12512C00068
+       mov       r9,1C45D800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,4771CDF6
-       mov       ebx,0BCEEFBBC
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
-       call      qword ptr [7FF8A83EDA10]
+       call      qword ptr [7FF8A83162C8]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83EDB48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B61348
+       mov       r11,7FF8A7B71600
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
-       mov       r11,7FF8A7B61340
+       mov       r11,7FF8A7B715F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83EDB30]
+       call      qword ptr [7FF8A83163B8]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83EDB30]
+       call      qword ptr [7FF8A83163B8]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83EDA10]
+       call      qword ptr [7FF8A83162C8]
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
-       mov       rax,7FF8A7C58210
-       mov       [rbp-60],rax
-       lea       rax,[M01_L00]
-       mov       [rbp-50],rax
-       lea       rax,[rbp-70]
-       mov       [rbx+8],rax
-       mov       byte ptr [rbx+4],0
-       mov       rax,7FF9078AE370
-       call      rax
-M01_L00:
-       mov       byte ptr [rbx+4],1
-       cmp       dword ptr [7FF907B64A90],0
-       je        short M01_L01
-       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
-M01_L01:
-       mov       rax,[rbp-68]
-       mov       [rbx+8],rax
-       add       rsp,58
+       mov       [rbp-98],rcx
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
+       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
+       mov       rcx,[rbp-98]
+       call      qword ptr [rax]
+       lea       rcx,[rbp-90]
+       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       je        near ptr M00_L18
-       mov       r9,22BC0400068
+       je        near ptr M00_L16
+       mov       r9,1C45D800068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,8EED5214
-       mov       ebx,67757602
+       mov       r11d,0AA8CBA48
+       mov       ebx,0BAAAF1AD
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
-       call      qword ptr [7FF8A831E6E8]
+       call      qword ptr [7FF8A83162C8]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A841ECE8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B81668
+       mov       r11,7FF8A7B71600
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
        mov       rax,[rcx+88]
        mov       [rax+4C],bl
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
-       mov       r11,7FF8A7B81660
+       mov       r11,7FF8A7B715F8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A831E7D8]
+       call      qword ptr [7FF8A83163B8]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L30
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A831E7D8]
+       call      qword ptr [7FF8A83163B8]
 M00_L30:
        nop
        add       rsp,28
        ret
 M00_L31:
        xor       ecx,ecx
-       call      qword ptr [7FF8A831E6E8]
+       call      qword ptr [7FF8A83162C8]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,23517000068
+       mov       r9,24E0FC00068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7402228D
-       mov       ebx,8AD10323
+       mov       r11d,6DC2F83E
+       mov       ebx,0D3C93C09
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
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A83CDF50]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83DEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A83CCC78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B51510
+       mov       r11,7FF8A7B414E0
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
-       mov       r11,7FF8A7B51508
+       mov       r11,7FF8A7B414D8
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A83CE040]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A83CE040]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A83CDF50]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       je        near ptr M00_L16
-       mov       r9,23517000068
+       je        near ptr M00_L18
+       mov       r9,245D5000068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7402228D
-       mov       ebx,8AD10323
+       mov       r11d,2E88F28C
+       mov       ebx,1B44E95F
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
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A82DFBD0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83DEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82DF180]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B51510
+       mov       r11,7FF8A7B51640
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
-       mov       r11,7FF8A7B51508
+       mov       r11,7FF8A7B51638
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A82DF198]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A82DF198]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A82DFBD0]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,23517000068
+       mov       r9,20F25400068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,7402228D
-       mov       ebx,8AD10323
+       mov       r11d,0CD841C85
+       mov       ebx,18CE3136
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
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A8316220]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83DEEE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317558]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B51510
+       mov       r11,7FF8A7B71658
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
-       mov       r11,7FF8A7B51508
+       mov       r11,7FF8A7B71650
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A8316310]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83DDE78]
+       call      qword ptr [7FF8A8316310]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83DDD88]
+       call      qword ptr [7FF8A8316220]
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
-       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,24E0FC00068
+       je        near ptr M00_L18
+       mov       r9,245D5000068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,6DC2F83E
-       mov       ebx,0D3C93C09
+       mov       r11d,2E88F28C
+       mov       ebx,1B44E95F
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
-       call      qword ptr [7FF8A83CDF50]
+       call      qword ptr [7FF8A82DFBD0]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83CCC78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A82DF180]; System.Threading.Monitor.Enter_Slowpath(System.Object)
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B414E0
+       mov       r11,7FF8A7B51640
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
-       mov       r11,7FF8A7B414D8
+       mov       r11,7FF8A7B51638
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE040]
+       call      qword ptr [7FF8A82DF198]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE040]
+       call      qword ptr [7FF8A82DF198]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83CDF50]
+       call      qword ptr [7FF8A82DFBD0]
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
        call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
        mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
        mov       rcx,[rbp-98]
        call      qword ptr [rax]
        lea       rcx,[rbp-90]
        call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       mov       r9,24E0FC00068
+       mov       r9,20F25400068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,6DC2F83E
-       mov       ebx,0D3C93C09
+       mov       r11d,0CD841C85
+       mov       ebx,18CE3136
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
-       call      qword ptr [7FF8A83CDF50]
+       call      qword ptr [7FF8A8316220]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A83CCC78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317558]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B414E0
+       mov       r11,7FF8A7B71658
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
-       mov       r11,7FF8A7B414D8
+       mov       r11,7FF8A7B71650
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE040]
+       call      qword ptr [7FF8A8316310]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A83CE040]
+       call      qword ptr [7FF8A8316310]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A83CDF50]
+       call      qword ptr [7FF8A8316220]
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
-       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
-       je        near ptr M00_L18
-       mov       r9,245D5000068
+       je        near ptr M00_L16
+       mov       r9,20F25400068
        mov       r9,[r9]
        mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
        cmp       [r9],r11
        jne       near ptr M00_L22
        lea       r9,[r10+0C]
        mov       r10d,[r10+8]
        add       r10d,r10d
-       mov       r11d,2E88F28C
-       mov       ebx,1B44E95F
+       mov       r11d,0CD841C85
+       mov       ebx,18CE3136
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
-       call      qword ptr [7FF8A82DFBD0]
+       call      qword ptr [7FF8A8316220]
        int       3
 M00_L09:
        mov       rcx,[rbp-50]
-       call      qword ptr [7FF8A82DF180]; System.Threading.Monitor.Enter_Slowpath(System.Object)
+       call      qword ptr [7FF8A8317558]
        jmp       short M00_L05
 M00_L10:
        mov       rdx,[rdi+8]
        mov       rcx,[rbp-48]
        mov       r8,[rbp-40]
-       mov       r11,7FF8A7B51640
+       mov       r11,7FF8A7B71658
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
-       mov       r11,7FF8A7B51638
+       mov       r11,7FF8A7B71650
        call      qword ptr [r11]
        mov       r10d,eax
        mov       rax,[rbp-48]
        jmp       near ptr M00_L03
 M00_L24:
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A82DF198]
+       call      qword ptr [7FF8A8316310]
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
        call      00007FF9078ADE50
        test      eax,eax
        je        short M00_L29
        mov       ecx,eax
        mov       rdx,[rbp-50]
-       call      qword ptr [7FF8A82DF198]
+       call      qword ptr [7FF8A8316310]
 M00_L29:
        nop
        add       rsp,28
        ret
 M00_L30:
        xor       ecx,ecx
-       call      qword ptr [7FF8A82DFBD0]
+       call      qword ptr [7FF8A8316220]
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
-       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
-       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
-       mov       rcx,[rbp-98]
-       call      qword ptr [rax]
-       lea       rcx,[rbp-90]
-       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
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
