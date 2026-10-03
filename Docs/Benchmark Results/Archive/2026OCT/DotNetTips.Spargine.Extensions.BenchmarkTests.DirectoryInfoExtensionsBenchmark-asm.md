## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.CreateTempFileThenMove()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       mov       rdx,2B4CF080C70
       mov       r8,2B4CF080CD0
       xor       r9d,r9d
       call      qword ptr [7FFBB4C4E808]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB4CAD9E0
       call      qword ptr [7FFBB4C4E7D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
; 		directory = directory.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		destinationFileName = destinationFileName.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		content = content.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		directory.Create();
; 		^^^^^^^^^^^^^^^^^^^
; 		var destinationPath = Path.Combine(directory.FullName, destinationFileName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		destinationFile.CreateTempFileThenMove(content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		destinationFile.Refresh();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return destinationFile;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rax,2B4CF080D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFBB4CADA78
       xor       r8d,r8d
       mov       r9,2B4CF070008
       call      qword ptr [7FFBB499E6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,2B4CF080D80
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2B4CF070008
       call      qword ptr [7FFBB4A44C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,2B4CF080DC0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFBB4A00B68
       xor       r8d,r8d
       mov       r9,2B4CF070008
       call      qword ptr [7FFBB499E6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB499E868]; System.IO.DirectoryInfo.Create()
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFBB4E4F7C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFBB4C4E6E8]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFBB4C4E700]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFBB4C4E838]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C4E850]; System.IO.FileSystemInfo.Refresh()
       mov       rax,[rbp-8]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 338
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
       mov       rdx,7FFBB4C949C0
       call      qword ptr [7FFBB4837B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB4C4EC88]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C4EC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.ReadAllTextSafe()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       mov       rdx,2022D210C70
       mov       r8,2022D200008
       xor       r9d,r9d
       call      qword ptr [7FFBB4C5E8B0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB4CBE1D0
       call      qword ptr [7FFBB4C5E880]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
; 		directory = directory.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		fileName = fileName.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var file = new FileInfo(Path.Combine(directory.FullName, fileName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return file.ReadAllTextSafe(fallback, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rax,2022D210E90
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFBB4CBE268
       xor       r8d,r8d
       mov       r9,2022D200008
       call      qword ptr [7FFBB49AE6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,2022D210EB8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2022D200008
       call      qword ptr [7FFBB4A54C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFBB4E5DC40
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFBB4C5E5E0]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFBB4C5E928]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFBB4C5E940]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 259
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
       mov       rdx,7FFBB4CA46B0
       call      qword ptr [7FFBB4847B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB4C5EDA8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C5ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.WriteAllTextAtomic()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       mov       rdx,25BE2480C70
       mov       r8,25BE2480CD0
       xor       r9d,r9d
       call      qword ptr [7FFBB4C5E2B0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFBB4CAC998
       call      qword ptr [7FFBB4C5E280]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
; 		directory = directory.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		fileName = fileName.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		content = content.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return directory.CreateTempFileThenMove(fileName, content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rax,25BE2480D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFBB4CACA30
       xor       r8d,r8d
       mov       r9,25BE2470008
       call      qword ptr [7FFBB49BE6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,25BE2480CA8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,25BE2470008
       call      qword ptr [7FFBB4A64C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,25BE2480D80
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFBB4A20B68
       xor       r8d,r8d
       mov       r9,25BE2470008
       call      qword ptr [7FFBB49BE6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FFBB4C5E2E0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 206
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
       mov       rdx,7FFBB4CB2658
       call      qword ptr [7FFBB4857B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB4C5E748]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4C5E700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

