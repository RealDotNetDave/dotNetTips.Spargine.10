## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       call      qword ptr [7FFB2BD5DE60]; DotNetTips.Spargine.IO.TempFileManager.CreateFile()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB2BD9EDA0
       call      qword ptr [7FFB2BD5DE30]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFile()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
; 		var file = GenerateRandomFile();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      qword ptr [7FFB2BD5DE78]; DotNetTips.Spargine.IO.TempFileManager.GenerateRandomFile()
       mov       [rbp-8],rax
; 		this._files.Add(file);
; 		^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       rdx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BD5DE90]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		return file;
; 		^^^^^^^^^^^^
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
       mov       rdx,7FFB2BDCCA68
       call      qword ptr [7FFB2B947B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BDE5938]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BDE58F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       call      qword ptr [7FFB2BD45C20]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB2BD60EE0
       call      qword ptr [7FFB2BD45BF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		_ = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-0C],eax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rax,19D7D2D0008
       mov       [rsp+20],rax
       mov       rax,19D7D2D3620
       mov       [rsp+28],rax
       lea       r9,[rbp-8]
       mov       ecx,[rbp-0C]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFB2BCC7C18]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
; 		return count <= 2
; 		^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(count)
; 			                                   
; 			: this.CreateFilesParallel(count);
; 			                                  
       mov       rax,[rbp+18]
       cmp       dword ptr [rax],2
       jle       short M01_L00
       mov       rax,[rbp+18]
       mov       edx,[rax]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD45C38]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesParallel(Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
M01_L00:
       mov       rax,[rbp+18]
       mov       edx,[rax]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD45C50]
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 148
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
       mov       rdx,7FFB2BDB9240
       call      qword ptr [7FFB2B947B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD4F408]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BD4F3C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       call      qword ptr [7FFB2BD55D10]; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB2BD715B0
       call      qword ptr [7FFB2BD55CE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.CreateFiles(Int32 ByRef)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		_ = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       eax,[rax]
       mov       [rbp-0C],eax
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rax,1F79B4C0008
       mov       [rsp+20],rax
       mov       rax,1F79B4C3620
       mov       [rsp+28],rax
       lea       r9,[rbp-8]
       mov       ecx,[rbp-0C]
       mov       edx,1
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFB2BCD7C18]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, Int32, System.Nullable`1<Int32> ByRef, System.String, System.String)
; 		return count <= 2
; 		^^^^^^^^^^^^^^^^^
; 			? this.CreateFilesSequential(count)
; 			                                   
; 			: this.CreateFilesParallel(count);
; 			                                  
       mov       rax,[rbp+18]
       cmp       dword ptr [rax],2
       jle       short M01_L00
       mov       rax,[rbp+18]
       mov       edx,[rax]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD55D28]
       nop
       add       rsp,40
       pop       rbp
       ret
M01_L00:
       mov       rax,[rbp+18]
       mov       edx,[rax]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD55D40]; DotNetTips.Spargine.IO.TempFileManager.CreateFilesSequential(Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 148
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
       mov       rdx,7FFB2BDA3670
       call      qword ptr [7FFB2B957B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BD5D860]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BD5D818]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

