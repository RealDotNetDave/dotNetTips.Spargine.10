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
       mov       rcx,7FF910CA3EC0
       mov       r9d,1
       call      qword ptr [7FF910C859B0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF910C859E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
; 			if (collection is T[])
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentReadOnlyException(Resources.ArraysAreFixedSize, nameof(collection));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
; 				AddAllItems(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			return AddUniqueItems(collection, items, comparer ?? EqualityComparer<T>.Default);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF910EB7F98
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,90
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,228F27AFD28
       call      qword ptr [7FF9108D7600]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L01
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C999E8
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M01_L03
       mov       rcx,7FF910EB7F9C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF910C85B48]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,228F27AFD28
       call      qword ptr [7FF910C85B60]
M01_L03:
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,7FF910EB7FA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M01_L04
       mov       rax,[rbp-58]
       mov       [rbp-40],rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C99F00
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M01_L05:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF910C85B00]
       mov       eax,1
       add       rsp,90
       pop       rbp
       ret
M01_L06:
       mov       rax,[rbp+18]
       mov       [rbp-18],rax
       mov       rax,[rbp+20]
       mov       [rbp-20],rax
       mov       rax,[rbp+30]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp+30],0
       jne       short M01_L09
       mov       rcx,7FF910EB7FA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L07
       mov       rax,[rbp-60]
       mov       [rbp-38],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C99E60
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FF910C85B78]; System.Collections.Generic.EqualityComparer`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Default()
       mov       [rbp-28],rax
M01_L09:
       mov       rcx,7FF910EB7FA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-68],rax
       cmp       qword ptr [rbp-68],0
       je        short M01_L10
       mov       rax,[rbp-68]
       mov       [rbp-30],rax
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C99C28
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M01_L11:
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-20]
       mov       r9,[rbp-28]
       call      qword ptr [7FF910C85AB8]; DotNetTips.Spargine.Extensions.CollectionExtensions.<AddRange>g__AddUniqueItems|4_1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 562
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
       call      qword ptr [7FF910C86010]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF910C85FE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,7FF910CCA658
       mov       r9d,1
       call      qword ptr [7FF910CB54B8]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF910CB54E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
; 			if (collection is T[])
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentReadOnlyException(Resources.ArraysAreFixedSize, nameof(collection));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
; 				AddAllItems(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			return AddUniqueItems(collection, items, comparer ?? EqualityComparer<T>.Default);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF910E21DA0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,90
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,1B66367FD28
       call      qword ptr [7FF9108E6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L01
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAA9E8
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9104D58F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M01_L03
       mov       rcx,7FF910E21DA4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF910CB5650]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,1B66367FD28
       call      qword ptr [7FF910CB5668]
M01_L03:
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,7FF910E21DA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M01_L04
       mov       rax,[rbp-58]
       mov       [rbp-40],rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAAF00
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M01_L05:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF910CB5608]
       mov       eax,1
       add       rsp,90
       pop       rbp
       ret
M01_L06:
       mov       rax,[rbp+18]
       mov       [rbp-18],rax
       mov       rax,[rbp+20]
       mov       [rbp-20],rax
       mov       rax,[rbp+30]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp+30],0
       jne       short M01_L09
       mov       rcx,7FF910E21DAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L07
       mov       rax,[rbp-60]
       mov       [rbp-38],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAAE60
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FF910CB5680]; System.Collections.Generic.EqualityComparer`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Default()
       mov       [rbp-28],rax
M01_L09:
       mov       rcx,7FF910E21DB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-68],rax
       cmp       qword ptr [rbp-68],0
       je        short M01_L10
       mov       rax,[rbp-68]
       mov       [rbp-30],rax
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAAC28
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M01_L11:
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-20]
       mov       r9,[rbp-28]
       call      qword ptr [7FF910CB55C0]; DotNetTips.Spargine.Extensions.CollectionExtensions.<AddRange>g__AddUniqueItems|4_1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 563
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
       call      qword ptr [7FF910CB5B18]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CB5AE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,7FF910C9A658
       mov       r9d,1
       call      qword ptr [7FF910C84F90]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FF910C84FC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
; 			if (collection is T[])
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentReadOnlyException(Resources.ArraysAreFixedSize, nameof(collection));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (!ensureUnique)
; 			^^^^^^^^^^^^^^^^^^
; 				AddAllItems(collection, items);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			return AddUniqueItems(collection, items, comparer ?? EqualityComparer<T>.Default);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       qword ptr [rbp+20],0
       jne       short M01_L00
       mov       rcx,7FF910DACC18
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,90
       pop       rbp
       ret
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,22C2EE8FD28
       call      qword ptr [7FF9108C6820]; System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L01
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C78520
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L02:
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M01_L03
       mov       rcx,7FF910DACC1C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF910C85128]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,22C2EE8FD28
       call      qword ptr [7FF910C85140]
M01_L03:
       movzx     eax,byte ptr [rbp+28]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,7FF910DACC20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M01_L04
       mov       rax,[rbp-58]
       mov       [rbp-40],rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C78A38
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M01_L05:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF910C850E0]
       mov       eax,1
       add       rsp,90
       pop       rbp
       ret
