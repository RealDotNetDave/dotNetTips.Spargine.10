## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C70C420]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C70C408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C70C4E0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C70C4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5758]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C6E5818]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E57E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF80C81A038
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705710]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF80C7056F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C7057D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7057A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF80C829458
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715680]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF80C715668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C715740]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C32A938]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 67
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
       mov       rcx,1E90CC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DF821963
       mov       r8d,0C33EEBDE
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
       mov       rdx,1E922C007B8
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
       call      qword ptr [7FF80BF25A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF80BF2F498]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF80C8035F0
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF80C795FA8
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF80C795FC0
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF2F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80C2AD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF80C2AD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF80C107810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       rdx,1E922C007B0
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
       mov       rdx,7FF80C795FA8
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C795FC0
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE713C8
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C32AA98]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 67
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
       je        near ptr M01_L30
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L18
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L31
       mov       rcx,1B717000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0FD4895C1
       mov       r8d,0A8606FC4
       cmp       edx,8
       jb        near ptr M01_L16
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
       jne       near ptr M01_L17
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
       mov       rdx,1B72D0007B8
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
       call      qword ptr [7FF80BF25A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M01_L19
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
       je        near ptr M01_L20
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
       js        near ptr M01_L23
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
       je        near ptr M01_L21
M01_L13:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L27
M01_L14:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M01_L22
M01_L15:
       call      qword ptr [7FF80BF2F498]
       int       3
M01_L16:
       cmp       edx,4
       jb        near ptr M01_L32
M01_L17:
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
M01_L18:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rdx,7FF80C804908
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L20:
       mov       rdx,7FF80C796038
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L21:
       mov       rdx,7FF80C796050
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L13
M01_L22:
       test      eax,eax
       jge       near ptr M01_L12
M01_L23:
       cmp       dword ptr [rdi+30],0
       jg        short M01_L25
       mov       eax,[rdi+28]
       mov       [rsp+2C],eax
       cmp       [r14+8],eax
       jne       short M01_L24
       mov       ecx,[rdi+28]
       call      qword ptr [7FF80BF2F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80C2AD9B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
M01_L24:
       mov       eax,[rsp+2C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,r14d
       mov       r14,rcx
       jmp       short M01_L26
M01_L25:
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
M01_L26:
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
       jbe       short M01_L27
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L27
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C2AD9B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF80C107810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M01_L27:
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
M01_L28:
       mov       rdx,1B72D0007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L46
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L45
M01_L29:
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
M01_L30:
       mov       rdx,7FF80C796038
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L31:
       xor       ebp,ebp
       jmp       near ptr M01_L04
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
       mov       rdx,7FF80C796050
       call      qword ptr [7FF80BF2F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE711B0
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
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L28
M01_L45:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L29
M01_L46:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L29
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1847
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C33A938]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 67
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
       mov       rcx,11EAAC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4D632D95
       mov       r8d,0D9A20FD7
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
       mov       rdx,11EC0C007B8
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
       call      qword ptr [7FF80BF35A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       call      qword ptr [7FF80BF3F498]
       int       3
M01_L16:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,7FF80C81DE98
       call      qword ptr [7FF80BF3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L18:
       mov       rdx,7FF80C7AECC8
       call      qword ptr [7FF80BF3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       rdx,7FF80C7AECE0
       call      qword ptr [7FF80BF3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF3F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80C2BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF80C2BD980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF80C117810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       rdx,11EC0C007B0
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
       mov       rdx,7FF80C7AECC8
       call      qword ptr [7FF80BF3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C7AECE0
       call      qword ptr [7FF80BF3F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE81140
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Add()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AA98]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
; Total bytes of code 67
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
       je        near ptr M01_L30
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L18
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L31
       mov       rcx,224A6C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L35
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0FA8C4218
       mov       r8d,7EB69950
       cmp       edx,8
       jb        near ptr M01_L16
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
       jne       near ptr M01_L17
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
       mov       rdx,224BCC00820
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
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        near ptr M01_L19
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
       je        near ptr M01_L20
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
       js        near ptr M01_L23
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
       je        near ptr M01_L21
M01_L13:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L27
M01_L14:
       mov       rax,[rsp+20]
       mov       eax,[rax+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M01_L22
M01_L15:
       call      qword ptr [7FF80C127A20]
       int       3
M01_L16:
       cmp       edx,4
       jb        near ptr M01_L32
M01_L17:
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
M01_L18:
       mov       rcx,r13
       mov       rdx,rbp
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rdx,7FF80C879BB8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L20:
       mov       rdx,7FF80C833CA8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L11
M01_L21:
       mov       rdx,7FF80C833CC0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L13
M01_L22:
       test      eax,eax
       jge       near ptr M01_L12
M01_L23:
       cmp       dword ptr [rdi+30],0
       jg        short M01_L25
       mov       eax,[rdi+28]
       mov       [rsp+2C],eax
       cmp       [r14+8],eax
       jne       short M01_L24
       mov       ecx,[rdi+28]
       call      qword ptr [7FF80C075020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
M01_L24:
       mov       eax,[rsp+2C]
       mov       r14d,eax
       lea       ecx,[r14+1]
       mov       [rdi+28],ecx
       mov       rcx,[rdi+10]
       mov       rax,rcx
       mov       rcx,rax
       mov       eax,r14d
       mov       r14,rcx
       jmp       short M01_L26
M01_L25:
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
M01_L26:
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
       jbe       short M01_L27
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L27
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF80BF0EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
M01_L27:
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
M01_L28:
       mov       rdx,224BCC00818
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L46
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L45
M01_L29:
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
M01_L30:
       mov       rdx,7FF80C833CA8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L31:
       xor       ebp,ebp
       jmp       near ptr M01_L04
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
       mov       rdx,7FF80C833CC0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE512D0
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
       jmp       near ptr M01_L28
M01_L44:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L28
M01_L45:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L29
M01_L46:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L29
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1847
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C7FDEF8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6F0998
       call      qword ptr [7FF80C6E52F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6D95D0
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5818]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E57D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.AddRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71C830
       call      qword ptr [7FF80C705230]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6F94E8
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C80D540
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70CEF0
       call      qword ptr [7FF80C6F5668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6EB940
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5B90]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5B48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C80D678
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FC840
       call      qword ptr [7FF80C6E5230]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6D94E8
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6BAA30
       call      qword ptr [7FF80C5EDA58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 91
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
       mov       rdx,7FF80C6A8B20
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C5EDBC0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C5EDB78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FCEF0
       call      qword ptr [7FF80C6E5620]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 91
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
       mov       rdx,7FF80C6DA940
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5740]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C819CA0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70C280
       call      qword ptr [7FF80C6F5158]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6E8478
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F52C0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5278]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C809C68
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70D5C0
       call      qword ptr [7FF80C6F5740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6EAA28
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F58A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5860]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31AAA8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 97
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
       mov       rdx,239D9C007B8
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
       call      qword ptr [7FF80C56EE50]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF80C56EE50]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,239D9C007C0
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
       mov       rdx,239D9C007B0
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
       call      qword ptr [7FF80C7078D0]
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
       call      qword ptr [7FF80C137E70]
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
       mov       r11,7FF80BE61588
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,239C3C01FB0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF80BE54000
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF80C70D2C0]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF80BE61590
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,239C3C01FB0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF80BE61568
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE61570
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE61578
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
       call      qword ptr [7FF80C08E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE61580
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF80BF157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF80C13C240]
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
       call      qword ptr [7FF80C7C6E50]
       int       3
M01_L28:
       call      qword ptr [7FF80BF157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF80C3173C8
       call      qword ptr [7FF80C1377B0]
       mov       rcx,rax
       call      qword ptr [7FF80C70D2F0]
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
       mov       r11,7FF80BE61580
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AAA8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 97
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
       mov       rdx,1C5F04007B8
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
       call      qword ptr [7FF80C577198]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF80C577198]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1C5F04007C0
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
       mov       rdx,1C5F04007B0
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
       call      qword ptr [7FF80C6D70D8]
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
       call      qword ptr [7FF80C127E70]
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
       mov       r11,7FF80BE515A0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,1C5DA401F98
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF80BE44000
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF80C6DD8C0]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF80BE515A8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,1C5DA401F98
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF80BE51580
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE51588
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE51590
       call      qword ptr [r11]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edi,[r14+10]
       cmp       [rcx+8],edi
       jbe       short M01_L22
       lea       edx,[rdi+1]
       mov       [r14+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L21
M01_L22:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FF80C07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE51598
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF80C12C240]
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
       call      qword ptr [7FF80C7A5E30]
       int       3
M01_L28:
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF80C3073C8
       call      qword ptr [7FF80C1277B0]
       mov       rcx,rax
       call      qword ptr [7FF80C6D6910]
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
       mov       r11,7FF80BE51598
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1480
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AAA8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 97
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
       mov       rdx,1ACD38007B8
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
       call      qword ptr [7FF80C55EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF80C55EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1ACD38007C0
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
       mov       rdx,1ACD38007B0
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
       call      qword ptr [7FF80C6FCD50]
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
       call      qword ptr [7FF80C127E70]
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
       mov       r11,7FF80BE516F8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,1ACBD801FB0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF80BE44000
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF80C5FE880]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF80BE51700
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,1ACBD801FB0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF80BE516D8
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE516E0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE516E8
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
       call      qword ptr [7FF80C07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE516F0
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF80C12C240]
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
       call      qword ptr [7FF80C7C7690]
       int       3
M01_L28:
       call      qword ptr [7FF80BF057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF80C3073C8
       call      qword ptr [7FF80C1277B0]
       mov       rcx,rax
       call      qword ptr [7FF80C5FE8B0]
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
       mov       r11,7FF80BE516F0
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Clear()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31AAA8]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Clear()
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 97
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
       mov       rdx,18F8AC00828
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
       call      qword ptr [7FF80C56EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      qword ptr [7FF80C56EEB0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M01_L08:
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,18F8AC00830
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
       mov       rdx,18F8AC00820
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
       call      qword ptr [7FF80C6069B8]
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
       call      qword ptr [7FF80C137E70]
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
       mov       r11,7FF80BE616E0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,18F74C01FE8
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L18:
       mov       [rbp-40],eax
       mov       ecx,28F
       mov       rdx,7FF80BE54000
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       ecx,[rbp-40]
       call      qword ptr [7FF80C6055F0]
       int       3
M01_L19:
       mov       rcx,r15
       mov       rdx,r13
       mov       r11,7FF80BE616E8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,18F74C01FE8
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,7FF80BE616C0
       call      qword ptr [r11]
       mov       [rbp-50],rax
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE616C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L23
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE616D0
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
       call      qword ptr [7FF80C08E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L21
M01_L23:
       mov       rcx,[rbp-50]
       mov       r11,7FF80BE616D8
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L24:
       mov       rdx,r8
       call      qword ptr [7FF80BF157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L06
M01_L25:
       mov       ecx,2
       call      qword ptr [7FF80C13C240]
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
       call      qword ptr [7FF80C7D7960]
       int       3
M01_L28:
       call      qword ptr [7FF80BF157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L29:
       mov       ecx,445
       mov       rdx,7FF80C3173C8
       call      qword ptr [7FF80C1377B0]
       mov       rcx,rax
       call      qword ptr [7FF80C605620]
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
       mov       r11,7FF80BE616D8
       call      qword ptr [r11]
M01_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1479
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FEF70
       call      qword ptr [7FF80C705728]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6EAD10
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705920]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7058D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6BAA30
       call      qword ptr [7FF80C5EDA88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6A8E08
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C5EDC80]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C5EDC38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C80B170
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FC280
       call      qword ptr [7FF80C6E5170]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6D8760
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5368]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5320]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C81A5F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71C418
       call      qword ptr [7FF80C705560]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6FAA20
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70D5C0
       call      qword ptr [7FF80C6F5740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6EBE98
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5DE8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5DA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FC6A8
       call      qword ptr [7FF80C6E5260]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6D98E8
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5908]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E58C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C82F8F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C72D5B0
       call      qword ptr [7FF80C715728]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C70BE98
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715DD0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715D88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C82FA08
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71C840
       call      qword ptr [7FF80C705278]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6F98E8
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705920]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7058D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.IntersectWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 81
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715698]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715680]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C7157A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715770]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705188]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705170]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C705290]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF80C82A9D0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715680]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF80C715668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C715788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715758]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FF80C7FA6C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5680]; DotNetTips.Spargine.Benchmarking.CollectionBenchmark.get_PersonRefLookupLast()
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
       call      qword ptr [7FF80C6E5668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rax+1A8]
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
       call      qword ptr [7FF80C6E5788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5758]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31A9D0]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 68
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
       mov       rcx,23980000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,28C512C1
       mov       r8d,5E6B7FC5
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
       mov       rdx,7FF80C786280
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF80C4CF168]
       mov       ecx,245B
       mov       rdx,7FF80C1F4FD8
       call      qword ptr [7FF80BF1F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F4FD8
       call      qword ptr [7FF80BF1F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F4FD8
       call      qword ptr [7FF80BF1F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C70CEE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C70CF00]
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
       mov       rdx,7FF80C786298
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE615A8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,239800027B0
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
       mov       rdx,7FF80C786280
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,23980000068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,28C512C1
       mov       r9d,5E6B7FC5
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
       mov       rdx,7FF80C786298
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE615B0
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
       call      qword ptr [7FF80BF1F498]
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
       mov       rdx,239800027A8
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31AB30]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 68
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
       mov       rcx,17270C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2C26A94
       mov       r8d,0B7B5E031
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
       mov       rdx,7FF80C7275B8
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF80C4C7438]
       mov       ecx,245B
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C7B50C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C6ECAF8]
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
       mov       rdx,7FF80C7275D0
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE613F8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,17286C007B8
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
       mov       rdx,7FF80C7275B8
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,17270C00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,2C26A94
       mov       r9d,0B7B5E031
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
       mov       rdx,7FF80C7275D0
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE61400
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
       call      qword ptr [7FF80C137A20]
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
       mov       rdx,17286C007B0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31AB30]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 68
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
       mov       rcx,242E0800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L17
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,89214585
       mov       r8d,0D6130DEF
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
       mov       rdx,7FF80C78FC40
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FF80C4CF1F8]
       mov       ecx,245B
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C60D3F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C60D410]
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
       mov       rdx,7FF80C78FC58
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE616F8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,242F68007B8
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
       mov       rdx,7FF80C78FC40
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,242E0800068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,89214585
       mov       r9d,0D6130DEF
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
       mov       rdx,7FF80C78FC58
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE61700
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
       call      qword ptr [7FF80C137A20]
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
       mov       rdx,242F68007B0
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.Remove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+1A8]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C31AB30]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       short M00_L00
; Total bytes of code 68
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
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L17
       mov       rdx,[rbp+28]
       test      rdx,rdx
       je        near ptr M01_L10
       mov       rcx,1E11DC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M01_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CD44CD5F
       mov       r8d,54E764F7
       cmp       edx,8
       jb        near ptr M01_L11
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
       mov       rdx,7FF80C745690
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FF80C4CF1F8]
       mov       ecx,245B
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C607060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C607078]
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
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdx,7FF80C7456A8
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE616D8
       call      qword ptr [r11]
       jmp       short M01_L22
