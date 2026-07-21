## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A86534D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A843D0C8]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A843D0B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A843D188]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A843D158]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A8575710
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6340]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6328]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A83F6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A852FCF8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406358]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A8406418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A84063E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A803BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
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
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L40
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L28
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L16
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L29
       mov       rcx,21411000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,347FCE55
       mov       r8d,1D5C53A7
       cmp       edx,8
       jb        near ptr M01_L30
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L31
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L36
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L15
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,214270007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L42
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L41
M01_L08:
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       jne       near ptr M01_L10
       xor       ecx,ecx
       call      qword ptr [7FF8A7C35A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M01_L17
       mov       rcx,rax
M01_L09:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
M01_L10:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       xor       r13d,r13d
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L18
M01_L11:
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L21
M01_L12:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+20],rax
       cmp       [rax+8],ebp
       jne       short M01_L14
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
M01_L13:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L25
M01_L14:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       short M01_L20
M01_L15:
       call      qword ptr [7FF8A7E57A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8A850F380
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8A84B10C0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8A84B10D8
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L13
M01_L20:
       test      eax,eax
       jge       near ptr M01_L12
M01_L21:
       cmp       dword ptr [rdi+30],0
       jg        short M01_L23
       mov       eax,[rdi+28]
       mov       [rsp+2C],eax
       cmp       [r14+8],eax
       jne       short M01_L22
       mov       ecx,[rdi+28]
       call      qword ptr [7FF8A7DA5038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8A7FBDA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L22:
       mov       eax,[rsp+2C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,r14d
       mov       r14,rcx
       jmp       short M01_L24
M01_L23:
       mov       ecx,[rdi+2C]
       mov       eax,ecx
       dec       dword ptr [rdi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L47
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+2C],ecx
M01_L24:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       [rsp+28],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[r14+rcx+10]
       mov       [rcx+8],ebp
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,[rsp+28]
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rdi+34]
       cmp       r13d,64
       jbe       short M01_L25
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L25
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8A7FBDA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A7C3E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M01_L25:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+18],rdx
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L44
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L43
M01_L26:
       mov       rdx,214270007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L46
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L45
M01_L27:
       mov       eax,1
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
M01_L28:
       mov       rdx,7FF8A84B10C0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L29:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L30:
       cmp       edx,4
       jb        short M01_L32
M01_L31:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L32:
       mov       r10d,80
       test      dl,1
       je        short M01_L33
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L33:
       test      dl,2
       je        short M01_L34
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L34:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L35:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L36:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdx,7FF8A84B10D8
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L38:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L39
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8A7B81430
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
       jmp       short M01_L40
M01_L39:
       mov       rcx,r13
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
M01_L40:
       xor       eax,eax
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
M01_L41:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L42:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L08
M01_L43:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L26
M01_L44:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L26
M01_L45:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L27
M01_L46:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L27
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1835
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A803BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L37
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L25
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L23
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L26
       mov       rcx,21C1D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L32
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4486AE9
       mov       r8d,2BFACFC7
       cmp       edx,8
       jb        near ptr M01_L27
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L28
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L60
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L33
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L52
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,21C338007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L39
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L38
M01_L08:
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L40
M01_L09:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       xor       r13d,r13d
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L24
M01_L10:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L48
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L41
       mov       rcx,21C1D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L47
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4486AE9
       mov       r8d,2BFACFC7
       cmp       edx,8
       jb        near ptr M01_L42
       mov       r10d,edx
       shr       r10d,3
M01_L11:
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
       jne       short M01_L11
       test      dl,4
       jne       near ptr M01_L43
M01_L12:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L13:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L14:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L60
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M01_L21
M01_L15:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M01_L53
       mov       eax,[rdi+28]
       mov       [rsp+3C],eax
       cmp       [r14+8],eax
       je        near ptr M01_L54
M01_L16:
       mov       eax,[rsp+3C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
M01_L17:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L60
       mov       ecx,r14d
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],ebp
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       [r12],r14d
       inc       dword ptr [rdi+34]
       cmp       r13d,64
       ja        near ptr M01_L55
M01_L18:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+18],rdx
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L57
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L56
M01_L19:
       mov       rdx,21C338007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L59
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L58
M01_L20:
       mov       eax,1
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
M01_L21:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],ebp
       je        near ptr M01_L49
M01_L22:
       mov       rax,[rsp+28]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L52
       test      eax,eax
       jge       short M01_L21
       jmp       near ptr M01_L15
M01_L23:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L24:
       mov       rdx,7FF8A84B16D8
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L25:
       mov       rdx,7FF8A84B16D8
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L26:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L27:
       cmp       edx,4
       jb        short M01_L29
M01_L28:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L29:
       mov       r10d,80
       test      dl,1
       je        short M01_L30
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L30:
       test      dl,2
       je        short M01_L31
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L31:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L32:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L33:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       rdx,7FF8A84B16F0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L35:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L36
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8A7B813F0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
       jmp       short M01_L37
M01_L36:
       mov       rcx,r13
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
M01_L37:
       xor       eax,eax
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
M01_L38:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8A7C3E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L09
M01_L41:
       xor       ebp,ebp
       jmp       near ptr M01_L14
M01_L42:
       cmp       edx,4
       jb        short M01_L44
M01_L43:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L12
M01_L44:
       mov       r10d,80
       test      dl,1
       je        short M01_L45
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L45:
       test      dl,2
       je        short M01_L46
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L13
M01_L46:
       mov       ecx,r10d
       jmp       near ptr M01_L13
M01_L47:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L14
M01_L48:
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L14
M01_L49:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L50
       jmp       short M01_L51
M01_L50:
       mov       rdx,7FF8A84B16F0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L51:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L18
       jmp       near ptr M01_L22
M01_L52:
       call      qword ptr [7FF8A7E57A08]
       int       3
M01_L53:
       mov       ecx,[rdi+2C]
       mov       eax,ecx
       dec       dword ptr [rdi+30]
       mov       ecx,[rdi+2C]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L60
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+2C],ecx
       mov       ecx,eax
       mov       rax,r14
       mov       r14d,ecx
       jmp       near ptr M01_L17
M01_L54:
       mov       rcx,rdi
       call      qword ptr [7FF8A84D72B8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L60
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M01_L16
M01_L55:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L18
       mov       r14,[rsp+30]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8A7FBDA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A7C3E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L18
M01_L56:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L19
M01_L57:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L58:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L20
M01_L59:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L20
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2140
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
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
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L40
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L28
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L16
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L29
       mov       rcx,1D9B8800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1F60AC54
       mov       r8d,0AE4F1C04
       cmp       edx,8
       jb        near ptr M01_L30
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L31
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L36
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L15
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,1D9CE8007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L42
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L41
M01_L08:
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       jne       near ptr M01_L10
       xor       ecx,ecx
       call      qword ptr [7FF8A7C15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M01_L17
       mov       rcx,rax
M01_L09:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
M01_L10:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       xor       r13d,r13d
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L18
M01_L11:
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L21
M01_L12:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+20],rax
       cmp       [rax+8],ebp
       jne       short M01_L14
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
M01_L13:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L25
M01_L14:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       short M01_L20
M01_L15:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8A8503FB8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8A84867A0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8A84867B8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L13
M01_L20:
       test      eax,eax
       jge       near ptr M01_L12
M01_L21:
       cmp       dword ptr [rdi+30],0
       jg        short M01_L23
       mov       eax,[rdi+28]
       mov       [rsp+2C],eax
       cmp       [r14+8],eax
       jne       short M01_L22
       mov       ecx,[rdi+28]
       call      qword ptr [7FF8A7D85038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8A7F9DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L22:
       mov       eax,[rsp+2C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,r14d
       mov       r14,rcx
       jmp       short M01_L24
M01_L23:
       mov       ecx,[rdi+2C]
       mov       eax,ecx
       dec       dword ptr [rdi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L47
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+2C],ecx
M01_L24:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       [rsp+28],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[r14+rcx+10]
       mov       [rcx+8],ebp
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,[rsp+28]
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rdi+34]
       cmp       r13d,64
       jbe       short M01_L25
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L25
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8A7F9DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A7C1E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M01_L25:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+18],rdx
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L44
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L43
M01_L26:
       mov       rdx,1D9CE8007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L46
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L45
M01_L27:
       mov       eax,1
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
M01_L28:
       mov       rdx,7FF8A84867A0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L29:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L30:
       cmp       edx,4
       jb        short M01_L32
M01_L31:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L32:
       mov       r10d,80
       test      dl,1
       je        short M01_L33
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L33:
       test      dl,2
       je        short M01_L34
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L34:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L35:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L36:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdx,7FF8A84867B8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L38:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L39
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8A7B610D8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
       jmp       short M01_L40
M01_L39:
       mov       rcx,r13
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
M01_L40:
       xor       eax,eax
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
M01_L41:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L42:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L08
M01_L43:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L26
M01_L44:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L26
M01_L45:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L27
M01_L46:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L27
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1835
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A800BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L38
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L26
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L24
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L27
       mov       rcx,24958800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L33
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,92FE80B8
       mov       r8d,9BD40F26
       cmp       edx,8
       jb        near ptr M01_L28
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L29
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L60
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L34
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L53
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,249588027D0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L40
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L39
M01_L08:
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L41
M01_L09:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       xor       r13d,r13d
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L25
M01_L10:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L49
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L42
       mov       rcx,24958800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L48
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,92FE80B8
       mov       r8d,9BD40F26
       cmp       edx,8
       jb        near ptr M01_L43
       mov       r10d,edx
       shr       r10d,3
M01_L11:
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
       jne       short M01_L11
       test      dl,4
       jne       near ptr M01_L44
M01_L12:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L13:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L14:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L60
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M01_L17
M01_L15:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],ebp
       je        near ptr M01_L50
M01_L16:
       mov       rax,[rsp+28]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L53
       test      eax,eax
       jge       short M01_L15
M01_L17:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M01_L23
       mov       eax,[rdi+28]
       mov       [rsp+3C],eax
       cmp       [r14+8],eax
       je        near ptr M01_L54
M01_L18:
       mov       eax,[rsp+3C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
M01_L19:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L60
       mov       ecx,r14d
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],ebp
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       [r12],r14d
       inc       dword ptr [rdi+34]
       cmp       r13d,64
       ja        near ptr M01_L55
M01_L20:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+18],rdx
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L57
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L56
M01_L21:
       mov       rdx,249588027C8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L59
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L58
M01_L22:
       mov       eax,1
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
M01_L23:
       mov       ecx,[rdi+2C]
       mov       eax,ecx
       dec       dword ptr [rdi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L60
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+2C],ecx
       mov       ecx,eax
       mov       rax,r14
       mov       r14d,ecx
       jmp       near ptr M01_L19
M01_L24:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L25:
       mov       rdx,7FF8A847F470
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L26:
       mov       rdx,7FF8A847F470
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L27:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L28:
       cmp       edx,4
       jb        short M01_L30
M01_L29:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L30:
       mov       r10d,80
       test      dl,1
       je        short M01_L31
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L31:
       test      dl,2
       je        short M01_L32
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L32:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L33:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L34:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L35
       jmp       short M01_L36
M01_L35:
       mov       rdx,7FF8A847F488
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L36:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L37
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8A7B511D8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
       jmp       short M01_L38
M01_L37:
       mov       rcx,r13
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
M01_L38:
       xor       eax,eax
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
M01_L39:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L08
M01_L41:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8A7C0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L09
M01_L42:
       xor       ebp,ebp
       jmp       near ptr M01_L14
M01_L43:
       cmp       edx,4
       jb        short M01_L45
M01_L44:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L12
M01_L45:
       mov       r10d,80
       test      dl,1
       je        short M01_L46
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L46:
       test      dl,2
       je        short M01_L47
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L13
M01_L47:
       mov       ecx,r10d
       jmp       near ptr M01_L13
M01_L48:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L14
M01_L49:
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L14
M01_L50:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L51
       jmp       short M01_L52
M01_L51:
       mov       rdx,7FF8A847F488
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L52:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L20
       jmp       near ptr M01_L16
M01_L53:
       call      qword ptr [7FF8A7E27A08]
       int       3
