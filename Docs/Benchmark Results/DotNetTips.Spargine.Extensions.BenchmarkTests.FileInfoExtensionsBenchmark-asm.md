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
       mov       rdx,27906730008
       xor       r8d,r8d
       call      qword ptr [7FFC1355E9D0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFC135BEFA0
       call      qword ptr [7FFC1355E9A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
; 			return file.Exists is false ? fallback : File.ReadAllText(file.FullName, encoding ?? Encoding.UTF8);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,27906740EC8
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC135BF038
       xor       r8d,r8d
       mov       r9,27906730008
       call      qword ptr [7FFC132AE670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp+10]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FFC13765760
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-38]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L01
       mov       rax,[rbp+10]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,7FFC13765868
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-40]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rax,[rbp+20]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FFC13765970
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC1344FA80]; System.Text.Encoding.get_UTF8()
       mov       [rbp-20],rax
M01_L00:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC1355EA18]; System.IO.File.ReadAllText(System.String, System.Text.Encoding)
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,7FFC13765974
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-10],rax
M01_L02:
       mov       rax,[rbp-10]
       mov       [rbp-8],rax
M01_L03:
       mov       rcx,7FFC13765980
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       add       rsp,70
       pop       rbp
       ret
       sub       rsp,28
       mov       [rbp-30],rcx
       mov       rcx,7FFC13765978
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L03]
       add       rsp,28
       ret
       sub       rsp,28
       mov       [rbp-28],rcx
       mov       rcx,7FFC1376597C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L03]
       add       rsp,28
       ret
; Total bytes of code 387
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
       mov       rdx,7FFC135A4800
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC1355EE20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1355EDD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,227A1620008
       xor       r8d,r8d
       call      qword ptr [7FFC135269A0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFC13557E30
       call      qword ptr [7FFC13526970]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
; 			return file.Exists is false ? fallback : File.ReadAllText(file.FullName, encoding ?? Encoding.UTF8);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,227A1630CA0
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC13557EC8
       xor       r8d,r8d
       mov       r9,227A1620008
       call      qword ptr [7FFC1329E6A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp+10]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FFC1370E8D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-38]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L01
       mov       rax,[rbp+10]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,7FFC1370E9E0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-40]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rax,[rbp+20]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FFC1370EAE8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC1343FAB0]; System.Text.Encoding.get_UTF8()
       mov       [rbp-20],rax
M01_L00:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFC135269E8]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,7FFC1370EAEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-10],rax
M01_L02:
       mov       rax,[rbp-10]
       mov       [rbp-8],rax
M01_L03:
       mov       rcx,7FFC1370EAF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       add       rsp,70
       pop       rbp
       ret
       sub       rsp,28
       mov       [rbp-30],rcx
       mov       rcx,7FFC1370EAF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L03]
       add       rsp,28
       ret
       sub       rsp,28
       mov       [rbp-28],rcx
       mov       rcx,7FFC1370EAF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       [rbp-8],rax
       lea       rax,[M01_L03]
       add       rsp,28
       ret
; Total bytes of code 387
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
       mov       rdx,7FFC1353EB80
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC13526A60]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13526A18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2180E480CF0
       xor       r8d,r8d
       call      qword ptr [7FFC1352DE60]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1352DE78]; System.IO.FileInfo.get_Length()
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC1352DE48]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
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
; 		var directory = file.Directory ?? throw new InvalidOperationException();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tempPath = Path.Combine(directory.FullName, $".{file.Name}.{Guid.NewGuid():N}.tmp");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		File.WriteAllText(tempPath, content, encoding ?? Encoding.UTF8);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,100
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0D0],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,2180E480D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC135888B0
       xor       r8d,r8d
       mov       r9,2180E470008
       call      qword ptr [7FFC1329E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,2180E480D78
       mov       [rsp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FFC13300B68
       xor       r8d,r8d
       mov       r9,2180E470008
       call      qword ptr [7FFC1329E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1352DEC0]; System.IO.FileInfo.get_Directory()
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-38],0
       jne       short M01_L01
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       call      qword ptr [7FFC1352DED8]
       mov       rcx,[rbp-78]
       call      CORINFO_HELP_THROW
       int       3
M01_L01:
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1329E880]; System.IO.DirectoryInfo.Create()
       mov       rax,[rbp-40]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,7FFC136DC520
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-80]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-48],rax
       lea       rcx,[rbp-30]
       mov       edx,6
       mov       r8d,2
       call      qword ptr [7FFC13134E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       rdx,2180E470658
       call      qword ptr [7FFC13134E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rax,[rbp+10]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       rdx,7FFC136DC628
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-88]
       mov       rax,[rbp-88]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       lea       rcx,[rbp-30]
       call      qword ptr [7FFC1313E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-30]
       mov       rdx,2180E470658
       call      qword ptr [7FFC13134E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC1329E820]; System.Guid.NewGuid()
       vmovups   xmm0,[rbp-58]
       vmovups   [rbp-0B8],xmm0
       lea       rdx,[rbp-0B8]
       lea       rcx,[rbp-30]
       mov       r8,2180E47B300
       call      qword ptr [7FFC1352DEA8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Guid, System.Private.CoreLib]](System.Guid, System.String)
       lea       rcx,[rbp-30]
       mov       rdx,2180E480DA0
       call      qword ptr [7FFC13134E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-30]
       call      qword ptr [7FFC13134EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-0C0],rax
       mov       rdx,[rbp-0C0]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC1329E898]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-60],rax
       mov       rax,[rbp+18]
       mov       [rbp-68],rax
       mov       rax,[rbp+20]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp+20],0
       jne       short M01_L02
       mov       rcx,7FFC136DC730
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC1343FA80]; System.Text.Encoding.get_UTF8()
       mov       [rbp-70],rax