M01_L06:
       mov       rax,[rbp+18]
       mov       [rbp-18],rax
       mov       rax,[rbp+20]
       mov       [rbp-20],rax
       mov       rax,[rbp+30]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp+30],0
       jne       short M01_L09
       mov       rcx,7FF910DACC24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-60],rax
       cmp       qword ptr [rbp-60],0
       je        short M01_L07
       mov       rax,[rbp-60]
       mov       [rbp-38],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C78998
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FF910C85158]; System.Collections.Generic.EqualityComparer`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Default()
       mov       [rbp-28],rax
M01_L09:
       mov       rcx,7FF910DACC28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-68],rax
       cmp       qword ptr [rbp-68],0
       je        short M01_L10
       mov       rax,[rbp-68]
       mov       [rbp-30],rax
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C78760
       call      qword ptr [7FF9104BF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M01_L11:
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-18]
       mov       r8,[rbp-20]
       mov       r9,[rbp-28]
       call      qword ptr [7FF910C85098]; DotNetTips.Spargine.Extensions.CollectionExtensions.<AddRange>g__AddUniqueItems|4_1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 562
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
       call      qword ptr [7FF910C855F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF910C855C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,178
       lea       rbp,[rsp+1B0]
       xor       eax,eax
       mov       [rbp-0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       [rbp+10],rbx
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L68
       test      r14,r14
       je        near ptr M00_L69
       mov       rcx,r14
       mov       rax,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rcx],rax
       je        short M00_L00
       xor       ecx,ecx
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L70
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L72
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L73
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-110],rax
       mov       dword ptr [r12+2C],0FFFFFFFF
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L75
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L74
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       [rbp-80],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-80]
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
       mov       [rbp-118],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-118]
       cmp       [rax],rcx
       jne       near ptr M00_L48
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L50
       mov       ecx,[rsi+0C]
       cmp       ecx,[rdx+38]
       jae       near ptr M00_L27
M00_L07:
       mov       rcx,[rsi]
       mov       rcx,[rcx+10]
       mov       edx,[rsi+0C]
       lea       r8d,[rdx+1]
       mov       [rsi+0C],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M00_L51
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L47
       mov       rdx,[rcx]
       mov       rdi,[rcx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       vmovdqu   xmm0,xmmword ptr [rax+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L08:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L29
M00_L09:
       mov       rdx,[r12+10]
       mov       [rbp-120],rdx
       mov       r8,[r12+18]
       mov       [rbp-128],r8
       xor       r10d,r10d
       mov       [rbp-84],r10d
       test      r8,r8
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-148]
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
       mov       rcx,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M00_L51
       mov       edx,edx
       lea       rdx,[rcx+rdx*4+10]
       mov       [rbp-130],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L13
M00_L10:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L26
       mov       r8d,[r12+28]
       mov       [rbp-8C],r8d
       mov       r11,[rbp-120]
       cmp       [r11+8],r8d
       je        near ptr M00_L15
M00_L11:
       mov       r8d,[rbp-8C]
       lea       ecx,[r8+1]
       mov       [r12+28],ecx
       mov       r11,[r12+10]
       mov       rcx,r11
M00_L12:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L51
       mov       [rbp-90],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-140],r10
       mov       [r10],eax
       mov       rdx,[rbp-130]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-140]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-90]
       inc       esi
       mov       rdi,[rbp-130]
       mov       [rdi],esi
       inc       dword ptr [r12+34]
       jmp       near ptr M00_L06
M00_L13:
       mov       r10,[rbp-120]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L51
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-120],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-150],r8
       mov       [rbp-88],eax
       cmp       [r8],eax
       je        near ptr M00_L30
M00_L14:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r10,[rbp-120]
       mov       [rbp-84],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L49
       test      r8d,r8d
       mov       eax,[rbp-88]
       jge       short M00_L13
       jmp       near ptr M00_L10
M00_L15:
       mov       ecx,[r12+28]
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        near ptr M00_L34
       mov       [rbp-88],eax
M00_L16:
       mov       ecx,edx
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M00_L17:
       mov       [rbp-94],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-168],rax
       mov       r10d,[r12+28]
       mov       [rbp-98],r10d
       mov       rcx,[r12+10]
       mov       rdx,rcx
       mov       [rbp-170],rdx
       test      rdx,rdx
       je        near ptr M00_L43
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L40
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L39
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L38
       cmp       r10d,[rax+8]
       ja        near ptr M00_L37
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L42
       mov       rax,[rbp-168]
       cmp       r8,4000
       ja        near ptr M00_L41
       mov       rcx,r9
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
       jne       near ptr M00_L36
M00_L18:
       movsxd    rdx,dword ptr [rbp-94]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-94]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
       xor       ecx,ecx
       mov       edx,[rbp-98]
       test      edx,edx
       jle       near ptr M00_L46
       mov       r8,[rbp-168]
       mov       eax,[r8+8]
       mov       [rbp-0FC],eax
       cmp       eax,edx
       jl        near ptr M00_L25
       jmp       short M00_L21
M00_L19:
       mov       r10d,[rax]
       mov       r9,[r12+8]
       mov       r11d,r10d
       imul      r11,[r12+20]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebx,r10d
       imul      r11,rbx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L51
       mov       r11d,r11d
       lea       r10,[r9+r11*4+10]
       mov       r9d,[r10]
       dec       r9d
       mov       [rax+4],r9d
       lea       eax,[rcx+1]
       mov       [r10],eax
M00_L20:
       inc       ecx
       cmp       ecx,edx
       jge       short M00_L22
M00_L21:
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       lea       rax,[r8+rax*8+10]
       cmp       dword ptr [rax+4],0FFFFFFFF
       jl        short M00_L20
       jmp       short M00_L19
M00_L22:
       lea       rcx,[r12+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+8]
       mov       edx,[rbp-88]
       mov       eax,edx
       imul      rax,[r12+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M00_L51
       mov       eax,eax
       lea       rcx,[rcx+rax*4+10]
       mov       rax,rcx
       mov       [rbp-130],rax
       mov       eax,edx
       jmp       near ptr M00_L11
M00_L23:
       mov       r9d,[r10]
       mov       r11,[r12+8]
       imul      r9,[r12+20]
       shr       r9,20
       inc       r9
       mov       eax,[r11+8]
       imul      rax,r9
       shr       rax,20
       cmp       eax,[r11+8]
       jae       near ptr M00_L51
       mov       eax,eax
       lea       rax,[r11+rax*4+10]
       mov       r9d,[rax]
       dec       r9d
       mov       [r10+4],r9d
       lea       r10d,[rcx+1]
       mov       [rax],r10d
M00_L24:
       inc       ecx
       cmp       ecx,edx
       mov       eax,[rbp-0FC]
       jge       near ptr M00_L22
M00_L25:
       cmp       ecx,eax
       jae       near ptr M00_L51
       mov       r10d,ecx
       lea       r10,[r10+r10*2]
       lea       r10,[r8+r10*8+10]
       cmp       dword ptr [r10+4],0FFFFFFFF
       jl        short M00_L24
       jmp       short M00_L23
M00_L26:
       mov       ecx,[r12+2C]
       mov       r8d,ecx
       dec       dword ptr [r12+30]
       mov       r11,[rbp-120]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L51
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L12
M00_L27:
       mov       rcx,[rsi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rsi+0C],ecx
       xor       ecx,ecx
       mov       [rsi+18],rcx
       mov       [rsi+20],rcx
       jmp       near ptr M00_L52
M00_L28:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-118]
       mov       r11,7FF9104117B8
       call      qword ptr [r11]
       mov       rax,[rbp-118]
       jmp       near ptr M00_L08
M00_L29:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CA59B0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-118]
       jmp       near ptr M00_L09
M00_L30:
       mov       r9,[r8+8]
       mov       [rbp-178],r9
       mov       r11,[r8+10]
       mov       [rbp-180],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-158],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-158]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-158]
       call      qword ptr [7FF9104049D0]
       test      eax,eax
       mov       r8,[rbp-150]
       je        near ptr M00_L14
       jmp       near ptr M00_L06
M00_L31:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0E8],xmm0
       lea       rdx,[rbp-0E8]
       mov       rcx,r8
       mov       r11,7FF9104117C8
       call      qword ptr [r11]
       mov       r8,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L51
       mov       edx,edx
       lea       rdx,[r8+rdx*4+10]
       mov       r10,rdx
       mov       [rbp-130],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L10
M00_L32:
       mov       r11,[rbp-120]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L51
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-120],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-138],r9
       mov       [rbp-88],eax
       cmp       [r9],eax
       jne       short M00_L33
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-0E8],xmm0
       mov       [rbp-0F8],rsi
       mov       [rbp-0F0],rdi
       lea       r8,[rbp-0F8]
       lea       rdx,[rbp-0E8]
       mov       rcx,[rbp-128]
       mov       r11,7FF9104117D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-138]
       jne       near ptr M00_L06
M00_L33:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r11,[rbp-120]
       cmp       [r11+8],ecx
       jb        near ptr M00_L49
       test      r9d,r9d
       mov       [rbp-120],r11
       mov       [rbp-84],ecx
       mov       eax,[rbp-88]
       jge       near ptr M00_L32
       jmp       near ptr M00_L10
M00_L34:
       cmp       ecx,7FFFFFC3
       jge       short M00_L35
       mov       r10d,7FFFFFC3
       mov       [rbp-88],eax
       mov       eax,r10d
       jmp       near ptr M00_L17
M00_L35:
       mov       [rbp-88],eax
       jmp       near ptr M00_L16
M00_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L18
M00_L37:
       jmp       short M00_L44
M00_L38:
       jmp       short M00_L44
M00_L39:
       jmp       short M00_L44
M00_L40:
       jmp       short M00_L44
M00_L41:
       mov       rcx,r9
       call      qword ptr [7FF910A6EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L18
M00_L42:
       mov       rcx,r9
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L18
M00_L43:
       xor       ecx,ecx
       mov       [rbp-9C],ecx
       jmp       short M00_L45
M00_L44:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF910CACBB8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-9C],eax
       mov       rax,[rbp-168]
M00_L45:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF910CACBB8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-98]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-170]
       mov       edx,[rbp-9C]
       mov       r8,[rbp-168]
       call      qword ptr [7FF910CACBD0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L18
M00_L46:
       mov       r8,[rbp-168]
       jmp       near ptr M00_L22
M00_L47:
       mov       ecx,[rsi+0C]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+38]
       jb        near ptr M00_L07
       jmp       near ptr M00_L27
M00_L48:
       mov       rcx,rax
       mov       r11,7FF9104117B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L28
       jmp       short M00_L52
M00_L49:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L50:
       call      qword ptr [7FF9104CFC60]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-118]
       cmp       [rax],rcx
       jne       near ptr M00_L76
M00_L53:
       mov       ecx,[r12+28]
       test      ecx,ecx
       jle       short M00_L54
       mov       rax,[r12+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L77
M00_L54:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L79
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        near ptr M00_L78
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
M00_L55:
       mov       rcx,rdx
M00_L56:
       mov       [rbp-108],rcx
       cmp       qword ptr [rbp-108],0
       je        near ptr M00_L61
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-108]
       cmp       [rcx],rdx
       jne       near ptr M00_L61
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L61
M00_L57:
       mov       rcx,[rbp-108]
       mov       rdx,[rcx]
       add       rcx,8
       cmp       [rcx],ecx
       call      qword ptr [7FF91083C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L66
       mov       rcx,[rbp-108]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0E8],xmm0
       lea       rdx,[rbp-0E8]
       lea       r8,[rbp-0D0]
       mov       rcx,r12
       call      qword ptr [7FF910CA5A88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M00_L57
       mov       rcx,r14
       mov       rdx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r9d,2
       call      qword ptr [7FF9104C66A0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       r13d,1
       jmp       short M00_L57
M00_L58:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-108]
       cmp       [rcx],rdx
       jne       near ptr M00_L64
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M00_L59:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0E8],xmm0
       lea       rdx,[rbp-0E8]
       lea       r8,[rbp-0D0]
       mov       rcx,r12
       call      qword ptr [7FF910CA5A88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].AddIfNotPresent(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M00_L61
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       short M00_L65
       mov       rcx,r14
       mov       rdx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r9d,2
       call      qword ptr [7FF9104C66A0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L60:
       mov       r13d,1
M00_L61:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-108]
       cmp       [rcx],rdx
       jne       short M00_L63
       mov       rdx,[rcx]
       add       rcx,8
       cmp       [rcx],ecx
       call      qword ptr [7FF91083C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L62:
       test      eax,eax
       jne       near ptr M00_L58
       jmp       short M00_L66
M00_L63:
       mov       r11,7FF910411780
       call      qword ptr [r11]
       jmp       short M00_L62
M00_L64:
       lea       rdx,[rbp-48]
       mov       r11,7FF910411788
       call      qword ptr [r11]
       jmp       near ptr M00_L59
M00_L65:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0E8],xmm0
       lea       rdx,[rbp-0E8]
       mov       rcx,r14
       mov       r11,7FF910411790
       call      qword ptr [r11]
       jmp       short M00_L60
M00_L66:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-108]
       cmp       [r11],rcx
       jne       near ptr M00_L80
M00_L67:
       mov       [rbp-0D8],r13b
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0D8]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA5BC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,178
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L68:
       xor       r13d,r13d
       jmp       short M00_L67
M00_L69:
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910CAD608]
       int       3
M00_L70:
       call      qword ptr [7FF910CA5728]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L71
       call      qword ptr [7FF910EC4528]
       mov       r13,rax
M00_L71:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF910837DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       r8,rsi
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      qword ptr [7FF910CA5980]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,r12
       mov       rdx,rsi
       call      qword ptr [7FF910CA5998]
       jmp       near ptr M00_L54
M00_L73:
       mov       rcx,r14
       mov       r11,7FF9104117A0
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L74:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,201AA400D28
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L75:
       mov       rcx,r14
       mov       r11,7FF9104117A8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L76:
       mov       rcx,rax
       mov       r11,7FF9104117C0
       call      qword ptr [r11]
       jmp       near ptr M00_L53
M00_L77:
       mov       edx,ecx
       sub       edx,[r12+30]
       mov       rcx,r12
       call      qword ptr [7FF910EC4540]
       jmp       near ptr M00_L54
M00_L78:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,201AA400D28
       mov       rdx,[rcx]
       jmp       near ptr M00_L55
M00_L79:
       mov       rcx,r15
       mov       r11,7FF910411778
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L56
M00_L80:
       mov       rcx,r11
       mov       r11,7FF910411798
       call      qword ptr [r11]
       jmp       near ptr M00_L67
       sub       rsp,38
       cmp       qword ptr [rbp-108],0
       je        short M00_L81
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-108]
       cmp       [rax],rcx
       je        short M00_L81
       mov       rcx,rax
       mov       r11,7FF910411798
       call      qword ptr [r11]
M00_L81:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-118],0
       je        short M00_L82
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-118]
       cmp       [rax],rcx
       je        short M00_L82
       mov       rcx,rax
       mov       r11,7FF9104117C0
       call      qword ptr [r11]
M00_L82:
       nop
       add       rsp,38
       ret
; Total bytes of code 3770
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
       mov       rcx,7FF96F2D0B08
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
       call      qword ptr [7FF910CAE4D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910835EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF910CAE4F0]
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
       je        short M03_L03
       cmp       edx,1
       jne       near ptr M03_L23
       mov       [rbp-44],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L04
       test      r15b,4
       je        near ptr M03_L07
M03_L02:
       mov       rcx,rdi
       call      00007FF9701427D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D759C8]
       jmp       near ptr M03_L16
M03_L03:
       mov       [rbp-48],ecx
       jmp       short M03_L01
M03_L04:
       mov       rcx,rdi
       mov       rax,7FF9104048F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L05]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF97013B1D0
       call      rax
M03_L05:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L06
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF910404938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L08]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF970162B70
       call      rax
M03_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L09
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,0AF2693D8
       mov       r8d,0D6CA06DE
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
       je        near ptr M03_L22
       cmp       edx,1
       jne       near ptr M03_L28
       mov       [rbp-44],eax
M03_L16:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,71270C46
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
       mov       [rbp-48],eax
       jmp       near ptr M03_L16
M03_L23:
       cmp       edx,2
       jne       short M03_L24
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L24:
       cmp       eax,3
       jne       short M03_L25
       mov       dword ptr [rbp-58],7EF3E8BD
       mov       dword ptr [rbp-54],0E0BC6F0C
       mov       dword ptr [rbp-50],5AD0A495
       mov       dword ptr [rbp-4C],0BC992AE4
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
       lea       rcx,[7FF910DE8558]
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
       mov       dword ptr [rbp-58],7EF3E8BD
       mov       dword ptr [rbp-54],0E0BC6F0C
       mov       dword ptr [rbp-50],5AD0A495
       mov       dword ptr [rbp-4C],0BC992AE4
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L16
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D759C8]
       jmp       near ptr M03_L16
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF910D76C40]
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M04_L01
       mov       rcx,rax
M04_L00:
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
M04_L01:
       mov       rdx,7FF910C9BF08
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
; Total bytes of code 167
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M05_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M05_L06
M05_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF96FF45618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF96FF45618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L05
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       call      qword ptr [7FF96FF34040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FF96FF34040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF96FF45618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FF96FF34040]; CORINFO_HELP_POLL_GC
M05_L07:
       cmp       rdi,4000
       ja        short M05_L06
       jmp       short M05_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L03
       test      r8b,18
       jne       short M06_L00
       test      r8b,4
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L01
M06_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M06_L01:
       vzeroupper
       ret
M06_L02:
       test      r8,r8
       je        short M06_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L01
M06_L03:
       cmp       r8,40
       ja        short M06_L07
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M06_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M06_L06
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L01
M06_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L07:
       cmp       r8,800
       ja        short M06_L11
       cmp       r8,100
       jb        short M06_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M06_L08:
       mov       r9,r8
       shr       r9,6
M06_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M06_L04
       jmp       near ptr M06_L05
M06_L10:
       cmp       rcx,rdx
       jne       short M06_L11
       cmp       [rdx],dl
       jmp       near ptr M06_L01
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9104C66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.GetLowerBound(Int32)
       push      rbx
       sub       rsp,20
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       r8d,eax
       or        r8d,edx
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FF96FF3E650]
       mov       rbx,rax
       call      qword ptr [7FF96FF498B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF96FF48058]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M08_L07
       test      rsi,rsi
       je        near ptr M08_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M08_L00
       mov       rax,[rbx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,1
       test      eax,eax
       cmove     eax,ecx
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       cmp       eax,ecx
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF96FF45378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF96FF5C8F8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF96FF45378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF96FF5C8F8]
       int       3
M08_L02:
       sub       ebp,eax
       js        near ptr M08_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF96FF45298]
       test      eax,eax
       jne       near ptr M08_L16
M08_L03:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       je        near ptr M08_L15
       cmp       r8,4000
       ja        near ptr M08_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF96FF45618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L12
M08_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L13
M08_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF96FF471F0]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF96FF471F0]
       int       3
M08_L08:
       call      qword ptr [7FF96FF3E770]
       mov       rbx,rax
       call      qword ptr [7FF96FF49D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF96FF48778]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF96FF5C8E0]
       int       3
M08_L10:
       call      qword ptr [7FF96FF3E538]
       mov       rbx,rax
       call      qword ptr [7FF96FF48BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF96FF471A0]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FF96FF3E538]
       mov       r14,rax
       call      qword ptr [7FF96FF48BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF96FF471A0]
       mov       rcx,r14
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M08_L12:
       call      qword ptr [7FF96FF34040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L04
M08_L13:
       call      qword ptr [7FF96FF34040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L14:
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF96FF488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L04
M08_L16:
       cmp       byte ptr [rsp+78],0
       je        short M08_L17
       call      qword ptr [7FF96FF3E560]
       mov       rbx,rax
       call      qword ptr [7FF96FF49698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF96FF47218]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M08_L17:
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
; Total bytes of code 738
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
       jne       short M09_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M09_L03
M09_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M09_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M09_L02
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
M09_L01:
       call      qword ptr [7FF9104CFC60]
       int       3
M09_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M09_L00
M09_L03:
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
M09_L04:
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
       je        near ptr M10_L06
M10_L00:
       mov       r15,[rbx+10]
       mov       r13,[rbx+18]
       xor       r12d,r12d
       test      r13,r13
       jne       near ptr M10_L11
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
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
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
       jae       near ptr M10_L22
       mov       edx,edx
       lea       r13,[rcx+rdx*4+10]
       mov       edi,[r13]
       dec       edi
       jns       short M10_L04
M10_L01:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M10_L20
       mov       r12d,[rbx+28]
       cmp       [r15+8],r12d
       je        near ptr M10_L21
M10_L02:
       lea       eax,[r12+1]
       mov       [rbx+28],eax
       mov       r15,[rbx+10]
M10_L03:
       cmp       r12d,[r15+8]
       jae       near ptr M10_L22
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
M10_L04:
       cmp       edi,[r15+8]
       jae       near ptr M10_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rax,[r15+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],esi
       je        short M10_L07
M10_L05:
       mov       rax,[rsp+30]
       mov       edi,[rax+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M10_L19
       test      edi,edi
       jge       short M10_L04
       jmp       near ptr M10_L01
M10_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910CA59B0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M10_L08
       jmp       short M10_L09
M10_L08:
       mov       rdx,7FF910C9BE88
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M10_L09:
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
       je        near ptr M10_L05
       mov       [r14],edi
M10_L10:
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
M10_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M10_L12
       jmp       short M10_L13
M10_L12:
       mov       rdx,7FF910C9C230
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M10_L13:
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
       jae       near ptr M10_L22
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       rdi,rcx
       mov       eax,[rdi]
       dec       eax
       jns       short M10_L14
       mov       r13,rdi
       jmp       near ptr M10_L01
M10_L14:
       cmp       eax,[r15+8]
       jae       near ptr M10_L22
       mov       [rsp+5C],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r15+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8],esi
       jne       short M10_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M10_L15
       jmp       short M10_L16
M10_L15:
       mov       rdx,7FF910C9C248
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M10_L16:
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
       jne       short M10_L18
M10_L17:
       mov       r8,[rsp+28]
       mov       eax,[r8+4]
       inc       r12d
       cmp       [r15+8],r12d
       jb        short M10_L19
       test      eax,eax
       jge       near ptr M10_L14
       mov       r13,rdi
       jmp       near ptr M10_L01
M10_L18:
       mov       eax,[rsp+5C]
       mov       [r14],eax
       jmp       near ptr M10_L10
M10_L19:
       call      qword ptr [7FF9104CF498]
       int       3
M10_L20:
       mov       eax,[rbx+2C]
       mov       r12d,eax
       dec       dword ptr [rbx+30]
       cmp       eax,[r15+8]
       jae       short M10_L22
       lea       rax,[rax+rax*2]
       mov       eax,[r15+rax*8+14]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rbx+2C],eax
       jmp       near ptr M10_L03
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FF910CA5B18]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize()
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
       jae       short M10_L22
       mov       ecx,ecx
       lea       r13,[rax+rcx*4+10]
       jmp       near ptr M10_L02
M10_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 916
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M11_L15
       cmp       qword ptr [rcx+8],0
       je        near ptr M11_L16
M11_L00:
       mov       rax,[rcx+10]
       mov       [rbp-68],rax
       mov       rax,[rcx+18]
       mov       [rbp-70],rax
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+78]
       test      r11,r11
       je        near ptr M11_L14
M11_L01:
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rax,[rbp-70]
       cmp       [rax],r8
       jne       near ptr M11_L18
       mov       dword ptr [rbp-3C],15051505
       mov       dword ptr [rbp-40],15051505
       mov       rdx,[rbp+18]
       mov       r8d,[rdx+8]
       mov       [rbp-44],r8d
       lea       r8,[rdx+0C]
       mov       [rbp-50],r8
       mov       r8,[rbp-50]
       cmp       dword ptr [rbp-44],2
       jle       short M11_L03
M11_L02:
       mov       r10d,[r8]
       mov       r9d,[r8+4]
       mov       r11d,r10d
       or        r11d,r9d
       test      r11d,0FF80FF80
       jne       near ptr M11_L04
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
       add       r8,8
       cmp       dword ptr [rbp-44],2
       jg        short M11_L02
M11_L03:
       cmp       dword ptr [rbp-44],0
       jle       near ptr M11_L13
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M11_L04
       rorx      r10d,[rbp-40],1B
       add       r10d,[rbp-40]
       or        r8d,200020
       xor       r8d,r10d
       mov       [rbp-40],r8d
       jmp       near ptr M11_L13
M11_L04:
       call      M11_L31
       nop
       mov       rdx,[rbp+18]
       mov       r8d,[rdx+8]
       sub       r8d,[rbp-44]
       cmp       [rdx+8],r8d
       jb        near ptr M11_L17
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2+0C]
       mov       eax,[rdx+8]
       sub       eax,r8d
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-40]
       mov       ecx,[rbp-3C]
       call      qword ptr [7FF910CAF438]
M11_L05:
       mov       ebx,eax
M11_L06:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       r8d,ebx
       imul      r8,[rcx+30]
       shr       r8,20
       inc       r8
       mov       r10d,[rax+8]
       mov       r9d,r10d
       imul      r8,r9
       shr       r8,20
       cmp       r8d,r10d
       jae       near ptr M11_L30
       mov       r8d,r8d
       lea       rdi,[rax+r8*4+10]
       mov       r14d,[rdi]
       dec       r14d
       mov       rax,[rbp-68]
       mov       r15d,[rax+8]
       cmp       r15d,r14d
       jbe       short M11_L09
M11_L07:
       mov       rax,[rbp-68]
       mov       r8d,r14d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       cmp       [r13+10],ebx
       je        near ptr M11_L19
M11_L08:
       mov       r14d,[r13+14]
       inc       esi
       cmp       r15d,esi
       jb        near ptr M11_L26
       cmp       r15d,r14d
       ja        short M11_L07
M11_L09:
       cmp       dword ptr [rcx+40],0
       jg        near ptr M11_L27
       mov       r13d,[rcx+38]
       cmp       r15d,r13d
       je        near ptr M11_L28
M11_L10:
       lea       eax,[r13+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-68],rax
M11_L11:
       mov       rax,[rbp-68]
       cmp       r13d,[rax+8]
       jae       near ptr M11_L30
       mov       rax,[rbp-68]
       mov       r8d,r13d
       lea       r8,[r8+r8*2]
       lea       r14,[rax+r8*8+10]
       mov       [r14+10],ebx
       mov       eax,[rdi]
       dec       eax
       mov       [r14+14],eax
       mov       rdx,[rbp+18]
       mov       rcx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       [rdi],r13d
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+44]
       cmp       esi,64
       ja        near ptr M11_L29
M11_L12:
       mov       eax,1
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L13:
       xor       r11d,r11d
       mov       [rbp-50],r11
       imul      r11d,[rbp-40],5D588B65
       add       r11d,[rbp-3C]
       mov       eax,r11d
       jmp       near ptr M11_L05
M11_L14:
       mov       rcx,rax
       mov       rdx,7FF910D23B60
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L01
M11_L15:
       mov       ecx,4
       call      qword ptr [7FF9104CFD50]
       int       3
M11_L16:
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L00
M11_L17:
       mov       ecx,21
       call      qword ptr [7FF9104CF360]
       int       3
M11_L18:
       mov       rcx,rax
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M11_L06
M11_L19:
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+80]
       test      r11,r11
       je        short M11_L20
       jmp       short M11_L21
M11_L20:
       mov       rcx,rax
       mov       rdx,7FF910D23B78
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M11_L21:
       mov       rdx,[rbp-68]
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-70]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M11_L08
       cmp       byte ptr [rbp+28],1
       jne       short M11_L22
       lea       rcx,[r13+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L12
M11_L22:
       cmp       byte ptr [rbp+28],2
       jne       short M11_L25
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r8,[r8+88]
       test      r8,r8
       je        short M11_L23
       mov       rcx,r8
       jmp       short M11_L24
M11_L23:
       mov       rcx,rax
       mov       rdx,7FF910D23B90
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M11_L24:
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9104CFD20]
       int       3
M11_L25:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L26:
       call      qword ptr [7FF9104CF498]
       int       3
M11_L27:
       mov       eax,[rcx+3C]
       mov       r13d,eax
       cmp       eax,r15d
       jae       near ptr M11_L30
       mov       r8,[rbp-68]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M11_L11
M11_L28:
       call      qword ptr [7FF910CAE898]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,ebx
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       short M11_L30
       mov       eax,eax
       lea       rdi,[rdx+rax*4+10]
       jmp       near ptr M11_L10
M11_L29:
       mov       rdx,[rbp-70]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M11_L12
       mov       rdx,[rbp-68]
       mov       edx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8d,1
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M11_L12
M11_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L31:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-50],r8
       add       rsp,28
       ret
; Total bytes of code 1162
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
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FF9104C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       sub       rsp,168
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L58
       test      r14,r14
       je        near ptr M00_L59
       mov       rcx,r14
       mov       rax,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rcx],rax
       je        short M00_L00
       xor       ecx,ecx
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L60
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L62
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L63
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [r12+2C],0FFFFFFFF
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L65
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L64
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       [rbp-80],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-80]
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
       mov       [rbp-100],rcx
M00_L06:
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-100]
       cmp       [rcx],rsi
       jne       near ptr M00_L26
       lea       rdi,[rcx+8]
       mov       edx,[rdi+8]
       mov       rax,[rdi]
       cmp       edx,[rax+44]
       jne       near ptr M00_L18
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       cmp       edx,[rax+38]
       jae       near ptr M00_L17
M00_L07:
       mov       rdx,[rdi]
       mov       rdx,[rdx+10]
       mov       eax,[rdi+0C]
       lea       r8d,[rax+1]
       mov       [rdi+0C],r8d
       cmp       eax,[rdx+8]
       jae       near ptr M00_L28
       lea       rax,[rax+rax*2]
       lea       rdx,[rdx+rax*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        near ptr M00_L25
       mov       rax,[rdx]
       mov       rsi,[rdx+8]
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-100]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L08:
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-50]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L20
M00_L09:
       mov       rax,[r12+10]
       mov       [rbp-108],rax
       mov       rdx,[r12+18]
       mov       [rbp-110],rdx
       xor       r8d,r8d
       mov       [rbp-84],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-130],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-130]
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
       mov       rcx,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],rdx
       mov       r8d,[rdx]
       dec       r8d
       js        short M00_L12
M00_L10:
       mov       r10,[rbp-108]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L28
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-108],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-138],r8
       mov       [rbp-88],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L11:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r10,[rbp-108]
       mov       [rbp-84],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L27
       test      r8d,r8d
       mov       eax,[rbp-88]
       jge       short M00_L10
M00_L12:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L16
       mov       r8d,[r12+28]
       mov       [rbp-8C],r8d
       mov       r11,[rbp-108]
       cmp       [r11+8],r8d
       je        near ptr M00_L15
M00_L13:
       mov       r8d,[rbp-8C]
       lea       ecx,[r8+1]
       mov       [r12+28],ecx
       mov       r11,[r12+10]
       mov       rcx,r11
M00_L14:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L28
       mov       [rbp-90],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-128],r10
       mov       [r10],eax
       mov       rdx,[rbp-118]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-128]
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-90]
       inc       esi
       mov       rdi,[rbp-118]
       mov       [rdi],esi
       inc       dword ptr [r12+34]
       jmp       near ptr M00_L06
M00_L15:
       mov       [rbp-88],eax
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104CF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910C95698]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r12+8]
       mov       edx,[rbp-88]
       mov       eax,edx
       imul      rax,[r12+20]
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
       mov       [rbp-118],rax
       mov       eax,edx
       jmp       near ptr M00_L13
M00_L16:
       mov       ecx,[r12+2C]
       mov       r8d,ecx
       dec       dword ptr [r12+30]
       mov       r11,[rbp-108]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L28
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L14
M00_L17:
       mov       rax,[rdi]
       mov       eax,[rax+38]
       inc       eax
       mov       [rdi+0C],eax
       xor       eax,eax
       mov       [rdi+18],rax
       mov       [rdi+20],rax
       jmp       near ptr M00_L29
M00_L18:
       call      qword ptr [7FF9104CFC60]
       int       3
M00_L19:
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-100]
       mov       r11,7FF910411630
       call      qword ptr [r11]
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L08
M00_L20:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910C954A0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L09
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-178],r9
       mov       r11,[r8+10]
       mov       [rbp-180],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9104049D0]
       test      eax,eax
       mov       r8,[rbp-138]
       je        near ptr M00_L11
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF910411640
       call      qword ptr [r11]
       mov       r8,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L12
M00_L23:
       mov       r11,[rbp-108]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L28
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-108],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-120],r9
       mov       [rbp-88],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rdi
       mov       [rbp-0E0],rsi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF910411648
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-120]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r11,[rbp-108]
       cmp       [r11+8],ecx
       jb        short M00_L27
       test      r9d,r9d
       mov       [rbp-108],r11
       mov       [rbp-84],ecx
       mov       eax,[rbp-88]
       jge       near ptr M00_L23
       jmp       near ptr M00_L12
M00_L25:
       mov       edx,[rdi+0C]
       mov       rax,[rdi]
       cmp       edx,[rax+38]
       jb        near ptr M00_L07
       jmp       near ptr M00_L17
M00_L26:
       mov       r11,7FF910411628
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       short M00_L29
M00_L27:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,[rbp-100]
       cmp       [rcx],rsi
       jne       near ptr M00_L66
M00_L30:
       mov       ecx,[r12+28]
       test      ecx,ecx
       jle       short M00_L31
       mov       rax,[r12+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L67
M00_L31:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L69
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        near ptr M00_L68
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       mov       [rbp-0B8],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0B8]
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
       mov       rcx,rdx
M00_L33:
       mov       [rbp-0F0],rcx
M00_L34:
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rsi
       jne       near ptr M00_L53
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91083C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L35:
       test      eax,eax
       je        near ptr M00_L56
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rsi
       jne       near ptr M00_L46
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M00_L36:
       mov       rsi,[rbp-48]
       mov       rdi,[rbp-40]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L47
M00_L37:
       mov       r15,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-150],rax
       xor       edx,edx
       mov       [rbp-0BC],edx
       test      rax,rax
       jne       near ptr M00_L49
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-168]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-168]
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910C955D8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        short M00_L40
M00_L38:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L55
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r15+rdx*8+10]
       mov       [rbp-170],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       je        near ptr M00_L48
M00_L39:
       mov       r10d,[r10+4]
       mov       edx,[rbp-0BC]
       inc       edx
       mov       [rbp-0BC],edx
       cmp       [r15+8],edx
       jb        near ptr M00_L54
       test      r10d,r10d
       jge       short M00_L38
M00_L40:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L45
       mov       r13d,[r12+28]
       cmp       [r15+8],r13d
       je        near ptr M00_L44
M00_L41:
       lea       ecx,[r13+1]
       mov       [r12+28],ecx
       mov       r15,[r12+10]
M00_L42:
       cmp       r13d,[r15+8]
       jae       near ptr M00_L55
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r15+rcx*8+10]
       mov       r9d,[rbp-0C0]
       mov       [r15],r9d
       mov       rax,[rbp-158]
       mov       ecx,[rax]
       dec       ecx
       mov       [r15+4],ecx
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       r15,[rbp-158]
       mov       [r15],r13d
       inc       dword ptr [r12+34]
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L52
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       call      qword ptr [7FF91050ABC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
M00_L43:
       mov       r13d,1
       jmp       near ptr M00_L34
M00_L44:
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104CF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910C95698]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r12
       mov       edx,[rbp-0C0]
       call      qword ptr [7FF910C955D8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r15,rax
       mov       [rbp-158],r15
       jmp       near ptr M00_L41
M00_L45:
       mov       ecx,[r12+2C]
       mov       r13d,ecx
       dec       dword ptr [r12+30]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L55
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r15+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       jmp       near ptr M00_L42
M00_L46:
       lea       rdx,[rbp-48]
       mov       r11,7FF910411600
       call      qword ptr [r11]
       mov       rcx,[rbp-0F0]
       jmp       near ptr M00_L36
M00_L47:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910C954A0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-0F0]
       jmp       near ptr M00_L37
M00_L48:
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       rdx,[rbp-0D8]
       lea       r8,[rbp-0E8]
       mov       rcx,2231DC00A08
       mov       rcx,[rcx]
       call      qword ptr [7FF910CACA60]
       test      eax,eax
       mov       r10,[rbp-170]
       je        near ptr M00_L39
       jmp       near ptr M00_L34
M00_L49:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,rax
       mov       r11,7FF910411650
       call      qword ptr [r11]
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910C955D8]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        near ptr M00_L40
M00_L50:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L55
       mov       r8d,r10d
       lea       r8,[r8+r8*2]
       lea       r10,[r15+r8*8+10]
       mov       [rbp-160],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L51
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-150]
       mov       r11,7FF910411658
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-160]
       jne       near ptr M00_L34
M00_L51:
       mov       r10d,[r10+4]
       mov       ecx,[rbp-0BC]
       inc       ecx
       cmp       [r15+8],ecx
       jb        short M00_L54
       test      r10d,r10d
       mov       [rbp-0BC],ecx
       jge       near ptr M00_L50
       jmp       near ptr M00_L40
M00_L52:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       mov       r11,7FF910411608
       call      qword ptr [r11]
       jmp       near ptr M00_L43
M00_L53:
       mov       r11,7FF9104115F8
       call      qword ptr [r11]
       jmp       near ptr M00_L35
M00_L54:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rsi
       jne       near ptr M00_L70
M00_L57:
       mov       [rbp-0C8],r13b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0C8]
       cmp       [rcx],ecx
       call      qword ptr [7FF910C956B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L58:
       xor       r13d,r13d
       jmp       short M00_L57
M00_L59:
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C9D500]
       int       3
M00_L60:
       call      qword ptr [7FF910C95218]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L61
       call      qword ptr [7FF910D772E8]
       mov       r13,rax
M00_L61:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF910837DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L62:
       mov       r8,rsi
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      qword ptr [7FF910C95470]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,r12
       mov       rdx,rsi
       call      qword ptr [7FF910C95488]
       jmp       near ptr M00_L31
M00_L63:
       mov       rcx,r14
       mov       r11,7FF910411618
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2231DC00B10
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L65:
       mov       rcx,r14
       mov       r11,7FF910411620
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L66:
       mov       r11,7FF910411638
       call      qword ptr [r11]
       jmp       near ptr M00_L30
M00_L67:
       mov       edx,ecx
       sub       edx,[r12+30]
       mov       rcx,r12
       call      qword ptr [7FF910D77300]
       jmp       near ptr M00_L31
M00_L68:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2231DC00B10
       mov       rdx,[rcx]
       jmp       near ptr M00_L32
M00_L69:
       mov       rcx,r15
       mov       r11,7FF9104115F0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L33
M00_L70:
       mov       r11,7FF910411610
       call      qword ptr [r11]
       jmp       near ptr M00_L57
       sub       rsp,28
       cmp       qword ptr [rbp-0F0],0
       je        short M00_L71
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rsi
       je        short M00_L71
       mov       r11,7FF910411610
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-100],0
       je        short M00_L72
       mov       rsi,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-100]
       cmp       [rcx],rsi
       je        short M00_L72
       mov       r11,7FF910411638
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,28
       ret
; Total bytes of code 3628
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
       mov       rcx,7FF96F2D0B08
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
       call      qword ptr [7FF910C9E700]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910835EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF910C9E688]
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
       jne       near ptr M03_L22
       mov       [rbp-44],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L03
       test      r15b,4
       je        short M03_L06
       jmp       near ptr M03_L25
M03_L02:
       mov       [rbp-48],ecx
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       mov       rax,7FF9104048F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF97013B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L05
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF910404938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF970162B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L08
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,8EA5FB71
       mov       r8d,5D6F62A2
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
       jne       near ptr M03_L28
       mov       [rbp-44],eax
M03_L15:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,132FB0F0
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
       cmp       edx,2
       jne       short M03_L23
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L23:
       cmp       eax,3
       jne       short M03_L24
       mov       dword ptr [rbp-58],20FC8D67
       mov       dword ptr [rbp-54],82C513B6
       mov       dword ptr [rbp-50],0FCD9493F
       mov       dword ptr [rbp-4C],5EA1CF8E
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
       call      00007FF9701427D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D75E60]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF910DDC9D8]
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
       mov       dword ptr [rbp-58],20FC8D67
       mov       dword ptr [rbp-54],82C513B6
       mov       dword ptr [rbp-50],0FCD9493F
       mov       dword ptr [rbp-4C],5EA1CF8E
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D75E60]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF910D76AF0]
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
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
       mov       rdx,7FF910C89958
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF910A6EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF910C9CBD0]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF910C9CBD0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF910C9CBE8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910C89958
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9104CFC60]
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
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M08_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       cmp       [rcx],ecx
       mov       rbx,[rdx]
       mov       rdx,[rdx+8]
       mov       [rbp-70],rdx
       mov       [rbp-78],rbx
       test      rbx,rbx
       je        near ptr M09_L16
       cmp       qword ptr [rcx+8],0
       je        near ptr M09_L17
M09_L00:
       mov       rdx,[rcx+10]
       mov       [rbp-80],rdx
       mov       rdx,[rcx+18]
       mov       [rbp-88],rdx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        near ptr M09_L15
M09_L01:
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-88]
       cmp       [rdx],r8
       jne       near ptr M09_L19
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       r8d,[rbx+8]
       mov       [rbp-4C],r8d
       lea       r8,[rbx+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M09_L03
M09_L02:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       short M09_L04
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
       jg        short M09_L02
M09_L03:
       cmp       dword ptr [rbp-4C],0
       jle       near ptr M09_L13
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M09_L04
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
       jmp       near ptr M09_L13
M09_L04:
       call      M09_L29
       nop
       mov       rbx,[rbp-78]
       mov       r8d,[rbx+8]
       sub       r8d,[rbp-4C]
       cmp       [rbx+8],r8d
       jb        near ptr M09_L18
       mov       edx,r8d
       lea       rdx,[rbx+rdx*2+0C]
       mov       ecx,[rbx+8]
       sub       ecx,r8d
       mov       [rbp-68],rdx
       mov       [rbp-60],ecx
       lea       r8,[rbp-68]
       mov       edx,[rbp-48]
       mov       ecx,[rbp-44]
       call      qword ptr [7FF910C9F708]
       mov       rdx,[rbp-88]
M09_L05:
       mov       esi,eax
M09_L06:
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       r8d,esi
       imul      r8,[rcx+30]
       shr       r8,20
       inc       r8
       mov       r10d,[rax+8]
       mov       r9d,r10d
       imul      r8,r9
       shr       r8,20
       cmp       r8d,r10d
       jae       near ptr M09_L28
       mov       r8d,r8d
       lea       r14,[rax+r8*4+10]
       mov       r15d,[r14]
       dec       r15d
       mov       rax,[rbp-80]
       mov       r13d,[rax+8]
       cmp       r13d,r15d
       jbe       short M09_L09
M09_L07:
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r12,[rax+r8*8+10]
       cmp       [r12+10],esi
       je        near ptr M09_L20
M09_L08:
       mov       r15d,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M09_L25
       cmp       r13d,r15d
       ja        short M09_L07
M09_L09:
       cmp       dword ptr [rcx+40],0
       jg        near ptr M09_L14
       mov       r15d,[rcx+38]
       cmp       r13d,r15d
       je        near ptr M09_L26
M09_L10:
       lea       eax,[r15+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-80],rax
M09_L11:
       mov       rax,[rbp-80]
       cmp       r15d,[rax+8]
       jae       near ptr M09_L28
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+44]
       cmp       edi,64
       ja        near ptr M09_L27
M09_L12:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L13:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
       jmp       near ptr M09_L05
M09_L14:
       mov       eax,[rcx+3C]
       mov       r15d,eax
       cmp       eax,r13d
       jae       near ptr M09_L28
       mov       r8,[rbp-80]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M09_L11
M09_L15:
       mov       rcx,rdx
       mov       rdx,7FF910D15690
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L01
M09_L16:
       mov       ecx,4
       call      qword ptr [7FF9104CFD50]
       int       3
M09_L17:
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M09_L00
M09_L18:
       mov       ecx,21
       call      qword ptr [7FF9104CF360]
       int       3
M09_L19:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L06
M09_L20:
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+80]
       test      r11,r11
       je        short M09_L21
       jmp       short M09_L22
M09_L21:
       mov       rcx,rax
       mov       rdx,7FF910D156A8
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L22:
       mov       rdx,[rbp-80]
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*2]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-88]
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-88]
       je        near ptr M09_L08
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        short M09_L23
       jmp       short M09_L24
M09_L23:
       mov       rcx,rdx
       mov       rdx,7FF910D156C0
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M09_L24:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9104CFD20]
       int       3
M09_L25:
       call      qword ptr [7FF9104CF498]
       int       3
M09_L26:
       call      qword ptr [7FF910C9EB20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,esi
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       short M09_L28
       mov       eax,eax
       lea       r14,[rdx+rax*4+10]
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L10
M09_L27:
       mov       rdx,[rbp-88]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L12
       mov       rdx,[rbp-80]
       mov       edx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8d,1
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M09_L12
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L29:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1144
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
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FF9104C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       sub       rsp,168
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L31
       test      r14,r14
       je        near ptr M00_L32
       mov       rcx,r14
       mov       rax,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rcx],rax
       je        short M00_L00
       xor       ecx,ecx
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L33
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L35
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L36
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FF9104E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [r12+2C],0FFFFFFFF
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L38
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L37
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       [rbp-80],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-80]
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
       mov       [rbp-100],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       jne       near ptr M00_L27
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       rax,[rbp-100]
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
       mov       rcx,[rbp-100]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L09:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L20
M00_L10:
       mov       rax,[r12+10]
       mov       [rbp-108],rax
       mov       rdx,[r12+18]
       mov       [rbp-110],rdx
       xor       r8d,r8d
       mov       [rbp-84],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-130],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-130]
       call      qword ptr [7FF9104249D8]; System.ValueType.GetHashCode()
       mov       rcx,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L17
       mov       r8d,[r12+28]
       mov       [rbp-8C],r8d
       mov       r11,[rbp-108]
       cmp       [r11+8],r8d
       je        near ptr M00_L16
M00_L12:
       mov       r8d,[rbp-8C]
       lea       ecx,[r8+1]
       mov       [r12+28],ecx
       mov       r11,[r12+10]
       mov       rcx,r11
M00_L13:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L30
       mov       [rbp-90],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-128],r10
       mov       [r10],eax
       mov       rdx,[rbp-118]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-128]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-90]
       inc       esi
       mov       rdi,[rbp-118]
       mov       [rdi],esi
       inc       dword ptr [r12+34]
       jmp       near ptr M00_L06
M00_L14:
       mov       r10,[rbp-108]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-108],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-138],r8
       mov       [rbp-88],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L15:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r10,[rbp-108]
       mov       [rbp-84],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L29
       test      r8d,r8d
       mov       eax,[rbp-88]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       [rbp-88],eax
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104EF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CC5B48]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r12+8]
       mov       edx,[rbp-88]
       mov       eax,edx
       imul      rax,[r12+20]
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
       mov       [rbp-118],rax
       mov       eax,edx
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,[r12+2C]
       mov       r8d,ecx
       dec       dword ptr [r12+30]
       mov       r11,[rbp-108]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L30
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L13
M00_L18:
       call      qword ptr [7FF9104EFC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-100]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-100]
       mov       r11,7FF9104314E0
       call      qword ptr [r11]
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CC5950]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L10
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-178],r9
       mov       r11,[r8+10]
       mov       [rbp-180],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9104249D0]
       test      eax,eax
       mov       r8,[rbp-138]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104314F0
       call      qword ptr [r11]
       mov       r8,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L11
M00_L23:
       mov       r11,[rbp-108]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L30
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-108],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-120],r9
       mov       [rbp-88],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104314F8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-120]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r11,[rbp-108]
       cmp       [r11+8],ecx
       jb        short M00_L29
       test      r9d,r9d
       mov       [rbp-108],r11
       mov       [rbp-84],ecx
       mov       eax,[rbp-88]
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
       mov       r11,7FF9104314D8
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L39
M00_L29:
       call      qword ptr [7FF9104EF498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r13d,r13d
       jmp       near ptr M00_L69
M00_L32:
       mov       ecx,65
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       rcx,rax
       call      qword ptr [7FF910CCD8F0]
       int       3
M00_L33:
       call      qword ptr [7FF910CC56C8]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L34
       call      qword ptr [7FF910D97258]
       mov       r13,rax
M00_L34:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF910857DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       r8,rsi
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      qword ptr [7FF910CC5920]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,r12
       mov       rdx,rsi
       call      qword ptr [7FF910CC5938]
       jmp       near ptr M00_L41
M00_L36:
       mov       rcx,r14
       mov       r11,7FF9104314C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L37:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B7AC400AF8
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L38:
       mov       rcx,r14
       mov       r11,7FF9104314D0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L40
       mov       rcx,rax
       mov       r11,7FF9104314E8
       call      qword ptr [r11]
M00_L40:
       cmp       dword ptr [r12+28],0
       jle       short M00_L41
       mov       rax,[r12+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r12+28]
       cmp       eax,3
       jle       short M00_L41
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r12
       call      qword ptr [7FF910D97270]
M00_L41:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L44
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L42
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       mov       [rbp-0B8],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L43
M00_L42:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B7AC400AF8
       mov       rdx,[rcx]
M00_L43:
       mov       rcx,rdx
       jmp       short M00_L45
M00_L44:
       mov       rcx,r15
       mov       r11,7FF9104314A0
       call      qword ptr [r11]
       mov       rcx,rax
M00_L45:
       mov       [rbp-0F0],rcx
M00_L46:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       near ptr M00_L64
       jmp       near ptr M00_L63
M00_L47:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       short M00_L48
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L49
M00_L48:
       lea       rdx,[rbp-48]
       mov       r11,7FF9104314B0
       call      qword ptr [r11]
       mov       rcx,[rbp-0F0]
M00_L49:
       mov       rsi,[rbp-48]
       mov       rdi,[rbp-40]
       cmp       qword ptr [r12+8],0
       jne       short M00_L50
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CC5950]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-0F0]
M00_L50:
       mov       r15,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-150],rax
       xor       edx,edx
       mov       [rbp-0BC],edx
       test      rax,rax
       jne       near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-168]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-168]
       call      qword ptr [7FF9104249D8]; System.ValueType.GetHashCode()
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CC5A88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        near ptr M00_L53
M00_L51:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r15+rdx*8+10]
       mov       [rbp-170],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L52
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       rdx,[rbp-0D8]
       lea       r8,[rbp-0E8]
       mov       rcx,1B7AC400A08
       mov       rcx,[rcx]
       call      qword ptr [7FF910CDCA60]
       test      eax,eax
       mov       r10,[rbp-170]
       jne       near ptr M00_L46
M00_L52:
       mov       r10d,[r10+4]
       mov       edx,[rbp-0BC]
       inc       edx
       mov       [rbp-0BC],edx
       cmp       [r15+8],edx
       jb        near ptr M00_L66
       test      r10d,r10d
       jge       near ptr M00_L51
M00_L53:
       cmp       dword ptr [r12+30],0
       jle       near ptr M00_L58
       jmp       near ptr M00_L57
M00_L54:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,rax
       mov       r11,7FF910431500
       call      qword ptr [r11]
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CC5A88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        short M00_L53
M00_L55:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       r8d,r10d
       lea       r8,[r8+r8*2]
       lea       r10,[r15+r8*8+10]
       mov       [rbp-160],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L56
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-150]
       mov       r11,7FF910431508
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-160]
       jne       near ptr M00_L46
M00_L56:
       mov       r10d,[r10+4]
       mov       ecx,[rbp-0BC]
       inc       ecx
       cmp       [r15+8],ecx
       jb        near ptr M00_L66
       test      r10d,r10d
       mov       [rbp-0BC],ecx
       jge       near ptr M00_L55
       jmp       near ptr M00_L53
M00_L57:
       mov       r13d,[r12+2C]
       dec       dword ptr [r12+30]
       mov       ecx,[r12+2C]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L67
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r15+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       jmp       short M00_L60
M00_L58:
       mov       r13d,[r12+28]
       cmp       [r15+8],r13d
       jne       short M00_L59
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104EF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CC5B48]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r12
       mov       edx,[rbp-0C0]
       call      qword ptr [7FF910CC5A88]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r15,rax
       mov       [rbp-158],r15
M00_L59:
       lea       ecx,[r13+1]
       mov       [r12+28],ecx
       mov       r15,[r12+10]
M00_L60:
       cmp       r13d,[r15+8]
       jae       near ptr M00_L67
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r15+rcx*8+10]
       mov       r9d,[rbp-0C0]
       mov       [r15],r9d
       mov       rax,[rbp-158]
       mov       ecx,[rax]
       dec       ecx
       mov       [r15+4],ecx
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       r15,[rbp-158]
       mov       [r15],r13d
       inc       dword ptr [r12+34]
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       short M00_L61
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       call      qword ptr [7FF91052ABC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       short M00_L62
M00_L61:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       mov       r11,7FF9104314B8
       call      qword ptr [r11]
M00_L62:
       mov       r13d,1
       jmp       near ptr M00_L46
M00_L63:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91085C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L65
M00_L64:
       mov       r11,7FF9104314A8
       call      qword ptr [r11]
M00_L65:
       test      eax,eax
       jne       near ptr M00_L47
       jmp       short M00_L68
M00_L66:
       call      qword ptr [7FF9104EF498]
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L69
       mov       rcx,rax
       mov       r11,7FF9104314C0
       call      qword ptr [r11]
M00_L69:
       mov       [rbp-0C8],r13b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0C8]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CC5B60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-0F0],0
       je        short M00_L70
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L70
       mov       rcx,rax
       mov       r11,7FF9104314C0
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-100],0
       je        short M00_L71
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L71
       mov       rcx,rax
       mov       r11,7FF9104314E8
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,28
       ret
; Total bytes of code 3648
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
       mov       rcx,7FF96F2D0B08
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
       call      qword ptr [7FF910CCE868]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910855EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF910CCD350]
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
       jne       near ptr M03_L22
       mov       [rbp-44],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L03
       test      r15b,4
       je        short M03_L06
       jmp       near ptr M03_L25
M03_L02:
       mov       [rbp-48],ecx
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       mov       rax,7FF9104248F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF97013B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L05
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF910424938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF970162B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L08
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,283B293A
       mov       r8d,6E866E0B
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
       jne       near ptr M03_L28
       mov       [rbp-44],eax
M03_L15:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L35
       mov       edx,70CAD3D7
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
       cmp       edx,2
       jne       short M03_L23
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L23:
       cmp       eax,3
       jne       short M03_L24
       mov       dword ptr [rbp-58],7E97B04E
       mov       dword ptr [rbp-54],0E060369D
       mov       dword ptr [rbp-50],5A746C26
       mov       dword ptr [rbp-4C],0BC3CF275
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
       call      00007FF9701427D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D95E60]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF910DF7D38]
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
       mov       dword ptr [rbp-58],7E97B04E
       mov       dword ptr [rbp-54],0E060369D
       mov       dword ptr [rbp-50],5A746C26
       mov       dword ptr [rbp-4C],0BC3CF275
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
       call      qword ptr [7FF9108FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9108FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D95E60]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF910D96AC0]
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
       call      qword ptr [7FF9108FD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9104E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
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
       mov       rdx,7FF910CBBF08
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF910A8EBE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9104E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF910CCCD68]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF910CCCD68]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF910CCCD80]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9104E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910CBBF08
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF9104E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M08_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       cmp       [rcx],ecx
       mov       rbx,[rdx]
       mov       rdx,[rdx+8]
       mov       [rbp-70],rdx
       mov       [rbp-78],rbx
       test      rbx,rbx
       je        near ptr M09_L15
       cmp       qword ptr [rcx+8],0
       je        near ptr M09_L16
M09_L00:
       mov       rdx,[rcx+10]
       mov       [rbp-80],rdx
       mov       rdx,[rcx+18]
       mov       [rbp-88],rdx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        near ptr M09_L14
M09_L01:
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-88]
       cmp       [rdx],r8
       jne       near ptr M09_L18
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       r8d,[rbx+8]
       mov       [rbp-4C],r8d
       lea       r8,[rbx+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M09_L03
M09_L02:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       short M09_L04
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
       jg        short M09_L02
M09_L03:
       cmp       dword ptr [rbp-4C],0
       jle       near ptr M09_L13
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M09_L04
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
       jmp       near ptr M09_L13
M09_L04:
       call      M09_L29
       nop
       mov       rbx,[rbp-78]
       mov       r8d,[rbx+8]
       sub       r8d,[rbp-4C]
       cmp       [rbx+8],r8d
       jb        near ptr M09_L17
       mov       edx,r8d
       lea       rdx,[rbx+rdx*2+0C]
       mov       ecx,[rbx+8]
       sub       ecx,r8d
       mov       [rbp-68],rdx
       mov       [rbp-60],ecx
       lea       r8,[rbp-68]
       mov       edx,[rbp-48]
       mov       ecx,[rbp-44]
       call      qword ptr [7FF910CCF6A8]
       mov       rdx,[rbp-88]
M09_L05:
       mov       esi,eax
M09_L06:
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       r8d,esi
       imul      r8,[rcx+30]
       shr       r8,20
       inc       r8
       mov       r10d,[rax+8]
       mov       r9d,r10d
       imul      r8,r9
       shr       r8,20
       cmp       r8d,r10d
       jae       near ptr M09_L28
       mov       r8d,r8d
       lea       r14,[rax+r8*4+10]
       mov       r15d,[r14]
       dec       r15d
       mov       rax,[rbp-80]
       mov       r13d,[rax+8]
       cmp       r13d,r15d
       jbe       short M09_L09
M09_L07:
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r12,[rax+r8*8+10]
       cmp       [r12+10],esi
       je        near ptr M09_L19
M09_L08:
       mov       r15d,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M09_L24
       cmp       r13d,r15d
       ja        short M09_L07
M09_L09:
       cmp       dword ptr [rcx+40],0
       jg        near ptr M09_L25
       mov       r15d,[rcx+38]
       cmp       r13d,r15d
       je        near ptr M09_L26
M09_L10:
       lea       eax,[r15+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-80],rax
M09_L11:
       mov       rax,[rbp-80]
       cmp       r15d,[rax+8]
       jae       near ptr M09_L28
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+44]
       cmp       edi,64
       ja        near ptr M09_L27
M09_L12:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L13:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
       jmp       near ptr M09_L05
M09_L14:
       mov       rcx,rdx
       mov       rdx,7FF910D349A8
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L01
M09_L15:
       mov       ecx,4
       call      qword ptr [7FF9104EFD50]
       int       3
M09_L16:
       xor       edx,edx
       call      qword ptr [7FF9104E5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M09_L00
M09_L17:
       mov       ecx,21
       call      qword ptr [7FF9104EF360]
       int       3
M09_L18:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L06
M09_L19:
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+80]
       test      r11,r11
       je        short M09_L20
       jmp       short M09_L21
M09_L20:
       mov       rcx,rax
       mov       rdx,7FF910D349C0
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L21:
       mov       rdx,[rbp-80]
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*2]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-88]
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-88]
       je        near ptr M09_L08
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        short M09_L22
       jmp       short M09_L23
M09_L22:
       mov       rcx,rdx
       mov       rdx,7FF910D349D8
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M09_L23:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9104EFD20]
       int       3
M09_L24:
       call      qword ptr [7FF9104EF498]
       int       3
M09_L25:
       mov       eax,[rcx+3C]
       mov       r15d,eax
       cmp       eax,r13d
       jae       near ptr M09_L28
       mov       r8,[rbp-80]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M09_L11
M09_L26:
       call      qword ptr [7FF910CCEB68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,esi
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       short M09_L28
       mov       eax,eax
       lea       r14,[rdx+rax*4+10]
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L10
M09_L27:
       mov       rdx,[rbp-88]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L12
       mov       rdx,[rbp-80]
       mov       edx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8d,1
       call      qword ptr [7FF9107773F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M09_L12
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L29:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1144
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
       jne       short M10_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M10_L03
M10_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M10_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M10_L02
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
M10_L01:
       call      qword ptr [7FF9104EFC60]
       int       3
M10_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M10_L00
M10_L03:
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
M10_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
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
       sub       rsp,168
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L31
       test      r14,r14
       je        near ptr M00_L32
       mov       rcx,r14
       mov       rax,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rcx],rax
       je        short M00_L00
       xor       ecx,ecx
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L33
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L35
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L36
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [r12+2C],0FFFFFFFF
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L38
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L37
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       [rbp-80],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-80]
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
       mov       [rbp-100],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       jne       near ptr M00_L27
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       rax,[rbp-100]
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
       mov       rcx,[rbp-100]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L09:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L20
M00_L10:
       mov       rax,[r12+10]
       mov       [rbp-108],rax
       mov       rdx,[r12+18]
       mov       [rbp-110],rdx
       xor       r8d,r8d
       mov       [rbp-84],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-130],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-130]
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
       mov       rcx,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L17
       mov       r8d,[r12+28]
       mov       [rbp-8C],r8d
       mov       r11,[rbp-108]
       cmp       [r11+8],r8d
       je        near ptr M00_L16
M00_L12:
       mov       r8d,[rbp-8C]
       lea       ecx,[r8+1]
       mov       [r12+28],ecx
       mov       r11,[r12+10]
       mov       rcx,r11
M00_L13:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L30
       mov       [rbp-90],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-128],r10
       mov       [r10],eax
       mov       rdx,[rbp-118]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-128]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-90]
       inc       esi
       mov       rdi,[rbp-118]
       mov       [rdi],esi
       inc       dword ptr [r12+34]
       jmp       near ptr M00_L06
M00_L14:
       mov       r10,[rbp-108]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-108],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-138],r8
       mov       [rbp-88],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L15:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r10,[rbp-108]
       mov       [rbp-84],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L29
       test      r8d,r8d
       mov       eax,[rbp-88]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       [rbp-88],eax
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104CF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CA7B10]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r12+8]
       mov       edx,[rbp-88]
       mov       eax,edx
       imul      rax,[r12+20]
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
       mov       [rbp-118],rax
       mov       eax,edx
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,[r12+2C]
       mov       r8d,ecx
       dec       dword ptr [r12+30]
       mov       r11,[rbp-108]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L30
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L13
M00_L18:
       call      qword ptr [7FF9104CFC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-100]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-100]
       mov       r11,7FF9104117B0
       call      qword ptr [r11]
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CA7918]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L10
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-178],r9
       mov       r11,[r8+10]
       mov       [rbp-180],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9104049D0]
       test      eax,eax
       mov       r8,[rbp-138]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104117C0
       call      qword ptr [r11]
       mov       r8,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L11
M00_L23:
       mov       r11,[rbp-108]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L30
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-108],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-120],r9
       mov       [rbp-88],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104117C8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-120]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r11,[rbp-108]
       cmp       [r11+8],ecx
       jb        short M00_L29
       test      r9d,r9d
       mov       [rbp-108],r11
       mov       [rbp-84],ecx
       mov       eax,[rbp-88]
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
       mov       r11,7FF9104117A8
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L39
M00_L29:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r13d,r13d
       jmp       near ptr M00_L69
M00_L32:
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910BAE7F0]
       int       3
M00_L33:
       call      qword ptr [7FF910CA7690]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L34
       call      qword ptr [7FF910D77600]
       mov       r13,rax
M00_L34:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF910837DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       r8,rsi
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      qword ptr [7FF910CA78E8]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,r12
       mov       rdx,rsi
       call      qword ptr [7FF910CA7900]
       jmp       near ptr M00_L41
M00_L36:
       mov       rcx,r14
       mov       r11,7FF910411798
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L37:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AE9D400B20
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L38:
       mov       rcx,r14
       mov       r11,7FF9104117A0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L40
       mov       rcx,rax
       mov       r11,7FF9104117B8
       call      qword ptr [r11]
M00_L40:
       cmp       dword ptr [r12+28],0
       jle       short M00_L41
       mov       rax,[r12+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r12+28]
       cmp       eax,3
       jle       short M00_L41
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r12
       call      qword ptr [7FF910D77618]
M00_L41:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L44
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L42
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       mov       [rbp-0B8],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L43
M00_L42:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AE9D400B20
       mov       rdx,[rcx]
M00_L43:
       mov       rcx,rdx
       jmp       short M00_L45
M00_L44:
       mov       rcx,r15
       mov       r11,7FF910411770
       call      qword ptr [r11]
       mov       rcx,rax
M00_L45:
       mov       [rbp-0F0],rcx
M00_L46:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       near ptr M00_L64
       jmp       near ptr M00_L63
M00_L47:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       short M00_L48
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L49
M00_L48:
       lea       rdx,[rbp-48]
       mov       r11,7FF910411780
       call      qword ptr [r11]
       mov       rcx,[rbp-0F0]
M00_L49:
       mov       rsi,[rbp-48]
       mov       rdi,[rbp-40]
       cmp       qword ptr [r12+8],0
       jne       short M00_L50
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CA7918]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-0F0]
M00_L50:
       mov       r15,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-150],rax
       xor       edx,edx
       mov       [rbp-0BC],edx
       test      rax,rax
       jne       near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-168]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-168]
       call      qword ptr [7FF9104049D8]; System.ValueType.GetHashCode()
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CA7A50]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        near ptr M00_L53
M00_L51:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r15+rdx*8+10]
       mov       [rbp-170],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L52
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       rdx,[rbp-0D8]
       lea       r8,[rbp-0E8]
       mov       rcx,2AE9D400A08
       mov       rcx,[rcx]
       call      qword ptr [7FF910CD7AD0]
       test      eax,eax
       mov       r10,[rbp-170]
       jne       near ptr M00_L46
M00_L52:
       mov       r10d,[r10+4]
       mov       edx,[rbp-0BC]
       inc       edx
       mov       [rbp-0BC],edx
       cmp       [r15+8],edx
       jb        near ptr M00_L66
       test      r10d,r10d
       jge       near ptr M00_L51
M00_L53:
       cmp       dword ptr [r12+30],0
       jle       near ptr M00_L58
       jmp       near ptr M00_L57
M00_L54:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,rax
       mov       r11,7FF9104117D0
       call      qword ptr [r11]
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CA7A50]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        short M00_L53
M00_L55:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       r8d,r10d
       lea       r8,[r8+r8*2]
       lea       r10,[r15+r8*8+10]
       mov       [rbp-160],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L56
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-150]
       mov       r11,7FF9104117D8
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-160]
       jne       near ptr M00_L46
M00_L56:
       mov       r10d,[r10+4]
       mov       ecx,[rbp-0BC]
       inc       ecx
       cmp       [r15+8],ecx
       jb        near ptr M00_L66
       test      r10d,r10d
       mov       [rbp-0BC],ecx
       jge       near ptr M00_L55
       jmp       near ptr M00_L53
M00_L57:
       mov       r13d,[r12+2C]
       dec       dword ptr [r12+30]
       mov       ecx,[r12+2C]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L67
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r15+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       jmp       short M00_L60
M00_L58:
       mov       r13d,[r12+28]
       cmp       [r15+8],r13d
       jne       short M00_L59
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104CF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CA7B10]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r12
       mov       edx,[rbp-0C0]
       call      qword ptr [7FF910CA7A50]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r15,rax
       mov       [rbp-158],r15
M00_L59:
       lea       ecx,[r13+1]
       mov       [r12+28],ecx
       mov       r15,[r12+10]
M00_L60:
       cmp       r13d,[r15+8]
       jae       near ptr M00_L67
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r15+rcx*8+10]
       mov       r9d,[rbp-0C0]
       mov       [r15],r9d
       mov       rax,[rbp-158]
       mov       ecx,[rax]
       dec       ecx
       mov       [r15+4],ecx
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       r15,[rbp-158]
       mov       [r15],r13d
       inc       dword ptr [r12+34]
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       short M00_L61
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       call      qword ptr [7FF91050ABC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       short M00_L62
M00_L61:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       mov       r11,7FF910411788
       call      qword ptr [r11]
M00_L62:
       mov       r13d,1
       jmp       near ptr M00_L46
M00_L63:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91083C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L65
M00_L64:
       mov       r11,7FF910411778
       call      qword ptr [r11]
M00_L65:
       test      eax,eax
       jne       near ptr M00_L47
       jmp       short M00_L68
M00_L66:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L69
       mov       rcx,rax
       mov       r11,7FF910411790
       call      qword ptr [r11]
M00_L69:
       mov       [rbp-0C8],r13b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0C8]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA7B28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-0F0],0
       je        short M00_L70
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L70
       mov       rcx,rax
       mov       r11,7FF910411790
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-100],0
       je        short M00_L71
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L71
       mov       rcx,rax
       mov       r11,7FF9104117B8
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,28
       ret
; Total bytes of code 3648
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
       mov       rcx,7FF96F2D0B08
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
       call      qword ptr [7FF910CAEEF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910835EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF910CADE48]
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
       je        near ptr M03_L04
       cmp       edx,1
       jne       near ptr M03_L24
       mov       [rbp-44],ecx
M03_L01:
       mov       rcx,[rdi+20]
       mov       r15d,[rcx]
       test      r15b,2
       je        short M03_L05
       test      r15b,4
       je        near ptr M03_L08
M03_L02:
       mov       rcx,rdi
       call      00007FF9701427D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D763D0]
       jmp       near ptr M03_L17
M03_L03:
       rorx      edx,[rbp-58],1F
       rorx      r8d,[rbp-54],19
       add       edx,r8d
       rorx      r8d,[rbp-50],14
       add       edx,r8d
       rorx      r8d,[rbp-4C],0E
       add       edx,r8d
       jmp       near ptr M03_L18
M03_L04:
       mov       [rbp-48],ecx
       jmp       short M03_L01
M03_L05:
       mov       rcx,rdi
       mov       rax,7FF9104048F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L06]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF97013B1D0
       call      rax
M03_L06:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L07
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M03_L07:
       mov       r9,[rbp-0A8]
       mov       [rsi+8],r9
       test      eax,eax
       jne       near ptr M03_L02
M03_L08:
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
       mov       rax,7FF910404938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L09]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF970162B70
       call      rax
M03_L09:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L10
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M03_L10:
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
       mov       edx,0BB9C82CA
       mov       r8d,2DEBDEBA
       cmp       ecx,8
       jb        short M03_L12
       mov       r10d,ecx
       shr       r10d,3
M03_L11:
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
       jne       short M03_L11
       test      cl,4
       je        short M03_L14
       jmp       short M03_L13
M03_L12:
       cmp       ecx,4
       jb        near ptr M03_L20
M03_L13:
       add       edx,[rax]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
M03_L14:
       mov       r10d,ecx
       and       r10,7
       mov       eax,[rax+r10-4]
       shr       eax,8
       or        eax,80000000
       not       ecx
       shl       ecx,3
       shrx      ecx,eax,ecx
M03_L15:
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
M03_L16:
       mov       ecx,[rbp-3C]
       lea       edx,[rcx+1]
       mov       [rbp-3C],edx
       mov       edx,ecx
       and       edx,3
       je        near ptr M03_L23
       cmp       edx,1
       jne       near ptr M03_L29
       mov       [rbp-44],eax
M03_L17:
       mov       eax,[rbp-3C]
       mov       ecx,eax
       and       ecx,3
       cmp       eax,4
       jae       near ptr M03_L03
       mov       edx,9CEADBB0
M03_L18:
       lea       eax,[rdx+rax*4]
       test      ecx,ecx
       je        short M03_L19
       imul      edx,[rbp-48],0C2B2AE3D
       add       eax,edx
       rol       eax,11
       imul      eax,27D4EB2F
       cmp       ecx,1
       jbe       short M03_L19
       imul      edx,[rbp-44],0C2B2AE3D
       add       edx,eax
       rol       edx,11
       imul      eax,edx,27D4EB2F
       cmp       ecx,2
       ja        near ptr M03_L36
M03_L19:
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
M03_L20:
       mov       r10d,80
       test      cl,1
       je        short M03_L21
       mov       r10d,ecx
       and       r10,2
       movzx     r10d,byte ptr [rax+r10]
       or        r10d,8000
M03_L21:
       test      cl,2
       jne       short M03_L22
       mov       ecx,r10d
       jmp       near ptr M03_L15
M03_L22:
       shl       r10d,10
       movzx     ecx,word ptr [rax]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M03_L15
M03_L23:
       mov       [rbp-48],eax
       jmp       near ptr M03_L17
M03_L24:
       cmp       edx,2
       jne       short M03_L25
       mov       [rbp-40],ecx
       jmp       near ptr M03_L01
M03_L25:
       cmp       eax,3
       jne       short M03_L26
       mov       dword ptr [rbp-58],0AAB7B827
       mov       dword ptr [rbp-54],0C803E76
       mov       dword ptr [rbp-50],869473FF
       mov       dword ptr [rbp-4C],0E85CFA4E
M03_L26:
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
M03_L27:
       cmp       eax,4
       ja        near ptr M03_L17
       mov       edx,eax
       lea       rcx,[7FF910DFFE58]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M03_L00]
       add       rcx,rax
       jmp       rcx
M03_L28:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L16
M03_L29:
       cmp       edx,2
       jne       short M03_L30
       mov       [rbp-40],eax
       jmp       near ptr M03_L17
M03_L30:
       cmp       ecx,3
       jne       short M03_L31
       mov       dword ptr [rbp-58],0AAB7B827
       mov       dword ptr [rbp-54],0C803E76
       mov       dword ptr [rbp-50],869473FF
       mov       dword ptr [rbp-4C],0E85CFA4E
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
       jmp       near ptr M03_L17
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L17
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L17
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910D763D0]
       jmp       near ptr M03_L17
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF910D76DF0]
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
       call      qword ptr [7FF9108DD968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L17
M03_L36:
       imul      ecx,[rbp-40],0C2B2AE3D
       add       ecx,eax
       rol       ecx,11
       imul      eax,ecx,27D4EB2F
       jmp       near ptr M03_L19
; Total bytes of code 1624
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       ecx,edx
       jmp       qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
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
       mov       rdx,7FF910CE2FF8
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L00
M05_L07:
       mov       rcx,rax
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF910A6F078]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF910BA4840]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF910BA4840]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF910BA4858]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910CE2FF8
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF9104C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M08_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       cmp       [rcx],ecx
       mov       rbx,[rdx]
       mov       rdx,[rdx+8]
       mov       [rbp-70],rdx
       mov       [rbp-78],rbx
       test      rbx,rbx
       je        near ptr M09_L15
       cmp       qword ptr [rcx+8],0
       je        near ptr M09_L16
M09_L00:
       mov       rdx,[rcx+10]
       mov       [rbp-80],rdx
       mov       rdx,[rcx+18]
       mov       [rbp-88],rdx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        near ptr M09_L14
M09_L01:
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-88]
       cmp       [rdx],r8
       jne       near ptr M09_L18
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       r8d,[rbx+8]
       mov       [rbp-4C],r8d
       lea       r8,[rbx+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M09_L03
M09_L02:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       short M09_L04
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
       jg        short M09_L02
M09_L03:
       cmp       dword ptr [rbp-4C],0
       jle       near ptr M09_L13
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M09_L04
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
       jmp       near ptr M09_L13
M09_L04:
       call      M09_L29
       nop
       mov       rbx,[rbp-78]
       mov       r8d,[rbx+8]
       sub       r8d,[rbp-4C]
       cmp       [rbx+8],r8d
       jb        near ptr M09_L17
       mov       edx,r8d
       lea       rdx,[rbx+rdx*2+0C]
       mov       ecx,[rbx+8]
       sub       ecx,r8d
       mov       [rbp-68],rdx
       mov       [rbp-60],ecx
       lea       r8,[rbp-68]
       mov       edx,[rbp-48]
       mov       ecx,[rbp-44]
       call      qword ptr [7FF910CAF9D8]
       mov       rdx,[rbp-88]
M09_L05:
       mov       esi,eax
M09_L06:
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       r8d,esi
       imul      r8,[rcx+30]
       shr       r8,20
       inc       r8
       mov       r10d,[rax+8]
       mov       r9d,r10d
       imul      r8,r9
       shr       r8,20
       cmp       r8d,r10d
       jae       near ptr M09_L28
       mov       r8d,r8d
       lea       r14,[rax+r8*4+10]
       mov       r15d,[r14]
       dec       r15d
       mov       rax,[rbp-80]
       mov       r13d,[rax+8]
       cmp       r13d,r15d
       jbe       short M09_L09
M09_L07:
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r12,[rax+r8*8+10]
       cmp       [r12+10],esi
       je        near ptr M09_L19
M09_L08:
       mov       r15d,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M09_L24
       cmp       r13d,r15d
       ja        short M09_L07
M09_L09:
       cmp       dword ptr [rcx+40],0
       jg        near ptr M09_L25
       mov       r15d,[rcx+38]
       cmp       r13d,r15d
       je        near ptr M09_L26
M09_L10:
       lea       eax,[r15+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-80],rax
M09_L11:
       mov       rax,[rbp-80]
       cmp       r15d,[rax+8]
       jae       near ptr M09_L28
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+44]
       cmp       edi,64
       ja        near ptr M09_L27
M09_L12:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L13:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
       jmp       near ptr M09_L05
M09_L14:
       mov       rcx,rdx
       mov       rdx,7FF910D28D30
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L01
M09_L15:
       mov       ecx,4
       call      qword ptr [7FF9104CFD50]
       int       3
M09_L16:
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M09_L00
M09_L17:
       mov       ecx,21
       call      qword ptr [7FF9104CF360]
       int       3
M09_L18:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L06
M09_L19:
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+80]
       test      r11,r11
       je        short M09_L20
       jmp       short M09_L21
M09_L20:
       mov       rcx,rax
       mov       rdx,7FF910D28D48
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L21:
       mov       rdx,[rbp-80]
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*2]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-88]
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-88]
       je        near ptr M09_L08
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        short M09_L22
       jmp       short M09_L23
M09_L22:
       mov       rcx,rdx
       mov       rdx,7FF910D28D60
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M09_L23:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9104CFD20]
       int       3
M09_L24:
       call      qword ptr [7FF9104CF498]
       int       3
M09_L25:
       mov       eax,[rcx+3C]
       mov       r15d,eax
       cmp       eax,r13d
       jae       near ptr M09_L28
       mov       r8,[rbp-80]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M09_L11
M09_L26:
       call      qword ptr [7FF910CAF210]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,esi
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       short M09_L28
       mov       eax,eax
       lea       r14,[rdx+rax*4+10]
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L10
M09_L27:
       mov       rdx,[rbp-88]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L12
       mov       rdx,[rbp-80]
       mov       edx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8d,1
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M09_L12
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L29:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1144
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
       jne       short M10_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M10_L03
M10_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M10_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M10_L02
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
M10_L01:
       call      qword ptr [7FF9104CFC60]
       int       3
M10_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M10_L00
M10_L03:
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
M10_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
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
       sub       rsp,168
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       r14,[rbx+278]
       mov       r15,[rbx+280]
       test      r15,r15
       je        near ptr M00_L31
       test      r14,r14
       je        near ptr M00_L32
       mov       rcx,r14
       mov       rax,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>[]
       cmp       [rcx],rax
       je        short M00_L00
       xor       ecx,ecx
M00_L00:
       test      rcx,rcx
       jne       near ptr M00_L33
       xor       r13d,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L35
M00_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L36
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
M00_L02:
       test      ecx,ecx
       jle       short M00_L03
       call      qword ptr [7FF9104D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [r12+2C],0FFFFFFFF
       lea       rcx,[r12+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r12+20],rax
M00_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L38
       mov       ecx,[r14+38]
       sub       ecx,[r14+40]
       je        near ptr M00_L37
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r14+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       [rbp-80],r14
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-80]
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
       mov       [rbp-100],rcx
M00_L06:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       jne       near ptr M00_L27
       lea       rsi,[rax+8]
       mov       ecx,[rsi+8]
       mov       rdx,[rsi]
       cmp       ecx,[rdx+44]
       jne       near ptr M00_L18
       mov       rax,[rbp-100]
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
       mov       rcx,[rbp-100]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L09:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       cmp       qword ptr [r12+8],0
       je        near ptr M00_L20
M00_L10:
       mov       rax,[r12+10]
       mov       [rbp-108],rax
       mov       rdx,[r12+18]
       mov       [rbp-110],rdx
       xor       r8d,r8d
       mov       [rbp-84],r8d
       test      rdx,rdx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-130],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-130]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-130]
       call      qword ptr [7FF9104149D8]; System.ValueType.GetHashCode()
       mov       rcx,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],rdx
       mov       r8d,[rdx]
       dec       r8d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r12+30],0
       jg        near ptr M00_L17
       mov       r8d,[r12+28]
       mov       [rbp-8C],r8d
       mov       r11,[rbp-108]
       cmp       [r11+8],r8d
       je        near ptr M00_L16
M00_L12:
       mov       r8d,[rbp-8C]
       lea       ecx,[r8+1]
       mov       [r12+28],ecx
       mov       r11,[r12+10]
       mov       rcx,r11
M00_L13:
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L30
       mov       [rbp-90],r8d
       mov       r10d,r8d
       lea       r10,[r10+r10*2]
       lea       r10,[rcx+r10*8+10]
       mov       [rbp-128],r10
       mov       [r10],eax
       mov       rdx,[rbp-118]
       mov       ecx,[rdx]
       dec       ecx
       mov       [r10+4],ecx
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-128]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbp-90]
       inc       esi
       mov       rdi,[rbp-118]
       mov       [rdi],esi
       inc       dword ptr [r12+34]
       jmp       near ptr M00_L06
M00_L14:
       mov       r10,[rbp-108]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L30
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-108],r10
       lea       r8,[r10+rcx*8+10]
       mov       [rbp-138],r8
       mov       [rbp-88],eax
       cmp       [r8],eax
       je        near ptr M00_L21
M00_L15:
       mov       r8d,[r8+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r10,[rbp-108]
       mov       [rbp-84],ecx
       cmp       [r10+8],ecx
       jb        near ptr M00_L29
       test      r8d,r8d
       mov       eax,[rbp-88]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       [rbp-88],eax
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104DF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CFE880]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r12+8]
       mov       edx,[rbp-88]
       mov       eax,edx
       imul      rax,[r12+20]
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
       mov       [rbp-118],rax
       mov       eax,edx
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,[r12+2C]
       mov       r8d,ecx
       dec       dword ptr [r12+30]
       mov       r11,[rbp-108]
       cmp       ecx,[r11+8]
       jae       near ptr M00_L30
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r11+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       mov       rcx,r11
       jmp       near ptr M00_L13
M00_L18:
       call      qword ptr [7FF9104DFC60]
       int       3
M00_L19:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-100]
       cmp       [rcx],rdx
       je        near ptr M00_L08
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-100]
       mov       r11,7FF9104217E0
       call      qword ptr [r11]
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L09
M00_L20:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CFE688]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-100]
       jmp       near ptr M00_L10
M00_L21:
       mov       r9,[r8+8]
       mov       [rbp-178],r9
       mov       r11,[r8+10]
       mov       [rbp-180],r11
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-178]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-140]
       call      qword ptr [7FF9104149D0]
       test      eax,eax
       mov       r8,[rbp-138]
       je        near ptr M00_L15
       jmp       near ptr M00_L06
M00_L22:
       vmovdqu   xmm0,xmmword ptr [rbp-58]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104217F0
       call      qword ptr [r11]
       mov       r8,[r12+8]
       mov       edx,eax
       imul      rdx,[r12+20]
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
       mov       [rbp-118],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M00_L11
M00_L23:
       mov       r11,[rbp-108]
       cmp       r9d,[r11+8]
       jae       near ptr M00_L30
       mov       r8d,r9d
       lea       r8,[r8+r8*2]
       mov       [rbp-108],r11
       lea       r9,[r11+r8*8+10]
       mov       [rbp-120],r9
       mov       [rbp-88],eax
       cmp       [r9],eax
       jne       short M00_L24
       vmovdqu   xmm0,xmmword ptr [r9+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-110]
       mov       r11,7FF9104217F8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-120]
       jne       near ptr M00_L06
M00_L24:
       mov       r9d,[r9+4]
       mov       ecx,[rbp-84]
       inc       ecx
       mov       r11,[rbp-108]
       cmp       [r11+8],ecx
       jb        short M00_L29
       test      r9d,r9d
       mov       [rbp-108],r11
       mov       [rbp-84],ecx
       mov       eax,[rbp-88]
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
       mov       r11,7FF9104217D8
       call      qword ptr [r11]
       mov       ecx,eax
M00_L28:
       test      ecx,ecx
       jne       near ptr M00_L19
       jmp       near ptr M00_L39
M00_L29:
       call      qword ptr [7FF9104DF498]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       xor       r13d,r13d
       jmp       near ptr M00_L69
M00_L32:
       mov       ecx,65
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rcx,rax
       call      qword ptr [7FF910BB5500]
       int       3
M00_L33:
       call      qword ptr [7FF910CFE3E8]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L34
       call      qword ptr [7FF910E077C8]
       mov       r13,rax
M00_L34:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF910847DB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       r8,rsi
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      qword ptr [7FF910CFE658]
       test      eax,eax
       je        near ptr M00_L01
       mov       rcx,r12
       mov       rdx,rsi
       call      qword ptr [7FF910CFE670]
       jmp       near ptr M00_L41
M00_L36:
       mov       rcx,r14
       mov       r11,7FF9104217C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L02
M00_L37:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B34C400B78
       mov       rdx,[rcx]
       jmp       near ptr M00_L04
M00_L38:
       mov       rcx,r14
       mov       r11,7FF9104217D0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L40
       mov       rcx,rax
       mov       r11,7FF9104217E8
       call      qword ptr [r11]
M00_L40:
       cmp       dword ptr [r12+28],0
       jle       short M00_L41
       mov       rax,[r12+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r12+28]
       cmp       eax,3
       jle       short M00_L41
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r12
       call      qword ptr [7FF910E077E0]
M00_L41:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L44
       mov       ecx,[r15+38]
       sub       ecx,[r15+40]
       je        short M00_L42
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[r15+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       mov       [rbp-0B8],r15
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       jmp       short M00_L43
M00_L42:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B34C400B78
       mov       rdx,[rcx]
M00_L43:
       mov       rcx,rdx
       jmp       short M00_L45
M00_L44:
       mov       rcx,r15
       mov       r11,7FF9104217A0
       call      qword ptr [r11]
       mov       rcx,rax
M00_L45:
       mov       [rbp-0F0],rcx
M00_L46:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       near ptr M00_L64
       jmp       near ptr M00_L63
M00_L47:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-0F0]
       cmp       [rcx],rdx
       jne       short M00_L48
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       jmp       short M00_L49
M00_L48:
       lea       rdx,[rbp-48]
       mov       r11,7FF9104217B0
       call      qword ptr [r11]
       mov       rcx,[rbp-0F0]
M00_L49:
       mov       rsi,[rbp-48]
       mov       rdi,[rbp-40]
       cmp       qword ptr [r12+8],0
       jne       short M00_L50
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF910CFE688]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-0F0]
M00_L50:
       mov       r15,[r12+10]
       mov       rax,[r12+18]
       mov       [rbp-150],rax
       xor       edx,edx
       mov       [rbp-0BC],edx
       test      rax,rax
       jne       near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       lea       rcx,[rax+8]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-168]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-168]
       call      qword ptr [7FF9104149D8]; System.ValueType.GetHashCode()
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CFE7C0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        near ptr M00_L53
M00_L51:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r10,[r15+rdx*8+10]
       mov       [rbp-170],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L52
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       rdx,[rbp-0D8]
       lea       r8,[rbp-0E8]
       mov       rcx,2B34C400AC0
       mov       rcx,[rcx]
       call      qword ptr [7FF910D56CE8]
       test      eax,eax
       mov       r10,[rbp-170]
       jne       near ptr M00_L46
M00_L52:
       mov       r10d,[r10+4]
       mov       edx,[rbp-0BC]
       inc       edx
       mov       [rbp-0BC],edx
       cmp       [r15+8],edx
       jb        near ptr M00_L66
       test      r10d,r10d
       jge       near ptr M00_L51
M00_L53:
       cmp       dword ptr [r12+30],0
       jle       near ptr M00_L58
       jmp       near ptr M00_L57
M00_L54:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,rax
       mov       r11,7FF910421800
       call      qword ptr [r11]
       mov       rcx,r12
       mov       [rbp-0C0],eax
       mov       edx,eax
       call      qword ptr [7FF910CFE7C0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       [rbp-158],rax
       mov       r10d,[rax]
       dec       r10d
       js        short M00_L53
M00_L55:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L67
       mov       r8d,r10d
       lea       r8,[r8+r8*2]
       lea       r10,[r15+r8*8+10]
       mov       [rbp-160],r10
       mov       r9d,[rbp-0C0]
       cmp       [r10],r9d
       jne       short M00_L56
       vmovdqu   xmm0,xmmword ptr [r10+8]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       mov       [rbp-0E8],rsi
       mov       [rbp-0E0],rdi
       lea       r8,[rbp-0E8]
       lea       rdx,[rbp-0D8]
       mov       rcx,[rbp-150]
       mov       r11,7FF910421808
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-160]
       jne       near ptr M00_L46
M00_L56:
       mov       r10d,[r10+4]
       mov       ecx,[rbp-0BC]
       inc       ecx
       cmp       [r15+8],ecx
       jb        near ptr M00_L66
       test      r10d,r10d
       mov       [rbp-0BC],ecx
       jge       near ptr M00_L55
       jmp       near ptr M00_L53
M00_L57:
       mov       r13d,[r12+2C]
       dec       dword ptr [r12+30]
       mov       ecx,[r12+2C]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L67
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r15+rcx*8+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r12+2C],ecx
       jmp       short M00_L60
M00_L58:
       mov       r13d,[r12+28]
       cmp       [r15+8],r13d
       jne       short M00_L59
       mov       ecx,[r12+28]
       call      qword ptr [7FF9104DF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF910CFE880]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r12
       mov       edx,[rbp-0C0]
       call      qword ptr [7FF910CFE7C0]; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r15,rax
       mov       [rbp-158],r15
M00_L59:
       lea       ecx,[r13+1]
       mov       [r12+28],ecx
       mov       r15,[r12+10]
M00_L60:
       cmp       r13d,[r15+8]
       jae       near ptr M00_L67
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r15+rcx*8+10]
       mov       r9d,[rbp-0C0]
       mov       [r15],r9d
       mov       rax,[rbp-158]
       mov       ecx,[rax]
       dec       ecx
       mov       [r15+4],ecx
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       r15,[rbp-158]
       mov       [r15],r13d
       inc       dword ptr [r12+34]
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       short M00_L61
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       call      qword ptr [7FF91051ABC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       short M00_L62
M00_L61:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       lea       rdx,[rbp-0D8]
       mov       rcx,r14
       mov       r11,7FF9104217B8
       call      qword ptr [r11]
M00_L62:
       mov       r13d,1
       jmp       near ptr M00_L46
M00_L63:
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91084C000]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M00_L65
M00_L64:
       mov       r11,7FF9104217A8
       call      qword ptr [r11]
M00_L65:
       test      eax,eax
       jne       near ptr M00_L47
       jmp       short M00_L68
M00_L66:
       call      qword ptr [7FF9104DF498]
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L69
       mov       rcx,rax
       mov       r11,7FF9104217C0
       call      qword ptr [r11]
M00_L69:
       mov       [rbp-0C8],r13b
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0C8]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CFE898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,168
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-0F0],0
       je        short M00_L70
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-0F0]
       cmp       [rax],rcx
       je        short M00_L70
       mov       rcx,rax
       mov       r11,7FF9104217C0
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-100],0
       je        short M00_L71
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M00_L71
       mov       rcx,rax
       mov       r11,7FF9104217E8
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,28
       ret
; Total bytes of code 3648
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
       mov       rcx,7FF96F2D0B08
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
       call      qword ptr [7FF910BBF2A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910845EC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF910BBF2B8]
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
       mov       rax,7FF9104148F8
       mov       [rbp-0A0],rax
       lea       rax,[M03_L04]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF97013B1D0
       call      rax
M03_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L05
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rax,7FF910414938
       mov       [rbp-0A0],rax
       lea       rax,[M03_L07]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF970162B70
       call      rax
M03_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L08
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       edx,22CD86DF
       mov       r8d,57DFD55B
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
       mov       edx,0B7CC973A
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
       mov       dword ptr [rbp-58],0C59973B1
       mov       dword ptr [rbp-54],2761FA00
       mov       dword ptr [rbp-50],0A1762F89
       mov       dword ptr [rbp-4C],33EB5D8
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
       call      00007FF9701427D0
       mov       r14,[rbp-0C8]
       mov       [rbp-0C0],r14
       mov       [rbp-0B8],eax
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910E066A0]
       jmp       near ptr M03_L15
M03_L26:
       cmp       eax,4
       ja        near ptr M03_L15
       mov       edx,eax
       lea       rcx,[7FF910DAD8F8]
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
       mov       dword ptr [rbp-58],0C59973B1
       mov       dword ptr [rbp-54],2761FA00
       mov       dword ptr [rbp-50],0A1762F89
       mov       dword ptr [rbp-4C],33EB5D8
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
       call      qword ptr [7FF9108ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF9108ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       ecx,[rbp-70]
       mov       [rbp-0C0],rdx
       mov       [rbp-0B8],ecx
       lea       rdx,[rbp-0C0]
       lea       rcx,[rbp-58]
       call      qword ptr [7FF910E066A0]
       jmp       near ptr M03_L15
       mov       edx,[rbp-68]
       add       rdx,[rbp-0C8]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF910E06850]
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
       call      qword ptr [7FF9108ED968]; System.HashCode.Add[[System.Int32, System.Private.CoreLib]](Int32)
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
       jmp       qword ptr [7FF9104D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
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
       mov       rdx,7FF910D61098
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF910B06628]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L12:
       mov       rcx,rax
       call      qword ptr [7FF9104D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L01
M05_L13:
       xor       r15d,r15d
       jmp       short M05_L15
M05_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF910BB4840]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M05_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF910BB4840]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FF910BB4858]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FF9104D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D61098
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 167
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF9104D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.HashSet`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].GetBucketRef(Int32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M08_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       cmp       [rcx],ecx
       mov       rbx,[rdx]
       mov       rdx,[rdx+8]
       mov       [rbp-70],rdx
       mov       [rbp-78],rbx
       test      rbx,rbx
       je        near ptr M09_L14
       cmp       qword ptr [rcx+8],0
       je        near ptr M09_L15
M09_L00:
       mov       rdx,[rcx+10]
       mov       [rbp-80],rdx
       mov       rdx,[rcx+18]
       mov       [rbp-88],rdx
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+70]
       test      r11,r11
       je        near ptr M09_L13
