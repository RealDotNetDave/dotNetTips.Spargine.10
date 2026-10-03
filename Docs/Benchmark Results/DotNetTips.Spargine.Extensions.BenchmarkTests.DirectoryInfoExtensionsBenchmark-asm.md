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
       mov       rdx,29977C70C70
       mov       r8,29977C70CD0
       xor       r9d,r9d
       call      qword ptr [7FFC62E7E7F0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFC62EDD9E0
       call      qword ptr [7FFC62E7E7C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		directory = directory.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,29977C70D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC62EDDA78
       xor       r8d,r8d
       mov       r9,29977C60008
       call      qword ptr [7FFC62BCE670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
; 		destinationFileName = destinationFileName.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,29977C70D80
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,29977C60008
       call      qword ptr [7FFC62C74C18]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
; 		content = content.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,29977C70DC0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFC62C30B68
       xor       r8d,r8d
       mov       r9,29977C60008
       call      qword ptr [7FFC62BCE670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		directory.Create();
; 		^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62BCE838]; System.IO.DirectoryInfo.Create()
; 		var destinationPath = Path.Combine(directory.FullName, destinationFileName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC62E7E6D0]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC62E7E6E8]; System.IO.FileInfo..ctor(System.String)
; 		destinationFile.CreateTempFileThenMove(content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFC62E7E820]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		destinationFile.Refresh();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E7E838]; System.IO.FileSystemInfo.Refresh()
; 		return destinationFile;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 317
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
       mov       rdx,7FFC62EC4A28
       call      qword ptr [7FFC62A67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC62E7EC70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E7EC28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2B080140C70
       mov       r8,2B080130008
       xor       r9d,r9d
       call      qword ptr [7FFC62E5E220]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFC62EBC2D8
       call      qword ptr [7FFC62E5E1F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		directory = directory.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,2B080140E90
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC62EBC370
       xor       r8d,r8d
       mov       r9,2B080130008
       call      qword ptr [7FFC62BCE670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
; 		fileName = fileName.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,2B080140EB8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2B080130008
       call      qword ptr [7FFC62C74C18]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
; 		var file = new FileInfo(Path.Combine(directory.FullName, fileName));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC62E5DF50]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC62E5E298]; System.IO.FileInfo..ctor(System.String)
; 		return file.ReadAllTextSafe(fallback, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFC62E5E2B0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 238
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
       mov       rdx,7FFC62EC03B0
       call      qword ptr [7FFC62A67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC62E5E718]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E5E6D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,23598FF0C70
       mov       r8,23598FF0CD0
       xor       r9d,r9d
       call      qword ptr [7FFC62E5E2C8]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFC62EAB9B0
       call      qword ptr [7FFC62E5E298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
; 		return directory.CreateTempFileThenMove(fileName, content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       call      qword ptr [7FFC62E5E2E0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 55
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
       mov       rdx,7FFC62EB2648
       call      qword ptr [7FFC62A57B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC62E5E760]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E5E718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

