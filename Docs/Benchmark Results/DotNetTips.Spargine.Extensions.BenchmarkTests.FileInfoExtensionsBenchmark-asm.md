## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.FileInfoExtensionsBenchmark.ReadAllTextSafe()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       mov       rdx,254F7D00008
       xor       r8d,r8d
       call      qword ptr [7FF7E91FE9E8]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF7E925EFA0
       call      qword ptr [7FF7E91FE9B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding ??= Encoding.UTF8;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (file.Exists is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
; 			return File.ReadAllText(file.FullName, encoding);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (IOException)
; 		^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
; 		catch (UnauthorizedAccessException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,254F7D10EC8
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF7E925F038
       xor       r8d,r8d
       mov       r9,254F7D00008
       call      qword ptr [7FF7E8F4E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF7E93FCE10
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7E90EFA80]; System.Text.Encoding.get_UTF8()
       mov       [rbp+20],rax
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,7FF7E93FCE18
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       jne       short M01_L01
       mov       rcx,7FF7E93FCF20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       add       rsp,60
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,7FF7E93FCF28
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF7E91FEA30]; System.IO.File.ReadAllText(System.String, System.Text.Encoding)
       mov       [rbp-8],rax
M01_L02:
       mov       rcx,7FF7E93FD038
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       add       rsp,60
       pop       rbp
       ret
       sub       rsp,28
       mov       [rbp-18],rcx
       mov       rcx,7FF7E93FD030
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L02]
       add       rsp,28
       ret
       sub       rsp,28
       mov       [rbp-10],rcx
       mov       rcx,7FF7E93FD034
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L02]
       add       rsp,28
       ret
; Total bytes of code 371
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
       mov       rdx,7FF7E9244870
       call      qword ptr [7FF7E8DE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91FEE38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91FEDF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.FileInfoExtensionsBenchmark.ReadAllTextSafeMissingFile()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B8]
       mov       rdx,18032040008
       xor       r8d,r8d
       call      qword ptr [7FF7E91B6AA8]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF7E91E8878
       call      qword ptr [7FF7E91B6A78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding ??= Encoding.UTF8;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (file.Exists is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
; 			return File.ReadAllText(file.FullName, encoding);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (IOException)
; 		^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
; 		catch (UnauthorizedAccessException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return fallback;
; 			^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,18032050CF0
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF7E91E8910
       xor       r8d,r8d
       mov       r9,18032040008
       call      qword ptr [7FF7E8F2E6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF7E939F390
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7E90CFAB0]; System.Text.Encoding.get_UTF8()
       mov       [rbp+20],rax
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,7FF7E939F398
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       jne       short M01_L01
       mov       rcx,7FF7E939F4A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       add       rsp,60
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,7FF7E939F4A8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF7E91B6AF0]
       mov       [rbp-8],rax
M01_L02:
       mov       rcx,7FF7E939F5B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       add       rsp,60
       pop       rbp
       ret
       sub       rsp,28
       mov       [rbp-18],rcx
       mov       rcx,7FF7E939F5B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L02]
       add       rsp,28
       ret
       sub       rsp,28
       mov       [rbp-10],rcx
       mov       rcx,7FF7E939F5B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L02]
       add       rsp,28
       ret
; Total bytes of code 371
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
       mov       rdx,7FF7E91CEC68
       call      qword ptr [7FF7E8DC7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91B6B68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91B6B20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.FileInfoExtensionsBenchmark.CreateTempFileThenMove()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       mov       rdx,23C87AF0CF0
       xor       r8d,r8d
       call      qword ptr [7FF7E91E6B08]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91E6B20]; System.IO.FileInfo.get_Length()
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91E6AF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		content = content.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding ??= Encoding.UTF8;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var directory = file.Directory ?? throw new InvalidOperationException();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tempPath = Path.Combine(directory.FullName, $".{file.Name}.{Guid.NewGuid():N}.tmp");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		File.WriteAllText(tempPath, content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (file.Exists)
; 			^^^^^^^^^^^^^^^^
; 				File.Replace(tempPath, file.FullName, destinationBackupFileName: null, ignoreMetadataErrors: true);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				File.Move(tempPath, file.FullName);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			file.Refresh();
; 			^^^^^^^^^^^^^^^
; 			if (File.Exists(tempPath))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				File.Delete(tempPath);
; 				^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,23C87AF0D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF7E92188B0
       xor       r8d,r8d
       mov       r9,23C87AE0008
       call      qword ptr [7FF7E8F5E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,23C87AF0D78
       mov       [rsp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FF7E8FC0B68
       xor       r8d,r8d
       mov       r9,23C87AE0008
       call      qword ptr [7FF7E8F5E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF7E92EB920
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7E90FFA80]; System.Text.Encoding.get_UTF8()
       mov       [rbp+20],rax
M01_L00:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91E6B68]; System.IO.FileInfo.get_Directory()
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-38],0
       jne       short M01_L01
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FF7E91E6B80]
       mov       rcx,[rbp-60]
       call      CORINFO_HELP_THROW
       int       3
