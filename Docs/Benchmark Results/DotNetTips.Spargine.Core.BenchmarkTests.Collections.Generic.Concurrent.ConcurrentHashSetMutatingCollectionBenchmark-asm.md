## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+278]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C309D88]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6EB110
       call      qword ptr [7FF80C6D51B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FF80C6D5200]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
       call      qword ptr [7FF80C6D5218]; System.Array.Clear(System.Array, Int32, Int32)
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
       call      qword ptr [7FF80C6D5218]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FF80C1AD9C8]; System.Math.Max(Int32, Int32)
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
       call      qword ptr [7FF80C6D5230]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
       mov       rdx,7FF80C6F7680
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6D52A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6D5260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+278]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C2F9D88]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6997F0
       call      qword ptr [7FF80C5CDA70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FF80C5CDAB8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
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
       call      qword ptr [7FF80C5CDAD0]; System.Array.Clear(System.Array, Int32, Int32)
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
       call      qword ptr [7FF80C5CDAD0]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FF80C12D968]; System.Math.Max(Int32, Int32)
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
       call      qword ptr [7FF80C5CDAE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
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
       mov       rdx,7FF80C6891C0
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C5CDB60]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C5CDB18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+278]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C319D88]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71BEE8
       call      qword ptr [7FF80C705668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6F9A80
       call      qword ptr [7FF80C147B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+278]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C319D88]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71D790
       call      qword ptr [7FF80C705698]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rbp-8],eax
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C7056E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FF80C7056F8]; System.Array.Clear(System.Array, Int32, Int32)
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FF80C7056F8]; System.Array.Clear(System.Array, Int32, Int32)
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FF80C14D968]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       mov       rcx,7FF80C819694
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
       mov       rcx,7FF80C819690
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705710]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 241
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
       mov       rdx,7FF80C6F9A80
       call      qword ptr [7FF80C147B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705740]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF80C6FE3B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF80C6FE3B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
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
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
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
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF80C54EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF80C6FE3B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FF80C6FE3B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF80C54EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
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
       call      qword ptr [7FF80C12C240]
       int       3
M00_L33:
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
       call      qword ptr [7FF80C7A6190]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FF86BBB2A70
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+60]
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
       call      qword ptr [7FF80C6FD530]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
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
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80C6FD530]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF80C6FD428]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1259
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
       nop       dword ptr [rax+rax]
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
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
       jmp       qword ptr [7FF80C54F840]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 240
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF80C6B6898]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF80C6B6898]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
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
       call      qword ptr [7FF80BEF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
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
       call      qword ptr [7FF80BEF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF80C557168]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF80C6B6898]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FF80C6B6898]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF80C557168]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
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
       call      qword ptr [7FF80C11C240]
       int       3
M00_L33:
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
       call      qword ptr [7FF80C7853B0]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FF86BBB2A70
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+60]
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
       call      qword ptr [7FF80C6B68C8]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
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
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80C6B68C8]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B68F8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1259
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
       nop       dword ptr [rax+rax]
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
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
       jmp       qword ptr [7FF80C557B10]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 240
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF80C6ECB28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF80C6ECB28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
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
       call      qword ptr [7FF80BF357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
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
       call      qword ptr [7FF80BF357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF80C597198]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF80C6ECB28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FF80C6ECB28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF80C597198]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
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
       call      qword ptr [7FF80C15C240]
       int       3