M01_L21:
       mov       rcx,r13
       mov       r8,rbx
       call      qword ptr [r11]
M01_L22:
       test      eax,eax
       je        near ptr M01_L06
       mov       rdx,1E133C00828
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
       mov       rdx,7FF80C745690
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,1E11DC00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M01_L36
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,0CD44CD5F
       mov       r9d,54E764F7
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
       mov       rdx,7FF80C7456A8
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       r11,7FF80BE616E0
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
       call      qword ptr [7FF80C137A20]
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
       mov       rdx,1E133C00820
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E56C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
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
       call      qword ptr [7FF80C6E58F0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E58C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5110]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
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
       call      qword ptr [7FF80C6E5338]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C82B9E8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715560]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF80C715788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715758]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C83AFB8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C725740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF80C725968]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C725938]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveRange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+20]
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C73DAB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
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
       call      qword ptr [7FF80C73DCE0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C73DCB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveWhere()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1E673802A38
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
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1E673802A30
       mov       rax,[rax]
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF80BEF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rbp-30]
       mov       rcx,1E673802A38
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       [rbp-3C],eax
       mov       edx,[rbp-3C]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80C6E56B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 277
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       mov       rsi,[rcx-18]
       mov       rcx,rsi
       test      cl,1
       jne       short M01_L00
       mov       rcx,7FF80C7469BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       mov       rcx,7FF80C7469B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80BEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 80
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
       call      qword ptr [7FF80C2F89A0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C479F68]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,7FF80C7490AC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,7FF80C7490A8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF80C6EDE00]
       int       3
