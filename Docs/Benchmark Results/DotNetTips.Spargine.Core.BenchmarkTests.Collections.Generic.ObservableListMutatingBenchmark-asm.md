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
       mov       rdx,7FF8AC4354B8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC207F78]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC207F60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC20C048]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC20C018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC351AF0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1C5D58]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC1C5D40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1C5E18]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1C5DE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC310AC8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E63A0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1E6460]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FF8ABDEBA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,1B353400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DFE13554
       mov       r8d,821D720A
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
       mov       rdx,1B3694007B8
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
       call      qword ptr [7FF8AB9E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF8ABC07A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8AC2D3298
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8AC2610A8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8AC2610C0
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABB55038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8ABD4DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8ABD4DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8AB9EE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       rdx,1B3694007B0
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
       mov       rdx,7FF8AC2610A8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2610C0
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB931448
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
       call      qword ptr [7FF8ABDFBA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,2D999C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L32
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8D7F0D8B
       mov       r8d,0F9F9D0FA
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
       mov       r12d,[r14+8]
       cmp       eax,r12d
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+30],rax
       cmp       [rax+8],ebp
       je        near ptr M01_L33
M01_L06:
       mov       rax,[rsp+30]
       mov       eax,[rax+0C]
       inc       r15d
       cmp       r12d,r15d
       jb        near ptr M01_L52
       test      eax,eax
       jge       short M01_L05
M01_L07:
       mov       rdx,2D9AFC007B8
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
       mov       rcx,2D999C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L47
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8D7F0D8B
       mov       r8d,0F9F9D0FA
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
       js        short M01_L17
M01_L15:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+20],rax
       cmp       [rax+8],ebp
       je        near ptr M01_L49
M01_L16:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L52
       test      eax,eax
       jge       short M01_L15
