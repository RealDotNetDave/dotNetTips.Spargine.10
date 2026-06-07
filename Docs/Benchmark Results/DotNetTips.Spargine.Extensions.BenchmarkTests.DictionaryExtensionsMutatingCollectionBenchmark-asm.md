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
       mov       rcx,7FF9FB34A5B0
       mov       r9d,1
       call      qword ptr [7FF9FB335590]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9FB3355C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rdx,2B03348FD28
       call      qword ptr [7FF9FAF66820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
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
       mov       rdx,7FF9FB32ACF8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9FB3355D8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9FB32AF08
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9FB3356B0]
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
       mov       rdx,7FF9FB32ADA8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32AE58
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF9FB335620]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9FB335668]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       call      qword ptr [7FF9FB335CB0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB335C80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,7FF9FB36ABE0
       mov       r9d,1
       call      qword ptr [7FF9FB355638]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9FB355668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rdx,2362398FD28
       call      qword ptr [7FF9FAF86820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
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
       mov       rdx,7FF9FB34ADE0
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9FB355680]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       mov       rdx,7FF9FB34AFF0
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9FB355758]
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
       mov       rdx,7FF9FB34AE90
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB34AF40
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF9FB3556C8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9FB355710]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       call      qword ptr [7FF9FB355D58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB355D28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,7FF9FB36AB58
       mov       r9d,1
       call      qword ptr [7FF9FB3556C8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9FB3556F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rcx,7FF9FB46C168
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,1FE6FCDFD28
       call      qword ptr [7FF9FAF86820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
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
       mov       rdx,7FF9FB34ADE0
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9FB355710]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,7FF9FB46C16C
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
       mov       rdx,7FF9FB34AFF0
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9FB3557E8]
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FF9FB46C170
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
       mov       rdx,7FF9FB34AE90
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB34AF40
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF9FB355758]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9FB3557A0]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       call      qword ptr [7FF9FB355DE8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB355DB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,7FF9FB35AC20
       mov       r9d,1
       call      qword ptr [7FF9FB345680]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9FB3456B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rcx,7FF9FB45BFA0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,1EA28AFFD28
       call      qword ptr [7FF9FAF76820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
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
       mov       rdx,7FF9FB33ADE0
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9FB3456C8]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,7FF9FB45BFA4
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
       mov       rdx,7FF9FB33AFF0
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9FB3457A0]
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FF9FB45BFA8
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
       mov       rdx,7FF9FB33AE90
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB33AF40
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF9FB345710]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9FB345758]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       call      qword ptr [7FF9FB345DA0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB345D70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF9FAAB49D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FAB7F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF9FB355C68]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF9FAB7FC60]
       int       3
M00_L19:
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FF9FAAC1498
       call      qword ptr [r11]
       mov       rax,[rbp-130]
       jmp       near ptr M00_L08
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9FB355A70]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAAB49D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L11
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       mov       rcx,r8
       mov       r11,7FF9FAAC14A8
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
       mov       r11,7FF9FAAC14B0
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
       mov       r11,7FF9FAAC1490
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       short M00_L29
M00_L27:
       call      qword ptr [7FF9FAB7F498]
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
       call      qword ptr [7FF9FAEEC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FF9FB355B48]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF9FB1A4C48]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
M00_L39:
       mov       r8d,eax
       xor       eax,eax
       mov       [rbp-0E0],eax
       mov       rcx,r15
       mov       [rbp-0DC],r8d
       mov       edx,r8d
       call      qword ptr [7FF9FB4274E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FB35EDC0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FF9FB4274E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FAEEC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FF9FB355B48]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF9FB1A4C48]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       mov       r11d,eax
M00_L52:
       mov       eax,r11d
       xor       ecx,ecx
       mov       [rbp-0E0],ecx
       mov       rcx,r15
       mov       [rbp-0DC],eax
       mov       edx,eax
       call      qword ptr [7FF9FB4274E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FAB75A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L38
M00_L57:
       mov       rax,[rbp-188]
       mov       [rbp-188],rax
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FF9FAAC14B8
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
       mov       r11,7FF9FAAC14C0
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
       call      qword ptr [7FF9FAE073F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L36
M00_L60:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1440
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L61:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1448
       call      qword ptr [r11]
       jmp       near ptr M00_L50
M00_L62:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rdx,[rbp-100]
       mov       rcx,r14
       mov       r11,7FF9FAAC1450
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L63:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9FAB75A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L51
M00_L64:
       mov       rax,[rbp-188]
       mov       [rbp-188],rax
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FF9FAAC14B8
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
       mov       r11,7FF9FAAC14C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L54
       jmp       short M00_L69
M00_L66:
       mov       rcx,r14
       call      qword ptr [7FF9FB35EDC0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FF9FB4274E0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FAE073F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L47
M00_L68:
       mov       ecx,4
       call      qword ptr [7FF9FAB7FD50]
       int       3
M00_L69:
       mov       rdx,rdi
       mov       rcx,7FF9FB3D9CA0
       call      qword ptr [7FF9FAB7FD20]
       int       3
M00_L70:
       call      qword ptr [7FF9FAB7F498]
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
       call      qword ptr [7FF9FB355C80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rcx,rax
       call      qword ptr [7FF9FB35D728]
       int       3
M00_L76:
       call      qword ptr [7FF9FB3557D0]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L77
       call      qword ptr [7FF9FB4274B0]
       mov       r12,rax
M00_L77:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9FAEE7DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L78:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FF9FAAC1460
       call      qword ptr [r11]
       mov       [rbp-120],rax
M00_L79:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1468
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L80
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1470
       call      qword ptr [r11]
       lea       r8,[rbp-60]
       lea       rdx,[rbp-58]
       mov       rcx,r13
       call      qword ptr [7FF9FB355B48]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M00_L79
       mov       r12d,1
       jmp       short M00_L79
M00_L80:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1478
       call      qword ptr [r11]
       jmp       near ptr M00_L73
M00_L81:
       mov       rcx,r14
       mov       r11,7FF9FAAC1480
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L82:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F5C5800B30
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L83:
       mov       rcx,r14
       mov       r11,7FF9FAAC1488
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L84:
       mov       rcx,rax
       mov       r11,7FF9FAAC14A0
       call      qword ptr [r11]
       jmp       near ptr M00_L30
M00_L85:
       mov       edx,ecx
       sub       edx,[r13+30]
       mov       rcx,r13
       call      qword ptr [7FF9FB4274C8]
       jmp       near ptr M00_L31
M00_L86:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F5C5800B30
       mov       rdx,[rcx]
       jmp       near ptr M00_L32
M00_L87:
       mov       rcx,r15
       mov       r11,7FF9FAAC1438
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L32
M00_L88:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1458
       call      qword ptr [r11]
       jmp       near ptr M00_L73
       sub       rsp,28
       cmp       qword ptr [rbp-120],0
       je        short M00_L89
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAC1478
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
       mov       r11,7FF9FAAC1458
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
       mov       r11,7FF9FAAC14A0
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
       mov       rcx,7FFA4FEB0B08
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
       call      qword ptr [7FF9FB35E988]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAEE5EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9FB35E970]
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
       mov       rax,7FF9FAAB48F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7BB1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L05
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF9FAAB4938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7E2B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L08
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,532119E7
       mov       r8d,90EED43F
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
       mov       edx,0A208EF89
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
       mov       dword ptr [rbp-58],0AFD5CC00
       mov       dword ptr [rbp-54],119E524F
       mov       dword ptr [rbp-50],8BB287D8
       mov       dword ptr [rbp-4C],0ED7B0E27
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
       call      00007FFA5A7C27D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB425E60]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF9FB48DC58]
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
       mov       dword ptr [rbp-58],0AFD5CC00
       mov       dword ptr [rbp-54],119E524F
       mov       dword ptr [rbp-50],8BB287D8
       mov       dword ptr [rbp-4C],0ED7B0E27
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
       call      qword ptr [7FF9FAF8D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9FAF8D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB425E60]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9FB426CB8]
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
       call      qword ptr [7FF9FAF8D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
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
       mov       rdx,7FF9FB34C240
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FB11EBC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB35CDC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB35CDC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB35CDE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB34C240
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB7FC60]
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
       call      qword ptr [7FF9FAAB49D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FB355A70]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF9FB34C1C0
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB34C568
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB34C580
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB7F498]
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
       call      qword ptr [7FF9FB355BD8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF9FAB7F360]
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
       call      qword ptr [7FF9FB35EF40]
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
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
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
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
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
       mov       rdx,7FF9FB45DEB8
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FB11EBC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L03
M11_L15:
       mov       rcx,rax
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L03
M11_L16:
       xor       r15d,r15d
       jmp       short M11_L18
