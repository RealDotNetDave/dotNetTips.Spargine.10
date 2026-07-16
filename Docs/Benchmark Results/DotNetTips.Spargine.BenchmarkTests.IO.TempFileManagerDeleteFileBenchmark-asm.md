## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteFileBenchmark.DeleteFile()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+1A0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+198]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E9EFD0]; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
; 		if (string.IsNullOrEmpty(fileName))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (TryDeleteFile(fileName))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.DeleteFileFromCache(fileName);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C1A8F1F8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       je        short M01_L00
       mov       rcx,7FF9C20D1AD8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C1E9EFE8]; DotNetTips.Spargine.IO.TempFileManager.TryDeleteFile(System.String)
       test      eax,eax
       je        short M01_L01
       mov       rcx,7FF9C20D1ADC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C1E9F000]; DotNetTips.Spargine.IO.TempFileManager.DeleteFileFromCache(System.String)
M01_L01:
       mov       rcx,7FF9C20D1AE0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 119
```

