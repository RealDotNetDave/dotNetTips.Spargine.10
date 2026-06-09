## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rax,[rbp+10]
       mov       r8,[rax+280]
       mov       rcx,7FFE508BA5B0
       mov       r9d,1
       call      qword ptr [7FFE508A5590]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFE508A55C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
; 			if (items is null)
; 			^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
; 				return false;
; 				^^^^^^^^^^^^^
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
; 			ArgumentNullException.ThrowIfNull(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,2CB671EFD28
       call      qword ptr [7FFE504D6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
; 			CollectionExtensionsHelper.ThrowIfArray(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M01_L01
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089ACF8
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE508A55D8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
; 				return CollectionExtensionsHelper.AddAllItemsToCollection(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M01_L03
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089AF08
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE508A56B0]
       nop
       add       rsp,70
       pop       rbp
       ret
; 			return CollectionExtensionsHelper.AddUniqueItemsToCollection(collection, items, CollectionExtensionsHelper.ResolveComparer(comparer));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L05:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L06
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089ADA8
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L08
       mov       rax,[rbp-50]
       mov       [rbp-20],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089AE58
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE508A5620]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFE508A5668]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 393
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A5CB0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508A5C80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rax,[rbp+10]
       mov       r8,[rax+280]
       mov       rcx,7FFE5089AB48
       mov       r9d,1
       call      qword ptr [7FFE508855F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFE50885620]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
; 			if (items is null)
; 			^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
; 				return false;
; 				^^^^^^^^^^^^^
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
; 			ArgumentNullException.ThrowIfNull(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,2129D61FD28
       call      qword ptr [7FFE504B6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
; 			CollectionExtensionsHelper.ThrowIfArray(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M01_L01
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087ADE0
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE50885638]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
; 				return CollectionExtensionsHelper.AddAllItemsToCollection(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M01_L03
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087AFF0
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE50885710]
       nop
       add       rsp,70
       pop       rbp
       ret
; 			return CollectionExtensionsHelper.AddUniqueItemsToCollection(collection, items, CollectionExtensionsHelper.ResolveComparer(comparer));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L05:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L06
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087AE90
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L08
       mov       rax,[rbp-50]
       mov       [rbp-20],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087AF40
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE50885680]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFE508856C8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 393
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE50885D10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50885CE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rax,[rbp+10]
       mov       r8,[rax+280]
       mov       rcx,7FFE508AA5B0
       mov       r9d,1
       call      qword ptr [7FFE508955C0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFE508955F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; 			if (items is null)
; 			^^^^^^^^^^^^^^^^^^
; 				return false;
; 				^^^^^^^^^^^^^
; 			ArgumentNullException.ThrowIfNull(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensionsHelper.ThrowIfArray(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
; 				return CollectionExtensionsHelper.AddAllItemsToCollection(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return CollectionExtensionsHelper.AddUniqueItemsToCollection(collection, items, CollectionExtensionsHelper.ResolveComparer(comparer));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FFE509AC2A0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,2650FC8FD28
       call      qword ptr [7FFE504C6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M01_L01
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088ACF8
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE50895608]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,7FFE509AC2A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M01_L03
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088AF08
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE508956E0]
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFE509AC2A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L06
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088ADA8
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L08
       mov       rax,[rbp-50]
       mov       [rbp-20],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088AE58
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE50895650]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFE50895698]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 438
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE50895CE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50895CB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rax,[rbp+10]
       mov       r8,[rax+280]
       mov       rcx,7FFE508CAC20
       mov       r9d,1
       call      qword ptr [7FFE508B56B0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFE508B56E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 93
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
; 			if (items is null)
; 			^^^^^^^^^^^^^^^^^^
; 				return false;
; 				^^^^^^^^^^^^^
; 			ArgumentNullException.ThrowIfNull(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensionsHelper.ThrowIfArray(collection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
; 				return CollectionExtensionsHelper.AddAllItemsToCollection(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return CollectionExtensionsHelper.AddUniqueItemsToCollection(collection, items, CollectionExtensionsHelper.ResolveComparer(comparer));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FFE509CBF20
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,275849DFD28
       call      qword ptr [7FFE504E6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M01_L01
       mov       rax,[rbp-38]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AADE0
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE508B56F8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,7FFE509CBF24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M01_L03
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AAFF0
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE508B57D0]
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFE509CBF28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L06
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AAE90
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L08
       mov       rax,[rbp-50]
       mov       [rbp-20],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AAF40
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE508B5740]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFE508B5788]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 438
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5DD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508B5DA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L74
       test      r14,r14
       je        near ptr M00_L75
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rdx],rcx
       je        short M00_L01
       xor       edx,edx
M00_L01:
       test      rdx,rdx
       jne       near ptr M00_L76
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L78
       xor       r12d,r12d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L81
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-128],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L83
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L82
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       [rbp-98],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-98]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L04:
       mov       rcx,rdx
M00_L05:
       mov       [rbp-130],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       jne       near ptr M00_L26
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jae       near ptr M00_L17
M00_L07:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M00_L28
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L25
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       vmovdqu   xmm0,xmmword ptr [rax+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
M00_L08:
       mov       rsi,[rbp-70]
       mov       rdi,[rbp-68]
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L20
M00_L09:
       mov       rdx,[r13+10]
       mov       [rbp-138],rdx
       mov       r8,[r13+18]
       mov       [rbp-140],r8
       xor       r10d,r10d
       mov       [rbp-9C],r10d
       test      r8,r8
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-160]
       call      qword ptr [7FFE500149D8]; System.ValueType.GetHashCode()
       mov       rcx,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M00_L28
       mov       edx,edx
       lea       rdx,[rcx+rdx*4+10]
       mov       [rbp-148],rdx
       mov       r8d,[rdx]
       dec       r8d
       js        short M00_L12
M00_L10:
       mov       r10,[rbp-138]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L28
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-138],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-168],r8
       mov       [rbp-0A0],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L11:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r10,[rbp-138]
       mov       [rbp-9C],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L27
       test      r8d,r8d
       mov       eax,[rbp-0A0]
       jge       short M00_L10
M00_L12:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L16
       mov       r8d,[r13+28]
       mov       [rbp-0A4],r8d
       mov       r11,[rbp-138]
       cmp       [r11+8],r8d
       je        near ptr M00_L15
M00_L13:
       mov       r8d,[rbp-0A4]
       lea       ecx,[r8+1]
       mov       [r13+28],ecx
       mov       r11,[r13+10]
       mov       rcx,r11
M00_L14:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L28
       mov       [rbp-0A8],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-158],r10
       mov       [r10],eax
       mov       rdx,[rbp-148]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-158]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0A8]
       inc       esi
       mov       rdi,[rbp-148]
       mov       [rdi],esi
       inc       dword ptr [r13+34]
       jmp       near ptr M00_L06
M00_L15:
       mov       [rbp-0A0],eax
       mov       ecx,[r13+28]
       call      qword ptr [7FFE500DF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE508A58D8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r13+8]
       mov       edx,[rbp-0A0]
       mov       eax,edx
       imul      rax,[r13+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M00_L28
       mov       eax,eax
       lea       rcx,[rcx+rax*4+10]
       mov       rax,rcx
       mov       [rbp-148],rax
       mov       eax,edx
       jmp       near ptr M00_L13
M00_L16:
       mov       ecx,[r13+2C]
       mov       r8d,ecx
       dec       dword ptr [r13+30]
       mov       r11,[rbp-138]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L28
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L14
M00_L17:
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       near ptr M00_L29
M00_L18:
       call      qword ptr [7FFE500DFC60]
       int       3
M00_L19:
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FFE50021668
       call      qword ptr [r11]
       mov       rax,[rbp-130]
       jmp       near ptr M00_L08
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE508A56E0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-130]
       jmp       near ptr M00_L09
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-198],r9
       mov       r11,[r8+10]
       mov       [rbp-1A0],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-170]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-178]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-1A0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-178]
       mov       rdx,[rbp-170]
       call      qword ptr [7FFE500149D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L11
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       mov       rcx,r8
       mov       r11,7FFE50021678
       call      qword ptr [r11]
       mov       r8,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L28
       mov       edx,edx
       lea       rdx,[r8+rdx*4+10]
       mov       r10,rdx
       mov       [rbp-148],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L12
M00_L23:
       mov       r11,[rbp-138]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L28
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-138],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-150],r9
       mov       [rbp-0A0],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       mov       [rbp-110],rsi
       mov       [rbp-108],rdi
       lea       r8,[rbp-110]
       lea       rdx,[rbp-100]
       mov       rcx,[rbp-140]
       mov       r11,7FFE50021680
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-150]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r11,[rbp-138]
       cmp       [r11+8],ecx
       jb        short M00_L27
       test      r9d,r9d
       mov       [rbp-138],r11
       mov       [rbp-9C],ecx
       mov       eax,[rbp-0A0]
       jge       near ptr M00_L23
       jmp       near ptr M00_L12
M00_L25:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M00_L07
       jmp       near ptr M00_L17
M00_L26:
       mov       rcx,rax
       mov       r11,7FFE50021660
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       short M00_L29
M00_L27:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       jne       near ptr M00_L84
M00_L30:
       mov       ecx,[r13+28]
       test      ecx,ecx
       jle       short M00_L31
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L85
M00_L31:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L87
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        near ptr M00_L86
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       [rbp-0D0],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L32:
       mov       [rbp-120],rdx
       cmp       qword ptr [rbp-120],0
       je        near ptr M00_L48
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L48
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L48
       jmp       near ptr M00_L37
M00_L33:
       cmp       dword ptr [r14+40],0
       jg        near ptr M00_L43
       mov       r12d,[r14+38]
       cmp       r10d,r12d
       je        near ptr M00_L42
M00_L34:
       lea       edx,[r12+1]
       mov       [r14+38],edx
       mov       rdx,[r14+10]
       mov       rax,rdx
M00_L35:
       cmp       r12d,[rax+8]
       jae       near ptr M00_L71
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       mov       [rbp-180],rax
       lea       r8,[rax+rdx*8+10]
       mov       r11d,[rbp-0DC]
       mov       [r8+10],r11d
       mov       edx,[r15]
       dec       edx
       mov       [r8+14],edx
       mov       [rbp-190],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-190]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       [r15],r12d
       inc       dword ptr [r14+44]
       cmp       dword ptr [rbp-0E0],64
       ja        near ptr M00_L59
M00_L36:
       mov       r12d,1
M00_L37:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5044C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L72
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FFE508A57B8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M00_L37
       mov       r15,r14
       mov       rsi,[rbp-40]
       mov       rdi,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L68
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L56
M00_L38:
       mov       r12,[r15+10]
       mov       rax,[r15+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       [rbp-188],rax
       cmp       [rax],rcx
       jne       near ptr M00_L57
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE506F47F8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
M00_L39:
       mov       r8d,eax
       xor       eax,eax
       mov       [rbp-0E0],eax
       mov       rcx,r15
       mov       [rbp-0DC],r8d
       mov       edx,r8d
       call      qword ptr [7FFE50987438]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r15,rax
       mov       eax,[r15]
       dec       eax
       mov       r10d,[r12+8]
       mov       [rbp-114],r10d
       cmp       r10d,eax
       jbe       near ptr M00_L33
M00_L40:
       cmp       eax,r10d
       jae       near ptr M00_L71
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r12+rdx*8+10]
       mov       [rbp-1A8],r9
       mov       r11d,[rbp-0DC]
       cmp       [r9+10],r11d
       je        near ptr M00_L58
M00_L41:
       mov       r9,[rbp-1A8]
       mov       eax,[r9+14]
       mov       ecx,[rbp-0E0]
       inc       ecx
       mov       [rbp-0E0],ecx
       cmp       r10d,ecx
       jb        near ptr M00_L70
       cmp       r10d,eax
       ja        short M00_L40
       jmp       near ptr M00_L33
M00_L42:
       mov       rcx,r14
       call      qword ptr [7FFE508AED90]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FFE50987438]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r15,rax
       jmp       near ptr M00_L34
M00_L43:
       mov       eax,[r14+3C]
       mov       r8d,eax
       cmp       eax,r10d
       jae       near ptr M00_L71
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r12+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r14+3C],edx
       dec       dword ptr [r14+40]
       mov       rax,r12
       mov       r12d,r8d
       jmp       near ptr M00_L35
M00_L44:
       cmp       dword ptr [r14+40],0
       jg        near ptr M00_L55
       mov       ecx,[r14+38]
       mov       eax,ecx
       mov       [rbp-0E4],eax
       cmp       [r12+8],eax
       je        near ptr M00_L66
M00_L45:
       mov       eax,[rbp-0E4]
       mov       r12d,eax
       lea       ecx,[r12+1]
       mov       [r14+38],ecx
       mov       rcx,[r14+10]
       mov       rax,rcx
M00_L46:
       cmp       r12d,[rax+8]
       jae       near ptr M00_L71
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-180],rax
       lea       rcx,[rax+rcx*8+10]
       mov       r8,rcx
       mov       r9d,[rbp-0DC]
       mov       [r8+10],r9d
       mov       ecx,[r15]
       dec       ecx
       mov       [r8+14],ecx
       mov       [rbp-190],r8
       mov       rcx,r8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-190]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[r12+1]
       mov       [r15],edx
       inc       dword ptr [r14+44]
       cmp       dword ptr [rbp-0E0],64
       ja        near ptr M00_L67
M00_L47:
       mov       r12d,1
M00_L48:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L60
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5044C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L49:
       test      eax,eax
       je        near ptr M00_L72
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L61
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M00_L50:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FFE508A57B8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L62
       mov       r15,r14
       mov       rsi,[rbp-40]
       mov       rdi,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L68
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L63
M00_L51:
       mov       r12,[r15+10]
       mov       rdx,[r15+18]
       mov       rax,rdx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       [rbp-188],rax
       cmp       [rax],rcx
       jne       near ptr M00_L64
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE506F47F8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       mov       r11d,eax
M00_L52:
       mov       eax,r11d
       xor       ecx,ecx
       mov       [rbp-0E0],ecx
       mov       rcx,r15
       mov       [rbp-0DC],eax
       mov       edx,eax
       call      qword ptr [7FFE50987438]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r15,rax
       mov       eax,[r15]
       dec       eax
       cmp       [r12+8],eax
       jbe       near ptr M00_L44
M00_L53:
       cmp       eax,[r12+8]
       jae       near ptr M00_L71
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r12+rdx*8+10]
       mov       [rbp-1B0],r10
       mov       r9d,[rbp-0DC]
       cmp       [r10+10],r9d
       je        near ptr M00_L65
M00_L54:
       mov       r10,[rbp-1B0]
       mov       eax,[r10+14]
       mov       edx,[rbp-0E0]
       inc       edx
       mov       [rbp-0E0],edx
       cmp       [r12+8],edx
       jb        near ptr M00_L70
       cmp       [r12+8],eax
       ja        short M00_L53
       jmp       near ptr M00_L44
M00_L55:
       mov       eax,[r14+3C]
       mov       r8d,eax
       cmp       eax,[r12+8]
       jae       near ptr M00_L71
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r12+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+3C],ecx
       dec       dword ptr [r14+40]
       mov       rax,r12
       mov       r12d,r8d
       jmp       near ptr M00_L46
M00_L56:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE500D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L38
M00_L57:
       mov       rax,[rbp-188]
       mov       [rbp-188],rax
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FFE50021688
       call      qword ptr [r11]
       jmp       near ptr M00_L39
M00_L58:
       cmp       eax,r10d
       jae       near ptr M00_L71
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[r12+rdx*8+10]
       mov       rcx,[rbp-188]
       mov       r8,rdi
       mov       r11,7FFE50021690
       call      qword ptr [r11]
       test      eax,eax
       mov       r10d,[rbp-114]
       je        near ptr M00_L41
       jmp       near ptr M00_L69
M00_L59:
       mov       rdx,[rbp-188]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L36
       mov       r12,[rbp-180]
       mov       edx,[r12+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFE503673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L36
M00_L60:
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021610
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L61:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021618
       call      qword ptr [r11]
       jmp       near ptr M00_L50
M00_L62:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       mov       rcx,r14
       mov       r11,7FFE50021620
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L63:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE500D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L51
M00_L64:
       mov       rax,[rbp-188]
       mov       [rbp-188],rax
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FFE50021688
       call      qword ptr [r11]
       mov       r11d,eax
       jmp       near ptr M00_L52
M00_L65:
       cmp       eax,[r12+8]
       jae       near ptr M00_L71
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[r12+rdx*8+10]
       mov       rcx,[rbp-188]
       mov       r8,rdi
       mov       r11,7FFE50021690
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L54
       jmp       short M00_L69
M00_L66:
       mov       rcx,r14
       call      qword ptr [7FFE508AED90]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FFE50987438]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r15,rax
       jmp       near ptr M00_L45
M00_L67:
       mov       rdx,[rbp-188]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L47
       mov       r12,[rbp-180]
       mov       edx,[r12+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFE503673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L47
M00_L68:
       mov       ecx,4
       call      qword ptr [7FFE500DFD50]
       int       3
M00_L69:
       mov       rdx,rdi
       mov       rcx,7FFE50934BF0
       call      qword ptr [7FFE500DFD20]
       int       3
M00_L70:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L71:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L72:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L88
M00_L73:
       mov       [rbp-0F0],r12b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508A58F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L74:
       xor       r12d,r12d
       jmp       short M00_L73
M00_L75:
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rcx,rax
       call      qword ptr [7FFE508AD6F8]
       int       3
M00_L76:
       call      qword ptr [7FFE508A5440]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L77
       call      qword ptr [7FFE50987408]
       mov       r12,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE50447DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FFE50021630
       call      qword ptr [r11]
       mov       [rbp-120],rax
M00_L79:
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021638
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L80
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021640
       call      qword ptr [r11]
       lea       r8,[rbp-60]
       lea       rdx,[rbp-58]
       mov       rcx,r13
       call      qword ptr [7FFE508A57B8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M00_L79
       mov       r12d,1
       jmp       short M00_L79
M00_L80:
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021648
       call      qword ptr [r11]
       jmp       near ptr M00_L73
M00_L81:
       mov       rcx,r14
       mov       r11,7FFE50021650
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L82:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A0ED002B28
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L83:
       mov       rcx,r14
       mov       r11,7FFE50021658
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L84:
       mov       rcx,rax
       mov       r11,7FFE50021670
       call      qword ptr [r11]
       jmp       near ptr M00_L30
M00_L85:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFE50987420]
       jmp       near ptr M00_L31
M00_L86:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A0ED002B28
       mov       rdx,[rcx]
       jmp       near ptr M00_L32
M00_L87:
       mov       rcx,r15
       mov       r11,7FFE50021608
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L32
M00_L88:
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021628
       call      qword ptr [r11]
       jmp       near ptr M00_L73
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L89
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021648
       call      qword ptr [r11]
M00_L89:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L90
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L90
       mov       rcx,[rbp-120]
       mov       r11,7FFE50021628
       call      qword ptr [r11]
M00_L90:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-130],0
       je        short M00_L91
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L91
       mov       rcx,rax
       mov       r11,7FFE50021670
       call      qword ptr [r11]
M00_L91:
       nop
       add       rsp,28
       ret
; Total bytes of code 4499
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFE741A0B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE508AEA60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE50445EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFE508AE718]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.ValueType.GetHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
M03_L00:
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx]
       mov       [rbp+10],rbx
       lea       r14,[rbx+8]
       mov       [rbp-0C8],r14
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rcx,rdi
       sar       rcx,20
       xor       ecx,edi
       mov       eax,[rbp-3C]
       lea       edx,[rax+1]
       mov       [rbp-3C],edx
       mov       edx,eax
       and       edx,3
       jne       short M03_L03
       mov       [rbp-48],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L04
       test      r15b,4
       je        near ptr M03_L07
M03_L02:
       mov       rcx,rdi
       call      00007FFEAFD327D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50985E90]
       jmp       near ptr M03_L16
M03_L03:
       cmp       edx,1
       jne       near ptr M03_L23
       mov       [rbp-44],ecx
       jmp       short M03_L01
M03_L04:
       mov       rcx,rdi
       mov       rax,7FFE500148F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L05]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD2B1D0
       call      rax
M03_L05:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L06
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L06:
       mov       r9,[rbp-0A8]
       mov       [rsi+8],r9
       test      eax,eax
       jne       near ptr M03_L02
M03_L07:
       mov       rbx,[rbp+10]
       mov       [rbp-60],rbx
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       [rbp-70],r9d
       mov       [rbp-78],r9
       lea       r9,[rbp-78]
       mov       [rsp+20],r9
       lea       r9,[rbp-70]
       lea       r8,[rbp-68]
       mov       rcx,rdi
       lea       rdx,[rbp-60]
       mov       rax,7FFE50014938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L08]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD52B70
       call      rax
M03_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L09
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L09:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       dec       eax
       jne       near ptr M03_L26
       mov       ecx,[rbp-68]
       mov       r14,[rbp-0C8]
       mov       rcx,[r14+rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       near ptr M03_L27
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       edx,86426DA6
       mov       r8d,0FFD76E21
       cmp       ecx,8
       jb        short M03_L11
       mov       r10d,ecx
       shr       r10d,3
M03_L10:
       add       edx,[rax]
       mov       r9d,[rax+4]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
       add       r9d,edx
       mov       edx,r8d
       xor       edx,r9d
       rol       r9d,14
       add       r9d,edx
       rol       edx,9
       xor       edx,r9d
       rol       r9d,1B
       add       r9d,edx
       rol       edx,13
       mov       r8d,r9d
       add       rax,8
       dec       r10d
       mov       r9d,edx
       mov       edx,r8d
       mov       r8d,r9d
       jne       short M03_L10
       test      cl,4
       je        short M03_L13
       jmp       short M03_L12
M03_L11:
       cmp       ecx,4
       jb        near ptr M03_L19
M03_L12:
       add       edx,[rax]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
M03_L13:
       mov       r10d,ecx
       and       r10,7
       mov       eax,[rax+r10-4]
       shr       eax,8
       or        eax,80000000
       not       ecx
       shl       ecx,3
       shrx      ecx,eax,ecx
M03_L14:
       add       ecx,edx
       mov       eax,r8d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
M03_L15:
       mov       ecx,[rbp-3C]
       lea       edx,[rcx+1]
       mov       [rbp-3C],edx
       mov       edx,ecx
       and       edx,3
       jne       near ptr M03_L22
       mov       [rbp-48],eax
M03_L16:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,0B4B6FAB6
M03_L17:
       lea       eax,[rdx+rax*4]
       test      ecx,ecx
       je        short M03_L18
       imul      edx,[rbp-48],0C2B2AE3D
       add       eax,edx
       rol       eax,11
       imul      eax,27D4EB2F
       cmp       ecx,1
       jbe       short M03_L18
       imul      edx,[rbp-44],0C2B2AE3D
       add       edx,eax
       rol       edx,11
       imul      eax,edx,27D4EB2F
       cmp       ecx,2
       ja        near ptr M03_L36
M03_L18:
       mov       ecx,eax
       shr       ecx,0F
       xor       ecx,eax
       imul      eax,ecx,85EBCA77
       mov       ecx,eax
       shr       ecx,0D
       xor       ecx,eax
       imul      eax,ecx,0C2B2AE3D
       mov       ecx,eax
       shr       ecx,10
       xor       eax,ecx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       mov       r10d,80
       test      cl,1
       je        short M03_L20
       mov       r10d,ecx
       and       r10,2
       movzx     r10d,byte ptr [rax+r10]
       or        r10d,8000
M03_L20:
       test      cl,2
       jne       short M03_L21
       mov       ecx,r10d
       jmp       near ptr M03_L14
M03_L21:
       shl       r10d,10
       movzx     ecx,word ptr [rax]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M03_L14
M03_L22:
       cmp       edx,1
       jne       near ptr M03_L28
       mov       [rbp-44],eax
       jmp       near ptr M03_L16
M03_L23:
       cmp       edx,2
       jne       short M03_L24
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L24:
       cmp       eax,3
       jne       short M03_L25
       mov       dword ptr [rbp-58],0C283D72D
       mov       dword ptr [rbp-54],244C5D7C
       mov       dword ptr [rbp-50],9E609305
       mov       dword ptr [rbp-4C],291954
M03_L25:
       imul      eax,[rbp-48],85EBCA77
       add       eax,[rbp-58]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-58],eax
       imul      eax,[rbp-44],85EBCA77
       add       eax,[rbp-54]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-54],eax
       imul      eax,[rbp-40],85EBCA77
       add       eax,[rbp-50]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-50],eax
       imul      ecx,85EBCA77
       add       ecx,[rbp-4C]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L01
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L16
       mov       edx,eax
       lea       rcx,[7FFE509EDF58]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M03_L00]
       add       rcx,rax
       jmp       rcx