M11_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB35CDC8]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M11_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB35CDC8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB35CDE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
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
       mov       rdx,7FF9FB45DEB8
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rax,[rdx+0A8]
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
       call      qword ptr [7FF9FAB7F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rcx,7FF9FB46C640
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
       mov       rcx,7FF9FB46C644
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M13_L02
M13_L04:
       mov       rcx,7FF9FB46C648
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
       mov       rdx,7FF9FB45DEB8
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FF9FB46C640
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
       mov       rcx,7FF9FB46C644
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M13_L06
       jmp       near ptr M13_L04
M13_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+98]
       test      rdi,rdi
       je        short M13_L09
       jmp       short M13_L10
M13_L09:
       mov       rdx,7FF9FB45DDF8
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M13_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FF9FB46C420
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
       mov       rcx,7FF9FB46C528
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M13_L12
       jmp       short M13_L13
M13_L12:
       mov       rdx,7FF9FB3C4EA0
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M13_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FF9FB46C530
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M13_L14:
       mov       rcx,7FF9FB46C638
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M13_L11
M13_L15:
       mov       rcx,7FF9FB46C63C
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
       jmp       qword ptr [7FF9FAB75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF9FAAA49D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FAB6F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF9FB345DA0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF9FAB6FC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-130]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FF9FAAB1518
       call      qword ptr [r11]
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9FB345BA8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAAA49D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FF9FAAB1528
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
       mov       r11,7FF9FAAB1530
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
       mov       r11,7FF9FAAB1510
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L47
M00_L29:
       call      qword ptr [7FF9FAB6F498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FF9FAAB14E0
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
       call      qword ptr [7FF9FAEDC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FF9FB345C80]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L32
       mov       r12d,1
       jmp       near ptr M00_L32
M00_L35:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAB14F0
       call      qword ptr [r11]
       jmp       short M00_L34
M00_L36:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAB14E8
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
       call      qword ptr [7FF9FB345DB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       rcx,rax
       call      qword ptr [7FF9FB34DB00]
       int       3
M00_L41:
       call      qword ptr [7FF9FB345908]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L42
       call      qword ptr [7FF9FB417498]
       mov       r12,rax
M00_L42:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9FAED7DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAB14F8
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L44:
       mov       rcx,r14
       mov       r11,7FF9FAAB1500
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A519800B18
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L46:
       mov       rcx,r14
       mov       r11,7FF9FAAB1508
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L47:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L48
       mov       rcx,rax
       mov       r11,7FF9FAAB1520
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
       call      qword ptr [7FF9FB4174B0]
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
       mov       rcx,2A519800B18
       mov       rdx,[rcx]
M00_L51:
       jmp       short M00_L53
M00_L52:
       mov       rcx,r15
       mov       r11,7FF9FAAB14B8
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
       mov       r11,7FF9FAAB14C8
       call      qword ptr [r11]
M00_L57:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FF9FB345C80]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF9FAB65A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L58:
       mov       rdi,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-180],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rax],rcx
       jne       short M00_L59
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB194CA8]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       jmp       short M00_L60
M00_L59:
       mov       rax,[rbp-180]
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FF9FAAB1538
       call      qword ptr [r11]
M00_L60:
       mov       [rbp-0DC],eax
       xor       r8d,r8d
       mov       [rbp-0E0],r8d
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FF9FB4174C8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       mov       r11,7FF9FAAB1540
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
       call      qword ptr [7FF9FB34ED78]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FF9FB4174C8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FADF73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L67:
       mov       r12d,1
       jmp       near ptr M00_L54
M00_L68:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r14
       mov       r11,7FF9FAAB14D0
       call      qword ptr [r11]
       jmp       short M00_L67
M00_L69:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FF9FAEDC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L71
M00_L70:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAAB14C0
       call      qword ptr [r11]
M00_L71:
       test      eax,eax
       jne       near ptr M00_L55
       jmp       short M00_L76
M00_L72:
       mov       ecx,4
       call      qword ptr [7FF9FAB6FD50]
       int       3
M00_L73:
       mov       rdx,rsi
       mov       rcx,7FF9FB39EA30
       call      qword ptr [7FF9FAB6FD20]
       int       3
M00_L74:
       call      qword ptr [7FF9FAB6F498]
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
       mov       r11,7FF9FAAB14D8
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
       mov       r11,7FF9FAAB14F8
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
       mov       r11,7FF9FAAB14D8
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
       mov       r11,7FF9FAAB1520
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
       mov       rcx,7FFA4FEB0B08
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
       call      qword ptr [7FF9FB34EA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAED5EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9FB34D578]
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
       mov       rax,7FF9FAAA48F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7BB1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L05
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF9FAAA4938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7E2B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L08
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,0DFD1A844
       mov       r8d,474EF89C
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
       mov       edx,2584CD1B
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
       mov       dword ptr [rbp-58],3351A992
       mov       dword ptr [rbp-54],951A2FE1
       mov       dword ptr [rbp-50],0F2E656A
       mov       dword ptr [rbp-4C],70F6EBB9
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
       call      00007FFA5A7C27D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB416100]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF9FB479458]
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
       mov       dword ptr [rbp-58],3351A992
       mov       dword ptr [rbp-54],951A2FE1
       mov       dword ptr [rbp-50],0F2E656A
       mov       dword ptr [rbp-4C],70F6EBB9
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
       call      qword ptr [7FF9FAF7D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9FAF7D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB416100]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9FB416CB8]
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
       call      qword ptr [7FF9FAF7D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
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
       mov       rdx,7FF9FB33C328
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FB10EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9FAB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB34CF78]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB34CF78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB34CF90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB33C328
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB6FC60]
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
       call      qword ptr [7FF9FAAA49D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FB345BA8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF9FB33C2A8
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB33C650
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB33C668
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB6F498]
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
       call      qword ptr [7FF9FB345D10]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
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
       jmp       qword ptr [7FF9FAB65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
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
       mov       rdx,7FF9FB43FA78
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB6F360]
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
       call      qword ptr [7FF9FB34EEC8]
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
       call      qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M14_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
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
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
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
       mov       rdx,7FF9FB43FA78
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FB10EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L15:
       mov       rcx,rax
       call      qword ptr [7FF9FAB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L16:
       xor       r15d,r15d
       jmp       short M14_L18
M14_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB34CF78]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M14_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB34CF78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB34CF90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rax,[rdx+0A8]
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
       call      qword ptr [7FF9FAB6F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rcx,7FF9FB45D088
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
       mov       rcx,7FF9FB45D08C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M15_L02
M15_L04:
       mov       rcx,7FF9FB45D090
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
       mov       rdx,7FF9FB43FA78
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FF9FB45D088
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
       mov       rcx,7FF9FB45D08C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M15_L06
       jmp       near ptr M15_L04
M15_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+98]
       test      rdi,rdi
       je        short M15_L09
       jmp       short M15_L10
