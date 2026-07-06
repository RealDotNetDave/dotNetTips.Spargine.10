## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerCreateFilesBenchmark.CreateFile()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE64DF08]; DotNetTips.Spargine.IO.TempFileManager.CreateFile()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCDE69D4A0
       call      qword ptr [7FFCDE64DED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
; 		this._files.Add(file);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		return file;
; 		^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       call      qword ptr [7FFCDE64DF20]; DotNetTips.Spargine.IO.TempFileManager.GenerateRandomFile()
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE64DF38]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
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
       mov       rdx,7FFCDE686A40
       call      qword ptr [7FFCDE01F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCDE64E538]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE64E4F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+138]
       mov       [rbp-18],rax
       mov       dword ptr [rbp-10],100
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE62DAD0]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCDE6853D0
       call      qword ptr [7FFCDE62DAA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		var fileCount = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-14],eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,2169D4B0008
       mov       [rsp+20],rax
       mov       rax,2169D4B4320
       mov       [rsp+28],rax
       lea       r9,[rbp-10]
       mov       ecx,[rbp-14]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFCDE58F960]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
       mov       [rbp-4],eax
; 		var parallelThreshold = Environment.ProcessorCount * 2;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      qword ptr [7FFCDE28D968]; System.Environment.get_ProcessorCount()
       imul      eax,2
       jo        short M01_L01
       mov       [rbp-8],eax
; 		return fileCount < parallelThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(fileCount)
; 			                                       
; 			: this.CreateFilesParallel(fileCount);
; 			                                      
       mov       eax,[rbp-4]
       cmp       eax,[rbp-8]
       jl        short M01_L00
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCDE62DAE8]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesParallel(Int32)
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCDE62DB00]
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 167
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
       mov       rdx,7FFCDE67DC50
       call      qword ptr [7FFCDDFFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCDE62FDE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE62FD98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+138]
       mov       [rbp-18],rax
       mov       dword ptr [rbp-10],2
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE62DAA0]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCDE6853D0
       call      qword ptr [7FFCDE62DA70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
; 		var parallelThreshold = Environment.ProcessorCount * 2;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return fileCount < parallelThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(fileCount)
; 			                                       
; 			: this.CreateFilesParallel(fileCount);
; 			                                      
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-14],eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,22EB7270008
       mov       [rsp+20],rax
       mov       rax,22EB7274320
       mov       [rsp+28],rax
       lea       r9,[rbp-10]
       mov       ecx,[rbp-14]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFCDE58F960]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
       mov       [rbp-4],eax
       call      qword ptr [7FFCDE28D968]; System.Environment.get_ProcessorCount()
       imul      eax,2
       jo        short M01_L01
       mov       [rbp-8],eax
       mov       eax,[rbp-4]
       cmp       eax,[rbp-8]
       jl        short M01_L00
       mov       rcx,7FFCDE82A6C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCDE62DAB8]
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFCDE82A6CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCDE62DAD0]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesSequential(Int32)
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 197
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
       mov       rdx,7FFCDE674E88
       call      qword ptr [7FFCDDFFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCDE62E148]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE62E100]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