M03_L27:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L15
M03_L28:
       cmp       edx,2
       jne       short M03_L29
       mov       [rbp-40],eax
       jmp       near ptr M03_L16
M03_L29:
       cmp       ecx,3
       jne       short M03_L30
       mov       dword ptr [rbp-58],0C283D72D
       mov       dword ptr [rbp-54],244C5D7C
       mov       dword ptr [rbp-50],9E609305
       mov       dword ptr [rbp-4C],291954
M03_L30:
       imul      ecx,[rbp-48],85EBCA77
       add       ecx,[rbp-58]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-58],ecx
       imul      ecx,[rbp-44],85EBCA77
       add       ecx,[rbp-54]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-54],ecx
       imul      ecx,[rbp-40],85EBCA77
       add       ecx,[rbp-50]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-50],ecx
       imul      eax,85EBCA77
       add       eax,[rbp-4C]
       rol       eax,0D
       imul      ecx,eax,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L16
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rdx]
       mov       rdx,[rdx]
       dec       rdx
       mov       rax,7FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,7FF0000000000000
       cmp       rdx,rax
       jb        short M03_L31
       mov       rdx,7FF0000000000000
       and       rcx,rdx
M03_L31:
       mov       rdx,rcx
       shr       rdx,20
       xor       edx,ecx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L16
       mov       ecx,[rbp-68]
       add       rcx,[rbp-0C8]
       mov       edx,[rcx]
       mov       ecx,[rcx]
       dec       ecx
       and       ecx,7FFFFFFF
       cmp       ecx,7F800000
       jb        short M03_L32
       and       edx,7F800000
M03_L32:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L16
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50985E90]
       jmp       near ptr M03_L16
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE50986C10]
       test      rax,rax
       jne       short M03_L33
       xor       edx,edx
       jmp       short M03_L34
M03_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edx,eax
M03_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L16
M03_L35:
       rorx      edx,[rbp-58],1F
       rorx      r8d,[rbp-54],19
       add       edx,r8d
       rorx      r8d,[rbp-50],14
       add       edx,r8d
       rorx      r8d,[rbp-4C],0E
       add       edx,r8d
       jmp       near ptr M03_L17
M03_L36:
       imul      ecx,[rbp-40],0C2B2AE3D
       add       ecx,eax
       rol       ecx,11
       imul      eax,ecx,27D4EB2F
       jmp       near ptr M03_L18
; Total bytes of code 1620
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M05_L06
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M05_L13
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M05_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L14
       cmp       ebp,[r14+8]
       ja        near ptr M05_L14
       cmp       ebp,[rdi+8]
       ja        near ptr M05_L14
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L12
       cmp       r8,4000
       ja        near ptr M05_L11
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M05_L10
M05_L01:
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
       jle       short M05_L05
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L09
       jmp       short M05_L04
       nop       dword ptr [rax]
M05_L02:
       mov       eax,[rdx]
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
       jae       near ptr M05_L16
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L03:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L04:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M05_L03
       jmp       short M05_L02
M05_L05:
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
M05_L06:
       mov       rdx,7FFE50899DF0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       r8d,[rax]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M05_L16
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+4],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M05_L08:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L09:
       cmp       ecx,edx
       jae       short M05_L16
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M05_L08
       jmp       short M05_L07
M05_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFE5067EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE508ACDC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE508ACDC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE508ACDE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
M06_L00:
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
M06_L01:
       mov       rdx,7FFE50899DF0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M07_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M07_L03
M07_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M07_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M07_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       call      qword ptr [7FFE500DFC60]
       int       3
M07_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M07_L00
M07_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rbp,rdx
       mov       r14,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L06
M08_L00:
       mov       r15,[rbx+10]
       mov       r13,[rbx+18]
       xor       r12d,r12d
       test      r13,r13
       jne       near ptr M08_L11
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       lea       rdi,[rdx+8]
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rcx,rdx
       call      qword ptr [7FFE500149D8]; System.ValueType.GetHashCode()
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r13,[rcx+rdx*4+10]
       mov       edi,[r13]
       dec       edi
       js        short M08_L03
M08_L01:
       cmp       edi,[r15+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rax,[r15+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],esi
       je        near ptr M08_L07
M08_L02:
       mov       rax,[rsp+30]
       mov       edi,[rax+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M08_L19
       test      edi,edi
       jge       short M08_L01
M08_L03:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M08_L20
       mov       r12d,[rbx+28]
       cmp       [r15+8],r12d
       je        near ptr M08_L21
M08_L04:
       lea       eax,[r12+1]
       mov       [rbx+28],eax
       mov       r15,[rbx+10]
M08_L05:
       cmp       r12d,[r15+8]
       jae       near ptr M08_L22
       mov       eax,r12d
       lea       rax,[rax+rax*2]
       lea       rdi,[r15+rax*8+10]
       mov       [rdi],esi
       mov       eax,[r13]
       dec       eax
       mov       [rdi+4],eax
       add       rdi,8
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       eax,[r12+1]
       mov       [r13],eax
       inc       dword ptr [rbx+34]
       mov       [r14],r12d
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE508A56E0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M08_L08
       jmp       short M08_L09
M08_L08:
       mov       rdx,7FFE50899D70
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L09:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rax,[rsp+30]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       r10,[rcx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       test      eax,eax
       je        near ptr M08_L02
       mov       [r14],edi
M08_L10:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M08_L12
       jmp       short M08_L13
M08_L12:
       mov       rdx,7FFE5089A118
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L13:
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rdx,[rsp+48]
       mov       rcx,r13
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L22
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       rdi,rcx
       mov       eax,[rdi]
       dec       eax
       jns       short M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L03
M08_L14:
       cmp       eax,[r15+8]
       jae       near ptr M08_L22
       mov       [rsp+5C],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r15+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8],esi
       jne       short M08_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M08_L15
       jmp       short M08_L16
M08_L15:
       mov       rdx,7FFE5089A130
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L16:
       mov       rax,[rsp+28]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L18
M08_L17:
       mov       r8,[rsp+28]
       mov       eax,[r8+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        short M08_L19
       test      eax,eax
       jge       near ptr M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L03
M08_L18:
       mov       eax,[rsp+5C]
       mov       [r14],eax
       jmp       near ptr M08_L10
M08_L19:
       call      qword ptr [7FFE500DF498]
       int       3
M08_L20:
       mov       eax,[rbx+2C]
       mov       r12d,eax
       dec       dword ptr [rbx+30]
       cmp       eax,[r15+8]
       jae       short M08_L22
       lea       rax,[rax+rax*2]
       mov       eax,[r15+rax*8+14]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+2C],eax
       jmp       near ptr M08_L05
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508A5848]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
       mov       rax,[rbx+8]
       mov       ecx,esi
       imul      rcx,[rbx+20]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       mov       r8d,edx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       short M08_L22
       mov       ecx,ecx
       lea       r13,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
```
```assembly
; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-28],xmm4
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-4],15051505
       mov       dword ptr [rbp-8],15051505
       mov       r8d,[rcx+8]
       mov       [rbp-0C],r8d
       lea       r8,[rcx+0C]
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       cmp       dword ptr [rbp-0C],2
       jle       short M09_L01
M09_L00:
       mov       edx,[r8]
       mov       eax,[r8+4]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M09_L03
       mov       r10d,[rbp-0C]
       add       r10d,0FFFFFFFC
       mov       [rbp-0C],r10d
       rorx      r10d,[rbp-4],1B
       add       r10d,[rbp-4]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-4],edx
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        eax,200020
       xor       edx,eax
       mov       [rbp-8],edx
       add       r8,8
       cmp       dword ptr [rbp-0C],2
       jg        short M09_L00
M09_L01:
       cmp       dword ptr [rbp-0C],0
       jle       short M09_L02
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M09_L03
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        r8d,200020
       xor       r8d,edx
       mov       [rbp-8],r8d
M09_L02:
       xor       eax,eax
       mov       [rbp-18],rax
       imul      eax,[rbp-8],5D588B65
       add       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
M09_L03:
       call      M09_L05
       nop
       mov       rcx,[rbp+10]
       mov       r8d,[rcx+8]
       sub       r8d,[rbp-0C]
       cmp       [rcx+8],r8d
       jae       short M09_L04
       mov       ecx,21
       call      qword ptr [7FFE500DF360]
       int       3
M09_L04:
       mov       edx,r8d
       lea       rdx,[rcx+rdx*2+0C]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-28],rdx
       mov       [rbp-20],ecx
       lea       r8,[rbp-28]
       mov       edx,[rbp-8]
       mov       ecx,[rbp-4]
       call      qword ptr [7FFE508AF858]
       nop
       add       rsp,50
       pop       rbp
       ret
M09_L05:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-18],r8
       add       rsp,28
       ret
; Total bytes of code 320
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M10_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M10_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M11_L12
M11_L00:
       mov       ecx,eax
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M11_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M11_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M11_L17
       cmp       ebp,[r14+8]
       ja        near ptr M11_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M11_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M11_L15
       cmp       r8,4000
       ja        near ptr M11_L14
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M11_L13
M11_L03:
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
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M11_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M11_L11
       jmp       short M11_L06
M11_L04:
       mov       eax,[rdi+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M11_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M11_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M11_L07
M11_L06:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rdi+rdx*8+24],0FFFFFFFF
       jl        short M11_L05
       jmp       short M11_L04
M11_L07:
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
M11_L08:
       mov       rdx,7FFE509262B8
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L02
M11_L09:
       mov       r8d,[rax+10]
       mov       r10,[rbx+8]
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M11_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+14],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M11_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M11_L07
M11_L11:
       cmp       ecx,edx
       jae       near ptr M11_L19
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+14],0FFFFFFFF
       jl        short M11_L10
       jmp       short M11_L09
M11_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M11_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M11_L01
M11_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M11_L03
M11_L14:
       mov       rcx,rax
       call      qword ptr [7FFE5067EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L03
M11_L15:
       mov       rcx,rax
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L03
M11_L16:
       xor       r15d,r15d
       jmp       short M11_L18
M11_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE508ACDC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M11_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE508ACDC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE508ACDE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M11_L03
M11_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M12_L01
       mov       rcx,rax
M12_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rdx,7FFE509262B8
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M12_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M13_L05
       mov       rcx,rax
M13_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE500DF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M13_L08
M13_L01:
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
       mov       [rbx+30],rax
       xor       esi,esi
       test      r14d,r14d
       jle       near ptr M13_L04
       cmp       [rbp+8],r14d
       jl        near ptr M13_L06
M13_L02:
       mov       ecx,esi
       lea       rdi,[rcx+rcx*2]
       cmp       dword ptr [rbp+rdi*8+24],0FFFFFFFF
       jl        short M13_L03
       mov       rcx,7FFE509CD818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rbp+rdi*8+20]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M13_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rbp+rdi*8+24],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M13_L03:
       mov       rcx,7FFE509CD81C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M13_L02
M13_L04:
       mov       rcx,7FFE509CD820
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L05:
       mov       rdx,7FFE509262B8
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L00
M13_L06:
       cmp       esi,[rbp+8]
       jae       near ptr M13_L16
       mov       ecx,esi
       lea       rcx,[rcx+rcx*2]
       lea       rdi,[rbp+rcx*8+10]
       cmp       dword ptr [rdi+14],0FFFFFFFF
       jl        short M13_L07
       mov       rcx,7FFE509CD818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+10]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       imul      rax,rcx
       shr       rax,20
       cmp       eax,[r13+8]
       jae       near ptr M13_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+14],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M13_L07:
       mov       rcx,7FFE509CD81C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M13_L06
       jmp       near ptr M13_L04
M13_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M13_L09
       jmp       short M13_L10
M13_L09:
       mov       rdx,7FFE509BEA70
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M13_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFE509CD5F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
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
       jge       near ptr M13_L15
M13_L11:
       cmp       r15d,[rbp+8]
       jae       near ptr M13_L16
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M13_L14
       mov       rcx,7FFE509CD700
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M13_L12
       jmp       short M13_L13
M13_L12:
       mov       rdx,7FFE50925878
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M13_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FFE509CD708
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M13_L14:
       mov       rcx,7FFE509CD810
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M13_L11
M13_L15:
       mov       rcx,7FFE509CD814
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L01
M13_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 815
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFE500D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L39
       test      r14,r14
       je        near ptr M00_L40
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rdx],rcx
       je        short M00_L01
       xor       edx,edx
M00_L01:
       test      rdx,rdx
       jne       near ptr M00_L41
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L31
       xor       r12d,r12d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-128],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       [rbp-98],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-98]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L04:
       mov       rcx,rdx
M00_L05:
       mov       [rbp-130],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       jne       near ptr M00_L27
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       rax,[rbp-130]
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jae       near ptr M00_L26
M00_L07:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M00_L30
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L25
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[rbp-130]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
M00_L09:
       mov       rsi,[rbp-70]
       mov       rdi,[rbp-68]
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L20
M00_L10:
       mov       rax,[r13+10]
       mov       [rbp-138],rax
       mov       rdx,[r13+18]
       mov       [rbp-140],rdx
       xor       r8d,r8d
       mov       [rbp-9C],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-160]
       call      qword ptr [7FFE500249D8]; System.ValueType.GetHashCode()
       mov       rcx,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M00_L30
       mov       edx,edx
       lea       rdx,[rcx+rdx*4+10]
       mov       [rbp-148],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L17
       mov       r8d,[r13+28]
       mov       [rbp-0A4],r8d
       mov       r11,[rbp-138]
       cmp       [r11+8],r8d
       je        near ptr M00_L16
M00_L12:
       mov       r8d,[rbp-0A4]
       lea       ecx,[r8+1]
       mov       [r13+28],ecx
       mov       r11,[r13+10]
       mov       rcx,r11
M00_L13:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L30
       mov       [rbp-0A8],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-158],r10
       mov       [r10],eax
       mov       rdx,[rbp-148]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-158]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0A8]
       inc       esi
       mov       rdi,[rbp-148]
       mov       [rdi],esi
       inc       dword ptr [r13+34]
       jmp       near ptr M00_L06
M00_L14:
       mov       r10,[rbp-138]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-138],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-168],r8
       mov       [rbp-0A0],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L15:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r10,[rbp-138]
       mov       [rbp-9C],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L29
       test      r8d,r8d
       mov       eax,[rbp-0A0]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       [rbp-0A0],eax
       mov       ecx,[r13+28]
       call      qword ptr [7FFE500EF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE508C5D88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r13+8]
       mov       edx,[rbp-0A0]
       mov       eax,edx
       imul      rax,[r13+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M00_L30
       mov       eax,eax
       lea       rcx,[rcx+rax*4+10]
       mov       rax,rcx
       mov       [rbp-148],rax
       mov       eax,edx
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,[r13+2C]
       mov       r8d,ecx
       dec       dword ptr [r13+30]
       mov       r11,[rbp-138]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L30
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L13
M00_L18:
       call      qword ptr [7FFE500EFC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-130]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FFE50031628
       call      qword ptr [r11]
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE508C5B90]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L10
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-190],r9
       mov       r11,[r8+10]
       mov       [rbp-198],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-170]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-190]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-178]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-178]
       mov       rdx,[rbp-170]
       call      qword ptr [7FFE500249D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FFE50031638
       call      qword ptr [r11]
       mov       r8,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L30
       mov       edx,edx
       lea       rdx,[r8+rdx*4+10]
       mov       r10,rdx
       mov       [rbp-148],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L11
M00_L23:
       mov       r11,[rbp-138]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L30
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-138],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-150],r9
       mov       [rbp-0A0],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       [rbp-118],rsi
       mov       [rbp-110],rdi
       lea       r8,[rbp-118]
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FFE50031640
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-150]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r11,[rbp-138]
       cmp       [r11+8],ecx
       jb        short M00_L29
       test      r9d,r9d
       mov       [rbp-138],r11
       mov       [rbp-9C],ecx
       mov       eax,[rbp-0A0]
       jge       near ptr M00_L23
       jmp       near ptr M00_L11
M00_L25:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M00_L07
M00_L26:
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       short M00_L28
M00_L27:
       mov       rcx,rax
       mov       r11,7FFE50031620
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L47
M00_L29:
       call      qword ptr [7FFE500EF498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FFE500315F0
       call      qword ptr [r11]
       mov       [rbp-120],rax
       mov       rdx,[rbp-120]
       cmp       [rdx],edx
M00_L32:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L36
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5045C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L33:
       test      eax,eax
       je        near ptr M00_L37
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L35
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L34:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-60]
       mov       rcx,r13
       call      qword ptr [7FFE508C5C68]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L32
       mov       r12d,1
       jmp       near ptr M00_L32
M00_L35:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FFE50031600
       call      qword ptr [r11]
       jmp       short M00_L34
M00_L36:
       mov       rcx,[rbp-120]
       mov       r11,7FFE500315F8
       call      qword ptr [r11]
       jmp       near ptr M00_L33
M00_L37:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L43
M00_L38:
       mov       [rbp-0F8],r12b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508C5DA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       xor       r12d,r12d
       jmp       short M00_L38
M00_L40:
       mov       ecx,65
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rcx,rax
       call      qword ptr [7FFE508CDB60]
       int       3
M00_L41:
       call      qword ptr [7FFE508C58F0]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L42
       call      qword ptr [7FFE50997450]
       mov       r12,rax
M00_L42:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE50457DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,[rbp-120]
       mov       r11,7FFE50031608
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L44:
       mov       rcx,r14
       mov       r11,7FFE50031610
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CE02000B08
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L46:
       mov       rcx,r14
       mov       r11,7FFE50031618
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L47:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L48
       mov       rcx,rax
       mov       r11,7FFE50031630
       call      qword ptr [r11]
M00_L48:
       cmp       dword ptr [r13+28],0
       jle       short M00_L49
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r13+28]
       cmp       eax,3
       jle       short M00_L49
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFE50997468]
M00_L49:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L52
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L50
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       [rbp-0D0],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L51
M00_L50:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CE02000B08
       mov       rdx,[rcx]
M00_L51:
       jmp       short M00_L53
M00_L52:
       mov       rcx,r15
       mov       r11,7FFE500315C8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L53:
       mov       [rbp-120],rdx
M00_L54:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L70
       jmp       near ptr M00_L69
M00_L55:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L56
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L57
M00_L56:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-120]
       mov       r11,7FFE500315D8
       call      qword ptr [r11]
M00_L57:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FFE508C5C68]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L68
       mov       r12,r14
       mov       r15,[rbp-40]
       mov       rsi,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L72
       cmp       qword ptr [r12+8],0
       jne       short M00_L58
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFE500E5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L58:
       mov       rdi,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-180],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rax],rcx
       jne       short M00_L59
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50714CA8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       jmp       short M00_L60
M00_L59:
       mov       rax,[rbp-180]
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FFE50031648
       call      qword ptr [r11]
M00_L60:
       mov       [rbp-0DC],eax
       xor       r8d,r8d
       mov       [rbp-0E0],r8d
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FFE50997480]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
       mov       eax,[r12]
       dec       eax
       jmp       near ptr M00_L63
M00_L61:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       r10d,[rbp-0DC]
       cmp       [rdi+rdx*8+20],r10d
       jne       short M00_L62
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       [rbp-0E4],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-180]
       mov       r8,rsi
       mov       r11,7FFE50031650
       call      qword ptr [r11]
       test      eax,eax
       mov       eax,[rbp-0E4]
       jne       near ptr M00_L73
M00_L62:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rdi+rcx*8+24]
       mov       ecx,eax
       mov       r8d,[rbp-0E0]
       inc       r8d
       mov       [rbp-0E0],r8d
       cmp       [rdi+8],r8d
       mov       eax,ecx
       jb        near ptr M00_L74
M00_L63:
       cmp       [rdi+8],eax
       ja        near ptr M00_L61
       cmp       dword ptr [r14+40],0
       jle       short M00_L64
       mov       ecx,[r14+3C]
       mov       eax,ecx
       mov       ecx,[r14+3C]
       cmp       ecx,[rdi+8]
       jae       near ptr M00_L75
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rdi+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+3C],ecx
       dec       dword ptr [r14+40]
       jmp       short M00_L66
M00_L64:
       mov       eax,[r14+38]
       mov       [rbp-0E8],eax
       cmp       [rdi+8],eax
       jne       short M00_L65
       mov       rcx,r14
       call      qword ptr [7FFE508CEE20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FFE50997480]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
M00_L65:
       mov       eax,[rbp-0E8]
       mov       edi,eax
       lea       ecx,[rdi+1]
       mov       [r14+38],ecx
       mov       rcx,[r14+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,edi
       mov       rdi,rcx
M00_L66:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       [rbp-0EC],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r9,[rdi+rcx*8+10]
       mov       [rbp-188],r9
       mov       r10d,[rbp-0DC]
       mov       [r9+10],r10d
       mov       ecx,[r12]
       dec       ecx
       mov       [r9+14],ecx
       mov       rcx,r9
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-188]
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0EC]
       inc       esi
       mov       [r12],esi
       inc       dword ptr [r14+44]
       cmp       dword ptr [rbp-0E0],64
       jbe       short M00_L67
       mov       rdx,[rbp-180]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L67
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFE503773F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L67:
       mov       r12d,1
       jmp       near ptr M00_L54
M00_L68:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r14
       mov       r11,7FFE500315E0
       call      qword ptr [r11]
       jmp       short M00_L67
M00_L69:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5045C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L71
M00_L70:
       mov       rcx,[rbp-120]
       mov       r11,7FFE500315D0
       call      qword ptr [r11]
M00_L71:
       test      eax,eax
       jne       near ptr M00_L55
       jmp       short M00_L76
M00_L72:
       mov       ecx,4
       call      qword ptr [7FFE500EFD50]
       int       3
M00_L73:
       mov       rdx,rsi
       mov       rcx,7FFE5091E9A0
       call      qword ptr [7FFE500EFD20]
       int       3
M00_L74:
       call      qword ptr [7FFE500EF498]
       int       3
M00_L75:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L76:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L77
       mov       rcx,[rbp-120]
       mov       r11,7FFE500315E8
       call      qword ptr [r11]
M00_L77:
       jmp       near ptr M00_L38
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L78
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L78
       mov       rcx,[rbp-120]
       mov       r11,7FFE50031608
       call      qword ptr [r11]
M00_L78:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L79
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L79
       mov       rcx,[rbp-120]
       mov       r11,7FFE500315E8
       call      qword ptr [r11]
M00_L79:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-130],0
       je        short M00_L80
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L80
       mov       rcx,rax
       mov       r11,7FFE50031630
       call      qword ptr [r11]
M00_L80:
       nop
       add       rsp,28
       ret
; Total bytes of code 3825
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFE741A0B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE508CEA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE50455EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFE508CD560]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.ValueType.GetHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
M03_L00:
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx]
       mov       [rbp+10],rbx
       lea       r14,[rbx+8]
       mov       [rbp-0C8],r14
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rcx,rdi
       sar       rcx,20
       xor       ecx,edi
       mov       eax,[rbp-3C]
       lea       edx,[rax+1]
       mov       [rbp-3C],edx
       mov       edx,eax
       and       edx,3
       je        short M03_L02
       cmp       edx,1
       jne       near ptr M03_L23
       mov       [rbp-44],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L03
       test      r15b,4
       je        short M03_L06
       jmp       near ptr M03_L26