; Total bytes of code 82
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
       call      qword ptr [7FF80C6E5D10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5CE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.RemoveWhere()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BF35728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1C1D4000A40
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
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BF35728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1C1D4000A38
       mov       rax,[rax]
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF80BF36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c
       call      qword ptr [7FF80BF35728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rbp-30]
       mov       rcx,1C1D4000A40
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       [rbp-3C],eax
       mov       edx,[rbp-3C]
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80C7256C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 277
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       mov       rsi,[rcx-18]
       mov       rcx,rsi
       test      cl,1
       jne       short M01_L00
       mov       rcx,7FF80C786A3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       mov       rcx,7FF80C786A38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80BF35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 80
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
       call      qword ptr [7FF80C3389A0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C4B9EA8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,7FF80C7890E4
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rcx,7FF80C7890E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF80C72DE30]
       int       3
; Total bytes of code 82
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
       call      qword ptr [7FF80C725D28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C725CF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,28023400A40
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
       mov       rcx,7FF80C82FB88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,28023400A38
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF80BF26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,28023400A40
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF80C82FB8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF80C82FB90
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
       call      qword ptr [7FF80C7156F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF80C3289A0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person.get_Addresses()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C4A9EA8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FF80C71DE48]
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
       call      qword ptr [7FF80C715D58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715D28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rax,1931B802A38
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
       mov       rcx,7FF80C80FB20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Predicate<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rax,1931B802A30
       mov       rdx,[rax]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark+<>c.<RemoveWhere>b__9_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF80BF06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-30]
       mov       rcx,1931B802A38
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       mov       rcx,7FF80C80FB24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,7FF80C80FB28
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
       call      qword ptr [7FF80C6E5158]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       r11,7FF80BE51488
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
       call      qword ptr [7FF80C6EDE30]
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
       call      qword ptr [7FF80C6E57B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5788]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C72CEF0
       call      qword ptr [7FF80C715668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C70A838
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C7157A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715758]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70C830
       call      qword ptr [7FF80C6F5218]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6E8370
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5350]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C81AB80
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71D5C0
       call      qword ptr [7FF80C7056F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6FA920
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705830]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7057E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C82AB78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C72D5C0
       call      qword ptr [7FF80C715728]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C70A920
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715860]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715818]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AB48]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       je        near ptr M01_L69
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L70
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L73
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L63
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L76
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L79
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L82
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L65
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
       je        near ptr M01_L66
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L67
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
       je        near ptr M01_L68
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
       mov       rcx,239DD000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,85398739
       mov       r10d,0B0201D7A
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
       mov       rdx,7FF80C81D2B8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF80C776288
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C7762A0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C6FF390]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80BF0EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF80BE51498
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L85
M01_L47:
       call      qword ptr [7FF80C6FF528]
       int       3
M01_L48:
       call      qword ptr [7FF80C127A20]
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
       jg        near ptr M01_L86
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L60
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L61
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L103
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L87
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L62
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
       je        near ptr M01_L88
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L91
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L94
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L97
M01_L55:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L101
       test      rdx,rdx
       je        near ptr M01_L100
       mov       rcx,[r15]
       cmp       rcx,[rdx]
       jne       near ptr M01_L100
M01_L56:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L102
M01_L57:
       mov       rdx,239F30007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L105
M01_L58:
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
       jne       near ptr M01_L108
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L107
M01_L59:
       mov       rdx,239F30007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L110
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L109
M01_L60:
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
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FF80C81D188
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L62:
       mov       rdx,7FF80C81D178
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L63:
       mov       rcx,rdx
       mov       rdx,7FF80C617040
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF80C81D178
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF80C81D188
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF80C81D198
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF80C7E3310
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF80C81D2A0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L69:
       call      qword ptr [7FF80C4BF1B0]
       mov       ecx,2875
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C6FCDB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C6FCDC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L70:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L71
       jmp       short M01_L72
M01_L71:
       mov       rcx,rdx
       mov       rdx,7FF80C7E3328
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L72:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7B6490]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L73:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L74
       jmp       short M01_L75
M01_L74:
       mov       rcx,rdx
       mov       rdx,7FF80C7EA698
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L75:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L76:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L77
       jmp       short M01_L78
M01_L77:
       mov       rdx,7FF80C7EA698
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L78:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L79:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF80BF06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       rcx,rdi
       mov       rdx,7FF80C7E3328
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L81:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L82:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       rcx,rdi
       mov       rdx,7FF80C81D178
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L84:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF80C7B7090]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80C7B6898]
       jmp       near ptr M01_L51
M01_L85:
       mov       rcx,rax
       mov       r11,7FF80BE514A0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L86:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF80C7B68B0]
       jmp       near ptr M01_L51
M01_L87:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L104
M01_L88:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L89
       jmp       short M01_L90
M01_L89:
       mov       rdx,7FF80C7E3328
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L90:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7B6490]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L92
       jmp       short M01_L93