M01_L17:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M01_L53
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
       mov       [rsp+28],rax
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
       mov       rdx,2D9AFC007B0
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
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L24:
       mov       rdx,7FF8AC271730
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L25:
       mov       rdx,7FF8AC271730
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC271748
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L35:
       mov       rax,[rsp+30]
       mov       rdx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L36
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF8AB9413F0
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
       call      qword ptr [7FF8AB9FE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC271748
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L51:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L20
       jmp       near ptr M01_L16
M01_L52:
       call      qword ptr [7FF8ABC17A08]
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
       jmp       near ptr M01_L19
M01_L54:
       mov       rcx,rdi
       call      qword ptr [7FF8AC297348]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       jmp       near ptr M01_L18
M01_L55:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L20
       mov       r14,[rsp+28]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8AB9FE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
; Total bytes of code 2143
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
       call      qword ptr [7FF8ABE0BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,231B1000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,35EE9876
       mov       r8d,0EF268657
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
       mov       rdx,231C70007B8
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
       call      qword ptr [7FF8ABA05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF8ABC27A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8AC2DFE28
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8AC2816A8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8AC2816C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABB75038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8ABA0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       rdx,231C70007B0
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
       mov       rdx,7FF8AC2816A8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2816C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9511B0
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
       call      qword ptr [7FF8ABE0BA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rcx,16F19C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L32
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,941BC147
       mov       r8d,0D946C03E
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
       mov       rdx,16F19C027B0
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
       mov       rcx,16F19C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L47
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,941BC147
       mov       r8d,0D946C03E
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
       js        short M01_L17
M01_L15:
       cmp       eax,[r14+8]
       jae       near ptr M01_L60
       mov       ecx,eax
       shl       rcx,4
       lea       rax,[r14+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],ebp
       je        near ptr M01_L49
M01_L16:
       mov       rax,[rsp+28]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M01_L52
       test      eax,eax
       jge       short M01_L15
M01_L17:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M01_L53
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
       mov       rdx,16F19C027A8
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
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L24:
       mov       rdx,7FF8AC27D848
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L25:
       mov       rdx,7FF8AC27D848
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC27D860
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9512C0
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
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC27D860
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L51:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L20
       jmp       near ptr M01_L16
M01_L52:
       call      qword ptr [7FF8ABC27A08]
       int       3
M01_L53:
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
M01_L54:
       mov       rcx,rdi
       call      qword ptr [7FF8AC2A74F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8ABA0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       call      qword ptr [7FF8ABDFBA08]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M01_L28
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L16
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L29
       mov       rcx,1C806400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,259AFC55
       mov       r8d,0FECEBD86
       cmp       edx,8
       jb        near ptr M01_L30
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
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
       mov       rdx,1C81C400828
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
       call      qword ptr [7FF8AB9F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
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
       mov       r11,[rdx+78]
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
       mov       r11,[rdx+80]
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
       call      qword ptr [7FF8ABC17A08]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF8AC397A50
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF8AC240FB8
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF8AC240FD0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABB65038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8AB9FE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       rdx,1C81C400820
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
       mov       rdx,7FF8AC240FB8
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdx,7FF8AC240FD0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9412F8
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
; Total bytes of code 1832
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
       mov       rdx,7FF8AC36A5A8
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
       mov       rdx,7FF8AC215AD0
       call      qword ptr [7FF8AC1E6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F8140
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E68B0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC389920
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
       mov       rdx,7FF8AC235AD0
       call      qword ptr [7FF8AC206358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC2181D8
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206880]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC325638
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
       mov       rdx,7FF8AC2255B8
       call      qword ptr [7FF8AC1F6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC208058
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F67C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC355EE0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC2055B8
       call      qword ptr [7FF8AC1D6268]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E7080
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC375E90
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC2257C0
       call      qword ptr [7FF8AC1F62F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC207168
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6460]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC301250
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+2D8]
       mov       rcx,[rbp+10]
       mov       rdx,7FF8AC205AC0
       call      qword ptr [7FF8AC1D6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E7168
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D64D8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D6490]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8ABE1BA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rdx,2176A0007B8
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
       call      qword ptr [7FF8AC06FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC06FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2176A0007C0
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
       mov       rdx,2176A0007B0
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
       call      qword ptr [7FF8AC1FC600]
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
       call      qword ptr [7FF8ABC37E58]
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
       mov       r11,7FF8AB961750
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,21754001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8AB954000
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8AC1FDF98]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8AB961758
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,21754001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8AB961730
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB961738
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB961740
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
       call      qword ptr [7FF8ABB8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB961748
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8ABC3C228]
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
       call      qword ptr [7FF8AC2B7348]
       int       3
M01_L28:
       call      qword ptr [7FF8ABA157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8ABE18338
       call      qword ptr [7FF8ABC37798]
       mov       rcx,rax
       call      qword ptr [7FF8AC1FDFC8]
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
       mov       r11,7FF8AB961748
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
       call      qword ptr [7FF8ABE2BA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rdx,2C0750027B0
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
       call      qword ptr [7FF8AC07FBA0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC07FBA0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2C0750027B8
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
       mov       rdx,2C0750027A8
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
       call      qword ptr [7FF8AC2070D8]
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
       call      qword ptr [7FF8ABC47E58]
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
       mov       r11,7FF8AB971530
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,2C075001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8AB964000
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8AC20DF38]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8AB971538
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,2C075001FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8AB971510
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB971518
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB971520
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
       call      qword ptr [7FF8ABB9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB971528
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8ABA257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8ABC4C228]
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
       call      qword ptr [7FF8AC2C7870]
       int       3
M01_L28:
       call      qword ptr [7FF8ABA257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8ABE28338
       call      qword ptr [7FF8ABC47798]
       mov       rcx,rax
       call      qword ptr [7FF8AC20DF68]
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
       mov       r11,7FF8AB971528
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
       call      qword ptr [7FF8ABDEBA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rdx,1F382C027B0
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
       call      qword ptr [7FF8AC03FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC03FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1F382C027B8
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
       mov       rdx,1F382C027A8
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
       call      qword ptr [7FF8AC1CC600]
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
       call      qword ptr [7FF8ABC07E58]
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
       mov       r11,7FF8AB931568
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,1F382C01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8AB924000
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8AC1CE238]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8AB931570
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,1F382C01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8AB931548
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB931550
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB931558
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
       call      qword ptr [7FF8ABB5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB931560
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8ABC0C228]
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
       call      qword ptr [7FF8AC287AC8]
       int       3
M01_L28:
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8ABDE8338
       call      qword ptr [7FF8ABC07798]
       mov       rcx,rax
       call      qword ptr [7FF8AC1CE268]
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
       mov       r11,7FF8AB931560
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
       call      qword ptr [7FF8ABDEBA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rdx,1EC84C007D8
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
       call      qword ptr [7FF8AC03FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC03FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1EC84C007E0
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
       mov       rdx,1EC84C007D0
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
       call      qword ptr [7FF8AC1DDD58]
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
       call      qword ptr [7FF8ABC07E58]
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
       mov       r11,7FF8AB9316E0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,1EC6EC01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8AB924000
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8AC0EE6E8]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8AB9316E8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,1EC6EC01FD0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8AB9316C0
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316D0
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
       call      qword ptr [7FF8ABB5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316D8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8ABC0C228]
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
       call      qword ptr [7FF8AC28C0D8]
       int       3
M01_L28:
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8ABDE8338
       call      qword ptr [7FF8ABC07798]
       mov       rcx,rax
       call      qword ptr [7FF8AC0EE718]
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
       mov       r11,7FF8AB9316D8
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
       call      qword ptr [7FF8ABDEBA18]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
       mov       rdx,2AB51400828
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
       call      qword ptr [7FF8AC03FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC03FB88]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2AB51400830
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
       mov       rdx,2AB51400820
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
       call      qword ptr [7FF8AC0EFC78]
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
       call      qword ptr [7FF8ABC07E58]
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
       mov       r11,7FF8AB9316C8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,2AB3B402008
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF8AB924000
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF8AC0E6280]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF8AB9316D0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,2AB3B402008
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF8AB9316A8
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316B8
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
       call      qword ptr [7FF8ABB5E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF8AB9316C0
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF8ABC0C228]
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
       call      qword ptr [7FF8AC2AC390]
       int       3
M01_L28:
       call      qword ptr [7FF8AB9E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF8ABDE8338
       call      qword ptr [7FF8ABC07798]
       mov       rcx,rax
       call      qword ptr [7FF8AC0E62B0]
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
       mov       r11,7FF8AB9316C0
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
       mov       rdx,7FF8AC366B70
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
       mov       rdx,7FF8AC2155B8
       call      qword ptr [7FF8AC1E6280]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F7368
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6478]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC397190
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
       mov       rdx,7FF8AC235AD0
       call      qword ptr [7FF8AC206388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC2173B8
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC206580]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206538]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC312168
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
       mov       rdx,7FF8AC2157C0
       call      qword ptr [7FF8AC1E6280]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F73B8
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6478]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC36B0E0
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
       mov       rdx,7FF8AC215AD0
       call      qword ptr [7FF8AC1E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F85D8
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6A00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E69B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC36BBB8
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
       mov       rdx,7FF8AC215AD0
       call      qword ptr [7FF8AC1E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F85D8
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6A00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E69B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC318130
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
       mov       rdx,7FF8AC2155B8
       call      qword ptr [7FF8AC1E6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F84F0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6940]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E68F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC2C8590
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
       mov       rdx,7FF8AC1A1D10
       call      qword ptr [7FF8AC0CE5B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC199CC8
       call      qword ptr [7FF8ABC07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0CEC58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0CEC10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC3469B0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1C62B0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC1C6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1C63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1C6388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC326258
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0DE658]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC0DE640]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC0DE760]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0DE730]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC3221D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F63A0]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF8AC1F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1F64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6478]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FF8ABE0BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       je        near ptr M01_L11
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
       je        near ptr M01_L10
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L08
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L12
       mov       rcx,20D32800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L18
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0FED21944
       mov       r8d,0EDF1C4A8
       cmp       edx,8
       jb        near ptr M01_L13
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
       jne       near ptr M01_L14
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
       jae       near ptr M01_L58
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       eax,[rcx]
       dec       eax
       js        short M01_L07
M01_L05:
       cmp       eax,[r14+8]
       jae       near ptr M01_L58
       mov       ecx,eax
       shl       rcx,4
       lea       r12,[r14+rcx+10]
       cmp       [r12+8],ebp
       je        near ptr M01_L19
M01_L06:
       mov       eax,[r12+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L52
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
       jne       short M01_L09
       jmp       near ptr M01_L31
M01_L10:
       mov       rdx,7FF8AC281178
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L11:
       call      qword ptr [7FF8ABFBF588]
       mov       ecx,24AB
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC1ED8F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8AC1ED908]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       xor       ebp,ebp
       jmp       near ptr M01_L04
M01_L13:
       cmp       edx,4
       jb        short M01_L15
M01_L14:
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
M01_L15:
       mov       r10d,80
       test      dl,1
       je        short M01_L16
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M01_L16:
       test      dl,2
       je        short M01_L17
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,r10d
       jmp       near ptr M01_L03
M01_L18:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FF8AC281190
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L21:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       short M01_L22
       test      rdx,rdx
       je        near ptr M01_L06
       mov       rcx,rdx
       mov       rdx,rbx
       mov       r11,7FF8AB951770
       call      qword ptr [r11]
       jmp       short M01_L23
M01_L22:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L23:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,20D328027B0
       mov       r8,[rdx]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdi
       jne       short M01_L24
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M01_L25
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L25
M01_L24:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax]
M01_L25:
       mov       rbp,[rsi+8]
       mov       r14,rbx
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L53
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
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rdx,7FF8AC281178
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L27:
       mov       rax,[rsp+40]
       mov       r8,[rax]
       mov       [rsp+48],r8
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       r8,rcx
       jne       near ptr M01_L39
       mov       rax,[rsp+40]
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M01_L28
       xor       r14d,r14d
       jmp       near ptr M01_L38
M01_L28:
       mov       rcx,20D32800068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L37
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0FED21944
       mov       r9d,0EDF1C4A8
       cmp       edx,8
       jae       short M01_L30
       cmp       edx,4
       jb        near ptr M01_L34
M01_L29:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       short M01_L32
M01_L30:
       mov       r11d,edx
       shr       r11d,3
       jmp       near ptr M01_L09
M01_L31:
       test      dl,4
       jne       short M01_L29
M01_L32:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L33:
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
       jmp       short M01_L38
M01_L34:
       mov       r11d,80
       test      dl,1
       je        short M01_L35
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M01_L35:
       test      dl,2
       je        short M01_L36
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       short M01_L33
M01_L36:
       mov       ecx,r11d
       jmp       short M01_L33
M01_L37:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L38:
       jmp       short M01_L40
M01_L39:
       mov       rax,[rsp+40]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rsp+40]
M01_L40:
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
       jae       near ptr M01_L58
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rsp+38],r10
       mov       r9d,[r10]
       dec       r9d
       js        near ptr M01_L53
M01_L41:
       cmp       r9d,[r15+8]
       jae       near ptr M01_L58
       mov       [rsp+5C],r9d
       mov       ecx,r9d
       shl       rcx,4
       lea       r11,[r15+rcx+10]
       mov       [rsp+30],r11
       cmp       [r11+8],r14d
       jne       short M01_L42
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L43
       jmp       short M01_L44
M01_L42:
       jmp       short M01_L48
M01_L43:
       mov       rdx,7FF8AC281190
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       mov       rax,[rsp+40]
M01_L44:
       mov       r11,[rsp+30]
       mov       rcx,[r11]
       mov       [rsp+28],rcx
       mov       r9,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsp+48],r9
       jne       short M01_L46
       test      rcx,rcx
       je        short M01_L45
       mov       rdx,rbx
       mov       r11,7FF8AB951778
       call      qword ptr [r11]
       jmp       short M01_L47
M01_L45:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M01_L47
M01_L46:
       mov       rcx,rax
       mov       [rsp+50],rdx
       mov       r11,rdx
       mov       rdx,[rsp+28]
       mov       r8,rbx
       mov       r9,[rsp+50]
       call      qword ptr [r9]
       mov       ecx,eax
       mov       eax,ecx
M01_L47:
       test      eax,eax
       jne       short M01_L49
M01_L48:
       mov       r12d,[rsp+5C]
       mov       rcx,[rsp+30]
       mov       ecx,[rcx+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        short M01_L52
       test      ecx,ecx
       mov       r9d,ecx
       mov       rax,[rsp+40]
       jge       near ptr M01_L41
       jmp       short M01_L53
M01_L49:
       test      r12d,r12d
       jge       short M01_L50
       mov       r14,[rsp+30]
       mov       eax,[r14+0C]
       inc       eax
       mov       r15,[rsp+38]
       mov       [r15],eax
       jmp       short M01_L51
M01_L50:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L58
       mov       eax,r12d
       shl       rax,4
       mov       r14,[rsp+30]
       mov       edx,[r14+0C]
       mov       [r15+rax+1C],edx
M01_L51:
       mov       eax,[rbp+2C]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [r14+0C],eax
       xor       eax,eax
       mov       [r14],rax
       mov       ecx,[rsp+5C]
       mov       [rbp+2C],ecx
       inc       dword ptr [rbp+30]
       jmp       short M01_L53
M01_L52:
       call      qword ptr [7FF8ABC27A08]
       int       3
M01_L53:
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
       jne       short M01_L54
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M01_L55
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L55
M01_L54:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
M01_L55:
       mov       rdx,20D328027A8
       mov       r8,[rdx]
       cmp       [rsi],rdi
       jne       short M01_L56
       mov       rax,[rsi+18]
       test      rax,rax
       je        short M01_L57
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L57
M01_L56:
       mov       rcx,rsi
       mov       rdx,r8
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
M01_L57:
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
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2131
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
       call      qword ptr [7FF8ABE2BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       mov       rcx,1C233C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,85058993
       mov       r8d,7304A705
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
       mov       rdx,7FF8AC2A1778
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF8ABFDF588]
       mov       ecx,24AB
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC20D9F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8AC20DA10]
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
       mov       rdx,7FF8AC2A1790
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9715C0
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,1C249C007B8
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
       mov       rdx,7FF8AC2A1778
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,1C233C00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,85058993
       mov       r9d,7304A705
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
       mov       rdx,7FF8AC2A1790
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9715C8
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
       call      qword ptr [7FF8ABC47A08]
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
       mov       rdx,1C249C007B0
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
       call      qword ptr [7FF8ABE0BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       mov       rcx,1F7C4000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A741B628
       mov       r8d,1CA3C55D
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
       mov       rdx,7FF8AC2817D8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L12:
       call      qword ptr [7FF8ABFBF588]
       mov       ecx,24AB
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC1EDA88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8AC1EDAA0]
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
       mov       rdx,7FF8AC2817F0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB951590
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,1F7DA0007B8
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
       mov       rdx,7FF8AC2817D8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,1F7C4000068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0A741B628
       mov       r9d,1CA3C55D
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
       mov       rdx,7FF8AC2817F0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB951598
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
       call      qword ptr [7FF8ABC27A08]
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
       mov       rdx,1F7DA0007B0
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
       call      qword ptr [7FF8ABE1BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       mov       rcx,219A3000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,365A38F
       mov       r8d,0F099B334
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
       mov       rdx,7FF8AC28F7E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF8ABFCF588]
       mov       ecx,24AB
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC11DF50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8AC11DF68]
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
       mov       rdx,7FF8AC28F800
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9614E8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,219A30027B0
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
       mov       rdx,7FF8AC28F7E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,219A3000068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,365A38F
       mov       r9d,0F099B334
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
       mov       rdx,7FF8AC28F800
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9614F0
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
       call      qword ptr [7FF8ABC37A08]
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
       mov       rdx,219A30027A8
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
       call      qword ptr [7FF8ABE0BAA0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M01_L09
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L08
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L11
       mov       rcx,1DBA4400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,494073D4
       mov       r8d,0D06630F6
       cmp       edx,8
       jb        near ptr M01_L12
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
       mov       rdx,7FF8AC251A70
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF8ABFBF138]
       mov       ecx,24AB
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC0F5AB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8AC0F5AD0]
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
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF8AC251A88
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9516C0
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,1DBA4402820
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
       mov       rdx,7FF8AC251A70
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,1DBA4400068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,494073D4
       mov       r9d,0D06630F6
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
       mov       rdx,7FF8AC251A88
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF8AB9516C8
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
       call      qword ptr [7FF8ABC27A08]
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
       mov       rdx,1DBA4402818
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
; Total bytes of code 2120
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
       mov       rdx,7FF8AC3793C0
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
       call      qword ptr [7FF8AC1F6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF8AC1F64C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6490]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rdx,7FF8AC377B98
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
       call      qword ptr [7FF8AC1F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF8AC1F65C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6598]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rdx,7FF8AC333AA0
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
       call      qword ptr [7FF8AC206358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF8AC206580]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206550]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rax,274D8400A60
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
       mov       rcx,7FF8AC36BA30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,274D8400A58
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8ABA06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,274D8400A60
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8AC36BA34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8AC36BA38
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
       call      qword ptr [7FF8AC1E6310]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF8ABE09A70]; Precode of DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8ABF8AF38]; Precode of System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FF8AC1EEA60]
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
       call      qword ptr [7FF8AC1E6970]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rax,1F42F802A58
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
       mov       rcx,7FF8AC36CBC8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,1F42F802A50
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8AB9F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,1F42F802A58
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8AC36CBCC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8AC36CBD0
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
       call      qword ptr [7FF8AC1D5F20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF8ABDF9A70]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8ABF7AF28]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FF8AC1DEAC0]
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
       call      qword ptr [7FF8AC1D6580]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D6550]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rax,2CE75800A60
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
       mov       rcx,7FF8AC307F78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,2CE75800A58
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF8AB9F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,2CE75800A60
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF8AC307F7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF8AC307F80
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
       call      qword ptr [7FF8AC1D6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       r11,7FF8AB941668
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
       call      qword ptr [7FF8AC1DEAC0]
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
       call      qword ptr [7FF8AC1D69D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D69A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
       mov       rdx,7FF8AC356D58
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
       mov       rdx,7FF8AC205AD0
       call      qword ptr [7FF8AC1D63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E6FC8
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D64C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D6478]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC366560
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
       mov       rdx,7FF8AC215AD0
       call      qword ptr [7FF8AC1E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F7060
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6478]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC312690
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
       mov       rdx,7FF8AC215AC0
       call      qword ptr [7FF8AC1E6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F6FC8
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6490]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E6448]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8ABE2BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8ABA25A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rcx,19CA2400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,9C5DD29B
       mov       r10d,2EAD69A5
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
       mov       rdx,7FF8AC31D078
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8AC294440
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC294458
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC2C6DC0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD8DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8ABA2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8AB971740
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8AC20FDF8]
       int       3
