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
       mov       rdx,293F5330BA0
       mov       r8,293F5330C00
       xor       r9d,r9d
       call      qword ptr [7FFD9F2EEF58]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.CreateTempFileThenMove(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFD9F352C60
       call      qword ptr [7FFD9F2EEF28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,293F5330C88
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFD9F352CF8
       xor       r8d,r8d
       mov       r9,293F5320008
       call      qword ptr [7FFD9F26F9D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,293F5330CB0
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,293F5320008
       call      qword ptr [7FFD9F0F56F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,293F5330CF0
       mov       [rsp+20],rax
       mov       rdx,[rbp+20]
       mov       rcx,7FFD9F300600
       xor       r8d,r8d
       mov       r9,293F5320008
       call      qword ptr [7FFD9F26F9D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9F05F318]; System.IO.DirectoryInfo.Create()
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFD9F51BEA0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD9F2EEE38]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD9F2EEE50]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFD9F2EEF88]; DotNetTips.Spargine.Extensions.FileInfoExtensions.CreateTempFileThenMove(System.IO.FileInfo, System.String, System.Text.Encoding)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9F2EEFA0]; System.IO.FileSystemInfo.Refresh()
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
       mov       rdx,7FFD9F3383C8
       call      qword ptr [7FFD9EEE7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD9F2EF3D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9F2EF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,242F7910BA0
       mov       r8,242F7900008
       xor       r9d,r9d
       call      qword ptr [7FFD9F30E328]; DotNetTips.Spargine.Extensions.DirectoryInfoExtensions.ReadAllTextSafe(System.IO.DirectoryInfo, System.String, System.String, System.Text.Encoding)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFD9F35BD20
       call      qword ptr [7FFD9F30E2F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,242F7910DC0
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFD9F35BDB8
       xor       r8d,r8d
       mov       r9,242F7900008
       call      qword ptr [7FFD9F27EC40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,242F7910DE8
       mov       [rsp+20],rax
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,242F7900008
       call      qword ptr [7FFD9F104A50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFD9F51A5A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD9F30E058]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD9F30E3A0]; System.IO.FileInfo..ctor(System.String)
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       call      qword ptr [7FFD9F30E3B8]; DotNetTips.Spargine.Extensions.FileInfoExtensions.ReadAllTextSafe(System.IO.FileInfo, System.String, System.Text.Encoding)
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
       mov       rdx,7FFD9F362570
       call      qword ptr [7FFD9EF17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD9F30E820]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9F30E7D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L10
       mov       rcx,[rsi+8]
       xor       edx,edx
       call      qword ptr [7FFD9F27EFA0]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       byte ptr [rsi+2C],0
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M00_L11
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rcx,19CF7090BAC
       mov       [rbp-98],rcx
       mov       dword ptr [rbp-90],0F
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD9F27EF58]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L02
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       mov       r14,19CF7090BAC
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M00_L01
       cmp       ecx,2F
       je        short M00_L01
       mov       rcx,19CF70881EC
       mov       [rbp-98],rdi
       mov       [rbp-90],esi
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],1
       mov       [rbp-0B8],r14
       mov       dword ptr [rbp-0B0],0F
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-0A8]
       lea       r8,[rbp-0B8]
       call      qword ptr [7FFD9F2F6910]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
M00_L00:
       jmp       short M00_L03
M00_L01:
       mov       [rbp-98],rdi
       mov       [rbp-90],esi
       mov       [rbp-0A8],r14
       mov       dword ptr [rbp-0A0],0F
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FFD9F07DB48]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       jmp       short M00_L00
M00_L02:
       mov       r15,19CF7090BA0
M00_L03:
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15,r15
       je        near ptr M00_L12
       mov       dword ptr [rsi+28],0FFFFFFFF
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       call      qword ptr [7FFD9EF1F048]; System.IO.Path.GetFullPath(System.String)
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M00_L13
       lea       rcx,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       lea       rcx,[rbp-98]
       call      qword ptr [7FFD9EF1F060]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L13
       lea       rcx,[rbp-70]
       mov       rdx,rdi
       call      qword ptr [7FFD9F107FA8]; System.MemoryExtensions.AsSpan(System.String)
       lea       rcx,[rbp-70]
       call      qword ptr [7FFD9F2F6B20]; System.IO.Path.GetDirectoryNameOffset(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jl        near ptr M00_L13
       mov       rcx,rdi
       mov       r8d,eax
       xor       edx,edx
       call      qword ptr [7FFD9EE6F450]; System.String.Substring(Int32, Int32)
       mov       rcx,rax
       call      qword ptr [7FFD9F2F6B38]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       rdi,rax
M00_L04:
       test      rdi,rdi
       je        near ptr M00_L14
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFD9F07E658]; System.IO.DirectoryInfo..ctor(System.String)
M00_L05:
       test      r14,r14
       je        near ptr M00_L15
       mov       rcx,r14
       call      qword ptr [7FFD9F07E670]; System.IO.DirectoryInfo.Create()
       mov       rdi,[r14+8]
       lea       rcx,[rbp-50]
       mov       edx,6
       mov       r8d,2
       call      qword ptr [7FFD9EF14E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       rdx,19CF7080658
       call      qword ptr [7FFD9EF14E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,rsi
       call      qword ptr [7FFD9F326768]; Precode of System.IO.FileInfo.get_Name()
       mov       rdx,rax
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD9EF1E3B8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       mov       rdx,19CF7080658
       call      qword ptr [7FFD9EF14E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD9F07E610]; System.Guid.NewGuid()
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-60]
       mov       r8,19CF708B238
       call      qword ptr [7FFD9F2F6A48]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Guid, System.Private.CoreLib]](System.Guid, System.String)
       lea       rcx,[rbp-50]
       mov       rdx,19CF7090D38
       call      qword ptr [7FFD9EF14E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD9EF14EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD9F2F6898]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-0C0],rax
       mov       rcx,15C62000220
       mov       rdi,[rcx]
       mov       rcx,[rbp-0C0]
       mov       rdx,rdi
       call      qword ptr [7FFD9F2F6BB0]; System.IO.File.Validate(System.String, System.Text.Encoding)
       lea       rcx,[rbp-80]
       mov       rdx,19CF7090C00
       call      qword ptr [7FFD9F107FA8]; System.MemoryExtensions.AsSpan(System.String)
       lea       r8,[rbp-80]
       mov       rcx,[rbp-0C0]
       mov       r9,rdi
       mov       edx,2
       call      qword ptr [7FFD9F2F6BC8]; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       nop
       mov       rcx,rsi
       call      qword ptr [7FFD9F326770]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       jne       short M00_L07
       mov       rdx,[rsi+8]
       mov       rcx,[rbp-0C0]
       xor       r8d,r8d
       call      qword ptr [7FFD9F2F6DA8]; System.IO.File.Move(System.String, System.String, Boolean)
M00_L06:
       mov       byte ptr [rsi+2C],0
       mov       rcx,rsi
       call      qword ptr [7FFD9F4D6160]
       jmp       short M00_L08
M00_L07:
       mov       rdx,[rsi+8]
       mov       rcx,[rbp-0C0]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFD9F2F6AC0]
       jmp       short M00_L06
