## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperMoveFileBenchmark.MoveFile()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+198]
       mov       rax,[rbp+10]
       mov       rcx,[rax+1A8]
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF9C1E7E4D8]; DotNetTips.Spargine.IO.FileHelper.MoveFile(System.IO.FileInfo, System.IO.FileInfo, Boolean, Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.MoveFile(System.IO.FileInfo, System.IO.FileInfo, Boolean, Int32)
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		destinationFile = destinationFile.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		retryCount = retryCount.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		ValidateFileCreateDestinationDirectory(file, destinationFile.Directory!);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sourcePath = file.FullName;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var destinationPath = destinationFile.FullName;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var retryIndex = 0; retryIndex < retryCount; retryIndex++)
; 		     ^^^^^^^^^^^^^^^^^^
; 			if (TryMoveFileOnce(sourcePath, destinationPath, replaceExisting))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			if (retryIndex < retryCount - 1)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				Thread.Sleep((retryIndex + 1) * 10);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       dword ptr [rbp-68],3E8
       mov       rax,2AA85960EE8
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FF9C1ECD588
       xor       r8d,r8d
       mov       r9,2AA85950008
       call      qword ptr [7FF9C1DEEDC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rax,2AA85960F08
       mov       [rsp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FF9C1ECD588
       xor       r8d,r8d
       mov       r9,2AA85950008
       call      qword ptr [7FF9C1DEEDC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       ecx,[rbp+28]
       mov       edx,1
       call      qword ptr [7FF9C1E74300]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp+28],eax
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E7E508]; System.IO.FileInfo.get_Directory()
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9C1E7E520]; DotNetTips.Spargine.IO.FileHelper.ValidateFileCreateDestinationDirectory(System.IO.FileInfo, System.IO.DirectoryInfo)
       mov       rax,[rbp+10]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF9C1ECD6B8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-40],rax
       mov       rax,[rbp+18]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FF9C1ECD7C0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-48],rax
       xor       eax,eax
       mov       [rbp-4C],eax
       jmp       near ptr M01_L03
M01_L00:
       movzx     r8d,byte ptr [rbp+20]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF9C1E7E538]; DotNetTips.Spargine.IO.FileHelper.TryMoveFileOnce(System.String, System.String, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,7FF9C1ECD8C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,0A0
       pop       rbp
       ret
M01_L01:
       mov       eax,[rbp+28]
       sub       eax,1
       jo        near ptr M01_L05
       cmp       [rbp-4C],eax
       jge       short M01_L02
       mov       rcx,7FF9C1ECD8CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-4C]
       add       eax,1
       jo        short M01_L05
       imul      ecx,eax,0A
       jo        short M01_L05
       call      qword ptr [7FF9C186F198]; System.Threading.Thread.Sleep(Int32)
M01_L02:
       mov       rcx,7FF9C1ECD8D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-4C]
       add       eax,1
       jo        short M01_L05
       mov       [rbp-4C],eax
M01_L03:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M01_L04
       lea       rcx,[rbp-68]
       mov       edx,6E
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+28]
       jl        near ptr M01_L00
       mov       rcx,7FF9C1ECD8D4
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,0A0
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 519
```