M03_L02:
       mov       [rbp-48],ecx
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       mov       rax,7FFE500248F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD2B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L05
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L05:
       mov       r9,[rbp-0A8]
       mov       [rsi+8],r9
       test      eax,eax
       jne       near ptr M03_L26
M03_L06:
       mov       rbx,[rbp+10]
       mov       [rbp-60],rbx
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       [rbp-70],r9d
       mov       [rbp-78],r9
       lea       r9,[rbp-78]
       mov       [rsp+20],r9
       lea       r9,[rbp-70]
       lea       r8,[rbp-68]
       mov       rcx,rdi
       lea       rdx,[rbp-60]
       mov       rax,7FFE50024938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD52B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L08
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L08:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       dec       eax
       jne       near ptr M03_L27
       mov       ecx,[rbp-68]
       mov       r14,[rbp-0C8]
       mov       rcx,[r14+rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       near ptr M03_L28
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       edx,784B27D1
       mov       r8d,709C1FD6
       cmp       ecx,8
       jb        short M03_L10
       mov       r10d,ecx
       shr       r10d,3
M03_L09:
       add       edx,[rax]
       mov       r9d,[rax+4]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
       add       r9d,edx
       mov       edx,r8d
       xor       edx,r9d
       rol       r9d,14
       add       r9d,edx
       rol       edx,9
       xor       edx,r9d
       rol       r9d,1B
       add       r9d,edx
       rol       edx,13
       mov       r8d,r9d
       add       rax,8
       dec       r10d
       mov       r9d,edx
       mov       edx,r8d
       mov       r8d,r9d
       jne       short M03_L09
       test      cl,4
       je        short M03_L12
       jmp       short M03_L11
M03_L10:
       cmp       ecx,4
       jb        near ptr M03_L18
M03_L11:
       add       edx,[rax]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
M03_L12:
       mov       r10d,ecx
       and       r10,7
       mov       eax,[rax+r10-4]
       shr       eax,8
       or        eax,80000000
       not       ecx
       shl       ecx,3
       shrx      ecx,eax,ecx
M03_L13:
       add       ecx,edx
       mov       eax,r8d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
M03_L14:
       mov       ecx,[rbp-3C]
       lea       edx,[rcx+1]
       mov       [rbp-3C],edx
       mov       edx,ecx
       and       edx,3
       je        near ptr M03_L21
       cmp       edx,1
       jne       near ptr M03_L29
       mov       [rbp-44],eax
M03_L15:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L22
       mov       edx,0DC9BF402
M03_L16:
       lea       eax,[rdx+rax*4]
       test      ecx,ecx
       je        short M03_L17
       imul      edx,[rbp-48],0C2B2AE3D
       add       eax,edx
       rol       eax,11
       imul      eax,27D4EB2F
       cmp       ecx,1
       jbe       short M03_L17
       imul      edx,[rbp-44],0C2B2AE3D
       add       edx,eax
       rol       edx,11
       imul      eax,edx,27D4EB2F
       cmp       ecx,2
       ja        near ptr M03_L36
M03_L17:
       mov       ecx,eax
       shr       ecx,0F
       xor       ecx,eax
       imul      eax,ecx,85EBCA77
       mov       ecx,eax
       shr       ecx,0D
       xor       ecx,eax
       imul      eax,ecx,0C2B2AE3D
       mov       ecx,eax
       shr       ecx,10
       xor       eax,ecx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L18:
       mov       r10d,80
       test      cl,1
       je        short M03_L19
       mov       r10d,ecx
       and       r10,2
       movzx     r10d,byte ptr [rax+r10]
       or        r10d,8000
M03_L19:
       test      cl,2
       jne       short M03_L20
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L20:
       shl       r10d,10
       movzx     ecx,word ptr [rax]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L21:
       mov       [rbp-48],eax
       jmp       near ptr M03_L15
M03_L22:
       rorx      edx,[rbp-58],1F
       rorx      r8d,[rbp-54],19
       add       edx,r8d
       rorx      r8d,[rbp-50],14
       add       edx,r8d
       rorx      r8d,[rbp-4C],0E
       add       edx,r8d
       jmp       near ptr M03_L16
M03_L23:
       cmp       edx,2
       jne       short M03_L24
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L24:
       cmp       eax,3
       jne       short M03_L25
       mov       dword ptr [rbp-58],0EA68D079
       mov       dword ptr [rbp-54],4C3156C8
       mov       dword ptr [rbp-50],0C6458C51
       mov       dword ptr [rbp-4C],280E12A0
M03_L25:
       imul      eax,[rbp-48],85EBCA77
       add       eax,[rbp-58]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-58],eax
       imul      eax,[rbp-44],85EBCA77
       add       eax,[rbp-54]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-54],eax
       imul      eax,[rbp-40],85EBCA77
       add       eax,[rbp-50]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-50],eax
       imul      ecx,85EBCA77
       add       ecx,[rbp-4C]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L01
M03_L26:
       mov       rcx,rdi
       call      00007FFEAFD327D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50995E30]
       jmp       near ptr M03_L15
M03_L27:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FFE509F7D18]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M03_L00]
       add       rcx,rax
       jmp       rcx
M03_L28:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L14
M03_L29:
       cmp       edx,2
       jne       short M03_L30
       mov       [rbp-40],eax
       jmp       near ptr M03_L15
M03_L30:
       cmp       ecx,3
       jne       short M03_L31
       mov       dword ptr [rbp-58],0EA68D079
       mov       dword ptr [rbp-54],4C3156C8
       mov       dword ptr [rbp-50],0C6458C51
       mov       dword ptr [rbp-4C],280E12A0
M03_L31:
       imul      ecx,[rbp-48],85EBCA77
       add       ecx,[rbp-58]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-58],ecx
       imul      ecx,[rbp-44],85EBCA77
       add       ecx,[rbp-54]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-54],ecx
       imul      ecx,[rbp-40],85EBCA77
       add       ecx,[rbp-50]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-50],ecx
       imul      eax,85EBCA77
       add       eax,[rbp-4C]
       rol       eax,0D
       imul      ecx,eax,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rdx]
       mov       rdx,[rdx]
       dec       rdx
       mov       rax,7FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,7FF0000000000000
       cmp       rdx,rax
       jb        short M03_L32
       mov       rdx,7FF0000000000000
       and       rcx,rdx
M03_L32:
       mov       rdx,rcx
       shr       rdx,20
       xor       edx,ecx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       ecx,[rbp-68]
       add       rcx,[rbp-0C8]
       mov       edx,[rcx]
       mov       ecx,[rcx]
       dec       ecx
       and       ecx,7FFFFFFF
       cmp       ecx,7F800000
       jb        short M03_L33
       and       edx,7F800000
M03_L33:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50995E30]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE50996C58]
       test      rax,rax
       jne       short M03_L34
       xor       edx,edx
       jmp       short M03_L35
M03_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edx,eax
M03_L35:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
M03_L36:
       imul      ecx,[rbp-40],0C2B2AE3D
       add       ecx,eax
       rol       ecx,11
       imul      eax,ecx,27D4EB2F
       jmp       near ptr M03_L17
; Total bytes of code 1621
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M05_L06
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M05_L13
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M05_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L14
       cmp       ebp,[r14+8]
       ja        near ptr M05_L14
       cmp       ebp,[rdi+8]
       ja        near ptr M05_L14
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L12
       cmp       r8,4000
       ja        near ptr M05_L11
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M05_L10
M05_L01:
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
       jle       short M05_L05
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L09
       jmp       short M05_L04
       nop       dword ptr [rax]
M05_L02:
       mov       eax,[rdx]
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
       jae       near ptr M05_L16
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L03:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L04:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M05_L03
       jmp       short M05_L02
M05_L05:
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
M05_L06:
       mov       rdx,7FFE508BC328
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       r8d,[rax]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M05_L16
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+4],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M05_L08:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L09:
       cmp       ecx,edx
       jae       short M05_L16
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M05_L08
       jmp       short M05_L07
M05_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFE5068F078]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE508CCF78]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE508CCF78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE508CCF90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
M06_L00:
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
M06_L01:
       mov       rdx,7FFE508BC328
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M07_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M07_L03
M07_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M07_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M07_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       call      qword ptr [7FFE500EFC60]
       int       3
M07_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M07_L00
M07_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rbp,rdx
       mov       r14,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L06
M08_L00:
       mov       r15,[rbx+10]
       mov       r13,[rbx+18]
       xor       r12d,r12d
       test      r13,r13
       jne       near ptr M08_L11
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       lea       rdi,[rdx+8]
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rcx,rdx
       call      qword ptr [7FFE500249D8]; System.ValueType.GetHashCode()
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r13,[rcx+rdx*4+10]
       mov       edi,[r13]
       dec       edi
       jns       short M08_L04
M08_L01:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M08_L20
       mov       r12d,[rbx+28]
       cmp       [r15+8],r12d
       je        near ptr M08_L21
M08_L02:
       lea       eax,[r12+1]
       mov       [rbx+28],eax
       mov       r15,[rbx+10]
M08_L03:
       cmp       r12d,[r15+8]
       jae       near ptr M08_L22
       mov       eax,r12d
       lea       rax,[rax+rax*2]
       lea       rdi,[r15+rax*8+10]
       mov       [rdi],esi
       mov       eax,[r13]
       dec       eax
       mov       [rdi+4],eax
       add       rdi,8
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       eax,[r12+1]
       mov       [r13],eax
       inc       dword ptr [rbx+34]
       mov       [r14],r12d
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L04:
       cmp       edi,[r15+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rax,[r15+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],esi
       je        short M08_L07
M08_L05:
       mov       rax,[rsp+30]
       mov       edi,[rax+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M08_L19
       test      edi,edi
       jge       short M08_L04
       jmp       near ptr M08_L01
M08_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE508C5B90]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M08_L08
       jmp       short M08_L09
M08_L08:
       mov       rdx,7FFE508BC2A8
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L09:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rax,[rsp+30]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       r10,[rcx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       test      eax,eax
       je        near ptr M08_L05
       mov       [r14],edi
M08_L10:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M08_L12
       jmp       short M08_L13
M08_L12:
       mov       rdx,7FFE508BC650
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L13:
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rdx,[rsp+48]
       mov       rcx,r13
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L22
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       rdi,rcx
       mov       eax,[rdi]
       dec       eax
       jns       short M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L14:
       cmp       eax,[r15+8]
       jae       near ptr M08_L22
       mov       [rsp+5C],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r15+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8],esi
       jne       short M08_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M08_L15
       jmp       short M08_L16
M08_L15:
       mov       rdx,7FFE508BC668
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L16:
       mov       rax,[rsp+28]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L18
M08_L17:
       mov       r8,[rsp+28]
       mov       eax,[r8+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        short M08_L19
       test      eax,eax
       jge       near ptr M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L18:
       mov       eax,[rsp+5C]
       mov       [r14],eax
       jmp       near ptr M08_L10
M08_L19:
       call      qword ptr [7FFE500EF498]
       int       3
M08_L20:
       mov       eax,[rbx+2C]
       mov       r12d,eax
       dec       dword ptr [rbx+30]
       cmp       eax,[r15+8]
       jae       short M08_L22
       lea       rax,[rax+rax*2]
       mov       eax,[r15+rax*8+14]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+2C],eax
       jmp       near ptr M08_L03
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508C5CF8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
       mov       rax,[rbx+8]
       mov       ecx,esi
       imul      rcx,[rbx+20]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       mov       r8d,edx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       short M08_L22
       mov       ecx,ecx
       lea       r13,[rax+rcx*4+10]
       jmp       near ptr M08_L02
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 916
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFE500E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M11_L01
       mov       rcx,rax
M11_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rdx,7FFE509357E0
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M11_L00
; Total bytes of code 170
```
```assembly
; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-28],xmm4
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-4],15051505
       mov       dword ptr [rbp-8],15051505
       mov       r8d,[rcx+8]
       mov       [rbp-0C],r8d
       lea       r8,[rcx+0C]
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       cmp       dword ptr [rbp-0C],2
       jle       short M12_L01
M12_L00:
       mov       edx,[r8]
       mov       eax,[r8+4]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M12_L03
       mov       r10d,[rbp-0C]
       add       r10d,0FFFFFFFC
       mov       [rbp-0C],r10d
       rorx      r10d,[rbp-4],1B
       add       r10d,[rbp-4]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-4],edx
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        eax,200020
       xor       edx,eax
       mov       [rbp-8],edx
       add       r8,8
       cmp       dword ptr [rbp-0C],2
       jg        short M12_L00
M12_L01:
       cmp       dword ptr [rbp-0C],0
       jle       short M12_L02
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M12_L03
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        r8d,200020
       xor       r8d,edx
       mov       [rbp-8],r8d
M12_L02:
       xor       eax,eax
       mov       [rbp-18],rax
       imul      eax,[rbp-8],5D588B65
       add       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
M12_L03:
       call      M12_L05
       nop
       mov       rcx,[rbp+10]
       mov       r8d,[rcx+8]
       sub       r8d,[rbp-0C]
       cmp       [rcx+8],r8d
       jae       short M12_L04
       mov       ecx,21
       call      qword ptr [7FFE500EF360]
       int       3
M12_L04:
       mov       edx,r8d
       lea       rdx,[rcx+rdx*2+0C]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-28],rdx
       mov       [rbp-20],ecx
       lea       r8,[rbp-28]
       mov       edx,[rbp-8]
       mov       ecx,[rbp-4]
       call      qword ptr [7FFE508CF6F0]
       nop
       add       rsp,50
       pop       rbp
       ret
M12_L05:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-18],r8
       add       rsp,28
       ret
; Total bytes of code 320
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M13_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M13_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M14_L12
M14_L00:
       mov       ecx,eax
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M14_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M14_L08
       mov       rcx,rax
M14_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M14_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M14_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M14_L17
       cmp       ebp,[r14+8]
       ja        near ptr M14_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M14_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M14_L15
       cmp       r8,4000
       ja        near ptr M14_L14
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M14_L13
M14_L03:
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
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M14_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M14_L11
       jmp       short M14_L06
M14_L04:
       mov       eax,[rdi+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M14_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M14_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L06:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rdi+rdx*8+24],0FFFFFFFF
       jl        short M14_L05
       jmp       short M14_L04
M14_L07:
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
M14_L08:
       mov       rdx,7FFE509357E0
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L02
M14_L09:
       mov       r8d,[rax+10]
       mov       r10,[rbx+8]
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M14_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+14],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M14_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L11:
       cmp       ecx,edx
       jae       near ptr M14_L19
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+14],0FFFFFFFF
       jl        short M14_L10
       jmp       short M14_L09
M14_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M14_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M14_L01
M14_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L03
M14_L14:
       mov       rcx,rax
       call      qword ptr [7FFE5068F078]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L15:
       mov       rcx,rax
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L16:
       xor       r15d,r15d
       jmp       short M14_L18
M14_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE508CCF78]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M14_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE508CCF78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE508CCF90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M14_L03
M14_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M15_L05
       mov       rcx,rax
M15_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE500EF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M15_L08
M15_L01:
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
       mov       [rbx+30],rax
       xor       esi,esi
       test      r14d,r14d
       jle       near ptr M15_L04
       cmp       [rbp+8],r14d
       jl        near ptr M15_L06
M15_L02:
       mov       ecx,esi
       lea       rdi,[rcx+rcx*2]
       cmp       dword ptr [rbp+rdi*8+24],0FFFFFFFF
       jl        short M15_L03
       mov       rcx,7FFE509DCF30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rbp+rdi*8+20]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rbp+rdi*8+24],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L03:
       mov       rcx,7FFE509DCF34
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M15_L02
M15_L04:
       mov       rcx,7FFE509DCF38
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L05:
       mov       rdx,7FFE509357E0
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M15_L00
M15_L06:
       cmp       esi,[rbp+8]
       jae       near ptr M15_L16
       mov       ecx,esi
       lea       rcx,[rcx+rcx*2]
       lea       rdi,[rbp+rcx*8+10]
       cmp       dword ptr [rdi+14],0FFFFFFFF
       jl        short M15_L07
       mov       rcx,7FFE509DCF30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+10]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       imul      rax,rcx
       shr       rax,20
       cmp       eax,[r13+8]
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+14],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L07:
       mov       rcx,7FFE509DCF34
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M15_L06
       jmp       near ptr M15_L04
M15_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M15_L09
       jmp       short M15_L10
M15_L09:
       mov       rdx,7FFE509BE898
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M15_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFE509DCD10
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
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
       jge       near ptr M15_L15
M15_L11:
       cmp       r15d,[rbp+8]
       jae       near ptr M15_L16
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M15_L14
       mov       rcx,7FFE509DCE18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M15_L12
       jmp       short M15_L13
M15_L12:
       mov       rdx,7FFE50934DA0
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M15_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FFE509DCE20
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M15_L14:
       mov       rcx,7FFE509DCF28
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M15_L11
M15_L15:
       mov       rcx,7FFE509DCF2C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L01
M15_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 815
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L37
       test      r14,r14
       je        near ptr M00_L38
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rdx],rcx
       je        short M00_L01
       xor       edx,edx
M00_L01:
       test      rdx,rdx
       jne       near ptr M00_L39
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L29
       xor       r12d,r12d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L42
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FFE500A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-128],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L43
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       [rbp-98],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-98]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L04:
       mov       rcx,rdx
M00_L05:
       mov       [rbp-130],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       jne       near ptr M00_L25
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L17
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jae       near ptr M00_L28
M00_L07:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M00_L27
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L24
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       vmovdqu   xmm0,xmmword ptr [rax+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
M00_L08:
       mov       rsi,[rbp-70]
       mov       rdi,[rbp-68]
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L19
M00_L09:
       mov       rdx,[r13+10]
       mov       [rbp-138],rdx
       mov       r8,[r13+18]
       mov       [rbp-140],r8
       xor       r10d,r10d
       mov       [rbp-9C],r10d
       test      r8,r8
       jne       near ptr M00_L21
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-160]
       call      qword ptr [7FFE4FFE49D8]; System.ValueType.GetHashCode()
       mov       rcx,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M00_L27
       mov       edx,edx
       lea       rdx,[rcx+rdx*4+10]
       mov       [rbp-148],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L13
M00_L10:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L16
       mov       r8d,[r13+28]
       mov       [rbp-0A4],r8d
       mov       r11,[rbp-138]
       cmp       [r11+8],r8d
       je        near ptr M00_L15
M00_L11:
       mov       r8d,[rbp-0A4]
       lea       ecx,[r8+1]
       mov       [r13+28],ecx
       mov       r11,[r13+10]
       mov       rcx,r11
M00_L12:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L27
       mov       [rbp-0A8],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-158],r10
       mov       [r10],eax
       mov       rdx,[rbp-148]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-158]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0A8]
       inc       esi
       mov       rdi,[rbp-148]
       mov       [rdi],esi
       inc       dword ptr [r13+34]
       jmp       near ptr M00_L06
M00_L13:
       mov       r10,[rbp-138]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-138],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-168],r8
       mov       [rbp-0A0],eax
       cmp       [r8],eax
       je        near ptr M00_L20
M00_L14:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r10,[rbp-138]
       mov       [rbp-9C],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L26
       test      r8d,r8d
       mov       eax,[rbp-0A0]
       jge       short M00_L13
       jmp       near ptr M00_L10
M00_L15:
       mov       [rbp-0A0],eax
       mov       ecx,[r13+28]
       call      qword ptr [7FFE500AF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE50866850]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r13+8]
       mov       edx,[rbp-0A0]
       mov       eax,edx
       imul      rax,[r13+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M00_L27
       mov       eax,eax
       lea       rcx,[rcx+rax*4+10]
       mov       rax,rcx
       mov       [rbp-148],rax
       mov       eax,edx
       jmp       near ptr M00_L11
M00_L16:
       mov       ecx,[r13+2C]
       mov       r8d,ecx
       dec       dword ptr [r13+30]
       mov       r11,[rbp-138]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L27
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L12
M00_L17:
       call      qword ptr [7FFE500AFC60]
       int       3
M00_L18:
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FFE4FFF1608
       call      qword ptr [r11]
       mov       rax,[rbp-130]
       jmp       near ptr M00_L08
M00_L19:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE50866658]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-130]
       jmp       near ptr M00_L09
M00_L20:
       mov       r9,[r8+8]
       mov       [rbp-190],r9
       mov       r11,[r8+10]
       mov       [rbp-198],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-170]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-190]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-178]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-178]
       mov       rdx,[rbp-170]
       call      qword ptr [7FFE4FFE49D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L14
       jmp       near ptr M00_L06
M00_L21:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r8
       mov       r11,7FFE4FFF1618
       call      qword ptr [r11]
       mov       r8,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L27
       mov       edx,edx
       lea       rdx,[r8+rdx*4+10]
       mov       r10,rdx
       mov       [rbp-148],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L10
M00_L22:
       mov       r11,[rbp-138]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L27
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-138],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-150],r9
       mov       [rbp-0A0],eax
       cmp       [r9],eax
       jne       short M00_L23
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       [rbp-118],rsi
       mov       [rbp-110],rdi
       lea       r8,[rbp-118]
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FFE4FFF1620
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-150]
       jne       near ptr M00_L06
M00_L23:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r11,[rbp-138]
       cmp       [r11+8],ecx
       jb        short M00_L26
       test      r9d,r9d
       mov       [rbp-138],r11
       mov       [rbp-9C],ecx
       mov       eax,[rbp-0A0]
       jge       near ptr M00_L22
       jmp       near ptr M00_L10
M00_L24:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M00_L07
       jmp       short M00_L28
M00_L25:
       mov       rcx,rax
       mov       r11,7FFE4FFF1600
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L45
M00_L26:
       call      qword ptr [7FFE500AF498]
       int       3
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       near ptr M00_L45
M00_L29:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FFE4FFF15D0
       call      qword ptr [r11]
       mov       [rbp-120],rax
       mov       rdx,[rbp-120]
       cmp       [rdx],edx
M00_L30:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L34
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5041C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L31:
       test      eax,eax
       je        near ptr M00_L35
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L33
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L32:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-60]
       mov       rcx,r13
       call      qword ptr [7FFE50866730]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L30
       mov       r12d,1
       jmp       near ptr M00_L30
M00_L33:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15E0
       call      qword ptr [r11]
       jmp       short M00_L32
M00_L34:
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15D8
       call      qword ptr [r11]
       jmp       near ptr M00_L31
M00_L35:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L41
M00_L36:
       mov       [rbp-0F8],r12b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50866868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L37:
       xor       r12d,r12d
       jmp       short M00_L36
M00_L38:
       mov       ecx,65
       mov       rdx,7FFE504AC720
       call      qword ptr [7FFE500AF228]
       mov       rcx,rax
       call      qword ptr [7FFE5086E130]
       int       3
M00_L39:
       call      qword ptr [7FFE508663B8]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L40
       call      qword ptr [7FFE509371E0]
       mov       r12,rax
M00_L40:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FFE504AC720
       call      qword ptr [7FFE500AF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE50417DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15E8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L42:
       mov       rcx,r14
       mov       r11,7FFE4FFF15F0
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L43:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2CDF3800B48
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L44:
       mov       rcx,r14
       mov       r11,7FFE4FFF15F8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L45:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFE4FFF1610
       call      qword ptr [r11]
M00_L46:
       cmp       dword ptr [r13+28],0
       jle       short M00_L47
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r13+28]
       cmp       eax,3
       jle       short M00_L47
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFE509371F8]
M00_L47:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L50
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L48
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       [rbp-0D0],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L49
M00_L48:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2CDF3800B48
       mov       rdx,[rcx]