M09_L01:
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-88]
       cmp       [rdx],r8
       jne       near ptr M09_L18
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       r8d,[rbx+8]
       mov       [rbp-4C],r8d
       lea       r8,[rbx+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M09_L03
M09_L02:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       near ptr M09_L16
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
       jg        short M09_L02
M09_L03:
       cmp       dword ptr [rbp-4C],0
       jle       short M09_L04
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       near ptr M09_L16
       rorx      eax,[rbp-48],1B
       add       eax,[rbp-48]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-48],r8d
M09_L04:
       xor       r11d,r11d
       mov       [rbp-58],r11
       imul      eax,[rbp-48],5D588B65
       add       eax,[rbp-44]
M09_L05:
       mov       esi,eax
M09_L06:
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       r8d,esi
       imul      r8,[rcx+30]
       shr       r8,20
       inc       r8
       mov       r10d,[rax+8]
       mov       r9d,r10d
       imul      r8,r9
       shr       r8,20
       cmp       r8d,r10d
       jae       near ptr M09_L28
       mov       r8d,r8d
       lea       r14,[rax+r8*4+10]
       mov       r15d,[r14]
       dec       r15d
       mov       rax,[rbp-80]
       mov       r13d,[rax+8]
       cmp       r13d,r15d
       ja        near ptr M09_L11
