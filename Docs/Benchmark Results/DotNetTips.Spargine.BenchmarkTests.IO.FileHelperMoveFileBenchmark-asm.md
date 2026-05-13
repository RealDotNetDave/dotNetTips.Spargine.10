## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperMoveFileBenchmark.MoveFile()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+138]
       mov       rax,[rbp+10]
       mov       rcx,[rax+148]
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFBEC64E790]; DotNetTips.Spargine.IO.FileHelper.MoveFile(System.IO.FileInfo, System.IO.FileInfo, Boolean, Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.MoveFile(System.IO.FileInfo, System.IO.FileInfo, Boolean, Int32)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       mov       dword ptr [rbp-68],3E8
; 		file = file.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,1E7AE420B50
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFBEC68F4A8
       xor       r8d,r8d
       mov       r9,1E7AE410008
       call      qword ptr [7FFBEC5BF930]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
; 		destinationFile = destinationFile.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,1E7AE420B70
       mov       [rsp+20],rax
       mov       rdx,[rbp+18]
       mov       rcx,7FFBEC68F4A8
       xor       r8d,r8d
       mov       r9,1E7AE410008
       call      qword ptr [7FFBEC5BF930]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		retryCount = retryCount.EnsureMinimum(1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,[rbp+28]
       mov       edx,1
       call      qword ptr [7FFBEC6448E8]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
       mov       [rbp+28],eax
; 		ValidateFileCreateDestinationDirectory(file, destinationFile.Directory!);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC64E7C0]; System.IO.FileInfo.get_Directory()
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC64E7D8]; DotNetTips.Spargine.IO.FileHelper.ValidateFileCreateDestinationDirectory(System.IO.FileInfo, System.IO.DirectoryInfo)
; 		for (var retryIndex = 0; retryIndex < retryCount; retryIndex++)
; 		     ^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       near ptr M01_L02
; 			if (TryMoveFileOnce(file.FullName, destinationFile.FullName, replaceExisting))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rax,[rbp+10]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFBEC68F5F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-50]
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-48],rax
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFBEC68F6F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-78],rax
       mov       rdx,[rbp-78]
       movzx     r8d,byte ptr [rbp+20]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFBEC64E7F0]; DotNetTips.Spargine.IO.FileHelper.TryMoveFileOnce(System.String, System.String, Boolean)
       test      eax,eax
       je        short M01_L01
       mov       rcx,7FFBEC68F800
       call      CORINFO_HELP_COUNTPROFILE32
; 				destinationFile.Refresh();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC64E808]; System.IO.FileSystemInfo.Refresh()
; 				return destinationFile.Exists;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFBEC68F808
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       nop
       add       rsp,0A0
       pop       rbp
       ret
M01_L01:
       mov       rcx,7FFBEC68F910
       call      CORINFO_HELP_COUNTPROFILE32
; 			Thread.Sleep((retryIndex + 1) * 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rbp-3C]
       add       eax,1
       jo        short M01_L04
       imul      ecx,eax,0A
       jo        short M01_L04
       call      qword ptr [7FFBEC247738]; System.Threading.Thread.Sleep(Int32)
       mov       eax,[rbp-3C]
       add       eax,1
       jo        short M01_L04
       mov       [rbp-3C],eax
M01_L02:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M01_L03
       lea       rcx,[rbp-68]
       mov       edx,6F
       call      CORINFO_HELP_PATCHPOINT
M01_L03:
       mov       eax,[rbp-3C]
       cmp       eax,[rbp+28]
       jl        near ptr M01_L00
       mov       rcx,7FFBEC68F914
       call      CORINFO_HELP_COUNTPROFILE32
; 		return false;
; 		^^^^^^^^^^^^^
       xor       eax,eax
       add       rsp,0A0
       pop       rbp
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 543
```

