## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC13706268]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC13722818
       mov       r9d,1
       call      qword ptr [7FFC13706208]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC13722930
       call      qword ptr [7FFC13706238]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (condition)
; 			^^^^^^^^^^^^^^
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136F7958
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,22959E7FE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,22959E70008
       call      qword ptr [7FFC13334210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136F7998
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,22959E7BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,22959E70008
       call      qword ptr [7FFC13334210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC138758C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13076238]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFC138758CC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 310
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC136F7B00
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC13706340]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC137062F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135EE5F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC136BED20
       mov       r9d,1
       call      qword ptr [7FFC135EE598]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136BEE38
       call      qword ptr [7FFC135EE5C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (condition)
; 			^^^^^^^^^^^^^^
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136A8CF8
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2E7912CFE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2E7912C0008
       call      qword ptr [7FFC13324210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136A8D38
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2E7912CBC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2E7912C0008
       call      qword ptr [7FFC13324210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC13835108
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13066238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFC1383510C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 310
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC136A8EA0
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135EE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EE688]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135FE5F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC136CED10
       mov       r9d,1
       call      qword ptr [7FFC135FE598]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136CEE28
       call      qword ptr [7FFC135FE5C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (condition)
; 			^^^^^^^^^^^^^^
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136B8CF8
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,273A6C7FE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,273A6C70008
       call      qword ptr [7FFC13334210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136B8D38
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,273A6C7BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,273A6C70008
       call      qword ptr [7FFC13334210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC13800DA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13076238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFC13800DAC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 310
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC136B8EA0
       call      qword ptr [7FFC13147B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135FE6D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135FE688]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135CE610]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC1369ED20
       mov       r9d,1
       call      qword ptr [7FFC135CE5B0]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC1369EE38
       call      qword ptr [7FFC135CE5E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (condition)
; 			^^^^^^^^^^^^^^
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC13688CF8
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1D094C5FE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1D094C50008
       call      qword ptr [7FFC13314210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC13688D38
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,1D094C5BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1D094C50008
       call      qword ptr [7FFC13314210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC137BFEE8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13056238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFC137BFEEC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 310
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC13688EA0
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135CE6E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CE6A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L11
       test      rcx,rcx
       je        near ptr M00_L12
       mov       rdi,rcx
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L13
M00_L00:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L21
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rcx,2220B800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,67E95A16
       mov       r8d,0CEDBCD15
       cmp       edx,8
       jb        near ptr M00_L15
       mov       r10d,edx
       shr       r10d,3
M00_L01:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L01
       test      dl,4
       jne       near ptr M00_L16
M00_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L03:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L04:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L27
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L07
M00_L05:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L27
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L22
M00_L06:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L23
       test      eax,eax
       jge       short M00_L05
M00_L07:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L24
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L25
M00_L08:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L09:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L27
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L26
M00_L10:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L11:
       call      qword ptr [7FFC134B78E8]
       mov       ecx,65
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC13795B60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136ED458]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      qword ptr [7FFC134B78E8]
       mov       ecx,0F
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC13795B60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136ED458]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F1E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L14:
       xor       r13d,r13d
       jmp       near ptr M00_L04
M00_L15:
       cmp       edx,4
       jb        short M00_L17
M00_L16:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L02
M00_L17:
       mov       r10d,80
       test      dl,1
       je        short M00_L18
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L18:
       test      dl,2
       je        short M00_L19
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L20:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E61550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E61558
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFC13137A08]
       int       3
M00_L24:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       mov       ecx,[rsi+2C]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L27
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,rsi
       call      qword ptr [7FFC13795FC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L27
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L08
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L10
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1326DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F1E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1336
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,262A0780008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFC136EC978]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFC137BBB60
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M03_L10
M03_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M03_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M03_L07
       mov       rcx,rax
M03_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M03_L14
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M03_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L15
       cmp       ebp,[r14+8]
       ja        near ptr M03_L15
       cmp       ebp,[rdi+8]
       ja        near ptr M03_L15
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L13
       cmp       r8,4000
       ja        near ptr M03_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M03_L11
M03_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M03_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M03_L08
M03_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L17
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M03_L04
M03_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L07:
       mov       rdx,7FFC137BBB60
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L08:
       cmp       ecx,edx
       jae       near ptr M03_L17
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M03_L09
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M03_L17
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M03_L09:
       inc       ecx
       cmp       ecx,ebp
       jl        short M03_L08
       jmp       near ptr M03_L06
M03_L10:
       cmp       ecx,7FFFFFC3
       jge       near ptr M03_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M03_L01
M03_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L03
M03_L12:
       mov       rcx,rax
       call      qword ptr [7FFC135E4C60]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L14:
       xor       r15d,r15d
       jmp       short M03_L16
M03_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134BEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L03
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 654
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M05_L06
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M05_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M05_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L13
       cmp       r14d,[r15+8]
       ja        near ptr M05_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M05_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L11
       cmp       r8,4000
       ja        near ptr M05_L10
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M05_L09
M05_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L15
M05_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M05_L07
M05_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L03
M05_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M05_L06:
       mov       rdx,7FFC137BBB60
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       cmp       ecx,r13d
       jae       near ptr M05_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L08
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L07
       jmp       near ptr M05_L05
M05_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L10:
       mov       rcx,rax
       call      qword ptr [7FFC135E4C60]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       xor       r13d,r13d
       jmp       short M05_L14
M05_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134BEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M05_L16
       jmp       short M05_L17
M05_L16:
       mov       rdx,7FFC137BBB78
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M05_L17:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L02
M05_L18:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M05_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M05_L23
       cmp       qword ptr [r13],0
       jne       short M05_L19
       xor       r12d,r12d
       jmp       short M05_L22
M05_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M05_L20
       jmp       short M05_L21
M05_L20:
       mov       rdx,7FFC13726DB0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M05_L22:
       mov       [r13+8],r12d
M05_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L18
       jmp       near ptr M05_L02
M05_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 865
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M06_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L08
M06_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M06_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M06_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M06_L12
M06_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M06_L10
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M06_L09
M06_L02:
       mov       r15d,eax
M06_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M06_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M06_L07
M06_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M06_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M06_L14
M06_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M06_L17
       test      r13d,r13d
       jge       short M06_L05
M06_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L08:
       mov       rdx,7FFC13726DB0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M06_L02
M06_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M06_L03
M06_L11:
       xor       r15d,r15d
       jmp       near ptr M06_L04
M06_L12:
       xor       r15d,r15d
       jmp       near ptr M06_L03
M06_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M06_L04
M06_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rdx,7FFC13726DC8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L17:
       call      qword ptr [7FFC13137A08]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L13
       test      rcx,rcx
       je        near ptr M00_L14
       mov       rdi,rcx
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L15
M00_L00:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L21
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rcx,1F59B400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,85BF310C
       mov       r8d,649C75A6
       cmp       edx,8
       jb        near ptr M00_L11
       mov       r10d,edx
       shr       r10d,3
M00_L01:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L01
       test      dl,4
       jne       near ptr M00_L12
M00_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L03:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L04:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L27
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L07
M00_L05:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L27
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L22
M00_L06:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L23
       test      eax,eax
       jge       short M00_L05
M00_L07:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L24
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L25
M00_L08:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L09:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L27
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L26
M00_L10:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L11:
       cmp       edx,4
       jb        near ptr M00_L17
M00_L12:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L02
M00_L13:
       call      qword ptr [7FFC134C7900]
       mov       ecx,65
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137A5A70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FD620]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFC134C7900]
       mov       ecx,0F
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137A5A70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FD620]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F2E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L16:
       xor       r13d,r13d
       jmp       near ptr M00_L04
M00_L17:
       mov       r10d,80
       test      dl,1
       je        short M00_L18
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L18:
       test      dl,2
       je        short M00_L19
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L20:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E71358
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E71360
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFC13147A08]
       int       3
