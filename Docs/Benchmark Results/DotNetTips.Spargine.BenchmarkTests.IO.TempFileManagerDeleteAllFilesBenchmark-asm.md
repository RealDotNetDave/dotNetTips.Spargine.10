## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteAllFilesBenchmark.DeleteAllFiles()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+198]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356A4C48]; DotNetTips.Spargine.IO.TempFileManager.DeleteAllFiles()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.DeleteAllFiles()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
; 		var filesSnapshot = this._files.ToArray();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3563BE30]; Precode of System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       [rbp-8],rax
; 		var fileCount = filesSnapshot.Length;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-8]
       mov       eax,[rax+8]
       mov       [rbp-0C],eax
; 		if (fileCount == 0)
; 		^^^^^^^^^^^^^^^^^^^
       cmp       dword ptr [rbp-0C],0
       jne       short M01_L00
       add       rsp,50
       pop       rbp
       ret
; 		var filesDeletedResult = FileHelper.DeleteFiles(new ReadOnlyCollection<string>(filesSnapshot));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFB354276F0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFB356A4CD8]; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
       mov       [rbp-18],rax
; 		if (filesDeletedResult.Value.Count == fileCount)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356A4CF0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB35464EB8]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       cmp       eax,[rbp-0C]
       jne       short M01_L01
; 			this._files.Clear();
; 			^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356A4D08]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,50
       pop       rbp
       ret
; 		this.DeleteFilesFromCache(filesDeletedResult.Value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356A4CF0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB356A4D20]
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 208
```

