## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerCreateFilesBenchmark.CreateFile()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB505E5F8]; DotNetTips.Spargine.IO.TempFileManager.CreateFile()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB50BE9D0
       call      qword ptr [7FFBB505E5C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFile()
; 		var file = GenerateRandomFile();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._files.TryAdd(file, default);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return file;
; 		^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       call      qword ptr [7FFBB505E610]; DotNetTips.Spargine.IO.TempFileManager.GenerateRandomFile()
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       rdx,[rbp-8]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB505E628]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].TryAdd(System.__Canon, Byte)
       mov       rax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 63
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
       mov       rdx,7FFBB50A5A88
       call      qword ptr [7FFBB4C47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB505EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB505EA60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerCreateFilesBenchmark.CreateFilesParallel()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
       mov       [rbp-18],rax
       mov       dword ptr [rbp-10],100
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB507DBF0]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB50D9630
       call      qword ptr [7FFBB507DBC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		var fileCount = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-14],eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,26977710008
       mov       [rsp+20],rax
       mov       rax,26977713620
       mov       [rsp+28],rax
       lea       r9,[rbp-10]
       mov       ecx,[rbp-14]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFBB4FFF4E0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
       mov       [rbp-4],eax
; 		return fileCount < App.MaxDegreeOfParallelism()
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(fileCount)
; 			                                       
; 			: this.CreateFilesParallel(fileCount);
; 			                                      
       call      qword ptr [7FFBB507DC08]; DotNetTips.Spargine.Core.App.MaxDegreeOfParallelism()
       cmp       eax,[rbp-4]
       jg        short M01_L00
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB507DC20]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesParallel(Int32)
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB507DC38]
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 150
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
       mov       rdx,7FFBB518E688
       call      qword ptr [7FFBB4C87B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB5157A98]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5157A50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerCreateFilesBenchmark.CreateFilesSequential()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
       mov       [rbp-18],rax
       mov       dword ptr [rbp-10],2
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB508E550]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB50EEB98
       call      qword ptr [7FFBB508E520]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
; 		var fileCount = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return fileCount < App.MaxDegreeOfParallelism()
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(fileCount)
; 			                                       
; 			: this.CreateFilesParallel(fileCount);
; 			                                      
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-14],eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,25CB1D90008
       mov       [rsp+20],rax
       mov       rax,25CB1D93620
       mov       [rsp+28],rax
       lea       r9,[rbp-10]
       mov       ecx,[rbp-14]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFBB4FEFDB0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
       mov       [rbp-4],eax
       call      qword ptr [7FFBB508E568]; DotNetTips.Spargine.Core.App.MaxDegreeOfParallelism()
       cmp       eax,[rbp-4]
       jg        short M01_L00
       mov       rcx,7FFBB5335BF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB508E580]
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFBB5335BFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB508E598]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesSequential(Int32)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 180
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
       mov       rdx,7FFBB5195D38
       call      qword ptr [7FFBB4C77B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB5156A78]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5156A30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