M00_L24:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L27
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,rsi
       call      qword ptr [7FFC137A5E60]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L27
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L08
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L10
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1327DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F2E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1339
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,236302B0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFC136FC960]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFC137CBD50
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M03_L12
M03_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M03_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M03_L08
       mov       rcx,rax
M03_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M03_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M03_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L17
       cmp       ebp,[r14+8]
       ja        near ptr M03_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M03_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L15
       cmp       r8,4000
       ja        near ptr M03_L14
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M03_L13
M03_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M03_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M03_L11
       jmp       short M03_L06
M03_L04:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M03_L07
M03_L06:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L05
       jmp       short M03_L04
M03_L07:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L08:
       mov       rdx,7FFC137CBD50
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L09:
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M03_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M03_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M03_L07
M03_L11:
       cmp       ecx,edx
       jae       near ptr M03_L19
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M03_L10
       jmp       short M03_L09
M03_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M03_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M03_L01
M03_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,rax
       call      qword ptr [7FFC135F4C78]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L15:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L16:
       xor       r15d,r15d
       jmp       short M03_L18
M03_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134CEEE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L03
M03_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M05_L07
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M05_L14
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M05_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L15
       cmp       r14d,[r15+8]
       ja        near ptr M05_L15
       cmp       r14d,[rbp+8]
       ja        near ptr M05_L15
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L13
       cmp       r8,4000
       ja        near ptr M05_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M05_L11
M05_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L17
M05_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L06
       nop       dword ptr [rax]
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M05_L10
       jmp       short M05_L05
       xchg      ax,ax
M05_L03:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L26
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L04:
       inc       ecx
       cmp       ecx,r14d
       jge       short M05_L06
M05_L05:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L04
       jmp       short M05_L03
M05_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M05_L07:
       mov       rdx,7FFC137CBD50
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L26
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L09:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M05_L06
M05_L10:
       cmp       ecx,r13d
       jae       near ptr M05_L26
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L09
       jmp       short M05_L08
M05_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFC135F4C78]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L14:
       xor       r13d,r13d
       jmp       short M05_L16
M05_L15:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L16:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134CEEE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L17:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M05_L18
       jmp       short M05_L19
M05_L18:
       mov       rdx,7FFC137CBD68
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M05_L19:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L02
M05_L20:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M05_L26
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M05_L25
       cmp       qword ptr [r13],0
       jne       short M05_L21
       xor       r12d,r12d
       jmp       short M05_L24
M05_L21:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M05_L22
       jmp       short M05_L23
M05_L22:
       mov       rdx,7FFC13737490
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L23:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M05_L24:
       mov       [r13+8],r12d
M05_L25:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L20
       jmp       near ptr M05_L02
M05_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M06_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L07
M06_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M06_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M06_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M06_L12
M06_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M06_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M06_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M06_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M06_L06
M06_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M06_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M06_L14
M06_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M06_L17
       test      r13d,r13d
       jge       short M06_L04