M00_L49:
       jmp       short M00_L51
M00_L50:
       mov       rcx,r15
       mov       r11,7FFE4FFF15A8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L51:
       mov       [rbp-120],rdx
M00_L52:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L68
       jmp       near ptr M00_L67
M00_L53:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L54
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L55
M00_L54:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15B8
       call      qword ptr [r11]
M00_L55:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FFE50866730]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L66
       mov       r12,r14
       mov       r15,[rbp-40]
       mov       rsi,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L70
       cmp       qword ptr [r12+8],0
       jne       short M00_L56
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFE500A5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L56:
       mov       rdi,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-180],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rax],rcx
       jne       short M00_L57
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5064CEB8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       jmp       short M00_L58
M00_L57:
       mov       rax,[rbp-180]
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FFE4FFF1628
       call      qword ptr [r11]
M00_L58:
       mov       [rbp-0DC],eax
       xor       r8d,r8d
       mov       [rbp-0E0],r8d
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FFE50937210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
       mov       eax,[r12]
       dec       eax
       jmp       near ptr M00_L61
M00_L59:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L73
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       r10d,[rbp-0DC]
       cmp       [rdi+rdx*8+20],r10d
       jne       short M00_L60
       cmp       eax,[rdi+8]
       jae       near ptr M00_L73
       mov       [rbp-0E4],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-180]
       mov       r8,rsi
       mov       r11,7FFE4FFF1630
       call      qword ptr [r11]
       test      eax,eax
       mov       eax,[rbp-0E4]
       jne       near ptr M00_L71
M00_L60:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L73
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rdi+rcx*8+24]
       mov       ecx,eax
       mov       r8d,[rbp-0E0]
       inc       r8d
       mov       [rbp-0E0],r8d
       cmp       [rdi+8],r8d
       mov       eax,ecx
       jb        near ptr M00_L72
M00_L61:
       cmp       [rdi+8],eax
       ja        near ptr M00_L59
       cmp       dword ptr [r14+40],0
       jle       short M00_L62
       mov       ecx,[r14+3C]
       mov       eax,ecx
       mov       ecx,[r14+3C]
       cmp       ecx,[rdi+8]
       jae       near ptr M00_L73
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rdi+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+3C],ecx
       dec       dword ptr [r14+40]
       jmp       short M00_L64
M00_L62:
       mov       eax,[r14+38]
       mov       [rbp-0E8],eax
       cmp       [rdi+8],eax
       jne       short M00_L63
       mov       rcx,r14
       call      qword ptr [7FFE5086F0D8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FFE50937210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
M00_L63:
       mov       eax,[rbp-0E8]
       mov       edi,eax
       lea       ecx,[rdi+1]
       mov       [r14+38],ecx
       mov       rcx,[r14+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,edi
       mov       rdi,rcx
M00_L64:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L73
       mov       [rbp-0EC],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r9,[rdi+rcx*8+10]
       mov       [rbp-188],r9
       mov       r10d,[rbp-0DC]
       mov       [r9+10],r10d
       mov       ecx,[r12]
       dec       ecx
       mov       [r9+14],ecx
       mov       rcx,r9
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-188]
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0EC]
       inc       esi
       mov       [r12],esi
       inc       dword ptr [r14+44]
       cmp       dword ptr [rbp-0E0],64
       jbe       short M00_L65
       mov       rdx,[rbp-180]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L65
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFE503373F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L65:
       mov       r12d,1
       jmp       near ptr M00_L52
M00_L66:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r14
       mov       r11,7FFE4FFF15C0
       call      qword ptr [r11]
       jmp       short M00_L65
M00_L67:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5041C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L69
M00_L68:
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15B0
       call      qword ptr [r11]
M00_L69:
       test      eax,eax
       jne       near ptr M00_L53
       jmp       short M00_L74
M00_L70:
       mov       ecx,4
       call      qword ptr [7FFE500AFD50]
       int       3
M00_L71:
       mov       rdx,rsi
       mov       rcx,7FFE508BD9B8
       call      qword ptr [7FFE500AFD20]
       int       3
M00_L72:
       call      qword ptr [7FFE500AF498]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L75
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15C8
       call      qword ptr [r11]
M00_L75:
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L76
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L76
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15E8
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L77
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L77
       mov       rcx,[rbp-120]
       mov       r11,7FFE4FFF15C8
       call      qword ptr [r11]
M00_L77:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-130],0
       je        short M00_L78
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L78
       mov       rcx,rax
       mov       r11,7FFE4FFF1610
       call      qword ptr [r11]
M00_L78:
       nop
       add       rsp,28
       ret
; Total bytes of code 3791
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFE741A0B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5086EE68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE50415EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFE5086CCC0]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.ValueType.GetHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
M03_L00:
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx]
       mov       [rbp+10],rbx
       lea       r14,[rbx+8]
       mov       [rbp-0C8],r14
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rcx,rdi
       sar       rcx,20
       xor       ecx,edi
       mov       eax,[rbp-3C]
       lea       edx,[rax+1]
       mov       [rbp-3C],edx
       mov       edx,eax
       and       edx,3
       jne       short M03_L02
       mov       [rbp-48],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L03
       test      r15b,4
       je        short M03_L06
       jmp       near ptr M03_L25
M03_L02:
       cmp       edx,1
       jne       near ptr M03_L22
       mov       [rbp-44],ecx
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       mov       rax,7FFE4FFE48F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD2B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L05
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L05:
       mov       r9,[rbp-0A8]
       mov       [rsi+8],r9
       test      eax,eax
       jne       near ptr M03_L25
M03_L06:
       mov       rbx,[rbp+10]
       mov       [rbp-60],rbx
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       [rbp-70],r9d
       mov       [rbp-78],r9
       lea       r9,[rbp-78]
       mov       [rsp+20],r9
       lea       r9,[rbp-70]
       lea       r8,[rbp-68]
       mov       rcx,rdi
       lea       rdx,[rbp-60]
       mov       rax,7FFE4FFE4938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD52B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L08
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L08:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       dec       eax
       jne       near ptr M03_L26
       mov       ecx,[rbp-68]
       mov       r14,[rbp-0C8]
       mov       rcx,[r14+rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       near ptr M03_L27
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       edx,7012C406
       mov       r8d,1D2F84AB
       cmp       ecx,8
       jb        short M03_L10
       mov       r10d,ecx
       shr       r10d,3
M03_L09:
       add       edx,[rax]
       mov       r9d,[rax+4]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
       add       r9d,edx
       mov       edx,r8d
       xor       edx,r9d
       rol       r9d,14
       add       r9d,edx
       rol       edx,9
       xor       edx,r9d
       rol       r9d,1B
       add       r9d,edx
       rol       edx,13
       mov       r8d,r9d
       add       rax,8
       dec       r10d
       mov       r9d,edx
       mov       edx,r8d
       mov       r8d,r9d
       jne       short M03_L09
       test      cl,4
       je        short M03_L12
       jmp       short M03_L11
M03_L10:
       cmp       ecx,4
       jb        near ptr M03_L18
M03_L11:
       add       edx,[rax]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
M03_L12:
       mov       r10d,ecx
       and       r10,7
       mov       eax,[rax+r10-4]
       shr       eax,8
       or        eax,80000000
       not       ecx
       shl       ecx,3
       shrx      ecx,eax,ecx
M03_L13:
       add       ecx,edx
       mov       eax,r8d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
M03_L14:
       mov       ecx,[rbp-3C]
       lea       edx,[rcx+1]
       mov       [rbp-3C],edx
       mov       edx,ecx
       and       edx,3
       jne       near ptr M03_L21
       mov       [rbp-48],eax
M03_L15:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,3DAB4FF6
M03_L16:
       lea       eax,[rdx+rax*4]
       test      ecx,ecx
       je        short M03_L17
       imul      edx,[rbp-48],0C2B2AE3D
       add       eax,edx
       rol       eax,11
       imul      eax,27D4EB2F
       cmp       ecx,1
       jbe       short M03_L17
       imul      edx,[rbp-44],0C2B2AE3D
       add       edx,eax
       rol       edx,11
       imul      eax,edx,27D4EB2F
       cmp       ecx,2
       ja        near ptr M03_L36
M03_L17:
       mov       ecx,eax
       shr       ecx,0F
       xor       ecx,eax
       imul      eax,ecx,85EBCA77
       mov       ecx,eax
       shr       ecx,0D
       xor       ecx,eax
       imul      eax,ecx,0C2B2AE3D
       mov       ecx,eax
       shr       ecx,10
       xor       eax,ecx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L18:
       mov       r10d,80
       test      cl,1
       je        short M03_L19
       mov       r10d,ecx
       and       r10,2
       movzx     r10d,byte ptr [rax+r10]
       or        r10d,8000
M03_L19:
       test      cl,2
       jne       short M03_L20
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L20:
       shl       r10d,10
       movzx     ecx,word ptr [rax]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L21:
       cmp       edx,1
       jne       near ptr M03_L28
       mov       [rbp-44],eax
       jmp       near ptr M03_L15
M03_L22:
       cmp       edx,2
       jne       short M03_L23
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L23:
       cmp       eax,3
       jne       short M03_L24
       mov       dword ptr [rbp-58],4B782C6D
       mov       dword ptr [rbp-54],0AD40B2BC
       mov       dword ptr [rbp-50],2754E845
       mov       dword ptr [rbp-4C],891D6E94
M03_L24:
       imul      eax,[rbp-48],85EBCA77
       add       eax,[rbp-58]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-58],eax
       imul      eax,[rbp-44],85EBCA77
       add       eax,[rbp-54]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-54],eax
       imul      eax,[rbp-40],85EBCA77
       add       eax,[rbp-50]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-50],eax
       imul      ecx,85EBCA77
       add       ecx,[rbp-4C]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L01
M03_L25:
       mov       rcx,rdi
       call      00007FFEAFD327D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50936070]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FFE509B4078]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M03_L00]
       add       rcx,rax
       jmp       rcx
M03_L27:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L14
M03_L28:
       cmp       edx,2
       jne       short M03_L29
       mov       [rbp-40],eax
       jmp       near ptr M03_L15
M03_L29:
       cmp       ecx,3
       jne       short M03_L30
       mov       dword ptr [rbp-58],4B782C6D
       mov       dword ptr [rbp-54],0AD40B2BC
       mov       dword ptr [rbp-50],2754E845
       mov       dword ptr [rbp-4C],891D6E94
M03_L30:
       imul      ecx,[rbp-48],85EBCA77
       add       ecx,[rbp-58]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-58],ecx
       imul      ecx,[rbp-44],85EBCA77
       add       ecx,[rbp-54]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-54],ecx
       imul      ecx,[rbp-40],85EBCA77
       add       ecx,[rbp-50]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-50],ecx
       imul      eax,85EBCA77
       add       eax,[rbp-4C]
       rol       eax,0D
       imul      ecx,eax,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rdx]
       mov       rdx,[rdx]
       dec       rdx
       mov       rax,7FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,7FF0000000000000
       cmp       rdx,rax
       jb        short M03_L31
       mov       rdx,7FF0000000000000
       and       rcx,rdx
M03_L31:
       mov       rdx,rcx
       shr       rdx,20
       xor       edx,ecx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504BD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       ecx,[rbp-68]
       add       rcx,[rbp-0C8]
       mov       edx,[rcx]
       mov       ecx,[rcx]
       dec       ecx
       and       ecx,7FFFFFFF
       cmp       ecx,7F800000
       jb        short M03_L32
       and       edx,7F800000
M03_L32:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504BD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50936070]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE50936868]
       test      rax,rax
       jne       short M03_L33
       xor       edx,edx
       jmp       short M03_L34
M03_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edx,eax
M03_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504BD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
M03_L35:
       rorx      edx,[rbp-58],1F
       rorx      r8d,[rbp-54],19
       add       edx,r8d
       rorx      r8d,[rbp-50],14
       add       edx,r8d
       rorx      r8d,[rbp-4C],0E
       add       edx,r8d
       jmp       near ptr M03_L16
M03_L36:
       imul      ecx,[rbp-40],0C2B2AE3D
       add       ecx,eax
       rol       ecx,11
       imul      eax,ecx,27D4EB2F
       jmp       near ptr M03_L17
; Total bytes of code 1621
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFE500A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M05_L06
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M05_L13
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M05_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L14
       cmp       ebp,[r14+8]
       ja        near ptr M05_L14
       cmp       ebp,[rdi+8]
       ja        near ptr M05_L14
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L12
       cmp       r8,4000
       ja        near ptr M05_L11
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M05_L10
M05_L01:
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
       jle       short M05_L05
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L09
       jmp       short M05_L04
       nop       dword ptr [rax]
M05_L02:
       mov       eax,[rdx]
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
       jae       near ptr M05_L16
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L03:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L04:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M05_L03
       jmp       short M05_L02
M05_L05:
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
M05_L06:
       mov       rdx,7FFE5085E2B0
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       r8d,[rax]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M05_L16
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+4],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M05_L08:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L09:
       cmp       ecx,edx
       jae       short M05_L16
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M05_L08
       jmp       short M05_L07
M05_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFE5064E988]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFE500A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE5086D698]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5086D698]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE5086F180]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
M06_L00:
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
M06_L01:
       mov       rdx,7FFE5085E2B0
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M07_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M07_L03
M07_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M07_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M07_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       call      qword ptr [7FFE500AFC60]
       int       3
M07_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M07_L00
M07_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rbp,rdx
       mov       r14,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L06
M08_L00:
       mov       r15,[rbx+10]
       mov       r13,[rbx+18]
       xor       r12d,r12d
       test      r13,r13
       jne       near ptr M08_L11
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       lea       rdi,[rdx+8]
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rcx,rdx
       call      qword ptr [7FFE4FFE49D8]; System.ValueType.GetHashCode()
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r13,[rcx+rdx*4+10]
       mov       edi,[r13]
       dec       edi
       jns       short M08_L04
M08_L01:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M08_L20
       mov       r12d,[rbx+28]
       cmp       [r15+8],r12d
       je        near ptr M08_L21
M08_L02:
       lea       eax,[r12+1]
       mov       [rbx+28],eax
       mov       r15,[rbx+10]
M08_L03:
       cmp       r12d,[r15+8]
       jae       near ptr M08_L22
       mov       eax,r12d
       lea       rax,[rax+rax*2]
       lea       rdi,[r15+rax*8+10]
       mov       [rdi],esi
       mov       eax,[r13]
       dec       eax
       mov       [rdi+4],eax
       add       rdi,8
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       eax,[r12+1]
       mov       [r13],eax
       inc       dword ptr [rbx+34]
       mov       [r14],r12d
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L04:
       cmp       edi,[r15+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rax,[r15+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],esi
       je        short M08_L07
M08_L05:
       mov       rax,[rsp+30]
       mov       edi,[rax+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M08_L19
       test      edi,edi
       jge       short M08_L04
       jmp       near ptr M08_L01
M08_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE50866658]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M08_L08
       jmp       short M08_L09
M08_L08:
       mov       rdx,7FFE5085E230
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L09:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rax,[rsp+30]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       r10,[rcx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       test      eax,eax
       je        near ptr M08_L05
       mov       [r14],edi
M08_L10:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M08_L12
       jmp       short M08_L13
M08_L12:
       mov       rdx,7FFE5085E5D8
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L13:
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rdx,[rsp+48]
       mov       rcx,r13
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L22
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       rdi,rcx
       mov       eax,[rdi]
       dec       eax
       jns       short M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L14:
       cmp       eax,[r15+8]
       jae       near ptr M08_L22
       mov       [rsp+5C],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r15+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8],esi
       jne       short M08_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M08_L15
       jmp       short M08_L16
M08_L15:
       mov       rdx,7FFE5085E5F0
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L16:
       mov       rax,[rsp+28]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L18
M08_L17:
       mov       r8,[rsp+28]
       mov       eax,[r8+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        short M08_L19
       test      eax,eax
       jge       near ptr M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L18:
       mov       eax,[rsp+5C]
       mov       [r14],eax
       jmp       near ptr M08_L10
M08_L19:
       call      qword ptr [7FFE500AF498]
       int       3
M08_L20:
       mov       eax,[rbx+2C]
       mov       r12d,eax
       dec       dword ptr [rbx+30]
       cmp       eax,[r15+8]
       jae       short M08_L22
       lea       rax,[rax+rax*2]
       mov       eax,[r15+rax*8+14]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+2C],eax
       jmp       near ptr M08_L03
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508667C0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
       mov       rax,[rbx+8]
       mov       ecx,esi
       imul      rcx,[rbx+20]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       mov       r8d,edx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       short M08_L22
       mov       ecx,ecx
       lea       r13,[rax+rcx*4+10]
       jmp       near ptr M08_L02
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 916
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFE500A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        short M11_L01
       mov       rcx,rax
M11_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rdx,7FFE50A3A460
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M11_L00
; Total bytes of code 170
```
```assembly
; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-28],xmm4
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-4],15051505
       mov       dword ptr [rbp-8],15051505
       mov       r8d,[rcx+8]
       mov       [rbp-0C],r8d
       lea       r8,[rcx+0C]
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       cmp       dword ptr [rbp-0C],2
       jle       short M12_L01
M12_L00:
       mov       edx,[r8]
       mov       eax,[r8+4]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M12_L03
       mov       r10d,[rbp-0C]
       add       r10d,0FFFFFFFC
       mov       [rbp-0C],r10d
       rorx      r10d,[rbp-4],1B
       add       r10d,[rbp-4]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-4],edx
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        eax,200020
       xor       edx,eax
       mov       [rbp-8],edx
       add       r8,8
       cmp       dword ptr [rbp-0C],2
       jg        short M12_L00
M12_L01:
       cmp       dword ptr [rbp-0C],0
       jle       short M12_L02
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M12_L03
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        r8d,200020
       xor       r8d,edx
       mov       [rbp-8],r8d
M12_L02:
       xor       eax,eax
       mov       [rbp-18],rax
       imul      eax,[rbp-8],5D588B65
       add       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
M12_L03:
       call      M12_L05
       nop
       mov       rcx,[rbp+10]
       mov       r8d,[rcx+8]
       sub       r8d,[rbp-0C]
       cmp       [rcx+8],r8d
       jae       short M12_L04
       mov       ecx,21
       call      qword ptr [7FFE500AF360]
       int       3
M12_L04:
       mov       edx,r8d
       lea       rdx,[rcx+rdx*2+0C]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-28],rdx
       mov       [rbp-20],ecx
       lea       r8,[rbp-28]
       mov       edx,[rbp-8]
       mov       ecx,[rbp-4]
       call      qword ptr [7FFE5086F0F0]
       nop
       add       rsp,50
       pop       rbp
       ret
M12_L05:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-18],r8
       add       rsp,28
       ret
; Total bytes of code 320
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M13_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M13_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M14_L12
M14_L00:
       mov       ecx,eax
       call      qword ptr [7FFE500A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M14_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M14_L08
       mov       rcx,rax
M14_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M14_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M14_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M14_L17
       cmp       ebp,[r14+8]
       ja        near ptr M14_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M14_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M14_L15
       cmp       r8,4000
       ja        near ptr M14_L14
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M14_L13
M14_L03:
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
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M14_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M14_L11
       jmp       short M14_L06
M14_L04:
       mov       eax,[rdi+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M14_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M14_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L06:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rdi+rdx*8+24],0FFFFFFFF
       jl        short M14_L05
       jmp       short M14_L04
M14_L07:
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
M14_L08:
       mov       rdx,7FFE50A3A460
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L02
M14_L09:
       mov       r8d,[rax+10]
       mov       r10,[rbx+8]
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M14_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+14],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M14_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L11:
       cmp       ecx,edx
       jae       near ptr M14_L19
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+14],0FFFFFFFF
       jl        short M14_L10
       jmp       short M14_L09
M14_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M14_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M14_L01
M14_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L03
M14_L14:
       mov       rcx,rax
       call      qword ptr [7FFE5064E988]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L15:
       mov       rcx,rax
       call      qword ptr [7FFE500A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L16:
       xor       r15d,r15d
       jmp       short M14_L18
M14_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE5086D698]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M14_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE5086D698]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE5086F180]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M14_L03
M14_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M15_L05
       mov       rcx,rax
M15_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE500AF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M15_L08
M15_L01:
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
       mov       [rbx+30],rax
       xor       esi,esi
       test      r14d,r14d
       jle       near ptr M15_L04
       cmp       [rbp+8],r14d
       jl        near ptr M15_L06
M15_L02:
       mov       ecx,esi
       lea       rdi,[rcx+rcx*2]
       cmp       dword ptr [rbp+rdi*8+24],0FFFFFFFF
       jl        short M15_L03
       mov       rcx,7FFE50A29308
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rbp+rdi*8+20]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rbp+rdi*8+24],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L03:
       mov       rcx,7FFE50A2930C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M15_L02
M15_L04:
       mov       rcx,7FFE50A29310
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L05:
       mov       rdx,7FFE50A3A460
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M15_L00
M15_L06:
       cmp       esi,[rbp+8]
       jae       near ptr M15_L16
       mov       ecx,esi
       lea       rcx,[rcx+rcx*2]
       lea       rdi,[rbp+rcx*8+10]
       cmp       dword ptr [rdi+14],0FFFFFFFF
       jl        short M15_L07
       mov       rcx,7FFE50A29308
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+10]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       imul      rax,rcx
       shr       rax,20
       cmp       eax,[r13+8]
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+14],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L07:
       mov       rcx,7FFE50A2930C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M15_L06
       jmp       near ptr M15_L04
M15_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A8]
       test      rdi,rdi
       je        short M15_L09
       jmp       short M15_L10
M15_L09:
       mov       rdx,7FFE50A3A3A0
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M15_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFE50A290E8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
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
       jge       near ptr M15_L15
M15_L11:
       cmp       r15d,[rbp+8]
       jae       near ptr M15_L16
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M15_L14
       mov       rcx,7FFE50A291F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M15_L12
       jmp       short M15_L13
M15_L12:
       mov       rdx,7FFE508EF590
       call      qword ptr [7FFE500AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M15_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FFE50A291F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M15_L14:
       mov       rcx,7FFE50A29300
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M15_L11
M15_L15:
       mov       rcx,7FFE50A29304
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L01
M15_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 815
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L39
       test      r14,r14
       je        near ptr M00_L40
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rdx],rcx
       je        short M00_L01
       xor       edx,edx
M00_L01:
       test      rdx,rdx
       jne       near ptr M00_L41
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L31
       xor       r12d,r12d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L44
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-128],rax
       mov       dword ptr [r13+2C],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L46
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       [rbp-98],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-98]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L04:
       mov       rcx,rdx
M00_L05:
       mov       [rbp-130],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       jne       near ptr M00_L27
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       rax,[rbp-130]
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jae       near ptr M00_L26
M00_L07:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M00_L30
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L25
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[rbp-130]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
M00_L09:
       mov       rsi,[rbp-70]
       mov       rdi,[rbp-68]
       cmp       qword ptr [r13+8],0
       je        near ptr M00_L20
M00_L10:
       mov       rax,[r13+10]
       mov       [rbp-138],rax
       mov       rdx,[r13+18]
       mov       [rbp-140],rdx
       xor       r8d,r8d
       mov       [rbp-9C],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-160]
       call      qword ptr [7FFE500149D8]; System.ValueType.GetHashCode()
       mov       rcx,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M00_L30
       mov       edx,edx
       lea       rdx,[rcx+rdx*4+10]
       mov       [rbp-148],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r13+30],0
       jg        near ptr M00_L17
       mov       r8d,[r13+28]
       mov       [rbp-0A4],r8d
       mov       r11,[rbp-138]
       cmp       [r11+8],r8d
       je        near ptr M00_L16
M00_L12:
       mov       r8d,[rbp-0A4]
       lea       ecx,[r8+1]
       mov       [r13+28],ecx
       mov       r11,[r13+10]
       mov       rcx,r11