M00_L08:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD9EF1F030]; System.IO.File.Exists(System.String)
       test      eax,eax
       je        short M00_L09
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD9F2F6AF0]
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFD9F2F6A18]; System.IO.FileSystemInfo.Refresh()
       mov       [rbp-88],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rbp-88]
       mov       rdx,7FFD9F328318
       cmp       [rcx],ecx
       call      qword ptr [7FFD9F2F6E08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FFD9F277480]
       mov       ecx,237
       mov       rdx,7FFD9F0CEB50
       call      qword ptr [7FFD9EF17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD9EFC4D18
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9ECF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFD9F0CEB50
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9ECF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD9F4D5D88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD9F3850B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       ecx,1C47E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rcx,rax
       call      qword ptr [7FFD9F2FFB88]
       int       3
M00_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1C426
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9F075A40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L14:
       xor       r14d,r14d
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9F2F6A78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD9EF1F030]; System.IO.File.Exists(System.String)
       test      eax,eax
       je        short M00_L16
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD9F2F6AF0]
M00_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 1356
```
```assembly
; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,378
       vzeroupper
       lea       rbp,[rsp+3B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-360],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-290],xmm4
       vmovdqa   xmmword ptr [rbp+rax-280],xmm4
       vmovdqa   xmmword ptr [rbp+rax-270],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0D48587828939
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-348]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-330],rcx
       mov       rcx,rbp
       mov       [rbp-320],rcx
       mov       [rbp-388],rsi
       mov       [rbp-380],rbx
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-2E0],ymm1
       vmovdqu   xmmword ptr [rbp-2CC],xmm1
       xor       r14d,r14d
       test      rbx,rbx
       je        short M01_L02
       mov       r15d,[rbx+8]
       test      r15d,r15d
       je        short M01_L02
       lea       ecx,[r15-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L36
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L37
M01_L02:
       mov       [rbp-378],rbx
M01_L03:
       xor       ecx,ecx
       mov       [rbp-2F0],rcx
       mov       [rbp-2EC],ecx
       mov       rax,7FFE27855FF0
       call      rax
       lea       rdx,[rbp-2EC]
       mov       ecx,1
       mov       rax,7FFE2785BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFE27855F30
       call      rax
       mov       ecx,eax
       call      00007FFDFE971F40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2F0],al
       movzx     eax,byte ptr [rbp-2F0]
       mov       [rbp-34C],al
       mov       eax,[rbp-2EC]
       mov       [rbp-350],eax
       cmp       dword ptr [7FFDFEC34A90],0
       jne       near ptr M01_L38
M01_L04:
       mov       r15,[rbp-378]
       test      r15,r15
       je        short M01_L05
       mov       ecx,[r15+8]
       cmp       ecx,104
       jge       near ptr M01_L11
       test      ecx,ecx
       je        short M01_L05
       dec       ecx
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M01_L11
       cmp       ecx,2E
       je        near ptr M01_L11
M01_L05:
       mov       [rbp-378],r15
       mov       rax,r15
M01_L06:
       test      rax,rax
       je        near ptr M01_L10
       add       rax,0C
       mov       rbx,rax
M01_L07:
       mov       [rbp-2F8],rbx
       xor       ecx,ecx
       mov       rax,7FFE27855FF0
       call      rax
       lea       r8,[rbp-2E0]
       mov       rcx,rbx
       xor       edx,edx
       mov       rax,7FFD9EDEB230
       mov       [rbp-338],rax
       lea       rax,[M01_L08]
       mov       [rbp-328],rax
       lea       rax,[rbp-348]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFE27865090
       call      rax
M01_L08:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFDFEC34A90],0
       je        short M01_L09
       call      qword ptr [7FFDFEC22648]; CORINFO_HELP_STOP_FOR_GC
M01_L09:
       mov       rcx,[rbp-340]
       mov       [rdi+8],rcx
       mov       ebx,eax
       mov       rax,7FFE27855F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2F8],rax
       call      00007FFDFE971F40
       test      ebx,ebx
       jne       near ptr M01_L15
       call      00007FFDFE971F20
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFD9F27EFB8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L15
       jmp       short M01_L12
M01_L10:
       xor       ebx,ebx
       jmp       near ptr M01_L07
M01_L11:
       mov       rcx,r15
       call      qword ptr [7FFD9F27F030]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-378],r15
       jmp       near ptr M01_L06
M01_L12:
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FFD9ECF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-378]
       call      qword ptr [7FFD9F386280]
       mov       [rbp-370],rax
       mov       rcx,[rbp-370]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9EDF03A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L13
       call      00007FFDFE971F20
       mov       r14d,eax
       jmp       short M01_L14
M01_L13:
       xor       r14d,r14d
       lea       rcx,[rbp-2E0]
       lea       rdx,[rbp-290]
       call      qword ptr [7FFD9F386298]
       nop
M01_L14:
       mov       rcx,[rbp-370]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-370]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L15:
       cmp       byte ptr [rbp-34C],0
       je        short M01_L16
       xor       ecx,ecx
       mov       [rbp-300],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-300]
       mov       ecx,[rbp-350]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M01_L16:
       test      r14d,r14d
       je        near ptr M01_L21
M01_L17:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9F076868]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       esi,esi
       mov       rdi,[rbp-380]
       mov       r15d,[rdi+8]
       mov       r14d,r15d
       cmp       r14d,2
       jl        short M01_L18
       lea       rcx,[rdi+0C]
       mov       [rbp-360],rcx
       mov       [rbp-358],r14d
       lea       rcx,[rbp-360]
       call      qword ptr [7FFD9F27EFD0]; System.IO.PathInternal.EndsInDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       ecx,[r14-1]
       test      eax,eax
       cmovne    r14d,ecx
M01_L18:
       lea       rcx,[rdi+0C]
       mov       eax,r15d
       mov       [rbp-360],rcx
       mov       [rbp-358],eax
       lea       rcx,[rbp-360]
       call      qword ptr [7FFD9F27EFE8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       r13d,eax
       cmp       r14d,r13d
       jle       near ptr M01_L27
       dec       r14d
       jmp       short M01_L20
M01_L19:
       dec       r14d
M01_L20:
       cmp       r14d,r13d
       jl        near ptr M01_L27
       test      esi,esi
       jne       near ptr M01_L27
       lea       r8d,[r14+1]
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD9EE6F450]; System.String.Substring(Int32, Int32)
       mov       r12,rax
       lea       rdx,[rbp-308]
       mov       rcx,r12
       call      qword ptr [7FFD9F387708]
       test      eax,eax
       jne       short M01_L25
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L26
M01_L21:
       cmp       dword ptr [rbp-2E0],0FFFFFFFF
       je        near ptr M01_L17
       test      byte ptr [rbp-2E0],10
       je        near ptr M01_L17
M01_L22:
       mov       r8,0D48587828939
       cmp       [rbp-40],r8
       je        short M01_L23
       call      CORINFO_HELP_FAIL_FAST
M01_L23:
       nop
       add       rsp,378
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FFD9EE6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L26
M01_L25:
       mov       esi,1
M01_L26:
       cmp       r14d,r13d
       jle       near ptr M01_L19
       cmp       r14d,r15d
       jae       near ptr M01_L43
       mov       edx,r14d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       cmp       edx,5C
       je        near ptr M01_L19
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L19
       dec       r14d
       jmp       short M01_L26
M01_L27:
       mov       r14d,[rbx+10]
       mov       r15d,1
       xor       r13d,r13d
       mov       r12,rdi
       mov       rdx,[rbp-388]
       mov       [rbp-298],rdx
       test      rdx,rdx
       je        short M01_L28
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L31
M01_L28:
       xor       edx,edx
M01_L29:
       mov       dword ptr [rbp-2B0],18
       mov       [rbp-2A8],rdx
       xor       edx,edx
       mov       [rbp-2A0],edx