M06_L06:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L07:
       mov       rdx,7FFC13737490
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L08:
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        short M06_L10
       mov       r15d,eax
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       rcx,r15
       call      qword ptr [7FFC12F2E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M06_L09
M06_L11:
       xor       r15d,r15d
       jmp       near ptr M06_L03
M06_L12:
       xor       r15d,r15d
       jmp       near ptr M06_L02
M06_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M06_L03
M06_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rdx,7FFC137374A8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L05
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L17:
       call      qword ptr [7FFC13147A08]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L11
       test      rcx,rcx
       je        near ptr M00_L12
       mov       rdi,rcx
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L13
M00_L00:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L21
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rcx,209AE000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,57365891
       mov       r8d,0AB6D4C54
       cmp       edx,8
       jb        near ptr M00_L15
       mov       r10d,edx
       shr       r10d,3
M00_L01:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L01
       test      dl,4
       jne       near ptr M00_L16
M00_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L03:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L04:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L27
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L07
M00_L05:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L27
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L22
M00_L06:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L23
       test      eax,eax
       jge       short M00_L05
M00_L07:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L24
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L25
M00_L08:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L09:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L27
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L26
M00_L10:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L11:
       call      qword ptr [7FFC134B7900]
       mov       ecx,65
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1370ED18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1370ED30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      qword ptr [7FFC134B7900]
       mov       ecx,0F
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330910
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1370ED18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1370ED30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F1E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L14:
       xor       r13d,r13d
       jmp       near ptr M00_L04
M00_L15:
       cmp       edx,4
       jb        short M00_L17
M00_L16:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L02
M00_L17:
       mov       r10d,80
       test      dl,1
       je        short M00_L18
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L18:
       test      dl,2
       je        short M00_L19
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,r10d
       jmp       near ptr M00_L03
M00_L20:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L21:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E61658
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E61660
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFC13137A08]
       int       3
M00_L24:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L27
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,rsi
       call      qword ptr [7FFC137B6E38]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L27
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L08
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L10
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1326DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F1E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1335
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,24A42FA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFC1370FB58]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFC13814298
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M03_L12
M03_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M03_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M03_L08
       mov       rcx,rax
M03_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M03_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M03_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L17
       cmp       ebp,[r14+8]
       ja        near ptr M03_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M03_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L15
       cmp       r8,4000
       ja        near ptr M03_L14
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M03_L13
M03_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M03_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M03_L11
       jmp       short M03_L06
M03_L04:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M03_L07
M03_L06:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L05
       jmp       short M03_L04
M03_L07:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L08:
       mov       rdx,7FFC13814298
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L09:
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M03_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M03_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M03_L07
M03_L11:
       cmp       ecx,edx
       jae       near ptr M03_L19
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M03_L10
       jmp       short M03_L09
M03_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M03_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M03_L01
M03_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L03
M03_L14:
       mov       rcx,rax
       call      qword ptr [7FFC134BF6A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L15:
       mov       rcx,rax
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L16:
       xor       r15d,r15d
       jmp       short M03_L18
M03_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134BEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L03
M03_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M05_L07
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M05_L14
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M05_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L15
       cmp       r14d,[r15+8]
       ja        near ptr M05_L15
       cmp       r14d,[rbp+8]
       ja        near ptr M05_L15
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L13
       cmp       r8,4000
       ja        near ptr M05_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M05_L11
M05_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L17
M05_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L06
       nop       dword ptr [rax]
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M05_L10
       jmp       short M05_L05
       xchg      ax,ax
M05_L03:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L26
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L04:
       inc       ecx
       cmp       ecx,r14d
       jge       short M05_L06
M05_L05:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L04
       jmp       short M05_L03
M05_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M05_L07:
       mov       rdx,7FFC13814298
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L26
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L09:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M05_L06
M05_L10:
       cmp       ecx,r13d
       jae       near ptr M05_L26
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L09
       jmp       short M05_L08
M05_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFC134BF6A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L14:
       xor       r13d,r13d
       jmp       short M05_L16
M05_L15:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L16:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134BEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134BEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L17:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M05_L18
       jmp       short M05_L19
M05_L18:
       mov       rdx,7FFC138142B0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M05_L19:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L02
M05_L20:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M05_L26
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M05_L25
       cmp       qword ptr [r13],0
       jne       short M05_L21
       xor       r12d,r12d
       jmp       short M05_L24
M05_L21:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M05_L22
       jmp       short M05_L23
M05_L22:
       mov       rdx,7FFC1379F340
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L23:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M05_L24:
       mov       [r13+8],r12d
M05_L25:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L20
       jmp       near ptr M05_L02
M05_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M06_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M06_L07
M06_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M06_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M06_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M06_L12
M06_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M06_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M06_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M06_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M06_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M06_L06
M06_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M06_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M06_L14
M06_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M06_L17
       test      r13d,r13d
       jge       short M06_L04
M06_L06:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L07:
       mov       rdx,7FFC1379F340
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L08:
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        short M06_L10
       mov       r15d,eax
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       rcx,r15
       call      qword ptr [7FFC12F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M06_L09
M06_L11:
       xor       r15d,r15d
       jmp       near ptr M06_L03
M06_L12:
       xor       r15d,r15d
       jmp       near ptr M06_L02
M06_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M06_L03
M06_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rdx,7FFC1379F358
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L05
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L17:
       call      qword ptr [7FFC13137A08]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.AddIf()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rcx,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L09
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdi,rcx
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L11
M00_L00:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L12
       mov       r13,[rdi+28]
       test      r13,r13
       je        short M00_L01
       mov       ecx,4
       call      qword ptr [7FFC137364D8]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
M00_L02:
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L18
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L05
M00_L03:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L18
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L13
M00_L04:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L14
       test      eax,eax
       jge       short M00_L03
M00_L05:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L15
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L16
M00_L06:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L07:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L18
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L17
M00_L08:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L09:
       call      qword ptr [7FFC134C7900]
       mov       ecx,65
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135FEEF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135FEF10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      qword ptr [7FFC134C7900]
       mov       ecx,0F
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135FEEF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135FEF10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F2E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E717E8
       call      qword ptr [r11]
       jmp       near ptr M00_L02
M00_L13:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E717F0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L08
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFC13147A08]
       int       3
M00_L15:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L18
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L07
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFC137D6700]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L18
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L06
M00_L17:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L08
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1327DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F2E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L08
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 984
```
```assembly
; System.StringComparer.FromComparison(System.StringComparison)
       push      rsi
       push      rbx
       sub       rsp,28
