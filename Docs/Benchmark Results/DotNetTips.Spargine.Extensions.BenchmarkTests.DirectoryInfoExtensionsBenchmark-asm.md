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
       mov       rdx,281383D0C20
       mov       r8,281383D0C80
       xor       r9d,r9d
       call      qword ptr [7FFB0D1BE7C0]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB0D21D6A0
       call      qword ptr [7FFB0D1BE790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,281383D0D08
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFB0D21D738
       xor       r8d,r8d
       mov       r9,281383C0008
       call      qword ptr [7FFB0CF0E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,281383D0D30
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,281383C0008
       call      qword ptr [7FFB0CFB4C18]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,281383D0D70
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFB0CF70B68
       xor       r8d,r8d
       mov       r9,281383C0008
       call      qword ptr [7FFB0CF0E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CF0E838]; System.IO.DirectoryInfo.Create()
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFB0D3B97D0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB0D1BE6A0]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFB0D1BE6B8]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFB0D1BE7F0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D1BE808]; System.IO.FileSystemInfo.Refresh()
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
       mov       rdx,7FFB0D204948
       call      qword ptr [7FFB0CDA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D1BEC40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D1BEBF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,249054E0C70
       mov       r8,249054D0008
       xor       r9d,r9d
       call      qword ptr [7FFB0D1A6C40]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB0D1D8A28
       call      qword ptr [7FFB0D1A6C10]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,249054E0E90
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFB0D1D8AC0
       xor       r8d,r8d
       mov       r9,249054D0008
       call      qword ptr [7FFB0CF1E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,249054E0EB8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,249054D0008
       call      qword ptr [7FFB0CFC4C18]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFB0D3AE098
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB0D1A6970]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFB0D1A6CB8]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFB0D1A6CD0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
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
       mov       rdx,7FFB0D1BF310
       call      qword ptr [7FFB0CDB7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D1A7138]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D1A70F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,1AA725D0C70
       mov       r8,1AA725D0CD0
       xor       r9d,r9d
       call      qword ptr [7FFB0D1BE418]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.WriteAllTextAtomic(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFB0D219910
       call      qword ptr [7FFB0D1BE3E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       call      qword ptr [7FFB0D1BE430]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
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
       mov       rdx,7FFB0D2039E8
       call      qword ptr [7FFB0CDA7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D1BE8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D1BE868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

