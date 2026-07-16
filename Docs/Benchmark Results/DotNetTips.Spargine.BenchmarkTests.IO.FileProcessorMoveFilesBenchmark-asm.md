## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorMoveFilesBenchmark.MoveFiles()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A0]
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+198]
       mov       [rbp-30],rax
       mov       dword ptr [rbp-10],1
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rsp+20],rax
       lea       r9,[rbp-10]
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E7F3F0]; DotNetTips.Spargine.IO.FileProcessor.MoveFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo, Boolean ByRef, System.Threading.CancellationToken)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9C1E7F3D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.MoveFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo, Boolean ByRef, System.Threading.CancellationToken)
; 		destination = destination.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var list = PrepareList(files);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (list is null)
; 		^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		_ = destination.CheckExists(createDirectory: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var successCount = 0;
; 		^^^^^^^^^^^^^^^^^^^^^
; 		var listCount = list.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var canBeCanceled = cancellationToken.CanBeCanceled;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var psw = this.CreateStopwatch(nameof(this.MoveFiles));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
; 		     ^^^^^^^^^^^^^^^^^
; 			if (canBeCanceled)
; 			^^^^^^^^^^^^^^^^^^
; 				cancellationToken.ThrowIfCancellationRequested();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			successCount += this.MoveFileItem(list[fileIndex], destinationPath, overwrite, psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return successCount;
; 		^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       dword ptr [rbp-88],3E8
       mov       rax,2610D5F10B0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FF9C1EDD2C8
       xor       r8d,r8d
       mov       r9,2610D5E0008
       call      qword ptr [7FF9C1DEF558]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FF9C1EDD3E0
       call      qword ptr [7FF9C1E7F450]; DotNetTips.Spargine.IO.FileProcessor.PrepareList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       jne       short M01_L00
       mov       rcx,7FF9C1EDD700
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,0C0
       pop       rbp
       ret
M01_L00:
       mov       dword ptr [rbp-68],1
       xor       eax,eax
       mov       [rbp-70],eax
       lea       rdx,[rbp-68]
       lea       r8,[rbp-70]
       mov       rcx,[rbp+20]
       mov       r9,2610D5E0008
       call      qword ptr [7FF9C1E7F480]; DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo, Boolean ByRef, Boolean ByRef, System.String)
       mov       rax,[rbp+20]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,7FF9C1EDD708
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-80]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      qword ptr [7FF9C1E7F498]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rbp-48],rax
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933548]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-50],eax
       lea       rcx,[rbp+30]
       call      qword ptr [7FF9C1E7F4B0]; System.Threading.CancellationToken.get_CanBeCanceled()
       mov       [rbp-54],eax
       mov       rcx,[rbp+10]
       mov       rdx,2610D5F10E0
       call      qword ptr [7FF9C1E7F4C8]; DotNetTips.Spargine.IO.FileProcessor.CreateStopwatch(System.String)
       mov       [rbp-60],rax
       xor       eax,eax
       mov       [rbp-74],eax
       jmp       near ptr M01_L03
M01_L01:
       cmp       dword ptr [rbp-54],0
       je        short M01_L02
       mov       rcx,7FF9C1EDD810
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+30]
       call      qword ptr [7FF9C1E7F4E0]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
M01_L02:
       mov       rcx,7FF9C1EDD814
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       mov       edx,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-90],rax
       mov       rax,[rbp-60]
       mov       [rsp+20],rax
       mov       rdx,[rbp-90]
       mov       rax,[rbp+28]
       movzx     r9d,byte ptr [rax]
       mov       rcx,[rbp+10]
       mov       r8,[rbp-48]
       call      qword ptr [7FF9C1E7F4F8]; DotNetTips.Spargine.IO.FileProcessor.MoveFileItem(System.IO.FileInfo, System.String, Boolean, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       eax,[rbp-4C]
       jo        short M01_L05
       mov       [rbp-4C],eax
       mov       eax,[rbp-74]
       add       eax,1
       jo        short M01_L05
       mov       [rbp-74],eax
M01_L03:
       mov       eax,[rbp-88]
       dec       eax
       mov       [rbp-88],eax
       cmp       dword ptr [rbp-88],0
       jg        short M01_L04
       lea       rcx,[rbp-88]
       mov       edx,8C
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       eax,[rbp-74]
       cmp       eax,[rbp-50]
       jl        near ptr M01_L01
       mov       rcx,7FF9C1EDD818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-4C]
       add       rsp,0C0
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 554
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
       call      qword ptr [7FF9C1EF44B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EF4480]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