M01_L00:
       cmp       ecx,4
       jne       short M01_L02
       mov       rax,1E549400068
       mov       rax,[rax]
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       cmp       ecx,5
       ja        short M01_L03
       mov       ecx,ecx
       lea       rax,[7FFC13805E10]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L00]
       add       rax,rdx
       jmp       rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC137D6670]
       mov       rsi,rax
       mov       ecx,0B55
       mov       rdx,7FFC12E64000
       call      qword ptr [7FFC13147798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC13277EE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC13145DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rsi,[rax]
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       rsi,rcx
       jne       short M01_L04
       mov       rcx,rax
       call      qword ptr [7FFC13046548]; System.Globalization.CultureInfo.get_CompareInfo()
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       mov       rax,[rsi+48]
       call      qword ptr [rax+30]
M01_L05:
       mov       rcx,rbx
       mov       rdx,rax
       xor       r8d,r8d
       call      qword ptr [7FFC1327DCE0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rax,rbx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC13145DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFC1327DCE0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rax,rbx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.CultureAwareComparer
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E55F400BF8
       mov       rax,[rcx]
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.CultureAwareComparer
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E55F400C00
       mov       rax,[rcx]
       jmp       near ptr M01_L01
       mov       rcx,1E549400070
       mov       rax,[rcx]
       jmp       near ptr M01_L01
; Total bytes of code 365
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,225DE1E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFC1373FA38]
       int       3
; Total bytes of code 231
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFC138A5CA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M04_L13
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M04_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M04_L08
       mov       rcx,rax
M04_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M04_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M04_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L17
       cmp       ebp,[r14+8]
       ja        near ptr M04_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M04_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L09
       cmp       r8,4000
       ja        near ptr M04_L15
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M04_L14
M04_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L12
       jmp       short M04_L06
M04_L04:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L07
M04_L06:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L08:
       mov       rdx,7FFC138A5CA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L10:
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M04_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M04_L11:
       inc       ecx
       cmp       ecx,ebp
       jge       near ptr M04_L07
M04_L12:
       cmp       ecx,edx
       jae       near ptr M04_L19
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L11
       jmp       short M04_L10
M04_L13:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L14:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L15:
       mov       rcx,rax
       call      qword ptr [7FFC134CF6A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L16:
       xor       r15d,r15d
       jmp       short M04_L18
M04_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134CEEB0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134CEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134CEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 659
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
M05_L02:
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       jne       short M05_L04
M05_L03:
       xor       edx,edx
       jmp       short M05_L00
M05_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       jmp       short M05_L02
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L07
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M06_L14
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M06_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L15
       cmp       r14d,[r15+8]
       ja        near ptr M06_L15
       cmp       r14d,[rbp+8]
       ja        near ptr M06_L15
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L08
       cmp       r8,4000
       ja        near ptr M06_L13
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M06_L12
M06_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L17
M06_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L06
       nop       dword ptr [rax]
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M06_L11
       jmp       short M06_L05
       xchg      ax,ax
M06_L03:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L26
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L04:
       inc       ecx
       cmp       ecx,r14d
       jge       short M06_L06
M06_L05:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L04
       jmp       short M06_L03
M06_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L07:
       mov       rdx,7FFC138A5CA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L09:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L26
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L10:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M06_L06
M06_L11:
       cmp       ecx,r13d
       jae       near ptr M06_L26
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L10
       jmp       short M06_L09
M06_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L13:
       mov       rcx,rax
       call      qword ptr [7FFC134CF6A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L14:
       xor       r13d,r13d
       jmp       short M06_L16
M06_L15:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134CEEB0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L16:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134CEEB0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134CEEC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L01
M06_L17:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M06_L18
       jmp       short M06_L19
M06_L18:
       mov       rdx,7FFC138A5CC0
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M06_L19:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L02
M06_L20:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M06_L26
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L25
       cmp       qword ptr [r13],0
       jne       short M06_L21
       xor       r12d,r12d
       jmp       short M06_L24
M06_L21:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L22
       jmp       short M06_L23
M06_L22:
       mov       rdx,7FFC13861FD0
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L23:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M06_L24:
       mov       [r13+8],r12d
M06_L25:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L20
       jmp       near ptr M06_L02
M06_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L08:
       mov       rdx,7FFC13861FD0
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12F2E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFC13861FE8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L17:
       call      qword ptr [7FFC13147A08]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135CE5C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC1369ED20
       call      qword ptr [7FFC135CE568]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC1369EE38
       call      qword ptr [7FFC135CE598]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (collection.Contains(item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = collection.Remove(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC13688CF8
       call      qword ptr [7FFC13117B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1D15332FE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1D153320008
       call      qword ptr [7FFC13304210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC13688D38
       call      qword ptr [7FFC13117B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,1D15332BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1D153320008
       call      qword ptr [7FFC13304210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC130461F8]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC13823D68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13046200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M02_L04:
       mov       rcx,7FFC13823D6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13046238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 334
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC13688E98
       call      qword ptr [7FFC13117B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC135CE6B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CE670]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC136D5A10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC136FFC78
       call      qword ptr [7FFC136D59B0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136FFD90
       call      qword ptr [7FFC136D59E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (collection.Contains(item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = collection.Remove(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136E92C0
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,15FC8B8FE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,15FC8B80008
       call      qword ptr [7FFC13324210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136E9300
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,15FC8B8BC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,15FC8B80008
       call      qword ptr [7FFC13324210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC130661F8]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC13861F70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13066200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M02_L04:
       mov       rcx,7FFC13861F74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13066238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 334
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC136E9460
       call      qword ptr [7FFC13137B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC136D5B00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D5AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E8]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC136C58A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFC136EEBA0
       call      qword ptr [7FFC136C5848]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+2E8]
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136EECB8
       call      qword ptr [7FFC136C5878]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+50]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (collection.Contains(item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = collection.Remove(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = collection.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M02_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136D8CF8
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,220230CFE48
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,220230C0008
       call      qword ptr [7FFC13314210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M02_L02
       mov       rax,[rbp-30]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFC136D8D38
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,220230CBC40
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,220230C0008
       call      qword ptr [7FFC13314210]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC130561F8]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFC137F81F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13056200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M02_L04:
       mov       rcx,7FFC137F81FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC13056238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 334
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFC136D8E98
       call      qword ptr [7FFC13127B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC136C5998]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136C5950]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rdi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L12
       test      rdi,rdi
       je        near ptr M00_L13
       mov       rdx,rdi
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       r11,7FFC12E816C8
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L02
M00_L00:
       mov       r12d,[rbp+8]
       cmp       eax,r12d
       jae       near ptr M00_L15
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+30],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L14
M00_L01:
       mov       eax,[rax+0C]
       inc       r14d
       cmp       r12d,r14d
       jb        near ptr M00_L11
       test      eax,eax
       jge       short M00_L00
M00_L02:
       cmp       qword ptr [rsi+8],0
       jne       short M00_L03
       xor       ecx,ecx
       call      qword ptr [7FFC12F35A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       ebp,eax
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,ebp
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M00_L03:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E816D8
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L06
M00_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L15
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       jne       short M00_L05
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E816E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
M00_L05:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L11
       test      eax,eax
       jge       short M00_L04
M00_L06:
       cmp       dword ptr [rsi+30],0
       jg        short M00_L08
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       jne       short M00_L07
       mov       ecx,[rsi+28]
       call      qword ptr [7FFC130A5020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC1328DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L15
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M00_L07:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,ebp
       mov       rbp,rcx
       jmp       short M00_L09
M00_L08:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L15
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
M00_L09:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L15
       mov       [rsp+40],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[rbp+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+40]
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       jbe       short M00_L10
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L10
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1328DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F3E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M00_L10:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L11:
       call      qword ptr [7FFC13157A08]
       int       3
M00_L12:
       call      qword ptr [7FFC134DF660]
       mov       ecx,65
       mov       rdx,7FFC13350910
       call      qword ptr [7FFC13157798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC13204F28
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13350910
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1371D800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1371D818]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFC134DF660]
       mov       ecx,0F
       mov       rdx,7FFC13350910
       call      qword ptr [7FFC13157798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC13204F28
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13350910
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1371D800]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1371D818]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFC12E816D0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+30]
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC13086200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1195
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M01_L02
       mov       rcx,7FFC71D11660
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M01_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M01_L01
       add       rax,4
       dec       edx
       jne       short M01_L00
       jmp       short M01_L03
M01_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC1371E850]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC13285FF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M01_L06
M01_L04:
       mov       ecx,esi
       call      qword ptr [7FFC1371E868]
       test      eax,eax
       je        short M01_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M01_L07
M01_L05:
       add       esi,2
M01_L06:
       cmp       esi,7FFFFFFF
       jl        short M01_L04
       jmp       short M01_L08
M01_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M02_L01
M02_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFC12F35A88]; System.Collections.HashHelpers.GetPrime(Int32)
M02_L01:
       cmp       ecx,7FFFFFC3
       jge       short M02_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M03_L06
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M03_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M03_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L13
       cmp       r14d,[r15+8]
       ja        near ptr M03_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M03_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L11
       cmp       r8,4000
       ja        near ptr M03_L10
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M03_L09
M03_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M03_L15
M03_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M03_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M03_L07
M03_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L03
M03_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M03_L06:
       mov       rdx,7FFC137EDD08
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L00
M03_L07:
       cmp       ecx,r13d
       jae       near ptr M03_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L08
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L07
       jmp       near ptr M03_L05
M03_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,rax
       call      qword ptr [7FFC134DF078]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L01
M03_L11:
       mov       rcx,rax
       call      qword ptr [7FFC12F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L01
M03_L12:
       xor       r13d,r13d
       jmp       short M03_L14
M03_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC13566BF8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC13566BF8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC13566C10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rdx,7FFC137EDD20
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L17:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M03_L02
M03_L18:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M03_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M03_L23
       cmp       qword ptr [r13],0
       jne       short M03_L19
       xor       r12d,r12d
       jmp       short M03_L22
M03_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFC13790238
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M03_L22:
       mov       [r13+8],r12d
M03_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M03_L18
       jmp       near ptr M03_L02
M03_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 865
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M05_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L08
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L10
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M05_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M05_L12
M05_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M05_L13
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M05_L09
M05_L02:
       mov       r15d,eax
M05_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M05_L07
M05_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L05
M05_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L08:
       mov       rdx,7FFC13790238
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12F3E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M05_L04
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L13:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M05_L03
M05_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L15
       jmp       short M05_L16
M05_L15:
       mov       rdx,7FFC13790250
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L17:
       call      qword ptr [7FFC13157A08]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
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
       je        near ptr M06_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L00
       test      rbx,rbx
       je        near ptr M06_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M06_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       test      rbx,rbx
       je        short M06_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L02
M06_L01:
       mov       rax,2B1F2510008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFC1371F348]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rdi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L14
       test      rdi,rdi
       je        near ptr M00_L15
       mov       rdx,rdi
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       r11,7FFC12E51438
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L02
M00_L00:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M00_L16
M00_L01:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       [rbp+8],r14d
       jb        near ptr M00_L27
       test      eax,eax
       jge       short M00_L00
M00_L02:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L17
M00_L03:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L25
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L18
       mov       rcx,240CD800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C1BB1B5
       mov       r8d,2FA1F7FD
       cmp       edx,8
       jb        near ptr M00_L19
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L20
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L07:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M00_L12
M00_L08:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L28
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L29
M00_L09:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L10:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L31
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L30
M00_L11:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+90]
       lea       r8,[rsp+38]
       mov       rdx,7FFC136F13B0
       cmp       [rcx],ecx
       call      qword ptr [7FFC136C5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L26
M00_L13:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L27
       test      eax,eax
       jge       short M00_L12
       jmp       near ptr M00_L08
M00_L14:
       call      qword ptr [7FFC134AED90]
       mov       ecx,65
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC13796400]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CF078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFC134AED90]
       mov       ecx,0F
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC13796400]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CF078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFC12E51440
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC13056200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F0E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L03
M00_L18:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L19:
       cmp       edx,4
       jb        short M00_L21
M00_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L21:
       mov       r10d,80
       test      dl,1
       je        short M00_L22
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L22:
       test      dl,2
       je        short M00_L23
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L23:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L24:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E51448
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E51450
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L11
       jmp       near ptr M00_L13
M00_L27:
       call      qword ptr [7FFC13127A08]
       int       3
M00_L28:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       mov       ecx,[rsi+2C]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L31
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L10
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFC13796BF8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L31
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L09
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L11
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1325DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F0E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L11
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1541
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,28162820008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFC136CF648]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFC137D33C8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M04_L10
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M04_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M04_L07
       mov       rcx,rax
M04_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M04_L14
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       cmp       ebp,[r14+8]
       ja        near ptr M04_L15
       cmp       ebp,[rdi+8]
       ja        near ptr M04_L15
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L13
       cmp       r8,4000
       ja        near ptr M04_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M04_L11
M04_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L08
M04_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L17
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L04
M04_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       rdx,7FFC137D33C8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L08:
       cmp       ecx,edx
       jae       near ptr M04_L17
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L09
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M04_L17
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M04_L09:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L08
       jmp       near ptr M04_L06
M04_L10:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L12:
       mov       rcx,rax
       call      qword ptr [7FFC135EC0F0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC13516340]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC13516340]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC13516358]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 654
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L06
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M06_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M06_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L13
       cmp       r14d,[r15+8]
       ja        near ptr M06_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M06_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L11
       cmp       r8,4000
       ja        near ptr M06_L10
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M06_L09
M06_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L15
M06_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M06_L07
M06_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L03
M06_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L06:
       mov       rdx,7FFC137D33C8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L07:
       cmp       ecx,r13d
       jae       near ptr M06_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L08
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L07
       jmp       near ptr M06_L05
M06_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L10:
       mov       rcx,rax
       call      qword ptr [7FFC135EC0F0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       xor       r13d,r13d
       jmp       short M06_L14
M06_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC13516340]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC13516340]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC13516358]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L01
M06_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M06_L16
       jmp       short M06_L17
M06_L16:
       mov       rdx,7FFC137D33E0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M06_L17:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L02
M06_L18:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M06_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L23
       cmp       qword ptr [r13],0
       jne       short M06_L19
       xor       r12d,r12d
       jmp       short M06_L22
M06_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L20
       jmp       short M06_L21
M06_L20:
       mov       rdx,7FFC13765CB0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M06_L22:
       mov       [r13+8],r12d
M06_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L18
       jmp       near ptr M06_L02
M06_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 865
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L10
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L13
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L08:
       mov       rdx,7FFC13765CB0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFC13765CC8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L17:
       call      qword ptr [7FFC13127A08]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rdi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L14
       test      rdi,rdi
       je        near ptr M00_L15
       mov       rdx,rdi
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       r11,7FFC12E71528
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L02
M00_L00:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M00_L16
M00_L01:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       [rbp+8],r14d
       jb        near ptr M00_L27
       test      eax,eax
       jge       short M00_L00
M00_L02:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L17
M00_L03:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L25
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L18
       mov       rcx,17D23000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1846558A
       mov       r8d,745A3803
       cmp       edx,8
       jb        near ptr M00_L19
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L20
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L07:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L10
M00_L08:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L26
M00_L09:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L27
       test      eax,eax
       jge       short M00_L08
M00_L10:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L28
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L29
M00_L11:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L12:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L31
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L30
M00_L13:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+90]
       lea       r8,[rsp+38]
       mov       rdx,7FFC136D01D8
       cmp       [rcx],ecx
       call      qword ptr [7FFC135FE5C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L14:
       call      qword ptr [7FFC134C7900]
       mov       ecx,65
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137A5B78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFC134C7900]
       mov       ecx,0F
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340910
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137A5B78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFC12E71530
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC13076200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F2E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L03
M00_L18:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L19:
       cmp       edx,4
       jb        short M00_L21
M00_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L21:
       mov       r10d,80
       test      dl,1
       je        short M00_L22
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L22:
       test      dl,2
       je        short M00_L23
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L23:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L24:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E71538
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E71540
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L27:
       call      qword ptr [7FFC13147A08]
       int       3
M00_L28:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L31
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L12
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFC137A5EA8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L31
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L11
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1327DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F2E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1531
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,1BDB8040008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFC136FC990]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFC137CCCD8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M04_L10
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M04_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M04_L07
       mov       rcx,rax
M04_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M04_L14
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       cmp       ebp,[r14+8]
       ja        near ptr M04_L15
       cmp       ebp,[rdi+8]
       ja        near ptr M04_L15
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L13
       cmp       r8,4000
       ja        near ptr M04_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M04_L11
M04_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L09
M04_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L17
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L04
M04_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       rdx,7FFC137CCCD8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L08:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L06
M04_L09:
       cmp       ecx,edx
       jae       near ptr M04_L17
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L08
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M04_L17
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
       jmp       short M04_L08
M04_L10:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L12:
       mov       rcx,rax
       call      qword ptr [7FFC135F4C78]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134CEEE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 651
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L06
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M06_L13
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M06_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L14
       cmp       r14d,[r15+8]
       ja        near ptr M06_L14
       cmp       r14d,[rbp+8]
       ja        near ptr M06_L14
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L12
       cmp       r8,4000
       ja        near ptr M06_L11
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M06_L10
M06_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L16
M06_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M06_L09
M06_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L25
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L03
M06_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L06:
       mov       rdx,7FFC137CCCD8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L07:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L25
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L08:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M06_L05
M06_L09:
       cmp       ecx,r13d
       jae       near ptr M06_L25
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L08
       jmp       short M06_L07
M06_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFC135F4C78]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       mov       rcx,rax
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L13:
       xor       r13d,r13d
       jmp       short M06_L15