M00_L33:
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
       call      qword ptr [7FF80C7D6058]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FF86BBB2A70
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+60]
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
       call      qword ptr [7FF80C6ECB40]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
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
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80C6ECB40]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED950]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1259
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L02
       cmp       rdx,40
       jbe       short M02_L00
       cmp       rdx,400
       jbe       short M02_L07
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF80C597B40]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L04
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       short M02_L03
M02_L02:
       test      dl,18
       jne       short M02_L05
       test      dl,4
       je        short M02_L06
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L05:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L07:
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
; Total bytes of code 227
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF80C604C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF80C604C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
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
       call      qword ptr [7FF80BF357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
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
       call      qword ptr [7FF80BF357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF80C5971B0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF80C604C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FF80C604C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF80C5971B0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
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
       call      qword ptr [7FF80C15C240]
       int       3
M00_L33:
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
       call      qword ptr [7FF80C876850]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FF86BBB2A70
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+60]
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
       call      qword ptr [7FF80C604C90]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L50
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-34],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
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
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80C604C90]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF80C605D10]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1259
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
       nop       dword ptr [rax+rax]
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
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
       jmp       qword ptr [7FF80C59FEA0]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 240
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5668]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C2F9DA0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5650]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+48]
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
       call      qword ptr [7FF80C6E5698]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
       call      qword ptr [7FF80C6E56F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E56C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C309DA0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+48]
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
       call      qword ptr [7FF80C705788]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
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
       call      qword ptr [7FF80C7057E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7057B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5770]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C309DA0]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5758]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+48]
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
       call      qword ptr [7FF80C6F5800]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F57D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5770]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C309DA0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5758]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,7FF80C8092B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF80C6F57A0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       mov       rcx,7FF80C8092BC
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 84
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
       call      qword ptr [7FF80C6F5800]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F57D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1D285000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0D110BCD2
       mov       r11d,0E69FADDA
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED3F8]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C6ECA20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE51560
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C6E57D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C277CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE51558
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6ED500]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6ED500]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF80C6ED3F8]
       int       3
; Total bytes of code 1037
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF80BF48210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF86BBB2F90
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L01
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C6E7180]
       int       3
M02_L01:
       call      qword ptr [7FF80C6EF1F8]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,2F309C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E87C3C18
       mov       r11d,0A465B6C6
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6E7468]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C6E67D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE71388
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C5ED9F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C297CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE71380
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6E6808]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6E6808]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF80C6E7468]
       int       3
; Total bytes of code 1037
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C6EE6D0]
       int       3
M02_L01:
       call      qword ptr [7FF80C6EFF30]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2CBBEC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,8BA1CB71
       mov       r11d,0B9EDE66F
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C5FDAA0]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C6FE3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE61658
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C6F79A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C287CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE61650
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5FEA00]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5FEA00]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF80C5FDAA0]
       int       3
; Total bytes of code 1037
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C5F4030]
       int       3
M02_L01:
       call      qword ptr [7FF80C7C4078]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,1959D000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0D578FFED
       mov       r11d,871B45D6
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C5D5C50]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C5D4C48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE51620
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C71D4A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C277CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE51618
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5D4C60]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5D4C60]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF80C5D5C50]
       int       3
; Total bytes of code 1037
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C56F858]
       int       3
M02_L01:
       call      qword ptr [7FF80C71F990]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,23CF7400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,46B331F8
       mov       r11d,618717DD
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6F74E0]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C6F67A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE815B0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C5FD9E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C2A7CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE815A8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6F67D8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6F67D8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF80C6F74E0]
       int       3
; Total bytes of code 1030
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C6FE670]
       int       3
M02_L01:
       call      qword ptr [7FF80C6FFE88]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2879D000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,632EE9E1
       mov       r11d,9C9EF839
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B67F0]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C6B67A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE41388
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C5BDAB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C267CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE41380
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6B67D8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C6B67D8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF80C6B67F0]
       int       3
; Total bytes of code 1030
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C6BE790]
       int       3
M02_L01:
       call      qword ptr [7FF80C6BFF90]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1AEF0800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,6CCE7766
       mov       r11d,82929CDF
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C5DD488]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C5DF408]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE51680
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C6FCB28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C277CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE51678
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5DD890]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5DD890]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF80C5DD488]
       int       3
; Total bytes of code 1030
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C5DC8A0]
       int       3
M02_L01:
       call      qword ptr [7FF80C6FF180]
       int       3
; Total bytes of code 45
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-40],r8
       mov       rdx,[rcx+48]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,28D2A000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,5C3BCBDB
       mov       r11d,0B70712E4
       cmp       eax,8
       jb        near ptr M00_L20
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L21
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M00_L03:
       mov       [rbp-2C],eax
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-2C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF86BBB2B50
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       ecx,[rbp-2C]
       cmp       ecx,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF80C5E5608]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80C5E6A90]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF80BE51678
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C73DE60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C277CA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF80BE51670
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5E57A0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF86BBB2A70
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80C5E57A0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF80C5E5608]
       int       3
; Total bytes of code 1030
```
```assembly
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
       call      qword ptr [7FF86B974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF86B974038]; CORINFO_HELP_JIT_PINVOKE_END
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF80C54FFD8]
       int       3
M02_L01:
       call      qword ptr [7FF80C844318]
       int       3
; Total bytes of code 45
```