M00_L13:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L30
       mov       [rbp-0A8],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-158],r10
       mov       [r10],eax
       mov       rdx,[rbp-148]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-158]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0A8]
       inc       esi
       mov       rdi,[rbp-148]
       mov       [rdi],esi
       inc       dword ptr [r13+34]
       jmp       near ptr M00_L06
M00_L14:
       mov       r10,[rbp-138]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-138],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-168],r8
       mov       [rbp-0A0],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L15:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r10,[rbp-138]
       mov       [rbp-9C],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L29
       test      r8d,r8d
       mov       eax,[rbp-0A0]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       [rbp-0A0],eax
       mov       ecx,[r13+28]
       call      qword ptr [7FFE500DF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE508FEAC0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r13+8]
       mov       edx,[rbp-0A0]
       mov       eax,edx
       imul      rax,[r13+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M00_L30
       mov       eax,eax
       lea       rcx,[rcx+rax*4+10]
       mov       rax,rcx
       mov       [rbp-148],rax
       mov       eax,edx
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,[r13+2C]
       mov       r8d,ecx
       dec       dword ptr [r13+30]
       mov       r11,[rbp-138]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L30
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r13+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L13
M00_L18:
       call      qword ptr [7FFE500DFC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-130]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FFE50021818
       call      qword ptr [r11]
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE508FE8C8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L10
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-190],r9
       mov       r11,[r8+10]
       mov       [rbp-198],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-170]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-190]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-178]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-178]
       mov       rdx,[rbp-170]
       call      qword ptr [7FFE500149D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FFE50021828
       call      qword ptr [r11]
       mov       r8,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L30
       mov       edx,edx
       lea       rdx,[r8+rdx*4+10]
       mov       r10,rdx
       mov       [rbp-148],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L11
M00_L23:
       mov       r11,[rbp-138]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L30
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-138],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-150],r9
       mov       [rbp-0A0],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       [rbp-118],rsi
       mov       [rbp-110],rdi
       lea       r8,[rbp-118]
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FFE50021830
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-150]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-9C]
       inc       ecx
       mov       r11,[rbp-138]
       cmp       [r11+8],ecx
       jb        short M00_L29
       test      r9d,r9d
       mov       [rbp-138],r11
       mov       [rbp-9C],ecx
       mov       eax,[rbp-0A0]
       jge       near ptr M00_L23
       jmp       near ptr M00_L11
M00_L25:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M00_L07
M00_L26:
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       short M00_L28
M00_L27:
       mov       rcx,rax
       mov       r11,7FFE50021810
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L47
M00_L29:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FFE500217E0
       call      qword ptr [r11]
       mov       [rbp-120],rax
       mov       rdx,[rbp-120]
       cmp       [rdx],edx
M00_L32:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L36
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5044C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L33:
       test      eax,eax
       je        near ptr M00_L37
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L35
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L34:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-60]
       mov       rcx,r13
       call      qword ptr [7FFE508FE9A0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L32
       mov       r12d,1
       jmp       near ptr M00_L32
M00_L35:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217F0
       call      qword ptr [r11]
       jmp       short M00_L34
M00_L36:
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217E8
       call      qword ptr [r11]
       jmp       near ptr M00_L33
M00_L37:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L43
M00_L38:
       mov       [rbp-0F8],r12b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0F8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508FEAD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       xor       r12d,r12d
       jmp       short M00_L38
M00_L40:
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rcx,rax
       call      qword ptr [7FFE507B55F0]
       int       3
M00_L41:
       call      qword ptr [7FFE508FE628]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L42
       call      qword ptr [7FFE50987A20]
       mov       r12,rax
M00_L42:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE50447DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217F8
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L44:
       mov       rcx,r14
       mov       r11,7FFE50021800
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28E73400B98
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L46:
       mov       rcx,r14
       mov       r11,7FFE50021808
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L47:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L48
       mov       rcx,rax
       mov       r11,7FFE50021820
       call      qword ptr [r11]
M00_L48:
       cmp       dword ptr [r13+28],0
       jle       short M00_L49
       mov       rax,[r13+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r13+28]
       cmp       eax,3
       jle       short M00_L49
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FFE50987A38]
M00_L49:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L52
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L50
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       [rbp-0D0],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L51
M00_L50:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28E73400B98
       mov       rdx,[rcx]
M00_L51:
       jmp       short M00_L53
M00_L52:
       mov       rcx,r15
       mov       r11,7FFE500217B8
       call      qword ptr [r11]
       mov       rdx,rax
M00_L53:
       mov       [rbp-120],rdx
M00_L54:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       near ptr M00_L70
       jmp       near ptr M00_L69
M00_L55:
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rdx],rcx
       jne       short M00_L56
       mov       rdx,[rbp-120]
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L57
M00_L56:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217C8
       call      qword ptr [r11]
M00_L57:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FFE508FE9A0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L68
       mov       r12,r14
       mov       r15,[rbp-40]
       mov       rsi,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L72
       cmp       qword ptr [r12+8],0
       jne       short M00_L58
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFE500D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L58:
       mov       rdi,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-180],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rax],rcx
       jne       short M00_L59
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50704CA8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       jmp       short M00_L60
M00_L59:
       mov       rax,[rbp-180]
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FFE50021838
       call      qword ptr [r11]
M00_L60:
       mov       [rbp-0DC],eax
       xor       r8d,r8d
       mov       [rbp-0E0],r8d
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FFE50987A50]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
       mov       eax,[r12]
       dec       eax
       jmp       near ptr M00_L63
M00_L61:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       r10d,[rbp-0DC]
       cmp       [rdi+rdx*8+20],r10d
       jne       short M00_L62
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       [rbp-0E4],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-180]
       mov       r8,rsi
       mov       r11,7FFE50021840
       call      qword ptr [r11]
       test      eax,eax
       mov       eax,[rbp-0E4]
       jne       near ptr M00_L73
M00_L62:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rdi+rcx*8+24]
       mov       ecx,eax
       mov       r8d,[rbp-0E0]
       inc       r8d
       mov       [rbp-0E0],r8d
       cmp       [rdi+8],r8d
       mov       eax,ecx
       jb        near ptr M00_L74
M00_L63:
       cmp       [rdi+8],eax
       ja        near ptr M00_L61
       cmp       dword ptr [r14+40],0
       jle       short M00_L64
       mov       ecx,[r14+3C]
       mov       eax,ecx
       mov       ecx,[r14+3C]
       cmp       ecx,[rdi+8]
       jae       near ptr M00_L75
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rdi+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+3C],ecx
       dec       dword ptr [r14+40]
       jmp       short M00_L66
M00_L64:
       mov       eax,[r14+38]
       mov       [rbp-0E8],eax
       cmp       [rdi+8],eax
       jne       short M00_L65
       mov       rcx,r14
       call      qword ptr [7FFE507BF828]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FFE50987A50]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       r12,rax
M00_L65:
       mov       eax,[rbp-0E8]
       mov       edi,eax
       lea       ecx,[rdi+1]
       mov       [r14+38],ecx
       mov       rcx,[r14+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,edi
       mov       rdi,rcx
M00_L66:
       cmp       eax,[rdi+8]
       jae       near ptr M00_L75
       mov       [rbp-0EC],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r9,[rdi+rcx*8+10]
       mov       [rbp-188],r9
       mov       r10d,[rbp-0DC]
       mov       [r9+10],r10d
       mov       ecx,[r12]
       dec       ecx
       mov       [r9+14],ecx
       mov       rcx,r9
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-188]
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-0EC]
       inc       esi
       mov       [r12],esi
       inc       dword ptr [r14+44]
       cmp       dword ptr [rbp-0E0],64
       jbe       short M00_L67
       mov       rdx,[rbp-180]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L67
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFE503673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L67:
       mov       r12d,1
       jmp       near ptr M00_L54
M00_L68:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r14
       mov       r11,7FFE500217D0
       call      qword ptr [r11]
       jmp       short M00_L67
M00_L69:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FFE5044C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L71
M00_L70:
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217C0
       call      qword ptr [r11]
M00_L71:
       test      eax,eax
       jne       near ptr M00_L55
       jmp       short M00_L76
M00_L72:
       mov       ecx,4
       call      qword ptr [7FFE500DFD50]
       int       3
M00_L73:
       mov       rdx,rsi
       mov       rcx,7FFE50954A80
       call      qword ptr [7FFE500DFD20]
       int       3
M00_L74:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L75:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L76:
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L77
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217D8
       call      qword ptr [r11]
M00_L77:
       jmp       near ptr M00_L38
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L78
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L78
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217F8
       call      qword ptr [r11]
M00_L78:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L79
       mov       rcx,[rbp-120]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       je        short M00_L79
       mov       rcx,[rbp-120]
       mov       r11,7FFE500217D8
       call      qword ptr [r11]
M00_L79:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-130],0
       je        short M00_L80
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L80
       mov       rcx,rax
       mov       r11,7FFE50021820
       call      qword ptr [r11]
M00_L80:
       nop
       add       rsp,28
       ret
; Total bytes of code 3825
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFE741A0B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE507BF408]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE50445EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFE507BF420]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.ValueType.GetHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
M03_L00:
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx]
       mov       [rbp+10],rbx
       lea       r14,[rbx+8]
       mov       [rbp-0C8],r14
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       rcx,rdi
       sar       rcx,20
       xor       ecx,edi
       mov       eax,[rbp-3C]
       lea       edx,[rax+1]
       mov       [rbp-3C],edx
       mov       edx,eax
       and       edx,3
       jne       short M03_L02
       mov       [rbp-48],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L03
       test      r15b,4
       je        short M03_L06
       jmp       near ptr M03_L25
M03_L02:
       cmp       edx,1
       jne       near ptr M03_L22
       mov       [rbp-44],ecx
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       mov       rax,7FFE500148F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD2B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L05
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L05:
       mov       r9,[rbp-0A8]
       mov       [rsi+8],r9
       test      eax,eax
       jne       near ptr M03_L25
M03_L06:
       mov       rbx,[rbp+10]
       mov       [rbp-60],rbx
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       [rbp-70],r9d
       mov       [rbp-78],r9
       lea       r9,[rbp-78]
       mov       [rsp+20],r9
       lea       r9,[rbp-70]
       lea       r8,[rbp-68]
       mov       rcx,rdi
       lea       rdx,[rbp-60]
       mov       rax,7FFE50014938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFEAFD52B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFEB00139A0],0
       je        short M03_L08
       call      qword ptr [7FFEB0001648]; CORINFO_HELP_STOP_FOR_GC
M03_L08:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       dec       eax
       jne       near ptr M03_L26
       mov       ecx,[rbp-68]
       mov       r14,[rbp-0C8]
       mov       rcx,[r14+rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       near ptr M03_L27
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       edx,88DFC0F7
       mov       r8d,63ABFB18
       cmp       ecx,8
       jb        short M03_L10
       mov       r10d,ecx
       shr       r10d,3
M03_L09:
       add       edx,[rax]
       mov       r9d,[rax+4]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
       add       r9d,edx
       mov       edx,r8d
       xor       edx,r9d
       rol       r9d,14
       add       r9d,edx
       rol       edx,9
       xor       edx,r9d
       rol       r9d,1B
       add       r9d,edx
       rol       edx,13
       mov       r8d,r9d
       add       rax,8
       dec       r10d
       mov       r9d,edx
       mov       edx,r8d
       mov       r8d,r9d
       jne       short M03_L09
       test      cl,4
       je        short M03_L12
       jmp       short M03_L11
M03_L10:
       cmp       ecx,4
       jb        near ptr M03_L18
M03_L11:
       add       edx,[rax]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
M03_L12:
       mov       r10d,ecx
       and       r10,7
       mov       eax,[rax+r10-4]
       shr       eax,8
       or        eax,80000000
       not       ecx
       shl       ecx,3
       shrx      ecx,eax,ecx
M03_L13:
       add       ecx,edx
       mov       eax,r8d
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       edx,ecx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
M03_L14:
       mov       ecx,[rbp-3C]
       lea       edx,[rcx+1]
       mov       [rbp-3C],edx
       mov       edx,ecx
       and       edx,3
       jne       near ptr M03_L21
       mov       [rbp-48],eax
M03_L15:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,3230E7FE
M03_L16:
       lea       eax,[rdx+rax*4]
       test      ecx,ecx
       je        short M03_L17
       imul      edx,[rbp-48],0C2B2AE3D
       add       eax,edx
       rol       eax,11
       imul      eax,27D4EB2F
       cmp       ecx,1
       jbe       short M03_L17
       imul      edx,[rbp-44],0C2B2AE3D
       add       edx,eax
       rol       edx,11
       imul      eax,edx,27D4EB2F
       cmp       ecx,2
       ja        near ptr M03_L36
M03_L17:
       mov       ecx,eax
       shr       ecx,0F
       xor       ecx,eax
       imul      eax,ecx,85EBCA77
       mov       ecx,eax
       shr       ecx,0D
       xor       ecx,eax
       imul      eax,ecx,0C2B2AE3D
       mov       ecx,eax
       shr       ecx,10
       xor       eax,ecx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L18:
       mov       r10d,80
       test      cl,1
       je        short M03_L19
       mov       r10d,ecx
       and       r10,2
       movzx     r10d,byte ptr [rax+r10]
       or        r10d,8000
M03_L19:
       test      cl,2
       jne       short M03_L20
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L20:
       shl       r10d,10
       movzx     ecx,word ptr [rax]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M03_L13
M03_L21:
       cmp       edx,1
       jne       near ptr M03_L28
       mov       [rbp-44],eax
       jmp       near ptr M03_L15
M03_L22:
       cmp       edx,2
       jne       short M03_L23
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L23:
       cmp       eax,3
       jne       short M03_L24
       mov       dword ptr [rbp-58],3FFDC475
       mov       dword ptr [rbp-54],0A1C64AC4
       mov       dword ptr [rbp-50],1BDA804D
       mov       dword ptr [rbp-4C],7DA3069C
M03_L24:
       imul      eax,[rbp-48],85EBCA77
       add       eax,[rbp-58]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-58],eax
       imul      eax,[rbp-44],85EBCA77
       add       eax,[rbp-54]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-54],eax
       imul      eax,[rbp-40],85EBCA77
       add       eax,[rbp-50]
       rol       eax,0D
       imul      eax,9E3779B1
       mov       [rbp-50],eax
       imul      ecx,85EBCA77
       add       ecx,[rbp-4C]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L01
M03_L25:
       mov       rcx,rdi
       call      00007FFEAFD327D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50986EE0]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FFE509CA0F8]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M03_L00]
       add       rcx,rax
       jmp       rcx
M03_L27:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L14
M03_L28:
       cmp       edx,2
       jne       short M03_L29
       mov       [rbp-40],eax
       jmp       near ptr M03_L15
M03_L29:
       cmp       ecx,3
       jne       short M03_L30
       mov       dword ptr [rbp-58],3FFDC475
       mov       dword ptr [rbp-54],0A1C64AC4
       mov       dword ptr [rbp-50],1BDA804D
       mov       dword ptr [rbp-4C],7DA3069C
M03_L30:
       imul      ecx,[rbp-48],85EBCA77
       add       ecx,[rbp-58]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-58],ecx
       imul      ecx,[rbp-44],85EBCA77
       add       ecx,[rbp-54]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-54],ecx
       imul      ecx,[rbp-40],85EBCA77
       add       ecx,[rbp-50]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-50],ecx
       imul      ecx,eax,85EBCA77
       add       ecx,[rbp-4C]
       rol       ecx,0D
       imul      ecx,9E3779B1
       mov       [rbp-4C],ecx
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rdx]
       mov       rdx,[rdx]
       dec       rdx
       mov       rax,7FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,7FF0000000000000
       cmp       rdx,rax
       jb        short M03_L31
       mov       rdx,7FF0000000000000
       and       rcx,rdx
M03_L31:
       mov       rdx,rcx
       shr       rdx,20
       xor       edx,ecx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       ecx,[rbp-68]
       add       rcx,[rbp-0C8]
       mov       edx,[rcx]
       mov       ecx,[rcx]
       dec       ecx
       and       ecx,7FFFFFFF
       cmp       ecx,7F800000
       jb        short M03_L32
       and       edx,7F800000
M03_L32:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE50986EE0]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFE50987048]
       test      rax,rax
       jne       short M03_L33
       xor       edx,edx
       jmp       short M03_L34
M03_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edx,eax
M03_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE504ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
M03_L35:
       rorx      edx,[rbp-58],1F
       rorx      r8d,[rbp-54],19
       add       edx,r8d
       rorx      r8d,[rbp-50],14
       add       edx,r8d
       rorx      r8d,[rbp-4C],0E
       add       edx,r8d
       jmp       near ptr M03_L16
M03_L36:
       imul      ecx,[rbp-40],0C2B2AE3D
       add       ecx,eax
       rol       ecx,11
       imul      eax,ecx,27D4EB2F
       jmp       near ptr M03_L17
; Total bytes of code 1621
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        near ptr M05_L06
       mov       rcx,rax
M05_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M05_L13
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M05_L14
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L14
       cmp       ebp,[r14+8]
       ja        near ptr M05_L14
       cmp       ebp,[rdi+8]
       ja        near ptr M05_L14
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L12
       cmp       r8,4000
       ja        near ptr M05_L11
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M05_L10
M05_L01:
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
       jle       short M05_L05
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L09
       jmp       short M05_L04
       nop       dword ptr [rax]
M05_L02:
       mov       eax,[rdx]
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
       jae       near ptr M05_L16
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L03:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L04:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M05_L03
       jmp       short M05_L02
M05_L05:
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
M05_L06:
       mov       rdx,7FFE50960FC0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       r8d,[rax]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M05_L16
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+4],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M05_L08:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L05
M05_L09:
       cmp       ecx,edx
       jae       short M05_L16
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M05_L08
       jmp       short M05_L07
M05_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L11:
       mov       rcx,rax
       call      qword ptr [7FFE5067EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE507B4930]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE507B4930]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE507B4948]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
M06_L00:
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
M06_L01:
       mov       rdx,7FFE50960FC0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M07_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M07_L03
M07_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M07_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M07_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       call      qword ptr [7FFE500DFC60]
       int       3
M07_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M07_L00
M07_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rbp,rdx
       mov       r14,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L06
M08_L00:
       mov       r15,[rbx+10]
       mov       r13,[rbx+18]
       xor       r12d,r12d
       test      r13,r13
       jne       near ptr M08_L11
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       lea       rdi,[rdx+8]
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rcx,rdx
       call      qword ptr [7FFE500149D8]; System.ValueType.GetHashCode()
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r13,[rcx+rdx*4+10]
       mov       edi,[r13]
       dec       edi
       jns       short M08_L04
M08_L01:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M08_L20
       mov       r12d,[rbx+28]
       cmp       [r15+8],r12d
       je        near ptr M08_L21
M08_L02:
       lea       eax,[r12+1]
       mov       [rbx+28],eax
       mov       r15,[rbx+10]
M08_L03:
       cmp       r12d,[r15+8]
       jae       near ptr M08_L22
       mov       eax,r12d
       lea       rax,[rax+rax*2]
       lea       rdi,[r15+rax*8+10]
       mov       [rdi],esi
       mov       eax,[r13]
       dec       eax
       mov       [rdi+4],eax
       add       rdi,8
       mov       rsi,rbp
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       eax,[r12+1]
       mov       [r13],eax
       inc       dword ptr [rbx+34]
       mov       [r14],r12d
       mov       eax,1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L04:
       cmp       edi,[r15+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rax,[r15+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],esi
       je        short M08_L07
M08_L05:
       mov       rax,[rsp+30]
       mov       edi,[rax+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M08_L19
       test      edi,edi
       jge       short M08_L04
       jmp       near ptr M08_L01
M08_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE508FE8C8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M08_L08
       jmp       short M08_L09
M08_L08:
       mov       rdx,7FFE50960F40
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L09:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rax,[rsp+30]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       r10,[rcx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       test      eax,eax
       je        near ptr M08_L05
       mov       [r14],edi
M08_L10:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M08_L12
       jmp       short M08_L13
M08_L12:
       mov       rdx,7FFE509612E8
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L13:
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rdx,[rsp+48]
       mov       rcx,r13
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L22
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       rdi,rcx
       mov       eax,[rdi]
       dec       eax
       jns       short M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L14:
       cmp       eax,[r15+8]
       jae       near ptr M08_L22
       mov       [rsp+5C],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r15+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8],esi
       jne       short M08_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M08_L15
       jmp       short M08_L16
M08_L15:
       mov       rdx,7FFE50961300
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L16:
       mov       rax,[rsp+28]
       vmovdqu   xmm0,xmmword ptr [rax+8]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+48]
       lea       r8,[rsp+38]
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L18
M08_L17:
       mov       r8,[rsp+28]
       mov       eax,[r8+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        short M08_L19
       test      eax,eax
       jge       near ptr M08_L14
       mov       r13,rdi
       jmp       near ptr M08_L01
M08_L18:
       mov       eax,[rsp+5C]
       mov       [r14],eax
       jmp       near ptr M08_L10
M08_L19:
       call      qword ptr [7FFE500DF498]
       int       3
M08_L20:
       mov       eax,[rbx+2C]
       mov       r12d,eax
       dec       dword ptr [rbx+30]
       cmp       eax,[r15+8]
       jae       short M08_L22
       lea       rax,[rax+rax*2]
       mov       eax,[r15+rax*8+14]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+2C],eax
       jmp       near ptr M08_L03
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508FEA30]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
       mov       rax,[rbx+8]
       mov       ecx,esi
       imul      rcx,[rbx+20]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       mov       r8d,edx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       short M08_L22
       mov       ecx,ecx
       lea       r13,[rax+rcx*4+10]
       jmp       near ptr M08_L02
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 916
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFE500D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M11_L01
       mov       rcx,rax
M11_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rdx,7FFE508AB5C0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M11_L00
; Total bytes of code 170
```
```assembly
; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-28],xmm4
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-4],15051505
       mov       dword ptr [rbp-8],15051505
       mov       r8d,[rcx+8]
       mov       [rbp-0C],r8d
       lea       r8,[rcx+0C]
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       cmp       dword ptr [rbp-0C],2
       jle       short M12_L01
M12_L00:
       mov       edx,[r8]
       mov       eax,[r8+4]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M12_L03
       mov       r10d,[rbp-0C]
       add       r10d,0FFFFFFFC
       mov       [rbp-0C],r10d
       rorx      r10d,[rbp-4],1B
       add       r10d,[rbp-4]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-4],edx
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        eax,200020
       xor       edx,eax
       mov       [rbp-8],edx
       add       r8,8
       cmp       dword ptr [rbp-0C],2
       jg        short M12_L00
M12_L01:
       cmp       dword ptr [rbp-0C],0
       jle       short M12_L02
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M12_L03
       rorx      edx,[rbp-8],1B
       add       edx,[rbp-8]
       or        r8d,200020
       xor       r8d,edx
       mov       [rbp-8],r8d
M12_L02:
       xor       eax,eax
       mov       [rbp-18],rax
       imul      eax,[rbp-8],5D588B65
       add       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
M12_L03:
       call      M12_L05
       nop
       mov       rcx,[rbp+10]
       mov       r8d,[rcx+8]
       sub       r8d,[rbp-0C]
       cmp       [rcx+8],r8d
       jae       short M12_L04
       mov       ecx,21
       call      qword ptr [7FFE500DF360]
       int       3
M12_L04:
       mov       edx,r8d
       lea       rdx,[rcx+rdx*2+0C]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-28],rdx
       mov       [rbp-20],ecx
       lea       r8,[rbp-28]
       mov       edx,[rbp-8]
       mov       ecx,[rbp-4]
       call      qword ptr [7FFE509849A8]
       nop
       add       rsp,50
       pop       rbp
       ret
M12_L05:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-18],r8
       add       rsp,28
       ret