M06_L14:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L15:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134CEEC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134CEEE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L01
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC137CCCF0
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M06_L18:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L02
M06_L19:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M06_L25
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L24
       cmp       qword ptr [r13],0
       jne       short M06_L20
       xor       r12d,r12d
       jmp       short M06_L23
M06_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rdx,7FFC13737350
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L22:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M06_L23:
       mov       [r13+8],r12d
M06_L24:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L19
       jmp       near ptr M06_L02
M06_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 866
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L12
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L07
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L11
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L13
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M07_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M07_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L03:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L06
M07_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L07:
       mov       rdx,7FFC13737350
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FFC12F2E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M07_L09
M07_L11:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       xor       r15d,r15d
       jmp       near ptr M07_L02
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFC13737368
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L17:
       call      qword ptr [7FFC13147A08]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rdi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L15
       test      rdi,rdi
       je        near ptr M00_L16
       mov       rdx,rdi
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       r11,7FFC12E51418
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L02
M00_L00:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M00_L17
M00_L01:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       [rbp+8],r14d
       jb        near ptr M00_L28
       test      eax,eax
       jge       short M00_L00
M00_L02:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L18
M00_L03:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L26
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L19
       mov       rcx,1DA96000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L25
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F48E7699
       mov       r8d,647E5AC4
       cmp       edx,8
       jb        near ptr M00_L20
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L21
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L07:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L10
M00_L08:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L27
M00_L09:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L28
       test      eax,eax
       jge       short M00_L08