M01_L30:
       cmp       dword ptr [rbx+10],0
       jle       near ptr M01_L34
       mov       edx,[rbx+10]
       dec       edx
       cmp       edx,[rbx+10]
       jae       near ptr M01_L40
       mov       rcx,[rbx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L43
       mov       r15,[rcx+rdx*8+10]
       mov       edx,[rbx+10]
       dec       edx
       mov       rcx,rbx
       call      qword ptr [7FFD9EDE3610]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,r15
       call      qword ptr [7FFD9F27F030]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rcx,rax
       lea       rdx,[rbp-2B0]
       call      qword ptr [7FFD9F27F048]; Interop+Kernel32.CreateDirectoryPrivate(System.String, SECURITY_ATTRIBUTES*)
       mov       ecx,eax
       or        ecx,r13d
       mov       [rbp-368],r15
       mov       r15d,eax
       jne       short M01_L30
       call      00007FFDFE971F20
       mov       [rbp-2B8],eax
       cmp       dword ptr [rbp-2B8],0B7
       je        short M01_L32
       mov       r13d,[rbp-2B8]
       jmp       near ptr M01_L30
M01_L31:
       add       rdx,10
       jmp       near ptr M01_L29
M01_L32:
       mov       rcx,[rbp-368]
       call      qword ptr [7FFD9EF1F120]; System.IO.FileSystem.FileExists(System.String)
       test      eax,eax
       jne       short M01_L33
       lea       rdx,[rbp-2B8]
       mov       rcx,[rbp-368]
       call      qword ptr [7FFD9F387708]
       test      eax,eax
       jne       near ptr M01_L30
       jmp       near ptr M01_L39
M01_L33:
       mov       r13d,[rbp-2B8]
       mov       rcx,[rbp-368]
       mov       r12,rcx
       jmp       near ptr M01_L30
M01_L34:
       xor       ecx,ecx
       mov       [rbp-298],rcx
       or        esi,r14d
       je        short M01_L35
       test      r15d,r15d
       jne       near ptr M01_L22
       test      r13d,r13d
       je        near ptr M01_L22
       jmp       near ptr M01_L42
M01_L35:
       mov       rcx,rdi
       call      qword ptr [7FFD9F387720]
       mov       rbx,rax
       lea       rdx,[rbp-310]
       mov       rcx,rbx
       call      qword ptr [7FFD9F387708]
       test      eax,eax
       jne       near ptr M01_L22
       jmp       near ptr M01_L41
M01_L36:
       mov       ecx,1
       jmp       near ptr M01_L01
M01_L37:
       lea       rcx,[rbx+0C]
       mov       r13d,r15d
       mov       [rbp-360],rcx
       mov       [rbp-358],r13d
       lea       rcx,[rbp-360]
       call      qword ptr [7FFD9F27EFE8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M01_L02
       lea       r8d,[r15-1]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD9EE6F450]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       mov       [rbp-378],r15
       jmp       near ptr M01_L03
M01_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L04
M01_L39:
       mov       rcx,[rbp-368]
       cmp       dword ptr [rbp-2B8],5
       mov       [rbp-368],rcx
       jne       near ptr M01_L30
       jmp       near ptr M01_L33
M01_L40:
       call      qword ptr [7FFD9F2FEE80]
       int       3
M01_L41:
       mov       rdx,rbx
       mov       ecx,3
       xor       r8d,r8d
       call      qword ptr [7FFD9F386220]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L42:
       mov       ecx,r13d
       mov       rdx,r12
       xor       r8d,r8d
       call      qword ptr [7FFD9F386220]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-370],0
       je        short M01_L44
       mov       rcx,[rbp-370]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-370]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
M01_L44:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-34C],0
       je        short M01_L45
       xor       ecx,ecx
       mov       [rbp-300],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-300]
       mov       ecx,[rbp-350]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M01_L45:
       nop
       add       rsp,28
       ret
; Total bytes of code 1897
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       test      esi,esi
       jle       short M02_L00
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M02_L01
       cmp       ecx,2F
       je        short M02_L01
       mov       rcx,7FFD9F3D2458
       call      CORINFO_HELP_COUNTPROFILE32
M02_L00:
       cmp       esi,2
       jl        short M02_L03
       movzx     ecx,word ptr [rbx]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       ja        short M02_L02
       mov       rcx,7FFD9F3D245C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       word ptr [rbx+2],3A
       sete      al
       movzx     eax,al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rcx,7FFD9F3D2468
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,7FFD9F3D2460
       call      CORINFO_HELP_COUNTPROFILE32
M02_L03:
       mov       rcx,7FFD9F3D2464
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 162
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,[r8]
       mov       esi,[r8+8]
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       r13d,r15d
       add       r13d,ebp
       jo        near ptr M03_L02
       add       r13d,esi
       jo        near ptr M03_L02
       test      r13d,r13d
       je        near ptr M03_L00
       mov       rcx,7FFD9F3D24E4
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFDFE9750F0
       mov       r13,rax
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+34],eax
       cmp       r15d,eax
       ja        near ptr M03_L01
       mov       r10d,r15d
       add       r10,r10
       mov       [rsp+28],r10
       mov       r8,r10
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,[rsp+28]
       add       r14,r12
       mov       r12d,[rsp+34]
       sub       r12d,r15d
       cmp       ebp,r12d
       ja        short M03_L01
       mov       r15d,ebp
       add       r15,r15
       mov       r8,r15
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+r15]
       sub       r12d,ebp
       cmp       esi,r12d
       ja        short M03_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rcx,7FFD9F3D24E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,19CF7080008
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       call      qword ptr [7FFD9F10D218]
       int       3
M03_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 293
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx]
       mov       ebp,[rcx+8]
       mov       ecx,ebp
       add       ecx,esi
       jo        near ptr M04_L02
       test      ecx,ecx
       je        short M04_L00
       movsxd    rcx,ecx
       call      qword ptr [7FFDE6E9B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        short M04_L01
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFDE6E9D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFDE6E9D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       call      qword ptr [7FFDE6E9F2C0]
       int       3
M04_L02:
       call      qword ptr [7FFDE6E88FD0]
       int       3
; Total bytes of code 176
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M05_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD9EF1F060]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M05_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFD9EF1F090]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M05_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD9EF1F0C0]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M05_L00
       mov       rcx,rbx
       call      qword ptr [7FFD9EF1F0D8]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M05_L01
M05_L00:
       mov       rax,rbx
M05_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ecx,1AC3E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rcx,rax
       call      qword ptr [7FFD9F2FFB88]
       int       3
M05_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD9F3863A0]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD9F076238]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD9F3863B8]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD9F076238]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```
```assembly
; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       mov       eax,[rcx+8]
       test      eax,eax
       je        short M06_L02
       mov       rcx,[rcx]
       test      eax,eax
       jle       short M06_L02
       xor       edx,edx
M06_L00:
       cmp       word ptr [rcx+rdx],20
       je        short M06_L01
       xor       eax,eax
       ret
M06_L01:
       add       rdx,2
       dec       eax
       jne       short M06_L00
M06_L02:
       mov       eax,1
       ret
; Total bytes of code 40
```
```assembly
; System.MemoryExtensions.AsSpan(System.String)
       test      rdx,rdx
       je        short M07_L00
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       jmp       short M07_L01
M07_L00:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
M07_L01:
       mov       rax,rcx
       ret
