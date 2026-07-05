## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC7A5A88]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC7B36E0
       mov       r9d,1
       call      qword ptr [7FFCCC7A5A28]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC7B37F8
       call      qword ptr [7FFCCC7A5A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
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
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC799A80
       call      qword ptr [7FFCCBFCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1B8B522FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1B8B5220008
       call      qword ptr [7FFCCC56F570]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC799AC0
       call      qword ptr [7FFCCBFCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,1B8B522BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1B8B5220008
       call      qword ptr [7FFCCC56F570]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			if (condition)
; 			^^^^^^^^^^^^^^
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1CB080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 280
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
       mov       rdx,7FFCCC799C28
       call      qword ptr [7FFCCBFCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC7A5B60]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7A5B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC755140]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC778B08
       mov       r9d,1
       call      qword ptr [7FFCCC7550E0]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC778C20
       call      qword ptr [7FFCCC755110]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
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
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC768400
       call      qword ptr [7FFCCBF9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2187CDBFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2187CDB0008
       call      qword ptr [7FFCCC53EC28]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC768440
       call      qword ptr [7FFCCBF9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2187CDBBB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2187CDB0008
       call      qword ptr [7FFCCC53EC28]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			if (condition)
; 			^^^^^^^^^^^^^^
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
; 				_ = collection.Add(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC19B080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 280
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
       mov       rdx,7FFCCC7685A8
       call      qword ptr [7FFCCBF9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC755218]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7551D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC785638]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC79AB20
       mov       r9d,1
       call      qword ptr [7FFCCC7855D8]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC79AC38
       call      qword ptr [7FFCCC785608]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
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
       mov       rdx,7FFCCC77A8E8
       call      qword ptr [7FFCCBFAF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,21EB3C6FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,21EB3C60008
       call      qword ptr [7FFCCC54F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFCCC77A928
       call      qword ptr [7FFCCBFAF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,21EB3C6BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,21EB3C60008
       call      qword ptr [7FFCCC54F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFCCC897558
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1AB080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFCCC89755C
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
       mov       rdx,7FFCCC77AA90
       call      qword ptr [7FFCCBFAF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC785710]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7856C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC775068]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC798990
       mov       r9d,1
       call      qword ptr [7FFCCC775008]; DotNetTips.Spargine.Extensions.HashSetExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon, Boolean)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC798AA8
       call      qword ptr [7FFCCC775038]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
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
       mov       rdx,7FFCCC788400
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,22806FDFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,22806FD0008
       call      qword ptr [7FFCCC55EC10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFCCC788440
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,22806FDBB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,22806FD0008
       call      qword ptr [7FFCCC55EC10]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFCCC8A6FB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1BB080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       mov       rcx,7FFCCC8A6FB4
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
       mov       rdx,7FFCCC7885A8
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC775140]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7750F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
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
       mov       rcx,1C63A800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2945B54E
       mov       r8d,0DF5AD8B3
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCCC53F180]
       mov       ecx,65
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC77CD08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC77CD20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      qword ptr [7FFCCC53F180]
       mov       ecx,0F
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC77CD08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC77CD20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC167750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBEE1430
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBEE1438
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFCCBF9F498]
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
       call      qword ptr [7FFCCC77F228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC30D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC167810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1333
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,206CF750008
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
       call      qword ptr [7FFCCC77EE38]
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
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC862D10
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC862D10
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L14:
       xor       r15d,r15d
       jmp       short M03_L16
M03_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC77C738]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC77C738]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC77C750]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC862D10
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       xor       r13d,r13d
       jmp       short M05_L14
M05_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC77C738]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC77C738]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC77C750]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC862D28
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7E63C0
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M06_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M06_L10
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M06_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M06_L11
M06_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M06_L12
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        near ptr M06_L09
M06_L02:
       mov       r15d,eax
M06_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M06_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M06_L14
M06_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M06_L17
       test      r13d,r13d
       jge       short M06_L05
M06_L07:
       mov       eax,0FFFFFFFF
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
M06_L08:
       mov       rdx,7FFCCC7E63C0
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1677F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M06_L02
M06_L10:
       xor       r15d,r15d
       jmp       near ptr M06_L04