M00_L10:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L14
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L29
M00_L11:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L12:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L31
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L30
M00_L13:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+90]
       lea       r8,[rsp+38]
       mov       rdx,7FFC136F38E0
       cmp       [rcx],ecx
       call      qword ptr [7FFC136C6DF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L14:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L31
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L12
M00_L15:
       call      qword ptr [7FFC134A78E8]
       mov       ecx,65
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CEE20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CEE38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       call      qword ptr [7FFC134A78E8]
       mov       ecx,0F
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320910
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CEE20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CEE38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFC12E51420
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC13056200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L18:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12F0E8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L03
M00_L19:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L20:
       cmp       edx,4
       jb        short M00_L22
M00_L21:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L22:
       mov       r10d,80
       test      dl,1
       je        short M00_L23
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L23:
       test      dl,2
       je        short M00_L24
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L24:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E51428
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L27:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E51430
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L28:
       call      qword ptr [7FFC13127A08]
       int       3
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFC137A6790]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L31
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L11
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1325DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12F0E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1531
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,21B2B120008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFC136CEFA0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12F05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFC137D8E10
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M04_L11
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12F05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M04_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M04_L07
       mov       rcx,rax
M04_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M04_L15
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M04_L16
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L16
       cmp       ebp,[r14+8]
       ja        near ptr M04_L16
       cmp       ebp,[rdi+8]
       ja        near ptr M04_L16
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L14
       cmp       r8,4000
       ja        near ptr M04_L13
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M04_L12
M04_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L10
M04_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L18
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L04
M04_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       rdx,7FFC137D8E10
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L08:
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M04_L18
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M04_L09:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L06
M04_L10:
       cmp       ecx,edx
       jae       near ptr M04_L18
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L09
       jmp       short M04_L08