M01_L48:
       call      qword ptr [7FF8ABC47A08]
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
       mov       rdx,19CB84007B8
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
       mov       rdx,19CB84007B0
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
       mov       rdx,7FF8AC31CF48
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8AC31CF38
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8AC136F58
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8AC31CF38
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8AC31CF48
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8AC31CF58
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8AC314C38
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8AC31D060
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8ABFDF120]
       mov       ecx,2A41
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC20D770]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC20D788]
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
       mov       rdx,7FF8AC314C50
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6D78]
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
       mov       rdx,7FF8AC318660
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC318660
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8ABA26358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC314C50
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC31CF38
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8AC434C18]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8AC2C6DD8]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8AB971748
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8AC2C6DF0]
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
       mov       rdx,7FF8AC314C50
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6D78]
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
       mov       rdx,7FF8AC318660
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC314C50
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6D78]
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
       mov       rdx,7FF8AC318660
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8AC2C6FA0]
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
       call      qword ptr [7FF8AC2C6FB8]
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
       mov       r11,7FF8AB971748
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
       call      qword ptr [7FF8ABE2BAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8ABA25A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rcx,223EB800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0DDFD18B3
       mov       r10d,60DA2D5E
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
       mov       rdx,7FF8AC349BA8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8AC2A1838
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC2A1850
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC2C6F10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD8DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8ABA2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8AB971578
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8AC2C40F0]
       int       3