M09_L07:
       cmp       dword ptr [rcx+40],0
       jg        near ptr M09_L25
       mov       r15d,[rcx+38]
       cmp       r13d,r15d
       je        near ptr M09_L26
M09_L08:
       lea       eax,[r15+1]
       mov       [rcx+38],eax
       mov       rax,[rcx+10]
       mov       [rbp-80],rax
M09_L09:
       mov       rax,[rbp-80]
       cmp       r15d,[rax+8]
       jae       near ptr M09_L28
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],esi
       mov       eax,[r14]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14],r15d
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+44]
       cmp       edi,64
       ja        near ptr M09_L27
M09_L10:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L11:
       mov       rax,[rbp-80]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r12,[rax+r8*8+10]
       cmp       [r12+10],esi
       je        near ptr M09_L19
M09_L12:
       mov       r15d,[r12+14]
       inc       edi
       cmp       r13d,edi
       jb        near ptr M09_L24
       cmp       r13d,r15d
       ja        short M09_L11
       jmp       near ptr M09_L07
M09_L13:
       mov       rcx,rax
       mov       rdx,7FF910CBAF60
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L01
M09_L14:
       mov       ecx,4
       call      qword ptr [7FF9104DFD50]
       int       3
M09_L15:
       xor       edx,edx
       call      qword ptr [7FF9104D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M09_L00
M09_L16:
       call      M09_L29
       nop
       mov       rbx,[rbp-78]
       mov       r8d,[rbx+8]
       sub       r8d,[rbp-4C]
       cmp       [rbx+8],r8d
       jae       short M09_L17
       mov       ecx,21
       call      qword ptr [7FF9104DF360]
       int       3
M09_L17:
       mov       edx,r8d
       lea       rdx,[rbx+rdx*2+0C]
       mov       ecx,[rbx+8]
       sub       ecx,r8d
       mov       [rbp-68],rdx
       mov       [rbp-60],ecx
       lea       r8,[rbp-68]
       mov       edx,[rbp-48]
       mov       ecx,[rbp-44]
       call      qword ptr [7FF910E04840]
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L05
M09_L18:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L06
M09_L19:
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+78]
       test      r11,r11
       je        short M09_L20
       jmp       short M09_L21
