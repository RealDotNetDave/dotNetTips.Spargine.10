## DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark-20260913-013130
**Diff for Add method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Add()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2E8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3E7468]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF86C3F6BE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C00D770]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF86C01D770]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       rax,[rax+2E8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3E7480]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
+       call      qword ptr [7FF86C3F6BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C00D770]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF86C01D770]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       r8,[rax+2E8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF86C416100
-       call      qword ptr [7FF86C3E7438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF86C42D7A8
+       call      qword ptr [7FF86C3F6BB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 151
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+50]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
 ; 		if (item is null)
 ; 		^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        jne       short M02_L00
 ; 			throw new ArgumentNullException(nameof(item));
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-8],rax
        mov       ecx,24AB
-       mov       rdx,7FF86BEE4F20
-       call      qword ptr [7FF86BE1C060]
+       mov       rdx,7FF86BEF4F20
+       call      qword ptr [7FF86BE377C8]
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
-       call      qword ptr [7FF86BF67FA8]
+       call      qword ptr [7FF86BF77720]
        mov       rcx,[rbp-8]
        call      CORINFO_HELP_THROW
        int       3
 ; 		if (this._uniqueItems.TryAdd(item))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M02_L00:
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C2FF618]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF86C31ED00]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        test      eax,eax
        je        short M02_L01
 ; 			this._bag.Add(item);
 ; 			^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C2FF630]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF86C31ED18]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
 M02_L01:
        nop
        add       rsp,30
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+58]
        pop       rbp
        ret
 ; Total bytes of code 18
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
-       mov       rdx,7FF86C3FA740
-       call      qword ptr [7FF86BE1C420]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF86C41A7C8
+       call      qword ptr [7FF86BE37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3E74E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF86C3F6C58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C3E7498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF86C3F6C10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Clear method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2E8]
        cmp       [rcx],ecx
        call      qword ptr [7FF86C00D778]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2E8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF86C41D160
-       call      qword ptr [7FF86C3E6AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF86C40B9A0
+       call      qword ptr [7FF86C3E6700]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        xor       eax,eax
        mov       [rbp-48],rax
        mov       [rbp-40],rcx
        mov       [rbp+10],rcx
        mov       dword ptr [rbp-50],3E8
        mov       eax,[rbp-50]
        dec       eax
        mov       [rbp-50],eax
        cmp       dword ptr [rbp-50],0
        jg        short M01_L01
        lea       rcx,[rbp-50]
        xor       edx,edx
        call      CORINFO_HELP_PATCHPOINT
 ; 		while (this._bag.TryTake(out _))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L01:
        lea       rdx,[rbp-48]
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C33DE70]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
+       call      qword ptr [7FF86C32BF30]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
        test      eax,eax
        jne       short M01_L02
-       mov       rcx,7FF86C41D1E0
+       mov       rcx,7FF86C40BA20
        call      CORINFO_HELP_COUNTPROFILE32
 ; 		this._uniqueItems.Clear();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C33FC40]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF86C32DD00]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
        nop
        add       rsp,70
        pop       rbp
        ret
 M01_L02:
-       mov       rcx,7FF86C41D1E4
+       mov       rcx,7FF86C40BA24
        call      CORINFO_HELP_COUNTPROFILE32
        jmp       short M01_L00
 ; Total bytes of code 135
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
-       mov       rdx,7FF86C40A878
+       mov       rdx,7FF86C3FBBA8
        call      qword ptr [7FF86BE27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3E6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF86C3E6880]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C3E6BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF86C3E6838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Remove method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Remove()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2E8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3C6BC8]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
+       call      qword ptr [7FF86C3E6B38]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86BFED798]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF86C00D798]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3C6BB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF86C3E6B20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+218]
        pop       rbp
        ret
 ; Total bytes of code 21
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
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
        mov       [rbp-20],rax
        mov       rax,[rbp-20]
        mov       rax,[rax+30]
        mov       rax,[rax]
        mov       rax,[rax+38]
        mov       [rbp-28],rax
        cmp       qword ptr [rbp-28],0
        je        short M02_L00
        mov       rax,[rbp-28]
        mov       [rbp-18],rax
        jmp       short M02_L01
 M02_L00:
        mov       rcx,[rbp-20]
-       mov       rdx,7FF86C3EA698
-       call      qword ptr [7FF86BBEC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
+       mov       rdx,7FF86C40A5B0
+       call      qword ptr [7FF86BC0C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
        mov       [rbp-18],rax
 M02_L01:
-       mov       rax,2B08EC6BC40
+       mov       rax,25A616BBC40
        mov       [rsp+20],rax
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
        mov       r8,[rbp-10]
-       mov       r9,2B08EC60008
-       call      qword ptr [7FF86C004240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,25A616B0008
+       call      qword ptr [7FF86C024240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp+18],rax
 ; 		if (this._uniqueItems.Remove(item))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C31F370]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF86C33EE98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        test      eax,eax
        je        short M02_L02
 ; 			this.ReconstructBagWithout(item);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF86C3C6C28]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
+       call      qword ptr [7FF86C3E6B98]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
 ; 			return true;
 ; 			^^^^^^^^^^^^
        mov       eax,1
        add       rsp,50
        pop       rbp
        ret
 ; 		return false;
 ; 		^^^^^^^^^^^^^
 M02_L02:
        xor       eax,eax
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 209
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF86C3C6E08]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF86C3E6D78]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF86C3C6DD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF86C3E6D48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