M01_L54:
       mov       rcx,rdi
       call      qword ptr [7FF8A84B74C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L60
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M01_L18
M01_L55:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L20
       mov       r14,[rsp+30]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8A7F8DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A7C0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L20
M01_L56:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L21
M01_L57:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L21
M01_L58:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L22
M01_L59:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L22
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A802BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Add(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
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
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L40
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L28
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L16
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L29
       mov       rcx,1640D000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6DB55FC7
       mov       r8d,0CF2C2414
       cmp       edx,8
       jb        near ptr M01_L30
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L31
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L36
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L15
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,16423000820
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L42
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L41
M01_L08:
       mov       rdi,[rbx+8]
       mov       rbp,rsi
       cmp       qword ptr [rdi+8],0
       jne       near ptr M01_L10
       xor       ecx,ecx
       call      qword ptr [7FF8A7C25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        near ptr M01_L17
       mov       rcx,rax
M01_L09:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
M01_L10:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       xor       r13d,r13d
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L18
M01_L11:
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        near ptr M01_L21
M01_L12:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+20],rax
       cmp       [rax+8],ebp
       jne       short M01_L14
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
M01_L13:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L25
M01_L14:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       short M01_L20
M01_L15:
       call      qword ptr [7FF8A7E47A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8A85C6FE8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8A8581D88
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8A8581DA0
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L13
M01_L20:
       test      eax,eax
       jge       near ptr M01_L12
M01_L21:
       cmp       dword ptr [rdi+30],0
       jg        short M01_L23
       mov       eax,[rdi+28]
       mov       [rsp+2C],eax
       cmp       [r14+8],eax
       jne       short M01_L22
       mov       ecx,[rdi+28]
       call      qword ptr [7FF8A7D95038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8A7FADA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L47
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
M01_L22:
       mov       eax,[rsp+2C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,r14d
       mov       r14,rcx
       jmp       short M01_L24
M01_L23:
       mov       ecx,[rdi+2C]
       mov       eax,ecx
       dec       dword ptr [rdi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L47
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+2C],ecx
M01_L24:
       cmp       eax,[r14+8]
       jae       near ptr M01_L47
       mov       [rsp+28],eax
       mov       ecx,eax
       shl       rcx,4
       lea       rcx,[r14+rcx+10]
       mov       [rcx+8],ebp
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,[rsp+28]
       inc       ebp
       mov       [r12],ebp
       inc       dword ptr [rdi+34]
       cmp       r13d,64
       jbe       short M01_L25
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L25
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8A7FADA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A7C2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M01_L25:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+18],rdx
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L44
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L43
M01_L26:
       mov       rdx,16423000818
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L46
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L45
M01_L27:
       mov       eax,1
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
M01_L28:
       mov       rdx,7FF8A8581D88
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L29:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L30:
       cmp       edx,4
       jb        short M01_L32
M01_L31:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L32:
       mov       r10d,80
       test      dl,1
       je        short M01_L33
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L33:
       test      dl,2
       je        short M01_L34
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L34:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L35:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L36:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdx,7FF8A8581DA0
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L38:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L39
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8A7B71318
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
       jmp       short M01_L40
M01_L39:
       mov       rcx,r13
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L06
M01_L40:
       xor       eax,eax
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
M01_L41:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L42:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L08
M01_L43:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L26
M01_L44:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L26
M01_L45:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L27
M01_L46:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L27
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1835
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A857A5A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84255B8
       call      qword ptr [7FF8A83F6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A84080F0
       call      qword ptr [7FF8A7E37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F6748]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A85795A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84155B8
       call      qword ptr [7FF8A83E6238]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F80F0
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6760]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A85255D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84255B8
       call      qword ptr [7FF8A83F6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A84080F0
       call      qword ptr [7FF8A7E37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6790]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F6748]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8516650
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A83E2210
       call      qword ptr [7FF8A830E670]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83D98C8
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A830EB98]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A830EB50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8556120
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84055B8
       call      qword ptr [7FF8A83D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83E7080
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83D63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83D6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A85660F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8415AC0
       call      qword ptr [7FF8A83E6340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F70D0
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A852D2F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8423F40
       call      qword ptr [7FF8A83F5E60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8419010
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F5FC8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F5F80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		if (this._set.Count == 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var removed = this.ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set.Clear();
; 		^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+28]
       sub       r8d,[rdx+30]
       je        near ptr M01_L10
       mov       rdx,210200007B8
       mov       r8,[rdx]
       mov       rsi,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L13
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L12
M01_L00:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L20
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L16
       mov       edi,[r15+28]
       sub       edi,[r15+30]
M01_L01:
       test      edi,edi
       je        near ptr M01_L17
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M01_L19
       xor       r12d,r12d
       mov       eax,[r15+28]
       sub       eax,[r15+30]
       js        near ptr M01_L18
       mov       r8d,[r13+8]
       cmp       [r13+8],eax
       jl        near ptr M01_L11
       mov       r10,[r15+10]
       mov       [rbp-58],r10
       xor       r9d,r9d
       cmp       dword ptr [r15+28],0
       jle       short M01_L04
M01_L02:
       mov       [rbp-40],eax
       test      eax,eax
       je        short M01_L04
       cmp       r9d,[r10+8]
       jae       near ptr M01_L34
       mov       [rbp-48],r9
       mov       r8,r9
       shl       r8,4
       lea       r8,[r10+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[r12+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,r12d
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rbp-40]
       dec       r12d
       mov       [rbp-40],r12d
       mov       r12d,[rbp-3C]
M01_L03:
       mov       r9,[rbp-48]
       inc       r9d
       mov       rcx,r9
       cmp       ecx,[r15+28]
       mov       r9,rcx
       mov       eax,[rbp-40]
       mov       r10,[rbp-58]
       jl        short M01_L02
M01_L04:
       mov       [r14+10],edi
M01_L05:
       mov       rdi,[rbx+8]
       mov       r15d,[rdi+28]
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       add       rcx,10
       test      dword ptr [rdx],1000000
       je        near ptr M01_L24
       mov       rdx,r8
       shr       rdx,3
       call      qword ptr [7FF8A824FB10]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L06:
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+28],rdx
       xor       edx,edx
       mov       [rdi+30],edx
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L25
       lea       rcx,[rdx+10]
       xor       eax,eax
       mov       r8,[rdx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M01_L26
M01_L07:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M01_L27
       test      r10d,r10d
       jl        near ptr M01_L27
       lea       eax,[r10+r15]
       cmp       eax,[rdx+8]
       ja        near ptr M01_L27
       movzx     edx,word ptr [r8]
       mov       eax,r10d
       imul      rax,rdx
       add       rcx,rax
       mov       eax,r15d
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M01_L28
       shr       rdx,3
       call      qword ptr [7FF8A824FB10]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,210200007C0
       mov       r15,[rcx]
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       test      r14,r14
       je        near ptr M01_L29
       mov       dword ptr [rdi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L31
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L30
M01_L09:
       mov       rdx,210200007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L33
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L32
M01_L10:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,6
       call      qword ptr [7FF8A83DC4C8]
       int       3
M01_L12:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+70]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       rax,[rsi+68]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,11
       call      qword ptr [7FF8A7E17E58]
       int       3
M01_L15:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       rcx,r15
       mov       r11,7FF8A7B41750
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,2100A001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8A83DDA10]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8A7B41758
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,2100A001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8A7B41730
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41738
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41740
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L22
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF8A7D6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41748
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L26:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FF8A8497240]
       int       3
M01_L28:
       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8A7FF8338
       call      qword ptr [7FF8A7E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A83DDA40]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L09
M01_L31:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rsi+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L32:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L33:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+68]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M01_L35
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41748
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		if (this._set.Count == 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var removed = this.ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set.Clear();
; 		^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+28]
       sub       r8d,[rdx+30]
       je        near ptr M01_L10
       mov       rdx,20896C027B0
       mov       r8,[rdx]
       mov       rsi,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L13
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L12
M01_L00:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L20
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L16
       mov       edi,[r15+28]
       sub       edi,[r15+30]
M01_L01:
       test      edi,edi
       je        near ptr M01_L17
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M01_L19
       xor       r12d,r12d
       mov       eax,[r15+28]
       sub       eax,[r15+30]
       js        near ptr M01_L18
       mov       r8d,[r13+8]
       cmp       [r13+8],eax
       jl        near ptr M01_L11
       mov       r10,[r15+10]
       mov       [rbp-58],r10
       xor       r9d,r9d
       cmp       dword ptr [r15+28],0
       jle       short M01_L04
M01_L02:
       mov       [rbp-40],eax
       test      eax,eax
       je        short M01_L04
       cmp       r9d,[r10+8]
       jae       near ptr M01_L34
       mov       [rbp-48],r9
       mov       r8,r9
       shl       r8,4
       lea       r8,[r10+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[r12+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,r12d
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rbp-40]
       dec       r12d
       mov       [rbp-40],r12d
       mov       r12d,[rbp-3C]
M01_L03:
       mov       r9,[rbp-48]
       inc       r9d
       mov       rcx,r9
       cmp       ecx,[r15+28]
       mov       r9,rcx
       mov       eax,[rbp-40]
       mov       r10,[rbp-58]
       jl        short M01_L02
M01_L04:
       mov       [r14+10],edi
M01_L05:
       mov       rdi,[rbx+8]
       mov       r15d,[rdi+28]
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       add       rcx,10
       test      dword ptr [rdx],1000000
       je        near ptr M01_L24
       mov       rdx,r8
       shr       rdx,3
       call      qword ptr [7FF8A824FB40]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L06:
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+28],rdx
       xor       edx,edx
       mov       [rdi+30],edx
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L25
       lea       rcx,[rdx+10]
       xor       eax,eax
       mov       r8,[rdx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M01_L26
M01_L07:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M01_L27
       test      r10d,r10d
       jl        near ptr M01_L27
       lea       eax,[r10+r15]
       cmp       eax,[rdx+8]
       ja        near ptr M01_L27
       movzx     edx,word ptr [r8]
       mov       eax,r10d
       imul      rax,rdx
       add       rcx,rax
       mov       eax,r15d
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M01_L28
       shr       rdx,3
       call      qword ptr [7FF8A824FB40]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,20896C027B8
       mov       r15,[rcx]
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       test      r14,r14
       je        near ptr M01_L29
       mov       dword ptr [rdi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L31
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L30
M01_L09:
       mov       rdx,20896C027A8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L33
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L32
M01_L10:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,6
       call      qword ptr [7FF8A83DC5D0]
       int       3
M01_L12:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+70]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       rax,[rsi+68]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,11
       call      qword ptr [7FF8A7E17E58]
       int       3
M01_L15:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       rcx,r15
       mov       r11,7FF8A7B41570
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,20896C01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8A83DDF08]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8A7B41578
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,20896C01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8A7B41550
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41558
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41560
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L22
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF8A7D6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41568
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L26:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FF8A84978B8]
       int       3
M01_L28:
       call      qword ptr [7FF8A7BF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8A7FF8338
       call      qword ptr [7FF8A7E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A83DDF38]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L09
M01_L31:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rsi+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L32:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L33:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+68]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M01_L35
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B41568
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		if (this._set.Count == 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var removed = this.ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set.Clear();
; 		^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+28]
       sub       r8d,[rdx+30]
       je        near ptr M01_L10
       mov       rdx,17EB20007B8
       mov       r8,[rdx]
       mov       rsi,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L13
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L12
M01_L00:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L20
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L16
       mov       edi,[r15+28]
       sub       edi,[r15+30]
M01_L01:
       test      edi,edi
       je        near ptr M01_L17
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M01_L19
       xor       r12d,r12d
       mov       eax,[r15+28]
       sub       eax,[r15+30]
       js        near ptr M01_L18
       mov       r8d,[r13+8]
       cmp       [r13+8],eax
       jl        near ptr M01_L11
       mov       r10,[r15+10]
       mov       [rbp-58],r10
       xor       r9d,r9d
       cmp       dword ptr [r15+28],0
       jle       short M01_L04
M01_L02:
       mov       [rbp-40],eax
       test      eax,eax
       je        short M01_L04
       cmp       r9d,[r10+8]
       jae       near ptr M01_L34
       mov       [rbp-48],r9
       mov       r8,r9
       shl       r8,4
       lea       r8,[r10+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[r12+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,r12d
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rbp-40]
       dec       r12d
       mov       [rbp-40],r12d
       mov       r12d,[rbp-3C]
M01_L03:
       mov       r9,[rbp-48]
       inc       r9d
       mov       rcx,r9
       cmp       ecx,[r15+28]
       mov       r9,rcx
       mov       eax,[rbp-40]
       mov       r10,[rbp-58]
       jl        short M01_L02
M01_L04:
       mov       [r14+10],edi
M01_L05:
       mov       rdi,[rbx+8]
       mov       r15d,[rdi+28]
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       add       rcx,10
       test      dword ptr [rdx],1000000
       je        near ptr M01_L24
       mov       rdx,r8
       shr       rdx,3
       call      qword ptr [7FF8A826FB40]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L06:
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+28],rdx
       xor       edx,edx
       mov       [rdi+30],edx
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L25
       lea       rcx,[rdx+10]
       xor       eax,eax
       mov       r8,[rdx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M01_L26
M01_L07:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M01_L27
       test      r10d,r10d
       jl        near ptr M01_L27
       lea       eax,[r10+r15]
       cmp       eax,[rdx+8]
       ja        near ptr M01_L27
       movzx     edx,word ptr [r8]
       mov       eax,r10d
       imul      rax,rdx
       add       rcx,rax
       mov       eax,r15d
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M01_L28
       shr       rdx,3
       call      qword ptr [7FF8A826FB40]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,17EB20007C0
       mov       r15,[rcx]
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       test      r14,r14
       je        near ptr M01_L29
       mov       dword ptr [rdi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L31
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L30
M01_L09:
       mov       rdx,17EB20007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L33
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L32
M01_L10:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,6
       call      qword ptr [7FF8A83FC5D0]
       int       3
M01_L12:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+70]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       rax,[rsi+68]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,11
       call      qword ptr [7FF8A7E37E58]
       int       3
M01_L15:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       rcx,r15
       mov       r11,7FF8A7B61588
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,17E9C001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8A83FE208]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8A7B61590
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,17E9C001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8A7B61568
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B61570
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B61578
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L22
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF8A7D8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B61580
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8A7E3C228]
       int       3
M01_L26:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FF8A84B7A50]
       int       3
M01_L28:
       call      qword ptr [7FF8A7C157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8A8018338
       call      qword ptr [7FF8A7E37798]
       mov       rcx,rax
       call      qword ptr [7FF8A83FE238]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L09
M01_L31:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rsi+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L32:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L33:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+68]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M01_L35
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B61580
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A800BA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		if (this._set.Count == 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var removed = this.ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set.Clear();
; 		^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+28]
       sub       r8d,[rdx+30]
       je        near ptr M01_L10
       mov       rdx,202E3C007E8
       mov       r8,[rdx]
       mov       rsi,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L13
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L12
M01_L00:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L20
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L16
       mov       edi,[r15+28]
       sub       edi,[r15+30]
M01_L01:
       test      edi,edi
       je        near ptr M01_L17
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M01_L19
       xor       r12d,r12d
       mov       eax,[r15+28]
       sub       eax,[r15+30]
       js        near ptr M01_L18
       mov       r8d,[r13+8]
       cmp       [r13+8],eax
       jl        near ptr M01_L11
       mov       r10,[r15+10]
       mov       [rbp-58],r10
       xor       r9d,r9d
       cmp       dword ptr [r15+28],0
       jle       short M01_L04
M01_L02:
       mov       [rbp-40],eax
       test      eax,eax
       je        short M01_L04
       cmp       r9d,[r10+8]
       jae       near ptr M01_L34
       mov       [rbp-48],r9
       mov       r8,r9
       shl       r8,4
       lea       r8,[r10+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[r12+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,r12d
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rbp-40]
       dec       r12d
       mov       [rbp-40],r12d
       mov       r12d,[rbp-3C]
M01_L03:
       mov       r9,[rbp-48]
       inc       r9d
       mov       rcx,r9
       cmp       ecx,[r15+28]
       mov       r9,rcx
       mov       eax,[rbp-40]
       mov       r10,[rbp-58]
       jl        short M01_L02
M01_L04:
       mov       [r14+10],edi
M01_L05:
       mov       rdi,[rbx+8]
       mov       r15d,[rdi+28]
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       add       rcx,10
       test      dword ptr [rdx],1000000
       je        near ptr M01_L24
       mov       rdx,r8
       shr       rdx,3
       call      qword ptr [7FF8A824F6F0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L06:
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+28],rdx
       xor       edx,edx
       mov       [rdi+30],edx
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L25
       lea       rcx,[rdx+10]
       xor       eax,eax
       mov       r8,[rdx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M01_L26
M01_L07:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M01_L27
       test      r10d,r10d
       jl        near ptr M01_L27
       lea       eax,[r10+r15]
       cmp       eax,[rdx+8]
       ja        near ptr M01_L27
       movzx     edx,word ptr [r8]
       mov       eax,r10d
       imul      rax,rdx
       add       rcx,rax
       mov       eax,r15d
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M01_L28
       shr       rdx,3
       call      qword ptr [7FF8A824F6F0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,202E3C007F0
       mov       r15,[rcx]
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       test      r14,r14
       je        near ptr M01_L29
       mov       dword ptr [rdi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L31
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L30
M01_L09:
       mov       rdx,202E3C007E0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L33
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L32
M01_L10:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,6
       call      qword ptr [7FF8A840E448]
       int       3
M01_L12:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+70]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       rax,[rsi+68]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,11
       call      qword ptr [7FF8A7E27E58]
       int       3
M01_L15:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       rcx,r15
       mov       r11,7FF8A7B515C8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,202CDC01FE0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8A82FE6A0]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8A7B515D0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,202CDC01FE0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8A7B515A8
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B515B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B515B8
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L22
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF8A7D7E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B515C0
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8A7E2C228]
       int       3
M01_L26:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FF8A84BC228]
       int       3
M01_L28:
       call      qword ptr [7FF8A7C057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8A8008338
       call      qword ptr [7FF8A7E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A82FE6D0]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L09
M01_L31:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rsi+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L32:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L33:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+68]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M01_L35
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B515C0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A803BA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		if (this._set.Count == 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var removed = this.ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set.Clear();
; 		^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rbx,rcx
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+28]
       sub       r8d,[rdx+30]
       je        near ptr M01_L10
       mov       rdx,223DB400828
       mov       r8,[rdx]
       mov       rsi,[rbx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L13
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L12
M01_L00:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L20
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L16
       mov       edi,[r15+28]
       sub       edi,[r15+30]
M01_L01:
       test      edi,edi
       je        near ptr M01_L17
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M01_L19
       xor       r12d,r12d
       mov       eax,[r15+28]
       sub       eax,[r15+30]
       js        near ptr M01_L18
       mov       r8d,[r13+8]
       cmp       [r13+8],eax
       jl        near ptr M01_L11
       mov       r10,[r15+10]
       mov       [rbp-58],r10
       xor       r9d,r9d
       cmp       dword ptr [r15+28],0
       jle       short M01_L04
M01_L02:
       mov       [rbp-40],eax
       test      eax,eax
       je        short M01_L04
       cmp       r9d,[r10+8]
       jae       near ptr M01_L34
       mov       [rbp-48],r9
       mov       r8,r9
       shl       r8,4
       lea       r8,[r10+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[r12+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,r12d
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rbp-40]
       dec       r12d
       mov       [rbp-40],r12d
       mov       r12d,[rbp-3C]
M01_L03:
       mov       r9,[rbp-48]
       inc       r9d
       mov       rcx,r9
       cmp       ecx,[r15+28]
       mov       r9,rcx
       mov       eax,[rbp-40]
       mov       r10,[rbp-58]
       jl        short M01_L02
M01_L04:
       mov       [r14+10],edi
M01_L05:
       mov       rdi,[rbx+8]
       mov       r15d,[rdi+28]
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       add       rcx,10
       test      dword ptr [rdx],1000000
       je        near ptr M01_L24
       mov       rdx,r8
       shr       rdx,3
       call      qword ptr [7FF8A828FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L06:
       mov       rdx,0FFFFFFFF00000000
       mov       [rdi+28],rdx
       xor       edx,edx
       mov       [rdi+30],edx
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        near ptr M01_L25
       lea       rcx,[rdx+10]
       xor       eax,eax
       mov       r8,[rdx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M01_L26
M01_L07:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M01_L27
       test      r10d,r10d
       jl        near ptr M01_L27
       lea       eax,[r10+r15]
       cmp       eax,[rdx+8]
       ja        near ptr M01_L27
       movzx     edx,word ptr [r8]
       mov       eax,r10d
       imul      rax,rdx
       add       rcx,rax
       mov       eax,r15d
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M01_L28
       shr       rdx,3
       call      qword ptr [7FF8A828FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,223DB400830
       mov       r15,[rcx]
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       dword ptr [rdi+20],0FFFFFFFF
       test      r14,r14
       je        near ptr M01_L29
       mov       dword ptr [rdi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       dword ptr [rdi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L31
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L30
M01_L09:
       mov       rdx,223DB400820
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rsi,rdx
       jne       near ptr M01_L33
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L32
M01_L10:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,6
       call      qword ptr [7FF8A833FBE8]
       int       3
M01_L12:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+70]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       rax,[rsi+68]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,11
       call      qword ptr [7FF8A7E57E58]
       int       3
M01_L15:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L16:
       mov       rcx,r15
       mov       r11,7FF8A7B816B8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,223C5402008
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8A7B74000
       call      qword ptr [7FF8A7E57798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8A8336268]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8A7B816C0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,223C5402008
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8A7B81698
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B816A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B816A8
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L22
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF8A7DAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B816B0
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8A7C357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8A7E5C228]
       int       3
M01_L26:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M01_L07
M01_L27:
       call      qword ptr [7FF8A84FC3C0]
       int       3
M01_L28:
       call      qword ptr [7FF8A7C357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8A8038338
       call      qword ptr [7FF8A7E57798]
       mov       rcx,rax
       call      qword ptr [7FF8A8336298]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L09
M01_L31:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rsi+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L09
M01_L32:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L33:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rsi+68]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M01_L35
       mov       rcx,[rbp-50]
       mov       r11,7FF8A7B816B0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8535658
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A83C1D10
       call      qword ptr [7FF8A82EE550]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83B8B40
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A82EE748]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82EE700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8567448
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8405AC0
       call      qword ptr [7FF8A83D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83E7450
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83D6550]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83D6508]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8531FA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8435AD0
       call      qword ptr [7FF8A8406358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8417450
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406550]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406508]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A849D208
       call      qword ptr [7FF8A842E868]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 101
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A848FF68
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A842EA60]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A842EA18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A859B8F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8445AD0
       call      qword ptr [7FF8A8416340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8428540
       call      qword ptr [7FF8A7E57B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A84169E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A84169A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A859C628
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8435AD0
       call      qword ptr [7FF8A8406328]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8418540
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A84069D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8536F90
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84355B8
       call      qword ptr [7FF8A8406268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8418458
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406910]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A84068C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A8586540
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8405EF0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8405ED8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A8405FF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8405FC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A8564818
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6298]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6280]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A83E63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6370]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF8A852DE00
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F5A88]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       mov       rax,[rbp-18]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       [rbp-24],eax
       mov       edx,[rbp-24]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F5A70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 132
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+208]
       pop       rbp
       ret
; Total bytes of code 21
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
       call      qword ptr [7FF8A83F5B90]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F5B60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A802BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Remove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       [rsi],esi
       test      rbx,rbx
       je        near ptr M01_L08
       mov       rdi,[rsi+8]
       mov       rbp,rbx
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L04
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L05
M01_L00:
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L06
       mov       rbp,[rbp+28]
       test      rbp,rbp
       je        near ptr M01_L09
       mov       rdx,13F95400068
       mov       rcx,[rdx]
       mov       rdx,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rdx
       jne       near ptr M01_L10
       mov       edx,[rbp+8]
       add       edx,edx
       lea       rcx,[rbp+0C]
       mov       r8d,6996A6C7
       mov       r9d,97767299
       call      qword ptr [7FF8A804DE60]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
M01_L01:
       mov       ebp,eax
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L50
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L04
M01_L02:
       cmp       eax,[r14+8]
       jae       near ptr M01_L50
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L11
M01_L03:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L44
       test      eax,eax
       jge       short M01_L02