M01_L48:
       call      qword ptr [7FF8ABC47A08]
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
       mov       rdx,224018007B8
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
       mov       rdx,224018007B0
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
       mov       rdx,7FF8AC349A78
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8AC349A68
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8AC148F10
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8AC349A68
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8AC349A78
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8AC349A88
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8AC2FF8E0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8AC349B90
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8ABFDF588]
       mov       ecx,2A41
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC20D8C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC20D8D8]
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
       mov       rdx,7FF8AC2FF8F8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6EE0]
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
       mov       rdx,7FF8AC316C00
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC316C00
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8ABA26358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC2FF8F8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC349A68
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8AC2C7AC8]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8AC2C7300]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8AB971580
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8AC2C7318]
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
       mov       rdx,7FF8AC2FF8F8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6EE0]
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
       mov       rdx,7FF8AC316C00
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2FF8F8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2C6EE0]
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
       mov       rdx,7FF8AC316C00
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8AC2C7498]
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
       call      qword ptr [7FF8AC2C74B0]
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
       mov       r11,7FF8AB971580
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
       call      qword ptr [7FF8ABDFBAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AB9F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rcx,17D7B000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,5E89181F
       mov       r10d,0FCA3A60A
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
       mov       rdx,7FF8AC31E4D0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8AC271868
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AB9FE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC271880
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC296E38]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8AB9FE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8AB9413E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8AC294078]
       int       3