M01_L02:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       call      qword ptr [7FFC1352DF08]; System.IO.File.WriteAllText(System.String, System.String, System.Text.Encoding)
       nop
       mov       rax,[rbp+10]
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       rdx,7FFC136DC738
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L03
       mov       rax,[rbp+10]
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rdx,7FFC136DC840
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-98]
       mov       rax,[rbp-98]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0C8],rax
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp-8]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFC1352DF20]
       jmp       short M01_L04
M01_L03:
       mov       rcx,7FFC136DC948
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       rdx,7FFC136DC950
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-0A0]
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0D0],rax
       mov       rdx,[rbp-0D0]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC1352DF38]; System.IO.File.Move(System.String, System.String)
M01_L04:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1352DF50]; System.IO.FileSystemInfo.Refresh()
       nop
       call      M01_L05
       nop
       mov       rcx,7FFC136DCA60
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,100
       pop       rbp
       ret
M01_L05:
       sub       rsp,28
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC1313F138]; System.IO.File.Exists(System.String)
       test      eax,eax
       je        short M01_L06
       mov       rcx,7FFC136DCA58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC1352DF68]
M01_L06:
       mov       rcx,7FFC136DCA5C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 989
```
```assembly
; System.IO.FileInfo.get_Length()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFC1352E280]; System.IO.FileSystemInfo.EnsureDataInitialized()
       test      byte ptr [rbx+30],10
       jne       short M02_L00
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC1352E298]; System.IO.FileSystemInfo.get_LengthCore()
M02_L00:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137168E0]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FFC135BC9A8]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC137168F8]
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
       call      qword ptr [7FFC1352E2E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1352E2B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int64, System.Private.CoreLib]](Int64 ByRef)
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
       mov       rdx,277841F0CF0
       xor       r8d,r8d
       call      qword ptr [7FFC1350DE78]; DotNetTips.Spargine.Extensions.FileInfoExtensions.WriteAllTextAtomic(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rax,[rbp+10]
       mov       rcx,[rax+1B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1350DE90]; System.IO.FileInfo.get_Length()
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC1350DE60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int64, System.Private.CoreLib]](Int64)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Extensions.FileInfoExtensions.WriteAllTextAtomic(System.IO.FileInfo, System.String, System.Text.Encoding)
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		content = content.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		file.CreateTempFileThenMove(content, encoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,277841F0D58
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFC13568A18
       xor       r8d,r8d
       mov       r9,277841E0008
       call      qword ptr [7FFC1327E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,277841F0D78
       mov       [rsp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FFC132E0B68
       xor       r8d,r8d
       mov       r9,277841E0008
       call      qword ptr [7FFC1327E670]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFC1350DEC0]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 151
```
```assembly
; System.IO.FileInfo.get_Length()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFC1350E2B0]; System.IO.FileSystemInfo.EnsureDataInitialized()
       test      byte ptr [rbx+30],10
       jne       short M02_L00
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC1350E2C8]; System.IO.FileSystemInfo.get_LengthCore()
M02_L00:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136F6DD8]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FFC136F6940]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC136F6DF0]
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
       call      qword ptr [7FFC1350E310]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1350E2E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int64, System.Private.CoreLib]](Int64 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 61
```