M01_L04:
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
M01_L05:
       mov       rdx,7FF8A8494AC0
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       jmp       near ptr M01_L01
M01_L07:
       add       r10d,[rcx]
       mov       r14d,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       r14d,r10d
       mov       r10d,r9d
       xor       r10d,r14d
       rol       r14d,14
       add       r14d,r10d
       rol       r10d,9
       xor       r10d,r14d
       rol       r14d,1B
       add       r14d,r10d
       rol       r10d,13
       mov       r9d,r14d
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M01_L07
       jmp       near ptr M01_L23
M01_L08:
       call      qword ptr [7FF8A81DEFE8]
       mov       ecx,24AB
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A84D6E68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A83FEDD8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L10:
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF8A8494AD8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L13:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L14
       test      rdx,rdx
       je        near ptr M01_L03
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8A7B71778
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L15:
       test      eax,eax
       je        near ptr M01_L03
       mov       rdx,13FAB4007B8
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L16
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L17
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L17:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L45
       mov       r15,[rbp+10]
       xor       r13d,r13d
       mov       r12d,0FFFFFFFF
       mov       rax,[rbp+18]
       mov       [rsp+40],rax
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rdx,7FF8A8494AC0
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L19:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L31
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L20
       xor       r14d,r14d
       jmp       near ptr M01_L30
M01_L20:
       mov       rcx,13F95400068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L29
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,6996A6C7
       mov       r9d,97767299
       cmp       edx,8
       jae       short M01_L22
       cmp       edx,4
       jb        near ptr M01_L26
M01_L21:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L24
M01_L22:
       mov       r11d,edx
       shr       r11d,3
       jmp       near ptr M01_L07
M01_L23:
       test      dl,4
       jne       short M01_L21
M01_L24:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L25:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r14d,r10d
       jmp       short M01_L30
M01_L26:
       mov       r11d,80
       test      dl,1
       je        short M01_L27
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L27:
       test      dl,2
       je        short M01_L28
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L25
M01_L28:
       mov       ecx,r11d
       jmp       short M01_L25
M01_L29:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L30:
       jmp       short M01_L32
M01_L31:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L32:
       mov       rcx,[rbp+8]
       mov       edx,r14d
       imul      rdx,[rbp+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L50
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L45
M01_L33:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L50
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L34
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L35
       jmp       short M01_L36
M01_L34:
       jmp       short M01_L40
M01_L35:
       mov       rdx,7FF8A8494AD8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L36:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L38
       test      rcx,rcx
       je        short M01_L37
       mov       rdx,rbx
       mov       r11,7FF8A7B71780
       call      qword ptr [r11]
       jmp       short M01_L39
M01_L37:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L39
M01_L38:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L39:
       test      eax,eax
       jne       short M01_L41
M01_L40:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L44
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L33
       jmp       short M01_L45
M01_L41:
       test      r12d,r12d
       jge       short M01_L42
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L43
M01_L42:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L50
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L43:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L45
M01_L44:
       call      qword ptr [7FF8A7E47A08]
       int       3
M01_L45:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+1C],0FFFFFFFF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       dword ptr [rbp+18],1
       cmp       [rsi],rdi
       jne       short M01_L46
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L47
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L47
M01_L46:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L47:
       mov       rdx,13FAB4007B0
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L48
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L49
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L49
M01_L48:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L49:
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
M01_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1841
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Remove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       [rsi],esi
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdi,[rsi+8]
       mov       rbp,rbx
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L09
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L08
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L11
       mov       rcx,2A0B5000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,56472CC3
       mov       r8d,1C9B2A47
       cmp       edx,8
       jb        near ptr M01_L12
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L13
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L57
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L57
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L18
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L51
       test      eax,eax
       jge       short M01_L05
M01_L07:
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
M01_L08:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,7FF8A8464B58
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF8A81AF0F0]
       mov       ecx,24AB
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A83DD6C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A83DD6E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L12:
       cmp       edx,4
       jb        short M01_L14
M01_L13:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L14:
       mov       r10d,80
       test      dl,1
       je        short M01_L15
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L15:
       test      dl,2
       je        short M01_L16
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L16:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF8A8464B70
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L20:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L21
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8A7B413C8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,2A0CB0007B8
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L23
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L24
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L24:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L52
       mov       r15,[rbp+10]
       xor       r13d,r13d
       mov       r12d,0FFFFFFFF
       mov       rax,[rbp+18]
       mov       [rsp+40],rax
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF8A8464B58
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L26:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L38
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L27
       xor       r14d,r14d
       jmp       near ptr M01_L37
M01_L27:
       mov       rcx,2A0B5000068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,56472CC3
       mov       r9d,1C9B2A47
       cmp       edx,8
       jae       short M01_L29
       cmp       edx,4
       jb        near ptr M01_L33
M01_L28:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L31
M01_L29:
       mov       r11d,edx
       shr       r11d,3
M01_L30:
       add       r10d,[rcx]
       mov       r14d,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       r14d,r10d
       mov       r10d,r9d
       xor       r10d,r14d
       rol       r14d,14
       add       r14d,r10d
       rol       r10d,9
       xor       r10d,r14d
       rol       r14d,1B
       add       r14d,r10d
       rol       r10d,13
       mov       r9d,r14d
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M01_L30
       test      dl,4
       jne       near ptr M01_L28
M01_L31:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L32:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r14d,r10d
       jmp       short M01_L37
M01_L33:
       mov       r11d,80
       test      dl,1
       je        short M01_L34
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L34:
       test      dl,2
       je        short M01_L35
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L32
M01_L35:
       mov       ecx,r11d
       jmp       short M01_L32
M01_L36:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L37:
       jmp       short M01_L39
M01_L38:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L39:
       mov       rcx,[rbp+8]
       mov       edx,r14d
       imul      rdx,[rbp+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L57
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L52
M01_L40:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L57
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L41
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L42
       jmp       short M01_L43
M01_L41:
       jmp       short M01_L47
M01_L42:
       mov       rdx,7FF8A8464B70
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L43:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L45
       test      rcx,rcx
       je        short M01_L44
       mov       rdx,rbx
       mov       r11,7FF8A7B413D0
       call      qword ptr [r11]
       jmp       short M01_L46
M01_L44:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L46
M01_L45:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L46:
       test      eax,eax
       jne       short M01_L48
M01_L47:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L51
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L40
       jmp       short M01_L52
M01_L48:
       test      r12d,r12d
       jge       short M01_L49
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L50
M01_L49:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L57
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L50:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FF8A7E17A08]
       int       3
M01_L52:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+1C],0FFFFFFFF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       dword ptr [rbp+18],1
       cmp       [rsi],rdi
       jne       short M01_L53
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L54
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L54:
       mov       rdx,2A0CB0007B0
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L55
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L56
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L56
M01_L55:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L56:
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
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2125
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Remove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       [rsi],esi
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdi,[rsi+8]
       mov       rbp,rbx
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L11
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L10
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L13
       mov       rcx,2146DC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,87929725
       mov       r8d,24B0B51B
       cmp       edx,8
       jb        near ptr M01_L08
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L09
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L57
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L57
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L18
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L51
       test      eax,eax
       jge       short M01_L05
M01_L07:
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
M01_L08:
       cmp       edx,4
       jb        near ptr M01_L14
M01_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L11:
       mov       rdx,7FF8A8484970
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L12:
       call      qword ptr [7FF8A81CF0F0]
       mov       ecx,24AB
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A83FD878]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A83FD890]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L13:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L14:
       mov       r10d,80
       test      dl,1
       je        short M01_L15
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L15:
       test      dl,2
       je        short M01_L16
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L16:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF8A8484988
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L20:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L21
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8A7B613C8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,21483C007B8
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L23
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L24
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L24:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L52
       mov       r15,[rbp+10]
       xor       r13d,r13d
       mov       r12d,0FFFFFFFF
       mov       rax,[rbp+18]
       mov       [rsp+40],rax
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF8A8484970
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L26:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L38
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L27
       xor       r14d,r14d
       jmp       near ptr M01_L37
M01_L27:
       mov       rcx,2146DC00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,87929725
       mov       r9d,24B0B51B
       cmp       edx,8
       jae       short M01_L29
       cmp       edx,4
       jb        near ptr M01_L33
M01_L28:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L31
M01_L29:
       mov       r11d,edx
       shr       r11d,3
M01_L30:
       add       r10d,[rcx]
       mov       r14d,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       r14d,r10d
       mov       r10d,r9d
       xor       r10d,r14d
       rol       r14d,14
       add       r14d,r10d
       rol       r10d,9
       xor       r10d,r14d
       rol       r14d,1B
       add       r14d,r10d
       rol       r10d,13
       mov       r9d,r14d
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M01_L30
       test      dl,4
       jne       near ptr M01_L28
M01_L31:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L32:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r14d,r10d
       jmp       short M01_L37
M01_L33:
       mov       r11d,80
       test      dl,1
       je        short M01_L34
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L34:
       test      dl,2
       je        short M01_L35
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L32
M01_L35:
       mov       ecx,r11d
       jmp       short M01_L32
M01_L36:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L37:
       jmp       short M01_L39
M01_L38:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L39:
       mov       rcx,[rbp+8]
       mov       edx,r14d
       imul      rdx,[rbp+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L57
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L52
M01_L40:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L57
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L41
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L42
       jmp       short M01_L43
M01_L41:
       jmp       short M01_L47
M01_L42:
       mov       rdx,7FF8A8484988
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L43:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L45
       test      rcx,rcx
       je        short M01_L44
       mov       rdx,rbx
       mov       r11,7FF8A7B613D0
       call      qword ptr [r11]
       jmp       short M01_L46
M01_L44:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L46
M01_L45:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L46:
       test      eax,eax
       jne       short M01_L48
M01_L47:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L51
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L40
       jmp       short M01_L52
M01_L48:
       test      r12d,r12d
       jge       short M01_L49
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L50
M01_L49:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L57
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L50:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L52:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+1C],0FFFFFFFF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       dword ptr [rbp+18],1
       cmp       [rsi],rdi
       jne       short M01_L53
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L54
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L54:
       mov       rdx,21483C007B0
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L55
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L56
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L56
M01_L55:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L56:
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
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2129
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A800BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Remove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       [rsi],esi
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rdi,[rsi+8]
       mov       rbp,rbx
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L17
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L10
       mov       rcx,25661C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8A206DDA
       mov       r8d,0A554F833
       cmp       edx,8
       jb        near ptr M01_L11
       mov       r10d,edx
       shr       r10d,3
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L12
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L57
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L57
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L18
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L51
       test      eax,eax
       jge       short M01_L05
M01_L07:
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
M01_L08:
       mov       rdx,7FF8A847EED0
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FF8A81BF558]
       mov       ecx,24AB
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A830DF20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A830DF38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L11:
       cmp       edx,4
       jb        short M01_L13
M01_L12:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L13:
       mov       r10d,80
       test      dl,1
       je        short M01_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L14:
       test      dl,2
       je        short M01_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L15:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF8A847EEE8
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L20:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L21
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8A7B516E0
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,25661C027B0
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L23
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L24
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L24:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L52
       mov       r15,[rbp+10]
       xor       r13d,r13d
       mov       r12d,0FFFFFFFF
       mov       rax,[rbp+18]
       mov       [rsp+40],rax
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF8A847EED0
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L26:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L38
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L27
       xor       r14d,r14d
       jmp       near ptr M01_L37
M01_L27:
       mov       rcx,25661C00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,8A206DDA
       mov       r9d,0A554F833
       cmp       edx,8
       jae       short M01_L29
       cmp       edx,4
       jb        near ptr M01_L33
M01_L28:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L31
M01_L29:
       mov       r11d,edx
       shr       r11d,3
M01_L30:
       add       r10d,[rcx]
       mov       r14d,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       r14d,r10d
       mov       r10d,r9d
       xor       r10d,r14d
       rol       r14d,14
       add       r14d,r10d
       rol       r10d,9
       xor       r10d,r14d
       rol       r14d,1B
       add       r14d,r10d
       rol       r10d,13
       mov       r9d,r14d
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M01_L30
       test      dl,4
       jne       near ptr M01_L28
M01_L31:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L32:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r14d,r10d
       jmp       short M01_L37
M01_L33:
       mov       r11d,80
       test      dl,1
       je        short M01_L34
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L34:
       test      dl,2
       je        short M01_L35
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L32
M01_L35:
       mov       ecx,r11d
       jmp       short M01_L32
M01_L36:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L37:
       jmp       short M01_L39
M01_L38:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L39:
       mov       rcx,[rbp+8]
       mov       edx,r14d
       imul      rdx,[rbp+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L57
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L52
M01_L40:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L57
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L41
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L42
       jmp       short M01_L43
M01_L41:
       jmp       short M01_L47
M01_L42:
       mov       rdx,7FF8A847EEE8
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L43:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L45
       test      rcx,rcx
       je        short M01_L44
       mov       rdx,rbx
       mov       r11,7FF8A7B516E8
       call      qword ptr [r11]
       jmp       short M01_L46
M01_L44:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L46
M01_L45:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L46:
       test      eax,eax
       jne       short M01_L48
M01_L47:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L51
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L40
       jmp       short M01_L52
M01_L48:
       test      r12d,r12d
       jge       short M01_L49
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L50
M01_L49:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L57
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L50:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FF8A7E27A08]
       int       3
M01_L52:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+1C],0FFFFFFFF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       dword ptr [rbp+18],1
       cmp       [rsi],rdi
       jne       short M01_L53
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L54
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L54:
       mov       rdx,25661C027A8
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L55
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L56
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L56
M01_L55:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L56:
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
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2125
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+208]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!this._set.Contains(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = this._set.Remove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       [rsi],esi
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdi,[rsi+8]
       mov       rbp,rbx
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M01_L11
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L10
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L13
       mov       rcx,1DF56C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9D98DE3B
       mov       r8d,9C5F8FDA
       cmp       edx,8
       jb        near ptr M01_L08
       mov       r10d,edx
       shr       r10d,3
       nop
M01_L01:
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
       jne       short M01_L01
       test      dl,4
       jne       near ptr M01_L09
M01_L02:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
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
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       ebp,edx
       rol       ebp,13
       xor       ebp,r12d
M01_L04:
       mov       rcx,[rdi+8]
       mov       edx,ebp
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L57
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L57
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L18
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L51
       test      eax,eax
       jge       short M01_L05
M01_L07:
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
M01_L08:
       cmp       edx,4
       jb        near ptr M01_L14
M01_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L11:
       mov       rdx,7FF8A8461A90
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L12:
       call      qword ptr [7FF8A81CF0F0]
       mov       ecx,24AB
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A8305A88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A8305AA0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L13:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L14:
       mov       r10d,80
       test      dl,1
       je        short M01_L15
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L15:
       test      dl,2
       je        short M01_L16
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L16:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L17:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L18:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF8A8461AA8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L20:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L21
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8A7B616C0
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,1DF6CC00828
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L23
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L24
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L24:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L52
       mov       r15,[rbp+10]
       xor       r13d,r13d
       mov       r12d,0FFFFFFFF
       mov       rax,[rbp+18]
       mov       [rsp+40],rax
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rdx,7FF8A8461A90
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L26:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L38
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L27
       xor       r14d,r14d
       jmp       near ptr M01_L37
M01_L27:
       mov       rcx,1DF56C00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,9D98DE3B
       mov       r9d,9C5F8FDA
       cmp       edx,8
       jae       short M01_L29
       cmp       edx,4
       jb        near ptr M01_L33
M01_L28:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L31
M01_L29:
       mov       r11d,edx
       shr       r11d,3
M01_L30:
       add       r10d,[rcx]
       mov       r14d,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       r14d,r10d
       mov       r10d,r9d
       xor       r10d,r14d
       rol       r14d,14
       add       r14d,r10d
       rol       r10d,9
       xor       r10d,r14d
       rol       r14d,1B
       add       r14d,r10d
       rol       r10d,13
       mov       r9d,r14d
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M01_L30
       test      dl,4
       jne       near ptr M01_L28
M01_L31:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L32:
       add       ecx,r10d
       mov       edx,r9d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r14d,r10d
       jmp       short M01_L37
M01_L33:
       mov       r11d,80
       test      dl,1
       je        short M01_L34
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L34:
       test      dl,2
       je        short M01_L35
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L32
M01_L35:
       mov       ecx,r11d
       jmp       short M01_L32
M01_L36:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L37:
       jmp       short M01_L39
M01_L38:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L39:
       mov       rcx,[rbp+8]
       mov       edx,r14d
       imul      rdx,[rbp+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L57
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L52
M01_L40:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L57
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L41
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M01_L42
       jmp       short M01_L43
M01_L41:
       jmp       short M01_L47
M01_L42:
       mov       rdx,7FF8A8461AA8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L43:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L45
       test      rcx,rcx
       je        short M01_L44
       mov       rdx,rbx
       mov       r11,7FF8A7B616C8
       call      qword ptr [r11]
       jmp       short M01_L46
M01_L44:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L46
M01_L45:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L46:
       test      eax,eax
       jne       short M01_L48
M01_L47:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L51
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L40
       jmp       short M01_L52
M01_L48:
       test      r12d,r12d
       jge       short M01_L49
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L50
M01_L49:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L57
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L50:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L52:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+1C],0FFFFFFFF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Specialized.SingleItemReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       dword ptr [rbp+18],1
       cmp       [rsi],rdi
       jne       short M01_L53
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L54
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L54:
       mov       rdx,1DF6CC00820
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L55
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L56
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L56
M01_L55:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L56:
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
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8557728
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83D5EC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83D60E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83D60B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8578958
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6568]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F6538]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8514318
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6580]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6550]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveWhere()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rax,254A6802A58
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       mov       rax,[rbp-10]
       mov       [rbp-20],rax
       mov       rax,[rbp-8]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-8],0
       jne       short M00_L00
       mov       rcx,7FF8A858CAC0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,254A6802A50
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A7C26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,254A6802A58
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8A858CAC4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8A858CAC8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-38]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       [rbp-44],eax
       mov       edx,[rbp-44]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8A8405DE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 280
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8029A70]; Precode of DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A81AAF38]; Precode of System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 55
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF8A840EA48]
       int       3
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveWhere()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rax,21257C00A60
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       mov       rax,[rbp-10]
       mov       [rbp-20],rax
       mov       rax,[rbp-8]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-8],0
       jne       short M00_L00
       mov       rcx,7FF8A856CAB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,21257C00A58
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A7C06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,21257C00A60
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8A856CABC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8A856CAC0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-38]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       [rbp-44],eax
       mov       edx,[rbp-44]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8A83E6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 280
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8009A70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A818AF28]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 55
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF8A83EEAA8]
       int       3
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E68C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveWhere()
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-10],rax
       mov       rax,2496A400A60
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       mov       rax,[rbp-10]
       mov       [rbp-20],rax
       mov       rax,[rbp-8]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-8],0
       jne       short M00_L00
       mov       rcx,7FF8A8538168
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,2496A400A58
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8A7C26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,2496A400A60
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8A853816C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8A8538170
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-38]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       [rbp-44],eax
       mov       edx,[rbp-44]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8A8406358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 280
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbx
       sub       rsp,20
       mov       rcx,[rdx+8]
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],r11
       jne       short M01_L01
       mov       ebx,[rcx+10]