M01_L48:
       call      qword ptr [7FF8ABC17A08]
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
       mov       rdx,17D910007B8
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
       mov       rdx,17D910007B0
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
       mov       rdx,7FF8AC31E3A0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8AC31E390
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8AC118FA0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8AC31E390
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8AC31E3A0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8AC31E3B0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8AC2E0400
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8AC31E4B8
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8ABFAF588]
       mov       ecx,2A41
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC1DDA88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC1DDAA0]
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
       mov       rdx,7FF8AC2E0418
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC296EE0]
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
       mov       rdx,7FF8AC2E89F0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2E89F0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8AB9F6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC2E0418
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC31E390
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8AC297AE0]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8AC297528]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8AB9413E8
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8AC297540]
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
       mov       rdx,7FF8AC2E0418
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC296EE0]
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
       mov       rdx,7FF8AC2E89F0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2E0418
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC296EE0]
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
       mov       rdx,7FF8AC2E89F0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8AC2976D8]
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
       call      qword ptr [7FF8AC2976F0]
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
       mov       r11,7FF8AB9413E8
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
       call      qword ptr [7FF8ABDFBAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AB9F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rcx,19964800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L40
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D6940D88
       mov       r10d,94DA3F49
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
       call      qword ptr [7FF8ABB65038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       rdx,7FF8AC3BB5B8
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L33:
       mov       rcx,rdi
       mov       rdx,7FF8AC26E0A8
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AB9FE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC26E0C0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABD5DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8AB9FE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8AB9416B8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8AC294DF8]
       int       3
M01_L48:
       call      qword ptr [7FF8ABC17A08]
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
       mov       rdx,1997A8007D8
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
       mov       rdx,1997A8007D0
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
       mov       rdx,7FF8AC3BB488
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8AC3BB478
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8AC1C9218
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB478
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB488
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB498
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8AC2EF530
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB5A0
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8ABFAF588]
       mov       ecx,2A41
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCD4D10
       call      qword ptr [7FF8ABC17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC0FE088]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC0FE0A0]
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
       mov       rdx,7FF8AC2EF548
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC297708]
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
       mov       rdx,7FF8AC31D220
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC31D220
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8AB9F6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC2EF548
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3BB478
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8AC29C0C0]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8AC297BA0]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8AB9416C0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8AC297BB8]
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
       mov       rdx,7FF8AC2EF548
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC297708]
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
       mov       rdx,7FF8AC31D220
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2EF548
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC297708]
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
       mov       rdx,7FF8AC31D220
       call      qword ptr [7FF8AB9FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8AC297CF0]
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
       call      qword ptr [7FF8AC297D08]
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
       mov       r11,7FF8AB9416C0
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3651
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
       call      qword ptr [7FF8ABDEBAB8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AB9E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,[rcx+78]
       test      r11,r11
       je        near ptr M01_L32
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L40
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M01_L35
       mov       rcx,1ECA0C00068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0C194DFFA
       mov       r10d,9E3D2C3F
       cmp       edx,8
       jb        near ptr M01_L24
       mov       r9d,edx
       shr       r9d,3
       nop
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
       mov       rdx,7FF8AC3BB8F8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF8AC230AD8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AB9EE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rdi
       mov       rdx,7FF8AC230AF0
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC2A70D8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD4DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8AB9EE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF8AB9316C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L84
M01_L47:
       call      qword ptr [7FF8AC2A5188]
       int       3
M01_L48:
       call      qword ptr [7FF8ABC07A08]
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
       mov       rdx,1ECA0C02820
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
       mov       rdx,1ECA0C02818
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
       mov       rdx,7FF8AC3BB7C8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L61:
       mov       rdx,7FF8AC3BB7B8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L62:
       mov       rcx,rdx
       mov       rdx,7FF8AC236CD0
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L63:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB7B8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB7C8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB7D8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF8AC387D68
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF8AC3BB8E0
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L68:
       call      qword ptr [7FF8ABF9F588]
       mov       ecx,2A41
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC0E5C50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC0E5C68]
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
       mov       rdx,7FF8AC387D80
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L71:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2A7B58]
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
       mov       rdx,7FF8AC3B5698
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3B5698
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L77:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L78:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF8AB9E6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC387D80
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3BB7B8
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L83:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF8AC2AC288]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF8AC2A7D68]
       jmp       near ptr M01_L51