; Total bytes of code 33
```
```assembly
; System.IO.Path.GetDirectoryNameOffset(System.ReadOnlySpan`1<Char>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       mov       [rsp+20],rbx
       mov       [rsp+28],esi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD9F27EFE8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edi,eax
       mov       ebp,esi
       cmp       ebp,edi
       jle       near ptr M08_L06
M08_L00:
       dec       ebp
       cmp       ebp,esi
       jae       near ptr M08_L07
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M08_L01
       cmp       ecx,2F
       je        short M08_L01
       mov       rcx,7FFD9F3FB4B8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       ebp,edi
       jle       short M08_L02
       jmp       short M08_L00
M08_L01:
       mov       rcx,7FFD9F3FB4B4
       call      CORINFO_HELP_COUNTPROFILE32
M08_L02:
       cmp       ebp,edi
       jle       short M08_L04
M08_L03:
       lea       r14d,[rbp-1]
       cmp       r14d,esi
       jae       short M08_L07
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M08_L05
       cmp       ecx,2F
       je        short M08_L05
       mov       rcx,7FFD9F3FB4C0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L04:
       mov       rcx,7FFD9F3FB4C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L05:
       mov       rcx,7FFD9F3FB4BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,r14d
       cmp       ebp,edi
       jle       short M08_L04
       jmp       short M08_L03
M08_L06:
       mov       rcx,7FFD9F3FB4B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,0FFFFFFFF
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 251
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        near ptr M09_L02
       test      ebx,ebx
       je        short M09_L01
       cmp       eax,ebx
       je        short M09_L00
       mov       rcx,7FFD9F3FB504
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,ebx
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.String
       call      00007FFDFE9750F0
       mov       rbx,rax
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       cmp       [rbx],bl
       lea       rcx,[rbx+0C]
       lea       r8,[rbp+rbp]
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L00:
       mov       rcx,7FFD9F3FB500
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L01:
       mov       rcx,7FFD9F3FB4FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,19CF7080008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L02:
       mov       rcx,7FFD9F3FB4F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FFD9F3876F0]
       int       3
; Total bytes of code 210
```
```assembly
; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       mov       [rbp+30],rax
       mov       rax,0D48587828939
       mov       [rbp],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M10_L18
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M10_L18
       xor       edi,edi
M10_L00:
       movzx     edx,word ptr [rbx+rdi*2+0C]
       cmp       edx,5C
       je        near ptr M10_L07
       cmp       edx,2F
       jne       near ptr M10_L10
M10_L01:
       mov       rcx,7FFD9F3FB568
       call      CORINFO_HELP_COUNTPROFILE32
       test      [rsp],esp
       sub       rsp,210
       lea       rcx,[rsp+20]
       xor       eax,eax
       mov       [rbp+18],rax
       mov       [rbp+28],rcx
       mov       dword ptr [rbp+30],104
       mov       [rbp+20],eax
       xor       edi,edi
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,5C
       je        short M10_L02
       cmp       ecx,2F
       jne       short M10_L03
M10_L02:
       mov       rcx,7FFD9F3FB580
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
       mov       ecx,[rbp+20]
       mov       rdx,[rbp+28]
       mov       eax,[rbp+30]
       cmp       ecx,eax
       jae       near ptr M10_L22
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],5C
       inc       ecx
       mov       [rbp+20],ecx
M10_L03:
       mov       edi,edi
       cmp       esi,edi
       jg        near ptr M10_L15
M10_L04:
       mov       rcx,7FFD9F3FB590
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,[rbp+20]
       cmp       ecx,[rbp+30]
       ja        near ptr M10_L24
       mov       rax,[rbp+28]
       mov       [rbp+8],rax
       mov       [rbp+10],ecx
       lea       rcx,[rbp+8]
       call      qword ptr [7FFD9EF14180]; System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rbx,rax
       mov       rdx,[rbp+18]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+18],ymm0
       test      rdx,rdx
       jne       near ptr M10_L25
M10_L05:
       mov       rax,rbx
       mov       r8,0D48587828939
       cmp       [rbp],r8
       je        short M10_L06
       call      CORINFO_HELP_FAIL_FAST
M10_L06:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M10_L07:
       test      edi,edi
       jle       short M10_L09
       lea       ecx,[rdi+1]
       cmp       esi,ecx
       jle       short M10_L08
       lea       ecx,[rdi+1]
       cmp       ecx,esi
       jae       near ptr M10_L26
       lea       ecx,[rdi+1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M10_L21
       cmp       ecx,2F
       je        near ptr M10_L21
       mov       rcx,7FFD9F3FB56C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L10
M10_L08:
       mov       rcx,7FFD9F3FB570
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L10
M10_L09:
       mov       rcx,7FFD9F3FB574
       call      CORINFO_HELP_COUNTPROFILE32
M10_L10:
       mov       rcx,7FFD9F3FB578
       call      CORINFO_HELP_COUNTPROFILE32
       inc       edi
       cmp       esi,edi
       jg        near ptr M10_L00
       mov       rcx,7FFD9F3FB57C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L19
M10_L11:
       mov       rcx,7FFD9F3FB584
       call      CORINFO_HELP_COUNTPROFILE32
M10_L12:
       mov       rcx,7FFD9F3FB588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,5C
M10_L13:
       mov       ecx,[rbp+20]
       mov       rax,[rbp+28]
       mov       r8d,[rbp+30]
       cmp       ecx,r8d
       jae       near ptr M10_L23
       mov       r8d,ecx
       mov       [rax+r8*2],dx
       inc       ecx
       mov       [rbp+20],ecx
M10_L14:
       mov       rcx,7FFD9F3FB58C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       edi
       cmp       esi,edi
       jle       near ptr M10_L04
M10_L15:
       movzx     edx,word ptr [rbx+rdi*2+0C]
       cmp       edx,5C
       je        short M10_L16
       cmp       edx,2F
       jne       short M10_L13
M10_L16:
       lea       ecx,[rdi+1]
       cmp       esi,ecx
       jle       short M10_L12
       lea       ecx,[rdi+1]
       cmp       ecx,esi
       jae       near ptr M10_L26
       lea       ecx,[rdi+1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        short M10_L17
       cmp       ecx,2F
       jne       near ptr M10_L11
M10_L17:
       mov       rcx,7FFD9F3FB594
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L14
M10_L18:
       mov       rcx,7FFD9F3FB560
       call      CORINFO_HELP_COUNTPROFILE32
M10_L19:
       mov       rax,rbx
       mov       r8,0D48587828939
       cmp       [rbp],r8
       je        short M10_L20
       call      CORINFO_HELP_FAIL_FAST
M10_L20:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M10_L21:
       mov       rcx,7FFD9F3FB564
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L01
M10_L22:
       lea       rcx,[rbp+18]
       mov       edx,5C
       call      qword ptr [7FFD9F3877C8]
       jmp       near ptr M10_L03
M10_L23:
       lea       rcx,[rbp+18]
       call      qword ptr [7FFD9F3877C8]
       jmp       near ptr M10_L14
M10_L24:
       call      qword ptr [7FFD9EE67198]
       int       3
M10_L25:
       mov       rcx,15C62000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD9EFAFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M10_L05
M10_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 779
```
```assembly
; System.IO.DirectoryInfo..ctor(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      qword ptr [7FFDE6EA7338]; Precode of System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rbx
       mov       rcx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFDE6EA6D00]; Precode of System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFDE6E9C210]
       int       3
; Total bytes of code 84
```
```assembly
; System.IO.DirectoryInfo.Create()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FFD9F27EFA0]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       byte ptr [rbx+2C],0
       mov       dword ptr [rbx+28],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,15C62000C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FFD9F3FB618
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbx+8],rax
       test      rax,rax
       je        short M13_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M13_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M13_L00
; Total bytes of code 127
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M14_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M14_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FFD9EE67198]
       int       3
M14_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFD9F2F4300]
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+14],0
       jne       short M15_L03
       test      rsi,rsi
       je        short M15_L02
       lea       r8,[rbx+18]
       mov       edx,[rbx+10]
       mov       ecx,[r8+8]
       cmp       edx,ecx
       ja        short M15_L00
       mov       r8,[r8]
       mov       eax,edx
       lea       rax,[r8+rax*2]
       sub       ecx,edx
       mov       edi,[rsi+8]
       cmp       edi,ecx
       ja        short M15_L01
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       mov       rcx,rax
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,7FFD9F485440
       call      CORINFO_HELP_COUNTPROFILE32
       add       [rbx+10],edi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L00:
       call      qword ptr [7FFD9EE67198]
       int       3
M15_L01:
       mov       rcx,7FFD9F485444
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M15_L03
M15_L02:
       mov       rcx,7FFD9F485448
       call      CORINFO_HELP_COUNTPROFILE32
M15_L03:
       mov       rcx,7FFD9F48544C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD9F387C60]
; Total bytes of code 175
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       mov       rbx,rcx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       lea       rcx,[rbp-48]
       mov       rax,7FFD9F2D0F60
       mov       [rbp-70],rax
       lea       rax,[M16_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE28180930
       call      rax
M16_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDFEC34A90],0
       je        short M16_L01
       call      qword ptr [7FFDFEC22648]; CORINFO_HELP_STOP_FOR_GC
M16_L01:
       mov       rcx,[rbp-78]
       mov       [rsi+8],rcx
       mov       esi,eax
       test      esi,esi
       jne       short M16_L02
       mov       rcx,7FFD9F485494
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rbp-48]
       vmovups   [rbx],xmm0
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L02:
       mov       rcx,7FFD9F485490
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       call      qword ptr [7FFD9F387C78]
       int       3
; Total bytes of code 210
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Guid, System.Private.CoreLib]](System.Guid, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M17_L04
M17_L00:
       mov       rcx,offset MT_System.Guid
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       vmovups   xmm0,[rsi]
       vmovups   [rbp+8],xmm0
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       mov       r14d,[rcx+8]
       cmp       edx,r14d
       ja        near ptr M17_L06
       mov       rcx,[rcx]
       mov       eax,edx
       lea       r15,[rcx+rax*2]
       sub       r14d,edx
       test      rdi,rdi
       jne       near ptr M17_L03
       xor       r13d,r13d
       xor       r12d,r12d
M17_L01:
       mov       rcx,rbp
       mov       rdx,7FFD9F4855C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       [rsp+40],r15
       mov       [rsp+48],r14d
       mov       [rsp+30],r13
       mov       [rsp+38],r12d
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+40]
       lea       r9,[rsp+30]
       lea       r8,[rsp+50]
       mov       r11,7FFD9EC40BA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M17_L05
       mov       rcx,7FFD9F4856D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rsp+50]
       add       [rbx+10],eax
M17_L02:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L03:
       lea       r13,[rdi+0C]
       mov       r12d,[rdi+8]
       jmp       near ptr M17_L01
M17_L04:
       mov       rcx,7FFD9F4855C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD9F387C90]
       jmp       short M17_L02
M17_L05:
       mov       rcx,7FFD9F4855C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFD9F27ED60]
       jmp       near ptr M17_L00
M17_L06:
       call      qword ptr [7FFD9EE67198]
       int       3
; Total bytes of code 320
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M18_L16
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rbp,rbp
       je        near ptr M18_L03
       mov       rcx,15C62000C88
       mov       rbx,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M18_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M18_L17
M18_L00:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M18_L18
M18_L01:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       short M18_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,esi
       cmp       [rbp+8],ecx
       jne       near ptr M18_L19
       mov       ecx,esi
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       short M18_L04
M18_L02:
       mov       rcx,15C62000C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M18_L29
M18_L03:
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M18_L04:
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M18_L32
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M18_L20
M18_L05:
       mov       r15,[rax+8]
       test      byte ptr [7FFD9F3FBF80],1
       je        near ptr M18_L21
M18_L06:
       cmp       byte ptr [7FFD9EC3B194],0
       je        near ptr M18_L22
       call      qword ptr [7FFD9F387858]
       mov       r13d,eax
M18_L07:
       test      byte ptr [7FFD9F3FBE10],1
       je        near ptr M18_L24
M18_L08:
       mov       eax,r13d
       xor       edx,edx
       div       dword ptr [7FFD9EC3B188]
       mov       r13d,edx
       mov       eax,[r15+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M18_L28
       mov       [rsp+40],eax
M18_L09:
       cmp       r13d,eax
       jae       near ptr M18_L32
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rsp+38],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+60],r10d
       mov       rcx,r8
       call      00007FFDFE97DF30
       test      eax,eax
       jne       short M18_L10
       mov       rcx,[rsp+38]
       call      qword ptr [7FFD9F2FFC78]
M18_L10:
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+5C],r8d
       cmp       [rcx+8],r8d
       jbe       short M18_L12
       test      r8d,r8d
       je        short M18_L15
M18_L11:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+5C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+60],1
M18_L12:
       mov       rcx,rax
       call      00007FFDFE97DE50
       test      eax,eax
       jne       near ptr M18_L25
M18_L13:
       cmp       dword ptr [rsp+60],0
       je        near ptr M18_L26
       mov       r15d,1
M18_L14:
       jmp       near ptr M18_L02
M18_L15:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M18_L11
M18_L16:
       call      qword ptr [7FFD9EE67198]
       int       3
M18_L17:
       mov       ecx,3
       call      qword ptr [7FFD9F3842D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M18_L00
M18_L18:
       mov       rcx,rbx
       call      qword ptr [7FFD9EF1CE88]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M18_L01
M18_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD9F387EA0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFD9F076238]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M18_L20:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFD9F387EB8]
       jmp       near ptr M18_L05
M18_L21:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M18_L06
M18_L22:
       mov       ecx,0A
       call      qword ptr [7FFD9F387870]
       mov       r13d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFD9F387870]
       lea       ecx,[r13-1]
       mov       [rax+10],ecx
       movzx     eax,r13w
       test      eax,eax
       jne       short M18_L23
       call      qword ptr [7FFD9F387888]
       mov       r13d,eax
       jmp       near ptr M18_L07
M18_L23:
       sar       r13d,10
       jmp       near ptr M18_L07
M18_L24:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M18_L08
M18_L25:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FFD9F2FFBA0]
       jmp       near ptr M18_L13
M18_L26:
       inc       r13d
       mov       ecx,[rsp+44]
       cmp       ecx,r13d
       jne       short M18_L27
       xor       r13d,r13d
M18_L27:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,ecx
       jne       near ptr M18_L09
M18_L28:
       xor       r15d,r15d
       jmp       near ptr M18_L14
M18_L29:
       cmp       dword ptr [rbp+8],0
       je        near ptr M18_L03
       mov       rcx,rbp
       call      qword ptr [7FFD9F10D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FFD9F10D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FFD9F3845D0]
       test      r15d,r14d
       jne       near ptr M18_L03
       mov       rcx,rbp
       call      qword ptr [7FFD9F10D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rbx
       call      qword ptr [7FFD9F10D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M18_L30
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M18_L31
M18_L30:
       mov       ecx,esi
       xor       edx,edx
M18_L31:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,ebp
       call      qword ptr [7FFD9F387ED0]
       jmp       near ptr M18_L03
M18_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1042
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M19_L06
       test      rbx,rbx
       je        near ptr M19_L07
       cmp       dword ptr [rsi+8],0
       je        near ptr M19_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M19_L03
       lea       rcx,[rbx+0C]
       mov       eax,[rbx+8]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      qword ptr [7FFD9F27EF58]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M19_L04
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       lea       rbp,[rbx+0C]
       mov       ebx,[rbx+8]
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M19_L02
       cmp       ecx,2F
       je        short M19_L02
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M19_L08
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M19_L00:
       test      ecx,ecx
       jne       short M19_L02
       mov       rcx,19CF70881EC
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rcx
       mov       dword ptr [rsp+40],1
       mov       [rsp+28],rbp
       mov       [rsp+30],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       call      qword ptr [7FFD9F2F6910]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
M19_L01:
       jmp       short M19_L05
M19_L02:
       mov       [rsp+48],rdi
       mov       [rsp+50],esi
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFD9F07DB48]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M19_L01
M19_L03:
       mov       rax,rsi
       jmp       short M19_L05
M19_L04:
       mov       rax,rbx
M19_L05:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L06:
       mov       ecx,1C47E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rcx,rax
       call      qword ptr [7FFD9F2FFB88]
       int       3
M19_L07:
       mov       ecx,1C48A
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rcx,rax
       call      qword ptr [7FFD9F2FFB88]
       int       3
M19_L08:
       mov       ecx,1
       jmp       near ptr M19_L00
; Total bytes of code 355
```
```assembly
; System.IO.File.Validate(System.String, System.Text.Encoding)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M20_L00
       cmp       dword ptr [rbx+8],0
       je        short M20_L00
       test      rdx,rdx
       je        short M20_L01
       add       rsp,20
       pop       rbx
       ret
M20_L00:
       mov       ecx,1AC3E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9F387300]
       int       3
M20_L01:
       mov       ecx,1C2B0
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rcx,rax
       call      qword ptr [7FFD9F2FFB88]
       int       3
; Total bytes of code 95
```
```assembly
; System.IO.File.WriteToFile(System.String, System.IO.FileMode, System.ReadOnlySpan`1<Char>, System.Text.Encoding)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       mov       [rbp+70],rax
       mov       rax,0D48587828939
       mov       [rbp+8],rax
       mov       rdi,rcx
       mov       esi,edx
       mov       rbx,r9
       mov       r14,[r8]
       mov       r15d,[r8+8]
       mov       rcx,rbx
       mov       rdx,7FFD9F48DF10
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      rax,rax
       je        near ptr M21_L34
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M21_L00:
       mov       [rbp+0A4],r12d
       cmp       r15d,2000
       jl        short M21_L01
       cmp       esi,6
       jne       near ptr M21_L30