M09_L20:
       mov       rcx,rax
       mov       rdx,7FF910CBAF78
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L21:
       mov       rdx,[rbp-80]
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*2]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-88]
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-88]
       je        near ptr M09_L12
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M09_L22
       jmp       short M09_L23
M09_L22:
       mov       rcx,rdx
       mov       rdx,7FF910CBAF90
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M09_L23:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9104DFD20]
       int       3
M09_L24:
       call      qword ptr [7FF9104DF498]
       int       3
M09_L25:
       mov       eax,[rcx+3C]
       mov       r15d,eax
       cmp       eax,r13d
       jae       near ptr M09_L28
       mov       r8,[rbp-80]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rcx+3C],eax
       dec       dword ptr [rcx+40]
       jmp       near ptr M09_L09
M09_L26:
       call      qword ptr [7FF910BBF720]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       mov       eax,esi
       imul      rax,[rcx+30]
       shr       rax,20
       inc       rax
       mov       r8d,[rdx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       short M09_L28
       mov       eax,eax
       lea       r14,[rdx+rax*4+10]
       mov       rdx,[rbp-88]
       jmp       near ptr M09_L08
M09_L27:
       mov       rdx,[rbp-88]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M09_L10
       mov       rdx,[rbp-80]
       mov       edx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8d,1
       call      qword ptr [7FF9107673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M09_L10
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L29:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-58],r8
       add       rsp,28
       ret
; Total bytes of code 1145
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
       jne       short M10_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M10_L03
M10_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M10_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M10_L02
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
M10_L01:
       call      qword ptr [7FF9104DFC60]
       int       3
M10_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M10_L00
M10_L03:
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
M10_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
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
       call      qword ptr [7FF910CB55F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108D78D0]; Precode of DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CB55F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CCAFC0
       call      qword ptr [7FF910CB5590]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF910CCB0D8
       call      qword ptr [7FF910CB55C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       je        short M02_L00
       mov       rax,[rbp-70]
       mov       [rbp-28],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAB308
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M02_L01:
       mov       rax,29ED4B51640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,29ED4B50008
       call      qword ptr [7FF910A7F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M02_L02
       mov       rax,[rbp-78]
       mov       [rbp-30],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAB340
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M02_L03:
       mov       rax,29ED4B59F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,29ED4B50008
       call      qword ptr [7FF910A7F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        short M02_L04
       mov       rax,[rbp-80]
       mov       [rbp-38],rax
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAB580
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M02_L05:
       mov       rax,29ED4B5FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,29ED4B50008
       call      qword ptr [7FF910A7F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-88],rax
       cmp       qword ptr [rbp-88],0
       je        short M02_L06
       mov       rax,[rbp-88]
       mov       [rbp-40],rax
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAB5A8
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M02_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF910E1B5E0
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
       jne       near ptr M02_L10
       mov       rcx,7FF910E1B6E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       cmp       qword ptr [rax+10],38
       jle       short M02_L08
       mov       rax,[rbp-90]
       mov       rax,[rax+38]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-98],0
       je        short M02_L08
       mov       rax,[rbp-98]
       mov       [rbp-48],rax
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CAB648
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M02_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF910E1B6F0
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
M02_L10:
       mov       rcx,7FF910E1B7F8
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF910CAB7C0
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CB5728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CB56E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF910CA55F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108C78D0]; Precode of DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA55F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CBAFC0
       call      qword ptr [7FF910CA5590]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF910CBB0D8
       call      qword ptr [7FF910CA55C0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       je        short M02_L00
       mov       rax,[rbp-70]
       mov       [rbp-28],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C9B308
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M02_L01:
       mov       rax,1B72E961640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,1B72E960008
       call      qword ptr [7FF910A6F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-78],rax
       cmp       qword ptr [rbp-78],0
       je        short M02_L02
       mov       rax,[rbp-78]
       mov       [rbp-30],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C9B340
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M02_L03:
       mov       rax,1B72E969F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,1B72E960008
       call      qword ptr [7FF910A6F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-80],rax
       cmp       qword ptr [rbp-80],0
       je        short M02_L04
       mov       rax,[rbp-80]
       mov       [rbp-38],rax
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C9B580
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M02_L05:
       mov       rax,1B72E96FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1B72E960008
       call      qword ptr [7FF910A6F198]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+30]
       mov       [rbp-88],rax
       cmp       qword ptr [rbp-88],0
       je        short M02_L06
       mov       rax,[rbp-88]
       mov       [rbp-40],rax
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C9B5A8
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M02_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF910E0BFD8
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
       jne       near ptr M02_L10
       mov       rcx,7FF910E0C0E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       cmp       qword ptr [rax+10],38
       jle       short M02_L08
       mov       rax,[rbp-90]
       mov       rax,[rax+38]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-98],0
       je        short M02_L08
       mov       rax,[rbp-98]
       mov       [rbp-48],rax
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910C9B648
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M02_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF910E0C0E8
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
M02_L10:
       mov       rcx,7FF910E0C1F0
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF910C9B7C0
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA5728]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA56E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF910CA50C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108D78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA50C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-20],rax
       mov       r9,[rbp-20]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CBAFC0
       call      qword ptr [7FF910CA5068]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FF910CBB0D8
       call      qword ptr [7FF910CA5098]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 140
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
       mov       rdx,7FF910C98D58
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L01:
       mov       rax,2770B761640
       mov       [rsp+20],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-18]
       mov       r9,2770B760008
       call      qword ptr [7FF910A7EC70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C98D90
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M03_L03:
       mov       rax,2770B769F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-20]
       mov       r9,2770B760008
       call      qword ptr [7FF910A7EC70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C98FD0
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-38],rax
M03_L05:
       mov       rax,2770B76FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2770B760008
       call      qword ptr [7FF910A7EC70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C98FF8
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-40],rax
M03_L07:
       mov       rax,[rbp+18]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FF910DC7FF0
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
       mov       rcx,7FF910DC80F8
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
       mov       rdx,7FF910C99098
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-48],rax
M03_L09:
       mov       rax,[rbp+18]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FF910DC8100
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
       mov       rcx,7FF910DC8208
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
       mov       rdx,7FF910C99210
       call      qword ptr [7FF9104DF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA5200]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA51B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       je        near ptr M00_L24
       mov       r8,[rbp-88]
       mov       [rbp-88],r8
       test      rdx,rdx
       je        near ptr M00_L25
       mov       [rbp-90],rdx
       test      rax,rax
       je        near ptr M00_L26
       mov       [rbp-98],rax
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r8
       jne       near ptr M00_L30
       mov       [rbp-0A0],rax
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L07
       mov       r8,[rax+18]
       mov       [rbp-0B0],r8
       mov       r10,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [r8],r10
       jne       near ptr M00_L27
       mov       dword ptr [rbp-3C],15051505
       mov       dword ptr [rbp-40],15051505
       mov       ebx,[rdx+8]
       mov       [rbp-44],ebx
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
       jne       short M00_L02
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
       jle       near ptr M00_L23
       mov       edx,[rdx]
       test      edx,0FF80FF80
       jne       short M00_L02
       rorx      r10d,[rbp-40],1B
       add       r10d,[rbp-40]
       or        edx,200020
       xor       edx,r10d
       mov       [rbp-40],edx
       jmp       near ptr M00_L23