M01_L00:
       test      ebx,ebx
       setg      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       r11,7FF8A7B71698
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M01_L00
; Total bytes of code 62
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF8A840EA90]
       int       3
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A84069B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8576D60
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8418A68
       call      qword ptr [7FF8A83F5EA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8408F08
       call      qword ptr [7FF8A7E37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F5FC8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F5F80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8563200
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84157C0
       call      qword ptr [7FF8A83E62F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F6FC8
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6418]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8512678
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8415AD0
       call      qword ptr [7FF8A83E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F7060
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6478]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A800BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var newSet = new HashSet<T>(items, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._set.SetEquals(newSet))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = newSet;
; 		^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L68
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L69
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L72
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L62
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L75
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L78
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L63
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L81
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M01_L65
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF8A7C05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L66
M01_L08:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M01_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L67
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M01_L11:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       near ptr M01_L46
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L30
       mov       [rax+8],ecx
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L31
M01_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L33
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L47
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L49
       mov       rbx,[r11+rcx*8+10]
M01_L14:
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L34
M01_L15:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L32
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L35
       mov       rcx,1D51B800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,5DC5BDFE
       mov       r10d,0D7DF71BB
       cmp       edx,8
       jb        near ptr M01_L24
       mov       r9d,edx
       shr       r9d,3
M01_L17:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L17
       test      dl,4
       jne       near ptr M01_L25
M01_L18:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L19:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L20:
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-68],r8
       mov       r10d,[r8]
       dec       r10d
       jns       near ptr M01_L27
M01_L21:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M01_L29
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M01_L44
M01_L22:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r10,rcx
M01_L23:
       cmp       r14d,[r10+8]
       jae       near ptr M01_L49
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-60],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-68]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-68]
       mov       [r12],r14d
       inc       dword ptr [rsi+34]
       cmp       r13d,64
       jbe       near ptr M01_L11
       jmp       near ptr M01_L45
M01_L24:
       cmp       edx,4
       jb        near ptr M01_L36
M01_L25:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L18
M01_L26:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L27:
       cmp       r10d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[r14+rcx+10]
       mov       [rbp-70],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L41
M01_L28:
       mov       rax,[rbp-58]
       mov       r10,[rbp-70]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L48
       test      r10d,r10d
       jge       short M01_L27
       jmp       near ptr M01_L21
M01_L29:
       mov       ecx,[rsi+2C]
       mov       r10d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L49
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       jmp       near ptr M01_L23
M01_L30:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L50
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA9C0
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8A8481288
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L16
M01_L33:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L14
M01_L34:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8A7C0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-58]
       jmp       near ptr M01_L15
M01_L35:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L36:
       mov       r9d,80
       test      dl,1
       je        short M01_L37
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L37:
       test      dl,2
       je        short M01_L38
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L38:
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L39:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L40:
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L41:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rdi
       mov       rdx,7FF8A84812A0
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L43:
       mov       rax,[rbp-70]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rsi
       call      qword ptr [7FF8A84A6D30]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       r14,r8
       mov       [rbp-68],r14
       mov       rax,[rbp-58]
       jmp       near ptr M01_L22
M01_L45:
       mov       r14,[rbp-60]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A7F8DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8A7C0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8A7B51758
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8A83EFDC8]
       int       3
M01_L48:
       call      qword ptr [7FF8A7E27A08]
       int       3
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L50:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M01_L51
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M01_L85
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L59
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L60
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L101
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L86
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L61
       mov       rcx,rax
M01_L53:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L100
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L87
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L90
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L93
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L96
M01_L55:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L100
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L99
M01_L56:
       mov       rdx,1D51B8027B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L104
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L103
M01_L57:
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+1C],0FFFFFFFF
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       dword ptr [rax+18],4
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L105
M01_L58:
       mov       rdx,1D51B8027A8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L108
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L107
M01_L59:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L60:
       mov       rcx,rdx
       mov       rdx,7FF8A84FA890
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8A84FA880
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8A8328F60
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA880
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA890
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA8A0
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8A84F3978
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA9A8
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8A81BF558]
       mov       ecx,2A41
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A83ED908]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A83ED920]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L70
       jmp       short M01_L71
M01_L70:
       mov       rcx,rdx
       mov       rdx,7FF8A84F3990
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84A6CE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L72:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L74
M01_L73:
       mov       rcx,rdx
       mov       rdx,7FF8A84F6028
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L74:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L75:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       rdx,7FF8A84F6028
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8A7C06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L79
       jmp       short M01_L80
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A84F3990
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L80:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L81:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rcx,rdi
       mov       rdx,7FF8A84FA880
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8A8614BE8]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A84A6D48]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8A7B51760
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8A84A6D60]
       jmp       near ptr M01_L51
M01_L86:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L102
M01_L87:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A84F3990
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84A6CE8]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rdx,7FF8A84F6028
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L92:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L93:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L94
       jmp       short M01_L95
M01_L94:
       mov       rdx,7FF8A84F3990
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84A6CE8]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L96:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L97
       jmp       short M01_L98
M01_L97:
       mov       rdx,7FF8A84F6028
       call      qword ptr [7FF8A7C0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A84A6F10]
       jmp       short M01_L102
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L56
M01_L101:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84A6F28]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L56
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L102:
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L103:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L104:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L105:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L108:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+68]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M01_L109
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L109
       mov       rcx,rax
       mov       r11,7FF8A7B51760
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3640
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var newSet = new HashSet<T>(items, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._set.SetEquals(newSet))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = newSet;
; 		^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L68
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L69
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L72
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L62
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L75
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L78
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L63
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L81
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M01_L65
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF8A7C15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L66
M01_L08:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M01_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L67
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M01_L11:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       near ptr M01_L46
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L30
       mov       [rax+8],ecx
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L31
M01_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L33
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L47
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L49
       mov       rbx,[r11+rcx*8+10]
M01_L14:
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L34
M01_L15:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L32
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L35
       mov       rcx,1D2ECC00068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,774A801F
       mov       r10d,2868D5B0
       cmp       edx,8
       jb        near ptr M01_L24
       mov       r9d,edx
       shr       r9d,3
M01_L17:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L17
       test      dl,4
       jne       near ptr M01_L25
M01_L18:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L19:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L20:
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-68],r8
       mov       r10d,[r8]
       dec       r10d
       jns       near ptr M01_L27
M01_L21:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M01_L29
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M01_L44
M01_L22:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r10,rcx
M01_L23:
       cmp       r14d,[r10+8]
       jae       near ptr M01_L49
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-60],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-68]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-68]
       mov       [r12],r14d
       inc       dword ptr [rsi+34]
       cmp       r13d,64
       jbe       near ptr M01_L11
       jmp       near ptr M01_L45
M01_L24:
       cmp       edx,4
       jb        near ptr M01_L36
M01_L25:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L18
M01_L26:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L27:
       cmp       r10d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[r14+rcx+10]
       mov       [rbp-70],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L41
M01_L28:
       mov       rax,[rbp-58]
       mov       r10,[rbp-70]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L48
       test      r10d,r10d
       jge       short M01_L27
       jmp       near ptr M01_L21
M01_L29:
       mov       ecx,[rsi+2C]
       mov       r10d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L49
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       jmp       near ptr M01_L23
M01_L30:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L50
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FF8A8530570
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8A84919C0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L16
M01_L33:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L14
M01_L34:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8A7C1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-58]
       jmp       near ptr M01_L15
M01_L35:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L36:
       mov       r9d,80
       test      dl,1
       je        short M01_L37
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L37:
       test      dl,2
       je        short M01_L38
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L38:
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L39:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L40:
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L41:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rdi
       mov       rdx,7FF8A84919D8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L43:
       mov       rax,[rbp-70]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rsi
       call      qword ptr [7FF8A84B6EC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       r14,r8
       mov       [rbp-68],r14
       mov       rax,[rbp-58]
       jmp       near ptr M01_L22
M01_L45:
       mov       r14,[rbp-60]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A7F9DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8A7C1E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8A7B614A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8A84B40C0]
       int       3
M01_L48:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L50:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M01_L51
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M01_L85
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L59
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L60
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L101
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L86
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L61
       mov       rcx,rax
M01_L53:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L100
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L87
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L90
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L93
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L96
M01_L55:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L100
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L99
M01_L56:
       mov       rdx,1D2ECC027B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L104
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L103
M01_L57:
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+1C],0FFFFFFFF
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       dword ptr [rax+18],4
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L105
M01_L58:
       mov       rdx,1D2ECC027A8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L108
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L107
M01_L59:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L60:
       mov       rcx,rdx
       mov       rdx,7FF8A8530440
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8A8530430
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8A8338F70
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8A8530430
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8A8530440
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8A8530450
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8A84EFCF8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8A8530558
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8A81CF558]
       mov       ecx,2A41
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A83FD920]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A83FD938]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L70
       jmp       short M01_L71
M01_L70:
       mov       rcx,rdx
       mov       rdx,7FF8A84EFD10
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6BE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L72:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L74
M01_L73:
       mov       rcx,rdx
       mov       rdx,7FF8A8505A00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L74:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L75:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       rdx,7FF8A8505A00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8A7C16358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L79
       jmp       short M01_L80
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A84EFD10
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L80:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L81:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rcx,rdi
       mov       rdx,7FF8A8530430
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8A84B7A98]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A84B7030]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8A7B614A8
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8A84B7048]
       jmp       near ptr M01_L51
M01_L86:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L102
M01_L87:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A84EFD10
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6BE0]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rdx,7FF8A8505A00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L92:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L93:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L94
       jmp       short M01_L95
M01_L94:
       mov       rdx,7FF8A84EFD10
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6BE0]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L96:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L97
       jmp       short M01_L98
M01_L97:
       mov       rdx,7FF8A8505A00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A84B71E0]
       jmp       short M01_L102
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L56
M01_L101:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84B71F8]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L56
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L102:
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L103:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L104:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L105:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L108:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+68]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M01_L109
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L109
       mov       rcx,rax
       mov       r11,7FF8A7B614A8
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3640
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var newSet = new HashSet<T>(items, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._set.SetEquals(newSet))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = newSet;
; 		^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L68
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L69
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L72
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L62
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L75
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L78
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L63
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L81
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M01_L65
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF8A7C15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L66
M01_L08:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M01_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L67
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M01_L11:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       near ptr M01_L46
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L30
       mov       [rax+8],ecx
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L31
M01_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L33
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L47
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L49
       mov       rbx,[r11+rcx*8+10]
M01_L14:
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L34
M01_L15:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L32
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L35
       mov       rcx,2C590400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0BFB49DA3
       mov       r10d,0A5362294
       cmp       edx,8
       jb        near ptr M01_L24
       mov       r9d,edx
       shr       r9d,3
M01_L17:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L17
       test      dl,4
       jne       near ptr M01_L25
M01_L18:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L19:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L20:
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-68],r8
       mov       r10d,[r8]
       dec       r10d
       jns       near ptr M01_L27
M01_L21:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M01_L29
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M01_L44
M01_L22:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r10,rcx
M01_L23:
       cmp       r14d,[r10+8]
       jae       near ptr M01_L49
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-60],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-68]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-68]
       mov       [r12],r14d
       inc       dword ptr [rsi+34]
       cmp       r13d,64
       jbe       near ptr M01_L11
       jmp       near ptr M01_L45
M01_L24:
       cmp       edx,4
       jb        near ptr M01_L36
M01_L25:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L18
M01_L26:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L27:
       cmp       r10d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[r14+rcx+10]
       mov       [rbp-70],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L41
M01_L28:
       mov       rax,[rbp-58]
       mov       r10,[rbp-70]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L48
       test      r10d,r10d
       jge       short M01_L27
       jmp       near ptr M01_L21
M01_L29:
       mov       ecx,[rsi+2C]
       mov       r10d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L49
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       jmp       near ptr M01_L23
M01_L30:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L50
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FF8A853DC68
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8A8491808
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L16
M01_L33:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L14
M01_L34:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8A7C1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-58]
       jmp       near ptr M01_L15
M01_L35:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L36:
       mov       r9d,80
       test      dl,1
       je        short M01_L37
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L37:
       test      dl,2
       je        short M01_L38
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L38:
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L39:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L40:
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L41:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rdi
       mov       rdx,7FF8A8491820
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L43:
       mov       rax,[rbp-70]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rsi
       call      qword ptr [7FF8A84B6EB0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       r14,r8
       mov       [rbp-68],r14
       mov       rax,[rbp-58]
       jmp       near ptr M01_L22
M01_L45:
       mov       r14,[rbp-60]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A7F9DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8A7C1E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8A7B61560
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8A84B40A8]
       int       3
M01_L48:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L50:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M01_L51
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M01_L85
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L59
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L60
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L101
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L86
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L61
       mov       rcx,rax
M01_L53:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L100
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L87
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L90
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L93
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L96
M01_L55:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L100
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L99
M01_L56:
       mov       rdx,2C5A64007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L104
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L103
M01_L57:
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+1C],0FFFFFFFF
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       dword ptr [rax+18],4
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L105
M01_L58:
       mov       rdx,2C5A64007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L108
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L107
M01_L59:
       mov       rcx,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L60:
       mov       rcx,rdx
       mov       rdx,7FF8A853DB38
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8A853DB28
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8A8338FA0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8A853DB28
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8A853DB38
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8A853DB48
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8A84EEB28
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8A853DC50
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8A81CF558]
       mov       ecx,2A41
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A83FDA28]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A83FDA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L70
       jmp       short M01_L71
M01_L70:
       mov       rcx,rdx
       mov       rdx,7FF8A84EEB40
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6EC8]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L72:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L74
M01_L73:
       mov       rcx,rdx
       mov       rdx,7FF8A8508450
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L74:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L75:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       rdx,7FF8A8508450
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8A7C16358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L79
       jmp       short M01_L80
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A84EEB40
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L80:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L81:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rcx,rdi
       mov       rdx,7FF8A853DB28
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8A84B7A98]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A84B74E0]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8A7B61568
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8A84B74F8]
       jmp       near ptr M01_L51
M01_L86:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L102
M01_L87:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A84EEB40
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6EC8]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rdx,7FF8A8508450
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L92:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L93:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L94
       jmp       short M01_L95
M01_L94:
       mov       rdx,7FF8A84EEB40
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B6EC8]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L96:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L97
       jmp       short M01_L98
M01_L97:
       mov       rdx,7FF8A8508450
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A84B7678]
       jmp       short M01_L102
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L56
M01_L101:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84B7690]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L56
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L102:
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L103:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L104:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L105:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L108:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+68]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M01_L109
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L109
       mov       rcx,rax
       mov       r11,7FF8A7B61568
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3644
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var newSet = new HashSet<T>(items, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._set.SetEquals(newSet))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = newSet;
; 		^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L68
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L69
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L72
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L62
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L75
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L78
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L63
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L81
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M01_L65
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF8A7BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L66
M01_L08:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M01_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L67
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M01_L11:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       near ptr M01_L46
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L31
       mov       [rax+8],ecx
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L32
M01_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L34
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L47
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L49
       mov       rbx,[r11+rcx*8+10]
M01_L14:
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L35
M01_L15:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L28
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L33
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L41
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L36
       mov       rcx,1C8FD400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,9532A617
       mov       r10d,4A008DC2
       cmp       edx,8
       jb        near ptr M01_L26
       mov       r9d,edx
       shr       r9d,3
M01_L17:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L17
       test      dl,4
       jne       near ptr M01_L27
M01_L18:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L19:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L20:
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-68],r8
       mov       r10d,[r8]
       dec       r10d
       js        short M01_L23
M01_L21:
       cmp       r10d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[r14+rcx+10]
       mov       [rbp-70],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L42
M01_L22:
       mov       rax,[rbp-58]
       mov       r10,[rbp-70]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L48
       test      r10d,r10d
       jge       short M01_L21
M01_L23:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M01_L30
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M01_L29
M01_L24:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r10,rcx
M01_L25:
       cmp       r14d,[r10+8]
       jae       near ptr M01_L49
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-60],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-68]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-68]
       mov       [r12],r14d
       inc       dword ptr [rsi+34]
       cmp       r13d,64
       jbe       near ptr M01_L11
       jmp       near ptr M01_L45
M01_L26:
       cmp       edx,4
       jb        near ptr M01_L37
M01_L27:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L18
M01_L28:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L29:
       mov       ecx,[rsi+28]
       call      qword ptr [7FF8A7D65038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       r14,r8
       mov       [rbp-68],r14
       mov       rax,[rbp-58]
       jmp       near ptr M01_L24
M01_L30:
       mov       ecx,[rsi+2C]
       mov       r10d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L49
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       jmp       near ptr M01_L25
M01_L31:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L50
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC1D8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L33:
       mov       rcx,rdi
       mov       rdx,7FF8A846EE30
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L16
M01_L34:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L14
M01_L35:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-58]
       jmp       near ptr M01_L15
M01_L36:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L37:
       mov       r9d,80
       test      dl,1
       je        short M01_L38
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L38:
       test      dl,2
       je        short M01_L39
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L39:
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L40:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L41:
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L42:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L43
       jmp       short M01_L44
M01_L43:
       mov       rcx,rdi
       mov       rdx,7FF8A846EE48
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L44:
       mov       rax,[rbp-70]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L22
M01_L45:
       mov       r14,[rbp-60]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8A7BFE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8A7B416B8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8A8494E28]
       int       3
M01_L48:
       call      qword ptr [7FF8A7E17A08]
       int       3
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L50:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M01_L51
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M01_L85
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L59
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L60
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L101
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L86
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L61
       mov       rcx,rax