M15_L09:
       mov       rdx,7FF9FB43F9B8
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M15_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FF9FB45CE68
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
       mov       rcx,7FF9FB45CF70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M15_L12
       jmp       short M15_L13
M15_L12:
       mov       rdx,7FF9FB3B4BB0
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M15_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FF9FB45CF78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M15_L14:
       mov       rcx,7FF9FB45D080
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M15_L11
M15_L15:
       mov       rcx,7FF9FB45D084
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
       call      qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF9FAA849D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FAB4F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF9FB317888]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF9FAB4FC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-130]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-70]
       mov       rcx,[rbp-130]
       mov       r11,7FF9FAA91610
       call      qword ptr [r11]
       mov       rcx,[rbp-130]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9FB317690]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAA849D0]
       test      eax,eax
       mov       r8,[rbp-168]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-140]
       mov       r11,7FF9FAA91620
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
       mov       r11,7FF9FAA91628
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
       mov       r11,7FF9FAA91608
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L47
M00_L29:
       call      qword ptr [7FF9FAB4F498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r12d,r12d
       mov       rcx,r15
       mov       r11,7FF9FAA915D8
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
       call      qword ptr [7FF9FAEBC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FF9FB317768]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L32
       mov       r12d,1
       jmp       near ptr M00_L32
M00_L35:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAA915E8
       call      qword ptr [r11]
       jmp       short M00_L34
M00_L36:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAA915E0
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
       call      qword ptr [7FF9FB3178A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rcx,rax
       call      qword ptr [7FF9FB31DBC0]
       int       3
M00_L41:
       call      qword ptr [7FF9FB3173F0]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L42
       call      qword ptr [7FF9FB3E7828]
       mov       r12,rax
M00_L42:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9FAEB7DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAA915F0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L44:
       mov       rcx,r14
       mov       r11,7FF9FAA915F8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19643000AF8
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L46:
       mov       rcx,r14
       mov       r11,7FF9FAA91600
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L47:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-130]
       cmp       [rax],rcx
       je        short M00_L48
       mov       rcx,rax
       mov       r11,7FF9FAA91618
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
       call      qword ptr [7FF9FB3E7840]
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
       mov       rcx,19643000AF8
       mov       rdx,[rcx]
M00_L51:
       jmp       short M00_L53
M00_L52:
       mov       rcx,r15
       mov       r11,7FF9FAA915B0
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
       mov       r11,7FF9FAA915C0
       call      qword ptr [r11]
M00_L57:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       lea       r8,[rbp-0D8]
       mov       rcx,r13
       call      qword ptr [7FF9FB317768]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF9FAB45A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L58:
       mov       rdi,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-180],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rax],rcx
       jne       short M00_L59
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB174C60]; System.String.GetNonRandomizedHashCodeOrdinalIgnoreCase()
       jmp       short M00_L60
M00_L59:
       mov       rax,[rbp-180]
       mov       rcx,rax
       mov       rdx,[rbp-48]
       mov       r11,7FF9FAA91630
       call      qword ptr [r11]