M00_L02:
       call      M00_L41
       nop
       mov       r8,[rbp-90]
       mov       ebx,[r8+8]
       mov       r8d,ebx
       sub       r8d,[rbp-44]
       cmp       ebx,r8d
       jb        near ptr M00_L32
       mov       rdx,[rbp-90]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2+0C]
       sub       ebx,r8d
       mov       [rbp-80],rdx
       mov       [rbp-78],ebx
       lea       r8,[rbp-80]
       mov       edx,[rbp-40]
       mov       ecx,[rbp-3C]
       call      qword ptr [7FF910CAE538]
       mov       r8,[rbp-0B0]
M00_L03:
       mov       ebx,eax
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
       jae       near ptr M00_L40
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
       je        near ptr M00_L28
M00_L06:
       mov       esi,[r13+14]
       inc       r14d
       cmp       r15d,r14d
       jb        near ptr M00_L35
       cmp       r15d,esi
       ja        short M00_L05
M00_L07:
       xor       r13d,r13d
M00_L08:
       test      r13,r13
       jne       near ptr M00_L29
       xor       edx,edx
       mov       [rbp-38],rdx
       mov       r13,[rbp-98]
       mov       [rbp-0A8],r13
       mov       rdx,[rbp-90]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L31
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
       jne       near ptr M00_L33
       mov       dword ptr [rbp-54],15051505
       mov       dword ptr [rbp-58],15051505
       mov       r8,[rbp-90]
       mov       ebx,[r8+8]
       mov       [rbp-5C],ebx
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
       jne       short M00_L12
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
       jle       near ptr M00_L22
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M00_L12
       rorx      eax,[rbp-58],1B
       add       eax,[rbp-58]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-58],r8d
       jmp       near ptr M00_L22