M04_L11:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFC134AF6D8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       mov       rcx,rax
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L15:
       xor       r15d,r15d
       jmp       short M04_L17
M04_L16:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC134AEEE0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L17:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC134AEEE0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC134AEEF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 651
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L06
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M06_L13
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M06_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L14
       cmp       r14d,[r15+8]
       ja        near ptr M06_L14
       cmp       r14d,[rbp+8]
       ja        near ptr M06_L14
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L12
       cmp       r8,4000
       ja        near ptr M06_L11
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M06_L10
M06_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L16
M06_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M06_L09
M06_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L25
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L03
M06_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L06:
       mov       rdx,7FFC137D8E10
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L07:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L25
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L08:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M06_L05
M06_L09:
       cmp       ecx,r13d
       jae       near ptr M06_L25
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L08
       jmp       short M06_L07
M06_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFC134AF6D8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       mov       rcx,rax
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L13:
       xor       r13d,r13d
       jmp       short M06_L15
M06_L14:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC134AEEE0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L15:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC134AEEE0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC134AEEF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L01
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC137D8E28
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M06_L18:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L02
M06_L19:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M06_L25
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L24
       cmp       qword ptr [r13],0
       jne       short M06_L20
       xor       r12d,r12d
       jmp       short M06_L23
M06_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rdx,7FFC137831F0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L22:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M06_L23:
       mov       [r13+8],r12d
M06_L24:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L19
       jmp       near ptr M06_L02
