## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.CreateTempFileThenMove()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+198]
       mov       rdx,24792380BA0
       mov       r8,24792380C00
       xor       r9d,r9d
       call      qword ptr [7FF8F432E058]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF8F436D160
       call      qword ptr [7FF8F432E028]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,24792380C88
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF8F436D1F8
       xor       r8d,r8d
       mov       r9,24792370008
       call      qword ptr [7FF8F42AEB38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,24792380CB0
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,24792370008
       call      qword ptr [7FF8F41356F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,24792380CF0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FF8F431AAD8
       xor       r8d,r8d
       mov       r9,24792370008
       call      qword ptr [7FF8F42AEB38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F408F318]; System.IO.DirectoryInfo.Create()
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8F4553140
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8F432DF38]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF8F432DF50]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FF8F432E088]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F432E0A0]; System.IO.FileSystemInfo.Refresh()
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
       mov       rdx,7FF8F4372508
       call      qword ptr [7FF8F3F17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8F432E4D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F432E490]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.ReadAllTextSafe()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+198]
       mov       rdx,1AEA9D40BA0
       mov       r8,1AEA9D30008
       xor       r9d,r9d
       call      qword ptr [7FF8F434DFC8]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF8F43988E0
       call      qword ptr [7FF8F434DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,1AEA9D40DC0
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF8F4398978
       xor       r8d,r8d
       mov       r9,1AEA9D30008
       call      qword ptr [7FF8F42BE880]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,1AEA9D40DE8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1AEA9D30008
       call      qword ptr [7FF8F4144A50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8F455A5B0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8F434DCF8]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF8F434E040]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FF8F434E058]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
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
       mov       rdx,7FF8F43A02C0
       call      qword ptr [7FF8F3F47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8F434E4C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F434E478]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DirectoryInfoExtensionsBenchmark.WriteAllTextAtomic()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+198]
       mov       rdx,2E3342B0BA0
       mov       r8,2E3342B0C00
       xor       r9d,r9d
       call      qword ptr [7FF8F432E688]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF8F438CC10
       call      qword ptr [7FF8F432E658]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,2E3342B0C88
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF8F438CCA8
       xor       r8d,r8d
       mov       r9,2E3342A0008
       call      qword ptr [7FF8F428F108]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,2E3342B0BD8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2E3342A0008
       call      qword ptr [7FF8F4114A50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,2E3342B0CB0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FF8F43397B8
       xor       r8d,r8d
       mov       r9,2E3342A0008
       call      qword ptr [7FF8F428F108]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FF8F432E6B8]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
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
       mov       rdx,7FF8F4374B90
       call      qword ptr [7FF8F3F17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8F432EB20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F432EAD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