M01_L84:
       mov       rcx,rax
       mov       r11,7FF8AB9316D0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L85:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF8AC2A7D80]
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
       mov       rdx,7FF8AC387D80
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L89:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2A7B58]
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
       mov       rdx,7FF8AC3B5698
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC387D80
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L95:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2A7B58]
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
       mov       rdx,7FF8AC3B5698
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L98:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L99:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8AC2A7F90]
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
       call      qword ptr [7FF8AC2A7FA8]
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
       mov       r11,7FF8AB9316D0
       call      qword ptr [r11]
M01_L109:
       nop
       add       rsp,28
       ret
; Total bytes of code 3642
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
       mov       rdx,7FF8AC345E80
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
       call      qword ptr [7FF8AC1C6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1C6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1C63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC356030
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
       call      qword ptr [7FF8AC1D6340]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1D63E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D63B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8AC300030
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
       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF8AC1D6400]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D63D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FF8ABB36288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8ABF9F528]
       mov       ecx,66ED
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC1CD7D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC1CD7E8]
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
       mov       rdx,7FF8AC2DB100
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8AC2DB110
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8AC2DB120
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8ABC0C228]
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
       mov       rdx,7FF8AC2DB120
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2DB110
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8AC3F4B88]
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
       jmp       qword ptr [7FF8AC286DA8]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8AC286DC0]
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
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8AB9E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8AB9E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2FCE6860008
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
       call      qword ptr [7FF8AC1CF7E0]
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
       call      qword ptr [7FF8ABB36288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8ABF9F588]
       mov       ecx,66ED
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCC4D10
       call      qword ptr [7FF8ABC07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC1CD7D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC1CD7E8]
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
       mov       rdx,7FF8AC309D38
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8AC309D48
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8AC309D58
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8ABC0C228]
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
       mov       rdx,7FF8AC309D58
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC309D48
       call      qword ptr [7FF8AB9EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8AC287978]
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
       jmp       qword ptr [7FF8AC2872D0]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8AC2872E8]
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
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8AB9E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8AB9E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26DB30A0008
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
       call      qword ptr [7FF8AC1CFAF8]
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
       call      qword ptr [7FF8ABB66288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8ABFCF588]
       mov       ecx,66ED
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC1FD830]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC1FD848]
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
       mov       rdx,7FF8AC33F540
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8AC33F550
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8AC33F560
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8ABC3C228]
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
       mov       rdx,7FF8AC33F560
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC33F550
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8AC2B7900]
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
       jmp       qword ptr [7FF8AC2B7468]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8AC2B7480]
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
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27D51C80008
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
       call      qword ptr [7FF8AC1FFA98]
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
       call      qword ptr [7FF8ABB56288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8ABFB77C8]
       mov       ecx,66ED
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC1DEEF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC1DEF10]
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
       mov       rdx,7FF8AC3B8EB8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8AC3B8EC8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8AC3B8ED8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8ABC2C228]
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
       mov       rdx,7FF8AC3B8ED8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3B8EC8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8AC2C72D0]
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
       jmp       qword ptr [7FF8AC2C6E68]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8AC2C6E80]
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
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E08E4B0008
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
       call      qword ptr [7FF8AC1DF090]
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
       call      qword ptr [7FF8ABB66288]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF8ABFCF588]
       mov       ecx,66ED
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC115C20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC115C38]
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
       mov       rdx,7FF8AC3EC268
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF8AC3EC278
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF8AC3EC288
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF8ABC3C228]
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
       mov       rdx,7FF8AC3EC288
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3EC278
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF8AC2DC0F0]
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
       jmp       qword ptr [7FF8AC2D7D80]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF8AC2D7D98]
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
       call      00007FF90B6950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EA9A160008
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
       call      qword ptr [7FF8AC23F5A0]
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
       mov       rdx,7FF8AC3714A0
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
       mov       rdx,7FF8AC205BF8
       call      qword ptr [7FF8AC1D6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E8768
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D6A00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D69B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC391980
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
       mov       rdx,7FF8AC225AD0
       call      qword ptr [7FF8AC1F63A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC208800
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1F6A48]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1F6A00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC31C8A8
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
       mov       rdx,7FF8AC215AD0
       call      qword ptr [7FF8AC1E6358]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1F8768
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1E6A00]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1E69B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC36B160
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
       mov       rdx,7FF8AC2057B0
       call      qword ptr [7FF8AC1D62E0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E8018
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D6910]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D68C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC36A818
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
       mov       rdx,7FF8AC205D20
       call      qword ptr [7FF8AC1D6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1E8018
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC1D69B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC1D6970]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC3371C0
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
       mov       rdx,7FF8AC235AC0
       call      qword ptr [7FF8AC206370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC218018
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC2069A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC206958]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,7FF8AC2D73B8
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
       mov       rdx,7FF8AC1B1D10
       call      qword ptr [7FF8AC0DE5B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF8AC1A9708
       call      qword ptr [7FF8ABC17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF8AC0DEBE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0DEB98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8ABE2BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8ABA25A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF8ABB79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L10
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rax,7FF8ABB79DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L14
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rcx,2230BC00068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0D0DE4EEE
       mov       r10d,136C0E21
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
       mov       rdx,7FF8AC35B948
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L42:
       mov       rdx,7FF8AC2A28D8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC2A28F0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC2B7558]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD8DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8ABA2E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8AB9715E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8AC2B4630]
       int       3