M06_L11:
       xor       r15d,r15d
       jmp       near ptr M06_L03
M06_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
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
       mov       rdx,7FFCCC7E63D8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L06
       mov       eax,r13d
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
M06_L17:
       call      qword ptr [7FFCCBF9F498]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
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
       mov       rcx,2B118C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6E2C247A
       mov       r8d,0D7371B0C
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCCC54F1B0]
       mov       ecx,65
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC275AC0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC78CF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC78CF78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      qword ptr [7FFCCC54F1B0]
       mov       ecx,0F
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC275AC0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC78CF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC78CF78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC177750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBEF1508
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBEF1510
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFCCBFAF498]
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
       call      qword ptr [7FFCCC78F240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC31D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC177810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2F1ADD20008
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
       call      qword ptr [7FFCCC78EE50]
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
       call      qword ptr [7FFCCBFA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC873FA8
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBFA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC873FA8
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC54EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L14:
       xor       r15d,r15d
       jmp       short M03_L16
M03_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC78C900]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC78C900]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC78C918]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC873FA8
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC54EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       xor       r13d,r13d
       jmp       short M05_L14
M05_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC78C900]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC78C900]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC78C918]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC873FC0
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7F64A0
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7F64A0
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L08:
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        short M06_L10
       mov       r15d,eax
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       rcx,r15
       call      qword ptr [7FFCCC1777F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC7F64B8
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBFAF498]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
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
       mov       rcx,1ADD6C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2DC6D2B9
       mov       r8d,438776D6
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCCC52F1E0]
       mov       ecx,65
       mov       rdx,7FFCCC38C0A0
       call      qword ptr [7FFCCBF8F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC255AC0
       call      qword ptr [7FFCCBF8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC38C0A0
       call      qword ptr [7FFCCBF8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC66D488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC66D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      qword ptr [7FFCCC52F1E0]
       mov       ecx,0F
       mov       rdx,7FFCCC38C0A0
       call      qword ptr [7FFCCBF8F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC255AC0
       call      qword ptr [7FFCCBF8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC38C0A0
       call      qword ptr [7FFCCBF8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC66D488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC66D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC157750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBED1478
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBED1480
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFCCBF8F498]
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
       call      qword ptr [7FFCCC834030]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC2FD9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC157810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1332
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EE6BB00008
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
       call      qword ptr [7FFCCC76F630]
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
       call      qword ptr [7FFCCBF85A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC84FA78
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       ja        near ptr M03_L13
M03_L00:
       mov       ecx,eax
       call      qword ptr [7FFCCBF85A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M03_L09
       cmp       r8,4000
       ja        near ptr M03_L15
       mov       rcx,rax
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
       jne       near ptr M03_L14
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
       jl        near ptr M03_L12
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
       mov       rdx,7FFCCC84FA78
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FFCCBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L10:
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
M03_L11:
       inc       ecx
       cmp       ecx,ebp
       jge       near ptr M03_L07
M03_L12:
       cmp       ecx,edx
       jae       near ptr M03_L19
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M03_L11
       jmp       short M03_L10
M03_L13:
       cmp       ecx,7FFFFFC3
       jge       near ptr M03_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M03_L01
M03_L14:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L03
M03_L15:
       mov       rcx,rax
       call      qword ptr [7FFCCC52EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L16:
       xor       r15d,r15d
       jmp       short M03_L18
M03_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC66D038]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC66D038]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC66D050]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L03
M03_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 659
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       cmp       [rdx],rcx
       je        short M04_L02
       mov       rax,[rdx]
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
       je        near ptr M05_L08
       cmp       r8,4000
       ja        near ptr M05_L13
       mov       rcx,rax
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
       jne       near ptr M05_L12
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
       jl        near ptr M05_L11
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
       mov       rdx,7FFCCC84FA78
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFCCBF85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L09:
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
M05_L10:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M05_L06
M05_L11:
       cmp       ecx,r13d
       jae       near ptr M05_L26
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L10
       jmp       short M05_L09
M05_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCC52EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L14:
       xor       r13d,r13d
       jmp       short M05_L16
M05_L15:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC66D038]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L16:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC66D038]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC66D050]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC84FA90
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7EF630
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD2BBCFEC0
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
       mov       rdx,7FFCCC7EF630
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1577F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC7EF648
       call      qword ptr [7FFCCBF8F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBF8F498]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
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
       mov       rcx,23BB7C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L20
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DEF7AE1F
       mov       r8d,6A720F42
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FFCCC56F1E0]
       mov       ecx,65
       mov       rdx,7FFCCC3CC0A0
       call      qword ptr [7FFCCBFCF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC295AC0
       call      qword ptr [7FFCCBFCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3CC0A0
       call      qword ptr [7FFCCBFCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC6A4F78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC6A4F90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFCCC56F1E0]
       mov       ecx,0F
       mov       rdx,7FFCCC3CC0A0
       call      qword ptr [7FFCCBFCF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC295AC0
       call      qword ptr [7FFCCBFCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3CC0A0
       call      qword ptr [7FFCCBFCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC6A4F78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC6A4F90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC197750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBF11660
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L22:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBF11668
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L10
       jmp       near ptr M00_L06
M00_L23:
       call      qword ptr [7FFCCBFCF498]
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
       call      qword ptr [7FFCCC9042E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC33D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC197810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBFC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBFC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27C4CCC0008
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
       call      qword ptr [7FFCCC7EE190]
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
       call      qword ptr [7FFCCBFC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC953CF8
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBFC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC953CF8
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC56EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBFC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L03
M03_L14:
       xor       r15d,r15d
       jmp       short M03_L16
M03_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC6A48E8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M03_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC6A48E8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC6A4900]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L03
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 654
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       jne       short M04_L04
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
M04_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC953CF8
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC56EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBFC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       xor       r13d,r13d
       jmp       short M05_L14
M05_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC6A48E8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC6A48E8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC6A4900]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC953D10
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC8011C8
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M06_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M06_L12
M06_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M06_L10
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        near ptr M06_L09
M06_L02:
       mov       r15d,eax
M06_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M06_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M06_L14
M06_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M06_L17
       test      r13d,r13d
       jge       short M06_L05
M06_L07:
       mov       eax,0FFFFFFFF
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
M06_L08:
       mov       rdx,7FFCCC8011C8
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC8011E0
       call      qword ptr [7FFCCBFCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L06
       mov       eax,r13d
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
M06_L17:
       call      qword ptr [7FFCCBFCF498]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC7955D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC7AAB20
       call      qword ptr [7FFCCC795578]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC7AAC38
       call      qword ptr [7FFCCC7955A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC78A8E8
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2DE773AFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2DE773A0008
       call      qword ptr [7FFCCC55F0D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC78A928
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2DE773ABB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2DE773A0008
       call      qword ptr [7FFCCC55F0D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			if (collection.Contains(item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1BB040]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
; 				_ = collection.Remove(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1BB048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 			_ = collection.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L04:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC1BB080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 304
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
       mov       rdx,7FFCCC78AA88
       call      qword ptr [7FFCCBFBF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC7956C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC795680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC745050]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC768990
       call      qword ptr [7FFCCC744FF0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC768AA8
       call      qword ptr [7FFCCC745020]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			collection = collection.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC758400
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1E61B79FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1E61B790008
       call      qword ptr [7FFCCC52EBF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCCC758440
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,1E61B79BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1E61B790008
       call      qword ptr [7FFCCC52EBF8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 			if (collection.Contains(item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B040]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
; 				_ = collection.Remove(item);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 			_ = collection.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L04:
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 304
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
       mov       rdx,7FFCCC7585A0
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC745140]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7450F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC765530]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC77A578
       call      qword ptr [7FFCCC7654D0]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC77A690
       call      qword ptr [7FFCCC765500]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
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
       mov       rdx,7FFCCC75A800
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,246D751FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,246D7510008
       call      qword ptr [7FFCCC52F0D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFCCC75A840
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,246D751BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,246D7510008
       call      qword ptr [7FFCCC52F0D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B040]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFCCC877FF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M02_L04:
       mov       rcx,7FFCCC877FF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rdx,7FFCCC75A9A0
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC765620]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7655D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC765668]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCCC77AB20
       call      qword ptr [7FFCCC765608]; DotNetTips.Spargine.Extensions.HashSetExtensions.Upsert[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>, System.__Canon)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFCCC77AC38
       call      qword ptr [7FFCCC765638]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rax,[rax+48]
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
       mov       rdx,7FFCCC75A8E8
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1C1700CFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1C1700C0008
       call      qword ptr [7FFCCC52F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFCCC75A928
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,1C1700CBB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1C1700C0008
       call      qword ptr [7FFCCC52F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B040]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FFCCC878188
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M02_L04:
       mov       rcx,7FFCCC87818C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC18B080]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rdx,7FFCCC75AA88
       call      qword ptr [7FFCCBF8F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCCC765758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC765710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
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
       mov       r11,7FFCCBEE14F8
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
       mov       rcx,13918400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1245287A
       mov       r8d,2B5FB573
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFCCC77A128
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7551D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCCC53ECB8]
       mov       ecx,65
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC75CFF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC75D008]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFCCC53ECB8]
       mov       ecx,0F
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC75CFF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC75D008]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFCCBEE1500
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC19B048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC167750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBEE1508
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBEE1510
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L27:
       call      qword ptr [7FFCCBF9F498]
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
       jmp       near ptr M00_L12
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFCCC75F258]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC30D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC167810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1529
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,179AD510008
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
       call      qword ptr [7FFCCC75EE68]
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
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC863368
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC863368
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC75C798]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC75C798]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC75C7B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC863368
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       xor       r13d,r13d
       jmp       short M06_L14
M06_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC75C798]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC75C798]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC75C7B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC863380
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7E72A8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M07_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L13
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFCCC7E72A8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1677F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC7E72C0
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFCCBF9F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
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
       mov       r11,7FFCCBF01508
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
       mov       rcx,14D87800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0BA2C3D8E
       mov       r8d,0EDE70F82
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFCCC7ABB98
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC795638]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCCC55F1E0]
       mov       ecx,65
       mov       rdx,7FFCCC3BC0A0
       call      qword ptr [7FFCCBFBF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC285AC0
       call      qword ptr [7FFCCBFBF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3BC0A0
       call      qword ptr [7FFCCBFBF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC79CFA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC79CFC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFCCC55F1E0]
       mov       ecx,0F
       mov       rdx,7FFCCC3BC0A0
       call      qword ptr [7FFCCBFBF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC285AC0
       call      qword ptr [7FFCCBFBF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3BC0A0
       call      qword ptr [7FFCCBFBF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFBD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC79CFA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC79CFC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFCCBF01510
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC1BB048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC187750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBF01518
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBF01520
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L27:
       call      qword ptr [7FFCCBFBF498]
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
       call      qword ptr [7FFCCC79F300]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC32D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC187810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1528
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBFB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBFB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18E1C990008
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
       call      qword ptr [7FFCCC79EF10]
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
       call      qword ptr [7FFCCBFB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC883FA8
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBFB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC883FA8
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC55EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBFB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC79CB70]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC79CB70]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC79CB88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC883FA8
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC55EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBFB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       xor       r13d,r13d
       jmp       short M06_L14
M06_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC79CB70]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC79CB70]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC79CB88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC883FC0
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC806318
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M07_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
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
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
       mov       eax,0FFFFFFFF
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
M07_L07:
       mov       rdx,7FFCCC806318
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FFCCC1877F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC806330
       call      qword ptr [7FFCCBFBF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFCCBFBF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 528
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
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
       mov       r11,7FFCCBEF1440
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
       mov       rcx,1B3A7000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B1D54E6D
       mov       r8d,797A5A7
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFCCC79C140
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC776448]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCCC54ECB8]
       mov       ecx,65
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC275AC0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC77CC90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC77CCA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFCCC54ECB8]
       mov       ecx,0F
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC275AC0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC3AC0A0
       call      qword ptr [7FFCCBFAF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBFAD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC77CC90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC77CCA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFCCBEF1448
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC1AB048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC177750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBEF1450
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBEF1458
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L27:
       call      qword ptr [7FFCCBFAF498]
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
       call      qword ptr [7FFCCC77FED0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC31D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC177810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1528
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F43C080008
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
       call      qword ptr [7FFCCC77F570]
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
       call      qword ptr [7FFCCBFA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC8A0368
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCBFA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC8A0368
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC54EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L14:
       xor       r15d,r15d
       jmp       short M04_L16
M04_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC77C918]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC77C918]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC77C930]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
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
       mov       rdx,7FFCCC8A0368
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCCC54EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L11:
       mov       rcx,rax
       call      qword ptr [7FFCCBFA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L12:
       xor       r13d,r13d
       jmp       short M06_L14
M06_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC77C918]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC77C918]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC77C930]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC8A0380
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC8212A0
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M07_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M07_L13
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFCCC8212A0
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1777F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC8212B8
       call      qword ptr [7FFCCBFAF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFCCBFAF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
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
       mov       r11,7FFCCBEE1660
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
       mov       rcx,1806E400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L24
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,22B8BA15
       mov       r8d,823F6615
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
       mov       rcx,[rbx+278]
       mov       [rsp+38],rcx
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFCCC822BE8
       cmp       [rcx],ecx
       call      qword ptr [7FFCCC7BE1D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCCC53ED30]
       mov       ecx,65
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC674F60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC674F78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       call      qword ptr [7FFCCC53ED30]
       mov       ecx,0F
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCCC265AC0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCCC39C0A0
       call      qword ptr [7FFCCBF9F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCCBF9D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCCC674F60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCCC674F78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFCCBEE1668
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC19B048]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCCC167750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,7FFCCBEE1670
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rdi
       mov       r11,7FFCCBEE1678
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       jne       near ptr M00_L13
       jmp       near ptr M00_L09
M00_L27:
       call      qword ptr [7FFCCBF9F498]
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
       call      qword ptr [7FFCCC8C4300]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FFCCC30D9E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCCC167810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L13
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1528
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
       call      00007FFD2BC3A1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C103570008
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
       call      qword ptr [7FFCCC7BE148]
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
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCCC9086D8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       ja        near ptr M04_L12
M04_L00:
       mov       ecx,eax
       call      qword ptr [7FFCCBF95A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M04_L15
       cmp       r8,4000
       ja        near ptr M04_L14
       mov       rcx,rax
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
       jne       near ptr M04_L13
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
       jl        near ptr M04_L11
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
       mov       rdx,7FFCCC9086D8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L09:
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
M04_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L07
M04_L11:
       cmp       ecx,edx
       jae       near ptr M04_L19
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M04_L10
       jmp       short M04_L09
M04_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M04_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M04_L01
M04_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L03
M04_L14:
       mov       rcx,rax
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L15:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L03
M04_L16:
       xor       r15d,r15d
       jmp       short M04_L18
M04_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCCC6748D0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M04_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCCC6748D0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCCC6748E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L03
M04_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 655
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
       je        near ptr M06_L13
       cmp       r8,4000
       ja        near ptr M06_L12
       mov       rcx,rax
       call      00007FFD2BBCFAA0
       cmp       dword ptr [7FFD2BEF39A0],0
       jne       near ptr M06_L11
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
       jl        near ptr M06_L10
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
       mov       rdx,7FFCCC9086D8
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L00
M06_L08:
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
M06_L09:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M06_L06
M06_L10:
       cmp       ecx,r13d
       jae       near ptr M06_L26
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L09
       jmp       short M06_L08
M06_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L12:
       mov       rcx,rax
       call      qword ptr [7FFCCC53EB80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L13:
       mov       rcx,rax
       call      qword ptr [7FFCCBF95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L01
M06_L14:
       xor       r13d,r13d
       jmp       short M06_L16
M06_L15:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCCC6748D0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M06_L16:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCCC6748D0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCCC6748E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCCC9086F0
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCCC7C4C40
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M07_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFD2BBCFEC0
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
       mov       eax,0FFFFFFFF
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
M07_L08:
       mov       rdx,7FFCCC7C4C40
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FFCCC1677F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCCC7C4C58
       call      qword ptr [7FFCCBF9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
       mov       eax,r13d
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
M07_L17:
       call      qword ptr [7FFCCBF9F498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```