M21_L01:
       xor       ecx,ecx
       xor       r10d,r10d
       mov       [rbp+108],rbx
       mov       [rbp+20],r14
       mov       [rbp+18],r13
M21_L02:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       [rbp+98],r10
       mov       [rsp+30],r10
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,2
       mov       r9d,1
       call      qword ptr [7FFD9F2F6C58]; System.IO.Strategies.FileStreamHelpers.ValidateArguments(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, Int32, System.IO.FileOptions, Int64)
       mov       rcx,rdi
       call      qword ptr [7FFD9EF1F048]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp+30],rax
       xor       ecx,ecx
       mov       [rbp+90],rcx
       mov       [rbp+94],ecx
       mov       rax,7FFE27855FF0
       call      rax
       lea       rdx,[rbp+94]
       mov       ecx,1
       mov       rax,7FFE2785BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFE27855F30
       call      rax
       mov       ecx,eax
       call      00007FFDFE971F40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp+90],al
       movzx     eax,byte ptr [rbp+90]
       mov       [rbp+80],al
       mov       eax,[rbp+94]
       mov       [rbp+7C],eax
       cmp       dword ptr [7FFDFEC34A90],0
       jne       near ptr M21_L35
M21_L03:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbp+30]
       mov       edx,esi
       mov       r8d,2
       mov       r9d,1
       call      qword ptr [7FFD9F2F6D30]; Microsoft.Win32.SafeHandles.SafeFileHandle.CreateFile(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.FileOptions)
       mov       rbx,rax
       mov       rdi,[rbp+98]
       test      rdi,rdi
       jle       short M21_L04
       mov       rcx,[rbp+30]
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFD9F387EE8]
       nop