M00_L12:
       call      M00_L42
       nop
       mov       rdx,[rbp-0B8]
       mov       ebx,[rdx+8]
       mov       r8d,ebx
       sub       r8d,[rbp-5C]
       cmp       ebx,r8d
       jb        near ptr M00_L32
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2+0C]
       mov       eax,ebx
       sub       eax,r8d
       mov       [rbp-80],rcx
       mov       [rbp-78],eax
       lea       r8,[rbp-80]
       mov       edx,[rbp-58]
       mov       ecx,[rbp-54]
       call      qword ptr [7FF910CAE538]
       mov       rdx,[rbp-0C8]
M00_L13:
       mov       ebx,eax
M00_L14:
       xor       esi,esi
       mov       r13,[rbp-0A8]
       mov       r8,[r13+8]
       mov       r11d,ebx
       imul      r11,[r13+30]
       shr       r11,20
       inc       r11
       mov       eax,[r8+8]
       imul      r11,rax
       shr       r11,20
       cmp       r11d,[r8+8]
       jae       near ptr M00_L40
       mov       r11d,r11d
       lea       rdi,[r8+r11*4+10]
       mov       eax,[rdi]
       dec       eax
       mov       r8,[rbp-0C0]
       mov       r14d,[r8+8]
       cmp       r14d,eax
       jbe       short M00_L17
M00_L15:
       mov       r8,[rbp-0C0]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r15,[r8+r11*8+10]
       cmp       [r15+10],ebx
       je        near ptr M00_L34
M00_L16:
       mov       eax,[r15+14]
       inc       esi
       cmp       r14d,esi
       jb        near ptr M00_L35
       cmp       r14d,eax
       ja        short M00_L15
M00_L17:
       cmp       dword ptr [r13+40],0
       jg        near ptr M00_L36
       mov       r15d,[r13+38]
       cmp       r14d,r15d
       je        near ptr M00_L37
M00_L18:
       lea       eax,[r15+1]
       mov       [r13+38],eax
       mov       rax,[r13+10]
       mov       [rbp-0C0],rax
M00_L19:
       mov       rax,[rbp-0C0]
       cmp       r15d,[rax+8]
       jae       near ptr M00_L40
       mov       rax,[rbp-0C0]
       mov       r8d,r15d
       lea       r8,[r8+r8*2]
       lea       r14,[rax+r8*8+10]
       mov       [r14+10],ebx
       mov       eax,[rdi]
       dec       eax
       mov       [r14+14],eax
       mov       rdx,[rbp-0B8]
       mov       rcx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [rdi],r15d
       inc       dword ptr [r13+44]
       cmp       esi,64
       ja        near ptr M00_L38
M00_L20:
       mov       rcx,[rbp-88]
       mov       [rbp-38],rcx
M00_L21:
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
M00_L22:
       xor       r11d,r11d
       mov       [rbp-68],r11
       imul      eax,[rbp-58],5D588B65
       add       eax,[rbp-54]
       jmp       near ptr M00_L13
M00_L23:
       xor       edx,edx
       mov       [rbp-50],rdx
       imul      edx,[rbp-40],5D588B65
       add       edx,[rbp-3C]
       mov       eax,edx
       jmp       near ptr M00_L03
M00_L24:
       call      qword ptr [7FF910A6F240]
       mov       ecx,159
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CACB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CACBA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       call      qword ptr [7FF910A6F240]
       mov       ecx,139
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CACB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CACBA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      qword ptr [7FF910A6F240]
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CACB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CACBA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,r8
       mov       r11,7FF910411760
       call      qword ptr [r11]
       mov       ebx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L28:
       mov       rdx,[r13]
       mov       rcx,r8
       mov       r8,[rbp-90]
       mov       r11,7FF910411768
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-0B0]
       je        near ptr M00_L06
       add       r13,8
       jmp       near ptr M00_L08
M00_L29:
       mov       r8,[r13]
       mov       [rbp-38],r8
       jmp       near ptr M00_L21
M00_L30:
       lea       r8,[rbp-38]
       mov       rcx,rax
       mov       r11,7FF910411750
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L21
       jmp       near ptr M00_L39
M00_L31:
       mov       rcx,[rbp-98]
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L09
M00_L32:
       mov       ecx,21
       call      qword ptr [7FF9104CF360]
       int       3
M00_L33:
       mov       rcx,rdx
       mov       rdx,[rbp-90]
       mov       r11,7FF910411770
       call      qword ptr [r11]
       mov       ebx,eax
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L34:
       mov       r8,[rbp-0C0]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-0C8]
       mov       r8,[rbp-0B8]
       mov       r11,7FF910411778
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C8]
       je        near ptr M00_L16
       mov       rdx,[rbp-0B8]
       mov       rcx,7FF910EB01E0
       call      qword ptr [7FF9104CFD20]
       int       3
M00_L35:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L36:
       mov       r15d,[r13+3C]
       mov       eax,[r13+3C]
       cmp       eax,r14d
       jae       near ptr M00_L40
       mov       r8,[rbp-0C0]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r13+3C],eax
       dec       dword ptr [r13+40]
       jmp       near ptr M00_L19
M00_L37:
       mov       rcx,r13
       call      qword ptr [7FF910CAE3E8]
       mov       rcx,[r13+8]
       mov       edx,ebx
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L40
       mov       edx,edx
       lea       rdi,[rcx+rdx*4+10]
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L38:
       mov       rdx,[rbp-0C8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L20
       mov       rdx,[rbp-0C0]
       mov       edx,[rdx+8]
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L20
M00_L39:
       mov       rcx,[rbp-98]
       mov       r8,[rbp-88]
       mov       rdx,[rbp-90]
       mov       r11,7FF910411758
       call      qword ptr [r11]
       jmp       near ptr M00_L20
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-50],r8
       add       rsp,28
       ret
M00_L42:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-68],r8
       add       rsp,28
       ret
; Total bytes of code 2371
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E4C9300008
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
       call      qword ptr [7FF910CAEB68]
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D99A70
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       call      qword ptr [7FF910A5F240]
       mov       ecx,159
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910785AC0
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      qword ptr [7FF910A5F240]
       mov       ecx,139
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910785AC0
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       call      qword ptr [7FF910A5F240]
       mov       ecx,65
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910785AC0
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CA68]
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
       call      qword ptr [7FF910C9E820]
       mov       edx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,r8
       mov       r11,7FF910401578
       call      qword ptr [r11]
       mov       ebx,eax
       mov       r8,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L27:
       mov       rdx,[r13]
       mov       rcx,r8
       mov       r8,[rbp-90]
       mov       r11,7FF910401580
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
       mov       r11,7FF910401568
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L40
M00_L30:
       mov       rcx,[rbp-98]
       xor       edx,edx
       call      qword ptr [7FF9104B5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104BF360]
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
       call      qword ptr [7FF910C9E820]
       mov       rdx,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L34:
       mov       rcx,rdx
       mov       rdx,[rbp-90]
       mov       r11,7FF910401588
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
       mov       r11,7FF910401590
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C8]
       je        near ptr M00_L21
       mov       rdx,[rbp-0B8]
       mov       rcx,7FF910CF29F0
       call      qword ptr [7FF9104BFD20]
       int       3
M00_L36:
       call      qword ptr [7FF9104BF498]
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
       call      qword ptr [7FF910C9E6A0]
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
       call      qword ptr [7FF9107473F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L18
M00_L40:
       mov       rcx,[rbp-98]
       mov       r8,[rbp-88]
       mov       rdx,[rbp-90]
       mov       r11,7FF910401570
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2756B980008
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
       call      qword ptr [7FF910C9EE50]
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
       call      qword ptr [7FF9104B5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D8BDE0
       call      qword ptr [7FF9104BF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
       int       3
; Total bytes of code 517
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
       mov       r9d,r10d
       imul      r11,r9
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L42
       mov       r11d,r11d
       lea       rsi,[r8+r11*4+10]
       mov       r10d,[rsi]
       dec       r10d
       mov       r8,[rbp-0B8]
       cmp       [r8+8],r10d
       ja        near ptr M00_L19
M00_L14:
       mov       rax,[rbp-0A0]
       cmp       dword ptr [rax+40],0
       jg        near ptr M00_L38
       mov       edi,[rax+38]
       mov       r8,[rbp-0B8]
       cmp       [r8+8],edi
       je        near ptr M00_L39
M00_L15:
       lea       r8d,[rdi+1]
       mov       [rax+38],r8d
       mov       r8,[rax+10]
       mov       [rbp-0B8],r8
M00_L16:
       mov       r8,[rbp-0B8]
       cmp       edi,[r8+8]
       jae       near ptr M00_L42
       mov       r8,[rbp-0B8]
       mov       r10d,edi
       lea       r10,[r10+r10*2]
       lea       r14,[r8+r10*8+10]
       mov       [r14+10],r15d
       mov       r8d,[rsi]
       dec       r8d
       mov       [r14+14],r8d
       mov       rdx,[rbp-0B0]
       mov       rcx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       [rsi],edi
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
       lea       rdi,[r8+r11*8+10]
       cmp       [rdi+10],r15d
       je        near ptr M00_L36
M00_L20:
       mov       r10d,[rdi+14]
       inc       ebx
       mov       r8,[rbp-0B8]
       cmp       [r8+8],ebx
       jb        near ptr M00_L37
       mov       r8,[rbp-0B8]
       cmp       [r8+8],r10d
       ja        short M00_L19
       jmp       near ptr M00_L14
M00_L21:
       call      qword ptr [7FF910A7F1E0]
       mov       ecx,159
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107A5AC0
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CBCF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CBCF78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       call      qword ptr [7FF910A7F1E0]
       mov       ecx,139
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107A5AC0
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CBCF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CBCF78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      qword ptr [7FF910A7F1E0]
       mov       ecx,65
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107A5AC0
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CBCF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CBCF78]
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
       call      qword ptr [7FF910CBF1C8]
       mov       edx,eax
       mov       r8,[rbp-0A8]
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,r8
       mov       r11,7FF910421570
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
       mov       r11,7FF910421578
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
       mov       r11,7FF910421560
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L41
M00_L31:
       mov       rcx,[rbp-90]
       xor       edx,edx
       call      qword ptr [7FF9104D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104DF360]
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
       call      qword ptr [7FF910CBF1C8]
       mov       rdx,[rbp-0C0]
       jmp       near ptr M00_L12
M00_L35:
       mov       rcx,rdx
       mov       rdx,[rbp-88]
       mov       r11,7FF910421580
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
       mov       r11,7FF910421588
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0C0]
       je        near ptr M00_L20
       mov       rdx,[rbp-0B0]
       mov       rcx,7FF910CED008
       call      qword ptr [7FF9104DFD20]
       int       3
M00_L37:
       call      qword ptr [7FF9104DF498]
       int       3
M00_L38:
       mov       edi,[rax+3C]
       mov       r8d,[rax+3C]
       mov       r10,[rbp-0B8]
       cmp       r8d,[r10+8]
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
       call      qword ptr [7FF910CBE658]
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
       call      qword ptr [7FF9107673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L17
M00_L41:
       mov       rcx,[rbp-90]
       mov       r8,[rbp-80]
       mov       rdx,[rbp-88]
       mov       r11,7FF910421568
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
; Total bytes of code 2419
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28614AB0008
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
       call      qword ptr [7FF910CBEDF0]
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
       call      qword ptr [7FF9104D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D23F78
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       je        short M00_L00
       mov       rdi,[rbx+18]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF9104414D0
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
       mov       rdx,[rbp-98]
       cmp       [rdx],r8
       jne       near ptr M00_L26
       mov       dword ptr [rbp-44],15051505
       mov       dword ptr [rbp-48],15051505
       mov       rsi,[rbp-88]
       mov       r8d,[rsi+8]
       mov       [rbp-4C],r8d
       lea       r8,[rsi+0C]
       mov       [rbp-58],r8
       mov       r8,[rbp-58]
       cmp       dword ptr [rbp-4C],2
       jle       short M00_L04
       xchg      ax,ax
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
       cmp       [r8+8],eax
       ja        near ptr M00_L13
M00_L08:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M00_L29
       mov       r13d,[rbx+38]
       mov       rax,[rbp-90]
       cmp       [rax+8],r13d
       je        near ptr M00_L30
M00_L09:
       lea       eax,[r13+1]
       mov       [rbx+38],eax
       mov       rax,[rbx+10]
       mov       [rbp-90],rax
M00_L10:
       mov       rax,[rbp-90]
       cmp       r13d,[rax+8]
       jae       near ptr M00_L33
       mov       rax,[rbp-90]
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
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       [r14],r13d
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
       lea       r13,[r8+r11*8+10]
       cmp       [r13+10],r15d
       je        near ptr M00_L27
M00_L14:
       mov       eax,[r13+14]
       inc       edi
       mov       r8,[rbp-90]
       cmp       [r8+8],edi
       jb        near ptr M00_L28
       mov       r8,[rbp-90]
       cmp       [r8+8],eax
       ja        short M00_L13
       jmp       near ptr M00_L08
M00_L15:
       mov       r8,[r15]
       mov       [rbp-40],r8
       jmp       near ptr M00_L12
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
       mov       r11,7FF9104414D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L17
       add       r15,8
       jmp       near ptr M00_L01
M00_L19:
       call      qword ptr [7FF910A9F1E0]
       mov       ecx,159
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107C5AC0
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CCCA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CCCA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FF910A9F1E0]
       mov       ecx,139
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107C5AC0
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CCCA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CCCA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FF910A9F1E0]
       mov       ecx,65
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107C5AC0
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108FC720
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CCCA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CCCA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FF9104414C0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L32
M00_L23:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104F5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104FF360]
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
       call      qword ptr [7FF910CCFE40]
       mov       rdx,[rbp-98]
       mov       rbx,[rbp-80]
       jmp       near ptr M00_L06