M01_L92:
       mov       rdx,7FF80C7EA698
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L93:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L94:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rdx,7FF80C7E3328
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L96:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7B6490]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L97:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rdx,7FF80C7EA698
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L99:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L57
       jmp       short M01_L103
M01_L101:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L100
       jmp       near ptr M01_L56
M01_L102:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF80C7B6A30]
       jmp       short M01_L104
M01_L103:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7B6A48]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L57
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L104:
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L105:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L108:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L109:
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
M01_L110:
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
       je        short M01_L111
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L111
       mov       rcx,rax
       mov       r11,7FF80BE514A0
       call      qword ptr [r11]
M01_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3687
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C2FAB48]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       je        near ptr M01_L69
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L70
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L73
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L63
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L76
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L79
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L82
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L65
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
       je        near ptr M01_L66
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF80BEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L67
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
       je        near ptr M01_L68
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
       mov       rcx,131D9800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,4B174E9C
       mov       r10d,15E0AF43
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
       mov       rdx,7FF80C892EB0
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF80C766030
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BEFEE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C766048
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C6FF408]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C27D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80BEFEEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF80BE415B8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L85
M01_L47:
       call      qword ptr [7FF80C6FF528]
       int       3
M01_L48:
       call      qword ptr [7FF80C117A20]
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
       jg        near ptr M01_L86
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L60
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L61
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L103
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L87
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L62
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
       je        near ptr M01_L88
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L91
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L94
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L97
M01_L55:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L101
       test      rdx,rdx
       je        near ptr M01_L100
       mov       rcx,[r15]
       cmp       rcx,[rdx]
       jne       near ptr M01_L100
M01_L56:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L102
M01_L57:
       mov       rdx,131EF8007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L105
M01_L58:
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
       jne       near ptr M01_L108
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L107
M01_L59:
       mov       rdx,131EF8007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L110
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L109
M01_L60:
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
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FF80C892D80
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L62:
       mov       rdx,7FF80C892D70
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L63:
       mov       rcx,rdx
       mov       rdx,7FF80C607070
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF80C892D70
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF80C892D80
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF80C892D90
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF80C7D4080
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF80C892E98
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L69:
       call      qword ptr [7FF80C4AF1F8]
       mov       ecx,2875
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C6FCF48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C6FCF60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L70:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L71
       jmp       short M01_L72
M01_L71:
       mov       rcx,rdx
       mov       rdx,7FF80C7D4098
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L72:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7A6478]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L73:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L74
       jmp       short M01_L75
M01_L74:
       mov       rcx,rdx
       mov       rdx,7FF80C7DC530
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L75:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L76:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L77
       jmp       short M01_L78
M01_L77:
       mov       rdx,7FF80C7DC530
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L78:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L79:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF80BEF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       rcx,rdi
       mov       rdx,7FF80C7D4098
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L81:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L82:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       rcx,rdi
       mov       rdx,7FF80C892D70
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L84:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF80C7A6FE8]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80C7A6A78]
       jmp       near ptr M01_L51
M01_L85:
       mov       rcx,rax
       mov       r11,7FF80BE415C0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L86:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF80C7A6A90]
       jmp       near ptr M01_L51
M01_L87:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L104
M01_L88:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L89
       jmp       short M01_L90
M01_L89:
       mov       rdx,7FF80C7D4098
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L90:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7A6478]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L92
       jmp       short M01_L93
M01_L92:
       mov       rdx,7FF80C7DC530
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L93:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L94:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rdx,7FF80C7D4098
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L96:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7A6478]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L97:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rdx,7FF80C7DC530
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L99:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L57
       jmp       short M01_L103
M01_L101:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L100
       jmp       near ptr M01_L56
M01_L102:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF80C7A6C10]
       jmp       short M01_L104
M01_L103:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7A6C28]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L57
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L104:
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L105:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L108:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L109:
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
M01_L110:
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
       je        short M01_L111
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L111
       mov       rcx,rax
       mov       r11,7FF80BE415C0
       call      qword ptr [r11]
M01_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3687
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AB48]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       je        near ptr M01_L69
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L70
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L73
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L63
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L76
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L79
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L82
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L65
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
       je        near ptr M01_L66
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L67
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
       je        near ptr M01_L68
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
       mov       rcx,1CA05C00068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,3BC328C1
       mov       r10d,6D80695E
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
       mov       rdx,7FF80C8CD6C8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF80C790C90
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C790CA8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C7C40C0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80BF0EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF80BE514C0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L85
M01_L47:
       call      qword ptr [7FF80C7C4258]
       int       3
M01_L48:
       call      qword ptr [7FF80C127A20]
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
       jg        near ptr M01_L86
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L60
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L61
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L103
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L87
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L62
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
       je        near ptr M01_L88
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L91
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L94
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L97
M01_L55:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L101
       test      rdx,rdx
       je        near ptr M01_L100
       mov       rcx,[r15]
       cmp       rcx,[rdx]
       jne       near ptr M01_L100
M01_L56:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L102
M01_L57:
       mov       rdx,1CA1BC007B8
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L105
M01_L58:
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
       jne       near ptr M01_L108
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L107
M01_L59:
       mov       rdx,1CA1BC007B0
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L110
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L109
M01_L60:
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
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FF80C8CD598
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L62:
       mov       rdx,7FF80C8CD588
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L63:
       mov       rcx,rdx
       mov       rdx,7FF80C61BA78
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF80C8CD588
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF80C8CD598
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF80C8CD5A8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF80C7DF508
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF80C8CD6B0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L69:
       call      qword ptr [7FF80C4BF1B0]
       mov       ecx,2875
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C6ECF60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C6ECF78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L70:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L71
       jmp       short M01_L72
M01_L71:
       mov       rcx,rdx
       mov       rdx,7FF80C7DF520
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L72:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7C6D48]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L73:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L74
       jmp       short M01_L75
M01_L74:
       mov       rcx,rdx
       mov       rdx,7FF80C8C3318
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L75:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L76:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L77
       jmp       short M01_L78
M01_L77:
       mov       rdx,7FF80C8C3318
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L78:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L79:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF80BF06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       rcx,rdi
       mov       rdx,7FF80C7DF520
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L81:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L82:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       rcx,rdi
       mov       rdx,7FF80C8CD588
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L84:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF80C7C7648]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80C7C70A8]
       jmp       near ptr M01_L51
M01_L85:
       mov       rcx,rax
       mov       r11,7FF80BE514C8
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L86:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF80C7C70C0]
       jmp       near ptr M01_L51
M01_L87:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L104
M01_L88:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L89
       jmp       short M01_L90
M01_L89:
       mov       rdx,7FF80C7DF520
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L90:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7C6D48]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L92
       jmp       short M01_L93
M01_L92:
       mov       rdx,7FF80C8C3318
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L93:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L94:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rdx,7FF80C7DF520
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L96:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7C6D48]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L97:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rdx,7FF80C8C3318
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L99:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L57
       jmp       short M01_L103
M01_L101:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L100
       jmp       near ptr M01_L56
M01_L102:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF80C7C7228]
       jmp       short M01_L104
M01_L103:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7C7240]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L57
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L104:
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L105:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L108:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L109:
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
M01_L110:
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
       je        short M01_L111
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L111
       mov       rcx,rax
       mov       r11,7FF80BE514C8
       call      qword ptr [r11]