M00_L60:
       mov       [rbp-0DC],eax
       xor       r8d,r8d
       mov       [rbp-0E0],r8d
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FF9FB3E7858]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       mov       r11,7FF9FAA91638
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
       call      qword ptr [7FF9FB31F408]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-0DC]
       call      qword ptr [7FF9FB3E7858]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
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
       call      qword ptr [7FF9FADD73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
M00_L67:
       mov       r12d,1
       jmp       near ptr M00_L54
M00_L68:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,r14
       mov       r11,7FF9FAA915C8
       call      qword ptr [r11]
       jmp       short M00_L67
M00_L69:
       mov       rdx,[rbp-120]
       mov       rdx,[rdx]
       mov       rcx,[rbp-120]
       add       rcx,8
       call      qword ptr [7FF9FAEBC000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L71
M00_L70:
       mov       rcx,[rbp-120]
       mov       r11,7FF9FAA915B8
       call      qword ptr [r11]
M00_L71:
       test      eax,eax
       jne       near ptr M00_L55
       jmp       short M00_L76
M00_L72:
       mov       ecx,4
       call      qword ptr [7FF9FAB4FD50]
       int       3
M00_L73:
       mov       rdx,rsi
       mov       rcx,7FF9FB36BA18
       call      qword ptr [7FF9FAB4FD20]
       int       3
M00_L74:
       call      qword ptr [7FF9FAB4F498]
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
       mov       r11,7FF9FAA915D0
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
       mov       r11,7FF9FAA915F0
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
       mov       r11,7FF9FAA915D0
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
       mov       r11,7FF9FAA91618
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
       mov       rcx,7FFA4FEB0B08
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
       call      qword ptr [7FF9FB31F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAEB5EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9FB31D320]
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
       mov       rax,7FF9FAA848F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7BB1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L05
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF9FAA84938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5A7E2B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA5AAA39A0],0
       je        short M03_L08
       call      qword ptr [7FFA5AA91648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,5AF7D8BF
       mov       r8d,17D38207
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
       mov       edx,0EF623B19
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
       mov       dword ptr [rbp-58],0FD2F1790
       mov       dword ptr [rbp-54],5EF79DDF
       mov       dword ptr [rbp-50],0D90BD368
       mov       dword ptr [rbp-4C],3AD459B7
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
       call      00007FFA5A7C27D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB3E6580]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF9FB46D4F8]
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
       mov       dword ptr [rbp-58],0FD2F1790
       mov       dword ptr [rbp-54],5EF79DDF
       mov       dword ptr [rbp-50],0D90BD368
       mov       dword ptr [rbp-4C],3AD459B7
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
       call      qword ptr [7FF9FAF5D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9FAF5D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9FB3E6580]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9FB3E6EE0]
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
       call      qword ptr [7FF9FAF5D968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M05_L07
       cmp       r8,4000
       ja        near ptr M05_L12
       mov       rcx,rax
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
       jne       near ptr M05_L11
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
       jl        near ptr M05_L10
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
       mov       rdx,7FF9FB32DD68
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       rcx,rax
       call      qword ptr [7FF9FAB45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L08:
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
M05_L09:
       inc       ecx
       cmp       ecx,ebp
       jge       near ptr M05_L05
M05_L10:
       cmp       ecx,edx
       jae       short M05_L16
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M05_L09
       jmp       short M05_L08
M05_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9FB0EEBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB22D1A0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB22D1A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB22D1B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L01
M05_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 606
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
       call      qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB32DD68
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB4FC60]
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
       call      qword ptr [7FF9FAA849D8]; System.ValueType.GetHashCode()
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
       call      qword ptr [7FF9FB317690]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF9FB32DCE8
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32E090
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32E0A8
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB4F498]
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
       call      qword ptr [7FF9FB3177F8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
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
       jmp       qword ptr [7FF9FAB45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB3A95A8
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9FAB4F360]
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
       call      qword ptr [7FF9FB3E4630]
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
       ja        near ptr M14_L13
M14_L00:
       mov       ecx,eax
       call      qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M14_L09
       cmp       r8,4000
       ja        near ptr M14_L15
       mov       rcx,rax
       call      00007FFA5A779170
       cmp       dword ptr [7FFA5AAA39A0],0
       jne       near ptr M14_L14
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
       jl        near ptr M14_L12
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
       mov       rdx,7FF9FB3A95A8
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L02
M14_L09:
       mov       rcx,rax
       call      qword ptr [7FF9FAB45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L10:
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
M14_L11:
       inc       ecx
       cmp       ecx,ebp
       jge       near ptr M14_L07
M14_L12:
       cmp       ecx,edx
       jae       near ptr M14_L19
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[rdi+rax*8+10]
       cmp       dword ptr [rax+14],0FFFFFFFF
       jl        short M14_L11
       jmp       short M14_L10
M14_L13:
       cmp       ecx,7FFFFFC3
       jge       near ptr M14_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M14_L01
M14_L14:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L03
M14_L15:
       mov       rcx,rax
       call      qword ptr [7FF9FB0EEBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L03
M14_L16:
       xor       r15d,r15d
       jmp       short M14_L18
M14_L17:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9FB22D1A0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M14_L18:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9FB22D1A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF9FB22D1B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M14_L03
M14_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 657
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
       call      qword ptr [7FF9FAB4F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rcx,7FF9FB4F06C8
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
       mov       rcx,7FF9FB4F06CC
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M15_L02
M15_L04:
       mov       rcx,7FF9FB4F06D0
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
       mov       rdx,7FF9FB3A95A8
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FF9FB4F06C8
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
       mov       rcx,7FF9FB4F06CC
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
       mov       rdx,7FF9FB4E3E70
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M15_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FF9FB4F04A8
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
       mov       rcx,7FF9FB4F05B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+78]
       test      r13,r13
       je        short M15_L12
       jmp       short M15_L13
M15_L12:
       mov       rdx,7FF9FB3A8B68
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M15_L13:
       lea       r12,[r15+r15*2]
       mov       rcx,rdi
       mov       rdx,7FF9FB4F05B8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       lea       rdx,[r15+r15*2]
       mov       rdx,[rbp+rdx*8+10]
       mov       r11,r13
       call      qword ptr [r13]
       mov       [rbp+r12*8+20],eax
M15_L14:
       mov       rcx,7FF9FB4F06C0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M15_L11
M15_L15:
       mov       rcx,7FF9FB4F06C4
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
       mov       rcx,7FF9FB3B9478
       mov       r9d,1
       call      qword ptr [7FF9FB36D530]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF9FB36D560]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rcx,7FF9FB4ED450
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,70
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,23E456FFD28
       call      qword ptr [7FF9FAF66820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
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
       mov       rdx,7FF9FB39FFB0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9FB36D578]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ThrowIfArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,7FF9FB4ED454
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
       mov       rdx,7FF9FB3C01F0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M01_L04:
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9FB36D650]
       nop
       add       rsp,70
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FF9FB4ED458
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
       mov       rdx,7FF9FB3C0090
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB3C0140
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L09:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF9FB36D5C0]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.ResolveComparer[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9FB36D608]; DotNetTips.Spargine.Extensions.CollectionExtensionsHelper.AddUniqueItemsToCollection[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
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
       call      qword ptr [7FF9FB36DC50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB36DC20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
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
       call      qword ptr [7FF9FB3455F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF678D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3455F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB35A940
       call      qword ptr [7FF9FB345590]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF9FB35AA58
       call      qword ptr [7FF9FB3455C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB33B290
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,1855D601640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1855D600008
       call      qword ptr [7FF9FB10F168]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB33B2C8
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,1855D609F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1855D600008
       call      qword ptr [7FF9FB10F168]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB33B508
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,1855D60FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1855D600008
       call      qword ptr [7FF9FB10F168]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB33B530
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB33B5D0
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB33B748
       call      qword ptr [7FF9FAB6F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB345728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB3456E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB3355C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF578D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3355C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB34A940
       call      qword ptr [7FF9FB335560]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF9FB34AA58
       call      qword ptr [7FF9FB335590]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB32B290
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,1D7E2F61640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1D7E2F60008
       call      qword ptr [7FF9FB0FF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B2C8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,1D7E2F69F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1D7E2F60008
       call      qword ptr [7FF9FB0FF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B508
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,1D7E2F6FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1D7E2F60008
       call      qword ptr [7FF9FB0FF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B530
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32B5D0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32B748
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3356F8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB3356B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB3256C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF478D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3256C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB33AEE8
       call      qword ptr [7FF9FB325668]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF9FB33B000
       call      qword ptr [7FF9FB325698]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB31B378
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,2F979F41640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,2F979F40008
       call      qword ptr [7FF9FB0EF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB31B3B0
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,2F979F49F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,2F979F40008
       call      qword ptr [7FF9FB0EF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB31B5F0
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,2F979F4FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2F979F40008
       call      qword ptr [7FF9FB0EF138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB31B618
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF9FB436890
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
       mov       rcx,7FF9FB436998
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
       mov       rdx,7FF9FB31B6B8
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF9FB4369A0
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
       mov       rcx,7FF9FB436AA8
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
       mov       rdx,7FF9FB31B830
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB325800]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB3257B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB335698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF578D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB335698]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB34AFC0
       call      qword ptr [7FF9FB335638]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF9FB34B0D8
       call      qword ptr [7FF9FB335668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB32B378
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,32F46B01640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,32F46B00008
       call      qword ptr [7FF9FB0FF048]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B3B0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,32F46B09F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,32F46B00008
       call      qword ptr [7FF9FB0FF048]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B5F0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,32F46B0FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,32F46B00008
       call      qword ptr [7FF9FB0FF048]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B618
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF9FB4466F0
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
       mov       rcx,7FF9FB4467F8
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
       mov       rdx,7FF9FB32B6B8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF9FB446800
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
       mov       rcx,7FF9FB446908
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
       mov       rdx,7FF9FB32B830
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3357D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB335788]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       imul      r11,r10
       shr       r11,20
       cmp       r11d,[rdx+8]
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
       nop
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
       mov       edi,[r8+8]
       cmp       edi,r10d
       ja        near ptr M00_L20
M00_L15:
       mov       rax,[rbp-0A8]
       cmp       dword ptr [rax+40],0
       jg        near ptr M00_L37
       mov       r14d,[rax+38]
       cmp       edi,r14d
       je        near ptr M00_L38
M00_L16:
       lea       r8d,[r14+1]
       mov       [rax+38],r8d
       mov       r8,[rax+10]
       mov       [rbp-0C0],r8
M00_L17:
       mov       r8,[rbp-0C0]
       cmp       r14d,[r8+8]
       jae       near ptr M00_L41
       mov       r8,[rbp-0C0]
       mov       r10d,r14d
       lea       r10,[r10+r10*2]
       lea       rdi,[r8+r10*8+10]
       mov       [rdi+10],r13d
       mov       r8d,[rsi]
       dec       r8d
       mov       [rdi+14],r8d
       mov       rdx,[rbp-0B8]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       [rsi],r14d
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
       lea       r14,[r8+r11*8+10]
       cmp       [r14+10],r13d
       je        near ptr M00_L35
M00_L21:
       mov       r10d,[r14+14]
       inc       ebx
       cmp       edi,ebx
       jb        near ptr M00_L36
       cmp       edi,r10d
       ja        short M00_L20
       jmp       near ptr M00_L15
M00_L22:
       call      qword ptr [7FF9FB0FF1F8]
       mov       ecx,16D
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB33CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB33CC90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      qword ptr [7FF9FB0FF1F8]
       mov       ecx,14D
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB33CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB33CC90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       call      qword ptr [7FF9FB0FF1F8]
       mov       ecx,65
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB33CC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB33CC90]
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
       call      qword ptr [7FF9FB33E928]
       mov       edx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,r8
       mov       r11,7FF9FAAA15A8
       call      qword ptr [r11]
       mov       ebx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L27:
       mov       rdx,[r13]
       mov       rcx,r8
       mov       r8,[rbp-90]
       mov       r11,7FF9FAAA15B0
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
       mov       r11,7FF9FAAA1598
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L40
M00_L30:
       mov       rcx,[rbp-98]
       xor       edx,edx
       call      qword ptr [7FF9FAB55A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAB5F360]
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
       call      qword ptr [7FF9FB33E928]
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L34:
       mov       rcx,rdx
       mov       rdx,[rbp-90]
       mov       r11,7FF9FAAA15B8
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
       mov       r11,7FF9FAAA15C0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C8]
       je        near ptr M00_L21
       mov       rdx,[rbp-0B8]
       mov       rcx,7FF9FB3B6718
       call      qword ptr [7FF9FAB5FD20]
       int       3
M00_L36:
       call      qword ptr [7FF9FAB5F498]
       int       3
M00_L37:
       mov       r14d,[rax+3C]
       mov       r8d,[rax+3C]
       cmp       r8d,edi
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
       call      qword ptr [7FF9FB33E730]
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
       call      qword ptr [7FF9FADE73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L18
M00_L40:
       mov       rcx,[rbp-98]
       mov       r8,[rbp-88]
       mov       rdx,[rbp-90]
       mov       r11,7FF9FAAA15A0
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
; Total bytes of code 2431
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AB25540008
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
       call      qword ptr [7FF9FB33EF58]
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
       call      qword ptr [7FF9FAB55A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB42BB48
       call      qword ptr [7FF9FAB5F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rdx,[rcx+48]
       mov       rsi,[rdx+28]
       mov       [rbp-80],rdx
       cmp       qword ptr [rbp-80],0
       je        near ptr M00_L19
       mov       rdx,[rbp-80]
       mov       [rbp-80],rdx
       test      rsi,rsi
       je        near ptr M00_L20
       test      rbx,rbx
       je        near ptr M00_L21
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M00_L22
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L02
       mov       rdi,[rbx+18]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF9FAAC13D0
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
       mov       eax,[r13+8]
       mov       [rbp-74],eax
       cmp       eax,r15d
       jbe       short M00_L02
M00_L00:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L18
M00_L01:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rbp-74]
       cmp       eax,r12d
       jb        near ptr M00_L28
       cmp       eax,r15d
       ja        short M00_L00
M00_L02:
       xor       r15d,r15d
M00_L03:
       test      r15,r15
       jne       near ptr M00_L17
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,rbx
       mov       [rbp-88],rcx
       mov       [rbp-90],rsi
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L23
M00_L04:
       mov       r8,[rcx+10]
       mov       [rbp-98],r8
       mov       rdx,[rcx+18]
       mov       [rbp-0A0],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-0A0]
       cmp       [rdx],r8
       jne       near ptr M00_L26
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       rsi,[rbp-90]
       mov       r8d,[rsi+8]
       mov       [rbp-4C],r8d
       lea       r8,[rsi+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M00_L06
M00_L05:
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
       jg        short M00_L05
M00_L06:
       cmp       dword ptr [rbp-4C],0
       jle       short M00_L07
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L24
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
M00_L07:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
M00_L08:
       mov       r15d,eax
M00_L09:
       xor       ebx,ebx
       mov       rcx,[rbp-88]
       mov       r8,[rcx+8]
       mov       r11d,r15d
       imul      r11,[rcx+30]
       shr       r11,20
       inc       r11
       mov       eax,[r8+8]
       imul      r11,rax
       shr       r11,20
       cmp       r11d,[r8+8]
       jae       near ptr M00_L33
       mov       r11d,r11d
       lea       rdi,[r8+r11*4+10]
       mov       eax,[rdi]
       dec       eax
       mov       r8,[rbp-98]
       cmp       [r8+8],eax
       ja        near ptr M00_L15
M00_L10:
       mov       rcx,[rbp-88]
       cmp       dword ptr [rcx+40],0
       jg        near ptr M00_L29
       mov       r14d,[rcx+38]
       mov       rax,[rbp-98]
       cmp       [rax+8],r14d
       je        near ptr M00_L30
M00_L11:
       lea       eax,[r14+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-98],rax
M00_L12:
       mov       rax,[rbp-98]
       cmp       r14d,[rax+8]
       jae       near ptr M00_L33
       mov       rax,[rbp-98]
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],r15d
       mov       eax,[rdi]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       [rdi],r14d
       mov       rcx,[rbp-88]
       inc       dword ptr [rcx+44]
       cmp       ebx,64
       ja        near ptr M00_L31
M00_L13:
       mov       rcx,[rbp-80]
       mov       [rbp-40],rcx
M00_L14:
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
M00_L15:
       mov       r8,[rbp-98]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r14,[r8+r11*8+10]
       cmp       [r14+10],r15d
       je        near ptr M00_L27
M00_L16:
       mov       eax,[r14+14]
       inc       ebx
       mov       r8,[rbp-98]
       cmp       [r8+8],ebx
       jb        near ptr M00_L28
       mov       r8,[rbp-98]
       cmp       [r8+8],eax
       ja        short M00_L15
       jmp       near ptr M00_L10
M00_L17:
       mov       r8,[r15]
       mov       [rbp-40],r8
       jmp       near ptr M00_L14
M00_L18:
       mov       rdx,[r15]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FF9FAAC13D8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       add       r15,8
       jmp       near ptr M00_L03
M00_L19:
       call      qword ptr [7FF9FB11F240]
       mov       ecx,16D
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE45AC0
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB35D098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB35D0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FF9FB11F240]
       mov       ecx,14D
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE45AC0
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB35D098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB35D0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FF9FB11F240]
       mov       ecx,65
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE45AC0
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB35D098]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB35D0B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FF9FAAC13C0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L14
       jmp       near ptr M00_L32
M00_L23:
       xor       edx,edx
       call      qword ptr [7FF9FAB75A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-88]
       jmp       near ptr M00_L04
M00_L24:
       call      M00_L34
       nop
       mov       rsi,[rbp-90]
       mov       r8d,[rsi+8]
       sub       r8d,[rbp-4C]
       cmp       [rsi+8],r8d
       jae       short M00_L25
       mov       ecx,21
       call      qword ptr [7FF9FAB7F360]
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
       call      qword ptr [7FF9FB35F270]
       mov       rdx,[rbp-0A0]
       jmp       near ptr M00_L08
M00_L26:
       mov       rsi,[rbp-90]
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF9FAAC13E0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rbp-0A0]
       jmp       near ptr M00_L09
M00_L27:
       mov       r8,[rbp-98]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-0A0]
       mov       r8,rsi
       mov       r11,7FF9FAAC13E8
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0A0]
       je        near ptr M00_L16
       mov       rdx,rsi
       mov       rcx,7FF9FB3A9298
       call      qword ptr [7FF9FAB7FD20]
       int       3
M00_L28:
       call      qword ptr [7FF9FAB7F498]
       int       3
M00_L29:
       mov       r14d,[rcx+3C]
       mov       eax,[rcx+3C]
       mov       r8,[rbp-98]
       cmp       eax,[r8+8]
       jae       near ptr M00_L33
       mov       r8,[rbp-98]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M00_L12
M00_L30:
       call      qword ptr [7FF9FB35E718]
       mov       rcx,[rbp-88]
       mov       rdx,[rcx+8]
       mov       eax,r15d
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       imul      rax,r8
       shr       rax,20
       cmp       eax,[rdx+8]
       jae       short M00_L33
       mov       eax,eax
       lea       rdi,[rdx+rax*4+10]
       mov       rdx,[rbp-0A0]
       jmp       near ptr M00_L11
M00_L31:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rdx,[rbp-98]
       mov       edx,[rdx+8]
       mov       rcx,[rbp-88]
       mov       r8d,1
       call      qword ptr [7FF9FAE073F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L13
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-80]
       mov       rdx,rsi
       mov       r11,7FF9FAAC13C8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1972
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AFF6700008
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
       call      qword ptr [7FF9FB35EEB0]
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
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB3C3D28
       call      qword ptr [7FF9FAB7F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rdx,[rcx+48]
       mov       rsi,[rdx+28]
       mov       [rbp-80],rdx
       cmp       qword ptr [rbp-80],0
       je        near ptr M00_L19
       mov       rdx,[rbp-80]
       mov       [rbp-80],rdx
       test      rsi,rsi
       je        near ptr M00_L20
       test      rbx,rbx
       je        near ptr M00_L21
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M00_L22
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L02
       mov       rdi,[rbx+18]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF9FAA914F0
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
       mov       eax,[r13+8]
       mov       [rbp-74],eax
       cmp       eax,r15d
       jbe       short M00_L02
M00_L00:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L18
M00_L01:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rbp-74]
       cmp       eax,r12d
       jb        near ptr M00_L28
       cmp       eax,r15d
       ja        short M00_L00
M00_L02:
       xor       r15d,r15d
M00_L03:
       test      r15,r15
       jne       near ptr M00_L17
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-88],rbx
       mov       [rbp-90],rsi
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L23
M00_L04:
       mov       r8,[rbx+10]
       mov       [rbp-98],r8
       mov       rdx,[rbx+18]
       mov       [rbp-0A0],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-0A0]
       cmp       [rdx],r8
       jne       near ptr M00_L26
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       rsi,[rbp-90]
       mov       r8d,[rsi+8]
       mov       [rbp-4C],r8d
       lea       r8,[rsi+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M00_L06
       xchg      ax,ax
M00_L05:
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
       jg        short M00_L05
M00_L06:
       cmp       dword ptr [rbp-4C],0
       jle       short M00_L07
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L24
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
M00_L07:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
M00_L08:
       mov       r15d,eax
M00_L09:
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
       mov       r8,[rbp-98]
       cmp       [r8+8],eax
       ja        near ptr M00_L15
M00_L10:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L29
       mov       r13d,[rbx+38]
       mov       rax,[rbp-98]
       cmp       [rax+8],r13d
       je        near ptr M00_L30
M00_L11:
       lea       eax,[r13+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-98],rax
M00_L12:
       mov       rax,[rbp-98]
       cmp       r13d,[rax+8]
       jae       near ptr M00_L33
       mov       rax,[rbp-98]
       mov       r8d,r13d
       lea       r8,[r8+r8*2]
       lea       r12,[rax+r8*8+10]
       mov       [r12+10],r15d
       mov       eax,[r14]
       dec       eax
       mov       [r12+14],eax
       mov       rcx,r12
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       [r14],r13d
       inc       dword ptr [rbx+44]
       cmp       edi,64
       ja        near ptr M00_L31
M00_L13:
       mov       rcx,[rbp-80]
       mov       [rbp-40],rcx
M00_L14:
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
M00_L15:
       mov       r8,[rbp-98]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r13,[r8+r11*8+10]
       cmp       [r13+10],r15d
       je        near ptr M00_L27
M00_L16:
       mov       eax,[r13+14]
       inc       edi
       mov       r8,[rbp-98]
       cmp       [r8+8],edi
       jb        near ptr M00_L28
       mov       r8,[rbp-98]
       cmp       [r8+8],eax
       ja        short M00_L15
       jmp       near ptr M00_L10
M00_L17:
       mov       r8,[r15]
       mov       [rbp-40],r8
       jmp       near ptr M00_L14
M00_L18:
       mov       rdx,[r15]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FF9FAA914F8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       add       r15,8
       jmp       near ptr M00_L03
M00_L19:
       call      qword ptr [7FF9FB0EF1E0]
       mov       ecx,16D
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE15AC0
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB22D500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB22D518]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FF9FB0EF1E0]
       mov       ecx,14D
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE15AC0
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB22D500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB22D518]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FF9FB0EF1E0]
       mov       ecx,65
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE15AC0
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF4C720
       call      qword ptr [7FF9FAB4F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB22D500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB22D518]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FF9FAA914E0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L14
       jmp       near ptr M00_L32