M00_L26:
       mov       rsi,[rbp-88]
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF9104414E0
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
       mov       r11,7FF9104414E8
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-98]
       je        near ptr M00_L14
       mov       rdx,rsi
       mov       rcx,7FF910D28850
       call      qword ptr [7FF9104FFD20]
       int       3
M00_L28:
       call      qword ptr [7FF9104FF498]
       int       3
M00_L29:
       mov       r13d,[rbx+3C]
       mov       eax,[rbx+3C]
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
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
       call      qword ptr [7FF910CCEC58]
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
       call      qword ptr [7FF9107873F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L11
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-78]
       mov       rdx,rsi
       mov       r11,7FF9104414C8
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
; Total bytes of code 1941
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26259FC0008
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
       call      qword ptr [7FF910CCF4E0]
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
       call      qword ptr [7FF9104F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D56350
       call      qword ptr [7FF9104FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       mov       r11,7FF9104116D8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
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
       mov       r8,[rbp-98]
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
       mov       [rbp-98],rax
M00_L12:
       mov       rax,[rbp-98]
       cmp       r12d,[rax+8]
       jae       near ptr M00_L33
       mov       rax,[rbp-98]
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
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       [r14],r12d
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
       mov       r11,7FF9104116E0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L01
       add       r15,8
       jmp       near ptr M00_L03
M00_L19:
       call      qword ptr [7FF910A6F240]
       mov       ecx,159
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BA4F90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BA4FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      qword ptr [7FF910A6F240]
       mov       ecx,139
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BA4F90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BA4FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      qword ptr [7FF910A6F240]
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BA4F90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BA4FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       lea       r8,[rbp-40]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r11,7FF9104116C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L14
       jmp       near ptr M00_L32
M00_L23:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104CF360]
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
       call      qword ptr [7FF910E04228]
       mov       rdx,[rbp-0A0]
       mov       rbx,[rbp-88]
       jmp       near ptr M00_L08
M00_L26:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF9104116E8
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
       mov       r11,7FF9104116F0
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-0A0]
       je        near ptr M00_L16
       mov       rdx,rsi
       mov       rcx,7FF910D44A80
       call      qword ptr [7FF9104CFD20]
       int       3
M00_L28:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L29:
       mov       eax,[rbx+3C]
       mov       r12d,eax
       cmp       eax,r13d
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
       call      qword ptr [7FF910BAF738]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L13
M00_L32:
       mov       rcx,rbx
       mov       r8,[rbp-80]
       mov       rdx,rsi
       mov       r11,7FF9104116D0
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
; Total bytes of code 1895
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18F542C0008
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
       call      qword ptr [7FF910CEE370]
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910C9B3A8
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF53ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       call      qword ptr [7FF910CB5098]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108E78D0]; Precode of DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CB5098]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CCAFC0
       call      qword ptr [7FF910CB5038]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CCB0D8
       call      qword ptr [7FF910CB5068]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       jne       short M02_L00
       mov       rcx,7FF910E2CD90
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M02_L00:
       mov       rcx,7FF910E2CD94
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M02_L01
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CA8D58
       call      qword ptr [7FF9104EF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L02:
       mov       rax,1C4CB2B9F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1C4CB2B0008
       call      qword ptr [7FF910A8EC70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+20]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M02_L03
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CA8F98
       call      qword ptr [7FF9104EF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L04:
       mov       rax,1C4CB2BFD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1C4CB2B0008
       call      qword ptr [7FF910A8EC70]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+28]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M02_L05
       mov       rax,[rbp-50]
       mov       [rbp-28],rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CA8FC0
       call      qword ptr [7FF9104EF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M02_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FF910E2CD98
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
       je        short M03_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M03_L01
M03_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF910CA9110
       call      qword ptr [7FF9104EF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CB5170]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CB5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF910CA54B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108C78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA54B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CBA940
       call      qword ptr [7FF910CA5458]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CBAA58
       call      qword ptr [7FF910CA5488]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rcx,7FF910E0ADA8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FF910E0ADAC
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
       mov       rdx,7FF910C9B220
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,1FE4C279F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,1FE4C270008
       call      qword ptr [7FF910A6F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C9B460
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,1FE4C27FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1FE4C270008
       call      qword ptr [7FF910A6F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C9B488
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FF910E0ADB0
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
       mov       rdx,7FF910C9B5D8
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA5590]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA5548]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF910CA54B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9108C78D0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Id()
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA54B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-8],rax
       lea       r9,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       rcx,7FF910CBA940
       call      qword ptr [7FF910CA5458]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF910CBAA58
       call      qword ptr [7FF910CA5488]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rcx,7FF910DB6220
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,80
       pop       rbp
       ret
M03_L00:
       mov       rcx,7FF910DB6224
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
       mov       rdx,7FF910C9B220
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M03_L02:
       mov       rax,216E4609F18
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,216E4600008
       call      qword ptr [7FF910A6F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C9B460
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M03_L04:
       mov       rax,216E460FD28
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,216E4600008
       call      qword ptr [7FF910A6F138]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FF910C9B488
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-28],rax
M03_L06:
       mov       rax,[rbp+18]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,7FF910DB6228
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
       mov       rdx,7FF910C9B5D8
       call      qword ptr [7FF9104CF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M04_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF910CA5590]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF910CA5548]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rax,[rcx+278]
       mov       rdx,[rcx+48]
       mov       r8,[rdx+28]
       mov       rbx,r8
       test      rdx,rdx
       je        near ptr M00_L11
       test      rbx,rbx
       je        near ptr M00_L13
       test      rax,rax
       je        near ptr M00_L14
       mov       r8,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r8
       jne       near ptr M00_L23
       mov       rsi,rax
       mov       [rbp-70],rsi
       mov       [rbp-78],rdx
       mov       [rbp-80],rbx
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L15
M00_L00:
       mov       r8,[rsi+10]
       mov       [rbp-88],r8
       mov       rdx,[rsi+18]
       mov       [rbp-90],rdx
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       rdx,[rbp-90]
       cmp       [rdx],r8
       jne       near ptr M00_L17
       mov       dword ptr [rbp-3C],15051505
       mov       dword ptr [rbp-40],15051505
       mov       rbx,[rbp-80]
       mov       r8d,[rbx+8]
       mov       [rbp-44],r8d
       lea       r8,[rbx+0C]
       mov       [rbp-50],r8
       mov       r8,[rbp-50]
       cmp       dword ptr [rbp-44],2
       jle       short M00_L02
M00_L01:
       mov       eax,[r8]
       mov       r10d,[r8+4]
       mov       r9d,eax
       or        r9d,r10d
       test      r9d,0FF80FF80
       jne       short M00_L03
       mov       r9d,[rbp-44]
       add       r9d,0FFFFFFFC
       mov       [rbp-44],r9d
       rorx      r9d,[rbp-3C],1B
       add       r9d,[rbp-3C]
       or        eax,200020
       xor       eax,r9d
       mov       [rbp-3C],eax
       rorx      eax,[rbp-40],1B
       add       eax,[rbp-40]
       or        r10d,200020
       xor       eax,r10d
       mov       [rbp-40],eax
       add       r8,8
       cmp       dword ptr [rbp-44],2
       jg        short M00_L01
M00_L02:
       cmp       dword ptr [rbp-44],0
       jle       near ptr M00_L12
       mov       r8d,[r8]
       test      r8d,0FF80FF80
       jne       short M00_L03
       rorx      eax,[rbp-40],1B
       add       eax,[rbp-40]
       or        r8d,200020
       xor       r8d,eax
       mov       [rbp-40],r8d
       jmp       near ptr M00_L12
M00_L03:
       call      M00_L25
       nop
       mov       rbx,[rbp-80]
       mov       r8d,[rbx+8]
       sub       r8d,[rbp-44]
       cmp       [rbx+8],r8d
       jb        near ptr M00_L16
       mov       edx,r8d
       lea       rdx,[rbx+rdx*2+0C]
       mov       ecx,[rbx+8]
       sub       ecx,r8d
       mov       [rbp-68],rdx
       mov       [rbp-60],ecx
       lea       r8,[rbp-68]
       mov       edx,[rbp-40]
       mov       ecx,[rbp-3C]
       call      qword ptr [7FF910CCEE80]
       mov       rdx,[rbp-90]
M00_L04:
       mov       edi,eax
M00_L05:
       xor       r14d,r14d
       mov       rsi,[rbp-70]
       mov       r8,[rsi+8]
       mov       r11d,edi
       imul      r11,[rsi+30]
       shr       r11,20
       inc       r11
       mov       eax,[r8+8]
       mov       r10d,eax
       imul      r11,r10
       shr       r11,20
       cmp       r11d,eax
       jae       near ptr M00_L24
       mov       r11d,r11d
       lea       r15,[r8+r11*4+10]
       mov       eax,[r15]
       dec       eax
       mov       r8,[rbp-88]
       mov       r13d,[r8+8]
       cmp       r13d,eax
       jbe       short M00_L08
M00_L06:
       mov       r8,[rbp-88]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       lea       r12,[r8+r11*8+10]
       cmp       [r12+10],edi
       je        near ptr M00_L18
M00_L07:
       mov       eax,[r12+14]
       inc       r14d
       cmp       r13d,r14d
       jb        near ptr M00_L19
       cmp       r13d,eax
       ja        short M00_L06
M00_L08:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M00_L20
       mov       r12d,[rsi+38]
       cmp       r13d,r12d
       je        near ptr M00_L21
M00_L09:
       lea       eax,[r12+1]
       mov       [rsi+38],eax
       mov       rax,[rsi+10]
       mov       [rbp-88],rax
M00_L10:
       mov       rax,[rbp-88]
       cmp       r12d,[rax+8]
       jae       near ptr M00_L24
       mov       rax,[rbp-88]
       mov       r8d,r12d
       lea       r8,[r8+r8*2]
       lea       r13,[rax+r8*8+10]
       mov       [r13+10],edi
       mov       eax,[r15]
       dec       eax
       mov       [r13+14],eax
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       [r15],r12d
       inc       dword ptr [rsi+44]
       cmp       r14d,64
       ja        near ptr M00_L22
M00_L11:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+278]
       mov       [rbp-58],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L12:
       xor       r11d,r11d
       mov       [rbp-50],r11
       imul      eax,[rbp-40],5D588B65
       add       eax,[rbp-3C]
       jmp       near ptr M00_L04
M00_L13:
       call      qword ptr [7FF910A8F240]
       mov       ecx,139
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107B5AC0
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CCCB28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CCCB40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FF910A8F240]
       mov       ecx,65
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107B5AC0
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108EC720
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CCCB28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CCCB40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9104E5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L16:
       mov       ecx,21
       call      qword ptr [7FF9104EF360]
       int       3
M00_L17:
       mov       rbx,[rbp-80]
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF910431718
       call      qword ptr [r11]
       mov       edi,eax
       mov       rdx,[rbp-90]
       jmp       near ptr M00_L05
M00_L18:
       mov       r8,[rbp-88]
       mov       r11d,eax
       lea       r11,[r11+r11*2]
       mov       rdx,[r8+r11*8+10]
       mov       rcx,[rbp-90]
       mov       r8,rbx
       mov       r11,7FF910431720
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       je        near ptr M00_L07
       lea       rcx,[r12+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L19:
       call      qword ptr [7FF9104EF498]
       int       3
M00_L20:
       mov       r12d,[rsi+3C]
       mov       eax,[rsi+3C]
       cmp       eax,r13d
       jae       near ptr M00_L24
       mov       r8,[rbp-88]
       lea       rax,[rax+rax*2]
       mov       eax,[r8+rax*8+24]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rsi+3C],eax
       dec       dword ptr [rsi+40]
       jmp       near ptr M00_L10
M00_L21:
       mov       rcx,rsi
       call      qword ptr [7FF910CCE310]
       mov       rcx,[rsi+8]
       mov       edx,edi
       imul      rdx,[rsi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L24
       mov       edx,edx
       lea       r15,[rcx+rdx*4+10]
       mov       rdx,[rbp-90]
       jmp       near ptr M00_L09
M00_L22:
       mov       rdx,[rbp-90]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L11
       mov       rdx,[rbp-88]
       mov       edx,[rdx+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF9107773F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,rbx
       mov       r11,7FF910431710
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L25:
       sub       rsp,28
       xor       r8d,r8d
       mov       [rbp-50],r8
       add       rsp,28
       ret
; Total bytes of code 1457
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18640DC0008
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
       call      qword ptr [7FF910CCEA78]
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
       call      qword ptr [7FF9104E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D333E0
       call      qword ptr [7FF9104EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       call      qword ptr [7FF910A5F1E0]
       mov       ecx,139
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910785AC0
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CAB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CAC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF910A5F1E0]
       mov       ecx,65
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910785AC0
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BC720
       call      qword ptr [7FF9104BF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104BD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CAB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CAC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104B5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104BF360]
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
       call      qword ptr [7FF910C9E760]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF910401528
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
       mov       r11,7FF910401530
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
       call      qword ptr [7FF9104BF498]
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
       call      qword ptr [7FF910C9E5E0]
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
       call      qword ptr [7FF9107473F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF910401520
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22212120008
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
       call      qword ptr [7FF910C9ED90]
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
       call      qword ptr [7FF9104B5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D8B708
       call      qword ptr [7FF9104BF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       call      qword ptr [7FF910A7F1E0]
       mov       ecx,139
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107A5AC0
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CBCC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CBCC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF910A7F1E0]
       mov       ecx,65
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107A5AC0
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108DC720
       call      qword ptr [7FF9104DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910CBCC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910CBCC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104D5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104DF360]
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
       call      qword ptr [7FF910CBF150]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF910421390
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
       mov       r11,7FF910421398
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
       call      qword ptr [7FF9104DF498]
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
       call      qword ptr [7FF910CBE568]
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
       call      qword ptr [7FF9107673F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF910421388
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25F79170008
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
       call      qword ptr [7FF910CBED78]
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
       call      qword ptr [7FF9104D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D23EA0
       call      qword ptr [7FF9104DF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       call      qword ptr [7FF910A6F1E0]
       mov       ecx,139
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CE70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FF910A6F1E0]
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910C9CE58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910C9CE70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF9104CF360]
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
       call      qword ptr [7FF910C9FEB8]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L17:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF910411578
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
       mov       r11,7FF910411580
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
       call      qword ptr [7FF9104CF498]
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
       call      qword ptr [7FF910C9E598]
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
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF910411570
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F7C8240008
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
       call      qword ptr [7FF910C9F4B0]
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910D21088
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
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
       je        near ptr M00_L13
       test      rax,rax
       je        near ptr M00_L14
       mov       r10,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rbx,rax
       mov       [rbp-70],rbx
       mov       [rbp-78],rdx
       mov       [rbp-80],r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L15
M00_L00:
       mov       rdx,[rbx+10]
       mov       [rbp-88],rdx
       mov       rdx,[rbx+18]
       mov       [rbp-90],rdx
       mov       rax,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       cmp       [rdx],rax
       jne       near ptr M00_L18
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
       jne       near ptr M00_L16
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
       jne       near ptr M00_L16
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
       jg        near ptr M00_L12
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
       je        near ptr M00_L19
M00_L11:
       mov       eax,[r13+14]
       inc       edi
       cmp       r15d,edi
       jb        near ptr M00_L20
       cmp       r15d,eax
       ja        short M00_L10
       jmp       near ptr M00_L06
M00_L12:
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
M00_L13:
       call      qword ptr [7FF910A6ED18]
       mov       ecx,139
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BA4FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BA4FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FF910A6ED18]
       mov       ecx,65
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF910795AC0
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108CC720
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BA4FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BA4FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9104C5A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L00
M00_L16:
       call      M00_L25
       nop
       mov       r8,[rbp-80]
       mov       edx,[r8+8]
       sub       edx,[rbp-3C]
       cmp       [r8+8],edx
       jae       short M00_L17
       mov       ecx,21
       call      qword ptr [7FF9104CF360]
       int       3
M00_L17:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2+0C]
       mov       eax,[r8+8]
       sub       eax,edx
       mov       [rbp-60],rcx
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       edx,[rbp-38]
       mov       ecx,[rbp-34]
       call      qword ptr [7FF910E14288]
       mov       rdx,[rbp-90]
       mov       rbx,[rbp-70]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L04
M00_L18:
       mov       r8,[rbp-80]
       mov       rcx,rdx
       mov       rdx,r8
       mov       r11,7FF910411870
       call      qword ptr [r11]
       mov       esi,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       jmp       near ptr M00_L05
M00_L19:
       mov       r11,[rbp-88]
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       rdx,[r11+rax*8+10]
       mov       rcx,[rbp-90]
       mov       r11,7FF910411878
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-90]
       mov       r8,[rbp-80]
       je        near ptr M00_L11
       lea       rcx,[r13+8]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L20:
       call      qword ptr [7FF9104CF498]
       int       3
M00_L21:
       mov       rcx,rbx
       call      qword ptr [7FF910BAF750]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF9107573F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,rax
       mov       r8,rdx
       mov       rdx,[rbp-68]
       mov       r11,7FF910411868
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
       call      00007FF970169D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C019C60008
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
       call      qword ptr [7FF910CEE340]
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
       call      qword ptr [7FF9104C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FF910C9F388
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF96FF53ED8]; Precode of System.Collections.HashHelpers.ExpandPrime(Int32)
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
       call      qword ptr [7FF96FF37E90]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF96FF34088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF96FF452F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF96FF41B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF370B8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF96FF43730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF96FF34090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF96FF39060]
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
       call      qword ptr [7FF96FF33FD8]
       int       3
; Total bytes of code 517
```