M06_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 866
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L12
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L11
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L13
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L08:
       mov       rdx,7FFC137831F0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L13:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFC13783208
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L17:
       call      qword ptr [7FFC13127A08]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsMutatingCollectionBenchmark.Upsert()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       mov       rdi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L17
       test      rdi,rdi
       je        near ptr M00_L18
       mov       rdx,rdi
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L02
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       r11,7FFC12E41678
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L02
M00_L00:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M00_L19
M00_L01:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       [rbp+8],r14d
       jb        near ptr M00_L28
       test      eax,eax
       jge       short M00_L00
M00_L02:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L20
M00_L03:
       mov       rbp,[rsi+10]
       mov       r14,[rsi+18]
       xor       r15d,r15d
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L26
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L21
       mov       rcx,1EB11000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L25
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9F63BBD3
       mov       r8d,6EE3FF1
       cmp       edx,8
       jb        near ptr M00_L14
       mov       r10d,edx
       shr       r10d,3
M00_L04:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L15
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L07:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,ecx
       lea       r12,[rdx+rcx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M00_L10
M00_L08:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L31
       mov       edx,eax
       shl       rdx,4
       lea       rax,[rbp+rdx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r13d
       je        near ptr M00_L27
M00_L09:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M00_L28
       test      eax,eax
       jge       short M00_L08
M00_L10:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L16
       mov       eax,[rsi+28]
       mov       [rsp+44],eax
       cmp       [rbp+8],eax
       je        near ptr M00_L29
M00_L11:
       mov       eax,[rsp+44]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       rax,rcx
M00_L12:
       cmp       ebp,[rax+8]
       jae       near ptr M00_L31
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rsi+34]
       cmp       r15d,64
       ja        near ptr M00_L30
M00_L13:
       mov       rcx,[rbx+2E8]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+90]
       lea       r8,[rsp+38]
       mov       rdx,7FFC13788060
       cmp       [rcx],ecx
       call      qword ptr [7FFC136FED18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L14:
       cmp       edx,4
       jb        near ptr M00_L22
M00_L15:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L16:
       mov       ecx,[rsi+2C]
       mov       eax,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M00_L31
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M00_L12
M00_L17:
       call      qword ptr [7FFC1349EDD8]
       mov       ecx,65
       mov       rdx,7FFC13310910
       call      qword ptr [7FFC13117798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13310910
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135C7948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135C7960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FFC1349EDD8]
       mov       ecx,0F
       mov       rdx,7FFC13310910
       call      qword ptr [7FFC13117798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13310910
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135C7948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135C7960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFC12E41680
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC13046200]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L20:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC12EFE8C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L03
M00_L21:
       xor       r13d,r13d
       jmp       near ptr M00_L07
M00_L22:
       mov       r10d,80
       test      dl,1
       je        short M00_L23
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L23:
       test      dl,2
       je        short M00_L24
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L24:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L25:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,r14
       mov       rdx,rdi
       mov       r11,7FFC12E41688
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L27:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFC12E41690
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L28:
       call      qword ptr [7FFC13117A08]
       int       3
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFC13797528]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L31
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M00_L11
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFC1324DB00]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFC12EFE988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1535
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
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
       je        near ptr M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       test      rbx,rbx
       je        short M02_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rax,22BA61C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       call      qword ptr [7FFC136FF480]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFC12EF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L01
       mov       rcx,rax
M03_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rdx,7FFC1388A198
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M04_L10
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFC12EF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M04_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M04_L07
       mov       rcx,rax
M04_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M04_L14
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       cmp       ebp,[r14+8]
       ja        near ptr M04_L15
       cmp       ebp,[rdi+8]
       ja        near ptr M04_L15
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L13
       cmp       r8,4000
       ja        near ptr M04_L12
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M04_L11
M04_L03:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L08
M04_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L17
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L04
M04_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       rdx,7FFC1388A198
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L08:
       cmp       ecx,edx
       jae       near ptr M04_L17
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L09
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M04_L17
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M04_L09:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L08
       jmp       near ptr M04_L06
M04_L10:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L12:
       mov       rcx,rax
       call      qword ptr [7FFC13506B68]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC13506370]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC13506370]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFC13506388]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 654
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
M05_L02:
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       jne       short M05_L04
M05_L03:
       xor       edx,edx
       jmp       short M05_L00
M05_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L00
       jmp       short M05_L02
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L06
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M06_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M06_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L13
       cmp       r14d,[r15+8]
       ja        near ptr M06_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M06_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L11
       cmp       r8,4000
       ja        near ptr M06_L10
       mov       rcx,rax
       call      00007FFC72B237A0
       cmp       dword ptr [7FFC72E63A90],0
       jne       near ptr M06_L09
M06_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L15
M06_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M06_L07
M06_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L04
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L03
M06_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M06_L06:
       mov       rdx,7FFC1388A198
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L07:
       cmp       ecx,r13d
       jae       near ptr M06_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L08
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M06_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L07
       jmp       near ptr M06_L05
M06_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L10:
       mov       rcx,rax
       call      qword ptr [7FFC13506B68]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       xor       r13d,r13d
       jmp       short M06_L14
M06_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC13506370]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFC13506370]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFC13506388]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L01
M06_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M06_L16
       jmp       short M06_L17
M06_L16:
       mov       rdx,7FFC1388A1B0
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M06_L17:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L02
M06_L18:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M06_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L23
       cmp       qword ptr [r13],0
       jne       short M06_L19
       xor       r12d,r12d
       jmp       short M06_L22
M06_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M06_L20
       jmp       short M06_L21
M06_L20:
       mov       rdx,7FFC13734B70
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M06_L22:
       mov       [r13+8],r12d
M06_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L18
       jmp       near ptr M06_L02
M06_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 865
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L12
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L11
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L13
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFC72B23FE0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L08:
       mov       rdx,7FFC13734B70
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFC12EFE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L13:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FFC13734B88
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L17:
       call      qword ptr [7FFC13117A08]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