M01_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3687
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.ResetList()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AB48]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].Reset(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       je        near ptr M01_L69
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx]
       mov       rax,offset MT_System.String
       cmp       [rdx],rax
       je        near ptr M01_L70
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L73
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L63
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M01_L76
M01_L02:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsi]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        near ptr M01_L79
M01_L03:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L04:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L82
M01_L05:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M01_L65
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
       je        near ptr M01_L66
M01_L07:
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L09
       mov       ecx,eax
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M01_L67
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
       je        near ptr M01_L68
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
       mov       rcx,23114C00068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L39
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,8215E198
       mov       r10d,94A434D6
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
       mov       rdx,7FF80C8BE7C0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-58]
       jmp       near ptr M01_L13
M01_L32:
       mov       rcx,rdi
       mov       rdx,7FF80C834110
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C834128
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C72FBE8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80BF0EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,rax
       mov       r11,7FF80BE516C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       near ptr M01_L12
       jmp       near ptr M01_L85
M01_L47:
       call      qword ptr [7FF80C72FD80]
       int       3
M01_L48:
       call      qword ptr [7FF80C127A20]
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
       jg        near ptr M01_L86
M01_L51:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       cmp       rsi,rbx
       je        near ptr M01_L60
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B8]
       test      rax,rax
       je        near ptr M01_L61
M01_L52:
       mov       rcx,rax
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L103
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       je        near ptr M01_L87
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L62
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
       je        near ptr M01_L88
       mov       r15,[rbx+18]
       test      r15,r15
       je        near ptr M01_L91
M01_L54:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M01_L94
       mov       rdx,[r14+18]
       test      rdx,rdx
       je        near ptr M01_L97
M01_L55:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M01_L101
       test      rdx,rdx
       je        near ptr M01_L100
       mov       rcx,[r15]
       cmp       rcx,[rdx]
       jne       near ptr M01_L100
M01_L56:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       cmp       ecx,edx
       je        near ptr M01_L102
M01_L57:
       mov       rdx,2312AC00820
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M01_L106
       mov       rax,[rcx+20]
       test      rax,rax
       jne       near ptr M01_L105
M01_L58:
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
       jne       near ptr M01_L108
       mov       r10,[rcx+10]
       test      r10,r10
       jne       near ptr M01_L107
M01_L59:
       mov       rdx,2312AC00818
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M01_L110
       mov       rax,[rcx+18]
       test      rax,rax
       jne       near ptr M01_L109
M01_L60:
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
M01_L61:
       mov       rcx,rdx
       mov       rdx,7FF80C8BE690
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L52
M01_L62:
       mov       rdx,7FF80C8BE680
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L63:
       mov       rcx,rdx
       mov       rdx,7FF80C736990
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L01
M01_L64:
       mov       rcx,rdi
       mov       rdx,7FF80C8BE680
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L65:
       mov       rcx,rdi
       mov       rdx,7FF80C8BE690
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L66:
       mov       rcx,rdi
       mov       rdx,7FF80C8BE6A0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L07
M01_L67:
       mov       rcx,rdi
       mov       rdx,7FF80C87A3D0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L08
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF80C8BE7A8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L10
M01_L69:
       call      qword ptr [7FF80C4B7438]
       mov       ecx,2875
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C5EE1C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C5EE1D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L70:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+0A0]
       test      rdi,rdi
       je        short M01_L71
       jmp       short M01_L72
M01_L71:
       mov       rcx,rdx
       mov       rdx,7FF80C87A3E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L72:
       mov       rdx,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C856928]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M01_L00
M01_L73:
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        short M01_L74
       jmp       short M01_L75
M01_L74:
       mov       rcx,rdx
       mov       rdx,7FF80C8B7CD8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L75:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M01_L00
M01_L76:
       mov       rdi,[rsi]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L77
       jmp       short M01_L78
M01_L77:
       mov       rdx,7FF80C8B7CD8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L78:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L79:
       mov       rcx,[rsi+18]
       call      qword ptr [7FF80BF06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L03
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       rcx,rdi
       mov       rdx,7FF80C87A3E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L81:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L82:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       rcx,rdi
       mov       rdx,7FF80C8BE680
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L84:
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF80C857120]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80C856BB0]
       jmp       near ptr M01_L51
M01_L85:
       mov       rcx,rax
       mov       r11,7FF80BE516D0
       call      qword ptr [r11]
       jmp       near ptr M01_L50
M01_L86:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF80C856BC8]
       jmp       near ptr M01_L51
M01_L87:
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L104
M01_L88:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r15,[rdx+0A0]
       test      r15,r15
       je        short M01_L89
       jmp       short M01_L90
M01_L89:
       mov       rdx,7FF80C87A3E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M01_L90:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C856928]
       mov       rdx,rax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L54
M01_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L92
       jmp       short M01_L93
M01_L92:
       mov       rdx,7FF80C8B7CD8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L93:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       jmp       near ptr M01_L54
M01_L94:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+0A0]
       test      r13,r13
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rdx,7FF80C87A3E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L96:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C856928]
       mov       rdx,rax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M01_L55
M01_L97:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rdx,7FF80C8B7CD8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L99:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L55
M01_L100:
       mov       eax,[rbx+28]
       sub       eax,[rbx+30]
       mov       ecx,[rdi+28]
       sub       ecx,[rdi+30]
       cmp       eax,ecx
       jg        near ptr M01_L57
       jmp       short M01_L103
M01_L101:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L100
       jmp       near ptr M01_L56
M01_L102:
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF80C856DF0]
       jmp       short M01_L104
M01_L103:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C856E08]
       mov       [rbp-50],rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       cmp       edx,[rbp-50]
       jne       near ptr M01_L57
       cmp       dword ptr [rbp-4C],0
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L104:
       test      eax,eax
       je        near ptr M01_L57
       jmp       near ptr M01_L60
M01_L105:
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,r8
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L58
M01_L107:
       mov       rdx,rcx
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L108:
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L59
M01_L109:
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
M01_L110:
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
       je        short M01_L111
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-58]
       cmp       [rax],rcx
       je        short M01_L111
       mov       rcx,rax
       mov       r11,7FF80BE516D0
       call      qword ptr [r11]