M01_L53:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L100
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L87
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L90
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L93
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L96
M01_L55:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L100
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L99
M01_L56:
       mov       rdx,1C9134007E8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L104
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L103
M01_L57:
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+1C],0FFFFFFFF
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       dword ptr [rax+18],4
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L105
M01_L58:
       mov       rdx,1C9134007E0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L108
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L107
M01_L59:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L60:
       mov       rcx,rdx
       mov       rdx,7FF8A85BC0A8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8A85BC098
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8A83C9D60
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC098
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC0A8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC0B8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8A84EF5B0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC1C0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8A81AF558]
       mov       ecx,2A41
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A82FE040]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A82FE058]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L70
       jmp       short M01_L71
M01_L70:
       mov       rcx,rdx
       mov       rdx,7FF8A84EF5C8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A8497738]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L72:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L74
M01_L73:
       mov       rcx,rdx
       mov       rdx,7FF8A859DDA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L74:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L75:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       rdx,7FF8A859DDA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8A7BF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L79
       jmp       short M01_L80
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A84EF5C8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L80:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L81:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rcx,rdi
       mov       rdx,7FF8A85BC098
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8A849C0F0]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A8497BD0]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8A7B416C0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8A8497BE8]
       jmp       near ptr M01_L51
M01_L86:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L102
M01_L87:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A84EF5C8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A8497738]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rdx,7FF8A859DDA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L92:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L93:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L94
       jmp       short M01_L95
M01_L94:
       mov       rdx,7FF8A84EF5C8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A8497738]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L96:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L97
       jmp       short M01_L98
M01_L97:
       mov       rdx,7FF8A859DDA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A8497D20]
       jmp       short M01_L102
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L56
M01_L101:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A8497D38]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L56
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L102:
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L103:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L104:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L105:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L108:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+68]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M01_L109
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L109
       mov       rcx,rax
       mov       r11,7FF8A7B416C0
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3647
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A801BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var newSet = new HashSet<T>(items, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._set.SetEquals(newSet))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = newSet;
; 		^^^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L68
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L69
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L72
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L62
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L75
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L78
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L63
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L81
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L06:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M01_L65
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF8A7C15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L66
M01_L08:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M01_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L67
M01_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-58],rax
M01_L11:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       jne       near ptr M01_L46
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L30
       mov       [rax+8],ecx
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L31
M01_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L33
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L47
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L49
       mov       rbx,[r11+rcx*8+10]
M01_L14:
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L34
M01_L15:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L26
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+88]
       test      r11,r11
       je        near ptr M01_L32
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L35
       mov       rcx,2CBB9400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0B76011FC
       mov       r10d,0BDB3DEBA
       cmp       edx,8
       jb        near ptr M01_L24
       mov       r9d,edx
       shr       r9d,3
M01_L17:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L17
       test      dl,4
       jne       near ptr M01_L25
M01_L18:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L19:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L20:
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-68],r8
       mov       r10d,[r8]
       dec       r10d
       jns       near ptr M01_L27
M01_L21:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M01_L29
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M01_L44
M01_L22:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r10,rcx
M01_L23:
       cmp       r14d,[r10+8]
       jae       near ptr M01_L49
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-60],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-68]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-68]
       mov       [r12],r14d
       inc       dword ptr [rsi+34]
       cmp       r13d,64
       jbe       near ptr M01_L11
       jmp       near ptr M01_L45
M01_L24:
       cmp       edx,4
       jb        near ptr M01_L36
M01_L25:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L18
M01_L26:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L27:
       cmp       r10d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[r14+rcx+10]
       mov       [rbp-70],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L41
M01_L28:
       mov       rax,[rbp-58]
       mov       r10,[rbp-70]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L48
       test      r10d,r10d
       jge       short M01_L27
       jmp       near ptr M01_L21
M01_L29:
       mov       ecx,[rsi+2C]
       mov       r10d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r14+8]
       jae       near ptr M01_L49
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       jmp       near ptr M01_L23
M01_L30:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L50
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB608
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8A8571E98
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L16
M01_L33:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L14
M01_L34:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8A7C1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-58]
       jmp       near ptr M01_L15
M01_L35:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L36:
       mov       r9d,80
       test      dl,1
       je        short M01_L37
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L37:
       test      dl,2
       je        short M01_L38
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L38:
       mov       ecx,r9d
       jmp       near ptr M01_L19
M01_L39:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L40:
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L20
M01_L41:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rdi
       mov       rdx,7FF8A8571EB0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L43:
       mov       rax,[rbp-70]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rsi
       call      qword ptr [7FF8A84D6970]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L49
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       r14,r8
       mov       [rbp-68],r14
       mov       rax,[rbp-58]
       jmp       near ptr M01_L22
M01_L45:
       mov       r14,[rbp-60]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       edx,[r14+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A7F9DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8A7C1E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8A7B618A8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8A84D48A0]
       int       3
M01_L48:
       call      qword ptr [7FF8A7E37A08]
       int       3
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L50:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M01_L51
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M01_L85
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L59
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L60
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L101
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L86
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L61
       mov       rcx,rax
M01_L53:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L100
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L87
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L90
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L93
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L96
M01_L55:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L100
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L99
M01_L56:
       mov       rdx,2CBB9402818
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L104
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L103
M01_L57:
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+1C],0FFFFFFFF
       mov       dword ptr [rax+20],0FFFFFFFF
       mov       dword ptr [rax+18],4
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L105
M01_L58:
       mov       rdx,2CBB9402810
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L108
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L107
M01_L59:
       mov       rcx,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L60:
       mov       rcx,rdx
       mov       rdx,7FF8A85EB4D8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8A85EB4C8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8A8465C68
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB4C8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB4D8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB4E8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8A85B6E68
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB5F0
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8A81C7798]
       mov       ecx,2A41
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A82FED18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A82FED30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L70
       jmp       short M01_L71
M01_L70:
       mov       rcx,rdx
       mov       rdx,7FF8A85B6E80
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84D7348]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L72:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L74
M01_L73:
       mov       rcx,rdx
       mov       rdx,7FF8A85E4C00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L74:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L75:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L76
       jmp       short M01_L77
M01_L76:
       mov       rdx,7FF8A85E4C00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8A7C16358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L79
       jmp       short M01_L80
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A85B6E80
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L80:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L81:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rcx,rdi
       mov       rdx,7FF8A85EB4C8
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8A84D7B28]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8A84D75E8]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8A7B618B0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8A84D7600]
       jmp       near ptr M01_L51
M01_L86:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L102
M01_L87:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A85B6E80
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84D7348]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rdx,7FF8A85E4C00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L92:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L93:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L94
       jmp       short M01_L95
M01_L94:
       mov       rdx,7FF8A85B6E80
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84D7348]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L96:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L97
       jmp       short M01_L98
M01_L97:
       mov       rdx,7FF8A85E4C00
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A84D7828]
       jmp       short M01_L102
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L56
M01_L101:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84D7840]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L56
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L102:
       test      eax,eax
       je        near ptr M01_L56
       jmp       near ptr M01_L59
M01_L103:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L104:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L57
M01_L105:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+18]
M01_L108:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+68]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+38]
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M01_L109
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L109
       mov       rcx,rax
       mov       r11,7FF8A7B618B0
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3644
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8552B28
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83D6190]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
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
       call      qword ptr [7FF8A83D6238]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8585988
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
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
       call      qword ptr [7FF8A84063E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A84063B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8530AC8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406190]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 118
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
       call      qword ptr [7FF8A8406238]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7D46288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8A81AF108]
       mov       ecx,66ED
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A83DD6C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A83DD6E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 241
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L08
       cmp       rsi,rbx
       je        near ptr M01_L09
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M01_L16
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L10
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
M01_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L13
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L07
M01_L03:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       rcx,rbp
       call      qword ptr [r11]
       cmp       edi,eax
       jle       near ptr M01_L16
M01_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rdx,7FF8A84EE488
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8A84EE498
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8A84EE4A8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L09:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FF8A84EE4A8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L12:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dil
       movzx     edi,dil
       jmp       near ptr M01_L17
M01_L13:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FF8A84EE498
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8A8604CA8]
       test      eax,eax
       je        near ptr M01_L02
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       jne       near ptr M01_L04
       mov       rcx,rbx
       mov       rdx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8A8496CD0]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A8496CE8]
       mov       [rsp+20],rax
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       cmp       eax,[rsp+20]
       jne       near ptr M01_L04
       cmp       dword ptr [rsp+24],0
       sete      dil
       movzx     edi,dil
M01_L17:
       movzx     eax,dil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 532
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
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A663F80008
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
       call      qword ptr [7FF8A83DF930]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7D86288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8A81EF558]
       mov       ecx,66ED
       mov       rdx,7FF8A7F14D10
       call      qword ptr [7FF8A7E57798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F14D10
       call      qword ptr [7FF8A7E57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F14D10
       call      qword ptr [7FF8A7E57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A841D650]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A841D668]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 241
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L08
       cmp       rsi,rbx
       je        near ptr M01_L09
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M01_L16
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L10
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
M01_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L13
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L07
M01_L03:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       rcx,rbp
       call      qword ptr [r11]
       cmp       edi,eax
       jle       near ptr M01_L16
M01_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rdx,7FF8A8551AB0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8A8551AD0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8A8551AE0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8A7E5C228]
       int       3
M01_L09:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FF8A8551AE0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L12:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dil
       movzx     edi,dil
       jmp       near ptr M01_L17
M01_L13:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FF8A8551AD0
       call      qword ptr [7FF8A7C3C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8A84D7900]
       test      eax,eax
       je        near ptr M01_L02
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       jne       near ptr M01_L04
       mov       rcx,rbx
       mov       rdx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8A84D6FB8]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84D6FD0]
       mov       [rsp+20],rax
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       cmp       eax,[rsp+20]
       jne       near ptr M01_L04
       cmp       dword ptr [rsp+24],0
       sete      dil
       movzx     edi,dil
M01_L17:
       movzx     eax,dil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 532
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
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21319490008
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
       call      qword ptr [7FF8A841FAE0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7D66288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8A81CF018]
       mov       ecx,66ED
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A83EDAE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A83EDB00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 241
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L08
       cmp       rsi,rbx
       je        near ptr M01_L09
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M01_L16
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L10
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
M01_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L13
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L07
M01_L03:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       rcx,rbp
       call      qword ptr [r11]
       cmp       edi,eax
       jle       near ptr M01_L16
M01_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rdx,7FF8A85C4528
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8A85C4538
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8A85C4548
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8A7E3C228]
       int       3
M01_L09:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FF8A85C4548
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L12:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dil
       movzx     edi,dil
       jmp       near ptr M01_L17
M01_L13:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FF8A85C4538
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8A84B7900]
       test      eax,eax
       je        near ptr M01_L02
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       jne       near ptr M01_L04
       mov       rcx,rbx
       mov       rdx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8A84B7468]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84B7480]
       mov       [rsp+20],rax
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       cmp       eax,[rsp+20]
       jne       near ptr M01_L04
       cmp       dword ptr [rsp+24],0
       sete      dil
       movzx     edi,dil
M01_L17:
       movzx     eax,dil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 532
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
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2837B130008
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
       call      qword ptr [7FF8A83EFA50]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7D76288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8A81DF558]
       mov       ecx,66ED
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A832E040]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A832E058]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 241
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L08
       cmp       rsi,rbx
       je        near ptr M01_L09
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M01_L16
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L10
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
M01_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L13
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L07
M01_L03:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       rcx,rbp
       call      qword ptr [r11]
       cmp       edi,eax
       jle       near ptr M01_L16
M01_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rdx,7FF8A85ED028
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8A85ED038
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8A85ED048
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8A7E4C228]
       int       3
M01_L09:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FF8A85ED048
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L12:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dil
       movzx     edi,dil
       jmp       near ptr M01_L17
M01_L13:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FF8A85ED038
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8A84C7F60]
       test      eax,eax
       je        near ptr M01_L02
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       jne       near ptr M01_L04
       mov       rcx,rbx
       mov       rdx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8A84C7B58]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84C7B70]
       mov       [rsp+20],rax
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       cmp       eax,[rsp+20]
       jne       near ptr M01_L04
       cmp       dword ptr [rsp+24],0
       sete      dil
       movzx     edi,dil
M01_L17:
       movzx     eax,dil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 532
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
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B321440008
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
       call      qword ptr [7FF8A84C41B0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7D76288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8A81DF558]
       mov       ecx,66ED
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A8325BD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A8325BF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 241
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L08
       cmp       rsi,rbx
       je        near ptr M01_L09
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M01_L16
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L10
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L06
M01_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L13
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L07
M01_L03:
       mov       edi,[rbx+28]
       sub       edi,[rbx+30]
       mov       rcx,rbp
       call      qword ptr [r11]
       cmp       edi,eax
       jle       near ptr M01_L16
M01_L04:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       mov       rdx,7FF8A85FC3F8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8A85FC408
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8A85FC418
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8A7E4C228]
       int       3
M01_L09:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FF8A85FC418
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L12:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dil
       movzx     edi,dil
       jmp       near ptr M01_L17
M01_L13:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FF8A85FC408
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8A84EC0C0]
       test      eax,eax
       je        near ptr M01_L02
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       jne       near ptr M01_L04
       mov       rcx,rbx
       mov       rdx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8A84E7CC0]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8A84E7CD8]
       mov       [rsp+20],rax
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       cmp       eax,[rsp+20]
       jne       near ptr M01_L04
       cmp       dword ptr [rsp+24],0
       sete      dil
       movzx     edi,dil
M01_L17:
       movzx     eax,dil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 532
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
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AAE8420008
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
       call      qword ptr [7FF8A844F5B8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A85B1B58
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8445AD0
       call      qword ptr [7FF8A8416328]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8428800
       call      qword ptr [7FF8A7E57B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A84169D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8416988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A8592238
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8425BF8
       call      qword ptr [7FF8A83F6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8408800
       call      qword ptr [7FF8A7E37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83F6A00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83F69B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A851DCE8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84155B8
       call      qword ptr [7FF8A83E6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F8680
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6910]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E68C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A84EDB30
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A83C2220
       call      qword ptr [7FF8A82EE688]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 132
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83B9EF0
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A82EED30]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82EECE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A857B058
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A84088F0
       call      qword ptr [7FF8A83E5DD0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F9EC0
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E63B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A856BE10
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8415AD0
       call      qword ptr [7FF8A83E6328]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A83F8018
       call      qword ptr [7FF8A7E27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A83E6958]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A83E6910]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2D8]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF8A85363F8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8A8435AD0
       call      qword ptr [7FF8A8406358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 133
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
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF8A8418018
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8A8406988]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8406940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		other = other.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var copy = new HashSet<T>(this._set, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		copy.UnionWith(other);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		if (copy.Count == this._set.Count)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var added = copy.Where(i => !this._set.Contains(i)).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = copy;
; 		^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M01_L88
       mov       [rbp+18],rsi
       mov       r14,[rbx+8]
       mov       r15,r14
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L89
       mov       rsi,[rbp+18]
       mov       r13,[r14+18]
       test      r13,r13
       je        near ptr M01_L92
M01_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L82
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rbp-0A0],r14
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M01_L95
M01_L02:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L98
M01_L03:
       test      r15,r15
       je        near ptr M01_L101
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L83
       mov       rcx,rax
M01_L04:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       mov       [rbp-0A8],r13
       test      r13,r13
       je        near ptr M01_L117
       mov       r12,[r14+18]
       test      r12,r12
       je        near ptr M01_L102
M01_L05:
       mov       rdx,[r13+18]
       test      rdx,rdx
       je        near ptr M01_L105
M01_L06:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L117
       mov       ecx,[r13+28]
       sub       ecx,[r13+30]
       je        near ptr M01_L19
       mov       rax,[r13+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L108
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF8A7BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
M01_L08:
       cmp       r12d,r15d
       jl        near ptr M01_L113
       mov       [rbp+18],rsi
       mov       r15,[r13+8]
       mov       [rbp-0B0],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L10
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L10:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-50]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L11
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L11:
       mov       r15,[rbp-0B0]
       lea       rdx,[r15+8]
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-50]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L84
       cmp       r8,4000
       ja        near ptr M01_L110
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L109
M01_L12:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0A0]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       rbx,[r13+10]
       mov       [rbp-0B8],rbx
       cmp       [rbx],bl
       mov       [rbp-58],rbx
       lea       rcx,[rbp-58]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L14
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L14:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L15
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L15:
       mov       rbx,[rbp-0B8]
       lea       rdx,[rbx+8]
       mov       rcx,[rbp-58]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-58]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L85
       cmp       r8,4000
       ja        near ptr M01_L112
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L111
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       r14,[rbp-0A0]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M01_L86
       mov       rcx,rax
M01_L17:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L18
       cmp       [rdx],rcx
       je        short M01_L18
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M01_L18:
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       edx,[r13+2C]
       mov       [r14+2C],edx
       mov       edx,[r13+30]
       mov       [r14+30],edx
       mov       edx,[r13+28]
       mov       [r14+28],edx
       mov       rdx,[r13+20]
       mov       [r14+20],rdx
       mov       rsi,[rbp+18]
M01_L19:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        near ptr M01_L87
M01_L20:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-0C0],rax
M01_L21:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       jne       near ptr M01_L56
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L40
       mov       [rax+8],ecx
M01_L22:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D8]
       test      r11,r11
       je        near ptr M01_L41
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L43
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L57
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L59
       mov       rsi,[r11+rcx*8+10]
M01_L24:
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L44
M01_L25:
       mov       rdi,[r14+10]
       mov       r15,[r14+18]
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L38
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        near ptr M01_L42
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L50
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M01_L45
       mov       rcx,24FC7800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0EE105C2B
       mov       r10d,8CBC3247
       cmp       edx,8
       jb        near ptr M01_L36
       mov       r9d,edx
       shr       r9d,3
M01_L27:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L27
       test      dl,4
       jne       near ptr M01_L37
M01_L28:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L29:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L30:
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-0D0],r8
       mov       r10d,[r8]
       dec       r10d
       js        short M01_L33
M01_L31:
       cmp       r10d,[rdi+8]
       jae       near ptr M01_L59
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[rdi+rcx+10]
       mov       [rbp-0D8],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L51
M01_L32:
       mov       rax,[rbp-0C0]
       mov       r10,[rbp-0D8]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [rdi+8],r13d
       jb        near ptr M01_L58
       test      r10d,r10d
       jge       short M01_L31