M01_L58:
       call      qword ptr [7FF8ABC47A08]
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
       call      qword ptr [7FF8ABDD61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,22321C007B8
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
       mov       rcx,22321C007C0
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
       mov       rdx,22321C007B0
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
       mov       rdx,7FF8AC216FE0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8AC217028
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8AC35BB20
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8AC35BB30
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8AC35BC40
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8AC35BC50
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8AC217078
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8AC35E2A8
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8AC148F70
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8AC35B808
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8ABA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8ABA25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8AC313AB8
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8AC35B930
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8ABFDF588]
       mov       ecx,66ED
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABD04D10
       call      qword ptr [7FF8ABC47798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA27858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC20DE18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8AC20DE30]
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
       mov       rdx,7FF8AC313AD0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2B7B58]
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
       mov       rdx,7FF8AC318CE0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC318CE0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8ABA26358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC313AD0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABC4C228]
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
       mov       rdx,7FF8AC318CE0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC318CE0
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABFDEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8ABFDEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8ABA2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF8ABA2E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF8AC35B818
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC35B828
       call      qword ptr [7FF8ABA2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8ABA2E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8ABB76240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AC2B7948]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8AB9715E8
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
       mov       rdx,7FF8AC35BC80
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8AC2FCA38
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC35BC70
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2BC7E0]
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
       mov       rdx,7FF8AC35BC60
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2BC7F8]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8ABC47E58]
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
       mov       rdx,7FF8AC35E298
       call      qword ptr [7FF8ABC47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8AC124558]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF8ABE28338
       call      qword ptr [7FF8ABC47798]
       mov       rcx,rax
       call      qword ptr [7FF8AC20E460]
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
       mov       r11,7FF8AB9715E8
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
       call      qword ptr [7FF8ABE0BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8ABA05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF8ABB59DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L10
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rax,7FF8ABB59DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L14
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rcx,229DB000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,5AEA19C2
       mov       r10d,0E6BE4BFB
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
       mov       rdx,7FF8AC3C05B8
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L42:
       mov       rdx,7FF8AC282868
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC282880
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8AC2974C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8ABA0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8AB9515C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8AC2945D0]
       int       3