M00_L23:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9FAB45A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L04
M00_L24:
       call      M00_L34
       nop
       mov       rsi,[rbp-90]
       mov       r8d,[rsi+8]
       sub       r8d,[rbp-4C]
       cmp       [rsi+8],r8d
       jae       short M00_L25
       mov       ecx,21
       call      qword ptr [7FF9FAB4F360]
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
       call      qword ptr [7FF9FB3E40A8]
       mov       rdx,[rbp-0A0]
       mov       rbx,[rbp-88]
       jmp       near ptr M00_L08
M00_L26:
       mov       rsi,[rbp-90]
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF9FAA91500
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rbp-0A0]
       jmp       near ptr M00_L09
M00_L27:
       mov       r8,[rbp-98]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-0A0]
       mov       r8,rsi
       mov       r11,7FF9FAA91508
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0A0]
       je        near ptr M00_L16
       mov       rdx,rsi
       mov       rcx,7FF9FB37E6A8
       call      qword ptr [7FF9FAB4FD20]
       int       3
M00_L28:
       call      qword ptr [7FF9FAB4F498]
       int       3
M00_L29:
       mov       r13d,[rbx+3C]
       mov       eax,[rbx+3C]
       mov       r8,[rbp-98]
       cmp       eax,[r8+8]
       jae       near ptr M00_L33
       mov       r8,[rbp-98]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+3C],eax
       dec       dword ptr [rbx+40]
       jmp       near ptr M00_L12