M01_L01:
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E8F5E880]; System.IO.DirectoryInfo.Create()
       mov       rax,[rbp-40]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       rdx,7FF7E92EB928
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-68]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-48],rax
       lea       rcx,[rbp-30]
       mov       edx,6
       mov       r8d,2
       call      qword ptr [7FF7E8DF4E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       rdx,23C87AE0658
       call      qword ptr [7FF7E8DF4E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rax,[rbp+10]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       rdx,7FF7E92EBA30
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-70]
       mov       rax,[rbp-70]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       [rbp-90],rax
       mov       rdx,[rbp-90]
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7E8DFE4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-30]
       mov       rdx,23C87AE0658
       call      qword ptr [7FF7E8DF4E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-58]
       call      qword ptr [7FF7E8F5E820]; System.Guid.NewGuid()
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-0A0],xmm0
       lea       rdx,[rbp-0A0]
       lea       rcx,[rbp-30]
       mov       r8,23C87AEB300
       call      qword ptr [7FF7E91E6B50]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Guid, System.Private.CoreLib]](System.Guid, System.String)
       lea       rcx,[rbp-30]
       mov       rdx,23C87AF0DA0
       call      qword ptr [7FF7E8DF4E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7E8DF4EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp-48]
       call      qword ptr [7FF7E8F5E898]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF7E91E6BB0]; System.IO.File.WriteAllText(System.String, System.String, System.Text.Encoding)
       nop
       mov       rax,[rbp+10]
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rdx,7FF7E92EBB38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L02
       mov       rax,[rbp+10]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,7FF7E92EBC40
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-80]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0B0],rax
       mov       rdx,[rbp-0B0]
       mov       rcx,[rbp-8]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FF7E91E6BC8]
       jmp       short M01_L03
M01_L02:
       mov       rcx,7FF7E92EBD48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       rdx,7FF7E92EBD50
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-88]
       mov       rax,[rbp-88]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0B8],rax
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FF7E91E6BE0]; System.IO.File.Move(System.String, System.String)
M01_L03:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91E6BF8]; System.IO.FileSystemInfo.Refresh()
       nop
       call      M01_L04
       nop
       mov       rcx,7FF7E92EBE60
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0E0
       pop       rbp
       ret
M01_L04:
       sub       rsp,28
       mov       rcx,[rbp-8]
       call      qword ptr [7FF7E8DFF138]; System.IO.File.Exists(System.String)
       test      eax,eax
       je        short M01_L05
       mov       rcx,7FF7E92EBE58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      qword ptr [7FF7E91E6C10]
M01_L05:
       mov       rcx,7FF7E92EBE5C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 933
```
```assembly
; System.IO.FileInfo.get_Length()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF7E91E6F28]; System.IO.FileSystemInfo.EnsureDataInitialized()
       test      byte ptr [rbx+30],10
       jne       short M02_L00
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7E91E6F40]; System.IO.FileSystemInfo.get_LengthCore()
M02_L00:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7E927C390]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FF7E9277D20]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF7E927C3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 101
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91E6F88]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91E6F58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int64, System.Private.CoreLib]](Int64 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 61
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.FileInfoExtensionsBenchmark.WriteAllTextAtomic()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       mov       rdx,251FB7E0CF0
       xor       r8d,r8d
       call      qword ptr [7FF7E91FE7A8]; DotNetTips.Spargine.Extensions.FileInfoExtensions.WriteAllTextAtomic(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91FE7C0]; System.IO.FileInfo.get_Length()
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91FE790]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.FileInfoExtensions.WriteAllTextAtomic(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		file.CreateTempFileThenMove(content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF7E91FE7D8]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.IO.FileInfo.get_Length()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF7E91FEBE0]; System.IO.FileSystemInfo.EnsureDataInitialized()
       test      byte ptr [rbx+30],10
       jne       short M02_L00
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7E91FEBF8]; System.IO.FileSystemInfo.get_LengthCore()
M02_L00:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7E93C6E08]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FF7E93C6970]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF7E93C6E20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 101
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7E91FEC40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E91FEC10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int64, System.Private.CoreLib]](Int64 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 61
```

