## DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark-20260725-223344
**Diff for Add method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Add()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDD58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC206AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABE2A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDD70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
+       call      qword ptr [7FF8AC206AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABE2A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC25A7D8
-       call      qword ptr [7FF8AC1FDD28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC23ABF8
+       call      qword ptr [7FF8AC206A90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rax,[rax+48]
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
-       mov       rdx,7FF8ABCF4D10
-       call      qword ptr [7FF8ABC2C030]
+       mov       rdx,7FF8ABD04D10
+       call      qword ptr [7FF8ABC477C8]
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
-       call      qword ptr [7FF8ABD77EA0]
+       call      qword ptr [7FF8ABD87618]
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
-       call      qword ptr [7FF8AC1F4E70]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF8AC12EC28]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        test      eax,eax
        je        short M02_L01
 ; 			this._bag.Add(item);
 ; 			^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1F4E88]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8AC12EC40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
        mov       rax,[rax+50]
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
-       mov       rdx,7FF8AC23A210
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC21A7C8
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDDD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC206B38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1FDD88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC206AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Add method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Add()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDD58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1C6B08]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABDEA608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDD70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
+       call      qword ptr [7FF8AC1C6B20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE1A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABDEA608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC25A7D8
-       call      qword ptr [7FF8AC1FDD28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1FAAD0
+       call      qword ptr [7FF8AC1C6AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+; 		if (item is null)
+; 		^^^^^^^^^^^^^^^^^
+; 			throw new ArgumentNullException(nameof(item));
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 		if (this._uniqueItems.TryAdd(item))
+; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this._bag.Add(item);
+; 			^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-; 		if (item is null)
-; 		^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        jne       short M02_L00
-; 			throw new ArgumentNullException(nameof(item));
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-8],rax
        mov       ecx,24AB
-       mov       rdx,7FF8ABCF4D10
-       call      qword ptr [7FF8ABC2C030]
+       mov       rdx,7FF8ABCC4D10
+       call      qword ptr [7FF8ABC077C8]
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
-       call      qword ptr [7FF8ABD77EA0]
+       call      qword ptr [7FF8ABD47618]
        mov       rcx,[rbp-8]
        call      CORINFO_HELP_THROW
        int       3
-; 		if (this._uniqueItems.TryAdd(item))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M02_L00:
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1F4E70]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF8AC0DEC58]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        test      eax,eax
        je        short M02_L01
-; 			this._bag.Add(item);
-; 			^^^^^^^^^^^^^^^^^^^^
+       mov       rcx,7FF8AC2C7648
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1F4E88]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8AC0DEC70]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
 M02_L01:
+       mov       rcx,7FF8AC2C764C
+       call      CORINFO_HELP_COUNTPROFILE32
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 154
+; Total bytes of code 184
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+50]
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
-       mov       rdx,7FF8AC23A210
-       call      qword ptr [7FF8ABC2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1DA7C8
+       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1FDDD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6B80]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1FDD88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1C6B38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Add method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Add()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   ymmword ptr [rbp-20],ymm4
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1C6B08]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE2A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABDEA608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
+       call      qword ptr [7FF8AC1C6B20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE2A608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8ABDEA608]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC23ABF8
-       call      qword ptr [7FF8AC206A90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1FAAD0
+       call      qword ptr [7FF8AC1C6AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+; 		if (item is null)
+; 		^^^^^^^^^^^^^^^^^
+; 			throw new ArgumentNullException(nameof(item));
+; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 		if (this._uniqueItems.TryAdd(item))
+; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
+; 			this._bag.Add(item);
+; 			^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-; 		if (item is null)
-; 		^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        jne       short M02_L00
-; 			throw new ArgumentNullException(nameof(item));
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-8],rax
        mov       ecx,24AB
-       mov       rdx,7FF8ABD04D10
-       call      qword ptr [7FF8ABC477C8]
+       mov       rdx,7FF8ABCC4D10
+       call      qword ptr [7FF8ABC077C8]
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
-       call      qword ptr [7FF8ABD87618]
+       call      qword ptr [7FF8ABD47618]
        mov       rcx,[rbp-8]
        call      CORINFO_HELP_THROW
        int       3
-; 		if (this._uniqueItems.TryAdd(item))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M02_L00:
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC12EC28]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF8AC0DEC58]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        test      eax,eax
        je        short M02_L01
