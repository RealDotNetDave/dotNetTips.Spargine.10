## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorCopyFilesBenchmark.CopyFiles()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B0]
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+1B8]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FFBB507F168]; DotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo, Boolean ByRef, System.Threading.CancellationToken)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB507F150]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo, Boolean ByRef, System.Threading.CancellationToken)
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
; 		destination = destination.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,27A43F51180
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFBB50D7E70
       xor       r8d,r8d
       mov       r9,27A43F40008
       call      qword ptr [7FFBB4DBE6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		var list = PrepareList(files);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp+18]
       mov       rcx,7FFBB50D7F88
       call      qword ptr [7FFBB507F1C8]; DotNetTips.Spargine.IO.FileProcessor.PrepareList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
; 		if (list is null)
; 		^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-40],0
       jne       short M01_L00
       mov       rcx,7FFBB50D82A8
       call      CORINFO_HELP_COUNTPROFILE32
; 			return 0;
; 			^^^^^^^^^
       xor       eax,eax
       add       rsp,0C0
       pop       rbp
       ret
; 		_ = destination.CheckExists(createDirectory: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       dword ptr [rbp-68],1
       xor       eax,eax
       mov       [rbp-70],eax
       lea       rdx,[rbp-68]
       lea       r8,[rbp-70]
       mov       rcx,[rbp+20]
       mov       r9,27A43F40008
       call      qword ptr [7FFBB507F1F8]; DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo, Boolean ByRef, Boolean ByRef, System.String)
; 		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+20]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,7FFBB50D82B0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-80]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      qword ptr [7FFBB507F210]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rbp-48],rax
; 		var successCount = 0;
; 		^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-4C],eax
; 		var listCount = list.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4B23548]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-50],eax
; 		var canBeCanceled = cancellationToken.CanBeCanceled;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp+30]
       call      qword ptr [7FFBB507F228]; System.Threading.CancellationToken.get_CanBeCanceled()
       mov       [rbp-54],eax
; 		var psw = this.CreateStopwatch(nameof(this.CopyFiles));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,27A43F511B0
       call      qword ptr [7FFBB507F240]; DotNetTips.Spargine.IO.FileProcessor.CreateStopwatch(System.String)
       mov       [rbp-60],rax
; 		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-74],eax
       jmp       near ptr M01_L03
; 			if (canBeCanceled)
; 			^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       dword ptr [rbp-54],0
       je        short M01_L02
       mov       rcx,7FFBB50D83B8
       call      CORINFO_HELP_COUNTPROFILE32
; 				cancellationToken.ThrowIfCancellationRequested();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp+30]
       call      qword ptr [7FFBB507F258]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
M01_L02:
       mov       rcx,7FFBB50D83BC
       call      CORINFO_HELP_COUNTPROFILE32
; 			successCount += this.CopyFileItem(list[fileIndex], destinationPath, overwrite, psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       mov       edx,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4B23578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-90],rax
       mov       rax,[rbp-60]
       mov       [rsp+20],rax
       mov       rdx,[rbp-90]
       mov       rax,[rbp+28]
       movzx     r9d,byte ptr [rax]
       mov       rcx,[rbp+10]
       mov       r8,[rbp-48]
       call      qword ptr [7FFBB507F270]; DotNetTips.Spargine.IO.FileProcessor.CopyFileItem(System.IO.FileInfo, System.String, Boolean, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
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
       mov       rcx,7FFBB50D83C0
       call      CORINFO_HELP_COUNTPROFILE32
; 		return successCount;
; 		^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFBB507F960]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB507F930]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorCopyFilesBenchmark.CopyFilesWithOriginalPath()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1B0]
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+1B8]
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
       mov       [rbp-28],rax
       xor       eax,eax
       mov       [rbp-18],rax
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-20]
       mov       r8,[rbp-28]
       mov       r9,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB505F7C8]; DotNetTips.Spargine.IO.FileProcessor.CopyFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef, System.IO.DirectoryInfo, System.Threading.CancellationToken)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFBB505F7B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 127
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.CopyFilesWithOriginalPath(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef, System.IO.DirectoryInfo, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       dword ptr [rbp-98],3E8
; 		destination = destination.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,2CFAC5A1180
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFBB50CBB80
       xor       r8d,r8d
       mov       r9,2CFAC590008
       call      qword ptr [7FFBB4DAF240]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		var list = PrepareList(files);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rdx,[rax]
       mov       rcx,7FFBB50CBC98
       call      qword ptr [7FFBB505F828]; DotNetTips.Spargine.IO.FileProcessor.PrepareList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
; 		if (list is null)
; 		^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-40],0
       jne       short M01_L00
       mov       rcx,7FFBB50CBFB8
       call      CORINFO_HELP_COUNTPROFILE32