; Total bytes of code 320
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M13_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M13_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M14_L12
M14_L00:
       mov       ecx,eax
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M14_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M14_L08
       mov       rcx,rax
M14_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M14_L16
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M14_L17
       cmp       dword ptr [rcx+4],18
       jne       near ptr M14_L17
       cmp       ebp,[r14+8]
       ja        near ptr M14_L17
       cmp       ebp,[rdi+8]
       ja        near ptr M14_L17
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M14_L15
       cmp       r8,4000
       ja        near ptr M14_L14
       mov       rcx,rax
       call      00007FFEAFCE9170
       cmp       dword ptr [7FFEB00139A0],0
       jne       near ptr M14_L13
M14_L03:
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
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M14_L07
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M14_L11
       jmp       short M14_L06
M14_L04:
       mov       eax,[rdi+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M14_L19
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M14_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L06:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rdi+rdx*8+24],0FFFFFFFF
       jl        short M14_L05
       jmp       short M14_L04
M14_L07:
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
M14_L08:
       mov       rdx,7FFE508AB5C0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L02
M14_L09:
       mov       r8d,[rax+10]
       mov       r10,[rbx+8]
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M14_L19
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+14],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M14_L10:
       inc       ecx
       cmp       ecx,ebp
       jge       short M14_L07
M14_L11:
       cmp       ecx,edx
       jae       near ptr M14_L19
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+14],0FFFFFFFF
       jl        short M14_L10
       jmp       short M14_L09
M14_L12:
       cmp       ecx,7FFFFFC3
       jge       near ptr M14_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M14_L01
M14_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L03
M14_L14:
       mov       rcx,rax
       call      qword ptr [7FFE5067EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L15:
       mov       rcx,rax
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L16:
       xor       r15d,r15d
       jmp       short M14_L18
M14_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE507B4930]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M14_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE507B4930]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFE507B4948]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M14_L03
M14_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M15_L05
       mov       rcx,rax
M15_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE500DF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M15_L08
M15_L01:
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
       mov       [rbx+30],rax
       xor       esi,esi
       test      r14d,r14d
       jle       near ptr M15_L04
       cmp       [rbp+8],r14d
       jl        near ptr M15_L06
M15_L02:
       mov       ecx,esi
       lea       rdi,[rcx+rcx*2]
       cmp       dword ptr [rbp+rdi*8+24],0FFFFFFFF
       jl        short M15_L03
       mov       rcx,7FFE50A85CA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rbp+rdi*8+20]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rbp+rdi*8+24],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L03:
       mov       rcx,7FFE50A85CAC
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M15_L02
M15_L04:
       mov       rcx,7FFE50A85CB0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L05:
       mov       rdx,7FFE508AB5C0
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M15_L00
M15_L06:
       cmp       esi,[rbp+8]
       jae       near ptr M15_L16
       mov       ecx,esi
       lea       rcx,[rcx+rcx*2]
       lea       rdi,[rbp+rcx*8+10]
       cmp       dword ptr [rdi+14],0FFFFFFFF
       jl        short M15_L07
       mov       rcx,7FFE50A85CA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+10]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       imul      rax,rcx
       shr       rax,20
       cmp       eax,[r13+8]
       jae       near ptr M15_L16
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+14],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M15_L07:
       mov       rcx,7FFE50A85CAC
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M15_L06
       jmp       near ptr M15_L04
M15_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M15_L09
       jmp       short M15_L10
M15_L09:
       mov       rdx,7FFE50A949A8
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M15_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFE50A85A88
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
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
       jge       near ptr M15_L15
M15_L11:
       cmp       r15d,[rbp+8]
       jae       near ptr M15_L16
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M15_L14
       mov       rcx,7FFE50A85B90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+70]
       test      r13,r13
       je        short M15_L12
       jmp       short M15_L13
M15_L12:
       mov       rdx,7FFE508AAB48
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M15_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FFE50A85B98
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M15_L14:
       mov       rcx,7FFE50A85CA0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M15_L11
M15_L15:
       mov       rcx,7FFE50A85CA4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L01
M15_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 815
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A56F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504C78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A56F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508BAEE8
       call      qword ptr [7FFE508A5698]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE508BB000
       call      qword ptr [7FFE508A56C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 140
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M03_L00
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B378
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,1C96F7F1640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1C96F7F0008
       call      qword ptr [7FFE5066F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M03_L02
       mov       rax,[rbp-58]
       mov       [rbp-30],rax
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B3B0
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,1C96F7F9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1C96F7F0008
       call      qword ptr [7FFE5066F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M03_L04
       mov       rax,[rbp-60]
       mov       [rbp-38],rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B5F0
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,1C96F7FFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1C96F7F0008
       call      qword ptr [7FFE5066F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		if (collection.TryGetValue(key, out var item) is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-68],rax
       cmp       qword ptr [rbp-68],0
       je        short M03_L06
       mov       rax,[rbp-68]
       mov       [rbp-40],rax
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B618
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-40]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-40]
       call      qword ptr [rax]
       test      eax,eax
       jne       short M03_L10
; 			collection.Add(key, value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+10],38
       jle       short M03_L08
       mov       rax,[rbp-70]
       mov       rax,[rax+38]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M03_L08
       mov       rax,[rbp-78]
       mov       [rbp-48],rax
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B6B8
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rcx,[rbp+18]
       mov       r11,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-48]
       call      qword ptr [rax]
; 			item = value;
; 			^^^^^^^^^^^^^
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
; 		return item;
; 		^^^^^^^^^^^^
M03_L10:
       mov       rax,[rbp-10]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 576
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5089B830
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A5830]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508A57E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508956F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504B78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508956F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508AAF70
       call      qword ptr [7FFE50895698]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE508AB088
       call      qword ptr [7FFE508956C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 140
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M03_L00
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B378
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,28CA42B1640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,28CA42B0008
       call      qword ptr [7FFE5065F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M03_L02
       mov       rax,[rbp-58]
       mov       [rbp-30],rax
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B3B0
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,28CA42B9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,28CA42B0008
       call      qword ptr [7FFE5065F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M03_L04
       mov       rax,[rbp-60]
       mov       [rbp-38],rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B5F0
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,28CA42BFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,28CA42B0008
       call      qword ptr [7FFE5065F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		if (collection.TryGetValue(key, out var item) is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-68],rax
       cmp       qword ptr [rbp-68],0
       je        short M03_L06
       mov       rax,[rbp-68]
       mov       [rbp-40],rax
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B618
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-40]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-40]
       call      qword ptr [rax]
       test      eax,eax
       jne       short M03_L10
; 			collection.Add(key, value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       cmp       qword ptr [rax+10],38
       jle       short M03_L08
       mov       rax,[rbp-70]
       mov       rax,[rax+38]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M03_L08
       mov       rax,[rbp-78]
       mov       [rbp-48],rax
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B6B8
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rcx,[rbp+18]
       mov       r11,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-48]
       call      qword ptr [rax]
; 			item = value;
; 			^^^^^^^^^^^^^
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
; 		return item;
; 		^^^^^^^^^^^^
M03_L10:
       mov       rax,[rbp-10]
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 576
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5088B830
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE50895830]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508957E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504D78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508CAFC0
       call      qword ptr [7FFE508B56C8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE508CB0D8
       call      qword ptr [7FFE508B56F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 140
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
; 		value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.TryGetValue(key, out var item) is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			collection.Add(key, value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = value;
; 			^^^^^^^^^^^^^
; 		return item;
; 		^^^^^^^^^^^^
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-70],0
       je        short M03_L00
       mov       rax,[rbp-70]
       mov       [rbp-28],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB378
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,1E4B5191640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1E4B5190008
       call      qword ptr [7FFE5067F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M03_L02
       mov       rax,[rbp-78]
       mov       [rbp-30],rax
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB3B0
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,1E4B5199F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1E4B5190008
       call      qword ptr [7FFE5067F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        short M03_L04
       mov       rax,[rbp-80]
       mov       [rbp-38],rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB5F0
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,1E4B519FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1E4B5190008
       call      qword ptr [7FFE5067F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-88],rax
       cmp       qword ptr [rbp-88],0
       je        short M03_L06
       mov       rax,[rbp-88]
       mov       [rbp-40],rax
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB618
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE509C5CE0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       lea       r8,[rbp-10]
       mov       r11,[rbp-40]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-40]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L10
       mov       rcx,7FFE509C5DE8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       cmp       qword ptr [rax+10],38
       jle       short M03_L08
       mov       rax,[rbp-90]
       mov       rax,[rax+38]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-98],0
       je        short M03_L08
       mov       rax,[rbp-98]
       mov       [rbp-48],rax
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB6B8
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE509C5DF0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       r11,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-48]
       call      qword ptr [rax]
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
M03_L10:
       mov       rcx,7FFE509C5EF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-10]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 721
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE508AB830
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5860]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508B5818]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE50885698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504A78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE50885698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE5089AEE8
       call      qword ptr [7FFE50885638]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE5089B000
       call      qword ptr [7FFE50885668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 140
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rcx+28]
       ret
; Total bytes of code 5
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
; 		value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (collection.TryGetValue(key, out var item) is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			collection.Add(key, value);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			item = value;
; 			^^^^^^^^^^^^^
; 		return item;
; 		^^^^^^^^^^^^
       push      rbp
       sub       rsp,0C0
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-70],0
       je        short M03_L00
       mov       rax,[rbp-70]
       mov       [rbp-28],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087B378
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,25C65281640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,25C65280008
       call      qword ptr [7FFE5064F108]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M03_L02
       mov       rax,[rbp-78]
       mov       [rbp-30],rax
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087B3B0
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,25C65289F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,25C65280008
       call      qword ptr [7FFE5064F108]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        short M03_L04
       mov       rax,[rbp-80]
       mov       [rbp-38],rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087B5F0
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,25C6528FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,25C65280008
       call      qword ptr [7FFE5064F108]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-88],rax
       cmp       qword ptr [rbp-88],0
       je        short M03_L06
       mov       rax,[rbp-88]
       mov       [rbp-40],rax
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087B618
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE50995E68
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       lea       r8,[rbp-10]
       mov       r11,[rbp-40]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-40]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L10
       mov       rcx,7FFE50995F70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       cmp       qword ptr [rax+10],38
       jle       short M03_L08
       mov       rax,[rbp-90]
       mov       rax,[rax+38]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-98],0
       je        short M03_L08
       mov       rax,[rbp-98]
       mov       [rbp-48],rax
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5087B6B8
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE50995F78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       r11,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-48]
       call      qword ptr [rax]
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
M03_L10:
       mov       rcx,7FFE50996080
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-10]
       add       rsp,0C0
       pop       rbp
       ret
; Total bytes of code 721
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5087B830
       call      qword ptr [7FFE500AF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508857D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50885788]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       r8,[rcx+48]
       mov       rdx,[r8+28]
       mov       [rbp-80],r8
       cmp       qword ptr [rbp-80],0
       je        near ptr M00_L21
       mov       r8,[rbp-80]
       mov       [rbp-80],r8
       test      rdx,rdx
       je        near ptr M00_L22
       mov       [rbp-88],rdx
       test      rax,rax
       je        near ptr M00_L23
       mov       [rbp-90],rax
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r8
       jne       near ptr M00_L30
       mov       [rbp-98],rax
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L06
       mov       r8,[rax+18]
       mov       [rbp-0A8],r8
       mov       r10,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [r8],r10
       jne       near ptr M00_L25
       mov       dword ptr [rbp-34],15051505
       mov       dword ptr [rbp-38],15051505
       mov       r10d,[rdx+8]
       mov       [rbp-3C],r10d
       add       rdx,0C
       mov       [rbp-48],rdx
       mov       rdx,[rbp-48]
       cmp       dword ptr [rbp-3C],2
       jle       short M00_L01
M00_L00:
       mov       r10d,[rdx]
       mov       r9d,[rdx+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L24
       mov       r11d,[rbp-3C]
       add       r11d,0FFFFFFFC
       mov       [rbp-3C],r11d
       rorx      r11d,[rbp-34],1B
       add       r11d,[rbp-34]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-34],r10d
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-38],r10d
       add       rdx,8
       cmp       dword ptr [rbp-3C],2
       jg        short M00_L00
M00_L01:
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L02
       mov       edx,[rdx]
       test      edx,0FF80FF80
       jne       near ptr M00_L24
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-38],edx
M00_L02:
       xor       edx,edx
       mov       [rbp-48],rdx
       imul      edx,[rbp-38],5D588B65
       add       edx,[rbp-34]
M00_L03:
       mov       ebx,edx
M00_L04:
       mov       rax,[rbp-98]
       mov       rdx,[rax+8]
       mov       r11d,ebx
       imul      r11,[rax+30]
       shr       r11,20
       inc       r11
       mov       r10d,[rdx+8]
       mov       r9d,r10d
       imul      r11,r9
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L42
       mov       r11d,r11d
       lea       rdx,[rdx+r11*4+10]
       mov       esi,[rdx]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       dec       esi
M00_L05:
       cmp       [rdi+8],esi
       ja        near ptr M00_L26
M00_L06:
       xor       r15d,r15d
M00_L07:
       test      r15,r15
       jne       near ptr M00_L29
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       rdx,[rbp-90]
       mov       [rbp-0A0],rdx
       mov       rdx,[rbp-88]
       mov       [rbp-0B0],rdx
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L31
M00_L08:
       mov       r8,[rbp-90]
       mov       r8,[r8+10]
       mov       [rbp-0B8],r8
       mov       r8,[rbp-90]
       mov       rdx,[r8+18]
       mov       [rbp-0C0],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-0C0]
       cmp       [rdx],r8
       jne       near ptr M00_L35
       mov       dword ptr [rbp-4C],15051505
       mov       dword ptr [rbp-50],15051505
       mov       r8,[rbp-88]
       mov       r8d,[r8+8]
       mov       [rbp-54],r8d
       mov       r8,[rbp-88]
       add       r8,0C
       mov       [rbp-60],r8
       mov       r8,[rbp-60]
       cmp       dword ptr [rbp-54],2
       jle       short M00_L10
M00_L09:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       near ptr M00_L32
       mov       r9d,[rbp-54]
       add       r9d,0FFFFFFFC
       mov       [rbp-54],r9d
       rorx      r9d,[rbp-4C],1B
       add       r9d,[rbp-4C]
       or        eax,200020
       xor       eax,r9d
       mov       [rbp-4C],eax
       rorx      eax,[rbp-50],1B
       add       eax,[rbp-50]
       or        r10d,200020
       xor       eax,r10d
       mov       [rbp-50],eax
       add       r8,8
       cmp       dword ptr [rbp-54],2
       jg        short M00_L09
M00_L10:
       cmp       dword ptr [rbp-54],0
       jle       short M00_L11
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L32
       rorx      eax,[rbp-50],1B
       add       eax,[rbp-50]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-50],r8d
M00_L11:
       xor       r11d,r11d
       mov       [rbp-60],r11
       imul      eax,[rbp-50],5D588B65
       add       eax,[rbp-4C]
M00_L12:
       mov       r15d,eax
M00_L13:
       xor       ebx,ebx
       mov       rax,[rbp-0A0]
       mov       r8,[rax+8]
       mov       r11d,r15d
       imul      r11,[rax+30]
       shr       r11,20
       inc       r11
       mov       r10d,[r8+8]
       imul      r11,r10
       shr       r11,20
       cmp       r11d,[r8+8]
       jae       near ptr M00_L42
       mov       r11d,r11d
       lea       rsi,[r8+r11*4+10]
       mov       r10d,[rsi]
       dec       r10d
       mov       r8,[rbp-0B8]
       mov       edi,[r8+8]
       cmp       edi,r10d
       ja        near ptr M00_L19
M00_L14:
       mov       rax,[rbp-0A0]
       cmp       dword ptr [rax+40],0
       jg        near ptr M00_L38
       mov       r14d,[rax+38]
       cmp       edi,r14d
       je        near ptr M00_L39
M00_L15:
       lea       r8d,[r14+1]
       mov       [rax+38],r8d
       mov       r8,[rax+10]
       mov       [rbp-0B8],r8
M00_L16:
       mov       r8,[rbp-0B8]
       cmp       r14d,[r8+8]
       jae       near ptr M00_L42
       mov       r8,[rbp-0B8]
       mov       r10d,r14d
       lea       r10,[r10+r10*2]
       lea       rdi,[r8+r10*8+10]
       mov       [rdi+10],r15d
       mov       r8d,[rsi]
       dec       r8d
       mov       [rdi+14],r8d
       mov       rdx,[rbp-0B0]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       [rsi],r14d
       mov       rax,[rbp-0A0]
       inc       dword ptr [rax+44]
       cmp       ebx,64
       ja        near ptr M00_L40
M00_L17:
       mov       rcx,[rbp-80]
       mov       [rbp-30],rcx
M00_L18:
       mov       rcx,[rbp-30]
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-68],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-68]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L19:
       mov       r8,[rbp-0B8]
       mov       r11d,r10d
       lea       r11,[r11+r11*2]
       lea       r14,[r8+r11*8+10]
       cmp       [r14+10],r15d
       je        near ptr M00_L36
M00_L20:
       mov       r10d,[r14+14]
       inc       ebx
       cmp       edi,ebx
       jb        near ptr M00_L37
       cmp       edi,r10d
       ja        short M00_L19
       jmp       near ptr M00_L14
M00_L21:
       call      qword ptr [7FFE5066ED90]
       mov       ecx,16D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5089CBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5089CBB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       call      qword ptr [7FFE5066ED90]
       mov       ecx,14D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5089CBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5089CBB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      qword ptr [7FFE5066ED90]
       mov       ecx,65
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5089CBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5089CBB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       call      M00_L43
       nop
       mov       r8,[rbp-88]
       mov       r8d,[r8+8]
       sub       r8d,[rbp-3C]
       mov       rdx,[rbp-88]
       cmp       [rdx+8],r8d
       jb        near ptr M00_L33
       mov       rdx,[rbp-88]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2+0C]
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-78],rdx
       mov       [rbp-70],ecx
       lea       r8,[rbp-78]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE5089E8F8]
       mov       edx,eax
       mov       r8,[rbp-0A8]
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,r8
       mov       r11,7FFE50011580
       call      qword ptr [r11]
       mov       ebx,eax
       mov       r8,[rbp-0A8]
       jmp       near ptr M00_L04
M00_L26:
       mov       edx,esi
       lea       rdx,[rdx+rdx*2]
       lea       r15,[rdi+rdx*8+10]
       cmp       [r15+10],ebx
       jne       short M00_L27
       mov       rdx,[r15]
       mov       rcx,r8
       mov       r8,[rbp-88]
       mov       r11,7FFE50011588
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-0A8]
       jne       short M00_L28
M00_L27:
       mov       esi,[r15+14]
       inc       r14d
       cmp       [rdi+8],r14d
       jae       near ptr M00_L05
       jmp       near ptr M00_L37
M00_L28:
       add       r15,8
       jmp       near ptr M00_L07
M00_L29:
       mov       r8,[r15]
       mov       [rbp-30],r8
       jmp       near ptr M00_L18
M00_L30:
       lea       r8,[rbp-30]
       mov       rcx,rax
       mov       r11,7FFE50011570
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L41
M00_L31:
       mov       rcx,[rbp-90]
       xor       edx,edx
       call      qword ptr [7FFE500C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L08
M00_L32:
       call      M00_L44
       nop
       mov       rdx,[rbp-0B0]
       mov       r8d,[rdx+8]
       sub       r8d,[rbp-54]
       cmp       [rdx+8],r8d
       jae       short M00_L34
M00_L33:
       mov       ecx,21
       call      qword ptr [7FFE500CF360]
       int       3
M00_L34:
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2+0C]
       mov       eax,[rdx+8]
       sub       eax,r8d
       mov       [rbp-78],rcx
       mov       [rbp-70],eax
       lea       r8,[rbp-78]
       mov       edx,[rbp-50]
       mov       ecx,[rbp-4C]
       call      qword ptr [7FFE5089E8F8]
       mov       rdx,[rbp-0C0]
       jmp       near ptr M00_L12
M00_L35:
       mov       rcx,rdx
       mov       rdx,[rbp-88]
       mov       r11,7FFE50011590
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rbp-0C0]
       jmp       near ptr M00_L13
M00_L36:
       mov       r8,[rbp-0B8]
       mov       r11d,r10d
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-0C0]
       mov       r8,[rbp-0B0]
       mov       r11,7FFE50011598
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C0]
       je        near ptr M00_L20
       mov       rdx,[rbp-0B0]
       mov       rcx,7FFE50903510
       call      qword ptr [7FFE500CFD20]
       int       3
M00_L37:
       call      qword ptr [7FFE500CF498]
       int       3
M00_L38:
       mov       r14d,[rax+3C]
       mov       r8d,[rax+3C]
       cmp       r8d,edi
       jae       near ptr M00_L42
       mov       r10,[rbp-0B8]
       lea       r8,[r8+r8*2]
       mov       r8d,[r10+r8*8+24]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [rax+3C],r8d
       dec       dword ptr [rax+40]
       jmp       near ptr M00_L16
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FFE5089E778]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rcx+8]
       mov       eax,r15d
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       imul      rax,r8
       shr       rax,20
       cmp       eax,[rdx+8]
       jae       short M00_L42
       mov       eax,eax
       lea       rsi,[rdx+rax*4+10]
       mov       rax,rcx
       mov       rdx,[rbp-0C0]
       jmp       near ptr M00_L15
M00_L40:
       mov       rdx,[rbp-0C0]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L17
       mov       rdx,[rbp-0B8]
       mov       edx,[rdx+8]
       mov       rcx,[rbp-0A0]
       mov       r8d,1
       call      qword ptr [7FFE503573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L17
M00_L41:
       mov       rcx,[rbp-90]
       mov       r8,[rbp-80]
       mov       rdx,[rbp-88]
       mov       r11,7FFE50011578
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-48],r8
       add       rsp,28
       ret
M00_L44:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-60],r8
       add       rsp,28
       ret
; Total bytes of code 2391
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,215B73B0008
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
       call      qword ptr [7FFE5089EF28]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE5099CCE0
       call      qword ptr [7FFE500CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        short M04_L04
M04_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M04_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M04_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       r8,[rcx+48]
       mov       rdx,[r8+28]
       mov       [rbp-88],r8
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L22
       mov       r8,[rbp-88]
       mov       [rbp-88],r8
       test      rdx,rdx
       je        near ptr M00_L23
       mov       [rbp-90],rdx
       test      rax,rax
       je        near ptr M00_L24
       mov       [rbp-98],rax
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r8
       jne       near ptr M00_L29
       mov       [rbp-0A0],rax
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L07
       mov       r8,[rax+18]
       mov       [rbp-0B0],r8
       mov       r10,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [r8],r10
       jne       near ptr M00_L26
       mov       dword ptr [rbp-3C],15051505
       mov       dword ptr [rbp-40],15051505
       mov       r10d,[rdx+8]
       mov       [rbp-44],r10d
       add       rdx,0C
       mov       [rbp-50],rdx
       mov       rdx,[rbp-50]
       cmp       dword ptr [rbp-44],2
       jle       short M00_L01
M00_L00:
       mov       r10d,[rdx]
       mov       r9d,[rdx+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L25
       mov       r11d,[rbp-44]
       add       r11d,0FFFFFFFC
       mov       [rbp-44],r11d
       rorx      r11d,[rbp-3C],1B
       add       r11d,[rbp-3C]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-3C],r10d
       rorx      r10d,[rbp-40],1B
       add       r10d,[rbp-40]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-40],r10d
       add       rdx,8
       cmp       dword ptr [rbp-44],2
       jg        short M00_L00
M00_L01:
       cmp       dword ptr [rbp-44],0
       jle       short M00_L02
       mov       edx,[rdx]
       test      edx,0FF80FF80
       jne       near ptr M00_L25
       rorx      r10d,[rbp-40],1B
       add       r10d,[rbp-40]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-40],edx