M01_L58:
       call      qword ptr [7FF8ABC27A08]
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
       call      qword ptr [7FF8ABDB61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,229F10007B8
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
       mov       rcx,229F10007C0
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
       mov       rdx,229F10007B0
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
       mov       rdx,7FF8AC1F6FE0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8AC1F7028
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8AC3C0790
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8AC3C07A0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8AC3C08B0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8AC3C08C0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8AC1F7078
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8AC3C2B70
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8AC128F40
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8AC3C0478
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8AC2F1678
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8AC3C05A0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8ABFBF588]
       mov       ecx,66ED
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC1EDE90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8AC1EDEA8]
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
       mov       rdx,7FF8AC2F1690
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC297D68]
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
       mov       rdx,7FF8AC2FC5C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2FC5C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8ABA06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC2F1690
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABC2C228]
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
       mov       rdx,7FF8AC2FC5C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC2FC5C0
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABFBEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8ABFBEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF8ABA0E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF8AC3C0488
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3C0498
       call      qword ptr [7FF8ABA0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8ABB56240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AC297B58]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8AB9515D0
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
       mov       rdx,7FF8AC3C08F0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8AC2DD140
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3C08E0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC29C780]
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
       mov       rdx,7FF8AC3C08D0
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC29C798]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8ABC27E58]
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
       mov       rdx,7FF8AC3C2B60
       call      qword ptr [7FF8ABC27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8AC104588]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF8ABE08338
       call      qword ptr [7FF8ABC27798]
       mov       rcx,rax
       call      qword ptr [7FF8AC1EE778]
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
       mov       r11,7FF8AB9515D0
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
       call      qword ptr [7FF8ABE1BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8ABA15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF8ABB69DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L10
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rax,7FF8ABB69DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L14
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rcx,1EC47800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L50
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0E4E7A0E9
       mov       r10d,0EBEF3C6C
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
       call      qword ptr [7FF8ABB85038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8ABD7DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       rdx,7FF8AC3DB188
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L43:
       mov       rdx,7FF8AC28B5B0
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF8AC28B5C8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABD7DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8ABA1E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8AB9616C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8AC2A52F0]
       int       3
M01_L58:
       call      qword ptr [7FF8ABC37A08]
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
       call      qword ptr [7FF8ABDC61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,1EC5D8007B8
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
       mov       rcx,1EC5D8007C0
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
       mov       rdx,1EC5D8007B0
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
       mov       rdx,7FF8AC2419E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8AC241A30
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DB360
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DB370
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DB480
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DB490
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8AC241A80
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8AC3DAF30
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8AC1E7A98
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8AC3DB048
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8AC30D050
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8AC3DB170
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8ABFCF5A0]
       mov       ecx,66ED
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCF4D10
       call      qword ptr [7FF8ABC37798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA17858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC11EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8AC11EEF8]
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
       mov       rdx,7FF8AC30D068
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2AC570]
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
       mov       rdx,7FF8AC3D28E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3D28E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8ABA16358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF8AC30D068
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABC3C228]
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
       mov       rdx,7FF8AC3D28E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3D28E8
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABFCF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8ABFCF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8ABA1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF8ABA1E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF8AC3DB058
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3DB068
       call      qword ptr [7FF8ABA1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8ABA1E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8ABB66240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AC2AC3C0]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8AB9616D0
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
       mov       rdx,7FF8AC3DB4C0
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8AC24FC68
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3DB4B0
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2ACB28]
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
       mov       rdx,7FF8AC3DB4A0
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2ACB40]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8ABC37E58]
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
       mov       rdx,7FF8AC3DAF20
       call      qword ptr [7FF8ABC37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8AC115C80]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF8ABE18338
       call      qword ptr [7FF8ABC37798]
       mov       rcx,rax
       call      qword ptr [7FF8AC11F6C0]
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
       mov       r11,7FF8AB9616D0
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
       call      qword ptr [7FF8ABE0BAF0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rax,[rdx+0B0]
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
       call      qword ptr [7FF8ABA05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF8ABB59DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L10
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
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
       mov       rax,7FF8ABB59DD0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90B53C750
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF90B954A90],0
       je        short M01_L14
       call      qword ptr [7FF90B942648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90B61A2B0
       cmp       dword ptr [7FF90B954A90],0
       jne       near ptr M01_L111
M01_L16:
       mov       rbx,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       r14,[rbp-0A0]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
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
       mov       r11,[rdx+0C8]
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
       mov       r11,[rdx+0D0]
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
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M01_L43
M01_L26:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L51
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M01_L46
       mov       rcx,1CCEC000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L50
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,5616B4F6
       mov       r10d,483E5EDE
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
       call      qword ptr [7FF8ABB75038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       rdx,7FF8AC3DD610
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L43:
       mov       rdx,7FF8AC250B80
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L53
       jmp       short M01_L54
M01_L53:
       mov       rdx,7FF8AC250B98
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABD6DA40]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF8ABA0E9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF8AB9516F0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF8AC2C5698]
       int       3
M01_L58:
       call      qword ptr [7FF8ABC27A08]
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
       call      qword ptr [7FF8ABDB61B0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,1CCEC002820
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
       mov       rcx,1CCEC002828
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
       mov       rdx,1CCEC002818
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
       mov       rdx,7FF8AC2A1CA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF8AC2A1CE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DD830
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DD840
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DD950
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF8AC3DD960
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF8AC2A1D38
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF8AC3DD328
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF8AC256D78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF8AC3DD450
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF8ABA05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF8AC3A8C20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF8AC3DD5F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF8ABFBF588]
       mov       ecx,66ED
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4D10
       call      qword ptr [7FF8ABC27798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8ABA07858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8AC105C20]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8AC105C38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rsi,[rbp+18]
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L90
       jmp       short M01_L91
M01_L90:
       mov       rdx,7FF8AC3A8C38
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF8AC2CC828]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L92:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L93
       jmp       short M01_L94
M01_L93:
       mov       rdx,7FF8AC3D77F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L96
       jmp       short M01_L97
M01_L96:
       mov       rdx,7FF8AC3D77F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF8ABA06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L03
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M01_L99
       jmp       short M01_L100
M01_L99:
       mov       rdx,7FF8AC3A8C38
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABC2C228]
       int       3
M01_L102:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L103
       jmp       short M01_L104
M01_L103:
       mov       rdx,7FF8AC3D77F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L106
       jmp       short M01_L107
M01_L106:
       mov       rdx,7FF8AC3D77F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF8ABFBEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF8ABFBEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF8ABA0E958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        short M01_L118
       mov       rcx,rax
       jmp       short M01_L119
M01_L118:
       mov       rdx,7FF8AC3DD460
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,[rdx+0C0]
       test      r11,r11
       je        short M01_L120
       jmp       short M01_L121
M01_L120:
       mov       rdx,7FF8AC3DD470
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF8ABA0E8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF8ABB56240]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF8AC2CC5A0]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF8AB9516F8
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
       mov       rdx,7FF8AC3DD990
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF8AC127C00
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8AC3DD980
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2CCD08]
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
       mov       rdx,7FF8AC3DD970
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF8AC2CCD20]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF8ABC27E58]
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
       mov       rdx,7FF8AC3DD318
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF8AC107D20]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF8ABE08338
       call      qword ptr [7FF8ABC27798]
       mov       rcx,rax
       call      qword ptr [7FF8AC1062B0]
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
       mov       r11,7FF8AB9516F8
       call      qword ptr [r11]
M01_L149:
       nop
       add       rsp,28
       ret
; Total bytes of code 4972
```