-; 			this._bag.Add(item);
-; 			^^^^^^^^^^^^^^^^^^^^
+       mov       rcx,7FF8AC2C7648
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC12EC40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
+       call      qword ptr [7FF8AC0DEC70]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
 M02_L01:
+       mov       rcx,7FF8AC2C764C
+       call      CORINFO_HELP_COUNTPROFILE32
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 154
+; Total bytes of code 184
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+50]
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
-       mov       rdx,7FF8AC21A7C8
-       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1DA7C8
+       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206B38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6B80]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC206AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1C6B38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

```
**Diff for Clear method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0A610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABE2A610]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC21A5C8
-       call      qword ptr [7FF8AC1E69E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC23B038
+       call      qword ptr [7FF8AC206AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,70
-       lea       rbp,[rsp+70]
-       xor       eax,eax
-       mov       [rbp-48],rax
-       mov       [rbp-40],rcx
-       mov       [rbp+10],rcx
-       mov       dword ptr [rbp-50],3E8
-M01_L00:
-       mov       eax,[rbp-50]
-       dec       eax
-       mov       [rbp-50],eax
-       cmp       dword ptr [rbp-50],0
-       jg        short M01_L01
-       lea       rcx,[rbp-50]
-       xor       edx,edx
-       call      CORINFO_HELP_PATCHPOINT
-; 		while (this._bag.TryTake(out _))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-M01_L01:
-       lea       rdx,[rbp-48]
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC13B840]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
-       test      eax,eax
-       jne       short M01_L02
-       mov       rcx,7FF8AC21A648
-       call      CORINFO_HELP_COUNTPROFILE32
-; 		this._uniqueItems.Clear();
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC13D610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       nop
-       add       rsp,70
-       pop       rbp
-       ret
-M01_L02:
-       mov       rcx,7FF8AC21A64C
-       call      CORINFO_HELP_COUNTPROFILE32
-       jmp       short M01_L00
-; Total bytes of code 135
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
-       mov       rdx,7FF8AC1FA878
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC22A960
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6B68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC206C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E6B20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC206C28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Clear()
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE0A610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
+       call      qword ptr [7FF8ABE2A610]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
        mov       rax,[rbp+10]
        mov       r8,[rax+2D8]
        mov       rcx,[rbp+10]
-       mov       rdx,7FF8AC21A5C8
-       call      qword ptr [7FF8AC1E69E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC23B038
+       call      qword ptr [7FF8AC206AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 71
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       push      rbp
-       sub       rsp,70
-       lea       rbp,[rsp+70]
-       xor       eax,eax
-       mov       [rbp-48],rax
-       mov       [rbp-40],rcx
-       mov       [rbp+10],rcx
-       mov       dword ptr [rbp-50],3E8
-M01_L00:
-       mov       eax,[rbp-50]
-       dec       eax
-       mov       [rbp-50],eax
-       cmp       dword ptr [rbp-50],0
-       jg        short M01_L01
-       lea       rcx,[rbp-50]
-       xor       edx,edx
-       call      CORINFO_HELP_PATCHPOINT
-; 		while (this._bag.TryTake(out _))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-M01_L01:
-       lea       rdx,[rbp-48]
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC13B840]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
-       test      eax,eax
-       jne       short M01_L02
-       mov       rcx,7FF8AC21A648
-       call      CORINFO_HELP_COUNTPROFILE32
-; 		this._uniqueItems.Clear();
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC13D610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
-       nop
-       add       rsp,70
-       pop       rbp
-       ret
-M01_L02:
-       mov       rcx,7FF8AC21A64C
-       call      CORINFO_HELP_COUNTPROFILE32
-       jmp       short M01_L00
-; Total bytes of code 135
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
-       mov       rdx,7FF8AC1FA878
-       call      qword ptr [7FF8ABC27B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC22A960
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
-M02_L01:
+M01_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6B68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC206C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E6B20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC206C28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for Remove method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
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
        mov       rax,[rax+2D8]
        mov       [rbp-8],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206AF0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
+       call      qword ptr [7FF8AC1C6A30]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE2A630]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDEA630]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1C6A18]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        mov       rax,[rax+208]
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
-       mov       rdx,7FF8AC22A698
-       call      qword ptr [7FF8ABA2C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1EA5B0
+       call      qword ptr [7FF8AB9EC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
        mov       [rbp-18],rax
 M02_L01:
-       mov       rax,2414ACDBB70
+       mov       rax,1FFBE3EBB70
        mov       [rsp+20],rax
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
        mov       r8,[rbp-10]
-       mov       r9,2414ACD0008
-       call      qword ptr [7FF8ABFDF4C8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       mov       r9,1FFBE3E0008
+       call      qword ptr [7FF8ABF9F4C8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp+18],rax
 ; 		if (this._uniqueItems.Remove(item))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC15DAE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8AC11DAE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        test      eax,eax
        je        short M02_L02
 ; 			this.ReconstructBagWithout(item);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC206B50]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
+       call      qword ptr [7FF8AC1C6A90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
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
-       call      qword ptr [7FF8AC206D30]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC206D00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1C6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Remove()
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
-       call      qword ptr [7FF8AC206AF0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
+       call      qword ptr [7FF8AC1C6B08]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABE2A630]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDEA630]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1C6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        mov       rax,[rax+208]
        pop       rbp
        ret
 ; Total bytes of code 21
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		item = item.ArgumentNotNull();
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-10],rax
-       mov       rax,[rbp+10]
-       mov       rax,[rax]
-       mov       [rbp-20],rax
-       mov       rax,[rbp-20]
-       mov       rax,[rax+30]
-       mov       rax,[rax]
-       mov       rax,[rax+38]
-       mov       [rbp-28],rax
-       cmp       qword ptr [rbp-28],0
-       je        short M02_L00
-       mov       rax,[rbp-28]
-       mov       [rbp-18],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FF8AC22A698
-       call      qword ptr [7FF8ABA2C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
-       mov       [rbp-18],rax
-M02_L01:
-       mov       rax,2414ACDBB70
-       mov       [rsp+20],rax
-       mov       rcx,[rbp-18]
-       mov       rdx,[rbp+18]
-       mov       r8,[rbp-10]
-       mov       r9,2414ACD0008
-       call      qword ptr [7FF8ABFDF4C8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp+18],rax
-; 		if (this._uniqueItems.Remove(item))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+18]
-       mov       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC15DAE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       test      eax,eax
-       je        short M02_L02
-; 			this.ReconstructBagWithout(item);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC206B50]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
-; 			return true;
-; 			^^^^^^^^^^^^
-       mov       eax,1
-       add       rsp,50
-       pop       rbp
-       ret
-; 		return false;
-; 		^^^^^^^^^^^^^
-M02_L02:
-       xor       eax,eax
-       add       rsp,50
-       pop       rbp
-       ret
-; Total bytes of code 209
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC206D30]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6D48]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC206D00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1C6D18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.Remove()
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
-       call      qword ptr [7FF8AC1C6A30]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
+       call      qword ptr [7FF8AC1C6B08]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        mov       [rbp-10],rax
        mov       rdx,[rbp-10]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8ABDEA630]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8ABDEA630]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6A18]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1C6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        mov       rax,[rax+208]
        pop       rbp
        ret
 ; Total bytes of code 21
-; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-; 		item = item.ArgumentNotNull();
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       xor       eax,eax
-       mov       [rbp-10],rax
-       mov       rax,[rbp+10]
-       mov       rax,[rax]
-       mov       [rbp-20],rax
-       mov       rax,[rbp-20]
-       mov       rax,[rax+30]
-       mov       rax,[rax]
-       mov       rax,[rax+38]
-       mov       [rbp-28],rax
-       cmp       qword ptr [rbp-28],0
-       je        short M02_L00
-       mov       rax,[rbp-28]
-       mov       [rbp-18],rax
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FF8AC1EA5B0
-       call      qword ptr [7FF8AB9EC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
-       mov       [rbp-18],rax
-M02_L01:
-       mov       rax,1FFBE3EBB70
-       mov       [rsp+20],rax
-       mov       rcx,[rbp-18]
-       mov       rdx,[rbp+18]
-       mov       r8,[rbp-10]
-       mov       r9,1FFBE3E0008
-       call      qword ptr [7FF8ABF9F4C8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp+18],rax
-; 		if (this._uniqueItems.Remove(item))
-; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rax,[rbp+10]
-       mov       rcx,[rax+18]
-       mov       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF8AC11DAE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       test      eax,eax
-       je        short M02_L02
-; 			this.ReconstructBagWithout(item);
-; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FF8AC1C6A90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ReconstructBagWithout(System.__Canon)
-; 			return true;
-; 			^^^^^^^^^^^^
-       mov       eax,1
-       add       rsp,50
-       pop       rbp
-       ret
-; 		return false;
-; 		^^^^^^^^^^^^^
-M02_L02:
-       xor       eax,eax
-       add       rsp,50
-       pop       rbp
-       ret
-; Total bytes of code 209
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1C6D48]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1C6D18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for TryAdd method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.TryAdd()
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
-       call      qword ptr [7FF8AC1E6B08]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1F6B20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E6B20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF8AC1F6B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        mov       [rbp-1C],eax
        mov       edx,[rbp-1C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1F6B08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6B38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
+       call      qword ptr [7FF8AC1F6B50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef02()
        mov       [rbp-28],rax
        mov       rdx,[rbp-28]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E6B20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
+       call      qword ptr [7FF8AC1F6B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        mov       [rbp-2C],eax
        mov       edx,[rbp-2C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1F6B08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        nop
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 158
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-18],rax
        mov       [rbp-20],rax
        mov       [rbp-8],rcx
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
        mov       [rbp-18],rax
        mov       ecx,24AB
-       mov       rdx,7FF8ABCE4D10
-       call      qword ptr [7FF8ABC277C8]
+       mov       rdx,7FF8ABCF4D10
+       call      qword ptr [7FF8ABC377C8]
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       rcx,[rbp-18]
-       call      qword ptr [7FF8ABD67618]
+       call      qword ptr [7FF8ABD77618]
        mov       rcx,[rbp-18]
        call      CORINFO_HELP_THROW
        int       3
 ; 		if (this._uniqueItems.AddIfNotExists(item))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       [rbp-28],rax
        mov       rax,[rbp-28]
        mov       rax,[rax+30]
        mov       rax,[rax]
        mov       rax,[rax+38]
        mov       [rbp-30],rax
        cmp       qword ptr [rbp-30],0
        je        short M02_L01
        mov       rax,[rbp-30]
        mov       [rbp-10],rax
        jmp       short M02_L02
 M02_L01:
        mov       rcx,[rbp-28]
        mov       rdx,7FF8AC20A718
-       call      qword ptr [7FF8ABA0C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
+       call      qword ptr [7FF8ABA1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M02_L02:
        mov       rax,[rbp+10]
        mov       rdx,[rax+18]
        mov       rcx,[rbp-10]
        mov       r8,[rbp+18]
-       call      qword ptr [7FF8AC1E6B50]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FF8AC1F6B68]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
        test      eax,eax
        je        short M02_L03
 ; 			this._bag.Add(item);
 ; 			^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
        call      qword ptr [7FF8AC10ECA0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
 ; 			return true;
 ; 			^^^^^^^^^^^^
        mov       eax,1
        add       rsp,50
        pop       rbp
        ret
 ; 		return false;
 ; 		^^^^^^^^^^^^^
 M02_L03:
        xor       eax,eax
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 243
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1E6E68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1F6E80]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1E6E38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1F6E50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
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
**Diff for TryGetValue method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.TryGetValue()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6658]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
+       call      qword ptr [7FF8AC1F6B20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        lea       r8,[rbp-8]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6670]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
+       call      qword ptr [7FF8AC1F6B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
        mov       [rbp-1C],eax
        mov       edx,[rbp-1C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6610]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1F6AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        mov       rcx,[rbp+10]
        mov       r8,[rbp-8]
-       mov       rdx,7FF8AC1FA490
-       call      qword ptr [7FF8AC1C6628]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC22B0B0
+       call      qword ptr [7FF8AC1F6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 125
 ; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+48]
        pop       rbp
        ret
 ; Total bytes of code 18
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
 ; 		if (equalValue is null)
 ; 		^^^^^^^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        jne       short M02_L00
 ; 			actualValue = default!;
 ; 			^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+20]
        xor       ecx,ecx
        mov       [rax],rcx
 ; 			return false;
 ; 			^^^^^^^^^^^^^
        xor       eax,eax
        add       rsp,20
        pop       rbp
        ret
 ; 		return this._uniqueItems.TryPeek(equalValue, out actualValue!);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M02_L00:
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6688]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
+       call      qword ptr [7FF8AC1F6B50]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6730]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1F6BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1F6BC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
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
-       mov       rdx,7FF8AC1EAA28
-       call      qword ptr [7FF8ABC17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC21AAA0
+       call      qword ptr [7FF8ABC37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6730]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1F6BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6748]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1F6C10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for TryPeek method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.TryPeek()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+2D8]
        mov       [rbp-10],rax
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6B20]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
+       call      qword ptr [7FF8AC1D66E8]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        lea       r8,[rbp-8]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
+       call      qword ptr [7FF8AC1D6700]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
        mov       [rbp-1C],eax
        mov       edx,[rbp-1C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC1D66A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        mov       rcx,[rbp+10]
        mov       r8,[rbp-8]
-       mov       rdx,7FF8AC1FB0B0
-       call      qword ptr [7FF8AC1C6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC1FD3B0
+       call      qword ptr [7FF8AC1D66B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 125
 ; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
        push      rbp
        mov       rbp,rsp
        mov       [rbp+10],rcx
        mov       rax,[rbp+10]
        mov       rax,[rax+208]
        pop       rbp
        ret
 ; Total bytes of code 21
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
 ; 		if (equalValue is null)
 ; 		^^^^^^^^^^^^^^^^^^^^^^^
        cmp       qword ptr [rbp+18],0
        jne       short M02_L00
 ; 			actualValue = default!;
 ; 			^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+20]
        xor       ecx,ecx
        mov       [rax],rcx
 ; 			return false;
 ; 			^^^^^^^^^^^^^
        xor       eax,eax
        add       rsp,20
        pop       rbp
        ret
 ; 		return this._uniqueItems.TryPeek(equalValue, out actualValue!);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M02_L00:
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6B50]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
+       call      qword ptr [7FF8AC1D6718]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryPeek(System.__Canon, System.__Canon ByRef)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6838]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC1D6808]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
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
-       mov       rdx,7FF8AC1EAC68
-       call      qword ptr [7FF8ABC07B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC1EABF0
+       call      qword ptr [7FF8ABC17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M04_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1C6C70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC1D6838]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1C6C88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC1D6850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
**Diff for TryTake method between:**
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
.NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagMutatingBenchmark.TryTake()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        lea       rdx,[rbp-8]
        mov       rax,[rbp+10]
        mov       rcx,[rax+2D8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6B20]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
+       call      qword ptr [7FF8AC206A30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6AD8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       call      qword ptr [7FF8AC2069E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        mov       rcx,[rbp+10]
        mov       r8,[rbp-8]
-       mov       rdx,7FF8AC20B0B0
-       call      qword ptr [7FF8AC1D6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
+       mov       rdx,7FF8AC23AA68
+       call      qword ptr [7FF8AC206A00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 90
 ; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
 ; 		if (this._bag.TryTake(out result!))
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+10]
        mov       rcx,[rax+8]
        mov       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC12BCF8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
+       call      qword ptr [7FF8AC15BCD8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].TryTake(System.__Canon ByRef)
        test      eax,eax
        je        short M01_L00
 ; 			return this._uniqueItems.Remove(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rax,[rbp+18]
        mov       rdx,[rax]
        mov       rax,[rbp+10]
        mov       rcx,[rax+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC12DAE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FF8AC15DAC0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; 		result = default!;
 ; 		^^^^^^^^^^^^^^^^^^
 M01_L00:
        mov       rax,[rbp+18]
        xor       ecx,ecx
        mov       [rax],rcx
 ; 		return false;
 ; 		^^^^^^^^^^^^^
        xor       eax,eax
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 89
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC206B50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6C10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8AC206B20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
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
-       mov       rdx,7FF8AC1FAD28
-       call      qword ptr [7FF8ABC17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
+       mov       rdx,7FF8AC22AC40
+       call      qword ptr [7FF8ABC47B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
        mov       [rbp-10],rax
 M03_L01:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF8AC1D6C40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF8AC206B50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        lea       r8,[rbp+20]
        mov       rdx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8AC1D6C58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF8AC206B68]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 130
```