M21_L04:
       cmp       byte ptr [rbp+80],0
       je        short M21_L05
       lea       rdx,[rbp+88]
       mov       ecx,[rbp+7C]
       call      qword ptr [7FFD9EF1F180]; Interop+Kernel32.SetThreadErrorMode(UInt32, UInt32 ByRef)
M21_L05:
       mov       [rbp+40],rbx
       cmp       esi,6
       jne       short M21_L06
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFD9EF167A8]; Microsoft.Win32.SafeHandles.SafeFileHandle.get_CanSeek()
       test      eax,eax
       jne       short M21_L08
       mov       rcx,7FFD9F48E018
       call      CORINFO_HELP_COUNTPROFILE32
M21_L06:
       xor       eax,eax
M21_L07:
       mov       rsi,rax
       test      r15d,r15d
       jne       short M21_L10
       test      r12d,r12d
       jle       near ptr M21_L31
       test      rax,rax
       jne       short M21_L09
       mov       rcx,7FFD9F48E020
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r13,[rbp+18]
       mov       [rbp+48],r13
       mov       [rbp+50],r12d
       lea       rdx,[rbp+48]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD9EF1C570]; System.IO.RandomAccess.WriteAtOffset(Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlySpan`1<Byte>, Int64)
       jmp       near ptr M21_L31
M21_L08:
       mov       rcx,7FFD9F48E01C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD9F387F00]
       mov       rcx,rbx
       call      qword ptr [7FFD9F387F18]
       jmp       short M21_L07
M21_L09:
       mov       rcx,7FFD9F48E024
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M21_L31
M21_L10:
       mov       r13,[rbp+18]
       mov       ecx,2000
       cmp       r15d,2000
       mov       ebx,ecx
       cmovle    ebx,r15d
       mov       rcx,[rbp+108]
       mov       rdx,7FFD9F48E028
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp+108]
       mov       edx,ebx
       mov       [rbp+108],rcx
       mov       rax,[rcx]
       mov       rbx,[rax+68]
       call      qword ptr [rbx+28]
       mov       edi,[rbp+0A4]
       mov       r14d,eax
       add       r14d,edi
       jo        near ptr M21_L28
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       r14d,400
       ja        near ptr M21_L20
       test      [rsp],esp
       sub       rsp,400
       lea       r12,[rsp+40]
       mov       r14d,400
M21_L11:
       test      rsi,rsi
       jne       short M21_L14
       cmp       edi,r14d
       jg        near ptr M21_L18
       mov       r8d,edi
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M21_L12:
       mov       rcx,[rbp+108]
       mov       rdx,7FFD9F48E248
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp+108]
       call      qword ptr [rbx+20]
       mov       rbx,rax
       test      r15d,r15d
       jne       near ptr M21_L17
M21_L13:
       mov       rcx,7FFD9F48E460
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M21_L23
M21_L14:
       mov       rcx,7FFD9F48E240
       call      CORINFO_HELP_COUNTPROFILE32
       xor       edi,edi
       jmp       short M21_L12
M21_L15:
       mov       r13d,r15d
M21_L16:
       cmp       r13d,r15d
       ja        near ptr M21_L19
       mov       rax,[rbp+20]
       mov       r8,rax
       mov       [rbp+10],r8
       mov       eax,r13d
       lea       rax,[r8+rax*2]
       sub       r15d,r13d
       mov       [rbp+20],rax
       cmp       edi,r14d
       ja        near ptr M21_L19
       mov       r10d,edi
       add       r10,r12
       mov       [rbp+28],r10
       mov       r9d,r14d
       sub       r9d,edi
       mov       [rbp+84],r9d
       mov       rcx,rbx
       mov       rdx,7FFD9F48E358
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp+10]
       mov       [rbp+68],rcx
       mov       [rbp+70],r13d
       mov       r13,[rbp+28]
       mov       [rbp+58],r13
       mov       r13d,[rbp+84]
       mov       [rbp+60],r13d
       mov       rcx,rbx
       lea       rdx,[rbp+68]
       lea       r8,[rbp+58]
       test      r15d,r15d
       sete      r9b
       movzx     r9d,r9b
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       add       edi,eax
       cmp       edi,r14d
       ja        short M21_L19
       mov       [rbp+48],r12
       mov       [rbp+50],edi
       lea       rdx,[rbp+48]
       mov       rcx,[rbp+40]
       mov       r8,rsi
       call      qword ptr [7FFD9EF1C570]; System.IO.RandomAccess.WriteAtOffset(Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlySpan`1<Byte>, Int64)
       movsxd    rax,edi
       add       rsi,rax
       xor       edi,edi
       test      r15d,r15d
       je        near ptr M21_L13
M21_L17:
       mov       rcx,7FFD9F48E350
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r15d,2000
       jle       near ptr M21_L15
       mov       r13d,2000
       jmp       near ptr M21_L16
M21_L18:
       call      qword ptr [7FFD9F10D218]
       int       3
M21_L19:
       call      qword ptr [7FFD9EE67198]
       int       3
M21_L20:
       mov       rcx,7FFD9F48E130
       call      CORINFO_HELP_COUNTPROFILE32
       test      byte ptr [7FFD9F2BE138],1
       je        near ptr M21_L26
M21_L21:
       mov       rcx,15C62001E10
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,7FFD9F48E138
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r12
       mov       edx,r14d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+38],rax
       test      rax,rax
       je        near ptr M21_L27
       lea       r12,[rax+10]
       mov       r14d,[rax+8]
M21_L22:
       jmp       near ptr M21_L11
M21_L23:
       cmp       qword ptr [rbp+38],0
       je        short M21_L25
       mov       rcx,7FFD9F48E464
       call      CORINFO_HELP_COUNTPROFILE32
       test      byte ptr [7FFD9F2BE138],1
       je        short M21_L29
M21_L24:
       mov       rcx,15C62001E10
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,7FFD9F48E468
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M21_L25:
       mov       rcx,7FFD9F48E570
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M21_L31
M21_L26:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M21_L21
M21_L27:
       xor       r12d,r12d
       xor       r14d,r14d
       jmp       near ptr M21_L22
M21_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M21_L29:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M21_L24
M21_L30:
       mov       [rbp+20],r14
       mov       [rbp+68],r14
       mov       [rbp+70],r15d
       lea       rdx,[rbp+68]
       mov       rcx,rbx
       mov       [rbp+108],rbx
       mov       r8,[rbx]
       mov       r8,[r8+50]
       call      qword ptr [r8+30]
       add       eax,[rbp+0A4]
       cdqe
       mov       [rbp+18],r13
       mov       r10,rax
       jmp       near ptr M21_L02
M21_L31:
       cmp       qword ptr [rbp+40],0
       je        short M21_L32
       mov       rcx,7FFD9F48E574
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+40]
       mov       rdx,7FFD9F48E578
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp+40]
       mov       r11,7FFD9EC40BB0
       call      qword ptr [r11]
M21_L32:
       mov       rcx,7FFD9F48E680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFD9F48E684
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8,0D48587828939
       cmp       [rbp+8],r8
       je        short M21_L33
       call      CORINFO_HELP_FAIL_FAST
