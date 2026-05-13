## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteFileBenchmark.DeleteFile()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+140]
       mov       rax,[rbp+10]
       mov       rcx,[rax+138]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6B5D10]; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.IO.TempFileManager.DeleteFile(System.String)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		if (string.IsNullOrEmpty(fileName))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBEC21F1B0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       je        short M01_L00
       add       rsp,60
       pop       rbp
       ret
; 		var filesDeletedResult = FileHelper.DeleteFiles(new ReadOnlyCollection<string>([fileName]));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       dword ptr [rbp-0C],1
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       edx,[rbp-0C]
       call      qword ptr [7FFBEC5946D8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       r8d,[rbp-0C]
       mov       rdx,[rbp-28]
       mov       rcx,7FFBEC6C6BA0
       call      qword ptr [7FFBEC59FD98]; System.Runtime.InteropServices.CollectionsMarshal.SetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       lea       rcx,[rbp-20]
       mov       r8,[rbp-28]
       mov       rdx,7FFBEC6C6C28
       call      qword ptr [7FFBEC59FDC8]; System.Runtime.InteropServices.CollectionsMarshal.AsSpan[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       cmp       dword ptr [rbp-18],0
       jbe       near ptr M01_L02
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FFBEC42C7C8]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rbp-30]
       xor       edx,edx
       call      qword ptr [7FFBEC6B5DB8]; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
       mov       [rbp-8],rax
; 		if (filesDeletedResult.Value.Count > 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6B5DD0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC465F68]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       test      eax,eax
       jle       short M01_L01
; 			this.DeleteFilesFromCache(filesDeletedResult.Value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6B5DD0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC6B5DE8]; DotNetTips.Spargine.IO.TempFileManager.DeleteFilesFromCache(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>)
M01_L01:
       nop
       add       rsp,60
       pop       rbp
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