M00_L30:
       mov       rcx,rbx
       call      qword ptr [7FF9FB32EE08]
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L33
       mov       edx,edx
       lea       r14,[rcx+rdx*4+10]
       mov       rdx,[rbp-0A0]
       jmp       near ptr M00_L11
M00_L31:
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rdx,[rbp-98]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9FADD73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L13
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-80]
       mov       rdx,rsi
       mov       r11,7FF9FAA914E8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1949
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1A283120008
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
       call      qword ptr [7FF9FB32F6A8]
       int       3
; Total bytes of code 231
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
       call      qword ptr [7FF9FAB45A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB3A6658
       call      qword ptr [7FF9FAB4F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       cmp       [rdx],rcx
       je        short M03_L02
       mov       rax,[rdx]
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       je        near ptr M00_L02
       mov       rdi,[rbx+18]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF9FAAA16B8
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
       jbe       short M00_L02
M00_L00:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L18
M00_L01:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jb        near ptr M00_L28
       cmp       [r13+8],r15d
       ja        short M00_L00
M00_L02:
       xor       r15d,r15d
M00_L03:
       test      r15,r15
       jne       near ptr M00_L17
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-80],rbx
       mov       [rbp-88],rsi
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L23
M00_L04:
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
       jle       short M00_L06
       nop       dword ptr [rax]
M00_L05:
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
       jg        short M00_L05
M00_L06:
       cmp       dword ptr [rbp-4C],0
       jle       short M00_L07
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M00_L24
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
M00_L07:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
M00_L08:
       mov       r15d,eax
M00_L09:
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
       ja        near ptr M00_L15
M00_L10:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L29
       mov       r12d,[rbx+38]
       cmp       r13d,r12d
       je        near ptr M00_L30
M00_L11:
       lea       eax,[r12+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-90],rax
M00_L12:
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
M00_L13:
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
M00_L14:
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
M00_L15:
       mov       r8,[rbp-90]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r12,[r8+r11*8+10]
       cmp       [r12+10],r15d
       je        near ptr M00_L27
M00_L16:
       mov       eax,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M00_L28
       cmp       r13d,eax
       ja        short M00_L15
       jmp       near ptr M00_L10
M00_L17:
       mov       r8,[r15]
       mov       [rbp-40],r8
       jmp       short M00_L14
M00_L18:
       mov       rdx,[r15]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FF9FAAA16C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       add       r15,8
       jmp       near ptr M00_L03
M00_L19:
       call      qword ptr [7FF9FB0FF240]
       mov       ecx,16D
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB234FD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB234FF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FF9FB0FF240]
       mov       ecx,14D
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB234FD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB234FF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FF9FB0FF240]
       mov       ecx,65
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB234FD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB234FF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FF9FAAA16A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L14
       jmp       near ptr M00_L32