; 			return 0;
; 			^^^^^^^^^
       xor       eax,eax
       add       rsp,0D0
       pop       rbp
       ret
; 		_ = destination.CheckExists(createDirectory: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       dword ptr [rbp-70],1
       xor       eax,eax
       mov       [rbp-78],eax
       lea       rdx,[rbp-70]
       lea       r8,[rbp-78]
       mov       rcx,[rbp+20]
       mov       r9,2CFAC590008
       call      qword ptr [7FFBB505F858]; DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo, Boolean ByRef, Boolean ByRef, System.String)
; 		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+20]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       rdx,7FFBB50CBFC0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      qword ptr [7FFBB505F870]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rbp-48],rax
; 		var successCount = 0;
; 		^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-4C],eax
; 		var psw = this.CreateStopwatch(nameof(this.CopyFilesWithOriginalPath));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,2CFAC5A11B0
       call      qword ptr [7FFBB505F888]; DotNetTips.Spargine.IO.FileProcessor.CreateStopwatch(System.String)
       mov       [rbp-58],rax
; 		var listCount = list.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4B13548]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-5C],eax
; 		var canBeCanceled = cancellationToken.CanBeCanceled;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp+28]
       call      qword ptr [7FFBB505F8A0]; System.Threading.CancellationToken.get_CanBeCanceled()
       mov       [rbp-60],eax
; 		var createdDirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       call      qword ptr [7FFBB505F8B8]; System.StringComparer.get_OrdinalIgnoreCase()
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFBB4A2DBC0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,[rbp-88]
       mov       [rbp-68],rax
; 		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
; 		     ^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-7C],eax
       jmp       short M01_L03
; 			if (canBeCanceled)
; 			^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       dword ptr [rbp-60],0
       je        short M01_L02
       mov       rcx,7FFBB50CC0C8
       call      CORINFO_HELP_COUNTPROFILE32
; 				cancellationToken.ThrowIfCancellationRequested();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rbp+28]
       call      qword ptr [7FFBB505F8D0]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
M01_L02:
       mov       rcx,7FFBB50CC0CC
       call      CORINFO_HELP_COUNTPROFILE32
; 			successCount += this.CopyFileItemWithOriginalPath(list[fileIndex], destinationPath, createdDirs, psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       mov       edx,[rbp-7C]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4B13578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-0A8],rax
       mov       rax,[rbp-58]
       mov       [rsp+20],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp-48]
       mov       r9,[rbp-68]
       call      qword ptr [7FFBB505F8E8]; DotNetTips.Spargine.IO.FileProcessor.CopyFileItemWithOriginalPath(System.IO.FileInfo, System.String, System.Collections.Generic.HashSet`1<System.String>, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       eax,[rbp-4C]
       jo        short M01_L05
       mov       [rbp-4C],eax
       mov       eax,[rbp-7C]
       add       eax,1
       jo        short M01_L05
       mov       [rbp-7C],eax
M01_L03:
       mov       eax,[rbp-98]
       dec       eax
       mov       [rbp-98],eax
       cmp       dword ptr [rbp-98],0
       jg        short M01_L04
       lea       rcx,[rbp-98]
       mov       edx,98
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       eax,[rbp-7C]
       cmp       eax,[rbp-5C]
       jl        near ptr M01_L01
       mov       rcx,7FFBB50CC0D0
       call      CORINFO_HELP_COUNTPROFILE32
; 		return successCount;
; 		^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rbp-4C]
       add       rsp,0D0
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 635
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
       call      qword ptr [7FFBB50E4180]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB50E4150]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

