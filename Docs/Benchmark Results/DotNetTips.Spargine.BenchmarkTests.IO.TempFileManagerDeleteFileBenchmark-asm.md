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
       call      qword ptr [7FFB3562E5B0]; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		if (string.IsNullOrEmpty(fileName))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       call      qword ptr [7FFB3522F018]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       je        short M01_L00
       add       rsp,20
       pop       rbp
       ret
; 		if (TryDeleteFile(fileName))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFB3562E5C8]; DotNetTips.Spargine.IO.TempFileManager.TryDeleteFile(System.String)
       test      eax,eax
       je        short M01_L01
; 			this.DeleteFileFromCache(fileName);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB3562E5E0]; DotNetTips.Spargine.IO.TempFileManager.DeleteFileFromCache(System.String)
M01_L01:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 73
```