M21_L33:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M21_L34:
       xor       r13d,r13d
       mov       [rbp+18],r13
       xor       r12d,r12d
       mov       r13,[rbp+18]
       jmp       near ptr M21_L00
M21_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M21_L03
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp+38],0
       je        short M21_L37
       mov       rcx,7FFD9F48E464
       call      CORINFO_HELP_COUNTPROFILE32
       test      byte ptr [7FFD9F2BE138],1
       jne       short M21_L36
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M21_L36:
       mov       rcx,15C62001E10
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,7FFD9F48E468
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M21_L37:
       mov       rcx,7FFD9F48E570
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp+40],0
       je        short M21_L38
       mov       rcx,7FFD9F48E574
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+40]
       mov       rdx,7FFD9F48E578
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp+40]
       mov       r11,7FFD9EC40BB0
       call      qword ptr [r11]
M21_L38:
       mov       rcx,7FFD9F48E680
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       byte ptr [rbp+80],0
       je        short M21_L39
       lea       rdx,[rbp+88]
       mov       ecx,[rbp+7C]
       call      qword ptr [7FFD9EF1F180]; Interop+Kernel32.SetThreadErrorMode(UInt32, UInt32 ByRef)
M21_L39:
       nop
       add       rsp,48
       ret
; Total bytes of code 1815
```
```assembly
; System.IO.FileInfo.get_Exists()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2C0
       vzeroupper
       lea       rbp,[rsp+2F0]
       xor       eax,eax
       mov       [rbp-2C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       [rbp-2A0],rax
       mov       rax,0D48587828939
       mov       [rbp-38],rax
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M22_L15
       mov       rsi,[rbx+8]
       lea       rdi,[rbx+30]
       xor       r14d,r14d
       test      rsi,rsi
       je        short M22_L01
       cmp       dword ptr [rsi+8],0
       je        short M22_L01
       mov       r15d,[rsi+8]
       dec       r15d
       cmp       r15d,[rsi+8]
       jae       near ptr M22_L21
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M22_L19
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M22_L00:
       test      ecx,ecx
       jne       near ptr M22_L20
M22_L01:
       mov       r15,rsi
M22_L02:
       xor       ecx,ecx
       mov       [rbp-298],rcx
       mov       [rbp-294],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FFD9ECE8CF0
       mov       esi,eax
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
       test      esi,esi
       setne     cl
       movzx     ecx,cl
       mov       [rbp-298],cl
       movzx     ecx,byte ptr [rbp-298]
       mov       [rbp-2B4],cl
       mov       ecx,[rbp-294]
       mov       [rbp-2B8],ecx
       test      r15,r15
       je        short M22_L03
       mov       ecx,[r15+8]
       cmp       ecx,104
       jge       near ptr M22_L07
       test      ecx,ecx
       je        short M22_L03
       dec       ecx
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M22_L07
       cmp       ecx,2E
       je        short M22_L07
M22_L03:
       mov       rax,r15
M22_L04:
       mov       [rbp-2A0],rdi
       mov       rsi,rdi
       test      rax,rax
       je        short M22_L06
       add       rax,0C
       mov       r13,rax
M22_L05:
       mov       [rbp-2A8],r13
       xor       ecx,ecx
       call      00007FFD9ECE8CD8
       mov       rcx,r13
       mov       r8,rsi
       xor       edx,edx
       call      00007FFD9ECE8F18
       mov       esi,eax
       call      00007FFD9ECE8D08
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFDFE971F40
       test      esi,esi
       jne       near ptr M22_L11
       call      00007FFDFE971F20
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFD9F27EFB8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M22_L11
       jmp       short M22_L08
M22_L06:
       xor       r13d,r13d
       jmp       short M22_L05
M22_L07:
       mov       rcx,r15
       call      qword ptr [7FFD9F27F030]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M22_L04
M22_L08:
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FFD9ECF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,r15
       call      qword ptr [7FFD9F386280]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9EDF03A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M22_L09
       call      00007FFDFE971F20
       mov       r14d,eax
       jmp       short M22_L10
M22_L09:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FFD9F386298]
       nop
M22_L10:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
       nop
M22_L11:
       cmp       byte ptr [rbp-2B4],0
       je        short M22_L12
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M22_L12:
       test      r14d,r14d
       jne       short M22_L17
M22_L13:
       mov       eax,r14d
M22_L14:
       mov       [rbx+28],eax
M22_L15:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M22_L23
       mov       eax,[rbx+30]
       cmp       eax,0FFFFFFFF
       je        near ptr M22_L23
       test      al,10
       sete      al
       movzx     eax,al
M22_L16:
       mov       [rbp-28C],eax
       jmp       short M22_L24
M22_L17:
       lea       eax,[r14-2]
       cmp       eax,1
       ja        short M22_L22
M22_L18:
       mov       dword ptr [rdi],0FFFFFFFF
       xor       eax,eax
       jmp       short M22_L14
M22_L19:
       mov       ecx,1
       jmp       near ptr M22_L00
M22_L20:
       lea       rcx,[rsi+0C]
       mov       r13d,[rsi+8]
       mov       [rbp-2C8],rcx
       mov       [rbp-2C0],r13d
       lea       rcx,[rbp-2C8]
       call      qword ptr [7FFD9F27EFE8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M22_L01
       mov       r8d,r15d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD9EE6F450]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       jmp       near ptr M22_L02
M22_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M22_L22:
       cmp       r14d,15
       jne       near ptr M22_L13
       jmp       short M22_L18
M22_L23:
       xor       eax,eax
       jmp       short M22_L16
M22_L24:
       mov       eax,[rbp-28C]
       mov       r8,0D48587828939
       cmp       [rbp-38],r8
       je        short M22_L25
       call      CORINFO_HELP_FAIL_FAST
M22_L25:
       nop
       add       rsp,2C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2D0],0
       je        short M22_L26
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
M22_L26:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2B4],0
       je        short M22_L27
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M22_L27:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       mov       [rbp-28C],eax
       lea       rax,[M22_L24]
       add       rsp,28
       ret
; Total bytes of code 964
```
```assembly
; System.IO.File.Move(System.String, System.String, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rbx,rbx
       je        short M23_L00
       cmp       dword ptr [rbx+8],0
       je        short M23_L00
       test      rsi,rsi
       je        short M23_L01
       cmp       dword ptr [rsi+8],0
       je        short M23_L01
       mov       rcx,rbx
       call      qword ptr [7FFD9EF1F048]; System.IO.Path.GetFullPath(System.String)
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD9EF1F048]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9EF1F120]; System.IO.FileSystem.FileExists(System.String)
       test      eax,eax
       je        short M23_L02
       movzx     r8d,dil
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD9F2F6DC0]; System.IO.FileSystem.MoveFile(System.String, System.String, Boolean)
M23_L00:
       mov       ecx,1C39E
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD9F387300]
       int       3
M23_L01:
       mov       ecx,1C3BC
       mov       rdx,7FFD9EC34000
       call      qword ptr [7FFD9EF17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD9F387300]
       int       3
M23_L02:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD9F38C468]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD9F38C030]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFD9F38C480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 226
```
```assembly
; System.IO.File.Exists(System.String)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M24_L04
       cmp       dword ptr [rbx+8],0
       je        near ptr M24_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9EF1F048]; System.IO.Path.GetFullPath(System.String)
       mov       rbx,rax
       mov       ecx,[rbx+8]
       test      ecx,ecx
       jle       short M24_L00
       dec       ecx
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        short M24_L03
       cmp       ecx,2F
       je        short M24_L03
       mov       rcx,7FFD9F493A48
       call      CORINFO_HELP_COUNTPROFILE32
M24_L00:
       mov       rcx,7FFD9F493A4C
       call      CORINFO_HELP_COUNTPROFILE32
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-30],ymm0
       vmovdqu   xmmword ptr [rbp-1C],xmm0
       lea       rdx,[rbp-30]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFD9EF1F138]; System.IO.FileSystem.FillAttributeInfo(System.String, WIN32_FILE_ATTRIBUTE_DATA ByRef, Boolean)
       test      eax,eax
       je        short M24_L05
M24_L01:
       xor       ebx,ebx