M01_L33:
       cmp       dword ptr [r14+30],0
       jg        near ptr M01_L39
       mov       edx,[r14+28]
       mov       [rbp-5C],edx
       cmp       [rdi+8],edx
       je        near ptr M01_L54
M01_L34:
       mov       edx,[rbp-5C]
       mov       edi,edx
       lea       ecx,[rdi+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r10,rcx
M01_L35:
       cmp       edi,[r10+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       shl       rcx,4
       mov       [rbp-0C8],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-0D0]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       r12,[rbp-0D0]
       mov       [r12],edi
       inc       dword ptr [r14+34]
       cmp       r13d,64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L55
M01_L36:
       cmp       edx,4
       jb        near ptr M01_L46
M01_L37:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L28
M01_L38:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L39:
       mov       ecx,[r14+2C]
       mov       r10d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L59
       shl       rcx,4
       mov       ecx,[rdi+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       rcx,rdi
       mov       edi,r10d
       mov       r10,rcx
       jmp       near ptr M01_L35
M01_L40:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L60
M01_L41:
       mov       rdx,7FF8A84EBBC0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L42:
       mov       rdx,7FF8A8472388
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L26
M01_L43:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L24
M01_L44:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L25
M01_L45:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L46:
       mov       r9d,80
       test      dl,1
       je        short M01_L47
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L47:
       test      dl,2
       je        short M01_L48
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L48:
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L49:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L50:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L51:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rdx,7FF8A84723A0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L53:
       mov       rax,[rbp-0D8]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L32
M01_L54:
       mov       rcx,r14
       call      qword ptr [7FF8A8497390]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       rdi,r8
       mov       [rbp-0D0],rdi
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L34
M01_L55:
       mov       rdi,[rbp-0C8]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8A7BFE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8A7B417B0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8A8494348]
       int       3
M01_L58:
       call      qword ptr [7FF8A7E17A08]
       int       3
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L60:
       mov       ecx,[r14+28]
       sub       ecx,[r14+30]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+28]
       sub       eax,[rdx+30]
       cmp       eax,ecx
       je        near ptr M01_L73
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L74
M01_L61:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].<UnionWith>b__52_0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        near ptr M01_L75
M01_L62:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L76
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L63:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L124
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       near ptr M01_L77
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L77
M01_L64:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L125
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L78
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L78
M01_L65:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L133
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L79
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L79
M01_L66:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L67:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+38]
       test      rsi,rsi
       je        near ptr M01_L80
M01_L68:
       test      r13,r13
       je        near ptr M01_L136
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L81
M01_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L138
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L137
       mov       rcx,rax
       call      qword ptr [7FF8A7FA61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,24FDD8007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L142
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L141
M01_L71:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,24FDD8007C0
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L143
       mov       dword ptr [rsi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],0FFFFFFFF
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L145
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L144
M01_L72:
       mov       rdx,24FDD8007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L147
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L146
M01_L73:
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L74:
       mov       rdx,7FF8A83E6DC8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8A83E6E10
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBD98
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBDA8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBEB8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBEC8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8A83E6E60
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8A84EE610
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8A8318F60
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8A84EBA80
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8A84CFAD8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8A84EBBA8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8A81AF540]
       mov       ecx,66ED
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A83DDE60]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A83DDE78]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A8]
       test      r13,r13
       je        short M01_L90
       jmp       short M01_L91
M01_L90:
       mov       rdx,7FF8A84CFAF0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84975B8]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L92:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L93
       jmp       short M01_L94
M01_L93:
       mov       rdx,7FF8A84E7848
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L94:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L00
M01_L95:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L96
       jmp       short M01_L97
M01_L96:
       mov       rdx,7FF8A84E7848
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8A7BF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L03
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rdx,7FF8A84CFAF0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L100:
       mov       rcx,rdx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L101:
       mov       ecx,17
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L102:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rdx,7FF8A84E7848
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L104:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r12,[rax]
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L05
M01_L105:
       mov       rcx,[r13]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rdx,7FF8A84E7848
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L107:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L06
M01_L108:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L07
       mov       r12d,7FFFFFC3
       jmp       near ptr M01_L08
M01_L109:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L110:
       call      qword ptr [7FF8A82FC8D0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8A82FC8D0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r13+10]
       xor       r15d,r15d
       jmp       short M01_L116
M01_L114:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L148
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L115
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L115:
       inc       r15d
M01_L116:
       cmp       r15d,[r13+28]
       jl        short M01_L114
       jmp       near ptr M01_L19
M01_L117:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M01_L118
       mov       rcx,rax
       jmp       short M01_L119
M01_L118:
       mov       rdx,7FF8A84EBA90
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L119:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L122
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M01_L120
       jmp       short M01_L121
M01_L120:
       mov       rdx,7FF8A84EBAA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8A7D46240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       near ptr M01_L19
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       near ptr M01_L19
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF8A84973A8]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8A7B417B8
       call      qword ptr [r11]
       jmp       near ptr M01_L60
M01_L124:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L67
M01_L125:
       cmp       dword ptr [r15+8],0
       jne       short M01_L130
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L126
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L126
       jmp       short M01_L127
M01_L126:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBEF8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8A84CA380
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L129:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L67
M01_L130:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L131
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBEE8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A8605818]
       jmp       near ptr M01_L67
M01_L133:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L134
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L134
       jmp       short M01_L135
M01_L134:
       mov       rcx,rdi
       mov       rdx,7FF8A84EBED8
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A8605830]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8A7E17E58]
       int       3
M01_L137:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L70
M01_L138:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L139
       jmp       short M01_L140
M01_L139:
       mov       rcx,rsi
       mov       rdx,7FF8A84EE600
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8A82F4510]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L70
M01_L141:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L71
M01_L142:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L71
M01_L143:
       mov       ecx,433
       mov       rdx,7FF8A7FF8338
       call      qword ptr [7FF8A7E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A83DE4C0]
       int       3
M01_L144:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L72
M01_L145:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L72
M01_L146:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L73
M01_L147:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L73
M01_L148:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L149
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       je        short M01_L149
       mov       rcx,rax
       mov       r11,7FF8A7B417B8
       call      qword ptr [r11]
M01_L149:
       nop
       add       rsp,28
       ret
; Total bytes of code 4986
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A802BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		other = other.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var copy = new HashSet<T>(this._set, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		copy.UnionWith(other);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		if (copy.Count == this._set.Count)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var added = copy.Where(i => !this._set.Contains(i)).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = copy;
; 		^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M01_L88
       mov       [rbp+18],rsi
       mov       r14,[rbx+8]
       mov       r15,r14
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L89
       mov       rsi,[rbp+18]
       mov       r13,[r14+18]
       test      r13,r13
       je        near ptr M01_L92
M01_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L82
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rbp-0A0],r14
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M01_L95
M01_L02:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14]
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L98
M01_L03:
       test      r15,r15
       je        near ptr M01_L101
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L83
M01_L04:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       mov       [rbp-0A8],r12
       test      r12,r12
       je        near ptr M01_L118
       mov       rax,[r14+18]
       test      rax,rax
       je        near ptr M01_L102
M01_L05:
       mov       rdx,[r12+18]
       test      rdx,rdx
       je        near ptr M01_L105
M01_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L109
       mov       ecx,[r12+28]
       sub       ecx,[r12+30]
       je        near ptr M01_L19
       mov       rax,[r12+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L108
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF8A7C25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edx,eax
M01_L08:
       cmp       edx,r15d
       jl        near ptr M01_L114
       mov       [rbp+18],rsi
       mov       r15,[r12+8]
       mov       [rbp-0B8],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF8A7D79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L10
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L10:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-50]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L11
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L11:
       mov       r15,[rbp-0B8]
       lea       rdx,[r15+8]
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-50]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L84
       cmp       r8,4000
       ja        near ptr M01_L111
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L110
M01_L12:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0A0]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-0A8]
       mov       rbx,[r12+10]
       mov       [rbp-0C0],rbx
       cmp       [rbx],bl
       mov       [rbp-58],rbx
       lea       rcx,[rbp-58]
       mov       rax,7FF8A7D79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L14
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L14:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L15
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L15:
       mov       rbx,[rbp-0C0]
       lea       rdx,[rbx+8]
       mov       rcx,[rbp-58]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-58]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L85
       cmp       r8,4000
       ja        near ptr M01_L113
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L112
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M01_L86
M01_L17:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L18
       cmp       [rdx],rcx
       je        short M01_L18
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M01_L18:
       mov       r14,[rbp-0A0]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-0A8]
       mov       edx,[r12+2C]
       mov       [r14+2C],edx
       mov       edx,[r12+30]
       mov       [r14+30],edx
       mov       edx,[r12+28]
       mov       [r14+28],edx
       mov       rdx,[r12+20]
       mov       [r14+20],rdx
       mov       rsi,[rbp+18]
M01_L19:
       mov       r14,[rbp-0A0]
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L87
M01_L20:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M01_L21:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       jne       near ptr M01_L56
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L40
       mov       [rax+8],ecx
M01_L22:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D8]
       test      r11,r11
       je        near ptr M01_L41
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L43
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L57
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L59
       mov       rsi,[r11+rcx*8+10]
M01_L24:
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L44
M01_L25:
       mov       rdi,[r14+10]
       mov       r15,[r14+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M01_L38
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        near ptr M01_L42
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L50
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M01_L45
       mov       rcx,21492400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,9612C1C4
       mov       r10d,3F73732C
       cmp       edx,8
       jb        near ptr M01_L36
       mov       r9d,edx
       shr       r9d,3
M01_L27:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L27
       test      dl,4
       jne       near ptr M01_L37
M01_L28:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L29:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       r10d,edx
       rol       r10d,13
       xor       r8d,r10d
M01_L30:
       mov       [rbp-5C],r8d
       mov       rcx,[r14+8]
       mov       edx,r8d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rbp-0D8],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M01_L33
M01_L31:
       cmp       r9d,[rdi+8]
       jae       near ptr M01_L59
       mov       ecx,r9d
       shl       rcx,4
       lea       r9,[rdi+rcx+10]
       mov       [rbp-0E0],r9
       cmp       [r9+8],r8d
       je        near ptr M01_L51
M01_L32:
       mov       rax,[rbp-0C8]
       mov       r9,[rbp-0E0]
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [rdi+8],r12d
       jb        near ptr M01_L58
       test      r9d,r9d
       mov       r8d,[rbp-5C]
       jge       short M01_L31
M01_L33:
       cmp       dword ptr [r14+30],0
       jg        near ptr M01_L39
       mov       edx,[r14+28]
       mov       [rbp-60],edx
       cmp       [rdi+8],edx
       je        near ptr M01_L54
M01_L34:
       mov       edx,[rbp-60]
       mov       edi,edx
       lea       ecx,[rdi+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r9,rcx
M01_L35:
       cmp       edi,[r9+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       shl       rcx,4
       mov       [rbp-0D0],r9
       lea       rcx,[r9+rcx+10]
       mov       [rcx+8],r8d
       mov       r10,[rbp-0D8]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       rdx,[rbp-0D8]
       mov       [rdx],edi
       inc       dword ptr [r14+34]
       cmp       r12d,64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L55
M01_L36:
       cmp       edx,4
       jb        near ptr M01_L46
M01_L37:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L28
M01_L38:
       xor       r8d,r8d
       jmp       near ptr M01_L30
M01_L39:
       mov       ecx,[r14+2C]
       mov       r9d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L59
       shl       rcx,4
       mov       ecx,[rdi+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       rcx,rdi
       mov       edi,r9d
       mov       r9,rcx
       jmp       near ptr M01_L35
M01_L40:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L60
M01_L41:
       mov       rcx,r13
       mov       rdx,7FF8A855B690
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L23
M01_L42:
       mov       rcx,r13
       mov       rdx,7FF8A84A2948
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L26
M01_L43:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L24
M01_L44:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L25
M01_L45:
       xor       r8d,r8d
       jmp       near ptr M01_L30
M01_L46:
       mov       r9d,80
       test      dl,1
       je        short M01_L47
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L47:
       test      dl,2
       je        short M01_L48
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L48:
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L49:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L30
M01_L50:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L30
M01_L51:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+98]
       test      r11,r11
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,r13
       mov       rdx,7FF8A84A2960
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L53:
       mov       rax,[rbp-0E0]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L32
M01_L54:
       mov       rcx,r14
       call      qword ptr [7FF8A84B74E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[r14+8]
       mov       edi,[rbp-5C]
       mov       edx,edi
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-0D8],rax
       mov       r8d,edi
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L34
M01_L55:
       mov       rdi,[rbp-0D0]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FF8A7FADA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8A7C2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8A7B714C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C8]
       jne       near ptr M01_L22
       jmp       near ptr M01_L126
M01_L57:
       call      qword ptr [7FF8A84B4618]
       int       3
M01_L58:
       call      qword ptr [7FF8A7E47A08]
       int       3
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L60:
       mov       ecx,[r14+28]
       sub       ecx,[r14+30]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+28]
       sub       eax,[rdx+30]
       cmp       eax,ecx
       je        near ptr M01_L73
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L74
M01_L61:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].<UnionWith>b__52_0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        near ptr M01_L75
M01_L62:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L76
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L63:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L127
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       near ptr M01_L77
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L77
M01_L64:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L128
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L78
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L78
M01_L65:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L136
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L79
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L79
M01_L66:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L67:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+38]
       test      rsi,rsi
       je        near ptr M01_L80
M01_L68:
       test      r13,r13
       je        near ptr M01_L139
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L81
M01_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L141
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L140
       mov       rcx,rax
       call      qword ptr [7FF8A7FD61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,214A84007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L145
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L144
M01_L71:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,214A84007C0
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L146
       mov       dword ptr [rsi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],0FFFFFFFF
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L148
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L147
M01_L72:
       mov       rdx,214A84007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L150
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L149
M01_L73:
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L74:
       mov       rdx,7FF8A8416FE0
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8A8417028
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8A855B868
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8A855B878
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8A855B988
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A855B998
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8A8417078
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8A855E048
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8A8348F70
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rcx,r13
       mov       rdx,7FF8A855B550
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rcx,r13
       mov       rdx,7FF8A84FFE40
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rcx,r13
       mov       rdx,7FF8A855B678
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8A81DF570]
       mov       ecx,66ED
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A840DE00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A840DE18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A8]
       test      r13,r13
       je        short M01_L90
       jmp       short M01_L91
M01_L90:
       mov       rdx,7FF8A84FFE58
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84B7B10]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L92:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L93
       jmp       short M01_L94
M01_L93:
       mov       rdx,7FF8A8518D68
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L94:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L00
M01_L95:
       mov       r13,[r14]
       mov       rcx,r13
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L96
       jmp       short M01_L97
M01_L96:
       mov       rdx,7FF8A8518D68
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8A7C26358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M01_L03
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rcx,r13
       mov       rdx,7FF8A84FFE58
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L100:
       mov       rdx,r12
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L101:
       mov       ecx,17
       call      qword ptr [7FF8A7E4C228]
       int       3
M01_L102:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rcx,r13
       mov       rdx,7FF8A8518D68
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L104:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0B0],rax
       mov       rax,[rbp-0B0]
       jmp       near ptr M01_L05
M01_L105:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L106
       mov       [rbp-0B0],rax
       jmp       short M01_L107
M01_L106:
       mov       [rbp-0B0],rax
       mov       rdx,7FF8A8518D68
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L107:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rax,[rbp-0B0]
       jmp       near ptr M01_L06
M01_L108:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L07
       mov       edx,7FFFFFC3
       jmp       near ptr M01_L08
M01_L109:
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L118
M01_L110:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L111:
       call      qword ptr [7FF8A81DEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L112:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L113:
       call      qword ptr [7FF8A81DEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L114:
       mov       r14,[rbp-0A0]
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r14
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r12+10]
       xor       r15d,r15d
       jmp       short M01_L117
M01_L115:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L151
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L116
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF8A7C2E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L116:
       inc       r15d
M01_L117:
       cmp       r15d,[r12+28]
       jl        short M01_L115
       jmp       near ptr M01_L19
M01_L118:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L119
       jmp       short M01_L120
M01_L119:
       mov       rcx,r13
       mov       rdx,7FF8A855B560
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L120:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L123
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        short M01_L121
       jmp       short M01_L122
M01_L121:
       mov       rcx,r13
       mov       rdx,7FF8A855B570
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L122:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L123
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L123:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8A7D76240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       short M01_L125
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       short M01_L124
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF8A84B7900]
       jmp       near ptr M01_L19
M01_L124:
       jmp       near ptr M01_L19
M01_L125:
       jmp       near ptr M01_L19
M01_L126:
       mov       rcx,rax
       mov       r11,7FF8A7B714D0
       call      qword ptr [r11]
       jmp       near ptr M01_L60
M01_L127:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L67
M01_L128:
       cmp       dword ptr [r15+8],0
       jne       short M01_L133
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L129
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L129
       jmp       short M01_L130
M01_L129:
       mov       rcx,rdi
       mov       rdx,7FF8A855B9C8
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L130:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rdx,7FF8A84FB658
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L132:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L67
M01_L133:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L134
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L134
       jmp       short M01_L135
M01_L134:
       mov       rcx,rdi
       mov       rdx,7FF8A855B9B8
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BC798]
       jmp       near ptr M01_L67
M01_L136:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L137
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L137
       jmp       short M01_L138
M01_L137:
       mov       rcx,rdi
       mov       rdx,7FF8A855B9A8
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L138:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BC7B0]
       jmp       near ptr M01_L67
M01_L139:
       mov       ecx,11
       call      qword ptr [7FF8A7E47E58]
       int       3
M01_L140:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L70
M01_L141:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L142
       jmp       short M01_L143
M01_L142:
       mov       rcx,rsi
       mov       rdx,7FF8A855E028
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L143:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8A8324528]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L70
M01_L144:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L71
M01_L145:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L71
M01_L146:
       mov       ecx,433
       mov       rdx,7FF8A8028338
       call      qword ptr [7FF8A7E47798]
       mov       rcx,rax
       call      qword ptr [7FF8A840E448]
       int       3
M01_L147:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L72
M01_L148:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L72
M01_L149:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L73
M01_L150:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L73
M01_L151:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M01_L152
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M01_L152
       mov       rcx,rax
       mov       r11,7FF8A7B714D0
       call      qword ptr [r11]
M01_L152:
       nop
       add       rsp,28
       ret