M00_L23:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9FAB55A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L04
M00_L24:
       call      M00_L34
       nop
       mov       rsi,[rbp-88]
       mov       r8d,[rsi+8]
       sub       r8d,[rbp-4C]
       cmp       [rsi+8],r8d
       jae       short M00_L25
       mov       ecx,21
       call      qword ptr [7FF9FAB5F360]
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
       call      qword ptr [7FF9FB484378]
       mov       rdx,[rbp-98]
       mov       rbx,[rbp-80]
       jmp       near ptr M00_L08
M00_L26:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF9FAAA16C8
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rdx,[rbp-98]
       jmp       near ptr M00_L09
M00_L27:
       mov       r8,[rbp-90]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-98]
       mov       r8,rsi
       mov       r11,7FF9FAAA16D0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-98]
       je        near ptr M00_L16
       mov       rdx,rsi
       mov       rcx,7FF9FB3D3DC0
       call      qword ptr [7FF9FAB5FD20]
       int       3
M00_L28:
       call      qword ptr [7FF9FAB5F498]
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
       jmp       near ptr M00_L12
M00_L30:
       mov       rcx,rbx
       call      qword ptr [7FF9FB23F840]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
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
       jmp       near ptr M00_L11
M00_L31:
       mov       rdx,[rbp-98]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L13
       mov       rdx,[rbp-90]
       mov       edx,[rdx+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9FADE73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L13
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-78]
       mov       rdx,rsi
       mov       r11,7FF9FAAA16B0
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1892
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24933B70008
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
       call      qword ptr [7FF9FB37EC28]
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
       call      qword ptr [7FF9FAB55A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB32B4D0
       call      qword ptr [7FF9FAB5F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B33ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       call      qword ptr [7FF9FB3556E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF778D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3556E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB36AFC0
       call      qword ptr [7FF9FB355680]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF9FB36B0D8
       call      qword ptr [7FF9FB3556B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB34B378
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,233E04A9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,233E04A0008
       call      qword ptr [7FF9FB11F150]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB34B5B8
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,233E04AFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,233E04A0008
       call      qword ptr [7FF9FB11F150]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB34B5E0
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB34B730
       call      qword ptr [7FF9FAB7F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3557B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB355770]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB335650]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF578D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB335650]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB34A940
       call      qword ptr [7FF9FB3355F0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF9FB34AA58
       call      qword ptr [7FF9FB335620]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF9FB32B290
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,1DCB26F9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1DCB26F0008
       call      qword ptr [7FF9FB0FF198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B4D0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,1DCB26FFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1DCB26F0008
       call      qword ptr [7FF9FB0FF198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B4F8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9FB32B648
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB335728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB3356E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB325728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF478D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB325728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB33AEE8
       call      qword ptr [7FF9FB3256C8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF9FB33B000
       call      qword ptr [7FF9FB3256F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rcx,7FF9FB435D78
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FF9FB435D7C
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
       mov       rdx,7FF9FB31B378
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,238FB899F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,238FB890008
       call      qword ptr [7FF9FB0EF198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB31B5B8
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,238FB89FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,238FB890008
       call      qword ptr [7FF9FB0EF198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB31B5E0
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FF9FB435D80
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
       mov       rdx,7FF9FB31B730
       call      qword ptr [7FF9FAB4F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB325800]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB3257B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB3356E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9FAF578D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3356E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF9FB34AEE8
       call      qword ptr [7FF9FB335680]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF9FB34B000
       call      qword ptr [7FF9FB3356B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 149
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rax,[rcx+48]
       ret
; Total bytes of code 5
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
       mov       rcx,7FF9FB445DC0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FF9FB445DC4
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
       mov       rdx,7FF9FB32B378
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,18414119F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,18414110008
       call      qword ptr [7FF9FB0FF150]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B5B8
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,1841411FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,18414110008
       call      qword ptr [7FF9FB0FF150]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF9FB32B5E0
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FF9FB445DC8
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
       mov       rdx,7FF9FB32B730
       call      qword ptr [7FF9FAB5F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9FB3357B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9FB335770]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9FB0FF240]
       mov       ecx,14D
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB33CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB33CC00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF9FB0FF240]
       mov       ecx,65
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE25AC0
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF5C720
       call      qword ptr [7FF9FAB5F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB33CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB33CC00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9FAB55A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAB5F360]
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
       call      qword ptr [7FF9FB33F318]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF9FAAA1568
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
       mov       r11,7FF9FAAA1570
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
       call      qword ptr [7FF9FAB5F498]
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
       call      qword ptr [7FF9FB33E7A8]
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
       call      qword ptr [7FF9FADE73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF9FAAA1560
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C7CBE00008
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
       call      qword ptr [7FF9FB33EF58]
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
       call      qword ptr [7FF9FAB55A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB3A3FA8
       call      qword ptr [7FF9FAB5F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       call      qword ptr [7FF9FB10F240]
       mov       ecx,14D
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE35AC0
       call      qword ptr [7FF9FAB6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB34D038]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB34D050]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF9FB10F240]
       mov       ecx,65
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE35AC0
       call      qword ptr [7FF9FAB6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF6C720
       call      qword ptr [7FF9FAB6F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB34D038]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB34D050]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9FAB65A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAB6F360]
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
       call      qword ptr [7FF9FB34F1F8]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF9FAAB1398
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
       mov       r11,7FF9FAAB13A0
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
       call      qword ptr [7FF9FAB6F498]
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
       call      qword ptr [7FF9FB34E730]
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
       call      qword ptr [7FF9FADF73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF9FAAB1390
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D141180008
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
       call      qword ptr [7FF9FB34EEC8]
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
       call      qword ptr [7FF9FAB65A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB3B3C48
       call      qword ptr [7FF9FAB6F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
       int       3
; Total bytes of code 517
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsMutatingCollectionBenchmark.Upsert()
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
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rsi,rcx
       mov       rdi,[rbx+48]
       mov       rbp,[rdi+28]
       test      rdi,rdi
       je        near ptr M00_L09
       test      rbp,rbp
       je        near ptr M00_L10
       test      rsi,rsi
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L12
       cmp       qword ptr [rsi+8],0
       jne       short M00_L00
       xor       ecx,ecx
       call      qword ptr [7FF9FAB75A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+30],rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       rcx,r15
       mov       rdx,rbp
       mov       r11,7FF9FAAC1488
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
       jae       near ptr M00_L13
       mov       ecx,ecx
       lea       rax,[rdx+rcx*4+10]
       mov       [rsp+38],rax
       mov       r10d,[rax]
       dec       r10d
       mov       r9d,[r14+8]
       mov       [rsp+44],r9d
       cmp       r9d,r10d
       jbe       short M00_L03
M00_L01:
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[r14+rdx*8+10]
       mov       [rsp+28],r11
       cmp       [r11+10],r13d
       jne       short M00_L02
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,r15
       mov       r8,rbp
       mov       r11,7FF9FAAC1490
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L08
M00_L02:
       mov       r11,[rsp+28]
       mov       r10d,[r11+14]
       inc       r12d
       mov       r9d,[rsp+44]
       cmp       r9d,r12d
       jb        near ptr M00_L07
       cmp       r9d,r10d
       ja        short M00_L01
M00_L03:
       cmp       dword ptr [rsi+40],0
       jg        short M00_L05
       mov       r14d,[rsi+38]
       cmp       [rsp+44],r14d
       jne       short M00_L04
       mov       ecx,[rsi+38]
       call      qword ptr [7FF9FAB7F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF9FAE073F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       jae       near ptr M00_L13
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+38],rax
M00_L04:
       lea       ecx,[r14+1]
       mov       [rsi+38],ecx
       mov       rcx,[rsi+10]
       mov       r8,rcx
       mov       rax,r8
       mov       r8d,r14d
       mov       r14,rax
       jmp       short M00_L06
M00_L05:
       mov       ecx,[rsi+3C]
       mov       r8d,ecx
       cmp       ecx,[rsp+44]
       jae       near ptr M00_L13
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+3C],ecx
       dec       dword ptr [rsi+40]
M00_L06:
       cmp       r8d,[r14+8]
       jae       near ptr M00_L13
       mov       [rsp+54],r8d
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r10,[r14+rcx*8+10]
       mov       [rsp+30],r10
       mov       [r10+10],r13d
       mov       rax,[rsp+38]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+30]
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rsp+54]
       inc       edi
       mov       rbp,[rsp+38]
       mov       [rbp],edi
       inc       dword ptr [rsi+44]
       cmp       r12d,64
       jbe       short M00_L09
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L09
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF9FAE073F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       short M00_L09
M00_L07:
       call      qword ptr [7FF9FAB7F498]
       int       3
M00_L08:
       mov       r11,[rsp+28]
       lea       rcx,[r11+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rcx,[rbx+278]
       mov       [rsp+48],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+48]
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
M00_L10:
       call      qword ptr [7FF9FB117450]
       mov       ecx,14D
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE45AC0
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB32E358]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB32E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FF9FB117450]
       mov       ecx,65
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE45AC0
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF7C720
       call      qword ptr [7FF9FAB7F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB32E358]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB32E370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       rcx,rsi
       mov       r8,rdi
       mov       rdx,rbp
       mov       r11,7FF9FAAC1480
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1108
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M01_L02
       mov       rcx,7FFA4FEB0B08
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
       call      qword ptr [7FF9FB32EE80]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAEE5EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M01_L06
M01_L04:
       mov       ecx,esi
       call      qword ptr [7FF9FB32C648]
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M03_L06
M03_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FA73BE0008
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
       call      qword ptr [7FF9FB32E478]
       int       3
; Total bytes of code 235
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
       call      qword ptr [7FF9FB0D7450]
       mov       ecx,14D
       mov       rdx,7FF9FAF3C720
       call      qword ptr [7FF9FAB3F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE05AC0
       call      qword ptr [7FF9FAB3F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF3C720
       call      qword ptr [7FF9FAB3F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB20E208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB20E220]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF9FB0D7450]
       mov       ecx,65
       mov       rdx,7FF9FAF3C720
       call      qword ptr [7FF9FAB3F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9FAE05AC0
       call      qword ptr [7FF9FAB3F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9FAF3C720
       call      qword ptr [7FF9FAB3F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9FAB3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9FB20E208]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9FB20E220]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9FAB35A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9FAB3F360]
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
       call      qword ptr [7FF9FB34F9C0]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF9FAA81680
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
       mov       r11,7FF9FAA81688
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
       call      qword ptr [7FF9FAB3F498]
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
       call      qword ptr [7FF9FB344228]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF9FADC73F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF9FAA81678
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
       call      00007FFA5A7E9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9FAB35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9FAB35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29DB8EC0008
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
       call      qword ptr [7FF9FB34F120]
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
       call      qword ptr [7FF9FAB35A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF9FB350768
       call      qword ptr [7FF9FAB3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA50B33ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
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
       call      qword ptr [7FFA50B17E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFA50B14088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFA50B252F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFA50B21B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B170B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA50B23730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA50B14090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFA50B13FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFA50B19060]
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
       call      qword ptr [7FFA50B13FD8]
       int       3
; Total bytes of code 517
```

