## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperDeleteFilesBenchmark.DeleteFiles()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+138]
       xor       edx,edx
       call      qword ptr [7FFCDE63E808]; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCDE694628
       call      qword ptr [7FFCDE63E7D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.DeleteFiles(System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>, Boolean)
; 		files = files.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new SimpleResult<ReadOnlyCollection<string>>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var fileCount = files.Count;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var filesDeleted = new List<string>(fileCount);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var fileIndex = 0; fileIndex < fileCount; fileIndex++)
; 		     ^^^^^^^^^^^^^^^^^
; 			if (ProcessFileDeletion(files[fileIndex], result, filesDeleted, stopOnFirstError))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		result.SetValue(new ReadOnlyCollection<string>(filesDeleted));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result;
; 		^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       dword ptr [rbp-78],3E8
       mov       rax,1F69CDA0BE8
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rcx,7FFCDE6946C0
       xor       r8d,r8d
       mov       r9,1F69CD90008
       call      qword ptr [7FFCDE5AF0D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult<System.Collections.ObjectModel.ReadOnlyCollection<System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FFCDE63E838]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE473040]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-44],eax
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp-44]
       call      qword ptr [7FFCDE5A4090]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-68]
       mov       [rbp-50],rax
       xor       eax,eax
       mov       [rbp-54],eax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-54]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE473048]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       movzx     r9d,byte ptr [rbp+18]
       mov       rdx,[rbp-40]
       mov       r8,[rbp-50]
       call      qword ptr [7FFCDE63E850]; DotNetTips.Spargine.IO.FileHelper.ProcessFileDeletion(System.String, DotNetTips.Spargine.Core.SimpleResult`1<System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>>, System.Collections.Generic.List`1<System.String>, Boolean)
       test      eax,eax
       jne       near ptr M01_L04
       mov       rcx,7FFCDE694738
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
       add       eax,1
       jo        near ptr M01_L05
       mov       [rbp-54],eax
M01_L01:
       mov       eax,[rbp-78]
       dec       eax
       mov       [rbp-78],eax
       cmp       dword ptr [rbp-78],0
       jg        short M01_L02
       lea       rcx,[rbp-78]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M01_L02:
       mov       eax,[rbp-54]
       cmp       eax,[rbp-44]
       jl        short M01_L00
M01_L03:
       mov       rcx,7FFCDE69473C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCDE437318]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE63E868]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].SetValue(System.__Canon)
       mov       rax,[rbp-40]
       add       rsp,0B0
       pop       rbp
       ret
M01_L04:
       mov       rcx,7FFCDE694740
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L03
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 417
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
       mov       rdx,7FFCDE67FC70
       call      qword ptr [7FFCDE237B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCDE63EDD8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE63ED90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

