## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteAllFilesBenchmark.DeleteAllFiles()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BE175E8]; DotNetTips.Spargine.IO.TempFileManager.DeleteAllFiles()
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
; 		var snapshot = this._files.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BD85570]; Precode of System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-4],eax
; 		var filesDeletedResult = FileHelper.DeleteFiles(this._files.AsEnumerable().ToReadOnlyCollection());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rdx,[rax+8]
       mov       rcx,7FFB2BE400A8
       call      qword ptr [7FFB2BE17660]; System.Linq.Enumerable.AsEnumerable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,7FFB2BE40158
       call      qword ptr [7FFB2BB75D70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFB2BE176C0]; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
       mov       [rbp-10],rax
; 		if (filesDeletedResult.Value.Count == snapshot)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BE176D8]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BBB5F68]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       cmp       eax,[rbp-4]
       jne       short M01_L00
; 			this._files.Clear();
; 			^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BE176F0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,50
       pop       rbp
       ret
; 		this.DeleteFilesFromCache(filesDeletedResult.Value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2BE176D8]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2BE17708]
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