M24_L02:
       jmp       short M24_L07
M24_L03:
       mov       rcx,7FFD9F493A44
       call      CORINFO_HELP_COUNTPROFILE32
M24_L04:
       xor       ebx,ebx
       jmp       short M24_L07
M24_L05:
       mov       ecx,[rbp-30]
       cmp       ecx,0FFFFFFFF
       je        short M24_L01
       test      cl,10
       sete      bl
       movzx     ebx,bl
       jmp       short M24_L02
M24_L06:
       mov       rcx,7FFD9F493A40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M24_L04
M24_L07:
       mov       rcx,7FFD9F493A5C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M24_L08:
       mov       rcx,7FFD9F493A58
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,7FFD9F493A50
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rax,[M24_L08]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,7FFD9F493A54
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rax,[M24_L08]
       add       rsp,28
       ret
       sub       rsp,28
       lea       rax,[M24_L08]
       add       rsp,28
       ret
; Total bytes of code 321
```
```assembly
; System.IO.FileSystemInfo.Refresh()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,318
       vzeroupper
       lea       rbp,[rsp+350]
       xor       eax,eax
       mov       [rbp-308],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-300],ymm4
       vmovdqu   ymmword ptr [rbp-2E0],ymm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       rax,0D48587828939
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-2F0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-2D8],rcx
       mov       rcx,rbp
       mov       [rbp-2C8],rcx
       mov       [rbp-328],rbx
       mov       byte ptr [rbx+2C],0
       mov       rdi,[rbx+8]
       lea       r14,[rbx+30]
       mov       [rbp-310],r14
       xor       r15d,r15d
       test      rdi,rdi
       je        short M25_L01
       cmp       dword ptr [rdi+8],0
       je        short M25_L01
       mov       r13d,[rdi+8]
       dec       r13d
       cmp       r13d,[rdi+8]
       jae       near ptr M25_L25
       mov       ecx,r13d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M25_L21
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M25_L00:
       test      ecx,ecx
       jne       near ptr M25_L22
M25_L01:
       mov       [rbp-320],rdi
M25_L02:
       xor       ecx,ecx
       mov       [rbp-2A0],rcx
       mov       [rbp-29C],ecx
       mov       rax,7FFE27855FF0
       call      rax
       lea       rdx,[rbp-29C]
       mov       ecx,1
       mov       rax,7FFE2785BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFE27855F30
       call      rax
       mov       ecx,eax
       call      00007FFDFE971F40
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2A0],al
       movzx     eax,byte ptr [rbp-2A0]
       mov       [rbp-2F4],al
       mov       eax,[rbp-29C]
       mov       [rbp-2F8],eax
       cmp       dword ptr [7FFDFEC34A90],0
       jne       near ptr M25_L23
M25_L03:
       mov       r13,[rbp-320]
       test      r13,r13
       je        short M25_L04
       mov       ecx,[r13+8]
       cmp       ecx,104
       jge       near ptr M25_L10
       test      ecx,ecx
       je        short M25_L04
       dec       ecx
       movzx     ecx,word ptr [r13+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M25_L10
       cmp       ecx,2E
       je        near ptr M25_L10
M25_L04:
       mov       [rbp-320],r13
       mov       rax,r13
M25_L05:
       mov       r14,[rbp-310]
       mov       [rbp-2A8],r14
       mov       rbx,r14
       test      rax,rax
       je        near ptr M25_L09
       add       rax,0C
       mov       rdi,rax
M25_L06:
       mov       [rbp-2B0],rdi
       xor       ecx,ecx
       mov       rax,7FFE27855FF0
       call      rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FFD9EDEB230
       mov       [rbp-2E0],rax
       lea       rax,[M25_L07]
       mov       [rbp-2D0],rax
       lea       rax,[rbp-2F0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE27865090
       call      rax
M25_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDFEC34A90],0
       je        short M25_L08
       call      qword ptr [7FFDFEC22648]; CORINFO_HELP_STOP_FOR_GC
M25_L08:
       mov       rcx,[rbp-2E8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFE27855F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B0],rax
       mov       [rbp-2A8],rax
       call      00007FFDFE971F40
       test      ebx,ebx
       jne       near ptr M25_L14
       call      00007FFDFE971F20
       mov       r15d,eax
       mov       ecx,r15d
       call      qword ptr [7FFD9F27EFB8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M25_L14
       jmp       short M25_L11
M25_L09:
       xor       edi,edi
       jmp       near ptr M25_L06
M25_L10:
       mov       rcx,r13
       call      qword ptr [7FFD9F27F030]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-320],r13
       jmp       near ptr M25_L05
M25_L11:
       lea       rcx,[rbp-290]
       mov       edx,250
       call      System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-320]
       call      qword ptr [7FFD9F386280]
       mov       [rbp-318],rax
       mov       rcx,[rbp-318]
       cmp       [rcx],ecx
       call      qword ptr [7FFD9EDF03A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M25_L12
       call      00007FFDFE971F20
       mov       r15d,eax
       jmp       short M25_L13
M25_L12:
       xor       r15d,r15d
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-310]
       call      qword ptr [7FFD9F386298]
       nop
M25_L13:
       mov       rcx,[rbp-318]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-318]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
       nop
M25_L14:
       cmp       byte ptr [rbp-2F4],0
       je        short M25_L15
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M25_L15:
       test      r15d,r15d
       jne       short M25_L19
M25_L16:
       mov       eax,r15d
M25_L17:
       mov       rbx,[rbp-328]
       mov       [rbx+28],eax
       mov       r8,0D48587828939
       cmp       [rbp-40],r8
       je        short M25_L18
       call      CORINFO_HELP_FAIL_FAST
M25_L18:
       nop
       add       rsp,318
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M25_L19:
       lea       eax,[r15-2]
       cmp       eax,1
       ja        short M25_L24
M25_L20:
       mov       r14,[rbp-310]
       mov       dword ptr [r14],0FFFFFFFF
       xor       eax,eax
       jmp       short M25_L17
M25_L21:
       mov       ecx,1
       jmp       near ptr M25_L00
M25_L22:
       lea       rcx,[rdi+0C]
       mov       r12d,[rdi+8]
       mov       [rbp-308],rcx
       mov       [rbp-300],r12d
       lea       rcx,[rbp-308]
       call      qword ptr [7FFD9F27EFE8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M25_L01
       mov       r8d,r13d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD9EE6F450]; System.String.Substring(Int32, Int32)
       mov       r13,rax
       mov       [rbp-320],r13
       jmp       near ptr M25_L02
M25_L23:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M25_L03
M25_L24:
       cmp       r15d,15
       jne       near ptr M25_L16
       jmp       short M25_L20
M25_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-318],0
       je        short M25_L26
       mov       rcx,[rbp-318]
       mov       edx,1
       call      qword ptr [7FFD9ECFC768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-318]
       call      qword ptr [7FFD9ECF7AE0]; System.GC.SuppressFinalize(System.Object)
M25_L26:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2F4],0
       je        short M25_L27
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FFD9ECE8CD8
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FFD9ECE8CF0
       call      00007FFD9ECE8D08
       mov       ecx,eax
       call      00007FFDFE971F40
M25_L27:
       nop
       add       rsp,28
       ret
; Total bytes of code 1157
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-10],0
       jne       short M26_L00
       mov       rcx,7FFD9F493A90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+20]
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD9F2F6EC8]; BenchmarkDotNet.Engines.Consumer.Consume(System.Object)
       nop
       add       rsp,40
       pop       rbp
       ret
M26_L00:
       mov       rcx,7FFD9F493A94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M26_L01
       mov       rax,[rbp-20]
       mov       [rbp-18],rax
       jmp       short M26_L02
M26_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFD9F30F708
       call      qword ptr [7FFD9EF17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M26_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFD9F2F6E80]
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M27_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M27_L00
       test      rbx,rbx
       je        near ptr M27_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M27_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M27_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFDFE9750F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD9ECF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M27_L00:
       test      rbx,rbx
       je        short M27_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M27_L02
M27_L01:
       mov       rax,19CF7080008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M27_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M27_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M27_L04:
       call      qword ptr [7FFD9F384498]
       int       3
; Total bytes of code 235
```