M01_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3687
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705110]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
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
       call      qword ptr [7FF80C7051B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705188]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C7156B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 87
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
       call      qword ptr [7FF80C715758]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C829ED8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C7156F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF80C7157A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715770]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C809CD0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FF80C6F5710]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F56E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF80C067298]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF80C4CF1F8]
       mov       ecx,607F
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F5548
       call      qword ptr [7FF80C1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C70CBB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C70CBD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 238
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
       mov       rdx,7FF80C82E130
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C82E140
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C82E150
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF80C13C240]
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
       mov       rdx,7FF80C82E150
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C82E140
       call      qword ptr [7FF80BF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C7C67C0]
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
       jmp       qword ptr [7FF80C7C67D8]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7C67F0]
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
       call      00007FF86BBA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF80BF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF80BF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28F57790008
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
       call      qword ptr [7FF80C70EF58]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF80C057298]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF80C4BF1B0]
       mov       ecx,607F
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C6FCE40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C6FCE58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 238
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
       mov       rdx,7FF80C8A35F0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C8A3600
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C8A3610
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF80C12C240]
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
       mov       rdx,7FF80C8A3610
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8A3600
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C7C69D0]
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
       jmp       qword ptr [7FF80C7C69E8]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7C6A00]
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
       call      00007FF86BBA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2640B260008
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
       call      qword ptr [7FF80C6FEF10]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF80C047298]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF80C4AF1F8]
       mov       ecx,607F
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1D5548
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C5ED4D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C5ED4E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 238
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
       mov       rdx,7FF80C8BD3E0
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C8BD3F0
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C8BD400
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF80C11C240]
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
       mov       rdx,7FF80C8BD400
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8BD3F0
       call      qword ptr [7FF80BEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C7B70D8]
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
       jmp       qword ptr [7FF80C7B70F0]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C7B7108]
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
       call      00007FF86BBA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D88A030008
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
       call      qword ptr [7FF80C6EF6C0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SetEquals()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L02
       mov       rcx,[rcx+8]
       test      rdx,rdx
       je        short M00_L01
       cmp       [rcx],ecx
       call      qword ptr [7FF80C12B0D0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].SetEquals(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FF80C4CF180]
       mov       ecx,607F
       mov       rdx,7FF80C1F5368
       call      qword ptr [7FF80BF1F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1F5368
       call      qword ptr [7FF80BF1F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1F5368
       call      qword ptr [7FF80BF1F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BF1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C605038]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C605050]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L00
; Total bytes of code 238
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
       mov       rdx,7FF80C8DB618
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FF80C8DB628
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FF80C8DB638
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L03
M01_L08:
       mov       ecx,44
       call      qword ptr [7FF80BF1FD50]
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
       mov       rdx,7FF80C8DB638
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8DB628
       call      qword ptr [7FF80BF1F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF80C8572E8]
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
       jmp       qword ptr [7FF80C857300]
M01_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF80C857318]
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
       call      00007FF86BBA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF80BF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF80BF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19201650008
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
       call      qword ptr [7FF80C74EAC0]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71CEF0
       call      qword ptr [7FF80C7055F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6FBFD8
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705C98]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705C50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6FD5C0
       call      qword ptr [7FF80C6E56F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6DC0C0
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6E5DA0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6E5D58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C8250F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71CEF0
       call      qword ptr [7FF80C705650]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6FBFD8
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705CF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705CB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C835A08
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C72CEF0
       call      qword ptr [7FF80C715668]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C70BFD8
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C715D10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C715CC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.SymmetricExceptWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 80
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71D5B0
       call      qword ptr [7FF80C705728]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6FB8D8
       call      qword ptr [7FF80BF1F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705D58]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705D10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp+10]
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C6EC8B0
       call      qword ptr [7FF80C6D5230]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 102
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
       mov       rdx,7FF80C6C9410
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6D5860]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6D5818]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C80EC60
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C70D5C0
       call      qword ptr [7FF80C6F5740]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6EB8D8
       call      qword ptr [7FF80BF0F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C6F5D70]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C6F5D28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       mov       rax,[rax+278]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF80C82ED38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rax,[rbp+10]
       mov       rdx,[rax+280]
       mov       rax,[rbp-10]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rax,[rbp+10]
       mov       r8,[rax+278]
       mov       rcx,[rbp+10]
       mov       rdx,7FF80C71C280
       call      qword ptr [7FF80C705158]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       rdx,7FF80C6F9328
       call      qword ptr [7FF80BF2F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80C705788]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C705740]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C2FAA20]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       call      qword ptr [7FF80BEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF80C0CBF00
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L10
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rax,7FF80C0CBF00
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L14
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rcx,121AE000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,7F1541CF
       mov       r10d,0FC7F8CC4
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
       mov       rdx,7FF80C80FF18
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L23
M01_L42:
       mov       rcx,r13
       mov       rdx,7FF80C767038
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C767050
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C6EF948]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C27D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C0D7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF80BE41630
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C8]
       jne       near ptr M01_L22
       jmp       near ptr M01_L126
M01_L57:
       call      qword ptr [7FF80C6EFA68]
       int       3
M01_L58:
       call      qword ptr [7FF80BEFF498]
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
       call      qword ptr [7FF80C2A4EB0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,121C40007B8
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
       mov       rcx,121C40007C0
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
       mov       rdx,121C40007B0
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
       mov       rdx,7FF80C6DA8A0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF80C6DA8E8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF80C890120
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF80C890130
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF80C890240
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF80C890250
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF80C6DA938
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF80C8939A8
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF80C6070A0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rcx,r13
       mov       rdx,7FF80C80FDD8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rcx,r13
       mov       rdx,7FF80C7D4C50
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rcx,r13
       mov       rdx,7FF80C80FF00
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF80C4AF150]
       mov       ecx,607F
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BEFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BEFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C6ED2D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C6ED2F0]
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
       mov       rdx,7FF80C7D4C68
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7A71B0]
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
       mov       rdx,7FF80C7DD470
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C7DD470
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF80BEF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF80C7D4C68
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BEFFD50]
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
       mov       rdx,7FF80C7DD470
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C7DD470
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C4AEB38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L112:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L113:
       call      qword ptr [7FF80C4AEB38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L114:
       mov       r14,[rbp-0A0]
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r14
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF80C0D77C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF80C80FDE8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C80FDF8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L122:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L123
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L123:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF80C10B088]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF80C7A6E50]
       jmp       near ptr M01_L19
M01_L124:
       jmp       near ptr M01_L19
M01_L125:
       jmp       near ptr M01_L19
M01_L126:
       mov       rcx,rax
       mov       r11,7FF80BE41638
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
       mov       rdx,7FF80C890280
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L130:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rdx,7FF80C7BF9F8
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF80C890270
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7A7CF0]
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
       mov       rdx,7FF80C890260
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L138:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7A7D08]
       jmp       near ptr M01_L67
M01_L139:
       mov       ecx,11
       call      qword ptr [7FF80BEFF948]
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
       mov       rdx,7FF80C893998
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L143:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF80C54F7C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF80C2F7268
       call      qword ptr [7FF80BEFF228]
       mov       rcx,rax
       call      qword ptr [7FF80C6ED800]
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
       mov       r11,7FF80BE41638
       call      qword ptr [r11]
M01_L152:
       nop
       add       rsp,28
       ret
; Total bytes of code 5052
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C2FAA20]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       call      qword ptr [7FF80BEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF80C0CBF00
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L10
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rax,7FF80C0CBF00
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L14
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rcx,2487A400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L49
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,2BB57D82
       mov       r10d,0DEDCA184
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
       mov       rdx,7FF80C893F40
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L23
M01_L42:
       mov       rcx,r13
       mov       rdx,7FF80C7671F0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C767208
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C6EF930]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       call      qword ptr [7FF80C27D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C0D7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF80BE414F8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C8]
       jne       near ptr M01_L22
       jmp       near ptr M01_L126
M01_L57:
       call      qword ptr [7FF80C6EFA50]
       int       3