; Total bytes of code 5052
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		other = other.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var copy = new HashSet<T>(this._set, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		copy.UnionWith(other);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		if (copy.Count == this._set.Count)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var added = copy.Where(i => !this._set.Contains(i)).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = copy;
; 		^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M01_L88
       mov       [rbp+18],rsi
       mov       r14,[rbx+8]
       mov       r15,r14
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L89
       mov       rsi,[rbp+18]
       mov       r13,[r14+18]
       test      r13,r13
       je        near ptr M01_L92
M01_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L82
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rbp-0A0],r14
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M01_L95
M01_L02:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L98
M01_L03:
       test      r15,r15
       je        near ptr M01_L101
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L83
       mov       rcx,rax
M01_L04:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       mov       [rbp-0A8],r13
       test      r13,r13
       je        near ptr M01_L117
       mov       r12,[r14+18]
       test      r12,r12
       je        near ptr M01_L102
M01_L05:
       mov       rdx,[r13+18]
       test      rdx,rdx
       je        near ptr M01_L105
M01_L06:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L117
       mov       ecx,[r13+28]
       sub       ecx,[r13+30]
       je        near ptr M01_L19
       mov       rax,[r13+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L108
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF8A7BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
M01_L08:
       cmp       r12d,r15d
       jl        near ptr M01_L113
       mov       [rbp+18],rsi
       mov       r15,[r13+8]
       mov       [rbp-0B0],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L10
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L10:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-50]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L11
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L11:
       mov       r15,[rbp-0B0]
       lea       rdx,[r15+8]
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-50]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L84
       cmp       r8,4000
       ja        near ptr M01_L110
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L109
M01_L12:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0A0]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       rbx,[r13+10]
       mov       [rbp-0B8],rbx
       cmp       [rbx],bl
       mov       [rbp-58],rbx
       lea       rcx,[rbp-58]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L14
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L14:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L15
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L15:
       mov       rbx,[rbp-0B8]
       lea       rdx,[rbx+8]
       mov       rcx,[rbp-58]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-58]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L85
       cmp       r8,4000
       ja        near ptr M01_L112
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L111
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       r14,[rbp-0A0]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M01_L86
       mov       rcx,rax
M01_L17:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L18
       cmp       [rdx],rcx
       je        short M01_L18
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M01_L18:
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       edx,[r13+2C]
       mov       [r14+2C],edx
       mov       edx,[r13+30]
       mov       [r14+30],edx
       mov       edx,[r13+28]
       mov       [r14+28],edx
       mov       rdx,[r13+20]
       mov       [r14+20],rdx
       mov       rsi,[rbp+18]
M01_L19:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        near ptr M01_L87
M01_L20:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-0C0],rax
M01_L21:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       jne       near ptr M01_L56
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L40
       mov       [rax+8],ecx
M01_L22:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D8]
       test      r11,r11
       je        near ptr M01_L41
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L43
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L57
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L59
       mov       rsi,[r11+rcx*8+10]
M01_L24:
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L44
M01_L25:
       mov       rdi,[r14+10]
       mov       r15,[r14+18]
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L38
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        near ptr M01_L42
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L50
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M01_L45
       mov       rcx,1A290800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,240C5368
       mov       r10d,0E67BCC4F
       cmp       edx,8
       jb        near ptr M01_L36
       mov       r9d,edx
       shr       r9d,3
M01_L27:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L27
       test      dl,4
       jne       near ptr M01_L37
M01_L28:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L29:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L30:
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-0D0],r8
       mov       r10d,[r8]
       dec       r10d
       js        short M01_L33
M01_L31:
       cmp       r10d,[rdi+8]
       jae       near ptr M01_L59
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[rdi+rcx+10]
       mov       [rbp-0D8],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L51
M01_L32:
       mov       rax,[rbp-0C0]
       mov       r10,[rbp-0D8]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [rdi+8],r13d
       jb        near ptr M01_L58
       test      r10d,r10d
       jge       short M01_L31
M01_L33:
       cmp       dword ptr [r14+30],0
       jg        near ptr M01_L39
       mov       edx,[r14+28]
       mov       [rbp-5C],edx
       cmp       [rdi+8],edx
       je        near ptr M01_L54
M01_L34:
       mov       edx,[rbp-5C]
       mov       edi,edx
       lea       ecx,[rdi+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r10,rcx
M01_L35:
       cmp       edi,[r10+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       shl       rcx,4
       mov       [rbp-0C8],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-0D0]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       r12,[rbp-0D0]
       mov       [r12],edi
       inc       dword ptr [r14+34]
       cmp       r13d,64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L55
M01_L36:
       cmp       edx,4
       jb        near ptr M01_L46
M01_L37:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L28
M01_L38:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L39:
       mov       ecx,[r14+2C]
       mov       r10d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L59
       shl       rcx,4
       mov       ecx,[rdi+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       rcx,rdi
       mov       edi,r10d
       mov       r10,rcx
       jmp       near ptr M01_L35
M01_L40:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L60
M01_L41:
       mov       rdx,7FF8A85B31C8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L42:
       mov       rdx,7FF8A8465A58
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L26
M01_L43:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L24
M01_L44:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L25
M01_L45:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L46:
       mov       r9d,80
       test      dl,1
       je        short M01_L47
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L47:
       test      dl,2
       je        short M01_L48
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L48:
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L49:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L50:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L51:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rdx,7FF8A8465A70
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L53:
       mov       rax,[rbp-0D8]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L32
M01_L54:
       mov       rcx,r14
       call      qword ptr [7FF8A8487468]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       rdi,r8
       mov       [rbp-0D0],rdi
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L34
M01_L55:
       mov       rdi,[rbp-0C8]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8A7BFE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8A7B41618
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8A84845E8]
       int       3
M01_L58:
       call      qword ptr [7FF8A7E17A08]
       int       3
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L60:
       mov       ecx,[r14+28]
       sub       ecx,[r14+30]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+28]
       sub       eax,[rdx+30]
       cmp       eax,ecx
       je        near ptr M01_L73
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L74
M01_L61:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].<UnionWith>b__52_0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        near ptr M01_L75
M01_L62:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L76
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L63:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L124
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       near ptr M01_L77
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L77
M01_L64:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L125
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L78
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L78
M01_L65:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L133
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L79
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L79
M01_L66:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L67:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+38]
       test      rsi,rsi
       je        near ptr M01_L80
M01_L68:
       test      r13,r13
       je        near ptr M01_L136
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L81
M01_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L138
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L137
       mov       rcx,rax
       call      qword ptr [7FF8A7FA61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,1A2A68007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L142
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L141
M01_L71:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A2A68007C0
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L143
       mov       dword ptr [rsi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],0FFFFFFFF
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L145
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L144
M01_L72:
       mov       rdx,1A2A68007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L147
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L146
M01_L73:
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L74:
       mov       rdx,7FF8A83E8E88
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8A83E8ED0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8A85B33A0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8A85B33B0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8A85B34C0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A85B34D0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8A83E8F20
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8A85B56D0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8A8306F98
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8A85B3088
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8A84E2FA0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8A85B31B0
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8A81AF0F0]
       mov       ecx,66ED
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A83DDE30]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A83DDE48]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A8]
       test      r13,r13
       je        short M01_L90
       jmp       short M01_L91
M01_L90:
       mov       rdx,7FF8A84E2FB8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A8487C78]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L92:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L93
       jmp       short M01_L94
M01_L93:
       mov       rdx,7FF8A84EE800
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L94:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L00
M01_L95:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L96
       jmp       short M01_L97
M01_L96:
       mov       rdx,7FF8A84EE800
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8A7BF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L03
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rdx,7FF8A84E2FB8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L100:
       mov       rcx,rdx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L101:
       mov       ecx,17
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L102:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rdx,7FF8A84EE800
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L104:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r12,[rax]
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L05
M01_L105:
       mov       rcx,[r13]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rdx,7FF8A84EE800
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L107:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L06
M01_L108:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L07
       mov       r12d,7FFFFFC3
       jmp       near ptr M01_L08
M01_L109:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L110:
       call      qword ptr [7FF8A82EC498]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8A82EC498]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r13+10]
       xor       r15d,r15d
       jmp       short M01_L116
M01_L114:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L148
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L115
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L115:
       inc       r15d
M01_L116:
       cmp       r15d,[r13+28]
       jl        short M01_L114
       jmp       near ptr M01_L19
M01_L117:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M01_L118
       mov       rcx,rax
       jmp       short M01_L119
M01_L118:
       mov       rdx,7FF8A85B3098
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L119:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L122
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M01_L120
       jmp       short M01_L121
M01_L120:
       mov       rdx,7FF8A85B30A8
       call      qword ptr [7FF8A7BFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8A7D46240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       near ptr M01_L19
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       near ptr M01_L19
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF8A8487A80]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8A7B41620
       call      qword ptr [r11]
       jmp       near ptr M01_L60
M01_L124:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L67
M01_L125:
       cmp       dword ptr [r15+8],0
       jne       short M01_L130
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L126
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L126
       jmp       short M01_L127
M01_L126:
       mov       rcx,rdi
       mov       rdx,7FF8A85B3500
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8A84BEC18
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L129:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L67
M01_L130:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L131
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rcx,rdi
       mov       rdx,7FF8A85B34F0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A848C708]
       jmp       near ptr M01_L67
M01_L133:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L134
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L134
       jmp       short M01_L135
M01_L134:
       mov       rcx,rdi
       mov       rdx,7FF8A85B34E0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A848C720]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8A7E17E58]
       int       3
M01_L137:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L70
M01_L138:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L139
       jmp       short M01_L140
M01_L139:
       mov       rcx,rsi
       mov       rdx,7FF8A85B56C0
       call      qword ptr [7FF8A7E17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8A82E40D8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L70
M01_L141:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L71
M01_L142:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L71
M01_L143:
       mov       ecx,433
       mov       rdx,7FF8A7FF8338
       call      qword ptr [7FF8A7E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A83DE568]
       int       3
M01_L144:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L72
M01_L145:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L72
M01_L146:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L73
M01_L147:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L73
M01_L148:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L149
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       je        short M01_L149
       mov       rcx,rax
       mov       r11,7FF8A7B41620
       call      qword ptr [r11]
M01_L149:
       nop
       add       rsp,28
       ret
; Total bytes of code 4986
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A802BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		other = other.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var copy = new HashSet<T>(this._set, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		copy.UnionWith(other);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		if (copy.Count == this._set.Count)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var added = copy.Where(i => !this._set.Contains(i)).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = copy;
; 		^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M01_L88
       mov       [rbp+18],rsi
       mov       r14,[rbx+8]
       mov       r15,r14
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L89
       mov       rsi,[rbp+18]
       mov       r13,[r14+18]
       test      r13,r13
       je        near ptr M01_L92
M01_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L82
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rbp-0A0],r14
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M01_L95
M01_L02:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L98
M01_L03:
       test      r15,r15
       je        near ptr M01_L101
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        near ptr M01_L83
       mov       rcx,rax
M01_L04:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       mov       [rbp-0A8],r13
       test      r13,r13
       je        near ptr M01_L117
       mov       r12,[r14+18]
       test      r12,r12
       je        near ptr M01_L102
M01_L05:
       mov       rdx,[r13+18]
       test      rdx,rdx
       je        near ptr M01_L105
M01_L06:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L117
       mov       ecx,[r13+28]
       sub       ecx,[r13+30]
       je        near ptr M01_L19
       mov       rax,[r13+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L108
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF8A7C25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
M01_L08:
       cmp       r12d,r15d
       jl        near ptr M01_L113
       mov       [rbp+18],rsi
       mov       r15,[r13+8]
       mov       [rbp-0B0],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF8A7D79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L10
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L10:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-50]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L11
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L11:
       mov       r15,[rbp-0B0]
       lea       rdx,[r15+8]
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-50]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L84
       cmp       r8,4000
       ja        near ptr M01_L110
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L109
M01_L12:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0A0]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       rbx,[r13+10]
       mov       [rbp-0B8],rbx
       cmp       [rbx],bl
       mov       [rbp-58],rbx
       lea       rcx,[rbp-58]
       mov       rax,7FF8A7D79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L14
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L14:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L15
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L15:
       mov       rbx,[rbp-0B8]
       lea       rdx,[rbx+8]
       mov       rcx,[rbp-58]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-58]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L85
       cmp       r8,4000
       ja        near ptr M01_L112
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L111
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       r14,[rbp-0A0]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M01_L86
       mov       rcx,rax
M01_L17:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L18
       cmp       [rdx],rcx
       je        short M01_L18
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M01_L18:
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0A8]
       mov       edx,[r13+2C]
       mov       [r14+2C],edx
       mov       edx,[r13+30]
       mov       [r14+30],edx
       mov       edx,[r13+28]
       mov       [r14+28],edx
       mov       rdx,[r13+20]
       mov       [r14+20],rdx
       mov       rsi,[rbp+18]
M01_L19:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D0]
       test      r11,r11
       je        near ptr M01_L87
M01_L20:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-0C0],rax
M01_L21:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       jne       near ptr M01_L56
       mov       ecx,[rax+8]
       inc       ecx
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L41
       mov       [rax+8],ecx
M01_L22:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0D8]
       test      r11,r11
       je        near ptr M01_L42
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L44
       mov       ecx,[rax+8]
       cmp       ecx,[rax+0C]
       jae       near ptr M01_L57
       mov       r11,[rax+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L59
       mov       rsi,[r11+rcx*8+10]
M01_L24:
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L45
M01_L25:
       mov       rdi,[r14+10]
       mov       r15,[r14+18]
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L38
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        near ptr M01_L43
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L51
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M01_L46
       mov       rcx,1E0EA000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L50
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,45D2FB95
       mov       r10d,3DF90DE8
       cmp       edx,8
       jb        near ptr M01_L36
       mov       r9d,edx
       shr       r9d,3
M01_L27:
       add       r8d,[rcx]
       mov       r11d,[rcx+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rcx,8
       dec       r9d
       mov       r11d,r8d
       mov       r8d,r10d
       mov       r10d,r11d
       jne       short M01_L27
       test      dl,4
       jne       near ptr M01_L37
M01_L28:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L29:
       add       ecx,r8d
       mov       edx,r10d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r12d,ecx
       rol       r12d,14
       add       r12d,edx
       rol       edx,9
       xor       edx,r12d
       rol       r12d,1B
       add       r12d,edx
       mov       r8d,edx
       rol       r8d,13
       xor       r12d,r8d
M01_L30:
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       [rbp-0D0],r8
       mov       r10d,[r8]
       dec       r10d
       js        short M01_L33
M01_L31:
       cmp       r10d,[rdi+8]
       jae       near ptr M01_L59
       mov       ecx,r10d
       shl       rcx,4
       lea       r10,[rdi+rcx+10]
       mov       [rbp-0D8],r10
       cmp       [r10+8],r12d
       je        near ptr M01_L52
M01_L32:
       mov       rax,[rbp-0C0]
       mov       r10,[rbp-0D8]
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       [rdi+8],r13d
       jb        near ptr M01_L58
       test      r10d,r10d
       jge       short M01_L31
M01_L33:
       cmp       dword ptr [r14+30],0
       jg        near ptr M01_L40
       mov       edx,[r14+28]
       mov       [rbp-5C],edx
       cmp       [rdi+8],edx
       je        near ptr M01_L39
M01_L34:
       mov       edx,[rbp-5C]
       mov       edi,edx
       lea       ecx,[rdi+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r10,rcx
M01_L35:
       cmp       edi,[r10+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       shl       rcx,4
       mov       [rbp-0C8],r10
       lea       rcx,[r10+rcx+10]
       mov       [rcx+8],r12d
       mov       r8,[rbp-0D0]
       mov       edx,[r8]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       r12,[rbp-0D0]
       mov       [r12],edi
       inc       dword ptr [r14+34]
       cmp       r13d,64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L55
M01_L36:
       cmp       edx,4
       jb        near ptr M01_L47
M01_L37:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M01_L28
M01_L38:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L39:
       mov       ecx,[r14+28]
       call      qword ptr [7FF8A7D95038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8A7FADA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r14+8]
       mov       edx,r12d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L59
       mov       edx,edx
       lea       r8,[rcx+rdx*4+10]
       mov       rdi,r8
       mov       [rbp-0D0],rdi
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L34
M01_L40:
       mov       ecx,[r14+2C]
       mov       r10d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L59
       shl       rcx,4
       mov       ecx,[rdi+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       rcx,rdi
       mov       edi,r10d
       mov       r10,rcx
       jmp       near ptr M01_L35
M01_L41:
       mov       ecx,[rax+0C]
       mov       [rax+8],ecx
       jmp       near ptr M01_L60
M01_L42:
       mov       rdx,7FF8A85EF670
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L43:
       mov       rdx,7FF8A84D0A40
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L26
M01_L44:
       mov       rcx,rax
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L24
M01_L45:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L25
M01_L46:
       xor       r12d,r12d
       jmp       near ptr M01_L30
M01_L47:
       mov       r9d,80
       test      dl,1
       je        short M01_L48
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M01_L48:
       test      dl,2
       je        short M01_L49
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L49:
       mov       ecx,r9d
       jmp       near ptr M01_L29
M01_L50:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L51:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L30
M01_L52:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+98]
       test      r11,r11
       je        short M01_L53
       jmp       short M01_L54
M01_L53:
       mov       rdx,7FF8A84D0A58
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L54:
       mov       rax,[rbp-0D8]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L32
M01_L55:
       mov       rdi,[rbp-0C8]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[rdi+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FF8A7FADA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8A7C2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8A7B71708
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8A84B5278]
       int       3
M01_L58:
       call      qword ptr [7FF8A7E47A08]
       int       3
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L60:
       mov       ecx,[r14+28]
       sub       ecx,[r14+30]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+28]
       sub       eax,[rdx+30]
       cmp       eax,ecx
       je        near ptr M01_L73
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L74
M01_L61:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].<UnionWith>b__52_0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        near ptr M01_L75
M01_L62:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L76
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L63:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L124
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       near ptr M01_L77
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L77
M01_L64:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L125
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L78
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L78
M01_L65:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L133
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L79
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L79
M01_L66:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L67:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+38]
       test      rsi,rsi
       je        near ptr M01_L80
M01_L68:
       test      r13,r13
       je        near ptr M01_L136
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L81
M01_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L138
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L137
       mov       rcx,rax
       call      qword ptr [7FF8A7FD61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,1E0EA0027B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L142
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L141
M01_L71:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1E0EA0027B8
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L143
       mov       dword ptr [rsi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],0FFFFFFFF
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L145
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L144
M01_L72:
       mov       rdx,1E0EA0027A8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L147
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L146
M01_L73:
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L74:
       mov       rdx,7FF8A8452060
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8A84520A8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF848
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF858
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF968
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF978
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8A84520F8
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8A85EF478
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8A83F6A28
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8A85EF530
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8A8541368
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8A85EF658
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8A81DF558]
       mov       ecx,66ED
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A832DF08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A832DF20]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A8]
       test      r13,r13
       je        short M01_L90
       jmp       short M01_L91