M00_L02:
       xor       edx,edx
       mov       [rbp-50],rdx
       imul      edx,[rbp-40],5D588B65
       add       edx,[rbp-3C]
M00_L03:
       mov       ebx,edx
M00_L04:
       mov       rax,[rbp-0A0]
       mov       rdx,[rax+8]
       mov       r11d,ebx
       imul      r11,[rax+30]
       shr       r11,20
       inc       r11
       mov       r10d,[rdx+8]
       mov       r9d,r10d
       imul      r11,r9
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L41
       mov       r11d,r11d
       lea       rdx,[rdx+r11*4+10]
       mov       esi,[rdx]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       dec       esi
       mov       r15d,[rdi+8]
       cmp       r15d,esi
       jbe       short M00_L07
M00_L05:
       mov       edx,esi
       lea       rdx,[rdx+rdx*2]
       lea       r13,[rdi+rdx*8+10]
       cmp       [r13+10],ebx
       je        near ptr M00_L27
M00_L06:
       mov       esi,[r13+14]
       inc       r14d
       cmp       r15d,r14d
       jb        near ptr M00_L36
       cmp       r15d,esi
       ja        short M00_L05
M00_L07:
       xor       r13d,r13d
M00_L08:
       test      r13,r13
       jne       near ptr M00_L28
       xor       edx,edx
       mov       [rbp-38],rdx
       mov       rdx,[rbp-98]
       mov       [rbp-0A8],rdx
       mov       rdx,[rbp-90]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L30
M00_L09:
       mov       r8,[rbp-98]
       mov       r8,[r8+10]
       mov       [rbp-0C0],r8
       mov       r8,[rbp-98]
       mov       rdx,[r8+18]
       mov       [rbp-0C8],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-0C8]
       cmp       [rdx],r8
       jne       near ptr M00_L34
       mov       dword ptr [rbp-54],15051505
       mov       dword ptr [rbp-58],15051505
       mov       r8,[rbp-90]
       mov       r8d,[r8+8]
       mov       [rbp-5C],r8d
       mov       r8,[rbp-90]
       add       r8,0C
       mov       [rbp-68],r8
       mov       r8,[rbp-68]
       cmp       dword ptr [rbp-5C],2
       jle       short M00_L11
M00_L10:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       near ptr M00_L31
       mov       r9d,[rbp-5C]
       add       r9d,0FFFFFFFC
       mov       [rbp-5C],r9d
       rorx      r9d,[rbp-54],1B
       add       r9d,[rbp-54]
       or        eax,200020
       xor       eax,r9d
       mov       [rbp-54],eax
       rorx      eax,[rbp-58],1B
       add       eax,[rbp-58]
       or        r10d,200020
       xor       eax,r10d
       mov       [rbp-58],eax
       add       r8,8
       cmp       dword ptr [rbp-5C],2
       jg        short M00_L10
M00_L11:
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L12
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L31
       rorx      eax,[rbp-58],1B
       add       eax,[rbp-58]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-58],r8d
M00_L12:
       xor       r11d,r11d
       mov       [rbp-68],r11
       imul      eax,[rbp-58],5D588B65
       add       eax,[rbp-54]
M00_L13:
       mov       r13d,eax
M00_L14:
       xor       ebx,ebx
       mov       rax,[rbp-0A8]
       mov       r8,[rax+8]
       mov       r11d,r13d
       imul      r11,[rax+30]
       shr       r11,20
       inc       r11
       mov       r10d,[r8+8]
       imul      r11,r10
       shr       r11,20
       cmp       r11d,[r8+8]
       jae       near ptr M00_L41
       mov       r11d,r11d
       lea       rsi,[r8+r11*4+10]
       mov       r10d,[rsi]
       dec       r10d
       mov       r8,[rbp-0C0]
       cmp       [r8+8],r10d
       ja        near ptr M00_L20
M00_L15:
       mov       rax,[rbp-0A8]
       cmp       dword ptr [rax+40],0
       jg        near ptr M00_L37
       mov       edi,[rax+38]
       mov       r8,[rbp-0C0]
       cmp       [r8+8],edi
       je        near ptr M00_L38
M00_L16:
       lea       r8d,[rdi+1]
       mov       [rax+38],r8d
       mov       r8,[rax+10]
       mov       [rbp-0C0],r8
M00_L17:
       mov       r8,[rbp-0C0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L41
       mov       r8,[rbp-0C0]
       mov       r10d,edi
       lea       r10,[r10+r10*2]
       lea       r14,[r8+r10*8+10]
       mov       [r14+10],r13d
       mov       r8d,[rsi]
       dec       r8d
       mov       [r14+14],r8d
       mov       rdx,[rbp-0B8]
       mov       rcx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       [rsi],edi
       mov       rax,[rbp-0A8]
       inc       dword ptr [rax+44]
       cmp       ebx,64
       ja        near ptr M00_L39
M00_L18:
       mov       rcx,[rbp-88]
       mov       [rbp-38],rcx
M00_L19:
       mov       rcx,[rbp-38]
       xor       edx,edx
       mov       [rbp-38],rdx
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       r8,[rbp-0C0]
       mov       r11d,r10d
       lea       r11,[r11+r11*2]
       lea       rdi,[r8+r11*8+10]
       cmp       [rdi+10],r13d
       je        near ptr M00_L35
M00_L21:
       mov       r10d,[rdi+14]
       inc       ebx
       mov       r8,[rbp-0C0]
       cmp       [r8+8],ebx
       jb        near ptr M00_L36
       mov       r8,[rbp-0C0]
       cmp       [r8+8],r10d
       ja        short M00_L20
       jmp       near ptr M00_L15
M00_L22:
       call      qword ptr [7FFE5066F240]
       mov       ecx,16D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508AD098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508AD0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      qword ptr [7FFE5066F240]
       mov       ecx,14D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508AD098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508AD0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       call      qword ptr [7FFE5066F240]
       mov       ecx,65
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508AD098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508AD0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       call      M00_L42
       nop
       mov       r8,[rbp-90]
       mov       r8d,[r8+8]
       sub       r8d,[rbp-44]
       mov       rdx,[rbp-90]
       cmp       [rdx+8],r8d
       jb        near ptr M00_L32
       mov       rdx,[rbp-90]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2+0C]
       mov       rcx,[rbp-90]
       mov       ecx,[rcx+8]
       sub       ecx,r8d
       mov       [rbp-80],rdx
       mov       [rbp-78],ecx
       lea       r8,[rbp-80]
       mov       edx,[rbp-40]
       mov       ecx,[rbp-3C]
       call      qword ptr [7FFE508AE988]
       mov       edx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,r8
       mov       r11,7FFE500113A8
       call      qword ptr [r11]
       mov       ebx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L27:
       mov       rdx,[r13]
       mov       rcx,r8
       mov       r8,[rbp-90]
       mov       r11,7FFE500113B0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-0B0]
       je        near ptr M00_L06
       add       r13,8
       jmp       near ptr M00_L08
M00_L28:
       mov       r8,[r13]
       mov       [rbp-38],r8
       jmp       near ptr M00_L19
M00_L29:
       lea       r8,[rbp-38]
       mov       rcx,rax
       mov       r11,7FFE50011398
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L40
M00_L30:
       mov       rcx,[rbp-98]
       xor       edx,edx
       call      qword ptr [7FFE500C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L09
M00_L31:
       call      M00_L43
       nop
       mov       rdx,[rbp-0B8]
       mov       r8d,[rdx+8]
       sub       r8d,[rbp-5C]
       cmp       [rdx+8],r8d
       jae       short M00_L33
M00_L32:
       mov       ecx,21
       call      qword ptr [7FFE500CF360]
       int       3
M00_L33:
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2+0C]
       mov       eax,[rdx+8]
       sub       eax,r8d
       mov       [rbp-80],rcx
       mov       [rbp-78],eax
       lea       r8,[rbp-80]
       mov       edx,[rbp-58]
       mov       ecx,[rbp-54]
       call      qword ptr [7FFE508AE988]
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L34:
       mov       rcx,rdx
       mov       rdx,[rbp-90]
       mov       r11,7FFE500113B8
       call      qword ptr [r11]
       mov       r13d,eax
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L35:
       mov       r8,[rbp-0C0]
       mov       r11d,r10d
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-0C8]
       mov       r8,[rbp-0B8]
       mov       r11,7FFE500113C0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C8]
       je        near ptr M00_L21
       mov       rdx,[rbp-0B8]
       mov       rcx,7FFE508F8AB8
       call      qword ptr [7FFE500CFD20]
       int       3
M00_L36:
       call      qword ptr [7FFE500CF498]
       int       3
M00_L37:
       mov       edi,[rax+3C]
       mov       r8d,[rax+3C]
       mov       r10,[rbp-0C0]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L41
       mov       r10,[rbp-0C0]
       lea       r8,[r8+r8*2]
       mov       r8d,[r10+r8*8+24]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [rax+3C],r8d
       dec       dword ptr [rax+40]
       jmp       near ptr M00_L17
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FFE508AE790]
       mov       rcx,[rbp-0A8]
       mov       rdx,[rcx+8]
       mov       eax,r13d
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       imul      rax,r8
       shr       rax,20
       cmp       eax,[rdx+8]
       jae       near ptr M00_L41
       mov       eax,eax
       lea       rsi,[rdx+rax*4+10]
       mov       rax,rcx
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L16
M00_L39:
       mov       rdx,[rbp-0C8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L18
       mov       rdx,[rbp-0C0]
       mov       edx,[rdx+8]
       mov       rcx,[rbp-0A8]
       mov       r8d,1
       call      qword ptr [7FFE503573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L18
M00_L40:
       mov       rcx,[rbp-98]
       mov       r8,[rbp-88]
       mov       rdx,[rbp-90]
       mov       r11,7FFE500113A0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-50],r8
       add       rsp,28
       ret
M00_L43:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-68],r8
       add       rsp,28
       ret
; Total bytes of code 2458
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EEFCC10008
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
       call      qword ptr [7FFE508AEFB8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE5099CA60
       call      qword ptr [7FFE500CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        short M04_L04
M04_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M04_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M04_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,[rdi+28]
       test      rdi,rdi
       je        near ptr M00_L16
       test      rbp,rbp
       je        near ptr M00_L17
       test      rsi,rsi
       je        near ptr M00_L18
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L19
       cmp       qword ptr [rsi+8],0
       je        short M00_L00
       mov       r14,[rsi+18]
       mov       rcx,r14
       mov       rdx,rbp
       mov       r11,7FFE50011490
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rsi+8]
       mov       ecx,r15d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L20
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r13d,[rdx]
       mov       r12,[rsi+10]
       xor       eax,eax
       mov       [rsp+4C],eax
       dec       r13d
       cmp       [r12+8],r13d
       ja        near ptr M00_L04
M00_L00:
       xor       r13d,r13d
M00_L01:
       test      r13,r13
       jne       near ptr M00_L15
       xor       ecx,ecx
       mov       [rsp+50],rcx
       cmp       qword ptr [rsi+8],0
       jne       short M00_L02
       xor       ecx,ecx
       call      qword ptr [7FFE500C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       dword ptr [rsi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+30],rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       rdx,rbp
       mov       r11,7FFE500114A0
       call      qword ptr [r11]
       mov       r13d,eax
       xor       r12d,r12d
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L20
       mov       ecx,ecx
       lea       rax,[rdx+rcx*4+10]
       mov       [rsp+30],rax
       mov       r10d,[rax]
       dec       r10d
       mov       r9d,[r14+8]
       mov       [rsp+3C],r9d
       cmp       r9d,r10d
       jbe       near ptr M00_L08
M00_L03:
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r14+rdx*8+10]
       mov       [rsp+20],r10
       cmp       [r10+10],r13d
       jne       near ptr M00_L07
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,r15
       mov       r8,rbp
       mov       r11,7FFE500114A8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,rbp
       mov       rcx,7FFE508B6588
       call      qword ptr [7FFE500CFD20]
       int       3
M00_L04:
       mov       edx,r13d
       lea       rdx,[rdx+rdx*2]
       lea       r13,[r12+rdx*8+10]
       cmp       [r13+10],r15d
       je        short M00_L06
M00_L05:
       mov       r13d,[r13+14]
       mov       eax,[rsp+4C]
       inc       eax
       cmp       [r12+8],eax
       jb        near ptr M00_L14
       cmp       [r12+8],r13d
       mov       [rsp+4C],eax
       jbe       near ptr M00_L00
       jmp       short M00_L04
M00_L06:
       mov       rdx,[r13]
       mov       rcx,r14
       mov       r8,rbp
       mov       r11,7FFE50011498
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       add       r13,8
       jmp       near ptr M00_L01
M00_L07:
       mov       r10,[rsp+20]
       mov       r10d,[r10+14]
       inc       r12d
       mov       r9d,[rsp+3C]
       cmp       r9d,r12d
       jb        near ptr M00_L14
       cmp       r9d,r10d
       ja        near ptr M00_L03
M00_L08:
       mov       edx,[rsi+40]
       test      edx,edx
       jg        short M00_L10
       mov       ecx,[rsi+38]
       mov       r14d,ecx
       cmp       [rsp+3C],r14d
       jne       short M00_L09
       call      qword ptr [7FFE500CF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE503573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rsi+8]
       mov       edx,r13d
       imul      rdx,[rsi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L20
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+30],rax
M00_L09:
       lea       ecx,[r14+1]
       mov       [rsi+38],ecx
       mov       rcx,[rsi+10]
       mov       r8,rcx
       mov       rax,r8
       mov       r8d,r14d
       mov       r14,rax
       jmp       short M00_L11
M00_L10:
       mov       ecx,[rsi+3C]
       mov       r8d,ecx
       cmp       ecx,[rsp+3C]
       jae       near ptr M00_L20
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+3C],ecx
       dec       edx
       mov       [rsi+40],edx
M00_L11:
       cmp       r8d,[r14+8]
       jae       near ptr M00_L20
       mov       [rsp+48],r8d
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r10,[r14+rcx*8+10]
       mov       [rsp+28],r10
       mov       [r10+10],r13d
       mov       rax,[rsp+30]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,[rsp+48]
       inc       ebp
       mov       r13,[rsp+30]
       mov       [r13],ebp
       inc       dword ptr [rsi+44]
       cmp       r12d,64
       jbe       short M00_L12
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L12
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFE503573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L12:
       mov       [rsp+50],rdi
M00_L13:
       mov       rcx,[rsp+50]
       xor       edx,edx
       mov       [rsp+50],rdx
       mov       [rsp+40],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+40]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,58
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
       call      qword ptr [7FFE500CF498]
       int       3
M00_L15:
       mov       r8,[r13]
       mov       [rsp+50],r8
       jmp       short M00_L13
M00_L16:
       call      qword ptr [7FFE50667450]
       mov       ecx,16D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE509650E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5087F198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      qword ptr [7FFE50667450]
       mov       ecx,14D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE509650E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5087F198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FFE50667450]
       mov       ecx,65
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE509650E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5087F198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       lea       r8,[rsp+50]
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFE50011480
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L13
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FFE50011488
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1546
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M01_L02
       mov       rcx,7FFE741A0B08
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
       call      qword ptr [7FFE5087EE38]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE50435EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M01_L06
M01_L04:
       mov       ecx,esi
       call      qword ptr [7FFE5087C0A8]
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
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       jmp       qword ptr [rax]
M02_L01:
       cmp       ecx,7FFFFFC3
       jge       short M02_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M03_L06
M03_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M03_L03
       cmp       [rbp+8],r14d
       jl        short M03_L04
M03_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M03_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M03_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L01
M03_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M03_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M03_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M03_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L04
       jmp       near ptr M03_L03
M03_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M03_L00
M03_L07:
       cmp       r15d,[rbp+8]
       jae       short M03_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M03_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M03_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M03_L07
       jmp       near ptr M03_L00
M03_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
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
       je        near ptr M05_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M05_L00
       test      rbx,rbx
       je        near ptr M05_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M05_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L00:
       test      rbx,rbx
       je        short M05_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L02
M05_L01:
       mov       rax,16C449C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       call      qword ptr [7FFE5087E4D8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.GetOrAdd()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rdx,[rcx+48]
       mov       rsi,[rdx+28]
       mov       [rbp-78],rdx
       cmp       qword ptr [rbp-78],0
       je        near ptr M00_L19
       mov       rdx,[rbp-78]
       mov       [rbp-78],rdx
       test      rsi,rsi
       je        near ptr M00_L20
       test      rbx,rbx
       je        near ptr M00_L21
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M00_L22
       cmp       qword ptr [rbx+8],0
       je        short M00_L00
       mov       rdi,[rbx+18]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FFE50031688
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L33
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       cmp       [r13+8],r15d
       ja        near ptr M00_L16
M00_L00:
       xor       r15d,r15d
M00_L01:
       test      r15,r15
       jne       near ptr M00_L15
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-80],rbx
       mov       [rbp-88],rsi
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L23
M00_L02:
       mov       r8,[rbx+10]
       mov       [rbp-90],r8
       mov       rdx,[rbx+18]
       mov       [rbp-98],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rdx],r8
       jne       near ptr M00_L26
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       r8d,[rsi+8]
       mov       [rbp-4C],r8d
       lea       r8,[rsi+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M00_L04
M00_L03:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       near ptr M00_L24
       mov       r9d,[rbp-4C]
       add       r9d,0FFFFFFFC
       mov       [rbp-4C],r9d
       rorx      r9d,[rbp-44],1B
       add       r9d,[rbp-44]
       or        eax,200020
       xor       eax,r9d
       mov       [rbp-44],eax
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r10d,200020
       xor       eax,r10d
       mov       [rbp-48],eax
       add       r8,8
       cmp       dword ptr [rbp-4C],2
       jg        short M00_L03
M00_L04:
       cmp       dword ptr [rbp-4C],0
       jle       short M00_L05
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L24
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
M00_L05:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
M00_L06:
       mov       r15d,eax
M00_L07:
       xor       edi,edi
       mov       r8,[rbx+8]
       mov       r11d,r15d
       imul      r11,[rbx+30]
       shr       r11,20
       inc       r11
       mov       eax,[r8+8]
       imul      r11,rax
       shr       r11,20
       cmp       r11d,[r8+8]
       jae       near ptr M00_L33
       mov       r11d,r11d
       lea       r14,[r8+r11*4+10]
       mov       eax,[r14]
       dec       eax
       mov       r8,[rbp-90]
       mov       r13d,[r8+8]
       cmp       r13d,eax
       ja        near ptr M00_L13
M00_L08:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L29
       mov       r12d,[rbx+38]
       cmp       r13d,r12d
       je        near ptr M00_L30
M00_L09:
       lea       eax,[r12+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-90],rax
M00_L10:
       mov       rax,[rbp-90]
       cmp       r12d,[rax+8]
       jae       near ptr M00_L33
       mov       rax,[rbp-90]
       mov       r8d,r12d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],r15d
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       [r14],r12d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L31
M00_L11:
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
M00_L12:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       r8,[rbp-90]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r12,[r8+r11*8+10]
       cmp       [r12+10],r15d
       je        near ptr M00_L27
M00_L14:
       mov       eax,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M00_L28
       cmp       r13d,eax
       ja        short M00_L13
       jmp       near ptr M00_L08
M00_L15:
       mov       r8,[r15]
       mov       [rbp-40],r8
       jmp       short M00_L12
M00_L16:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        short M00_L18
M00_L17:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jb        near ptr M00_L28
       cmp       [r13+8],r15d
       jbe       near ptr M00_L00
       jmp       short M00_L16
M00_L18:
       mov       rdx,[r15]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FFE50031690
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L17
       add       r15,8
       jmp       near ptr M00_L01
M00_L19:
       call      qword ptr [7FFE50687450]
       mov       ecx,16D
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503B5AC0
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE507AE208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE507AE220]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FFE50687450]
       mov       ecx,14D
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503B5AC0
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE507AE208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE507AE220]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FFE50687450]
       mov       ecx,65
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503B5AC0
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE507AE208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE507AE220]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FFE50031678
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L32
M00_L23:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE500E5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L02
M00_L24:
       call      M00_L34
       nop
       mov       rsi,[rbp-88]
       mov       r8d,[rsi+8]
       sub       r8d,[rbp-4C]
       cmp       [rsi+8],r8d
       jae       short M00_L25
       mov       ecx,21
       call      qword ptr [7FFE500EF360]
       int       3
M00_L25:
       mov       edx,r8d
       lea       rdx,[rsi+rdx*2+0C]
       mov       ecx,[rsi+8]
       sub       ecx,r8d
       mov       [rbp-70],rdx
       mov       [rbp-68],ecx
       lea       r8,[rbp-70]
       mov       edx,[rbp-48]
       mov       ecx,[rbp-44]
       call      qword ptr [7FFE508FF9F0]
       mov       rdx,[rbp-98]
       mov       rbx,[rbp-80]
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FFE50031698
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rbp-98]
       jmp       near ptr M00_L07
M00_L27:
       mov       r8,[rbp-90]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-98]
       mov       r8,rsi
       mov       r11,7FFE500316A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-98]
       je        near ptr M00_L14
       mov       rdx,rsi
       mov       rcx,7FFE509477C0
       call      qword ptr [7FFE500EFD20]
       int       3
M00_L28:
       call      qword ptr [7FFE500EF498]
       int       3
M00_L29:
       mov       eax,[rbx+3C]
       mov       r12d,eax
       cmp       eax,r13d
       jae       near ptr M00_L33
       mov       r8,[rbp-90]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L10
M00_L30:
       mov       rcx,rbx
       call      qword ptr [7FFE508F4228]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L33
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-98]
       jmp       near ptr M00_L09
M00_L31:
       mov       rdx,[rbp-98]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L11
       mov       rdx,[rbp-90]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE503773F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L11
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-78]
       mov       rdx,rsi
       mov       r11,7FFE50031680
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1887
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2520CD60008
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
       call      qword ptr [7FFE508FF000]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE509008A8
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       call      qword ptr [7FFE74E23ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 40
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
       jmp       short M04_L02
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L03
       cmp       [rbp+8],r14d
       jl        short M05_L04
M05_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M05_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L01
M05_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M05_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M05_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M05_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L04
       jmp       near ptr M05_L03
M05_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L00
M05_L07:
       cmp       r15d,[rbp+8]
       jae       short M05_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M05_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M05_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L07
       jmp       near ptr M05_L00
M05_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508955F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504B78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508955F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508AA940
       call      qword ptr [7FFE50895590]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AAA58
       call      qword ptr [7FFE508955C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 149
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+28]
       cmp       qword ptr [rax],0
       jne       short M03_L00
       add       rsp,70
       pop       rbp
       ret
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M03_L00:
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M03_L01
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B290
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,2BB0C6C9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2BB0C6C0008
       call      qword ptr [7FFE5065F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M03_L03
       mov       rax,[rbp-38]
       mov       [rbp-20],rax
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B4D0
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,2BB0C6CFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2BB0C6C0008
       call      qword ptr [7FFE5065F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		collection[key] = item;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M03_L05
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5088B4F8
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+28]
       mov       r8,[rax]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-28]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-28]
       call      qword ptr [rax]
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 354
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5088B648
       call      qword ptr [7FFE500BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508956C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE50895680]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A5710]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504C78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A5710]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508BAED8
       call      qword ptr [7FFE508A56B0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508BAFF0
       call      qword ptr [7FFE508A56E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 149
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+28]
       cmp       qword ptr [rax],0
       jne       short M03_L00
       add       rsp,70
       pop       rbp
       ret
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M03_L00:
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-30],0
       je        short M03_L01
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B378
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,31257FC9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,31257FC0008
       call      qword ptr [7FFE5066F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M03_L03
       mov       rax,[rbp-38]
       mov       [rbp-20],rax
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B5B8
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,31257FCFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,31257FC0008
       call      qword ptr [7FFE5066F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		collection[key] = item;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M03_L05
       mov       rax,[rbp-40]
       mov       [rbp-28],rax
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B5E0
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+28]
       mov       r8,[rax]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-28]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-28]
       call      qword ptr [rax]
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 354
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5089B730
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A57E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508A57A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504D78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508CAFC0
       call      qword ptr [7FFE508B5638]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508CB0D8
       call      qword ptr [7FFE508B5668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 149
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+28]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection[key] = item;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rax,[rbp+28]
       cmp       qword ptr [rax],0
       jne       short M03_L00
       mov       rcx,7FFE509C6258
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FFE509C625C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M03_L01
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB378
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,1D0A6699F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1D0A6690008
       call      qword ptr [7FFE5067EE50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M03_L03
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB5B8
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,1D0A669FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1D0A6690008
       call      qword ptr [7FFE5067EE50]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M03_L05
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508AB5E0
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FFE509C6260
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-30]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rax,[rbp+28]
       mov       r8,[rax]
       mov       r11,[rbp-28]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-28]
       call      qword ptr [rax]
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 445
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE508AB730
       call      qword ptr [7FFE500DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508B5770]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508B5728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A56C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE504C78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A56C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FFE508BAEE8
       call      qword ptr [7FFE508A5668]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE508BB000
       call      qword ptr [7FFE508A5698]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 149
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
; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
; 			return this._id;
; 			^^^^^^^^^^^^^^^^
       mov       rax,[rcx+28]
       ret