M01_L58:
       call      qword ptr [7FF80BEFF498]
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
       call      qword ptr [7FF80C2A4EB0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,248904007B8
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
       mov       rcx,248904007C0
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
       mov       rdx,248904007B0
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
       mov       rdx,7FF80C6DA5B0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF80C6DA5F8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF80C894118
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF80C894128
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF80C894238
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF80C894248
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF80C6DA648
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF80C8964F0
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF80C6070D0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rcx,r13
       mov       rdx,7FF80C893E00
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rcx,r13
       mov       rdx,7FF80C7E4BC8
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rcx,r13
       mov       rdx,7FF80C893F28
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF80C4AF138]
       mov       ecx,607F
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BEFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1D4FD8
       call      qword ptr [7FF80BEFF228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BEFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C6ED470]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C6ED488]
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
       mov       rdx,7FF80C7E4BE0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7972B8]
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
       mov       rdx,7FF80C801230
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C801230
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF80BEF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF80C7E4BE0
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BEFFD50]
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
       mov       rdx,7FF80C801230
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C801230
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C4AEB38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L112:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L113:
       call      qword ptr [7FF80C4AEB38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L114:
       mov       r14,[rbp-0A0]
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r14
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF80C0D77C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF80C893E10
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C893E20
       call      qword ptr [7FF80BEFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L122:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L123
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF80C0D7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L123:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF80C10B088]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF80C7970C0]
       jmp       near ptr M01_L19
M01_L124:
       jmp       near ptr M01_L19
M01_L125:
       jmp       near ptr M01_L19
M01_L126:
       mov       rcx,rax
       mov       r11,7FF80BE41500
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
       mov       rdx,7FF80C894278
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L130:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L131
       jmp       short M01_L132
M01_L131:
       mov       rdx,7FF80C7E0820
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF80C894268
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C797D50]
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
       mov       rdx,7FF80C894258
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L138:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C797D68]
       jmp       near ptr M01_L67
M01_L139:
       mov       ecx,11
       call      qword ptr [7FF80BEFF948]
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
       mov       rdx,7FF80C8964E0
       call      qword ptr [7FF80BEFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L143:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF80C54F7B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF80C2F7268
       call      qword ptr [7FF80BEFF228]
       mov       rcx,rax
       call      qword ptr [7FF80C6EDAE8]
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
       mov       r11,7FF80BE41500
       call      qword ptr [r11]
M01_L152:
       nop
       add       rsp,28
       ret
; Total bytes of code 5052
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AB80]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rax,7FF80C05ADE0
       mov       [rbp-88],rax
       lea       rax,[M01_L09]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L10
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rax,7FF80C05ADE0
       mov       [rbp-88],rax
       lea       rax,[M01_L13]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L14
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
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
       mov       rcx,286C0800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M01_L50
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0DC89D195
       mov       r10d,4B2B26B0
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
       call      qword ptr [7FF80C075020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       rdx,7FF80C8CE928
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       mov       rax,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L43:
       mov       rdx,7FF80C7912A0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C7912B8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80BF0EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L56:
       mov       rcx,rax
       mov       r11,7FF80BE51558
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       near ptr M01_L22
       jmp       near ptr M01_L123
M01_L57:
       call      qword ptr [7FF80C7B47F8]
       int       3
M01_L58:
       call      qword ptr [7FF80C127A20]
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
       call      qword ptr [7FF80C2B53F0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L70:
       mov       rdx,286C08027B0
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
       mov       rcx,286C08027B8
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
       mov       rdx,286C08027A8
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
       mov       rdx,7FF80C732050
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L61
M01_L75:
       mov       rdx,7FF80C732098
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,rdi
       mov       rdx,7FF80C8CEB00
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L63
M01_L77:
       mov       rcx,rdi
       mov       rdx,7FF80C8CEB10
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L64
M01_L78:
       mov       rcx,rdi
       mov       rdx,7FF80C8CEC20
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L65
M01_L79:
       mov       rcx,rdi
       mov       rdx,7FF80C8CEC30
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L66
M01_L80:
       mov       rdx,7FF80C7320E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L68
M01_L81:
       mov       rcx,rsi
       mov       rdx,7FF80C8CE6D8
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L69
M01_L82:
       mov       rdx,7FF80C6D3240
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L83:
       mov       rdx,7FF80C8CE7E8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L84:
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L85:
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L86:
       mov       rdx,7FF80C810820
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L87:
       mov       rdx,7FF80C8CE910
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L88:
       call      qword ptr [7FF80C4BF1F8]
       mov       ecx,607F
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E5548
       call      qword ptr [7FF80C1277B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BF07840]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C5FD4E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C5FD500]
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
       mov       rdx,7FF80C810838
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L91:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7B7B10]
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
       mov       rdx,7FF80C8C4EF0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8C4EF0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L98:
       mov       rcx,[r14+18]
       call      qword ptr [7FF80BF06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF80C810838
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C12C240]
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
       mov       rdx,7FF80C8C4EF0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8C4EF0
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C4BF030]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L111:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L112:
       call      qword ptr [7FF80C4BF030]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L113:
       mov       edx,[r13+28]
       sub       edx,[r13+30]
       mov       rcx,r14
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       call      qword ptr [7FF80BF0EE80]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdx,7FF80C8CE7F8
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8CE808
       call      qword ptr [7FF80BF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L121:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L122
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF80BF0EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L122:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF80C057250]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF80C7B7960]
       jmp       near ptr M01_L19
M01_L123:
       mov       rcx,rax
       mov       r11,7FF80BE51560
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
       mov       rdx,7FF80C8CEC60
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L128
       jmp       short M01_L129
M01_L128:
       mov       rdx,7FF80C770B68
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF80C8CEC50
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L132:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7BC120]
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
       mov       rdx,7FF80C8CEC40
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7BC138]
       jmp       near ptr M01_L67
M01_L136:
       mov       ecx,11
       call      qword ptr [7FF80C127E70]
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
       mov       rdx,7FF80C8CE6C8
       call      qword ptr [7FF80C127B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L140:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF80C5F4360]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF80C3073C8
       call      qword ptr [7FF80C1277B0]
       mov       rcx,rax
       call      qword ptr [7FF80C5FDAD0]
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
       mov       r11,7FF80BE51560
       call      qword ptr [r11]
M01_L149:
       nop
       add       rsp,28
       ret
