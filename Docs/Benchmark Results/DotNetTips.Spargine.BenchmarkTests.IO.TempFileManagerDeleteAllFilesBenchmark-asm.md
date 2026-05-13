## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteAllFilesBenchmark.DeleteAllFiles()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6FCAF8]; DotNetTips.Spargine.IO.TempFileManager.DeleteAllFiles()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.DeleteAllFiles()
; 		var snapshot = this._files.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var filesDeletedResult = FileHelper.DeleteFiles(this._files.AsEnumerable().ToReadOnlyCollection());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (filesDeletedResult.Value.Count == snapshot)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._files.Clear();
; 			^^^^^^^^^^^^^^^^^^^^
; 		this.DeleteFilesFromCache(filesDeletedResult.Value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC693DF8]; Precode of System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-4],eax
       mov       rax,[rbp+10]
       mov       rdx,[rax+8]
       mov       rcx,7FFBEC74E318
       call      qword ptr [7FFBEC6FCB70]; System.Linq.Enumerable.AsEnumerable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,7FFBEC74E3C8
       call      qword ptr [7FFBEC455D70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFBEC6FCBD0]; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6FCBE8]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC495F68]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       cmp       eax,[rbp-4]
       jne       short M01_L00
       mov       rcx,7FFBEC8C5860
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6FCC00]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Clear()
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFBEC8C5864
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6FCBE8]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC6FCC18]
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 234
```