; Total bytes of code 5
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 		key = key.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection = collection.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		collection[key] = item;
; 		^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rax,[rbp+28]
       cmp       qword ptr [rax],0
       jne       short M03_L00
       mov       rcx,7FFE509B5E98
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FFE509B5E9C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M03_L01
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B378
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,2A81A7A9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2A81A7A0008
       call      qword ptr [7FFE5066F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M03_L03
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M03_L04
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B5B8
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,2A81A7AFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A81A7A0008
       call      qword ptr [7FFE5066F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M03_L05
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       jmp       short M03_L06
M03_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFE5089B5E0
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FFE509B5EA0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-30]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rax,[rbp+28]
       mov       r8,[rax]
       mov       r11,[rbp-28]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-28]
       call      qword ptr [rax]
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 445
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
       je        short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M04_L01
M04_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE5089B730
       call      qword ptr [7FFE500CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE508A57A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE508A5758]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       rdx,[rcx+48]
       mov       r8,[rdx+28]
       mov       [rbp-68],r8
       test      rdx,rdx
       je        near ptr M00_L09
       test      r8,r8
       je        near ptr M00_L12
       test      rax,rax
       je        near ptr M00_L13
       mov       r10,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rbx,rax
       mov       [rbp-70],rbx
       mov       [rbp-78],rdx
       mov       [rbp-80],r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L14
M00_L00:
       mov       r8,[rbx+10]
       mov       [rbp-88],r8
       mov       rdx,[rbx+18]
       mov       [rbp-90],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-90]
       cmp       [rdx],r8
       jne       near ptr M00_L17
       mov       dword ptr [rbp-34],15051505
       mov       dword ptr [rbp-38],15051505
       mov       r8,[rbp-80]
       mov       eax,[r8+8]
       mov       [rbp-3C],eax
       lea       rax,[r8+0C]
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       cmp       dword ptr [rbp-3C],2
       jle       short M00_L02
M00_L01:
       mov       r10d,[rax]
       mov       r9d,[rax+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L15
       mov       r11d,[rbp-3C]
       add       r11d,0FFFFFFFC
       mov       [rbp-3C],r11d
       rorx      r11d,[rbp-34],1B
       add       r11d,[rbp-34]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-34],r10d
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-38],r10d
       add       rax,8
       cmp       dword ptr [rbp-3C],2
       jg        short M00_L01
M00_L02:
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L03
       mov       eax,[rax]
       test      eax,0FF80FF80
       jne       near ptr M00_L15
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        eax,200020
       xor       eax,r10d
       mov       [rbp-38],eax
M00_L03:
       xor       r11d,r11d
       mov       [rbp-48],r11
       imul      eax,[rbp-38],5D588B65
       add       eax,[rbp-34]
M00_L04:
       mov       esi,eax
M00_L05:
       xor       edi,edi
       mov       r11,[rbx+8]
       mov       eax,esi
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r10d,[r11+8]
       mov       r9d,r10d
       imul      rax,r9
       shr       rax,20
       cmp       eax,r10d
       jae       near ptr M00_L24
       mov       eax,eax
       lea       r14,[r11+rax*4+10]
       mov       eax,[r14]
       dec       eax
       mov       r11,[rbp-88]
       mov       r15d,[r11+8]
       cmp       r15d,eax
       ja        near ptr M00_L10
M00_L06:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L20
       mov       r13d,[rbx+38]
       cmp       r15d,r13d
       je        near ptr M00_L21
M00_L07:
       lea       eax,[r13+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-88],rax
M00_L08:
       mov       rax,[rbp-88]
       cmp       r13d,[rax+8]
       jae       near ptr M00_L24
       mov       rax,[rbp-88]
       mov       r10d,r13d
       lea       r10,[r10+r10*2]
       lea       r15,[rax+r10*8+10]
       mov       [r15+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r15+14],eax
       mov       rcx,r15
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       [r14],r13d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L22
M00_L09:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+278]
       mov       [rbp-50],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       r11,[rbp-88]
       mov       r10d,eax
       lea       r10,[r10+r10*2]
       lea       r13,[r11+r10*8+10]
       cmp       [r13+10],esi
       je        near ptr M00_L18
M00_L11:
       mov       eax,[r13+14]
       inc       edi
       cmp       r15d,edi
       jb        near ptr M00_L19
       cmp       r15d,eax
       ja        short M00_L10
       jmp       near ptr M00_L06
M00_L12:
       call      qword ptr [7FFE5066F240]
       mov       ecx,14D
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508ACDB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508ACDC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFE5066F240]
       mov       ecx,65
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE50395AC0
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504CC720
       call      qword ptr [7FFE500CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508ACDB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508ACDC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE500C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L15:
       call      M00_L25
       nop
       mov       r8,[rbp-80]
       mov       edx,[r8+8]
       sub       edx,[rbp-3C]
       cmp       [r8+8],edx
       jae       short M00_L16
       mov       ecx,21
       call      qword ptr [7FFE500CF360]
       int       3
M00_L16:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2+0C]
       mov       eax,[r8+8]
       sub       eax,edx
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE508AE928]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FFE500113A0
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L05
M00_L18:
       mov       r11,[rbp-88]
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*8+10]
       mov       rcx,[rbp-90]
       mov       r11,7FFE500113A8
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       je        near ptr M00_L11
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L19:
       call      qword ptr [7FFE500CF498]
       int       3
M00_L20:
       mov       r13d,[rbx+3C]
       mov       eax,[rbx+3C]
       cmp       eax,r15d
       jae       near ptr M00_L24
       mov       r10,[rbp-88]
       lea       rax,[rax+rax*2]
       mov       eax,[r10+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L08
M00_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508AE7D8]
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L24
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,[rbp-90]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rdx,[rbp-88]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE503573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FFE50011398
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L25:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-48],r8
       add       rsp,28
       ret
; Total bytes of code 1464
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B87A450008
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
       call      qword ptr [7FFE508AEF58]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M02_L01
       mov       rcx,rax
M02_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE5099AC70
       call      qword ptr [7FFE500CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        short M04_L04
M04_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M04_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M04_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       rdx,[rcx+48]
       mov       r8,[rdx+28]
       mov       [rbp-68],r8
       test      rdx,rdx
       je        near ptr M00_L09
       test      r8,r8
       je        near ptr M00_L12
       test      rax,rax
       je        near ptr M00_L13
       mov       r10,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rbx,rax
       mov       [rbp-70],rbx
       mov       [rbp-78],rdx
       mov       [rbp-80],r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L14
M00_L00:
       mov       r8,[rbx+10]
       mov       [rbp-88],r8
       mov       rdx,[rbx+18]
       mov       [rbp-90],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-90]
       cmp       [rdx],r8
       jne       near ptr M00_L17
       mov       dword ptr [rbp-34],15051505
       mov       dword ptr [rbp-38],15051505
       mov       r8,[rbp-80]
       mov       eax,[r8+8]
       mov       [rbp-3C],eax
       lea       rax,[r8+0C]
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       cmp       dword ptr [rbp-3C],2
       jle       short M00_L02
M00_L01:
       mov       r10d,[rax]
       mov       r9d,[rax+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L15
       mov       r11d,[rbp-3C]
       add       r11d,0FFFFFFFC
       mov       [rbp-3C],r11d
       rorx      r11d,[rbp-34],1B
       add       r11d,[rbp-34]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-34],r10d
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-38],r10d
       add       rax,8
       cmp       dword ptr [rbp-3C],2
       jg        short M00_L01
M00_L02:
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L03
       mov       eax,[rax]
       test      eax,0FF80FF80
       jne       near ptr M00_L15
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        eax,200020
       xor       eax,r10d
       mov       [rbp-38],eax
M00_L03:
       xor       r11d,r11d
       mov       [rbp-48],r11
       imul      eax,[rbp-38],5D588B65
       add       eax,[rbp-34]
M00_L04:
       mov       esi,eax
M00_L05:
       xor       edi,edi
       mov       r11,[rbx+8]
       mov       eax,esi
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r10d,[r11+8]
       mov       r9d,r10d
       imul      rax,r9
       shr       rax,20
       cmp       eax,r10d
       jae       near ptr M00_L24
       mov       eax,eax
       lea       r14,[r11+rax*4+10]
       mov       eax,[r14]
       dec       eax
       mov       r11,[rbp-88]
       cmp       [r11+8],eax
       ja        near ptr M00_L10
M00_L06:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L20
       mov       r15d,[rbx+38]
       mov       rax,[rbp-88]
       cmp       [rax+8],r15d
       je        near ptr M00_L21
M00_L07:
       lea       eax,[r15+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-88],rax
M00_L08:
       mov       rax,[rbp-88]
       cmp       r15d,[rax+8]
       jae       near ptr M00_L24
       mov       rax,[rbp-88]
       mov       r10d,r15d
       lea       r10,[r10+r10*2]
       lea       r13,[rax+r10*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L22
M00_L09:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+278]
       mov       [rbp-50],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       r11,[rbp-88]
       mov       r10d,eax
       lea       r10,[r10+r10*2]
       lea       r15,[r11+r10*8+10]
       cmp       [r15+10],esi
       je        near ptr M00_L18
M00_L11:
       mov       eax,[r15+14]
       inc       edi
       mov       r10,[rbp-88]
       cmp       [r10+8],edi
       jb        near ptr M00_L19
       mov       r10,[rbp-88]
       cmp       [r10+8],eax
       ja        short M00_L10
       jmp       near ptr M00_L06
M00_L12:
       call      qword ptr [7FFE5067F210]
       mov       ecx,14D
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503A5AC0
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508BD050]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508BD068]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFE5067F210]
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503A5AC0
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508BD050]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508BD068]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE500D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L15:
       call      M00_L25
       nop
       mov       r8,[rbp-80]
       mov       edx,[r8+8]
       sub       edx,[rbp-3C]
       cmp       [r8+8],edx
       jae       short M00_L16
       mov       ecx,21
       call      qword ptr [7FFE500DF360]
       int       3
M00_L16:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2+0C]
       mov       eax,[r8+8]
       sub       eax,edx
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE508BF288]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FFE50021398
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L05
M00_L18:
       mov       r11,[rbp-88]
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*8+10]
       mov       rcx,[rbp-90]
       mov       r11,7FFE500213A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       je        near ptr M00_L11
       lea       rcx,[r15+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L19:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L20:
       mov       r15d,[rbx+3C]
       mov       eax,[rbx+3C]
       mov       r10,[rbp-88]
       cmp       eax,[r10+8]
       jae       near ptr M00_L24
       mov       r10,[rbp-88]
       lea       rax,[rax+rax*2]
       mov       eax,[r10+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L08
M00_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508BE730]
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L24
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,[rbp-90]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rdx,[rbp-88]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE503673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FFE50021390
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L25:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-48],r8
       add       rsp,28
       ret
; Total bytes of code 1493
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,198AD840008
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
       call      qword ptr [7FFE508BEEC8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE50923F78
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        short M04_L04
M04_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M04_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M04_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       rdx,[rcx+48]
       mov       r8,[rdx+28]
       mov       [rbp-68],r8
       test      rdx,rdx
       je        near ptr M00_L09
       test      r8,r8
       je        near ptr M00_L12
       test      rax,rax
       je        near ptr M00_L13
       mov       r10,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rbx,rax
       mov       [rbp-70],rbx
       mov       [rbp-78],rdx
       mov       [rbp-80],r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L14
M00_L00:
       mov       r8,[rbx+10]
       mov       [rbp-88],r8
       mov       rdx,[rbx+18]
       mov       [rbp-90],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-90]
       cmp       [rdx],r8
       jne       near ptr M00_L17
       mov       dword ptr [rbp-34],15051505
       mov       dword ptr [rbp-38],15051505
       mov       r8,[rbp-80]
       mov       eax,[r8+8]
       mov       [rbp-3C],eax
       lea       rax,[r8+0C]
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       cmp       dword ptr [rbp-3C],2
       jle       short M00_L02
M00_L01:
       mov       r10d,[rax]
       mov       r9d,[rax+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L15
       mov       r11d,[rbp-3C]
       add       r11d,0FFFFFFFC
       mov       [rbp-3C],r11d
       rorx      r11d,[rbp-34],1B
       add       r11d,[rbp-34]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-34],r10d
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-38],r10d
       add       rax,8
       cmp       dword ptr [rbp-3C],2
       jg        short M00_L01
M00_L02:
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L03
       mov       eax,[rax]
       test      eax,0FF80FF80
       jne       near ptr M00_L15
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        eax,200020
       xor       eax,r10d
       mov       [rbp-38],eax
M00_L03:
       xor       r11d,r11d
       mov       [rbp-48],r11
       imul      eax,[rbp-38],5D588B65
       add       eax,[rbp-34]
M00_L04:
       mov       esi,eax
M00_L05:
       xor       edi,edi
       mov       r11,[rbx+8]
       mov       eax,esi
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r10d,[r11+8]
       mov       r9d,r10d
       imul      rax,r9
       shr       rax,20
       cmp       eax,r10d
       jae       near ptr M00_L24
       mov       eax,eax
       lea       r14,[r11+rax*4+10]
       mov       eax,[r14]
       dec       eax
       mov       r11,[rbp-88]
       cmp       [r11+8],eax
       ja        near ptr M00_L10
M00_L06:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L20
       mov       r15d,[rbx+38]
       mov       rax,[rbp-88]
       cmp       [rax+8],r15d
       je        near ptr M00_L21
M00_L07:
       lea       eax,[r15+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-88],rax
M00_L08:
       mov       rax,[rbp-88]
       cmp       r15d,[rax+8]
       jae       near ptr M00_L24
       mov       rax,[rbp-88]
       mov       r10d,r15d
       lea       r10,[r10+r10*2]
       lea       r13,[rax+r10*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L22
M00_L09:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+278]
       mov       [rbp-50],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       r11,[rbp-88]
       mov       r10d,eax
       lea       r10,[r10+r10*2]
       lea       r15,[r11+r10*8+10]
       cmp       [r15+10],esi
       je        near ptr M00_L18
M00_L11:
       mov       eax,[r15+14]
       inc       edi
       mov       r10,[rbp-88]
       cmp       [r10+8],edi
       jb        near ptr M00_L19
       mov       r10,[rbp-88]
       cmp       [r10+8],eax
       ja        short M00_L10
       jmp       near ptr M00_L06
M00_L12:
       call      qword ptr [7FFE5068ED00]
       mov       ecx,14D
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503B5AC0
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508BCF78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508BCF90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFE5068ED00]
       mov       ecx,65
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503B5AC0
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504EC720
       call      qword ptr [7FFE500EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE508BCF78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE508BCF90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE500E5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L15:
       call      M00_L25
       nop
       mov       r8,[rbp-80]
       mov       edx,[r8+8]
       sub       edx,[rbp-3C]
       cmp       [r8+8],edx
       jae       short M00_L16
       mov       ecx,21
       call      qword ptr [7FFE500EF360]
       int       3
M00_L16:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2+0C]
       mov       eax,[r8+8]
       sub       eax,edx
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE508BFF00]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FFE50031478
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L05
M00_L18:
       mov       r11,[rbp-88]
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*8+10]
       mov       rcx,[rbp-90]
       mov       r11,7FFE50031480
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       je        near ptr M00_L11
       lea       rcx,[r15+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L19:
       call      qword ptr [7FFE500EF498]
       int       3
M00_L20:
       mov       r15d,[rbx+3C]
       mov       eax,[rbx+3C]
       mov       r10,[rbp-88]
       cmp       eax,[r10+8]
       jae       near ptr M00_L24
       mov       r10,[rbp-88]
       lea       rax,[rax+rax*2]
       mov       eax,[r10+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L08
M00_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE508BED00]
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L24
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,[rbp-90]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rdx,[rbp-88]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE503773F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FFE50031470
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L25:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-48],r8
       add       rsp,28
       ret
; Total bytes of code 1493
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21B21640008
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
       call      qword ptr [7FFE508BF5A0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE50939A08
       call      qword ptr [7FFE500EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        short M04_L04
M04_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M04_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M04_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M04_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       rdx,[rcx+48]
       mov       r8,[rdx+28]
       mov       [rbp-68],r8
       test      rdx,rdx
       je        near ptr M00_L09
       test      r8,r8
       je        near ptr M00_L12
       test      rax,rax
       je        near ptr M00_L13
       mov       r10,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rbx,rax
       mov       [rbp-70],rbx
       mov       [rbp-78],rdx
       mov       [rbp-80],r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L14
M00_L00:
       mov       rdx,[rbx+10]
       mov       [rbp-88],rdx
       mov       rdx,[rbx+18]
       mov       [rbp-90],rdx
       mov       rax,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rdx],rax
       jne       near ptr M00_L17
       mov       dword ptr [rbp-34],15051505
       mov       dword ptr [rbp-38],15051505
       mov       r8,[rbp-80]
       mov       eax,[r8+8]
       mov       [rbp-3C],eax
       lea       rax,[r8+0C]
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       cmp       dword ptr [rbp-3C],2
       jle       short M00_L02
M00_L01:
       mov       r10d,[rax]
       mov       r9d,[rax+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M00_L15
       mov       r11d,[rbp-3C]
       add       r11d,0FFFFFFFC
       mov       [rbp-3C],r11d
       rorx      r11d,[rbp-34],1B
       add       r11d,[rbp-34]
       or        r10d,200020
       xor       r10d,r11d
       mov       [rbp-34],r10d
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        r9d,200020
       xor       r10d,r9d
       mov       [rbp-38],r10d
       add       rax,8
       cmp       dword ptr [rbp-3C],2
       jg        short M00_L01
M00_L02:
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L03
       mov       eax,[rax]
       test      eax,0FF80FF80
       jne       near ptr M00_L15
       rorx      r10d,[rbp-38],1B
       add       r10d,[rbp-38]
       or        eax,200020
       xor       eax,r10d
       mov       [rbp-38],eax
M00_L03:
       xor       r11d,r11d
       mov       [rbp-48],r11
       imul      eax,[rbp-38],5D588B65
       add       eax,[rbp-34]
M00_L04:
       mov       esi,eax
M00_L05:
       xor       edi,edi
       mov       r11,[rbx+8]
       mov       eax,esi
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r10d,[r11+8]
       mov       r9d,r10d
       imul      rax,r9
       shr       rax,20
       cmp       eax,r10d
       jae       near ptr M00_L24
       mov       eax,eax
       lea       r14,[r11+rax*4+10]
       mov       eax,[r14]
       dec       eax
       mov       r11,[rbp-88]
       mov       r15d,[r11+8]
       cmp       r15d,eax
       ja        near ptr M00_L10
M00_L06:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L20
       mov       r13d,[rbx+38]
       cmp       r15d,r13d
       je        near ptr M00_L21
M00_L07:
       lea       eax,[r13+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-88],rax
M00_L08:
       mov       rax,[rbp-88]
       cmp       r13d,[rax+8]
       jae       near ptr M00_L24
       mov       rax,[rbp-88]
       mov       r10d,r13d
       lea       r10,[r10+r10*2]
       lea       r15,[rax+r10*8+10]
       mov       [r15+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r15+14],eax
       mov       rcx,r15
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       [r14],r13d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L22
M00_L09:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+278]
       mov       [rbp-50],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       r11,[rbp-88]
       mov       r10d,eax
       lea       r10,[r10+r10*2]
       lea       r13,[r11+r10*8+10]
       cmp       [r13+10],esi
       je        near ptr M00_L18
M00_L11:
       mov       eax,[r13+14]
       inc       edi
       cmp       r15d,edi
       jb        near ptr M00_L19
       cmp       r15d,eax
       ja        short M00_L10
       jmp       near ptr M00_L06
M00_L12:
       call      qword ptr [7FFE5067F240]
       mov       ecx,14D
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503A5AC0
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE507B4FD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE507B4FF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFE5067F240]
       mov       ecx,65
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE503A5AC0
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE504DC720
       call      qword ptr [7FFE500DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE500DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE507B4FD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE507B4FF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE500D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L15:
       call      M00_L25
       nop
       mov       r8,[rbp-80]
       mov       edx,[r8+8]
       sub       edx,[rbp-3C]
       cmp       [r8+8],edx
       jae       short M00_L16
       mov       ecx,21
       call      qword ptr [7FFE500DF360]
       int       3
M00_L16:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2+0C]
       mov       eax,[r8+8]
       sub       eax,edx
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FFE50A14330]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FFE500216A0
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L05
M00_L18:
       mov       r11,[rbp-88]
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*8+10]
       mov       rcx,[rbp-90]
       mov       r11,7FFE500216A8
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       je        near ptr M00_L11
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L19:
       call      qword ptr [7FFE500DF498]
       int       3
M00_L20:
       mov       eax,[rbx+3C]
       mov       r13d,eax
       cmp       eax,r15d
       jae       near ptr M00_L24
       mov       r10,[rbp-88]
       lea       rax,[rax+rax*2]
       mov       eax,[r10+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L08
M00_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE507BF828]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbx+8]
       mov       edx,esi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M00_L24
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,[rbp-90]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L09
       mov       rdx,[rbp-88]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE503673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FFE50021698
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L25:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-48],r8
       add       rsp,28
       ret
; Total bytes of code 1458
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
       call      00007FFEAFD59D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE500D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AF36A80008
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
       call      qword ptr [7FFE508FEBE0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFE500D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rdx,7FFE508AB398
       call      qword ptr [7FFE500DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+38]
       call      qword ptr [7FFE74E23ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 40
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
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E07E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFE74E04088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE74E152F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFE74E11B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L03
       cmp       [rbp+8],r14d
       jl        short M05_L04
M05_L01:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [rbp+rdx*8+24],0FFFFFFFF
       jl        short M05_L02
       mov       eax,[rbp+rdx*8+20]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L09
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rbp+rdx*8+24],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L01
M05_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M05_L09
       mov       eax,ecx
       lea       rdx,[rax+rax*2]
       lea       rdx,[rbp+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M05_L05
       mov       eax,[rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M05_L09
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L04
       jmp       near ptr M05_L03
M05_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E070B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE74E13730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE74E04090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFE74E03FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L00
M05_L07:
       cmp       r15d,[rbp+8]
       jae       short M05_L09
       lea       rcx,[r15+r15*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M05_L08
       mov       rcx,[rbx]
       call      qword ptr [7FFE74E09060]
       lea       r13,[r15+r15*2]
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+r13*8+20],eax
M05_L08:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L07
       jmp       near ptr M05_L00
M05_L09:
       call      qword ptr [7FFE74E03FD8]
       int       3
; Total bytes of code 517
```