; Total bytes of code 5003
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.ObservableListMutatingBenchmark.UnionWith()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+280]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       short M00_L01
       call      qword ptr [7FF80C30AA20]; DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L00:
       mov       rcx,[rbx+278]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
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
; Total bytes of code 104
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
       je        near ptr M01_L110
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
       je        near ptr M01_L101
       mov       ecx,[r12+28]
       sub       ecx,[r12+30]
       je        near ptr M01_L19
       mov       rax,[r12+8]
       mov       r15d,[rax+8]
       inc       ecx
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L100
M01_L07:
       mov       ecx,eax
       call      qword ptr [7FF80BF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edx,eax
M01_L08:
       cmp       edx,r15d
       jl        near ptr M01_L106
       mov       [rbp+18],rsi
       mov       r15,[r12+8]
       mov       [rbp-0C0],r15
       cmp       [r15],r15b
       mov       [rbp-50],r15
       lea       rcx,[rbp-50]
       mov       rax,7FF80C0DBF00
       mov       [rbp-90],rax
       lea       rax,[M01_L09]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L09:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L10
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       ja        near ptr M01_L103
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
       jne       near ptr M01_L102
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
       mov       rax,7FF80C0DBF00
       mov       [rbp-90],rax
       lea       rax,[M01_L13]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BA6AEE0
       call      rax
M01_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M01_L14
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       ja        near ptr M01_L105
       call      00007FF86BB39170
       cmp       dword ptr [7FF86BE639A0],0
       jne       near ptr M01_L104
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
       mov       r14,[rbp-0A8]
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
       mov       rdx,7FF80C8E45D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L23
M01_L28:
       mov       rcx,r13
       mov       rdx,7FF80C73A328
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,1F7C0C00068
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
       call      qword ptr [7FF80BF0F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF80C0E7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
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
       mov       rdx,7FF80C73A340
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
       call      qword ptr [7FF80C28D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF80C0E7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M01_L21
M01_L48:
       mov       rcx,rsi
       mov       r11,7FF80BE51938
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L22
       jmp       near ptr M01_L118
M01_L49:
       call      qword ptr [7FF80C7C4BA0]
       int       3
M01_L50:
       call      qword ptr [7FF80BF0F498]
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
       jne       near ptr M01_L119
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
       jne       near ptr M01_L120
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
       jne       near ptr M01_L128
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
       je        near ptr M01_L131
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L73
M01_L61:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L133
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L132
       mov       rcx,rax
       call      qword ptr [7FF80C2B4EB0]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToList()
       mov       rdi,rax
M01_L62:
       mov       rdx,1F7D6C00828
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L137
       mov       rax,[rbx+20]
       test      rax,rax
       jne       near ptr M01_L136
M01_L63:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Specialized.NotifyCollectionChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1F7D6C00830
       mov       r14,[rcx]
       mov       dword ptr [rsi+1C],0FFFFFFFF
       mov       dword ptr [rsi+20],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M01_L138
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
       jne       near ptr M01_L140
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L139
M01_L64:
       mov       rdx,1F7D6C00820
       mov       r8,[rdx]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.ObservableList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdx
       jne       near ptr M01_L142
       mov       rax,[rbx+18]
       test      rax,rax
       jne       near ptr M01_L141
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
       mov       rdx,7FF80C7883A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L53
M01_L67:
       mov       rdx,7FF80C7883F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L54
M01_L68:
       mov       rcx,rdi
       mov       rdx,7FF80C8E47F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L55
M01_L69:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4800
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L56
M01_L70:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4910
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L57
M01_L71:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4920
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L58
M01_L72:
       mov       rdx,7FF80C788440
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L60
M01_L73:
       mov       rcx,rsi
       mov       rdx,7FF80C8E4290
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L61
M01_L74:
       mov       rdx,7FF80C73F018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L75:
       mov       rcx,r13
       mov       rdx,7FF80C8E4410
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L76:
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L77:
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L78:
       mov       rcx,r13
       mov       rdx,7FF80C88F3C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L79:
       mov       rcx,r13
       mov       rdx,7FF80C8E45B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L20
M01_L80:
       call      qword ptr [7FF80C4BEC70]
       mov       ecx,607F
       mov       rdx,7FF80C1E4FD8
       call      qword ptr [7FF80BF0F228]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FF80C1E4FD8
       call      qword ptr [7FF80BF0F228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BF0D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FF80C1E4FD8
       call      qword ptr [7FF80BF0F228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80BF0D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C5F4F18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C5F4F30]
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
       mov       rdx,7FF80C88F3E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L83:
       mov       rdx,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF80C7C7D50]
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
       mov       rdx,7FF80C8CDE20
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
       mov       rdx,7FF80C8CDE20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L89:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M01_L02
M01_L90:
       mov       rcx,[r14+18]
       call      qword ptr [7FF80BF06358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
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
       mov       rdx,7FF80C88F3E0
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
       call      qword ptr [7FF80BF0FD50]
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
       mov       rdx,7FF80C8CDE20
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
       mov       rdx,7FF80C8CDE20
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
       jmp       near ptr M01_L110
M01_L102:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L103:
       call      qword ptr [7FF80C546148]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L104:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L105:
       call      qword ptr [7FF80C546148]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L16
M01_L106:
       mov       r14,[rbp-0A8]
       mov       edx,[r12+28]
       sub       edx,[r12+30]
       mov       rcx,r14
       call      qword ptr [7FF80C0E7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rdi,[r12+10]
       xor       r15d,r15d
       jmp       short M01_L109
M01_L107:
       cmp       r15d,[rdi+8]
       jae       near ptr M01_L143
       mov       rdx,r15
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L108
       mov       rdx,[rdx]
       lea       r8,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FF80C0E77C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
M01_L108:
       inc       r15d
M01_L109:
       cmp       r15d,[r12+28]
       jl        short M01_L107
       jmp       near ptr M01_L19
M01_L110:
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M01_L111
       jmp       short M01_L112
M01_L111:
       mov       rcx,r13
       mov       rdx,7FF80C8E4420
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L112:
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L115
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        short M01_L113
       jmp       short M01_L114
M01_L113:
       mov       rcx,r13
       mov       rdx,7FF80C8E4430
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L114:
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       jle       short M01_L115
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FF80C0E7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M01_L115:
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FF80C11B088]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r14+28],0
       jle       short M01_L117
       mov       rax,[r14+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r14+28]
       cmp       eax,3
       jle       short M01_L116
       mov       edx,[r14+28]
       sub       edx,[r14+30]
       mov       rcx,r14
       call      qword ptr [7FF80C7C7AC8]
       jmp       near ptr M01_L19
M01_L116:
       jmp       near ptr M01_L19
M01_L117:
       jmp       near ptr M01_L19
M01_L118:
       mov       rcx,rsi
       mov       r11,7FF80BE51940
       call      qword ptr [r11]
       jmp       near ptr M01_L52
M01_L119:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M01_L59
M01_L120:
       cmp       dword ptr [r15+8],0
       jne       short M01_L125
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L121
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L121
       jmp       short M01_L122
M01_L121:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4950
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L122:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L123
       jmp       short M01_L124
M01_L123:
       mov       rdx,7FF80C61B760
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L124:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax]
       jmp       near ptr M01_L59
M01_L125:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],68
       jle       short M01_L126
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L126
       jmp       short M01_L127
M01_L126:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4940
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L127:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7CC270]
       jmp       near ptr M01_L59
M01_L128:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],60
       jle       short M01_L129
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        short M01_L129
       jmp       short M01_L130
M01_L129:
       mov       rcx,rdi
       mov       rdx,7FF80C8E4930
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L130:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF80C7CC288]
       jmp       near ptr M01_L59
M01_L131:
       mov       ecx,11
       call      qword ptr [7FF80BF0F948]
       int       3
M01_L132:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M01_L62
M01_L133:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L134
       jmp       short M01_L135
M01_L134:
       mov       rcx,rsi
       mov       rdx,7FF80C8E4280
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L135:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FF80C5F71B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L62
M01_L136:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L63
M01_L137:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax]
       jmp       near ptr M01_L63
M01_L138:
       mov       ecx,433
       mov       rdx,7FF80C307268
       call      qword ptr [7FF80BF0F228]
       mov       rcx,rax
       call      qword ptr [7FF80C5F5548]
       int       3
M01_L139:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L64
M01_L140:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L64
M01_L141:
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L65
M01_L142:
       mov       rcx,rbx
       mov       rdx,r8
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L65
M01_L143:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0D0],0
       je        short M01_L144
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rsi,[rbp-0D0]
       cmp       [rsi],rcx
       je        short M01_L144
       mov       rcx,rsi
       mov       r11,7FF80BE51940
       call      qword ptr [r11]
M01_L144:
       nop
       add       rsp,28
       ret
; Total bytes of code 4621
```

