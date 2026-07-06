## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorDeleteFilesBenchmark.DeleteFiles()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+138]
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+140]
       mov       [rbp-20],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       r8,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE66E820]; DotNetTips.Spargine.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.Threading.CancellationToken)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCDE66E808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.Threading.CancellationToken)
; 		var list = PrepareList(files);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (list is null)
; 		^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		var successCount = 0;
; 		^^^^^^^^^^^^^^^^^^^^^
; 		var psw = this.CreateStopwatch(nameof(this.DeleteFiles));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var listCount = list.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var canBeCanceled = cancellationToken.CanBeCanceled;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
; 		     ^^^^^^^^^^^^^^^^^
; 			if (canBeCanceled)
; 			^^^^^^^^^^^^^^^^^^
; 				cancellationToken.ThrowIfCancellationRequested();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			successCount += this.DeleteFileItem(list[fileIndex], psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return successCount;
; 		^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       dword ptr [rbp-68],3E8
       mov       rdx,[rbp+18]
       mov       rcx,7FFCDE6C5360
       call      qword ptr [7FFCDE66E8B0]; DotNetTips.Spargine.IO.FileProcessor.PrepareList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       jne       short M01_L00
       mov       rcx,7FFCDE6C53D8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,90
       pop       rbp
       ret
M01_L00:
       xor       eax,eax
       mov       [rbp-44],eax
       mov       rcx,[rbp+10]
       mov       rdx,29A0FAD0C20
       call      qword ptr [7FFCDE66E8E0]; DotNetTips.Spargine.IO.FileProcessor.CreateStopwatch(System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE123548]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-54],eax
       lea       rcx,[rbp+20]
       call      qword ptr [7FFCDE66E8F8]; System.Threading.CancellationToken.get_CanBeCanceled()
       mov       [rbp-58],eax
       xor       eax,eax
       mov       [rbp-5C],eax
       jmp       short M01_L03
M01_L01:
       cmp       dword ptr [rbp-58],0
       je        short M01_L02
       mov       rcx,7FFCDE6C53DC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+20]
       call      qword ptr [7FFCDE66E910]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
M01_L02:
       mov       rcx,7FFCDE6C53E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       mov       edx,[rbp-5C]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE123578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp+10]
       mov       r8,[rbp-50]
       call      qword ptr [7FFCDE66E928]; DotNetTips.Spargine.IO.FileProcessor.DeleteFileItem(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       eax,[rbp-44]
       jo        short M01_L05
       mov       [rbp-44],eax
       mov       eax,[rbp-5C]
       add       eax,1
       jo        short M01_L05
       mov       [rbp-5C],eax
M01_L03:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M01_L04
       lea       rcx,[rbp-68]
       mov       edx,52
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       eax,[rbp-5C]
       cmp       eax,[rbp-54]
       jl        near ptr M01_L01
       mov       rcx,7FFCDE6C53E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-44]
       add       rsp,90
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 351
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCDE66EEF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE66EEC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