M01_L90:
       mov       rdx,7FF8A8541380
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84BC570]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L92:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L93
       jmp       short M01_L94
M01_L93:
       mov       rdx,7FF8A85E5B98
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L94:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L00
M01_L95:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L96
       jmp       short M01_L97
M01_L96:
       mov       rdx,7FF8A85E5B98
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8A7C26358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L03
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rdx,7FF8A8541380
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L100:
       mov       rcx,rdx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L101:
       mov       ecx,17
       call      qword ptr [7FF8A7E4C228]
       int       3
M01_L102:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rdx,7FF8A85E5B98
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L104:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r12,[rax]
       mov       r14,[rbp-0A0]
       jmp       near ptr M01_L05
M01_L105:
       mov       rcx,[r13]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rdx,7FF8A85E5B98
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L107:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L06
M01_L108:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L07
       mov       r12d,7FFFFFC3
       jmp       near ptr M01_L08
M01_L109:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L110:
       call      qword ptr [7FF8A81DEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8A81DEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r13+10]
       xor       r15d,r15d
       jmp       short M01_L116
M01_L114:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L148
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L115
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF8A7C2E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L115:
       inc       r15d
M01_L116:
       cmp       r15d,[r13+28]
       jl        short M01_L114
       jmp       near ptr M01_L19
M01_L117:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M01_L118
       mov       rcx,rax
       jmp       short M01_L119
M01_L118:
       mov       rdx,7FF8A85EF540
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L119:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L122
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+0C8]
       test      r11,r11
       je        short M01_L120
       jmp       short M01_L121
M01_L120:
       mov       rdx,7FF8A85EF550
       call      qword ptr [7FF8A7C2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8A7C2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8A7D76240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       near ptr M01_L19
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       near ptr M01_L19
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF8A84BC3C0]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8A7B71710
       call      qword ptr [r11]
       jmp       near ptr M01_L60
M01_L124:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L67
M01_L125:
       cmp       dword ptr [r15+8],0
       jne       short M01_L130
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L126
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L126
       jmp       short M01_L127
M01_L126:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF9A8
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8A8490FE0
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L129:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L67
M01_L130:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L131
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF998
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BCB28]
       jmp       near ptr M01_L67
M01_L133:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L134
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L134
       jmp       short M01_L135
M01_L134:
       mov       rcx,rdi
       mov       rdx,7FF8A85EF988
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BCB40]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8A7E47E58]
       int       3
M01_L137:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L70
M01_L138:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L139
       jmp       short M01_L140
M01_L139:
       mov       rcx,rsi
       mov       rdx,7FF8A85EF468
       call      qword ptr [7FF8A7E47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8A8325818]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L70
M01_L141:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L71
M01_L142:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L71
M01_L143:
       mov       ecx,433
       mov       rdx,7FF8A8028338
       call      qword ptr [7FF8A7E47798]
       mov       rcx,rax
       call      qword ptr [7FF8A841E298]
       int       3
M01_L144:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L72
M01_L145:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L72
M01_L146:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L73
M01_L147:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L73
M01_L148:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L149
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C0]
       cmp       [rax],rcx
       je        short M01_L149
       mov       rcx,rax
       mov       r11,7FF8A7B71710
       call      qword ptr [r11]
M01_L149:
       nop
       add       rsp,28
       ret
; Total bytes of code 5003
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF8A7FFBAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+2D8]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       jmp       short M00_L00
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		other = other.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var copy = new HashSet<T>(this._set, this._set.Comparer);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		copy.UnionWith(other);
; 		^^^^^^^^^^^^^^^^^^^^^^
; 		if (copy.Count == this._set.Count)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var added = copy.Where(i => !this._set.Contains(i)).ToList();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanging();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._set = copy;
; 		^^^^^^^^^^^^^^^^^
; 		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.OnCountPropertyChanged();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       cmp       [rbx],ebx
       test      rsi,rsi
       je        near ptr M01_L80
       mov       [rbp+18],rsi
       mov       r14,[rbx+8]
       mov       r15,r14
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L81
       mov       rsi,[rbp+18]
       mov       r13,[r14+18]
       test      r13,r13
       je        near ptr M01_L84
M01_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L74
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rbp-0A8],r14
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M01_L87
M01_L02:
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14]
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L90
M01_L03:
       test      r15,r15
       je        near ptr M01_L93
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L75
M01_L04:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       mov       [rbp-0B0],r12
       test      r12,r12
       je        near ptr M01_L111
       mov       rax,[r14+18]
       test      rax,rax
       je        near ptr M01_L94
M01_L05:
       mov       rdx,[r12+18]
       test      rdx,rdx
       je        near ptr M01_L97
M01_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M01_L102
       mov       ecx,[r12+28]
       sub       ecx,[r12+30]
       je        near ptr M01_L101
       mov       rax,[r12+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L100
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF8A7BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edx,eax
M01_L08:
       cmp       edx,r15d
       jl        near ptr M01_L107
       mov       [rbp+18],rsi
       mov       r15,[r12+8]
       mov       [rbp-0C0],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-90],rax
       lea       rax,[M01_L09]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L10
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L10:
       mov       rcx,[rbp-98]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-50]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L11
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L11:
       mov       r15,[rbp-0C0]
       lea       rdx,[r15+8]
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-50]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L76
       cmp       r8,4000
       ja        near ptr M01_L104
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L103
M01_L12:
       mov       rdx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-0B0]
       mov       rbx,[r12+10]
       mov       [rbp-0C8],rbx
       cmp       [rbx],bl
       mov       [rbp-58],rbx
       lea       rcx,[rbp-58]
       mov       rax,7FF8A7D49DD0
       mov       [rbp-90],rax
       lea       rax,[M01_L13]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90774C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L14
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L14:
       mov       rcx,[rbp-98]
       mov       [rdi+8],rcx
       mov       rcx,[rbp-58]
       mov       rdx,[rcx]
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L15
       mov       eax,[rcx+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L15:
       mov       rbx,[rbp-0C8]
       lea       rdx,[rbx+8]
       mov       rcx,[rbp-58]
       cmp       [rcx],cl
       add       rcx,8
       mov       rax,[rbp-58]
       mov       rax,[rax]
       test      dword ptr [rax],1000000
       je        near ptr M01_L77
       cmp       r8,4000
       ja        near ptr M01_L106
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       jne       near ptr M01_L105
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L78
M01_L17:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L18
       cmp       [rdx],rcx
       je        short M01_L18
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M01_L18:
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-0B0]
       mov       edx,[r12+2C]
       mov       [r14+2C],edx
       mov       edx,[r12+30]
       mov       [r14+30],edx
       mov       edx,[r12+28]
       mov       [r14+28],edx
       mov       rdx,[r12+20]
       mov       [r14+20],rdx
       mov       rsi,[rbp+18]
M01_L19:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M01_L79
M01_L20:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M01_L21:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,[rbp-0D0]
       cmp       [rsi],rcx
       jne       near ptr M01_L48
       mov       ecx,[rsi+8]
       inc       ecx
       cmp       ecx,[rsi+0C]
       jae       near ptr M01_L40
       mov       [rsi+8],ecx
M01_L22:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0D0]
       test      r11,r11
       je        near ptr M01_L27
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       ecx,[rsi+8]
       cmp       ecx,[rsi+0C]
       jae       near ptr M01_L49
       mov       r11,[rsi+10]
       cmp       ecx,[r11+8]
       jae       near ptr M01_L51
       mov       rdi,[r11+rcx*8+10]
M01_L24:
       cmp       qword ptr [r14+8],0
       je        near ptr M01_L42
M01_L25:
       mov       r15,[r14+10]
       mov       r12,[r14+18]
       xor       eax,eax
       mov       [rbp-5C],eax
       test      rdi,rdi
       je        near ptr M01_L37
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+78]
       test      r11,r11
       je        short M01_L28
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],rcx
       jne       near ptr M01_L43
       mov       rdx,[rdi+28]
       test      rdx,rdx
       jne       short M01_L29
       xor       ecx,ecx
       jmp       short M01_L30
M01_L27:
       mov       rcx,r13
       mov       rdx,7FF8A85DBF90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L23
M01_L28:
       mov       rcx,r13
       mov       rdx,7FF8A8440B40
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,288EA400068
       mov       rcx,[rcx]
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       ecx,eax
M01_L30:
       mov       r8d,ecx
M01_L31:
       mov       [rbp-60],r8d
       mov       rcx,[r14+8]
       mov       edx,r8d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       mov       r9d,r10d
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,r10d
       jae       near ptr M01_L51
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rbp-0E0],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M01_L34
M01_L32:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L51
       mov       ecx,r9d
       shl       rcx,4
       lea       r9,[r15+rcx+10]
       mov       [rbp-0E8],r9
       cmp       [r9+8],r8d
       je        near ptr M01_L44
M01_L33:
       mov       r9,[rbp-0E8]
       mov       r9d,[r9+0C]
       mov       eax,[rbp-5C]
       inc       eax
       mov       [rbp-5C],eax
       cmp       [r15+8],eax
       jb        near ptr M01_L50
       test      r9d,r9d
       mov       r8d,[rbp-60]
       jge       short M01_L32
M01_L34:
       cmp       dword ptr [r14+30],0
       jg        near ptr M01_L39
       mov       edx,[r14+28]
       mov       [rbp-64],edx
       cmp       [r15+8],edx
       je        short M01_L38
M01_L35:
       mov       edx,[rbp-64]
       mov       r15d,edx
       lea       ecx,[r15+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r9,rcx
M01_L36:
       cmp       r15d,[r9+8]
       jae       near ptr M01_L51
       mov       ecx,r15d
       shl       rcx,4
       mov       [rbp-0D8],r9
       lea       rcx,[r9+rcx+10]
       mov       [rcx+8],r8d
       mov       r10,[rbp-0E0]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-0E0]
       mov       [rdx],r15d
       inc       dword ptr [r14+34]
       cmp       dword ptr [rbp-5C],64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L47
M01_L37:
       xor       r8d,r8d
       jmp       near ptr M01_L31
M01_L38:
       mov       ecx,[r14+28]
       call      qword ptr [7FF8A7D65038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r14+8]
       mov       r15d,[rbp-60]
       mov       edx,r15d
       imul      rdx,[r14+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L51
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-0E0],rax
       mov       r8d,r15d
       jmp       near ptr M01_L35
M01_L39:
       mov       ecx,[r14+2C]
       mov       r9d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[r15+8]
       jae       near ptr M01_L51
       shl       rcx,4
       mov       ecx,[r15+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       eax,r9d
       mov       r9,r15
       mov       r15d,eax
       jmp       near ptr M01_L36
M01_L40:
       mov       ecx,[rsi+0C]
       mov       [rsi+8],ecx
       jmp       near ptr M01_L52
M01_L41:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L24
M01_L42:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L25
M01_L43:
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L30
M01_L44:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L45
       jmp       short M01_L46
M01_L45:
       mov       rcx,r13
       mov       rdx,7FF8A8440B58
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L46:
       mov       rax,[rbp-0E8]
       mov       rdx,[rax]
       mov       rcx,r12
       mov       r8,rdi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L33
M01_L47:
       mov       r15,[rbp-0D8]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[r15+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FF8A7F7DA10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF8A7BFE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L48:
       mov       rcx,rsi
       mov       r11,7FF8A7B41728
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L22
       jmp       near ptr M01_L117
M01_L49:
       call      qword ptr [7FF8A84B5680]
       int       3
M01_L50:
       call      qword ptr [7FF8A7E17A08]
       int       3
M01_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L52:
       mov       ecx,[r14+28]
       sub       ecx,[r14+30]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+28]
       sub       eax,[rdx+30]
       cmp       eax,ecx
       je        near ptr M01_L65
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L66
M01_L53:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].<UnionWith>b__52_0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+30]
       test      rdi,rdi
       je        near ptr M01_L67
M01_L54:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L68
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L68
M01_L55:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L118
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       near ptr M01_L69
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M01_L69
M01_L56:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L119
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M01_L70
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M01_L70
M01_L57:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L127
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M01_L71
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L71
M01_L58:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L59:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+38]
       test      rsi,rsi
       je        near ptr M01_L72
M01_L60:
       test      r13,r13
       je        near ptr M01_L130
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L73
M01_L61:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L132
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L131
       mov       rcx,rax
       call      qword ptr [7FF8A7FA61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L62:
       mov       rdx,28900400828
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L136
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L135
M01_L63:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28900400830
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L137
       mov       dword ptr [rsi+18],2
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.ReadOnlyList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],0FFFFFFFF
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L139
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L138
M01_L64:
       mov       rdx,28900400820
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L141
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L140
M01_L65:
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L66:
       mov       rdx,7FF8A847F898
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L67:
       mov       rdx,7FF8A847F8E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L54
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC1B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L55
M01_L69:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC1C0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L56
M01_L70:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC2D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L57
M01_L71:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC2E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L58
M01_L72:
       mov       rdx,7FF8A847F930
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L60
M01_L73:
       mov       rcx,rsi
       mov       rdx,7FF8A85DBC50
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L61
M01_L74:
       mov       rdx,7FF8A8446640
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L75:
       mov       rcx,r13
       mov       rdx,7FF8A85DBDD0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L76:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L77:
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L78:
       mov       rcx,r13
       mov       rdx,7FF8A85AA760
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L79:
       mov       rcx,r13
       mov       rdx,7FF8A85DBF78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L80:
       call      qword ptr [7FF8A81AF570]
       mov       ecx,66ED
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A82F5C08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A82F5C20]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L81:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L82
       jmp       short M01_L83
M01_L82:
       mov       rdx,7FF8A85AA778
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L83:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8A84BCA98]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L84:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L85
       jmp       short M01_L86
M01_L85:
       mov       rdx,7FF8A85D5B90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L86:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L00
M01_L87:
       mov       r13,[r14]
       mov       rcx,r13
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L88
       jmp       short M01_L89
M01_L88:
       mov       rdx,7FF8A85D5B90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L89:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L90:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8A7BF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M01_L03
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L91
       jmp       short M01_L92
M01_L91:
       mov       rcx,r13
       mov       rdx,7FF8A85AA778
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L92:
       mov       rdx,r12
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L93:
       mov       ecx,17
       call      qword ptr [7FF8A7E1C228]
       int       3
M01_L94:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rcx,r13
       mov       rdx,7FF8A85D5B90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L96:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       jmp       near ptr M01_L05
M01_L97:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L98
       mov       [rbp-0B8],rax
       jmp       short M01_L99
M01_L98:
       mov       [rbp-0B8],rax
       mov       rdx,7FF8A85D5B90
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L99:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rax,[rbp-0B8]
       jmp       near ptr M01_L06
M01_L100:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L07
       mov       edx,7FFFFFC3
       jmp       near ptr M01_L08
M01_L101:
       mov       r14,[rbp-0A8]
       jmp       near ptr M01_L19
M01_L102:
       mov       r14,[rbp-0A8]
       jmp       near ptr M01_L111
M01_L103:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L104:
       call      qword ptr [7FF8A81AEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L105:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L106:
       call      qword ptr [7FF8A81AEEF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L107:
       mov       r14,[rbp-0A8]
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r12+10]
       xor       r15d,r15d
       jmp       short M01_L110
M01_L108:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L142
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L109
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF8A7BFE958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L109:
       inc       r15d
M01_L110:
       cmp       r15d,[r12+28]
       jl        short M01_L108
       jmp       near ptr M01_L19
M01_L111:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L112
       jmp       short M01_L113
M01_L112:
       mov       rcx,r13
       mov       rdx,7FF8A85DBDE0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L113:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L116
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M01_L114
       jmp       short M01_L115
M01_L114:
       mov       rcx,r13
       mov       rdx,7FF8A85DBDF0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L115:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L116
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8A7BFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L116:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8A7D46240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       near ptr M01_L19
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       near ptr M01_L19
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF8A84BC810]
       jmp       near ptr M01_L19
M01_L117:
       mov       rcx,rsi
       mov       r11,7FF8A7B41730
       call      qword ptr [r11]
       jmp       near ptr M01_L52
M01_L118:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L59
M01_L119:
       cmp       dword ptr [r15+8],0
       jne       short M01_L124
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L120
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L120
       jmp       short M01_L121
M01_L120:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC310
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L121:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L122
       jmp       short M01_L123
M01_L122:
       mov       rdx,7FF8A8317930
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L123:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L59
M01_L124:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L125
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L125
       jmp       short M01_L126
M01_L125:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC300
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L126:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BCF00]
       jmp       near ptr M01_L59
M01_L127:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L128
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rcx,rdi
       mov       rdx,7FF8A85DC2F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L129:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8A84BCF18]
       jmp       near ptr M01_L59
M01_L130:
       mov       ecx,11
       call      qword ptr [7FF8A7E17E58]
       int       3
M01_L131:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L132:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L133
       jmp       short M01_L134
M01_L133:
       mov       rcx,rsi
       mov       rdx,7FF8A85DBC40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L134:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8A82F7DC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L62
M01_L135:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L63
M01_L136:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L63
M01_L137:
       mov       ecx,433
       mov       rdx,7FF8A7FF8338
       call      qword ptr [7FF8A7E17798]
       mov       rcx,rax
       call      qword ptr [7FF8A82F6298]
       int       3
M01_L138:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L64
M01_L139:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L64
M01_L140:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L65
M01_L141:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L65
M01_L142:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0D0],0
       je        short M01_L143
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,[rbp-0D0]
       cmp       [rsi],rcx
       je        short M01_L143
       mov       rcx,rsi
       mov       r11,7FF8A7B41730
       call      qword ptr [r11]
M01_L143:
       nop
       add       rsp,28
       ret
; Total bytes of code 4624
```

